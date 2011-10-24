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
using Compas.Logic.Security;
using Compas.Helpers;

namespace Compas.AdminUI.Security
{
    public partial class UserRolesForm : Form
    {
        ContextManager manager;
        int employeeId;
        int? userId;

        /// <summary>
        /// Заповнюємо список ролей
        /// </summary>
        private void FillRoles()
        {
            SecurityUserRolesLogic userRoles = new SecurityUserRolesLogic(manager);
            SecurityRolesLogic roles = new SecurityRolesLogic(manager);
            List<SecurityRole> allRoles = roles.GetAll();
            
            if (userId != null)
            {
                List<SecurityUserRole> userHasRoles = userRoles.GetAll(Convert.ToInt32(userId));

                foreach (var role in allRoles)
                {
                    Helpers.Item item = new Item();
                    item.ID = role.ID.ToString();
                    item.Name = role.Name;

                    ((ListBox)RolesLB).DisplayMember = "Name";
                    ((ListBox)RolesLB).ValueMember = "ID";

                    SecurityUserRole userRole = userHasRoles.Where(a => a.RoleID == role.ID).Select(a => a).FirstOrDefault();
                    bool selected = false;
                    if (userRole != null)
                    {
                        selected = true;
                        
                    }
                    RolesLB.Items.Add(item, selected);
                    
                }
            }
           
        }

        public UserRolesForm(int EmployeeID)
        {
            InitializeComponent();
            employeeId = EmployeeID;
            manager = new ContextManager();
            StaffEmployeeLogic employeeLogic = new StaffEmployeeLogic(manager);
            StaffEmployee employee = employeeLogic.Get(EmployeeID);
            
            if (employee != null)
            {
                if (employee.UserID != null)
                {
                    userId = Convert.ToInt32(employee.UserID);
                    SecurityUsersLogic usersLogic = new SecurityUsersLogic(manager);
                    SecurityUser user = usersLogic.Get(Convert.ToInt32(userId));
                    LoginL.Text = user.Login;
                }
                else
                    MessageBox.Show("Логін користувача відсутній");
            }

            LFML.Text = employee.LastName + " " + employee.FirstName + " " + employee.MiddleName;
            

            FillRoles();
            

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            SecurityUserRolesLogic userRoles = new SecurityUserRolesLogic(manager);
            List<int> checkedRoles = new List<int>();
            List<int> availableRoles = new List<int>();
            foreach (Object item in RolesLB.CheckedItems)
            {
                checkedRoles.Add(Convert.ToInt32(((Helpers.Item)item).ID));
            }
            foreach (Object item in RolesLB.Items)
            {
                availableRoles.Add(Convert.ToInt32(((Helpers.Item)item).ID));
            }

            foreach (int roleId in availableRoles)
            {
                if (checkedRoles.Contains(roleId))
                {
                    userRoles.Create(Convert.ToInt32(userId), roleId);
                }
                else
                {
                    userRoles.Delete(Convert.ToInt32(userId), roleId);
                }
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
