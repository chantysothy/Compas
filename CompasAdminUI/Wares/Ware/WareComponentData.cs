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
using Compas.Helpers;

namespace Compas.AdminUI.Wares.Ware
{
    public partial class WareComponentData : Form
    {
        string mode;
        bool columnsCreated = false;
        int? id;
        ContextManager manager;
        private void Fill()
        {
            

            if (mode == "edit")
            {
                WaresLogic waresLogic = new WaresLogic(manager);
                Model.Ware ware = waresLogic.Get(Convert.ToInt32(id));
                WareNameL.Text = ware.Name;               
               
            }

        }
        SortableBindingList<WareView> view;


        private void FillComponentWareUnits(int ComponentWareID)
        {
            //WaresLogic waresLogic = new WaresLogic(manager);
            //Compas.Model.Ware ware = waresLogic.Get(Convert.ToInt32(ComponentWareID));
            //UnitsRG.Properties.Items.Clear();
            //if (ware != null)
            //{ 
                
            //    DevExpress.XtraEditors.Controls.RadioGroupItem item0 = new DevExpress.XtraEditors.Controls.RadioGroupItem(ware.UnitID, ware.WareUnit.Name);
            //    UnitsRG.Properties.Items.Add(item0);
            //    UnitsRG.SelectedIndex = 0;
            //    if(ware.SecondaryUnitID != null)
            //    {
            //        DevExpress.XtraEditors.Controls.RadioGroupItem item1 = new DevExpress.XtraEditors.Controls.RadioGroupItem(ware.SecondaryUnitID, ware.WareUnit1.Name);
            //        UnitsRG.Properties.Items.Add(item1);
            //    }
            //}
        }

        private void FillComponentWares()
        {
            
            ContextManager manager0 = new ContextManager();
            WareComponentsLogic wareComponentsLogic = new WareComponentsLogic(manager0);
            WareComponentsGV.AutoGenerateColumns = false;
            List<WareComponentView> components = wareComponentsLogic.GetAllView(Convert.ToInt32(id));
            WareComponentsGV.ClearSelection();
            //WareComponentsGV.Rows.Clear();
            WareComponentsGV.DataSource = null;
            
            WareComponentsGV.Rows.Clear();
            SortableBindingList<WareComponentView> view = new SortableBindingList<WareComponentView>(components);

            WareComponentsGV.DataSource = view;

        }

        private void FillFilteredWares(string columnName)
        {
            WaresLogic wares = new WaresLogic(manager);
          
            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            if(categoriesUC1.SelectedCategoryID >= 0)
                categoryId = categoriesUC1.SelectedCategoryID;
            //manufacturerId = wareFilterUC1.ManufacturerID;
            //unitId = wareFilterUC1.UnitID;
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
            WareLUE.Properties.DataSource = view;
           


        }

        private void FillWares()
        {
            WaresLogic wares = new WaresLogic(manager);

            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            if (categoriesUC1.SelectedCategoryID >= 0)
                categoryId = categoriesUC1.SelectedCategoryID;
            //manufacturerId = wareFilterUC1.ManufacturerID;
            //unitId = wareFilterUC1.UnitID;
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

            WareLUE.Properties.DataSource = view;

            if (columnsCreated == false)
            {
                WareLUE.Properties.ValueMember = "ID";
                WareLUE.Properties.DisplayMember = "Name";


                //WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WareCodesString", 0, "Код"));
                WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва"));
                //WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ManufacturerName", 0, "Виробник"));
                //WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", 0, "Осн. од. вим."));
               // WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SecondUnitName", 0, "втор. од. вим."));
                WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", 0, "Категорія"));

                columnsCreated = true;
            }

        }



        public WareComponentData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            //FillWares();
            categoriesUC1.Fill();
            categoriesUC1.ExpandAll();
            FillComponentWares();
            
            //wareFilterUC1.Fill();
            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            //WareUnitsLogic units = new WareUnitsLogic(manager);

            if (mode == "new")
            {
                //units.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                //units.Update(Convert.ToInt32(id), NameTB.Text);
            }
            manager.Save();

            this.Close();
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WareLUE_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            List<WareView> viewList = new List<WareView>();
            viewList = view.Where(a => (a.Name.ToUpper().Contains(NameTB.Text.ToUpper()) == true) || a.CategoryName.ToUpper().Contains(NameTB.Text.ToUpper())).ToList();
            SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

            WareLUE.Properties.DataSource = filteredView;
            if (filteredView.Count > 0)
                WareLUE.ItemIndex = 0;
        }

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {
            //фільтруємо по коду
            if (CodeTB.Text.Length > 0)
            {
                List<WareView> viewList = new List<WareView>();
                if (CodeTB.Text.Length > 0)
                    viewList = view.Where(a => a.WareCodesStringForSearch.StartsWith("<" + CodeTB.Text))
                        .ToList();
                else
                    viewList = view.ToList();
                SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

                WareLUE.Properties.DataSource = filteredView;
                if (filteredView.Count > 0)
                    WareLUE.ItemIndex = 0;
            }
            else
            {
                List<WareView> viewList = new List<WareView>();
                viewList = view.ToList();
                SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

                WareLUE.Properties.DataSource = filteredView;
                if (filteredView.Count > 0)
                    WareLUE.ItemIndex = 0;
            }
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            FillFilteredWares("Name");
        }

        private void AddComponentBt_Click(object sender, EventArgs e)
        {
            int wareId = Convert.ToInt32(id);
            int componentWareId = Convert.ToInt32(WareLUE.EditValue);
            decimal unitQuantity = 0;
            decimal secondaryUnitQuantity = 0;
            if(UnitQuantityTB.EditValue.ToString().Trim().Length>0)
                unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //if (UnitsRG.Properties.Items.Count == 1)
            //{
            //    unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //}
            //if (UnitsRG.Properties.Items.Count == 2)
            //{
            //    if(UnitsRG.SelectedIndex == 0)
            //        unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //    if (UnitsRG.SelectedIndex == 1)
            //        unitQuantity = Convert.ToDecimal(UnitQuantityTB.EditValue);
            //}
            
            WareComponentsLogic wareComponentsLogic = new WareComponentsLogic(manager);
            wareComponentsLogic.Create(wareId, componentWareId, unitQuantity, secondaryUnitQuantity);
            manager.Save();
            FillComponentWares();
        }

        private void DeleteComponentBt_Click(object sender, EventArgs e)
        {
            if (WareComponentsGV.SelectedRows.Count > 0)
            {
                int wareComponentId = Convert.ToInt32(WareComponentsGV.SelectedRows[0].Cells["WareComponentID"].Value);
                WareComponentsLogic wareComponentsLogic = new WareComponentsLogic(manager);
                wareComponentsLogic.Delete(wareComponentId);
                manager.Save();
                manager.CloseContext();
                manager = new ContextManager();
                FillComponentWares();
            }
        }

        private void UnitQuantityTB_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void SecondaryUnitQuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void WareLUE_EditValueChanged(object sender, EventArgs e)
        {
            if(WareLUE.EditValue != null)
             FillComponentWareUnits(Convert.ToInt32(WareLUE.EditValue));
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoriesUC1_SelectedCategoryChanged(object sender, EventArgs e)
        {
            FillWares();
        }

       
    }
}
