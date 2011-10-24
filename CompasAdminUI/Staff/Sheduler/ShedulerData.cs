using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Staff;
using Compas.Logic.Security;
using Compas.Helpers;

namespace Compas.AdminUI.Staff.Sheduler
{
    public partial class ShedulerData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        StaffSheduler sheduler;
        

        private void FillStructureObjects()
        {
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffStructureObject none = new StaffStructureObject();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<ItemIntValue> list = new List<ItemIntValue>();
            
            list.AddRange(StructureObjects.GetStructureObjectsHierarchy(true));
            
            StructureObjectsCB.DataSource = list;

            if (mode == "edit" || mode == "copy")
            {
                if (sheduler != null && sheduler.StructureObjectID != null)
                {
                    int i = 0;
                    foreach (object o in StructureObjectsCB.Items)
                    {
                        ItemIntValue StructureObject = (ItemIntValue)o;
                        if (StructureObject.ID == sheduler.StructureObjectID)
                        {
                            StructureObjectsCB.SelectedIndex = i;
                        }
                        i++;
                    }
                }

                if (mode == "copy")
                {
                    StartDateDTP.Value = sheduler.StartDate.Date.AddDays(1);
                    EndDateDTP.Value = sheduler.EndDate.Date.AddDays(1);
                    StartTimeDTP.Value = sheduler.StartDate;
                    EndTimeDTP.Value = sheduler.EndDate;

                }
            }
        }

        private void FillShifts()
        {
            StaffShiftsLogic shifts = new StaffShiftsLogic(manager);
            ShiftsCB.ValueMember = "ID";
            ShiftsCB.DisplayMember = "Name";
            ShiftsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffShift none = new StaffShift();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<StaffShift> list = new List<StaffShift>();
            list.Add(none);
            list.AddRange(shifts.GetAll());

            ShiftsCB.DataSource = list;

            if (mode == "edit" || mode == "copy")
            {
                if (sheduler != null && sheduler.ShiftID != null)
                {
                    int i = 0;
                    foreach (object o in ShiftsCB.Items)
                    {
                        StaffShift shift = (StaffShift)o;
                        if (shift.ID == sheduler.ShiftID)
                        {
                            ShiftsCB.SelectedIndex = i;
                        }
                        i++;
                    }
                }
            }

        }

        private void FillTeams()
        {
            StaffTeamsLogic teams = new StaffTeamsLogic(manager);
            TeamsCB.ValueMember = "ID";
            TeamsCB.DisplayMember = "Name";
            TeamsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffTeam none = new StaffTeam();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<StaffTeam> list = new List<StaffTeam>();
            list.Add(none);
            int StructureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            list.AddRange(teams.GetByStructureObject(StructureObjectId));

            TeamsCB.DataSource = list;

            if (mode == "edit" || mode == "copy")
            {
                if (sheduler != null && sheduler.TeamID != null)
                {
                    int i = 0;
                    foreach (object o in TeamsCB.Items)
                    {
                        StaffTeam team = (StaffTeam)o;
                        if (team.ID == sheduler.TeamID)
                        {
                            TeamsCB.SelectedIndex = i;
                        }
                        i++;
                    }
                }
            }

        }

       

        private void FillPositions()
        {
            StaffPositionsLogic positions = new StaffPositionsLogic(manager);
            PositionsCB.ValueMember = "ID";
            PositionsCB.DisplayMember = "Name";
            PositionsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StaffPosition none = new StaffPosition();
            //none.ID = -1;
            none.Name = "- не вибрано -";
            List<StaffPosition> list = new List<StaffPosition>();
            list.Add(none);
            int StructureObjectId = Convert.ToInt32(PositionsCB.SelectedValue);
            list.AddRange(positions.GetAll());

            PositionsCB.DataSource = list;
            

        }

        private void FillAvailableEmployees()
        {
            AvailableEmployeesLB.Items.Clear();
            StaffEmployeeLogic employeesLogic = new StaffEmployeeLogic(manager);
            StaffEmployeePositionsLogic employeePositionsLogic = new StaffEmployeePositionsLogic(manager);
            
            //List<StaffEmployee> employees = employeesLogic.GetAll().Select(a => new { a.ID, a.LastName + " " + a.FirstName + " " + a.MiddleName});
            AvailableEmployeesLB.ValueMember = "ID";
            AvailableEmployeesLB.DisplayMember = "Name";

            int structureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
           
            //BindingList<Helpers.ItemIntValue> structureObjects = structureObjectsLogic.GetStructureObjectsHierarchy(false, structureObjectId);

            
            List<StaffEmployee> filteredEmloyees = employeePositionsLogic.GetByPositionID(Convert.ToInt32(PositionsCB.SelectedValue)).Select(a => a.StaffEmployee).ToList();
            var employees = employeesLogic.GetAll().Where(a => filteredEmloyees.Contains(a)).Select(a => new { a.ID, Name = a.LastName + " " + a.FirstName + " " + a.MiddleName });
            foreach(var employee in employees)
            {
                ItemIntValue item = new ItemIntValue();
                item.ID = employee.ID;
                item.Name = employee.Name;
                AvailableEmployeesLB.Items.Add(item);
            }  

        }

        private void FillSelectedEmployees()
        {
            if (sheduler != null)
            {
                StaffShedulerEmployeesLogic shedulerEmployees = new StaffShedulerEmployeesLogic(manager);

                var employees = shedulerEmployees.GetBySheduler(sheduler.ID).Select(a => new { a.StaffEmployee.ID, Name = a.StaffEmployee.LastName + " "
                    + a.StaffEmployee.FirstName + " "
                    + a.StaffEmployee.MiddleName });
                foreach (var employee in employees)
                {
                    ItemIntValue item = new ItemIntValue();
                    item.ID = employee.ID;
                    item.Name = employee.Name;
                    SelectedEmployeesLB.Items.Add(item);
                }  
            }
        }

        public ShedulerData(string _mode, int? _id)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;

            if (mode == "new")
            {
                StartTimeDTP.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
                EndTimeDTP.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
            }
            if (mode == "edit" || mode =="copy")
            {
                StaffShedulersLogic shedulers = new StaffShedulersLogic(manager);
                sheduler = shedulers.Get(Convert.ToInt32(id));
            }

            
            FillStructureObjects();
            FillShifts();
            FillTeams();
           
            FillPositions();
            FillAvailableEmployees();
            FillSelectedEmployees();
            SelectedEmployeesLB.ValueMember = "ID";
            SelectedEmployeesLB.DisplayMember = "Name";
            RemoveBt.Enabled = false;
            
        }



        private void SaveBt_Click(object sender, EventArgs e)
        {
            StaffShedulersLogic shedulers = new StaffShedulersLogic(manager);
            StaffShedulerEmployeesLogic shedulersEmployee = new StaffShedulerEmployeesLogic(manager);
            
            int? StructureObjectId = null;
            int? teamId = null;
            int? shiftId = null;
            int? workPlaceId = null;
            DateTime startDate = StartDateDTP.Value.Add(StartTimeDTP.Value.TimeOfDay);
            DateTime endDate = EndDateDTP.Value.Add(EndTimeDTP.Value.TimeOfDay);
            string description = DescriptionTB.Text;

            if (StructureObjectsCB.SelectedIndex > 0)
            {
                StructureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            }

            if (TeamsCB.SelectedIndex > 0)
            {
                teamId = Convert.ToInt32(TeamsCB.SelectedValue);
            }

            if (ShiftsCB.SelectedIndex > 0)
            {
                shiftId = Convert.ToInt32(ShiftsCB.SelectedValue);
            }

            
            if (mode == "new" || mode == "copy")
            {
                int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
                // Define a transaction scope for the operations.
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        StaffSheduler sheduler = shedulers.Create( StructureObjectId, shiftId, teamId, 
                            startDate, endDate, userId, DateTime.Now, description);
                        //додаємо працівників
                        foreach (object item in SelectedEmployeesLB.Items)
                        {
                            ItemIntValue i = (ItemIntValue)item;
                            int employeeId = i.ID;
                            shedulersEmployee.Create(sheduler, employeeId);
                        }

                    }
                    catch (Exception ex)
                    {
                        // Handle errors and deadlocks here and retry if needed.
                        // Allow an UpdateException to pass through and 
                        // retry, otherwise stop the execution.
                        if (ex.GetType() != typeof(UpdateException))
                        {
                            MessageBox.Show("An error occured. "
                                + "The operation cannot be retried."
                                + ex.Message);

                        }
                        // If we get to this point, the operation will be retried.
                    }
                }

                
            }
            if (mode == "edit")
            {

                // Define a transaction scope for the operations.
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        shedulers.Update(Convert.ToInt32(id),  StructureObjectId, shiftId, teamId, 
                            startDate, endDate, description);
                        //додаємо працівників
                        shedulersEmployee.DeleteBySheduler(Convert.ToInt32(id));
                        foreach (object item in SelectedEmployeesLB.Items)
                        {
                            ItemIntValue i = (ItemIntValue)item;
                            int employeeId = i.ID;
                            shedulersEmployee.Create(sheduler, employeeId);
                        }

                    }
                    catch (Exception ex)
                    {
                        // Handle errors and deadlocks here and retry if needed.
                        // Allow an UpdateException to pass through and 
                        // retry, otherwise stop the execution.
                        if (ex.GetType() != typeof(UpdateException))
                        {
                            MessageBox.Show("An error occured. "
                                + "The operation cannot be retried."
                                + ex.Message);

                        }
                        // If we get to this point, the operation will be retried.
                    }
                }
            }
           
            manager.Save();

            this.Close();
        }

        private void ShedulerData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EnterprisesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStructureObjects();
        }

        private void StructureObjectsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTeams();
           
        }

        private void StartDateDTP_ValueChanged(object sender, EventArgs e)
        {
            EndDateDTP.Value = StartDateDTP.Value;
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            List<object> employees = new List<object>();
            foreach (object employee in AvailableEmployeesLB.SelectedItems)
            {
                employees.Add(employee);
            }

            int index = AvailableEmployeesLB.SelectedIndex;
            if (index - 1 >= 0)
                AvailableEmployeesLB.SelectedIndex = index - 1;
            
            
            foreach (object employee in employees)
            {
                SelectedEmployeesLB.Items.Add(employee);
                AvailableEmployeesLB.Items.Remove(employee);
            }           

        }

        private void RemoveBt_Click(object sender, EventArgs e)
        {
            List<object> employees = new List<object>();
            foreach (object employee in SelectedEmployeesLB.SelectedItems)
            {
                employees.Add(employee);
            }

            foreach (object employee in employees)
            {
                //AvailableEmployeesLB.Items.Add(employee);
                SelectedEmployeesLB.Items.Remove(employee);
            }
            FillAvailableEmployees();
        }

        private void PositionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAvailableEmployees();
        }

        private void SelectedEmployeesLB_Enter(object sender, EventArgs e)
        {
            RemoveBt.Enabled = true;   
        }

        private void SelectedEmployeesLB_Leave(object sender, EventArgs e)
        {
            
        }

        private void AvailableEmployeesLB_Enter(object sender, EventArgs e)
        {
            RemoveBt.Enabled = false;
        }

        private void ShiftsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartTimeDTP.Value = StartDateDTP.Value.Date.Add(((StaffShift)(ShiftsCB.SelectedItem)).StartTime);
            EndTimeDTP.Value = EndDateDTP.Value.Date.Add(((StaffShift)(ShiftsCB.SelectedItem)).EndTime);
        }
    }
}
