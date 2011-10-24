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
    public partial class PricesList : Form
    {
        
        int? wareId;
        
        ContextManager manager;
        SortableBindingList<PricesView> view;

        private void FillFilter()
        {
            List<PricesView> viewList = new List<PricesView>();
            viewList = view.Where(a => (universalFilter1.WareID == null || a.WareID == universalFilter1.WareID)).ToList();
            SortableBindingList<PricesView> filteredView = new SortableBindingList<PricesView>(viewList);

            DataGV.DataSource = filteredView;
            DataGV.Update();
        }

        private void Fill()
        {

            WarePricesLogic prices = new WarePricesLogic(manager);
            var pricesList = prices.GetAll(wareId).Select(a => new
            {
                a.ID,
                a.WareID,
                a.WarePriceGroupID,
                a.DocumentID,
                a.AllowDiscount,
                a.PurchasePriceForUnit,
                a.SalePriceForUnit,
                a.Active,
                a.Ware.Name,
                UnitID = a.Ware.UnitID,
                UnitName = a.Ware.WareUnit == null ? "" : a.Ware.WareUnit.Name,
                CategoryID = a.Ware.CategoryID,
                CategoryName = a.Ware.WareCategory == null ? "" : a.Ware.WareCategory.Name,
                WarePriceGroupName = a.WarePriceGroup == null ? "" : a.WarePriceGroup.Name,
                ManufacturerName = a.Ware.WareManufacturer == null ? "" : a.Ware.WareManufacturer.Name,
                ManufacturerID = a.Ware.ManufacturerID
            });

            view = new SortableBindingList<PricesView>();


            //var waresList = wares.GetAll(name, categoryId, manufacturerId, unitId).Select(a => new
            //{
            //    a.ID,
            //    Name = a.Name,
            //    UnitName = a.WareUnit != null ? a.WareUnit.Name : "",
            //    ManufacturerName = a.WareManufacturer != null ? a.WareManufacturer.Name : "",
            //    CategoryName = a.WareCategory != null ? a.WareCategory.Name : ""
            //});//.OrderBy(a => a.CategoryName).ThenBy(a=> a.Name).ToList();

            foreach (var a in pricesList)
            {
                PricesView pv = new PricesView();
                pv.ID = a.ID;
                pv.WareName = a.Name;
                pv.CategoryID = a.CategoryID;
                pv.CategoryName = a.CategoryName;
                pv.ManufacturerName = a.ManufacturerName;
                pv.UnitName = a.UnitName;
                pv.DocumentID = a.DocumentID;
                pv.ManufacturerID = a.ManufacturerID;
                
                pv.PurshasePriceForUnit = a.PurchasePriceForUnit;
                pv.SalePriceForUnit = a.SalePriceForUnit;
                pv.UnitID = a.UnitID;
                pv.UnitName = a.UnitName;
                pv.WareID = a.WareID;
                pv.WarePriceGroupID = a.WarePriceGroupID;
                pv.WarePriceGroupName = a.WarePriceGroupName;

                pv.AllowDiscount = a.AllowDiscount;
                pv.Active = a.Active;
                view.Add(pv);
            }

            //BindingListView<WareView> view = new BindingListView<WareView>(viewList);
            //bs.DataSource = view;
            //bs.Sort = columnName;

            //SortableBindingList<PricesView> viewList = new SortableBindingList<PricesView>(view);
            DataGV.DataSource = view;
            DataGV.Update();

        }

        public PricesList(int? _wareId)
        {
            InitializeComponent();
            wareId = _wareId;
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");
            

            if (allowed == true)
            {
                universalFilter1.Fill();
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
            Wares.Price.PriceData form;
            if(wareId == null)
               form = new Wares.Price.PriceData("new", null);
            else
               form = new Wares.Price.PriceData("new", null, wareId);

            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Wares.Price.PriceData form = new Wares.Price.PriceData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WarePricesLogic prices = new WarePricesLogic(manager);
            prices.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void DataGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            if (index > 0)
            {
                DataGV.ClearSelection();
                DataGV.Rows[index].Selected = true;
            }
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
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

        private void OkBt_Click(object sender, EventArgs e)
        {
            FillFilter();
        }

       
    }
}
