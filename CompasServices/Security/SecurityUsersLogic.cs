 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Logic.Staff;

namespace Compas.Logic.Security
{
    public class SecurityUsersLogic : IGenericInterface<SecurityUser>
    {
        
        private CompasDataContext context;
        private ContextManager manager;

        public SecurityUsersLogic(ContextManager contextManager)
        {

            manager = contextManager;
            context = manager.Context;
        }

        

        public SecurityUser Get(int ID)
        {
            SecurityUser result;

            result = (from a in context.SecurityUsers
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        /// <summary>
        /// Метод перевірки дозволеності виконання певної дії
        /// </summary>
        /// <param name="UserID">Ідентифікатор користувача</param>
        /// <param name="ActionCode">Код дії</param>
        /// <returns>True якщо дія дозволена, інакше False</returns>
        public bool CheckAction(int UserID, string ActionCode)
        {
            //ContextManager intManger = new ContextManager();
            //CompasDataContext intContext = intManger.Context;
            //по замовчуванню дія заборонена, якщо не дозволена явно
            bool result = false;

            //шукаємо ролі до яких належить користувач
            var userRoles = from a in context.SecurityUserRoles
                      where a.UserID == UserID
                      select a;
            if (UserID == 1)
                result = true;
            else
                foreach (var userRole in userRoles)
                {
                    var action = (from a in context.SecurityRoleActions
                                  where a.SecurityAction.Code == ActionCode &
                                        a.RoleID == userRole.RoleID &
                                        a.Allow == true
                                  select a).FirstOrDefault();

                    if (action != null)
                    {
                        result = true;
                    }
                }

            //intManger.CloseContext();
            return result;
        }

        public int Get(string Login, string Hash)
        {
            int result = -1;

            SecurityUser user = (from a in context.SecurityUsers
                      where a.Login == Login & a.Hash == Hash
                      select a).FirstOrDefault();

            if (user != null)
                result = user.ID;
            return result;
        }


        /// <summary>
        /// всі акаунти
        /// </summary>
        /// <returns></returns>
        public List<SecurityUser> GetAll()
        {
            List<SecurityUser> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityUsers                          
                          select a).ToList();
            //}
            return result;
        }
        

        public int Create(string Login, string Hash, bool Active, int? EmployeeID)
        {
            int result = 1;
            SecurityUser sr = SecurityUser.CreateSecurityUser(1,true);
              
            sr.Login = Login;
            sr.Hash = Hash;
            sr.Active = Active;
            if (EmployeeID != null)
            {               
                int employeeId = Convert.ToInt32(EmployeeID);
                StaffEmployee e = (from a in context.StaffEmployees
                                   where a.ID == employeeId
                                   select a).FirstOrDefault();
               
                e.SecurityUser = sr;               
            }
            context.AddToSecurityUsers(sr);
          
            result = sr.ID;
            return result;
        }

        public int Update(int ID, string Login, string Hash, bool Active)
        {
            int result = 1;
            SecurityUser sr = (from a in context.SecurityUsers
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Login = Login;
            sr.Hash = Hash;
            sr.Active = Active;
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityUser sr = (from a in context.SecurityUsers
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.SecurityUsers.DeleteObject(sr);

            return result;
        }

        
    }
    
}
