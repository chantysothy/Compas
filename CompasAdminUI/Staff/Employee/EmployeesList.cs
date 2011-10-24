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
using Compas.Logic.Staff;
using Compas.Logic.Security;
using Compas.Helpers;

namespace Compas.AdminUI.Staff.Employee
{
    public partial class EmployeesList : Form
    {
        ContextManager manager;
        

        private void FillStructureObjects()        
        {

            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            
            List<Item> list = new List<Item>();
           
            foreach (var a in StructureObjects.GetStructureObjectsHierarchy(true))
            {
                Item i = new Item();
                i.ID = a.ID.ToString();
                i.Name = a.Name;
                list.Add(i);
            }
            
            StructureObjectsCB.DataSource = list;
        }

        /// <summary>
        /// Заповнення таблиці працівників для відображення
        /// </summary>
        private void FillGrid()
        {
            manager = new ContextManager();
            DataGV.Rows.Clear();
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            
            DataGV.AutoGenerateColumns = false;
            int enterpriseId;
            int? StructureObjectId = null;
            
            if(StructureObjectsCB.SelectedIndex > 0)
                StructureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            
            BindingSource bs = new BindingSource();
            StaffEmployeePositionsLogic employeePositions = new StaffEmployeePositionsLogic(manager);
            //bs.DataSource = employees.GetAll(enterpriseId);
            if (StructureObjectId != null)
                bs.DataSource = employeePositions.GetAll(StructureObjectId);
            else
                bs.DataSource = employees.GetAll();
            
            DataGV.DataSource = bs;           

            DataGV.Update();
            DataGV.Refresh();
           
        }

        private void FillInfo()
        {
            if (DataGV.SelectedRows.Count > 0)
            {
                StaffEmployeePositionsLogic employeePositionsLogic = new StaffEmployeePositionsLogic(manager);
                StaffEmployeeLogic employeeLogic = new StaffEmployeeLogic(manager);
                SecurityUserRolesLogic userRoles = new SecurityUserRolesLogic(manager);
                int employeeId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
                PositionsLB.DataSource = employeePositionsLogic.GetPositionsByEmployeeID(employeeId).ToList();

                PositionsLB.DisplayMember = "Name";
                PositionsLB.ValueMember = "ID";
                PositionsLB.Update();

                StaffEmployee employee = employeeLogic.Get(employeeId);
                if (employee.UserID != null)
                {
                    int userId = Convert.ToInt32(employee.UserID);
                    RolesLB.DataSource = userRoles.GetAll(userId).Select(a => a.SecurityRole).ToList();
                    RolesLB.DisplayMember = "Name";
                    RolesLB.ValueMember = "ID";
                    RolesLB.Update();
                }
            }
        }


        public EmployeesList()
        {
           
                InitializeComponent();
                manager = new ContextManager();
                
                FillStructureObjects();
                FillGrid();

                if (DataGV.Rows.Count > 0)
                {
                    DataGV.Rows[0].Selected = true;
                    FillInfo();
                }
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            EmployeeData form = new EmployeeData("new", null);
            form.ShowDialog();
            FillGrid();
        }

        private void EmployeesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void EnterprisesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStructureObjects();
            FillGrid();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            employees.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            FillGrid();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            EmployeeData form = new EmployeeData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            FillGrid();
        }

        private void RefreshSB_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void ActionsStrip_Paint(object sender, PaintEventArgs e)
        {
            if (DataGV.Rows.Count == 0)
            {
                ActionsStrip.Items[1].Enabled = false;
                ActionsStrip.Items[2].Enabled = false;                
                ActionsStrip.Items[4].Enabled = false;
            }
            if (DataGV.Rows.Count > 0)
            {
                ActionsStrip.Items[1].Enabled = true;
                ActionsStrip.Items[2].Enabled = true;
                ActionsStrip.Items[4].Enabled = true;
            }
        }

        private void AccessSB_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
            Security.UserForm form = new Security.UserForm("manage", null, employeeId);
            form.ShowDialog();
        }

        private void RolesSB_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
            Security.UserRolesForm form = new Security.UserRolesForm(employeeId);
            form.ShowDialog();
        }

        private void PositionSB_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
            Staff.EmployeePosition.EmployeePositionsList form = new Staff.EmployeePosition.EmployeePositionsList(employeeId);
            form.ShowDialog();
        }

        private void StructureObjectsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void DataGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


            
        }

        private void DataGV_SelectionChanged(object sender, EventArgs e)
        {
            FillInfo();
        }

        private void SalaryBt_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
            Staff.EmployeSalariesList form = new Staff.EmployeSalariesList(employeeId);
            form.ShowDialog();
        }
    }
}
