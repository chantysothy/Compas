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

namespace Compas.AdminUI.Staff.EmployeePosition
{
    public partial class EmployeePositionsList : Form
    {
        
        int employeeId;
        
        ContextManager manager;

        private void Fill()
        {

            StaffEmployeePositionsLogic positions = new StaffEmployeePositionsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = positions.GetByEmployeeID(employeeId).Select(a => new
            {
                a.ID,
                Name = a.StaffPosition.Name,
                a.StartDate,
                a.EndDate,
                a.Active
                
            }).ToList();
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            StaffEmployee employee = employees.Get(employeeId);
            EmployeeL.Text = employee.LastName + " " + employee.FirstName + " " + employee.MiddleName;
            DataGV.Update();
            

        }

        public EmployeePositionsList(int _employeeId)
        {

            InitializeComponent();
            manager = new ContextManager();
            DataGV.AutoGenerateColumns = false;
            employeeId = _employeeId;
            Fill();
           
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            EmployeePositionData form = new EmployeePositionData("new", null, employeeId);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            EmployeePositionData form = new EmployeePositionData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), employeeId);
            form.ShowDialog();
            manager.Save();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            StaffEmployeePositionsLogic employeePositions = new StaffEmployeePositionsLogic(manager);
            employeePositions.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            
            Fill();
        }

        private void TeamsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }
    }
}
