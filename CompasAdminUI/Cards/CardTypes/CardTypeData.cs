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
    public partial class CardTypeData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        List<WareDiscount> availableDiscounts;
        List<WareDiscount> acceptedDiscounts;


        private void FillDiscounts()
        {
            WareDiscountsLogic discountsLogic = new WareDiscountsLogic(manager);
            CardTypesDiscountsLogic typeDiscountsLogic = new CardTypesDiscountsLogic(manager);
            if (availableDiscounts == null)
            {
                availableDiscounts = new List<WareDiscount>();
                availableDiscounts = discountsLogic.GetAll();
            }
            if (acceptedDiscounts == null)
            {
                acceptedDiscounts = new List<WareDiscount>();
                if (id != null & acceptedDiscounts.Count() == 0)
                {
                    acceptedDiscounts = typeDiscountsLogic.GetAll(Convert.ToInt32(id)).Select(a => a.WareDiscount).Distinct().ToList();
                }
            }
                       
           
           
           
            //else
            //{
            //    availableDiscounts = acceptedDiscounts.SkipWhile(a => acceptedDiscounts.Contains(a)).ToList();
            //}
            AvailableDiscountsGV.AutoGenerateColumns = false;
            AvailableDiscountsGV.DataSource = availableDiscounts.Where(a => !acceptedDiscounts.Contains(a)).ToList();
            AvailableDiscountsGV.Update();
            if (AvailableDiscountsGV.RowCount > 0)
                AvailableDiscountsGV.Rows[0].Selected = true;
            AcceptedDiscountsGV.AutoGenerateColumns = false;
            AcceptedDiscountsGV.DataSource = acceptedDiscounts.Select(a => a).ToList();            
            AcceptedDiscountsGV.Update();

        }


        private void Fill()
        {
            CardTypesLogic carTypes = new CardTypesLogic(manager);

            FillDiscounts();
            

            if (mode == "edit")
            {
                WareCardType type = carTypes.Get(Convert.ToInt32(id));
                if (type != null)
                {
                    NameTB.Text = type.Name;
                    AllowMultipleCarsCB.Checked = Convert.ToBoolean(type.AllowMultipleCars);
                    AllowBalanceCB.Checked = type.AllowBalance;
                }
            }
            
        }

        public CardTypeData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            Fill();
            if (mode == "edit")
            {
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            CardTypesLogic cardTypesLogic = new CardTypesLogic(manager);
            CardTypesDiscountsLogic cardTypeDiscountsLogic = new CardTypesDiscountsLogic(manager);
            WareCardType cardType = null;
            if (mode == "new")
            {
                cardType = cardTypesLogic.Create(NameTB.Text, AllowBalanceCB.Checked, AllowMultipleCarsCB.Checked);
            }
            if (mode == "edit")
            {
                cardType = cardTypesLogic.Update(Convert.ToInt32(id), NameTB.Text, AllowBalanceCB.Checked, AllowMultipleCarsCB.Checked);
            }

            cardTypeDiscountsLogic.Delete(acceptedDiscounts, cardType.ID);
            
            foreach (WareDiscount discount in acceptedDiscounts)
            {
                cardTypeDiscountsLogic.Create(cardType, discount.ID, DateTime.Now, null);
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

        private void AddBt_Click(object sender, EventArgs e)
        {
            WareDiscountsLogic discountsLogic = new WareDiscountsLogic(manager);
            int discoutId = Convert.ToInt32(AvailableDiscountsGV.SelectedRows[0].Cells["DiscountID"].Value);
            acceptedDiscounts.Add(discountsLogic.Get(discoutId));
            FillDiscounts();
        }

        private void RemoveBt_Click(object sender, EventArgs e)
        {
            WareDiscountsLogic discountsLogic = new WareDiscountsLogic(manager);
            int discoutId = Convert.ToInt32(AcceptedDiscountsGV.CurrentRow.Cells["DiscountID0"].Value);
            acceptedDiscounts.Remove(discountsLogic.Get(discoutId));
            FillDiscounts();
        }
    }
}
