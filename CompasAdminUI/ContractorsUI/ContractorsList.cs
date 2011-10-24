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
using Compas.Logic.Contractors;
using Compas.Helpers;

using System.Globalization;
using System.IO;

using CompletIT.Windows.DataGridViewExtension;
using CompletIT.Windows.Forms.Export.Pdf;
using CompletIT.Windows.Forms.Export.Html;

namespace Compas.AdminUI.ContractorsUI

{
    public partial class ContractorsList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;
        SortableBindingList<ContractorView> view;
        private void Fill()
        {

            ContractorsLogic contractors = new ContractorsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            List<Contractor> resultA = contractors.GetAll();
            List<ContractorView> contractorsView = new List<ContractorView>();
            foreach (Contractor a in resultA)
            {
                ContractorView c = new ContractorView(a,manager);  
                contractorsView.Add(c);
            }
            view = new SortableBindingList<ContractorView>(contractorsView);
            DataGV.DataSource = view;
            DataGV.AutoResizeRows();
            DataGV.Update();

            PersonCB.SelectedIndex = 0;
            ContractorTypesDDL.Items.Clear();
            ContractorTypesLogic types = new ContractorTypesLogic(manager);
            ContractorTypesDDL.DisplayMember = "Name";
            ContractorTypesDDL.ValueMember = "ID";
            ContractorType all = new ContractorType();
            all.ID = -1;
            all.Name = " - всі - ";
            ContractorTypesDDL.Items.Add(all);
            foreach (var a in types.GetAll())
            {
                ContractorTypesDDL.Items.Add(a);
            }
            ContractorTypesDDL.SelectedIndex = 0;
            
           
            
        }

        private void FillFilter()
        {
            List<ContractorView> viewList = new List<ContractorView>();
            viewList = view.Where(a => (
                (a.LastName.ToUpper().Contains(LastNameTB.Text.ToUpper()) == true) &
                a.FirstName.ToUpper().Contains(FirstNameTB.Text.ToUpper()) &
                a.MiddleName.ToUpper().Contains(MiddleNameTB.Text.ToUpper())
                ) 
                &                
                a.City.ToUpper().Contains(CityTB.Text.ToUpper()) &
                a.Street.ToUpper().Contains(StreetTB.Text.ToUpper()) &
                a.Building.ToUpper().Contains(BuildingTB.Text.ToUpper()) &
                a.Flat.ToUpper().Contains(FlatTB.Text.ToUpper()) &
                ((PersonCB.SelectedIndex == 0) || ((PersonCB.SelectedIndex == 1) & (a.Person == false)) || ((PersonCB.SelectedIndex == 2) & (a.Person == true))) &
                (ContractorTypesDDL.SelectedIndex == 0 || a.ContractorTypesObjectsList.Contains((ContractorType)(ContractorTypesDDL.SelectedItem))) 
                ).ToList();
            SortableBindingList<ContractorView> filteredView = new SortableBindingList<ContractorView>(viewList);

            DataGV.DataSource = filteredView;
            DataGV.Update();
        }

        public ContractorsList()
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            if (allowed == true)
            {
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

            ContractorsUI.ContractorData form = new ContractorsUI.ContractorData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            ContractorsUI.ContractorData form = new ContractorsUI.ContractorData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ContractorsLogic wares = new ContractorsLogic(manager);
            wares.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void CityTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void StreetTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void FirstNameTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void MiddleNameTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void ClientsCB_CheckedChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void ProvidersCB_CheckedChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void EmployeesCB_CheckedChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void BuildingTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void FlatTB_TextChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void DataGV_DoubleClick(object sender, EventArgs e)
        {
            ContractorsUI.ContractorData form = new ContractorsUI.ContractorData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void ContractorTypesDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFilter();
        }

        private void RefreshSB_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void DataGV_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            if (index > 0)
            {
                DataGV.ClearSelection();
                DataGV.Rows[index].Selected = true;
            }
        }

        private void PersonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFilter();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
