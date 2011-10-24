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
using Compas.Logic.Config;

namespace Compas.AdminUI.Documents
{
    public partial class DocumentDetailsDataSimple : Form
    {
        string mode;

        int? id;
        ContextManager manager;

        public WareDocumentDetail DocumentDetail;
        private WareDocument Document;
        private List<WareDocumentDetail> DocumentDetails;

        SortableBindingList<WareView> view;

        private void FillWares()
        {
            WaresLogic wares = new WaresLogic(manager);

            int? categoryId = null;
            int? manufacturerId = null;
            int? unitId = null;
            //string name = wareFilterUC1.WareName;
            categoryId = categoriesUC1.SelectedCategoryID;
           
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

            WaresGV.AutoGenerateColumns = false;
            WaresGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            WaresGV.DataSource = view;

            

        }

        private void FillSummaryPrice()
        {
            decimal discount = Convert.ToDecimal(DiscountForUnitNUD.Value);
            decimal unitQuantity = Convert.ToDecimal(UnitQuantityNUD.Value);
            decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityNUD.Value);
            decimal endSalePriceForUnit = UnitPriceNUD.Value - discount;
            decimal salePrice = endSalePriceForUnit * unitQuantity;
            TotalPriceL.Text = salePrice.ToString("n2");
            MessageL.Text = "Оберіть одиницю";
        }

        private void FillPrices()
        {
            if (WaresGV.SelectedRows.Count > 0)
            {
                int wareId = Convert.ToInt32(WaresGV.SelectedRows[0].Cells["WareID"].Value);
                //int priceGroupId = Convert.ToInt32(PriceGroupsCBE.EditValue);
                decimal discount = Convert.ToDecimal(DiscountForUnitNUD.Value);
                decimal unitQuantity = Convert.ToDecimal(UnitQuantityNUD.Value);
                decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityNUD.Value);

                WarePricesLogic prices = new WarePricesLogic(manager);
                WarePrice price = prices.GetAll(wareId).OrderByDescending(a => a.Active).FirstOrDefault();

                if (price != null)
                {
                    UnitPriceNUD.Value = price.SalePriceForUnit;

                   
                }
                
            }

        }

        public DocumentDetailsDataSimple(string _mode, WareDocument document, List<WareDocumentDetail> documentDetails, WareDocumentDetail documentDetail)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            MessageL.Text = "Оберіть одиницю";

            Document = document;
            DocumentDetails = documentDetails;
            DocumentDetail = documentDetail;
            categoriesUC1.Fill();
            categoriesUC1.ExpandAll();

            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            ConfigurationParameter param0 = config.Get(ParametersLogic.Parameter.DOCUMENTDETAILS_SHOW_SECONDARY_UNIT.ToString());
            if (param0 != null)
            {
               SecondaryGroupGB.Visible = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param0.Value);
            }

        }

        private void PriceGroupsCBE_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void categoriesUC1_Click(object sender, EventArgs e)
        {

        }

        private void categoriesUC1_SelectedCategoryChanged(object sender, EventArgs e)
        {
            FillWares();
        }

        private void WaresUpBt_Click(object sender, EventArgs e)
        {
            if (WaresGV.FirstDisplayedScrollingRowIndex > 0)
                WaresGV.FirstDisplayedScrollingRowIndex = WaresGV.FirstDisplayedScrollingRowIndex - 1;
        }

        private void WaresDownBt_Click(object sender, EventArgs e)
        {
            if(WaresGV.FirstDisplayedScrollingRowIndex < WaresGV.RowCount)
                WaresGV.FirstDisplayedScrollingRowIndex = WaresGV.FirstDisplayedScrollingRowIndex + 1;
        }

        private void CategoriesUpBt_Click(object sender, EventArgs e)
        {
            categoriesUC1.ScrollUp();
        }

        private void CategoriesDownBt_Click(object sender, EventArgs e)
        {
            categoriesUC1.ScrollDown();
        }

        private void WaresGV_SelectionChanged(object sender, EventArgs e)
        {
            TotalPriceL.Text = "0";
            //MessageL.Text = "Ціну не знайдено.";
            DiscountForUnitNUD.Value = 0;
            UnitQuantityNUD.Value = 1;
            SecondaryUnitQuantityNUD.Value = 0;
            UnitPriceNUD.Value = 0;
            FillPrices();
        }

        private void UnitQuantityNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSummaryPrice();
        }

        private void SecondaryUnitQuantityNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSummaryPrice();
        }

        private void UnitPriceNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSummaryPrice();
        }

        private void ShowNumPadBt_Click(object sender, EventArgs e)
        {
            numPad1.Visible = !numPad1.Visible;
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            DocumentDetailsLogic details = new DocumentDetailsLogic(manager);
            if (WaresGV.SelectedRows.Count > 0)
            {
                int wareId = (int)(WaresGV.SelectedRows[0].Cells["WareID"].Value);
                decimal unitQuantity = Convert.ToDecimal(UnitQuantityNUD.Value);
                decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityNUD.Value);
                decimal priceForUnit = Convert.ToDecimal(UnitPriceNUD.Value);
                decimal discountForUnit = Convert.ToDecimal(DiscountForUnitNUD.Value);
                decimal endSalePriceForUnit = Convert.ToDecimal(priceForUnit - discountForUnit);
                decimal endPrice = Convert.ToDecimal(endSalePriceForUnit * unitQuantity);
                int currencyId = Convert.ToInt32(Document.CurrencyID);



                //MessageBox.Show(wareId.ToString());
                if (mode == "new")
                {
                    //створюємо новий запис в деталізації документа і повертаємо його
                    DocumentDetail = details.CreateWithNoSave(wareId, unitQuantity, secondaryUnitQuantity,
                        priceForUnit, discountForUnit, endSalePriceForUnit, endPrice, currencyId, -1);
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
                MessageL.Text = "Додано";
            }
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnitPriceNUD_ValueChanged_1(object sender, EventArgs e)
        {
            FillSummaryPrice();
        }

        private void DiscountForUnitNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSummaryPrice();
        }

        private void AddAndCloseBt_Click(object sender, EventArgs e)
        {
            DocumentDetailsLogic details = new DocumentDetailsLogic(manager);
            int wareId = (int)(WaresGV.SelectedRows[0].Cells["WareID"].Value);
            decimal unitQuantity = Convert.ToDecimal(UnitQuantityNUD.Value);
            decimal secondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantityNUD.Value);
            decimal priceForUnit = Convert.ToDecimal(UnitPriceNUD.Value);
            decimal discountForUnit = Convert.ToDecimal(DiscountForUnitNUD.Value);
            decimal endSalePriceForUnit = Convert.ToDecimal(priceForUnit - discountForUnit);
            decimal endPrice = Convert.ToDecimal(endSalePriceForUnit * unitQuantity);
            int currencyId = Convert.ToInt32(Document.CurrencyID);



            //MessageBox.Show(wareId.ToString());
            if (mode == "new")
            {
                //створюємо новий запис в деталізації документа і повертаємо його
                DocumentDetail = details.CreateWithNoSave(wareId, unitQuantity, secondaryUnitQuantity,
                    priceForUnit, discountForUnit, endSalePriceForUnit, endPrice, currencyId, -1);
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
            MessageL.Text = "Додано";
            this.Close();
        }
    }
}
