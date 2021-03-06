﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Contractors;

namespace Compas.AdminUI.ContractorsUI
{
    public partial class ContractorTypeData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            ContractorTypesLogic types = new ContractorTypesLogic(manager);

            if (mode == "edit")
            {
                ContractorType type = types.Get(Convert.ToInt32(id));
                if (type != null)
                {
                    NameTB.Text = type.Name;
                }
            }
            
        }

        public ContractorTypeData(string _mode, int? _id)
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

            ContractorTypesLogic types = new ContractorTypesLogic(manager);

            if (mode == "new")
            {
                types.Create(NameTB.Text);
            }
            if (mode == "edit")
            {
                types.Update(Convert.ToInt32(id), NameTB.Text);
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
