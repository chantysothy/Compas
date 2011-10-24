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

namespace Compas.AdminUI.Wares.Manufacturer
{
    public partial class ManufacturerData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            WareManufacturersLogic manufacturers = new WareManufacturersLogic(manager);

            if (mode == "edit")
            {
                WareManufacturer manufacturer = manufacturers.Get(Convert.ToInt32(id));
                if (manufacturer != null)
                {
                    NameTB.Text = manufacturer.Name;
                }
            }
            
        }

        public ManufacturerData(string _mode, int? _id)
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

            WareManufacturersLogic manufacturers = new WareManufacturersLogic(manager);

            if (mode == "new")
            {
                manufacturers.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                manufacturers.Update(Convert.ToInt32(id), NameTB.Text);
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
