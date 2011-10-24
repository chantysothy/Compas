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
using Compas.Helpers;

namespace Compas.AdminUI.Security
{
    public partial class ActionsForm : Form
    {
        private void FillGrid()
        {
            ContextManager manager = new ContextManager();
            SecurityActionsLogic logic = new SecurityActionsLogic(manager);

            if (CategoriesLB.SelectedItems.Count > 0)
            {
                Compas.Model.SecurityCategory item = ((Compas.Model.SecurityCategory)(CategoriesLB.SelectedItems[0]));
                int categoryId = Convert.ToInt32(item.ID);
                DataGV.DataSource = logic.GetByCategory(categoryId);
            }
            else
                DataGV.DataSource = logic.GetAll();
            manager.CloseContext();

        }

        private void FillCategories()
        {
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic categories = new SecurityCategoriesLogic(manager);
            CategoriesLB.DataSource = categories.GetAll();
            if(CategoriesLB.Items.Count > 0)
                CategoriesLB.SelectedIndex = 0;
            manager.CloseContext();
        }

        public ActionsForm()
        {
            InitializeComponent();
            DataGV.AutoGenerateColumns = false;
            ContextManager manager = new ContextManager();
            SecurityCategoriesLogic categories = new SecurityCategoriesLogic(manager);
            //CategoriesGV.DataSource = categories.GetAll();
            //foreach (var c in categories.GetAll())
            //{
            //    CategoriesTV.Nodes.Add(c.ID.ToString(), c.Name);
               
            //}
            FillCategories();
            FillGrid();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityActionsLogic sr = new SecurityActionsLogic(manager);
            sr.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells[0].FormattedValue));
            manager.Save();
            FillGrid();
            
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            string[] args = new string[] { "new" };

            ActionNew an = new ActionNew();
            an.ShowDialog();
            FillGrid();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            ActionEdit rn = new ActionEdit(Convert.ToInt32(DataGV.SelectedRows[0].Cells[0].FormattedValue));
            rn.ShowDialog();
            FillGrid();
        }

        private void CategoriesTV_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void CategoriesGV_SelectionChanged(object sender, EventArgs e)
        {
           // FillGrid();

        }

        private void CategoriesGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CategoriesGV_Click(object sender, EventArgs e)
        {
           
        }

        private void CategoriesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        


    }
}
