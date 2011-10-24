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
    public partial class DiscountTypeData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            WareDiscountTypesLogic discountTypes = new WareDiscountTypesLogic(manager);

            if (mode == "edit")
            {
                WareDiscountType currency = discountTypes.Get(Convert.ToInt32(id));
                if (currency != null)
                {
                   NameTB.Text = currency.Name;
                }
            }
            
        }

        public DiscountTypeData(string _mode, int? _id)
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

            WareDiscountTypesLogic discountTypes = new WareDiscountTypesLogic(manager);

            if (mode == "new")
            {
                discountTypes.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                discountTypes.Update(Convert.ToInt32(id), NameTB.Text);
            }
            manager.Save();

            this.Close();
        }

        

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
