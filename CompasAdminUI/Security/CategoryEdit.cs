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
    public partial class CategoryEdit : Form
    {
        private int ID;
        public CategoryEdit(int _ID)
        {
            ID = _ID;
            InitializeComponent();
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic logic = new SecurityCategoriesLogic(manager);
            SecurityCategory role = logic.Get(ID);
            NameTB.Text = role.Name;
            
            
            manager.CloseContext();           
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic logic = new SecurityCategoriesLogic(manager);
            logic.Update(ID, NameTB.Text);
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
