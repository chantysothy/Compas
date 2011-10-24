using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Security
{
    public class SecurityRolesLogic : IGenericInterface<SecurityRole>
    {

        private CompasDataContext context;

        public SecurityRolesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }
            
        public SecurityRole Get(int ID)
        {
            SecurityRole result;
            
                result = (from a in context.SecurityRoles
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<SecurityRole> GetAll()
        {
            List<SecurityRole> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityRoles                          
                          select a).ToList();
            //}
            return result;
        }

        public List<SecurityRole> GetAll(CompasDataContext db)
        {
            List<SecurityRole> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in db.SecurityRoles
                      select a).ToList();
            
            //}
            return result;
        }

        public int Create(string Name, string Description)
        {
            int result = 1;
            SecurityRole sr = SecurityRole.CreateSecurityRole(1, Name);
            sr.Description = Description;
            context.AddToSecurityRoles(sr);
            return result;
        }

        public int Update(int ID, string Name, string Description)
        {
            int result = 1;
            SecurityRole sr = (from a in context.SecurityRoles
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.Description = Description;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityRole sr = (from a in context.SecurityRoles
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)                
                context.SecurityRoles.DeleteObject(sr);

            return result;
        }

        
    }
}
