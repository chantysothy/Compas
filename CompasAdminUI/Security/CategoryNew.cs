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

namespace Compas.AdminUI.Security
{
    public partial class CategoryNew : Form
    {
        public CategoryNew()
        {
            InitializeComponent();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic logic = new SecurityCategoriesLogic(manager);
            logic.Create(NameTB.Text);
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
