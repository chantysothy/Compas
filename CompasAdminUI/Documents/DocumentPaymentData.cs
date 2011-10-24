using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Compas.Logic.Wares;
using Compas.Logic.Documents;
using Compas.Model;
using Compas.Logic;
using Compas.Logic.Staff;
using Compas.Logic.Config;
using Compas.CashRegisters;

namespace Compas.AdminUI.Documents
{
    public partial class DocumentPaymentData : Form
    {
        ContextManager manager;
        CashRegister cashRegister;
        WareDocument document;
        private decimal documentSuma = 0;
        private int documentId;

        private void FillPaymentTypes()
        {
            DocumentPaymentTypesLogic typesLogic = new DocumentPaymentTypesLogic(manager);
            List<WareDocumentPaymentType> types = typesLogic.GetAll();
            PaymentTypesLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Назва"));
            PaymentTypesLUE.Properties.DataSource = types;
            PaymentTypesLUE.Properties.DisplayMember = "Name";
            PaymentTypesLUE.Properties.ValueMember = "ID";
            
            if (types.Count > 0)
            {
                PaymentTypesLUE.EditValue = types[0].ID;
            }
        }
        private void FillStructureObjects()
        {
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            BindingList<StructureObjectView> structureObjects = structureObjectsLogic.GetHeirarchyView();
            StructureObjectsLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Назва"));
            StructureObjectsLUE.Properties.DataSource = structureObjects;
            StructureObjectsLUE.Properties.DisplayMember = "Name";
            StructureObjectsLUE.Properties.ValueMember = "ID";

            if (structureObjects.Count > 0)
            {
                StructureObjectsLUE.EditValue = structureObjects[0].ID;
            }
        }

        private void Fill()
        {
            decimal suma = SumaSE.Value;
            decimal overPay = suma - documentSuma;


            //якщо оплачено не всю суму
            if (overPay < 0)
            {
                overPay = 0;
                OverPayL.Text = overPay.ToString("n2");
                PaySumaL.Text = suma.ToString("n2");
            }
            else
            {
                //вся сума
                OverPayL.Text = overPay.ToString("n2");
                PaySumaL.Text = (suma - overPay).ToString("n2");
            }
        }
        public DocumentPaymentData(int DocumentID, WareDocument Document, CashRegister _CashRegister)
        {
            
            InitializeComponent();
            cashRegister = _CashRegister;
            document = Document;
            manager = new ContextManager();
            documentSuma = Document.DocumentSum;
            documentId = DocumentID;
            PayDateDTP.Value = DateTime.Now;
            DocumentSumaL.Text = Convert.ToString(documentSuma);
            CheckNumberTB.Text = document.Number;
            Fill();
            FillPaymentTypes();
            FillStructureObjects();

            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            ConfigurationParameter param0 = config.Get(ParametersLogic.Parameter.PAYMENTS_SHOW_CARD.ToString());
            if (param0 != null)
            {
                if (Helpers.ConfigDataTypeConverter.ConvertToBoolean(param0.Value) == true)
                {
                    tableLayoutPanel1.RowStyles[4].SizeType = SizeType.Absolute;

                    tableLayoutPanel1.RowStyles[4].Height = 0;
                }
            }
        }

        public DocumentPaymentData(int DocumentID, CashRegister _CashRegister)
        {

            InitializeComponent();

            cashRegister = _CashRegister;
            manager = new ContextManager();
            DocumentsLogic dl = new DocumentsLogic(manager);

            document = dl.Get(DocumentID);
            documentSuma = document.DocumentSum;
            documentId = DocumentID;
            PayDateDTP.Value = DateTime.Now;
            DocumentSumaL.Text = Convert.ToString(documentSuma);
            CheckNumberTB.Text = document.Number;
            Fill();
            FillPaymentTypes();
            FillStructureObjects();

            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            ConfigurationParameter param0 = config.Get(ParametersLogic.Parameter.PAYMENTS_SHOW_CARD.ToString());
            if (param0 != null)
            {
                if (Helpers.ConfigDataTypeConverter.ConvertToBoolean(param0.Value) == true)
                {
                    tableLayoutPanel1.RowStyles[4].SizeType = SizeType.Absolute;

                    tableLayoutPanel1.RowStyles[4].Height = 0;
                }
            }
        }
        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Оплата по документу не проведена");
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            //виводимо квитанцію на фіскальний принтер
            List<WareDocumentDetail> details = (from a in document.WareDocumentDetails
                                               select a).ToList();
            if (cashRegister != null)
            {
                cashRegister.StartCheck();
                foreach (var detail in details)
                {
                    cashRegister.AddCheckPosition(detail.WareID, Convert.ToDecimal(detail.PriceForUnit), detail.UnitQuantity, detail.Ware.Name);
                }

                cashRegister.AddPayment(Convert.ToDecimal(PaySumaL.Text));
                cashRegister.EndCheck();
            }
            else
                MessageBox.Show("Фіскальний принтер не підключено");

            //зберігаємо дані про оплату в БД
            int? cardId = null;
            if (CardTB.Text.Length > 0)
            { 
                CardsLogic cardsLogic = new CardsLogic(manager);
                WareCard card = cardsLogic.GetByCode(CardTB.Text);
                if (card != null)
                    cardId = card.ID;
            }
            
            DocumentPaymentsLogic paymentsLogic = new DocumentPaymentsLogic(manager);
            paymentsLogic.Create(DateTime.Now, 
                Convert.ToDecimal(PaySumaL.Text), 
                true, documentId, 
                Convert.ToInt32(document.CurrencyID),
                Convert.ToInt32(StructureObjectsLUE.EditValue),
                Convert.ToInt32(PaymentTypesLUE.EditValue),
                cardId,
                CheckNumberTB.Text);
            manager.Save();
            this.Close();
        }

        private void SumaSE_EditValueChanged(object sender, EventArgs e)
        {

            Fill();
        }
    }
}
