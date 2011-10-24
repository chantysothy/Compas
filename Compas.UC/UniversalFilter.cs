using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;
using Compas.Logic.Staff;
using Compas.Logic.Documents;
using Compas.Helpers;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Compas.UC
{
    public partial class UniversalFilter : UserControl
    {
        ContextManager manager;
        SortableBindingList<WareView> view;

        /// <summary>
        /// Значення що повертаються
        /// </summary>
        #region PublicProperties
        public int? StructureObjectID
        {
            get  
            { 
                int? result =  null;
                if(StructureObjectsLUE.EditValue != null)
                {
                    result = Convert.ToInt32(StructureObjectsLUE.EditValue);
                }
                return result;
            }
        }

        public DateTime? StartDate
        {
            get
            {
                DateTime? result = null;
                if (StartDateDE.EditValue != null)
                {
                    result = Convert.ToDateTime(StartDateDE.EditValue);
                }
                return result;
            }
        }

        public DateTime? EndDate
        {
            get
            {
                DateTime? result = null;
                if (EndDateDE.EditValue != null)
                {
                    result = Convert.ToDateTime(EndDateDE.EditValue);
                }
                return result;
            }
        }

        public int? WareID
        {
            get
            {
                int? result = null;
                if (WaresLUE.EditValue != null)
                {
                    result = Convert.ToInt32(WaresLUE.EditValue);
                }
                return result;
            }
        }

        public int? WareCategoryID
        {
            get
            {
                int? result = null;
                if (WareCategoriesLUE.EditValue != null)
                {
                    result = Convert.ToInt32(WareCategoriesLUE.EditValue);
                }
                return result;
            }
        }

        public int? StateID
        {
            get
            {
                int? result = null;
                if (StatesCB.SelectedIndex > 0)
                {
                    result = Convert.ToInt32(((Helpers.ItemIntValue)(StatesCB.Items[StatesCB.SelectedIndex])).ID);
                }
                return result;
            }
        }

        public string WareCode
        {
            get
            {
                string result = null;
                if (WareCodeTE.EditValue != null)
                {
                    result = Convert.ToString(WareCodeTE.EditValue);
                }
                return result;
            }
        }

        public string WareName
        {
            get
            {
                string result = null;
                if (WareNameTE.EditValue != null)
                {
                    result = Convert.ToString(WareNameTE.EditValue);
                }
                return result;
            }
        }

        public int? WareUnitTypeID
        {
            get
            {
                int? result = null;
                if (UnitLUE.EditValue != null)
                {
                    result = Convert.ToInt32(UnitLUE.EditValue);
                }
                return result;
            }
        }

        public int? CurrencyID
        {
            get
            {
                int? result = null;
                if (CurrencyLUE.EditValue != null)
                {
                    result = Convert.ToInt32(CurrencyLUE.EditValue);
                }
                return result;
            }
        }

        #endregion

        private void FilterWares()
        {

            if ((WareCodeTE.Text.Length > 0) || (WareNameTE.Text.Length > 0))
            {
                List<WareView> viewList = new List<WareView>();
                if (WareCodeTE.Text.Length > 0)
                    viewList = view.Where(a => a.WareCodesStringForSearch.StartsWith("<" + WareCodeTE.Text))
                        .ToList();
                else
                    viewList = view.ToList();

                if (WareNameTE.Text.Length > 0)
                {
                    viewList = viewList.Where(a => a.Name.ToUpper().Contains(WareNameTE.Text.ToUpper())).ToList();
                }
                SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

                WaresLUE.Properties.DataSource = filteredView;
                if (filteredView.Count > 0)
                    WaresLUE.ItemIndex = 0;
            }
            else
            {
                List<WareView> viewList = new List<WareView>();
                viewList = view.ToList();
                SortableBindingList<WareView> filteredView = new SortableBindingList<WareView>(viewList);

                WaresLUE.Properties.DataSource = filteredView;
                if (filteredView.Count > 0)
                    WaresLUE.ItemIndex = 0;
            }
        }

        private void FillWares()
        {
            WaresLogic wares = new WaresLogic(manager);

            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            if( WareCategoriesLUE.EditValue != null)
                categoryId =Convert.ToInt32(WareCategoriesLUE.EditValue);
            if(UnitLUE.EditValue != null)
                unitId =Convert.ToInt32(UnitLUE.EditValue);
            
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

            WaresLUE.Properties.DataSource = view;
            WaresLUE.Properties.ValueMember = "ID";
            WaresLUE.Properties.DisplayMember = "Name";
            WaresLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WareCodesString", 0, "Код"));
            WaresLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва"));
            WaresLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ManufacturerName", 0, "Виробник"));
            WaresLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", 0, "Осн. од. вим."));
            WaresLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SecondUnitName", 0, "втор. од. вим."));
            WaresLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", 0, "Категорія"));


        }

        private void FillStates()
        {
            StatesCB.Items.Clear();
            StatesOfDocumentsLogic statesLogic = new StatesOfDocumentsLogic(manager);
            Compas.Helpers.ItemIntValue item = new ItemIntValue();
            StatesCB.DisplayMember = "Name";
            StatesCB.ValueMember = "ID";
            item.ID = -1;
            item.Name = "- не обрано -";
            StatesCB.Items.Add(item);
            foreach (var s in statesLogic.GetAll())
            {
                item = new ItemIntValue();
                item.ID = s.ID;
                item.Name = s.Name;
                StatesCB.Items.Add(item);
            }
            StatesCB.SelectedIndex = 0;
        }


        private void FillCurrencies()
        {
            CurrenciesLogic currencies = new CurrenciesLogic(manager);
            CurrencyLUE.Properties.DataSource = currencies.GetAll();
            CurrencyLUE.Properties.ValueMember = "ID";
            CurrencyLUE.Properties.DisplayMember = "Name";
            CurrencyLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва валюти"));
            CurrencyLUE.EditValue = currencies.GetDefault().ID;

        }

        public void FillFilters()
        {

            WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            WaresLogic waresLogic = new WaresLogic(manager);
            DocumentTypesLogic documentTypesLogic = new DocumentTypesLogic(manager);


            StructureObjectsLUE.Properties.DisplayMember = "Name";
            StructureObjectsLUE.Properties.ValueMember = "ID";
            StructureObjectsLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Назва"));
            StructureObjectsLUE.Properties.DataSource = structureObjectsLogic.GetHeirarchyView();

           

            WareCategoriesLUE.Properties.DisplayMember = "Name";
            WareCategoriesLUE.Properties.ValueMember = "ID";
            WareCategoriesLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Назва"));
            WareCategoriesLUE.Properties.DataSource = categoriesLogic.GetCategoriesHierarchy();

            StartDateDE.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        }

        public void Fill()
        {
            manager = new ContextManager();
            FillFilters();
            FillCurrencies();
            FillWares();

            FillStates();
        }


        public UniversalFilter()
        {
            InitializeComponent();
           
            
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void WareCodeTE_TextChanged(object sender, EventArgs e)
        {
            FilterWares();

            
        }

        private void WareNameTE_TextChanged(object sender, EventArgs e)
        {
            FilterWares();
        }

        private void WaresLUE_KeyPress(object sender, KeyPressEventArgs e)
        {
         

        }

        private void WaresLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void WareCategoriesLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void UnitLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void CurrencyLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }
    }
}
