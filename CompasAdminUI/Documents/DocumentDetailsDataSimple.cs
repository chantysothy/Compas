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
            if (wareSelectorUC1.WareID != null)
            {

                int wareId = Convert.ToInt32(/*WaresGV.SelectedRows[0].Cells["WareID"].Value*/wareSelectorUC1.WareID);
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
                else
                {
                    UnitPriceNUD.Value = 0;
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
            //categoriesUC1.Fill();
            //categoriesUC1.ExpandAll();
            wareSelectorUC1.Init("");

            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            ConfigurationParameter param0 = config.Get(ParametersLogic.Parameter.DOCUMENTDETAILS_SHOW_SECONDARY_UNIT.ToString());
            if (param0 != null)
            {
               SecondaryGroupGB.Visible = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param0.Value);
            }

            ConfigurationParameter param1 = config.Get(ParametersLogic.Parameter.DOCUMENTDETAILS_SHOW_FONTSIZE.ToString());
            if (param1 != null)
            {
                float size = Helpers.ConfigDataTypeConverter.ConvertToFloat(param1.Value);
                wareSelectorUC1.FontSize = size;

                //this.Font = new Font(this.Font.Name, size);
            }

            ConfigurationParameter param2 = config.Get(ParametersLogic.Parameter.DOCUMENTDETAILS_SHOW_WARES_MINROWHEIGHT.ToString());
            if (param2 != null)
            {
                int size = Convert.ToInt32(param2.Value);
                wareSelectorUC1.MinRowHeight = size;
            }

            ConfigurationParameter param3 = config.Get(ParametersLogic.Parameter.DOCUMENTDETAILS_SHOW_WARES_VIEWMODE.ToString());
            if (param3 != null)
            {
                switch (param3.ToString().ToUpper())
                {
                    case "TREEVIEW":
                        {
                            wareSelectorUC1.CategoriesViewMode = UC.CategoriesUC.Mode.TreeView;
                            break;
                        }
                    case "BUTTON":
                        {
                            wareSelectorUC1.CategoriesViewMode = UC.CategoriesUC.Mode.Button;
                            break;
                        }
                }
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
            ////FillWares();
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
            if (wareSelectorUC1.WareID != null)
            {
                int wareId = (int)(wareSelectorUC1.WareID);
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
            int wareId = (int)(wareSelectorUC1.WareID);
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

        private void wareSelectorUC1_SelectedWareChanged(object sender, EventArgs e)
        {
            FillPrices();
            FillSummaryPrice();
        }

        private void wareSelectorUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
