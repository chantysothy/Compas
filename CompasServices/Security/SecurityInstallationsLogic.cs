using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Security
{
    public class SecurityInstallationsLogic : IGenericInterface<SecurityInstallation>
    {

        private CompasDataContext context;

        public SecurityInstallationsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public SecurityInstallation Get(int ID)
        {
            SecurityInstallation result;

            result = (from a in context.SecurityInstallations
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<SecurityInstallation> GetAll()
        {
            List<SecurityInstallation> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityInstallations                          
                          select a).ToList();
            //}
            return result;
        }

        public List<SecurityInstallation> GetAll(CompasDataContext db)
        {
            List<SecurityInstallation> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in db.SecurityInstallations
                      select a).ToList();
            
            //}
            return result;
        }

        public int Create(string InstallationID, string Description)
        {
            int result = 1;
            SecurityInstallation sr = SecurityInstallation.CreateSecurityInstallation(1,InstallationID);
            sr.Description = Description;
            context.AddToSecurityInstallations(sr);
            return result;
        }

        public int Update(int ID, string InstallationID, string Description)
        {
            int result = 1;
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityInstallation sr = (from a in context.SecurityInstallations
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.SecurityInstallations.DeleteObject(sr);

            return result;
        }

        
    }
}
