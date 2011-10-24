using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CompletIT.Windows.DataGridViewExtension;
using CompletIT.Windows.DataGridViewExtension.Persistence;
using CompletIT.Windows.DataGridViewExtension.Persistence.Xml;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;
using Compas.Helpers;

namespace Compas.AdminUI.Wares
{
    
    public partial class ComponentsList : Form
    {
        
        int StructureObjectId;
        SortableBindingList<WareView> view;
        ContextManager manager;

        private void Fill(string columnName)
        {
            WaresLogic wares = new WaresLogic(manager);
            DataGV.AutoGenerateColumns = false;
            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            categoryId = wareFilterUC1.CategoryID;
            manufacturerId = wareFilterUC1.ManufacturerID;
            unitId = wareFilterUC1.UnitID;
            BindingSource bs = new BindingSource();



            var waresList = wares.GetAll("", categoryId, manufacturerId, unitId).Select(a => new
            {
                a.ID,
                Name = a.Name,
                UnitName = a.WareUnit != null ? a.WareUnit.Name : "",
                ManufacturerName = a.WareManufacturer != null ? a.WareManufacturer.Name : "",
                CategoryName = a.WareCategory != null ? a.WareCategory.Name : "",
                SecondaryUnitID = a.SecondaryUnitID != null ? a.SecondaryUnitID : null,

               SecondaryUnitName = a.WareUnit1 != null ? a.WareUnit1.Name : "",
               SecondaryUnitQuantity = a.SecondaryUnitQuantity != null ? a.SecondaryUnitQuantity : null,
               a.WareCodes
            });//.OrderBy(a => a.CategoryName).ThenBy(a=> a.Name).ToList();
            List<WareView> viewList = new List<WareView>();
            foreach (var a in waresList)
            {
                WareView wv = new WareView();
                wv.ID = a.ID;
                wv.Name = a.Name;
                wv.CategoryName = a.CategoryName;
                wv.ManufacturerName = a.ManufacturerName;
                wv.UnitName = a.UnitName;
                wv.SecondaryUnitID = a.SecondaryUnitID;
                wv.SecondaryUnitName = a.SecondaryUnitName;
                wv.SecondaryUnitQuantity = a.SecondaryUnitQuantity;
                wv.WareCodes = a.WareCodes.ToList();
                viewList.Add(wv);
            }
            
            //BindingListView<WareView> view = new BindingListView<WareView>(viewList);
            //bs.DataSource = view;
            //bs.Sort = columnName;
            
            view = new SortableBindingList<WareView>(viewList);
            DataGV.DataSource = view;
            DataGV.Update();

           
        }


        public void FillResultsFilter()
        {
            List<WareView> viewList = new List<WareView>();
            List<WareCode> codeList = new List<WareCode>();
            
            viewList = view.Where(a => (
                ((a.Name.ToUpper().Contains(NameTB.Text.ToUpper()) == true) || 
                a.CategoryName.ToUpper().Contains(NameTB.Text.ToUpper())) &
                a.WareCodesString.ToUpper().Contains(CodeTB.Text.ToUpper())
                
                )).ToList();
            SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

            DataGV.DataSource = filteredView;
            DataGV.Update();
        }

        public ComponentsList()
        {
            InitializeComponent();

            //створюємо контекстне меню
            //ContextMenu contextMenu = Helpers.ToolStripConverter.ToContextMenu(toolStrip1);
            wareFilterUC1.SetFieldsWidth(175);
            

            manager = new ContextManager();
            wareFilterUC1.Fill();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            if (allowed == true)
            {
                Fill("Name");
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            Wares.Ware.WareData form = new Wares.Ware.WareData("new", null, null);
            form.ShowDialog();
            Fill("Name");
            wareFilterUC1.Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            int selectedIndex = DataGV.SelectedRows[0].Index;
            Wares.Ware.WareData form = new Wares.Ware.WareData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill("Name");
            wareFilterUC1.Fill();
            DataGV.Rows[selectedIndex].Selected = true;
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WaresLogic wares = new WaresLogic(manager);
            wares.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill("Name");
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            
            Fill("Name");
        }

        private void DataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OkBt_Click_1(object sender, EventArgs e)
        {
            Fill("Name");
        }

        private void DataGV_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = DataGV.SelectedRows[0].Index;
            Wares.Ware.WareData form = new Wares.Ware.WareData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill("Name");
            wareFilterUC1.Fill();
            DataGV.Rows[selectedIndex].Selected = true;
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

        private void DataGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right)
            //{
            //    DataGV.ClearSelection();
            //    DataGV.Rows[e.RowIndex].Selected = true;
            //    Rectangle r = DataGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            //    DataGVContextMenu.Show((Control)sender, r.Left + e.X, r.Top + e.Y);
            //}
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

            FillResultsFilter();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void PricesSB_Click(object sender, EventArgs e)
        {
            Wares.Price.PricesList form = new Wares.Price.PricesList(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.MdiParent = this.MdiParent;
            form.Show();
            Fill("Name");
            wareFilterUC1.Fill();
        }

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {
            FillResultsFilter();
        }

        

       
    }
}
