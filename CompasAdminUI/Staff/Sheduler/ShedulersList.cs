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

namespace Compas.AdminUI.Staff.Sheduler
{
    public partial class ShedulersList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void Fill()
        {
            //int enterpriseId = Convert.ToInt32(
            StaffShedulersLogic shedulers = new StaffShedulersLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = shedulers.GetAll(
                enterpriseStructureUC1.StructureObjectID,
                enterpriseStructureUC1.ShiftID,
                enterpriseStructureUC1.TeamID, 
                enterpriseStructureUC1.StartDate).Select(a => new {a.ID, 
                   
                    StructureObjectName = a.StaffStructureObject != null ? a.StaffStructureObject.Name : "",
                    ShiftName = a.StaffShift != null ? a.StaffShift.Name : "",
                    TeamName = a.StaffTeam != null ? a.StaffTeam.Name : "",
                    a.StartDate,
                    a.EndDate,
                    a.Description
                }).ToList();
            DataGV.Update();
        }

        public ShedulersList()
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            if (allowed == true)
            {
                
                enterpriseStructureUC1.Fill();
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
            Sheduler.ShedulerData form = new Sheduler.ShedulerData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Sheduler.ShedulerData form = new Sheduler.ShedulerData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            StaffShedulersLogic shedulers = new StaffShedulersLogic(manager);
            shedulers.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void DataGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGV.SelectedRows.Count > 0)
            {
                StaffShedulerEmployeesLogic shedulerEmployees = new StaffShedulerEmployeesLogic(manager);

                int shedulerId = Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value);
                var employees = shedulerEmployees.GetBySheduler(shedulerId).Select(a => new
                {
                    a.StaffEmployee.ID,
                    Name = a.StaffEmployee.LastName + " "
                        + a.StaffEmployee.FirstName + " "
                        + a.StaffEmployee.MiddleName
                });
                SelectedEmployeesLB.ValueMember = "ID";
                SelectedEmployeesLB.DisplayMember = "Name";
                SelectedEmployeesLB.DataSource = employees.ToList();
            }
        }

        private void DuplicateSB_Click(object sender, EventArgs e)
        {
            Sheduler.ShedulerData form = new Sheduler.ShedulerData("copy", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

       
    }
}
