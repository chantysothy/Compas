using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Compas.Logic;
using Compas.Logic.Security;
using Compas.Model;

namespace Compas.AdminUI.Security
{
    public partial class RoleEdit : Form
    {
        private int ID;
        public RoleEdit(int _ID)
        {
            ID = _ID;
            InitializeComponent();
            ContextManager manager = new ContextManager();
            SecurityRolesLogic sr = new SecurityRolesLogic(manager);
            SecurityRole role = sr.Get(ID);
            NameTB.Text = role.Name;
            DescriptionTB.Text = role.Description;
            
            manager.CloseContext();           
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityRolesLogic sr = new SecurityRolesLogic(manager);
            sr.Update(ID, NameTB.Text, DescriptionTB.Text);
            manager.Save();
            manager.CloseContext();
            this.Close();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
