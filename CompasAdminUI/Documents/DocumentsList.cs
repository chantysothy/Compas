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
using Compas.Logic.Documents;
using Compas.Helpers;
using Compas.CashRegisters;

using System.Globalization;
using System.IO;

using CompletIT.Windows.DataGridViewExtension;
using CompletIT.Windows.Forms.Export.Pdf;
using CompletIT.Windows.Forms.Export.Html;



namespace Compas.AdminUI.Documents

{
    public partial class DocumentsList : Form
    {
        
        int StructureObjectId;
        CashRegister cashRegister;
        ContextManager manager;
        DocumentsLogic documentsLogic;

        private void Fill()
        {
            documentsLogic = new DocumentsLogic(manager);
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
            int? wareId = universalFilter1.WareID;
            int? categoryId = universalFilter1.WareCategoryID;
            int? stateId = universalFilter1.StateID;

            SortableBindingList<DocumentView> view =
                    new SortableBindingList<DocumentView>(documentsLogic.GetAllView(documentTypeId, documentNumber,
                        startDate, endDate, documentSum, wareId, categoryId, stateId));

            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = view;
            DataGV.Update();

            decimal summaryDocSum = 0;
            decimal summaryPayments = 0;
            foreach (DocumentView v in view)
            {
                summaryDocSum = summaryDocSum + v.DocumentSum;
                summaryPayments = summaryPayments + v.PaySum;
            }

            SummaryL.Text = "Сума под документам: " + summaryDocSum.ToString("n2") + "     Сума оплат: " + summaryPayments.ToString("n2");

            if (selectedIndex != null)
                if (DataGV.RowCount > selectedIndex)
                    DataGV.Rows[Convert.ToInt32(selectedIndex)].Selected = true;

            foreach (DataGridViewRow r in DataGV.Rows)
            {
                if (r.Cells["DocumentSum"].Value.ToString() != r.Cells["PaySum"].Value.ToString())
                {
                    r.DefaultCellStyle.BackColor = Color.Yellow;
                    //foreach (DataGridViewCell c in r.Cells)
                    //{ 
                    //c.d
                    //}
                }

            }
        }

        public DocumentsList(CashRegister _CashRegister)
        {
            InitializeComponent();
            cashRegister = _CashRegister;
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("DocumentsList");
            
            if (allowed == true)
            {
                documentFilterUC1.Fill();
                universalFilter1.Fill();
                documentsLogic = new DocumentsLogic(manager);
                Fill();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

            //this.DataGV.CellPainting += new
            //     DataGridViewCellPaintingEventHandler(DataGV_CellPainting);

        }

//        void DataGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
//        {
//            int sum = 0;
//            // only draw the cells of the extra row by ourselves, leaving 
//            //the rest cells to the system
//            if (e.RowIndex == this.DataGV.NewRowIndex &&
// e.ColumnIndex > -1)
//            {
//                for (int i = 0; i < this.DataGV.NewRowIndex; i++)
//                {
//                    if
//(this.DataGV.Rows[i].Cells[e.ColumnIndex].Value.ToString().Trim() !=
//"")
//                    {
//                        sum +=
// (int)this.DataGV.Rows[i].Cells[e.ColumnIndex].Value;
//                    }
//                }
//                e.PaintBackground(e.CellBounds, false);
//                e.Graphics.DrawString(sum.ToString(),
// this.DataGV.Font, Brushes.Black, e.CellBounds.Left +
// 2, e.CellBounds.Top + 2);

//                e.Handled = true;
//            }
//        }

        private void NewSB_Click(object sender, EventArgs e)
        {

            DocumentData form = new DocumentData("new", null, cashRegister);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            DocumentData form = new DocumentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), cashRegister);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();            
            manager = new ContextManager();
            documentsLogic = new DocumentsLogic(manager);
            
            Fill();
            
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            DocumentStatesLogic documentStatesLogic = new DocumentStatesLogic(manager);
            documentStatesLogic.Create(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), 3, DateTime.Now);
            //documentsLogic.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void DataGV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void ApplyFilterBt_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void RefreshSB_Click(object sender, EventArgs e)
        {
            documentFilterUC1.Fill();
            universalFilter1.Fill();
            //manager.CloseContext();
            //manager = new ContextManager();
            Fill();
        }

        private void universalFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ExcelMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToExcel(DataGV, this.Name);
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
            Helpers.DataGridExport.ExportToExcel(DataGV, this.Name);
        }

        private void DataGV_ParentChanged(object sender, EventArgs e)
        {

        }

        private void DataGV_DoubleClick_1(object sender, EventArgs e)
        {
            DocumentData form = new DocumentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), cashRegister);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            documentsLogic = new DocumentsLogic(manager);
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void PaymentsSB_Click(object sender, EventArgs e)
        {
            int? documentId = null;
            if (DataGV.SelectedRows.Count > 0)
            {
                documentId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
            }

            PaymentsList form = new PaymentsList(documentId);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DocumentsList_Load(object sender, EventArgs e)
        {

        }

        private void AddPaymentSB_Click(object sender, EventArgs e)
        {
            int? documentId = null;
            if (DataGV.SelectedRows.Count > 0)
            {
                documentId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
            }
            if (documentId != null)
            {
                DocumentPaymentData form = new DocumentPaymentData(Convert.ToInt32(documentId), cashRegister);
                form.WindowState = FormWindowState.Normal;
                form.ShowDialog();
                manager.Save();
                manager.CloseContext();
                manager = new ContextManager();
                Fill();
            }
        }

       
    }
}
