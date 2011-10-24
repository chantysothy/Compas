using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Compas.Logic;
using Compas.Logic.Security;


namespace Compas.AdminUI.Security
{
    public partial class RolesForm : Form
    {
        private void FillGrid()
        {
            ContextManager manager = new ContextManager();
            SecurityRolesLogic sr = new SecurityRolesLogic(manager);
            RolesGV.DataSource = sr.GetAll();
            manager.CloseContext();
        }


        public RolesForm()
        {
            InitializeComponent();
            RolesGV.AutoGenerateColumns = false;
            FillGrid();

        }

        private void RolesGV_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void AddBt_Click(object sender, EventArgs e)
        {
           
           
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            SecurityRolesLogic sr = new SecurityRolesLogic(manager);
            sr.Delete(Convert.ToInt32(RolesGV.SelectedRows[0].Cells[0].FormattedValue));
            manager.Save();
            FillGrid();
            manager.CloseContext();
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            //string[] args = new string[] { "new" };
            
            RoleNew rn = new RoleNew();
            rn.ShowDialog();
            FillGrid();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            RoleEdit rn = new RoleEdit(Convert.ToInt32(RolesGV.SelectedRows[0].Cells[0].FormattedValue));
            rn.ShowDialog();
            FillGrid();
        }

      

       
    }
}
