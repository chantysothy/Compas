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
using DgvFilterPopup;

namespace Compas.AdminUI.Wares.Ware
{
    
    public partial class WaresList : Form
    {
        
        int StructureObjectId;
        SortableBindingList<ViewWare> view;
        ContextManager manager;

        private void Fill(string columnName)
        {
            DateTime start = DateTime.Now;
            WaresLogic wares = new WaresLogic(manager);
            DataGV.AutoGenerateColumns = false;
            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            if(categoriesFilterUC1.SelectedCategoryID >= 0)
                categoryId = categoriesFilterUC1.SelectedCategoryID;
            //manufacturerId = wareFilterUC1.ManufacturerID;
            //unitId = wareFilterUC1.UnitID;
            BindingSource bs = new BindingSource();



            var waresList = wares.GetAllView("", categoryId, manufacturerId, unitId);
            //    .Select(a => new
            //{
            //    a.ID,
            //    Name = a.Name,
            //    UnitName = a.WareUnit != null ? a.WareUnit.Name : "",
            //    ManufacturerName = a.WareManufacturer != null ? a.WareManufacturer.Name : "",
            //    CategoryName = a.WareCategory != null ? a.WareCategory.Name : "",
            //    CategoryID = a.CategoryID,
            //    SecondaryUnitID = a.SecondaryUnitID != null ? a.SecondaryUnitID : null,

            //   SecondaryUnitName = a.WareUnit1 != null ? a.WareUnit1.Name : "",
            //   SecondaryUnitQuantity = a.SecondaryUnitQuantity != null ? a.SecondaryUnitQuantity : null,
            //   a.WareCodes,
            //   a.WareTimeLimits
            //});//.OrderBy(a => a.CategoryName).ThenBy(a=> a.Name).ToList();
            //List<WareView> viewList = new List<WareView>();

            DateTime start0 = DateTime.Now;
            
            //foreach (var a in waresList)
            //{
            //    WareView wv = new WareView();
            //    wv.ID = a.ID;
            //    wv.CategoryID = a.CategoryID;
            //    wv.Name = a.Name;
            //    wv.CategoryName = a.CategoryName;
            //    wv.ManufacturerName = a.ManufacturerName;
            //    wv.UnitName = a.UnitName;
            //    wv.SecondaryUnitID = a.SecondaryUnitID;
            //    wv.SecondaryUnitName = a.SecondaryUnitName;
            //    wv.SecondaryUnitQuantity = a.SecondaryUnitQuantity;
            //    //wv.WareCodes = a.WareCodes.ToList();

            //    //var lastTimeLimit = (from aa in a.WareTimeLimits
            //    //                     where aa.Active == true
            //    //                     select aa).FirstOrDefault();
            //    //if (lastTimeLimit != null)
            //    //    wv.TimeLimit = lastTimeLimit.TimeLimit;
            //    //else
            //    //    wv.TimeLimit = 0;

            //    viewList.Add(wv);
            //}
            DateTime start1 = DateTime.Now;
            //BindingListView<WareView> view = new BindingListView<WareView>(viewList);
            //bs.DataSource = view;
            //bs.Sort = columnName;

            view = new SortableBindingList<ViewWare>(waresList);
           
            ListToDataTable listToDataTable = new ListToDataTable();
            DataGV.DataSource = listToDataTable.ToDataTable<ViewWare>(waresList);
            
            //DataGV.DataSource = view;
            DataGV.Update();
            DgvFilterManager filterManager = new DgvFilterManager(DataGV);
            DateTime start2 = DateTime.Now;
            //MessageBox.Show(start.ToString() + " " + start0.ToString() + " " + start1.ToString() + " " + start2.ToString()); 
           
        }


        public void FillResultsFilter()
        {
            List<ViewWare> viewList = new List<ViewWare>();
            List<WareCode> codeList = new List<WareCode>();
            
            viewList = view.Where(a => (
                ((a.Name.ToUpper().Contains(NameTB.Text.ToUpper()) == true) || 
                a.WareCategoryName.ToUpper().Contains(NameTB.Text.ToUpper())) &
                a.WareCode.ToUpper().Contains(CodeTB.Text.ToUpper())
                
                )).ToList();

            SortableBindingList<ViewWare> filteredView = new SortableBindingList<ViewWare>(viewList);

            //DataGV.DataSource = filteredView;
           
            ListToDataTable listToDataTable = new ListToDataTable();
            DataGV.DataSource = listToDataTable.ToDataTable<ViewWare>(viewList);


            DataGV.Update();
        }

        public WaresList()
        {
            InitializeComponent();

            //створюємо контекстне меню
            //ContextMenu contextMenu = Helpers.ToolStripConverter.ToContextMenu(toolStrip1);

            

            manager = new ContextManager();
            //wareFilterUC1.Fill();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            if (allowed == true)
            {
                categoriesFilterUC1.Fill();
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
            Wares.Ware.WareData form = new Wares.Ware.WareData("new", null, categoriesFilterUC1.SelectedCategoryID);
            form.ShowDialog();
            Fill("Name");
            //wareFilterUC1.Fill();
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
            //wareFilterUC1.Fill();
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
            //int selectedIndex = DataGV.SelectedRows[0].Index;
            //Wares.Ware.WareData form = new Wares.Ware.WareData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            //form.ShowDialog();
            //manager.Save();
            //manager.CloseContext();
            //manager = new ContextManager();
            //Fill("Name");
            ////wareFilterUC1.Fill();
            //DataGV.Rows[selectedIndex].Selected = true;

            Wares.Ware.WareComponentData form = new Wares.Ware.WareComponentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
           
            form.ShowDialog();  
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

        private void label1_Click(object sender, EventArgs e)
        {

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
            //wareFilterUC1.Fill();
        }

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {
            FillResultsFilter();
        }

        private void wareFilterUC1_Load(object sender, EventArgs e)
        {

        }

        private void ComponentsSB_Click(object sender, EventArgs e)
        {
            Wares.Ware.WareComponentData form = new Wares.Ware.WareComponentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.MdiParent = this.MdiParent;
            form.Show();           
            //wareFilterUC1.Fill();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

       

        private void DataGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGV.SelectedRows[0].Cells[e.ColumnIndex].OwningColumn.Name == "PricesC")
            {
                Wares.Price.PricesList form = new Wares.Price.PricesList(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
                form.ShowDialog();
            }
            if (DataGV.SelectedRows[0].Cells[e.ColumnIndex].OwningColumn.Name == "ComponentsC")
            {
                Wares.Ware.WareComponentData form = new Wares.Ware.WareComponentData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
                form.ShowDialog();
            }
            
               
           

            if (DataGV.SelectedRows.Count > 0)
            {
                ComponentsTV.Nodes.Clear();
                int wareId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
                WareComponentsLogic componentsLogic = new WareComponentsLogic(manager);
                List<WareComponent> components = componentsLogic.GetAllRecursively(wareId, null);
                foreach (WareComponent component in components)
                {
                    ComponentsTV.Nodes.Add(component.WareID.ToString(), component.Ware1.Name + " " + component.UnitQuantity.ToString() + component.Ware1.WareUnit.Name);
                }
            }
        }

        private void AddCategorySB_Click(object sender, EventArgs e)
        {
            Wares.Category.CategoryData form = new Wares.Category.CategoryData("new", null);
            form.ShowDialog();            
            categoriesFilterUC1.Fill();
        }

        private void EditCategorySB_Click(object sender, EventArgs e)
        {
            if (categoriesFilterUC1.SelectedCategoryID != null)
            {
                Wares.Category.CategoryData form = new Wares.Category.CategoryData("edit", Convert.ToInt32(categoriesFilterUC1.SelectedCategoryID));

                form.ShowDialog();
                
            }
        }

        private void DeleteCategorySB_Click(object sender, EventArgs e)
        {
            if (categoriesFilterUC1.SelectedCategoryID != null)
            {
                WareCategoriesLogic cl = new WareCategoriesLogic(manager);
                cl.Delete(Convert.ToInt32(categoriesFilterUC1.SelectedCategoryID));
                manager.Save();
                categoriesFilterUC1.Fill();
            }
        }

        private void RefreshCategoriesSB_Click(object sender, EventArgs e)
        {
            categoriesFilterUC1.Fill();
        }

        private void categoriesFilterUC1_SelectedCategoryChanged(object sender, EventArgs e)
        {
            Fill("Name");
        }

        private void WaresList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                Wares.Ware.WareData form = new Wares.Ware.WareData("new", null, categoriesFilterUC1.SelectedCategoryID);
                form.ShowDialog();
                Fill("Name");
            }
        }

        

       
    }
}
