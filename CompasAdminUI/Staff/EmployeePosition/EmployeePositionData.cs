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
using Compas.Helpers;

namespace Compas.AdminUI.Staff.EmployeePosition
{
    public partial class EmployeePositionData : Form
    {
        string mode;
        int employeeId;
        int? id;
        ContextManager manager;

        

            
         
        private void Fill()
        {
            StaffEmployeePositionsLogic employeePositions = new StaffEmployeePositionsLogic(manager);
            //StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            StaffEmployeePosition employeePosition = employeePositions.Get(Convert.ToInt32(id));
            StaffPositionsLogic positions = new StaffPositionsLogic(manager);
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            StaffEmployee employee = employees.Get(employeeId);

            EmployeeL.Text = employee.LastName + " "+ employee.FirstName + " " + employee.MiddleName;
            PositionsCB.DataSource = positions.GetAll();
            PositionsCB.DisplayMember = "Name";
            PositionsCB.ValueMember = "ID";
            PositionsCB.Update();

            //заповнюємо поле відділу
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            int objectId = Convert.ToInt32(employee.StructureObjectID);
            List<Item> list = new List<Item>();
            Item defaultItem = new Item();
            defaultItem.ID = "";
            defaultItem.Name = " - всі відділи - ";
            list.Add(defaultItem);
            foreach (var a in StructureObjects.GetHeirarchyView())
            {
                Item i = new Item();
                i.ID = a.ID.ToString();
                i.Name = a.Name;
                list.Add(i);
            }
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DataSource = list;


            if (mode == "new")
            {
                //очищаємо поле EndDate
                //set the format to custom
                EndDateDTP.Format = DateTimePickerFormat.Custom;
                // set custom format to empty
                EndDateDTP.CustomFormat = " ";
                ActiveCB.Checked = true;
            }
            if (mode == "edit")
            {
                StartDateDTP.Value = employeePosition.StartDate;
                if (employeePosition.EndDate != null)
                {
                    EndDateDTP.Value = Convert.ToDateTime(employeePosition.EndDate);
                }
                else
                {
                    //очищаємо поле EndDate
                    //set the format to custom
                    EndDateDTP.Format = DateTimePickerFormat.Custom;
                    // set custom format to empty
                    EndDateDTP.CustomFormat = " ";
                }
                PositionsCB.SelectedItem = positions.GetAll().Where(a => a.ID == employeePosition.PositionID).FirstOrDefault();
                ActiveCB.Checked = employeePosition.Active;

                if (employeePosition.StructureObjectID != null)
                {
                    int n = 0;
                    foreach (Item i in StructureObjectsCB.Items)
                    {
                        if (i.ID == employeePosition.StructureObjectID.ToString())
                            StructureObjectsCB.SelectedIndex = n;
                        n++;
                    }
                }
            }           
           

            
        }

        public EmployeePositionData(string _mode, int? _id, int _employeeId)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            employeeId = _employeeId;
            id = _id;

            if (mode == "edit")
            {
                Fill();
            }
            else
            {
                Fill();
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            StaffEmployeePositionsLogic employeePositions = new StaffEmployeePositionsLogic(manager);
            DateTime? endDate = null;
            int? StructureObjectId= null;

            if (StructureObjectsCB.SelectedIndex > 0)
            {
                StructureObjectId = Convert.ToInt32(((Item)(StructureObjectsCB.SelectedItem)).ID);
            }

            if(EndDateDTP.Format == DateTimePickerFormat.Custom)
            {
                endDate = null;
            }
            else
            {
                endDate = EndDateDTP.Value;
            }
            if (mode == "new")
            {

                employeePositions.Create(employeeId, Convert.ToInt32(PositionsCB.SelectedValue), StartDateDTP.Value, endDate, ActiveCB.Checked, StructureObjectId);

            }
            if (mode == "edit")
            {
                employeePositions.Update(Convert.ToInt32(id), Convert.ToInt32(PositionsCB.SelectedValue), StartDateDTP.Value, endDate, ActiveCB.Checked, StructureObjectId);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EndDateDTP_ValueChanged(object sender, EventArgs e)
        {
            EndDateDTP.Format = DateTimePickerFormat.Long;
        }
    }
}
