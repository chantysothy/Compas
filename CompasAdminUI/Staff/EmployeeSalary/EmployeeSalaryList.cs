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

namespace Compas.AdminUI.Staff
{
    public partial class EmployeSalariesList : Form
    {
        
        int? employeeId;
        
        ContextManager manager;

        private void Fill()
        {
           
                StaffEmployeeSalariesLogic salariesLogic = new StaffEmployeeSalariesLogic(manager);
                DataGV.AutoGenerateColumns = false;
                if (employeeId != null)
                    DataGV.DataSource = salariesLogic.GetViewByEmployeeID(Convert.ToInt32(employeeId));
                else
                    DataGV.DataSource = salariesLogic.GetView();
                StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
                if (employeeId != null)
                {
                    StaffEmployee employee = employees.Get(Convert.ToInt32(employeeId));
                    EmployeeL.Text = employee.LastName + " " + employee.FirstName + " " + employee.MiddleName;
                }
                else
                    EmployeeL.Text = "Всі працівники";

                DataGV.Update();
            

        }

        public EmployeSalariesList(int? _employeeId)
        {

            InitializeComponent();
            manager = new ContextManager();
            DataGV.AutoGenerateColumns = false;
            employeeId = _employeeId;
            if (_employeeId == null)
            {
                NewSB.Enabled = false;                
            }
            Fill();
           
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            EmployeeSalaryData form = new EmployeeSalaryData("new", null, Convert.ToInt32(employeeId));
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            if (DataGV.SelectedRows.Count > 0)
            {
                EmployeeSalaryData form = new EmployeeSalaryData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), Convert.ToInt32(employeeId));
                form.ShowDialog();
                manager.Save();
                manager.CloseContext();
                manager = new ContextManager();
                Fill();
            }
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            StaffEmployeeSalariesLogic employeeSalaries = new StaffEmployeeSalariesLogic(manager);
            employeeSalaries.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void TeamsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void CalculateSalarySB_Click(object sender, EventArgs e)
        {
            EmployeeSalaryRecalculate form = new EmployeeSalaryRecalculate();
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }
    }
}
