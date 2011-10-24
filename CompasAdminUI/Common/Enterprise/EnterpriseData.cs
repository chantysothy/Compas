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


namespace Compas.AdminUI
{
    public partial class EnterpriseData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            EnterprisesLogic Enterprises = new EnterprisesLogic(manager);

            if (mode == "edit")
            {
                Enterprise Enterprise = Enterprises.Get(Convert.ToInt32(id));
                if (Enterprise != null)
                {
                    NameTB.Text = Enterprise.Name;
                }
            }
            
        }

        public EnterpriseData(string _mode, int? _id)
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

            EnterprisesLogic Enterprises = new EnterprisesLogic(manager);

            if (mode == "new")
            {
                Enterprises.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                Enterprises.Update(Convert.ToInt32(id), NameTB.Text);
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
