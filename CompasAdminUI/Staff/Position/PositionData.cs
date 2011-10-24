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

namespace Compas.AdminUI.Staff.Position
{
    public partial class PositionData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            StaffPositionsLogic positions = new StaffPositionsLogic(manager);
            StaffPosition position = positions.Get(Convert.ToInt32(id));
            if (position != null)
            {

                NameTB.Text = position.Name;
                ActiveCB.Checked = position.Active;
            }
            //StaffTeam team = teams.Get(Convert.ToInt32(id));
            //NameTB.Text = team.Name;
            
        }

        public PositionData(string _mode, int? _id)
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

            StaffPositionsLogic positions = new StaffPositionsLogic(manager);
           
            if (mode == "new")
            {
                positions.Create(NameTB.Text, ActiveCB.Checked);
            }
            if (mode == "edit")
            {
                positions.Update(Convert.ToInt32(id), NameTB.Text, ActiveCB.Checked);
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
