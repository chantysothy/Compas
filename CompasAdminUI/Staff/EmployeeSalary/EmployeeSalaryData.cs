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

namespace Compas.AdminUI.Staff
{
    public partial class EmployeeSalaryData : Form
    {
        string mode;
        int employeeId;
        int? id;
        ContextManager manager;

        

            
         
        private void Fill()
        {
            StaffEmployeeSalariesLogic employeeSalaries = new StaffEmployeeSalariesLogic(manager);
            
            //StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            StaffEmployeeSalary employeeSalary = employeeSalaries.Get(Convert.ToInt32(id));           
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
            StaffEmployee employee = employees.Get(employeeId);

            EmployeeL.Text = employee.LastName + " "+ employee.FirstName + " " + employee.MiddleName;
           

            //заповнюємо поле відділу
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            int objectId = Convert.ToInt32(employee.StructureObjectID);
            List<Item> list = new List<Item>();
            //Item defaultItem = new Item();
            //defaultItem.ID = "";
            //defaultItem.Name = " - всі відділи - ";
            //list.Add(defaultItem);
            int selectedObjectIndex = 0;
            int counter = 0;
            foreach (var a in StructureObjects.GetHeirarchyView())
            {
                Item i = new Item();
                i.ID = a.ID.ToString();
                i.Name = a.Name;
                if (employee.StructureObjectID == a.ID)
                    selectedObjectIndex = counter;
                list.Add(i);
                counter++;
            }
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DataSource = list;
            StructureObjectsCB.SelectedIndex = selectedObjectIndex;

            if (mode == "new")
            {
                //очищаємо поле EndDate
                //set the format to custom
                
            }
            if (mode == "edit")
            {

                //заповнюємо відділ по якому нараховується зарплата
                if (employeeSalary.StructureObjectID != null)
                {
                    int n = 0;
                    foreach (Item i in StructureObjectsCB.Items)
                    {
                        if (i.ID == employeeSalary.StructureObjectID.ToString())
                            StructureObjectsCB.SelectedIndex = n;
                        n++;
                    }
                }

                dateTimePicker1.Value = employeeSalary.Month;
                SalaryNUD.Value = employeeSalary.Salary;
                SaleSumNUD.Value = employeeSalary.SumSale;
                ExtraPercentNUD.Value = employeeSalary.ExtraPercent;

            }           
           

            
        }

        private void FillSumSalary()
        {
            decimal sum = SalaryNUD.Value + SaleSumNUD.Value * (ExtraPercentNUD.Value/100);
            SumL.Text = sum.ToString("n2");
        }

        public EmployeeSalaryData(string _mode, int? _id, int _employeeId)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            employeeId = _employeeId;
            id = _id;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM.yyyy";
            dateTimePicker1.ShowUpDown = true;
            Fill();
            if (mode == "edit")
            {
                
            }
            else
            {
                
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            StaffEmployeeSalariesLogic employeeSalaries = new StaffEmployeeSalariesLogic(manager);
            DateTime month = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1, 0, 0, 0);

            int? StructureObjectId= null;

            if (StructureObjectsCB.SelectedIndex >= 0)
            {
                StructureObjectId = Convert.ToInt32(((Item)(StructureObjectsCB.SelectedItem)).ID);
            }

            decimal sumSale = SaleSumNUD.Value;
            decimal extraPercent = ExtraPercentNUD.Value;
            decimal salary = SalaryNUD.Value;
            decimal sumSalary = SaleSumNUD.Value;
           
            if (mode == "new")
            {
                employeeSalaries.Create(month, Convert.ToInt32(StructureObjectId), Convert.ToInt32(employeeId), sumSale, extraPercent, salary);
                

            }
            if (mode == "edit")
            {
                employeeSalaries.Update(Convert.ToInt32(id), month, Convert.ToInt32(StructureObjectId), sumSale, extraPercent, salary);
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

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SaleSumNUD_Enter(object sender, EventArgs e)
        {
            //if(SaleSumNUD.Value == null)
            //    SaleSumNUD.va
        }

        private void SalaryNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSumSalary();
        }

        private void SaleSumNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSumSalary();
        }

        private void ExtraPercentNUD_ValueChanged(object sender, EventArgs e)
        {
            FillSumSalary();
        }
    }
}
