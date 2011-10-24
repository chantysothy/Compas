 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Logic.Staff;

namespace Compas.Logic.Security
{
    public class SecurityUserRolesLogic : IGenericInterface<SecurityUserRole>
    {
        
        private CompasDataContext context;
        private ContextManager manager;

        public SecurityUserRolesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public SecurityUserRole Get(int ID)
        {
            SecurityUserRole result;

            result = (from a in context.SecurityUserRoles
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public SecurityUserRole Get(int UserID, int RoleID)
        {
            SecurityUserRole result;

            result = (from a in context.SecurityUserRoles
                      where a.UserID == UserID & a.RoleID == RoleID
                      select a).FirstOrDefault();


            return result;
        }
        


        /// <summary>
        /// всі ролі
        /// </summary>
        /// <returns></returns>
        public List<SecurityUserRole> GetAll()
        {
            List<SecurityUserRole> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityUserRoles                          
                          select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// всі ролі
        /// </summary>
        /// <returns></returns>
        public List<SecurityUserRole> GetAll(int UserID)
        {
            List<SecurityUserRole> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityUserRoles
                      where a.UserID == UserID
                      select a).ToList();
            //}
            return result;
        }

        public int Create(int UserID, int RoleID)
        {
            int result = 1;            

            SecurityUserRole role = this.Get(UserID, RoleID);
            if (role == null)
            {
                SecurityUserRole sr = SecurityUserRole.CreateSecurityUserRole(1, UserID, RoleID);
                context.AddToSecurityUserRoles(sr);
                result = sr.ID;
            }
            
            return result;
        }

       

        public int Delete(int ID)
        {
            int result = 1;
            SecurityUserRole sr = (from a in context.SecurityUserRoles
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.SecurityUserRoles.DeleteObject(sr);

            return result;
        }

        public int Delete(int UserID, int RoleID)
        {
            int result = 1;
            SecurityUserRole sr = (from a in context.SecurityUserRoles
                                   where a.UserID == UserID & a.RoleID == RoleID
                                   select a).FirstOrDefault();
            if (sr != null)
                context.SecurityUserRoles.DeleteObject(sr);

            return result;
        }

        
    }
    
}
