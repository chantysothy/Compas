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

namespace Compas.AdminUI.Wares.PriceGroup
{
    public partial class PriceGroupData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            WarePriceGroupsLogic groups = new WarePriceGroupsLogic(manager);

            if (mode == "edit")
            {
                WarePriceGroup group = groups.Get(Convert.ToInt32(id));
                if (group != null)
                {
                    NameTB.Text = group.Name;
                    DefaultExtraPercentNUD.Value = Convert.ToInt32(group.DefaultExtraPercent);
                    ActiveCB.Checked = group.Active;
                }
            }
            
        }

        public PriceGroupData(string _mode, int? _id)
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

            WarePriceGroupsLogic groups = new WarePriceGroupsLogic(manager);

            if (mode == "new")
            {
                groups.Create(NameTB.Text, ActiveCB.Checked, Convert.ToInt32(DefaultExtraPercentNUD.Value));
            }
            if (mode == "edit")
            {
                groups.Update(Convert.ToInt32(id), NameTB.Text, ActiveCB.Checked, Convert.ToInt32(DefaultExtraPercentNUD.Value));
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
