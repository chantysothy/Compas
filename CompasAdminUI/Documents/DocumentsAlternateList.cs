using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;
using Compas.Logic.Staff;
using Compas.Logic.Documents;
using Compas.Helpers;
using System.Globalization;
using System.IO;

using CompletIT.Windows.DataGridViewExtension;
using CompletIT.Windows.Forms.Export.Pdf;
using CompletIT.Windows.Forms.Export.Html;





namespace Compas.AdminUI.Documents

{
    public partial class DocumentsAlternateList : Form
    {
        
        int StructureObjectId;
        DataTable exportTable;
        ContextManager manager;
        DocumentsLogic documentsLogic;
        int employeeCounter = 1;//кількість виконавців

        private void FillDataTable()
        {


           



        }

        private void Fill()
        {
            int? selectedIndex = null;
            if (DataGV.SelectedRows.Count > 0)
            {
                selectedIndex = DataGV.SelectedRows[0].Index;
            }

            int? documentTypeId = null;
            string documentNumber = "";
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime? endDate = null;
            decimal? documentSum = null;

            if(documentFilterUC1.DocumentTypeID >= 0)
                documentTypeId = documentFilterUC1.DocumentTypeID;
            documentNumber = documentFilterUC1.DocumentNumber;
            startDate = universalFilter1.StartDate == null ? startDate : Convert.ToDateTime(universalFilter1.StartDate);
            endDate = universalFilter1.EndDate;
            documentSum = documentFilterUC1.DocumentSum;

            

            SortableBindingList<DocumentView> view =
                    new SortableBindingList<DocumentView>(documentsLogic.GetAllView(documentTypeId, documentNumber,
                        startDate, endDate, documentSum));
            

            
            //if (selectedIndex != null)
            //    if(DataGV.RowCount > selectedIndex)
            //     DataGV.Rows[Convert.ToInt32(selectedIndex)].Selected = true;

            DataTable table = new DataTable();


            table.Columns.Add("Дата", typeof(DateTime));
            table.Columns.Add("Адреса", typeof(string));
            
            WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            Compas.Logic.Documents.DocumentDetailsLogic detailsLogic = new DocumentDetailsLogic(manager);
            DocumentStaffDetailsLogic staffLogic = new DocumentStaffDetailsLogic(manager);
            WaresLogic waresLogic = new WaresLogic(manager);

            //Спочатку визначаємо яку категорію номенклатури нам необхідно проаналізувати
            int viewCategoryId = Convert.ToInt32(ViewCategoriesLUE.EditValue);

            List<WareCategory> categories = categoriesLogic.GetAllRoot().Where(a => a.ID != viewCategoryId).ToList();
            foreach (WareCategory category in categories)
            {
                table.Columns.Add(category.Name, typeof(string));
                
            }

            table.Columns.Add("Акт №", typeof(string));
            table.Columns.Add("Сума", typeof(decimal));
            table.Columns.Add("К-ть робіт", typeof(decimal));
            table.Columns.Add("К-ть виконавців", typeof(int));
            table.Columns.Add("К-ть на вик.", typeof(int));
            

            table.Columns.Add("Виконавець1", typeof(string));
            table.Columns.Add("Виконавець2", typeof(string));
            table.Columns.Add("Виконавець3", typeof(string));
            table.Columns.Add("Виконавець4", typeof(string));

            //Основні матеріали(номенклатура, включена в документ)
            
            List<WareCategory> viewCategories = categoriesLogic.GetAllChilds(viewCategoryId);
            //спочатку вкладені підкатегорії
            foreach (WareCategory category in viewCategories)
            {
                table.Columns.Add(category.Name, typeof(string));
            }
            //тоді номенклатурні одиниці даної категорії(без підкатегорій)
            List<Ware> wares = waresLogic.GetAll(viewCategoryId);
            //кожна номенклатурна одиниця - окрема колонка
            foreach (Ware ware in wares)
            {
                table.Columns.Add(ware.Name, typeof(decimal));
            }

            table.Columns.Add("Коментарі", typeof(string));



            categories = categoriesLogic.GetAllRoot().Where(a => a.ID != viewCategoryId).ToList();
            foreach (DocumentView document in view)
            {

                DataRow row = table.NewRow();
                row["Дата"] = document.Date;
                row["Адреса"] = "Адреса надання послуги";
                row["Акт №"] = document.Number;
                row["Сума"] = document.DocumentSum;
                
                row["К-ть виконавців"] = 0;
                row["К-ть на вик."] = 0;
                

                int counter = 0;
                //виводимо категорії по колонкам
                foreach (WareCategory category in categories)
                {
                    string detailsList = "";
                    List<WareDocumentDetail> details = detailsLogic.GetAllByWareCategory(startDate, endDate, category.ID, document.ID).Where(a => a.Ware.CategoryID != viewCategoryId).ToList();
                    
                    foreach (WareDocumentDetail detail in details)
                    {
                        if (detailsList.Length > 0)
                            detailsList = detailsList + ";\n";
                        //стрічка містить перелік номенклатурних одиниць в межах категорії
                        detailsList = detailsList + detail.Ware.Name;
                        counter++;
                    }

                    if (row[category.Name] != null)
                    {
                        row[category.Name] = detailsList;
                    }
                }
                row["К-ть робіт"] = counter;



                //Працівники повязані з даним документом
                

                List<StaffEmployee> staffEmployees = staffLogic.GetStaffEmployeesByDocumentID(document.ID);

                counter = 1;
               

                string fullName = "";

                foreach (StaffEmployee employee in staffEmployees)
                {

                    fullName = employee.LastName + " " + employee.FirstName + " " + employee.MiddleName;

                    if (counter < 4)
                        row["Виконавець" + counter.ToString()] = fullName;
                    else
                        row["Виконавець" + counter.ToString()] = row["Виконавець" + counter.ToString()] + "; " + fullName;


                    counter = counter + 1;
                }


                //номенклатурні одиниці, пов'язані з документом

                string viewCategoryDetailsList = "";
                decimal startViewCounter = 0;
                List<WareDocumentDetail> viewCategoryDetailsAll = detailsLogic.GetAllByWareCategory(startDate, endDate, viewCategoryId, document.ID);
                List<WareDocumentDetail> viewCategoryDetails = viewCategoryDetailsAll.Where(a => a.Ware.CategoryID == viewCategoryId).ToList();

                foreach (WareDocumentDetail detail in viewCategoryDetails)
                {                     
                    row[detail.Ware.Name] = startViewCounter + detail.UnitQuantity;                   
                }

                //тепер заповнюємо перелік по підкатегоріям
                List<WareDocumentDetail> viewNotCategoryDetails = viewCategoryDetailsAll.Where(a => a.Ware.CategoryID != viewCategoryId).ToList();

                
                foreach (WareCategory category in viewCategories)
                {
                    string waresList = "";
                    List<WareDocumentDetail> details = detailsLogic.GetAllByWareCategory(startDate, endDate, category.ID, document.ID);
                    foreach (WareDocumentDetail detail in details)
                    {
                        waresList = waresList + detail.Ware.Name + ";\n";
                    }
                    row[category.Name] = waresList;
                }

                row["Коментарі"] = document.Description;

                table.Rows.Add(row);
            }

            DataGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGV.AllowUserToResizeColumns = true;
            DataGV.AutoGenerateColumns = true;
            DataGV.DataSource = table;
            DataGV.Columns["Коментарі"].DisplayIndex = DataGV.Columns.Count - 1;
            DataGV.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DataGV.Update();
            

            exportTable = table;
        }

        public DocumentsAlternateList()
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");
            


            if (allowed == true)
            {
                documentFilterUC1.Fill();
                universalFilter1.Fill();
                documentsLogic = new DocumentsLogic(manager);
                WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);

                BindingList<ItemIntValue> categories = categoriesLogic.GetCategoriesHierarchy();
                ViewCategoriesLUE.Properties.ValueMember = "ID";
                ViewCategoriesLUE.Properties.DisplayMember = "Name";
                ViewCategoriesLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва категорії"));
                ViewCategoriesLUE.Properties.DataSource = categories;
                Fill();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

           

        }

        private void NewSB_Click(object sender, EventArgs e)
        {

            DocumentData form = new DocumentData("new", null,null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            DocumentData form = new DocumentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();            
            manager = new ContextManager();
            documentsLogic = new DocumentsLogic(manager);
            
            Fill();
            
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
           
            documentsLogic.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void DataGV_DoubleClick(object sender, EventArgs e)
        {
            if (DataGV.SelectedRows.Count > 0)
            {
                DocumentData form = new DocumentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
                form.ShowDialog();
                manager.Save();
                manager.CloseContext();
                manager = new ContextManager();
                documentsLogic = new DocumentsLogic(manager);

                Fill();
            }
        }

        private void ApplyFilterBt_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void RefreshSB_Click(object sender, EventArgs e)
        {
            documentFilterUC1.Fill();
            universalFilter1.Fill();
            Fill();
        }

        private void universalFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ExcelMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToExcelExtended(exportTable, this.Name);
        }

        private void PDFMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToPDF(DataGV, this.Name);
        }

        private void HTMLMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToHTML(DataGV, this.Name);
        }

        private void ExportSB_ButtonClick(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToExcelExtended(exportTable, this.Name);
            
        }

       
    }
}
