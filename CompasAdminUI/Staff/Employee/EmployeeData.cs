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

namespace Compas.AdminUI.Staff.Employee
{
    /// <summary>
    /// створення і редагування даних працівника
    /// </summary>
    public partial class EmployeeData : Form
    {
        string mode;
        int? id;
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

        private void FillData()
        {
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            
            StaffEmployee employee = employees.Get(Convert.ToInt32(id));
           
            

            LastNameTB.Text = employee.LastName;
            FirstNameTB.Text = employee.FirstName;
            MiddleNameTB.Text = employee.MiddleName;

            CityTB.Text = employee.City;
            StreetTB.Text = employee.Street;
            BuildingTB.Text = employee.Building;
            FlatTB.Text = employee.Flat;

            PhoneTB.Text = employee.Phone;
            MobPhoneTB.Text = employee.MobPhone;

            HireDateDTP.Value = Convert.ToDateTime(employee.HireDate);

            if (employee.ReleaseDate != null)
            {
                ReleasedCB.Checked = true;
                ReleaseDateDTP.Value = Convert.ToDateTime(employee.ReleaseDate);
            }


        }

        public EmployeeData(string _mode, int? _id)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            id = _id;
            FillStructureObjects();
            if (mode == "edit")
            {
                
                FillData();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            
            int? StructureObjectId = null;
            if (StructureObjectsCB.SelectedIndex > 0)
                StructureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            string lastName = LastNameTB.Text;
            string firstName = FirstNameTB.Text;
            string middleName = MiddleNameTB.Text;
            string city = CityTB.Text;
            string street = StreetTB.Text;
            string building = BuildingTB.Text;
            string flat = FlatTB.Text;
            string phone = PhoneTB.Text;
            string mobPhone = MobPhoneTB.Text;
            DateTime? hireDate = HireDateDTP.Value;
            DateTime? releaseDate = ReleaseDateDTP.Value;
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            

            if (mode == "new")
            {
                employees.Create( lastName, firstName, middleName,
                    city, street, building, flat, phone, mobPhone, hireDate, StructureObjectId);
                
            }
            if (mode == "edit")
            {
                employees.Update(Convert.ToInt32(id), lastName, firstName, middleName,
                    city, street, building, flat, phone, mobPhone, hireDate, releaseDate, StructureObjectId); 
            }
            manager.Save();

            this.Close();
            
        }

        private void EmployeeData_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
            
        }

        private void EnterprisesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ReleasedCB_CheckedChanged(object sender, EventArgs e)
        {
            ReleaseDateDTP.Enabled = ReleasedCB.Checked;
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
