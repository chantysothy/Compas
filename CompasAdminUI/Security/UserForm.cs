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
    public partial class UserForm : Form
    {

        string mode;
        int? id;
        int? employeeId;

        ContextManager manager;

        private void FillData()
        { 
            SecurityUsersLogic users = new SecurityUsersLogic(manager);
            if (id != null)
            {
                SecurityUser user = users.Get(Convert.ToInt32(id));

                LoginTB.Text = user.Login;
                ActiveCB.Checked = user.Active;
            }
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="_mode"></param>
        /// <param name="_id">ідентифікатор користувача </param>
        /// <param name="_id">ідентифікатор працівника </param>
        public UserForm(string _mode, int? _id, int? _employeeId)
        {
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            id = _id;
            employeeId = _employeeId;

            if ((id == null) & (employeeId != null))
            {
                StaffEmployeeLogic employees = new StaffEmployeeLogic(manager);
                StaffEmployee employee = employees.Get(Convert.ToInt32(employeeId));
                if (employee != null)
                {
                    id = employee.UserID;
                }

            }

            if (_mode == "manage")
            {
                FillData();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            string login = LoginTB.Text;
            string password = PasswordTB.Text;
            bool active = ActiveCB.Checked;
            
            string hash = "";
            hash = Helpers.Crypto.sha512encrypt(password+login);
            
            SecurityUsersLogic users = new SecurityUsersLogic(manager);
            if (id == null)
            {               
                users.Create(login, hash, active, employeeId);
                
            }
            else
            {
                users.Update(Convert.ToInt32(id), login, hash, active);
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
