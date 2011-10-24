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

namespace Compas.AdminUI.Staff.StructureObject
{
    public partial class StructureObjectData : Form
    {
        string mode;
        int? id;
        ContextManager manager;
        private void FillData()
        {
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            
            //EnterprisesCB.DataSource = enterprises.GetAll();
            //StructureObjectsCB.DataSource = StructureObjects.GetAll();
            Model.StaffStructureObject StructureObject = StructureObjects.Get(Convert.ToInt32(id));
            NameTB.Text = StructureObject.Name;
            AllowServicesCB.Checked = StructureObject.AllowServices;
            ActiveCB.Checked = StructureObject.Active;

            if (StructureObject.ParentStructureObjectID != null)
            {
                int n = 0;
                foreach (Item i in StructureObjectsCB.Items)
                {
                    if (i.ID == Convert.ToInt32(StructureObject.ParentStructureObjectID).ToString())
                        StructureObjectsCB.SelectedIndex = n;
                    n++;
                }
            }
        }

        private void Fill()
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
            
            //list.AddRange(StructureObjects.GetAll().Select(x => new { ID = x.ID.ToString(), x.Name }).ToList() );
            
            //StructureObjectsCB.DataSource = StructureObjects.GetAll().Insert(-1, dep);

            //StructureObjectsCB.DataSource = null;
            //StructureObjectsCB.Items.Insert(0, " не вказано ");
            
            
        }


        public StructureObjectData(string _mode, int? _id)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            id = _id;
            Fill();
            if (mode == "edit")
            {
                Fill();
                FillData();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            int? parentStructureObjectID = null;
            if ((StructureObjectsCB.SelectedValue != null) & (StructureObjectsCB.SelectedIndex > 0))
            {
                int test;
                if (int.TryParse(StructureObjectsCB.SelectedValue.ToString(), out test) == true) 
                    parentStructureObjectID = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            }

            if (mode == "new")
            {
                StructureObjects.Create(NameTB.Text, AllowServicesCB.Checked, ActiveCB.Checked, parentStructureObjectID);
            }
            if (mode == "edit")
            {
                StructureObjects.Update(Convert.ToInt32(id), NameTB.Text, AllowServicesCB.Checked, ActiveCB.Checked, parentStructureObjectID);
            }
            manager.Save();

            this.Close();
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
