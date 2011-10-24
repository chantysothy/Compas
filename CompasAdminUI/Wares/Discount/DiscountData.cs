using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic.Wares;
using Compas.Logic;


namespace Compas.AdminUI.Wares.Discount
{
    public partial class DiscountData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            WareDiscountTypesLogic discountTypes = new WareDiscountTypesLogic(manager);
            DiscountTypesCB.DataSource = discountTypes.GetAll();
            DiscountTypesCB.ValueMember = "ID";
            DiscountTypesCB.DisplayMember = "Name";
            DiscountTypesCB.Update();

            if (mode == "edit")
            {

                if (id != null)
                {
                    WareDiscountsLogic discounts = new WareDiscountsLogic(manager);
                    WareDiscount discount = discounts.Get(Convert.ToInt32(id));
                    if (discount != null)
                    {
                        NameTB.Text = discount.Name;
                        ActiveCB.Checked = discount.Active;
                        DefaultDiscountPercentNUD.Value = discount.DefaultDiscountPercent;
                        //int i = 0;
                        foreach (WareDiscountType a in DiscountTypesCB.Items)
                        {
                            if (a.ID == discount.DiscountTypeID)
                                DiscountTypesCB.SelectedItem = a;
                               
                        }
                    }
                }
                //WareDiscountType discountTypes = discountTypes.Get(Convert.ToInt32(id));
                //if (currency != null)
                //{
                //   NameTB.Text = currency.Name;
                //}
            }
            
        }

        public DiscountData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            Fill();
            //if (mode == "edit")
            //{
                
            //}
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            WareDiscountsLogic discounts = new WareDiscountsLogic(manager);
            int discountTypeId = Convert.ToInt32(DiscountTypesCB.SelectedValue);
            string name = NameTB.Text;
            bool active = ActiveCB.Checked;
            decimal defaultDiscountPercent = DefaultDiscountPercentNUD.Value;
            if (mode == "new")
            {
                discounts.Create(name, active, discountTypeId, defaultDiscountPercent);
            }
            if (mode == "edit")
            {
                discounts.Update(Convert.ToInt32(id), name, active, discountTypeId, defaultDiscountPercent);
            }
            manager.Save();

            this.Close();
        }

        

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTypeBt_Click(object sender, EventArgs e)
        {
            Wares.Discount.DiscountTypesList form = new Wares.Discount.DiscountTypesList();

            form.ShowDialog();
        }

        

        
    }
}
