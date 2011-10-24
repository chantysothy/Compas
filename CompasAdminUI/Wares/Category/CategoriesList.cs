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
using Compas.Helpers;

namespace Compas.AdminUI.Wares.Category
{
    public partial class CategoriesList : Form
    {
        
        int StructureObjectId;
        BindingList<ItemIntValue> items = new BindingList<ItemIntValue>();
        ContextManager manager;

        private void Fill()
        {
            DataGV.Rows.Clear();
            DataGV.ClearSelection();

            FillCategoriesHierarchy(null, "", true);
            WareCategoriesLogic cl = new WareCategoriesLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = items;//cl.GetAll();
            
            DataGV.Update();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category">батьківська категорія</param>
        private void FillCategoriesHierarchy(WareCategory category, string prefix, bool start)
        {

            if (start == true)
                items.Clear();
            WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            List<WareCategory> categories = new List<WareCategory>();
            if (category == null)
                categories = categoriesLogic.GetAllRoot();
            else
                categories = categoriesLogic.GetAll(category.ID);

            foreach (WareCategory a in categories)
            {               
                ItemIntValue item = new ItemIntValue();
                item.ID = a.ID;
                item.Name = prefix + a.Name;
                items.Add(item);
                FillCategoriesHierarchy(a, prefix + @"    ", false);
            }
        }

        public CategoriesList()
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            
            if (allowed == true)
            {
                Fill();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            Wares.Category.CategoryData form = new Wares.Category.CategoryData("new", null);
            form.ShowDialog();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Wares.Category.CategoryData form = new Wares.Category.CategoryData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WareCategoriesLogic cl = new WareCategoriesLogic(manager);
            cl.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
               
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

       
    }
}
