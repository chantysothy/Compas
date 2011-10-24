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

namespace Compas.AdminUI.Wares.Price
{
    public partial class PriceData : Form
    {
        string mode;
        int? wareId;
        int? id;
        ContextManager manager;
        SortableBindingList<WareView> view;

        private void FillWares()
        {
            WaresLogic wares = new WaresLogic(manager);
            
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
                SecondaryUnitQuantity = a.SecondaryUnitQuantity != null ? a.SecondaryUnitQuantity : null
            });//.OrderBy(a => a.CategoryName).ThenBy(a=> a.Name).ToList();

            if (wareId != null)
            {
                waresList = waresList.Where(a => a.ID == wareId);
            }

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
                viewList.Add(wv);
            }

            //BindingListView<WareView> view = new BindingListView<WareView>(viewList);
            //bs.DataSource = view;
            //bs.Sort = columnName;

            view = new SortableBindingList<WareView>(viewList);
            
            WareCB.DataSource = view;
            WareCB.ValueMember = "ID";
            WareCB.DisplayMember = "Name";

            

        }

        private void FillPriceGroups()
        {
            WarePriceGroupsLogic groups = new WarePriceGroupsLogic(manager);
            PriceGroupsCB.DataSource = groups.GetAll();
            PriceGroupsCB.ValueMember = "ID";
            PriceGroupsCB.DisplayMember = "Name";
        }


        private void Fill()
        {

            FillWares();
            FillPriceGroups();
            WarePricesLogic prices = new WarePricesLogic(manager);
            if (mode == "edit")
            {
                WarePrice price = prices.Get(Convert.ToInt32(id));
                if (price != null)
                {
                    int i = 0;
                    foreach (var a in WareCB.Items)
                    {
                        if (price.WareID == ((WareView)a).ID)
                        {
                            WareCB.SelectedIndex = i;
                            break;
                        }
                        i++;
                    }
                    PriceGroupsCB.SelectedItem = price.WarePriceGroup;
                    AllowDiscountCB.Checked = price.AllowDiscount;
                    PurchasePriceNUD.Value = price.PurchasePriceForUnit;
                    SalePriceNUD.Value = price.SalePriceForUnit;
                }
            }
            
        }

        public PriceData(string _mode, int? _id)
        {

            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;

            id = _id;

            wareFilterUC1.Fill();
            Fill();

        }

        public PriceData(string _mode, int? _id, int? _wareId)
        {

            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;

            id = _id;
            wareId = _wareId;
            wareFilterUC1.Fill();
            Fill();

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            WarePricesLogic prices = new WarePricesLogic(manager);

            int wareId = Convert.ToInt32(WareCB.SelectedValue);
            int warePriceGroupId = Convert.ToInt32(PriceGroupsCB.SelectedValue);
            int? documentId = null;
            bool allowDiscount = AllowDiscountCB.Checked;
            decimal purchasePriceForUnit = PurchasePriceNUD.Value;
            decimal salePriceForUnit = SalePriceNUD.Value;
            bool active = PriceActiveCB.Checked;

            if (mode == "new")
            {
                prices.Create(wareId, warePriceGroupId, documentId, allowDiscount,
                    purchasePriceForUnit, salePriceForUnit, active);
            }
            if (mode == "edit")
            {
                prices.Update(Convert.ToInt32(id), wareId, warePriceGroupId, documentId, allowDiscount,
                    purchasePriceForUnit, salePriceForUnit, active);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            FillWares();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            List<WareView> viewList = new List<WareView>();
            viewList = view.Where(a => (a.Name.ToUpper().Contains(NameTB.Text.ToUpper()) == true) || a.CategoryName.ToUpper().Contains(NameTB.Text.ToUpper())).ToList();
            SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

            WareCB.DataSource = filteredView;
            WareCB.Update();
        }
    }
}
