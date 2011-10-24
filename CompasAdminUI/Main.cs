using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Logic.Security;

namespace Compas.AdminUI
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
            
            //MessageBox.Show(CurrentSecurityContext.Identity.Name + " " + CurrentSecurityContext.Identity.IsAuthenticated.ToString());
            
        }

        private void RolesMI_Click(object sender, EventArgs e)
        {
            Security.RolesForm roles = new Security.RolesForm();
            roles.ShowDialog();
        }

        private void CategoriesMI_Click(object sender, EventArgs e)
        {
            Security.CategoriesForm categories = new Security.CategoriesForm();
            categories.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //securityCategoryBindingSource.
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ActionsMI_Click(object sender, EventArgs e)
        {
            Security.ActionsForm actions = new Security.ActionsForm();
            actions.ShowDialog();
        }

        private void правилаРолейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.RoleActionsF actions = new Security.RoleActionsF();
            actions.ShowDialog();
        }

        private void PersonalMI_Click(object sender, EventArgs e)
        {

        }

        

        private void StructureObjectsMI_Click(object sender, EventArgs e)
        {
            Staff.StructureObject.StructureObjectsList form = new Staff.StructureObject.StructureObjectsList();
            form.ShowDialog();
        }

        private void TeamsMI_Click(object sender, EventArgs e)
        {
            //Staff.Team.TeamsList form = new Staff.Team.TeamsList();
            //form.ShowDialog();
        }

        private void EmployeeMI_Click(object sender, EventArgs e)
        {
            Staff.Employee.EmployeesList form = new Staff.Employee.EmployeesList();
            form.ShowDialog();
        }

        
    }
}
