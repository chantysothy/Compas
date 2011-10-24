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

namespace Compas.AdminUI.Staff.Shift
{
    public partial class ShiftData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            StaffShiftsLogic shifts = new StaffShiftsLogic(manager);
            StaffShift shift = shifts.Get(Convert.ToInt32(id));
            if (shift != null)
            {
                TimeSpan startTime = shift.StartTime;
                TimeSpan endTime = shift.EndTime;
                NameTB.Text = shift.Name;
                dateTimePicker1.Value = new DateTime(2000, 01, 01, startTime.Hours, startTime.Minutes, startTime.Seconds);
                dateTimePicker2.Value = new DateTime(2000, 01, 01, endTime.Hours, endTime.Minutes, endTime.Seconds);
            }
            //StaffTeam team = teams.Get(Convert.ToInt32(id));
            //NameTB.Text = team.Name;
            
        }

        public ShiftData(string _mode, int? _id)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;

            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            
            StaffShiftsLogic shifts = new StaffShiftsLogic(manager);
            TimeSpan startTime = dateTimePicker1.Value.TimeOfDay;
            TimeSpan endTime = dateTimePicker2.Value.TimeOfDay;
            if (mode == "new")
            {
                shifts.Create(NameTB.Text, startTime, endTime);
            }
            if (mode == "edit")
            {
                shifts.Update(Convert.ToInt32(id), NameTB.Text, startTime, endTime);
            }
            manager.Save();

            this.Close();
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
