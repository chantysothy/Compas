using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compas.Model;

namespace Compas.Logic.Security
{
    public class SecurityActionsLogic : IGenericInterface<SecurityAction>
    {

        private CompasDataContext context;

        public SecurityActionsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public SecurityAction Get(int ID)
        {
            SecurityAction result;

            result = (from a in context.SecurityActions
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<SecurityAction> GetAll()
        {
            List<SecurityAction> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityActions
                      select a).ToList();
            //}
            return result;
        }

        public List<SecurityAction> GetByCategory(int CategoryID)
        {
            List<SecurityAction> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityActions
                      where a.CategoryID == CategoryID
                      select a).ToList();
            //}
            return result;
        }

        public List<SecurityAction> GetAll(CompasDataContext db)
        {
            List<SecurityAction> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in db.SecurityActions
                      select a).ToList();

            //}
            return result;
        }

        public int Create(string Name, string Code, int CategoryID, string Description)
        {
            int result = 1;
            SecurityAction sc = SecurityAction.CreateSecurityAction(1, Name, Code, CategoryID);
            sc.Description = Description;
            context.AddToSecurityActions(sc);
            return result;
        }

        public int Update(int ID, string Name, int CategoryID, string Code, string Description)
        {
            int result = 1;
            SecurityAction sc = (from a in context.SecurityActions
                                   where a.ID == ID
                                   select a).FirstOrDefault();
            sc.Name = Name;

            sc.CategoryID = CategoryID;
            sc.Description = Description;
            sc.Code = Code;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityAction sc = (from a in context.SecurityActions
                                   where a.ID == ID
                                   select a).FirstOrDefault();
            if (sc != null)
                context.SecurityActions.DeleteObject(sc);

            return result;
        }


    }
}
