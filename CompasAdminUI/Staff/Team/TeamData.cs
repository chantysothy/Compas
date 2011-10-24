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
    public partial class TeamData : Form
    {
        string mode;
        int StructureObjectId;
        int? id;
        ContextManager manager;
        private void Fill()
        {
            StaffTeamsLogic teams = new StaffTeamsLogic(manager);
            StaffStructureObjectsLogic StructureObjects = new StaffStructureObjectsLogic(manager);
            StaffTeam team = teams.Get(Convert.ToInt32(id));
            NameTB.Text = team.Name;
            
        }

        public TeamData(string _mode, int? _id, int _StructureObjectId)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            StructureObjectId = _StructureObjectId;
            id = _id;

            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ContextManager manager = new ContextManager();
            StaffTeamsLogic teams = new StaffTeamsLogic(manager);
            if (mode == "new")
            {
                teams.Create(NameTB.Text, StructureObjectId);
            }
            if (mode == "edit")
            {
                teams.Update(Convert.ToInt32(id), NameTB.Text, StructureObjectId);
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
