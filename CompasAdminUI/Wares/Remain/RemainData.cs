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

namespace Compas.AdminUI.Wares.Remain
{
    public partial class RemainData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            WareUnitsLogic units = new WareUnitsLogic(manager);

            if (mode == "edit")
            {
                WareUnit unit = units.Get(Convert.ToInt32(id));
                if (unit != null)
                {
                    NameTB.Text = unit.Name;
                }
            }
            
        }

        public RemainData(string _mode, int? _id)
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

            WareUnitsLogic units = new WareUnitsLogic(manager);

            if (mode == "new")
            {
                units.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                units.Update(Convert.ToInt32(id), NameTB.Text);
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
