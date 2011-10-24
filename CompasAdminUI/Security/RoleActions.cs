using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Helpers;
using Compas.Logic;
using Compas.Logic.Security;
using Compas.Model;

namespace Compas.AdminUI.Security
{
    

    
    public partial class RoleActionsF : Form
    {
        private void FillActions()
        {
            ContextManager manager = new ContextManager();
            SecurityActionsLogic actions = new SecurityActionsLogic(manager);
            if (RolesCB.SelectedIndex >= 0)
            {
                int categoryId = Convert.ToInt32(CategoriesCB.SelectedValue);
                ActionsGV.DataSource = actions.GetByCategory(categoryId);
            }
            else
                ActionsGV.DataSource = actions.GetAll();

           
                //ContextManager manager = new ContextManager();
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                SecurityRoleActionsLogic roleActions = new SecurityRoleActionsLogic(manager);
                foreach (DataGridViewRow row in ActionsGV.Rows)
                {
                    ch1 = (DataGridViewCheckBoxCell)row.Cells["AllowAction"];
                    int actionId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    int roleId = Convert.ToInt32(RolesCB.SelectedValue);
                    bool actionAllow = roleActions.Exists(roleId, actionId, true);
                    ch1.Value = actionAllow;
                }



            


            manager.CloseContext();
        }

        public RoleActionsF()
        {
            InitializeComponent();
            //створюэмо грід з можливістю групування
            GroupByGrid grid = new GroupByGrid();
            ContextManager manager = new ContextManager();
            SecurityActionsLogic actions = new Logic.Security.SecurityActionsLogic(manager);
            SecurityCategoriesLogic categories = new SecurityCategoriesLogic(manager);
            SecurityRolesLogic roles = new SecurityRolesLogic(manager);
            ActionsGV.AutoGenerateColumns = false;
            RolesCB.DataSource = roles.GetAll();
            CategoriesCB.DataSource = categories.GetAll();
            manager.CloseContext(); 
      
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void CategoriesGV_Click(object sender, EventArgs e)
        {
            FillActions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillActions();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityRoleActionsLogic actions = new SecurityRoleActionsLogic(manager);
            int roleId = Convert.ToInt32(RolesCB.SelectedValue);
            int categoryId = Convert.ToInt32(CategoriesCB.SelectedValue);
            
            foreach (DataGridViewRow r in ActionsGV.Rows)
            {
                
                DataGridViewCheckBoxCell chk = r.Cells["AllowAction"] as DataGridViewCheckBoxCell;
                int actionId = Convert.ToInt32(r.Cells["ID"].Value.ToString());
                bool allow = false;
                if (Convert.ToBoolean(chk.Value) == true)
                //MessageBox.Show("this cell checked" + r.Cells["ID"].Value.ToString());
                {
                    allow = true;
                }
                else
                {
                    allow = false;
                }

                SecurityRoleAction actionExists = actions.Get(roleId, actionId);
                if (actionExists == null)
                {
                    actions.Create(roleId, actionId, allow);
                }
                else
                {
                    actions.Update(actionExists.ID, roleId, actionId, allow);
                }
               
            }
            manager.Save();
            manager.CloseContext();
            MsgL.Text = "Дані збережено.";
        }

        private void ActionsGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }


}
