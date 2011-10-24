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
    public partial class EmployeeSalaryRecalculate : Form
    {
        ContextManager manager;
        public EmployeeSalaryRecalculate()
        {
            InitializeComponent();
            manager = new ContextManager();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM.yyyy";
            dateTimePicker1.ShowUpDown = true;
            Fill();
        }

        private void Fill()
        {
            StaffEmployeeSalariesLogic employeeSalaries = new StaffEmployeeSalariesLogic(manager);

            //StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            //StaffEmployeeSalary employeeSalary = employeeSalaries.Get(Convert.ToInt32(id));
            StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);





            //заповнюємо поле відділу
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);

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
                list.Add(i);
                counter++;
            }
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DataSource = list;
            StructureObjectsCB.SelectedIndex = selectedObjectIndex;



        }





        private void SaveBt_Click(object sender, EventArgs e)
        {
            DateTime month = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1, 0, 0, 0);
            int structureObjectId = 0;
            if (StructureObjectsCB.SelectedIndex >= 0)
            {
                structureObjectId = Convert.ToInt32(((Item)(StructureObjectsCB.SelectedItem)).ID);
            }
            StaffEmployeeSalariesLogic employeeSalariesLogic = new StaffEmployeeSalariesLogic(manager);
            employeeSalariesLogic.Recalculate(month, structureObjectId);
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill(); 
        }
    }
}
