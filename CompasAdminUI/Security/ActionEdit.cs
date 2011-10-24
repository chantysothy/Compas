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
    public partial class ActionEdit : Form
    {
        private int ID;
        public ActionEdit(int _ID)
        {
            ID = _ID;
            InitializeComponent();
            ContextManager manager = new ContextManager();
            SecurityActionsLogic logic = new SecurityActionsLogic(manager);
            SecurityAction action = logic.Get(ID);
            NameTB.Text = action.Name;
            CodeTB.Text = action.Code;
            DescriptionTB.Text = action.Description;

            SecurityCategoriesLogic categoriesLogic = new SecurityCategoriesLogic(manager);
            //role.SecurityCategory.Name
            var categories = categoriesLogic.GetAll();
            int i = 0;
            foreach (var category in categories)
            {
                Helpers.Item item = new Helpers.Item();
                item.ID = category.ID.ToString();
                item.Name = category.Name;
                CategoriesCB.Items.Add(item);
                if (action.CategoryID == category.ID)
                {
                    CategoriesCB.SelectedIndex = i;
                }
                i++;
            }
            
            
            
            manager.CloseContext();           
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityActionsLogic logic = new SecurityActionsLogic(manager);
            int categoryId = Convert.ToInt32(((Helpers.Item)(CategoriesCB.SelectedItem)).ID);
            logic.Update(ID, NameTB.Text, categoryId, CodeTB.Text, DescriptionTB.Text);
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
