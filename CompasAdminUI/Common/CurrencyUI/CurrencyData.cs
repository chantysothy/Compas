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

namespace Compas.AdminUI.Common.CurrencyUI
{
    public partial class CurrencyData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            CurrenciesLogic currencies = new CurrenciesLogic(manager);

            if (mode == "edit")
            {
                Currency currency = currencies.Get(Convert.ToInt32(id));
                if (currency != null)
                {
                   NameTB.Text = currency.Name;
                }
            }
            
        }

        public CurrencyData(string _mode, int? _id)
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

             CurrenciesLogic currencies = new CurrenciesLogic(manager);

            if (mode == "new")
            {
                currencies.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                currencies.Update(Convert.ToInt32(id), NameTB.Text);
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
