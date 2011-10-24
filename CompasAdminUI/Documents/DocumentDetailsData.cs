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

namespace Compas.AdminUI.Documents
{
    public partial class DocumentDetailsData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;

        public WareDocumentDetail DocumentDetail;
        private WareDocument Document;
        private List<WareDocumentDetail> DocumentDetails;

        SortableBindingList<WareView> view;


        private void FillFilteredWares(string columnName)
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
        private void RecalculatePrices()
        {
            int wareId = Convert.ToInt32(WareLUE.EditValue);
            int priceGroupId = Convert.ToInt32(PriceGroupsCBE.EditValue);
            decimal discount = Convert.ToDecimal(DiscountForUnitTB.Text);
            decimal unitQuantity = Convert.ToDecimal(UnitQuantityTB.Text);
            decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityTB.Text);
            decimal salePriceForUnit = Convert.ToDecimal(SalePriceForUnitTB.Text);
            
            WarePricesLogic prices = new WarePricesLogic(manager);
            WarePrice price = prices.Get(wareId, priceGroupId);

            decimal endSalePriceForUnit = salePriceForUnit - discount;
            decimal salePrice = endSalePriceForUnit * unitQuantity;

            EndSalePriceForUnitTB.Text = endSalePriceForUnit.ToString("n2");
            SalePriceTB.Text = salePrice.ToString("n2");

            if (price != null)
            {                
                MessageL.Text = "";
            }
            else
            {
               
                MessageL.Text = "Ціну не знайдено.";
            }
        }

        private void FillPrices()
        {

            int wareId = Convert.ToInt32(WareLUE.EditValue);
            int priceGroupId = Convert.ToInt32(PriceGroupsCBE.EditValue);
            decimal discount = Convert.ToDecimal(DiscountForUnitTB.Text);
            decimal unitQuantity = Convert.ToDecimal(UnitQuantityTB.Text);
            decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityTB.Text);

            WarePricesLogic prices = new WarePricesLogic(manager);
            WarePrice price = prices.Get(wareId, priceGroupId);

            if (price != null)
            {
                SalePriceForUnitTB.Text = price.SalePriceForUnit.ToString("n2");

                decimal endSalePriceForUnit = price.SalePriceForUnit - discount;
                decimal salePrice = endSalePriceForUnit * unitQuantity;

                EndSalePriceForUnitTB.Text = endSalePriceForUnit.ToString("n2");
                SalePriceTB.Text = salePrice.ToString("n2");
                MessageL.Text = "";
            }
            else
            {
                SalePriceForUnitTB.Text = "0";
                EndSalePriceForUnitTB.Text = "0";
                SalePriceTB.Text = "0";
                MessageL.Text = "Ціну не знайдено.";
            }

        }

        private void FillPriceGroups()
        {
            WarePriceGroupsLogic priceGroups = new WarePriceGroupsLogic(manager);
            //SortableBindingList<WarePriceGroup>  view = new SortableBindingList<WarePriceGroup>(viewList);
            if (WareLUE.EditValue != null)
            {
                int wareId = ((int)(WareLUE.EditValue));
                PriceGroupsCBE.Properties.DataSource = priceGroups.GetAll(wareId);
                PriceGroupsCBE.Properties.ValueMember = "ID";
                PriceGroupsCBE.Properties.DisplayMember = "Name";

                WarePriceGroup priceGroup = priceGroups.GetAll(wareId).FirstOrDefault();
                if ((priceGroup != null) & (mode == "new"))
                {
                    PriceGroupsCBE.EditValue = priceGroup.ID;
                }
                //PriceGroupsCBE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва"));
            }
           

            
        }

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



            var waresList = 
                mode == "new" ?                
                wares.GetAll("", categoryId, manufacturerId, unitId).Select(a => new
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
            }) :
            wares.GetAllByWareID(DocumentDetail.WareID).Select(a => new
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
            })
            
            ;//.OrderBy(a => a.CategoryName).ThenBy(a=> a.Name).ToList();
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
            WareLUE.Properties.ValueMember = "ID";
            WareLUE.Properties.DisplayMember = "Name";
            WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WareCodesString", 0, "Код"));
            WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва"));
            WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ManufacturerName", 0, "Виробник"));
            WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", 0, "Осн. од. вим."));
            WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SecondUnitName", 0, "втор. од. вим."));
            WareLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", 0, "Категорія"));


        }

        private void Fill()
        {
            WareUnitsLogic units = new WareUnitsLogic(manager);
            WaresLogic wares = new WaresLogic(manager);
            StaffStructureObjectsLogic objects = new StaffStructureObjectsLogic(manager);

            if (DocumentDetail != null)
            {
                WareLUE.EditValue = DocumentDetail.WareID;
                UnitQuantityTB.EditValue = DocumentDetail.UnitQuantity;
                SecondaryUnitQuantityTB.EditValue = DocumentDetail.SecondaryUnitQuantity;
                SalePriceForUnitTB.EditValue = DocumentDetail.PriceForUnit;
                DiscountForUnitTB.EditValue = DocumentDetail.DiscountForUnit;
                EndSalePriceForUnitTB.Text = Convert.ToDecimal(DocumentDetail.EndPriceForUnit).ToString("n2");
                SalePriceTB.Text = Convert.ToDecimal(DocumentDetail.EndPrice).ToString("n2");
            }
            
            
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

        public DocumentDetailsData(string _mode, WareDocument document, List<WareDocumentDetail> documentDetails, WareDocumentDetail documentDetail)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            MessageL.Text = "";

            Document = document;
            DocumentDetails = documentDetails;
            DocumentDetail = documentDetail;
            
            FillWares();
            FillPriceGroups();
            FillCurrencies();
            Fill();
            if (mode == "edit")
            {
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() == true)
            {

                DocumentDetailsLogic details = new DocumentDetailsLogic(manager);
                int wareId = (int)(WareLUE.EditValue);
                decimal unitQuantity = Convert.ToDecimal(UnitQuantityTB.Text);
                decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityTB.Text);
                decimal priceForUnit = Convert.ToDecimal(SalePriceForUnitTB.Text);
                decimal discountForUnit = Convert.ToDecimal(DiscountForUnitTB.Text);
                decimal endSalePriceForUnit = Convert.ToDecimal(EndSalePriceForUnitTB.Text);
                decimal endPrice = Convert.ToDecimal(SalePriceTB.Text);
                int currencyId = Convert.ToInt32(CurrencyLUE.EditValue);
                int priceGroupID = Convert.ToInt32(PriceGroupsCBE.EditValue);

                //MessageBox.Show(wareId.ToString());
                if (mode == "new")
                {
                    //створюємо новий запис в деталізації документа і повертаємо його
                    DocumentDetail = details.CreateWithNoSave(wareId, unitQuantity, secondaryUnitQuantity,
                        priceForUnit, discountForUnit, endSalePriceForUnit, endPrice, currencyId, priceGroupID);
                    DocumentDetails.Add(DocumentDetail);


                }
                if (mode == "edit")
                {
                    //DocumentDetails.Remove(DocumentDetail);
                    DocumentDetail.UnitQuantity = unitQuantity;
                    DocumentDetail.SecondaryUnitQuantity = secondaryUnitQuantity;
                    DocumentDetail.PriceForUnit = priceForUnit;
                    DocumentDetail.DiscountForUnit = discountForUnit;
                    DocumentDetail.EndPriceForUnit = endSalePriceForUnit;
                    DocumentDetail.EndPrice = endPrice;
                    DocumentDetail.CurrencyID = currencyId;

                    //DocumentDetails.Add(DocumentDetail);

                }
                //manager.Save();

                this.Close();
            }
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            FillFilteredWares("Name");
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void WareLUE_Properties_EditValueChanged(object sender, EventArgs e)
        {
            FillPriceGroups();
            FillPrices();
        }

        private void PriceGroupsCBE_EditValueChanged(object sender, EventArgs e)
        {
            FillPrices();
        }

        private void WareLUE_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PriceGroupsCBE_Properties_EditValueChanged(object sender, EventArgs e)
        {
            FillPrices();
        }

        private void DocumentDetailsData_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnitQuantityTB_TextChanged(object sender, EventArgs e)
        {
            RecalculatePrices();
        }

        private void SalePriceForUnitTB_TextChanged(object sender, EventArgs e)
        {
            RecalculatePrices();
        }

        private void DiscountForUnitTB_TextChanged(object sender, EventArgs e)
        {
            RecalculatePrices();
        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            wareFilterUC1.Fill();
        }

        private void UnitQuantityTB_EditValueChanged(object sender, EventArgs e)
        {
            RecalculatePrices();
        }

        private void SalePriceForUnitTB_EditValueChanged(object sender, EventArgs e)
        {
            RecalculatePrices();
        }

        private void DiscountForUnitTB_EditValueChanged(object sender, EventArgs e)
        {
            RecalculatePrices();
        }
    }
}
