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

namespace Compas.AdminUI.Wares.Extra
{
    public partial class ExtraData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            WareExtrasLogic extras = new WareExtrasLogic(manager);

            if (mode == "edit")
            {
                WareExtra extra = extras.Get(Convert.ToInt32(id));
                if (extra != null)
                {
                    ExtraPercentNUD.Value = extra.ExtraPercent;
                    DefaultCB.Checked = extra.Default;
                }
            }
            
        }

        public ExtraData(string _mode, int? _id)
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

            WareExtrasLogic extras = new WareExtrasLogic(manager);

            if (mode == "new")
            {
                extras.Create(Convert.ToInt32(ExtraPercentNUD.Value), DefaultCB.Checked);
            }
            if (mode == "edit")
            {
                extras.Update(Convert.ToInt32(id), Convert.ToInt32(ExtraPercentNUD.Value), DefaultCB.Checked);
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
