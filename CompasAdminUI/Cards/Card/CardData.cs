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

using Zen.Barcode;

namespace Compas.AdminUI.Cards
{
    public partial class CardData : Form
    {
        string mode;
        
        int? id;
        int? contractorId;

        ContextManager manager;
        private void Fill()
        {
            CardsLogic cardsLogic = new CardsLogic(manager);
            CardTypesLogic cardTypesLogic = new CardTypesLogic(manager);

            CardTypesCB.DisplayMember = "Name";
            CardTypesCB.ValueMember = "ID";
            CardTypesCB.DataSource = cardTypesLogic.GetAll();

            if (mode == "edit")
            {
                WareCard card = cardsLogic.Get(Convert.ToInt32(id));
                if (card != null)
                {
                    CodeTB.Text = card.Code;
                    foreach (object a in CardTypesCB.Items)
                    {
                        if (((WareCardType)a).ID == card.CardTypeID)
                            CardTypesCB.SelectedItem = a; 
                    }
                }
                ActiveCB.Checked = card.Active;
                if (card.IssuedDate != null)
                {
                    IssuedDateDTP.Value = Convert.ToDateTime(card.IssuedDate);
                }
            }
            
        }

        public CardData(string _mode, int? _id, int? _contractorId)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            Fill();

            if (mode == "edit")
            {
                CardsQuantityNUD.Enabled = false;
                CharsQuantityNUD.Enabled = false;
                FillCodeCB.Enabled = false;

                //перевіряємо чи дана картка не закріплена за клієнтом
                Compas.Logic.Contractors.ContractorsLogic contractorsLogic = new Logic.Contractors.ContractorsLogic(manager);
                ViewContractorCard card = contractorsLogic.GetCard(Convert.ToInt32(id));
                int contractorId = -1;
                if (card != null)
                {
                    contractorId = card.ContractorID;
                    var contractor = contractorsLogic.Get(contractorId);
                    if (contractor != null)
                        ContractorLL.Text = contractor.LastName + " " + contractor.FirstName + " " + contractor.MiddleName;
                }
                else
                {
                    ContractorLL.Text = "Картка вільна";
                }
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            CardsLogic cardsLogic = new CardsLogic(manager);

            if (mode == "new")
            {
                int cardsQuantity = Convert.ToInt32(CardsQuantityNUD.Value);
                int charsQuantity = Convert.ToInt32(CharsQuantityNUD.Value);
                //покищо коди лише числові
                int intCode = Convert.ToInt32(CodeTB.Text);

                for (int i = 0; i < cardsQuantity; i++)
                {
                    string code = intCode.ToString().PadLeft(charsQuantity, '0');
                    cardsLogic.Create(code, Convert.ToInt32(CardTypesCB.SelectedValue), ActiveCB.Checked, IssuedDateDTP.Value);
                    intCode = intCode + 1;
                }
             }
            if (mode == "edit")
            {
                cardsLogic.Update(Convert.ToInt32(id), CodeTB.Text, Convert.ToInt32(CardTypesCB.SelectedValue), ActiveCB.Checked, IssuedDateDTP.Value);
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

        private void CodeTB_TextChanged(object sender, EventArgs e)
        {
            Code128BarcodeDraw bdf = BarcodeDrawFactory.Code128WithChecksum;
            if (CodeTB.Text.Length > 0)
            {
                BarcodePB.Image = bdf.Draw(CodeTB.Text, 40);
                BarcodePB.Update();
            }
        }
    }
}
