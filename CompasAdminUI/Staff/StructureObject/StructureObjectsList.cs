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

namespace Compas.AdminUI.Staff.StructureObject
{
    public partial class StructureObjectsList : Form
    {
        private void FillGrid()
        {
            ContextManager manager = new ContextManager();
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);

            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = StructureObjects.GetAll();
            BindingSource bs = new BindingSource();
            //bs.DataSource = StructureObjects.GetAll().Select(x => new { 
            //    x.ID, 
            //    x.Name,
            //    x.Active, 
            //    x.AllowServices, 
            //    ParrentStructureObjectName = (x.StaffStructureObject1 == null ? "" : x.StaffStructureObject1.Name)
            //    });
            bs.DataSource = StructureObjects.GetHeirarchyView();
            DataGV.DataSource = bs;
            //ataGridView1.DataSource = StructureObjects.GetAll();//.Select(x => new { x.ID, x.Name, x.Active, x.AllowServices, ParrentStructureObjectName = (x.StaffStructureObject1 == null ? "" : x.StaffStructureObject1.Name) });
            //foreach (var a in StructureObjects.GetAll().Select(x => new { x.ID, x.Name, x.Active, x.AllowServices, ParentStructureObjectName = (x.StaffStructureObject1 == null ? "" : x.StaffStructureObject1.Name) }))
            //{

            //    MessageBox.Show(a.ParentStructureObjectName /* + (a.StaffStructureObject1 == null ? "" : a.StaffStructureObject1.Name)*/);
            //}
            
            DataGV.Update();
            
            manager.CloseContext();
        }

        public StructureObjectsList()
        {
            InitializeComponent();
            ContextManager manager = new ContextManager();
            
            manager.CloseContext();
            FillGrid();
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            StructureObjectData form = new StructureObjectData("new", null);            
            form.ShowDialog();
            FillGrid();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            StructureObjects.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            manager.CloseContext();
            FillGrid();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            StructureObjectData form = new StructureObjectData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            FillGrid();
        }

        private void EnterprisesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGV.Columns[e.ColumnIndex].Name == "Teams")
                {
                    Staff.Team.TeamsList form = new Team.TeamsList(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
                    form.ShowDialog();
                }
            }
            
            
        }
    }
}
