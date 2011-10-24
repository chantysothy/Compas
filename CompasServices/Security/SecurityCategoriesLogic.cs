using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compas.Model;

namespace Compas.Logic.Security
{
    public class SecurityCategoriesLogic : IGenericInterface<SecurityCategory>
    {

        private CompasDataContext context;

        public SecurityCategoriesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }
            
        public SecurityCategory Get(int ID)
        {
            SecurityCategory result;
            
                result = (from a in context.SecurityCategories
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<SecurityCategory> GetAll()
        {
            List<SecurityCategory> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityCategories                          
                          select a).ToList();
            //}
            return result;
        }

        public List<SecurityCategory> GetAll(CompasDataContext db)
        {
            List<SecurityCategory> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in db.SecurityCategories
                      select a).ToList();
            
            //}
            return result;
        }

        public int Create(string Name)
        {
            int result = 1;
            SecurityCategory sc = SecurityCategory.CreateSecurityCategory(1, Name);
            context.AddToSecurityCategories(sc);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            SecurityCategory sc = (from a in context.SecurityCategories
                               where a.ID == ID
                               select a).FirstOrDefault();
            sc.Name = Name;            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityCategory sc = (from a in context.SecurityCategories
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sc != null)                
                context.SecurityCategories.DeleteObject(sc);

            return result;
        }

        
    }
}
