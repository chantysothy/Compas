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
    public partial class ActionNew : Form
    {
        public ActionNew()
        {
            InitializeComponent();
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic cl = new SecurityCategoriesLogic(manager);
            CategoriesCB.DataSource = cl.GetAll();
            
            CategoriesCB.Update();
            //CategoriesCB.Items.AddRange(cl.GetAll());
            //foreach (var c in cl.GetAll())
            //{
                
            //    CategoriesCB.Items.Add(
            //}
            manager.CloseContext();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityActionsLogic logic = new SecurityActionsLogic(manager);
            logic.Create(NameTB.Text, CodeTB.Text, Convert.ToInt32(CategoriesCB.SelectedValue), DescriptionTB.Text);
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
