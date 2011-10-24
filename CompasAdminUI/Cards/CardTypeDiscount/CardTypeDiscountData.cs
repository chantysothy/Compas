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

namespace Compas.AdminUI.Cards
{
    public partial class CardTypeDiscountData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        List<WareDiscount> acceptedDiscounts = new List<WareDiscount>();
        List<WareDiscount> availableDiscounts = new List<WareDiscount>();

        private void FillDiscounts()
        { 
            
        }


        private void Fill()
        {
            CardTypesLogic carTypes = new CardTypesLogic(manager);

            if (mode == "edit")
            {
                WareCardType type = carTypes.Get(Convert.ToInt32(id));
                if (type != null)
                {
                    NameTB.Text = type.Name;
                    AllowBalanceCB.Checked = type.AllowBalance;
                    if (type.AllowMultipleCars != null)
                        AllowMultipleCarsCB.Checked = Convert.ToBoolean(type.AllowMultipleCars);
                }
            }
            
        }

        public CardTypeDiscountData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;

            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            CardTypesLogic types = new CardTypesLogic(manager);

            if (mode == "new")
            {
                types.Create(NameTB.Text, AllowBalanceCB.Checked, AllowMultipleCarsCB.Checked);
            }
            if (mode == "edit")
            {
                types.Update(Convert.ToInt32(id),NameTB.Text, AllowBalanceCB.Checked, AllowMultipleCarsCB.Checked);
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
    }
}
