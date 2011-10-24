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

namespace Compas.AdminUI.Staff.Team
{
    public partial class TeamsList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void Fill()
        {
            StaffTeamsLogic teams = new StaffTeamsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = teams.GetByStructureObject(StructureObjectId);
            DataGV.Update();

        }

        public TeamsList(int _StructureObjectId)
        {
            InitializeComponent();
            manager = new ContextManager();
            DataGV.AutoGenerateColumns = false;
            StructureObjectId = _StructureObjectId;
            Fill();
           
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            Team.TeamData form = new TeamData("new", null, StructureObjectId);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Team.TeamData form = new TeamData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), StructureObjectId);
            form.ShowDialog();
            manager.Save();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            StaffTeamsLogic teams = new StaffTeamsLogic(manager);
            teams.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void TeamsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }
    }
}
