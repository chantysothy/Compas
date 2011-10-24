using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління довідником категорій автомобілів(легкові, вантажні і т.д.)
    /// </summary>
    public class CWCategoriesLogic : IGenericInterface<CWCategory>
    {

        private CompasDataContext context;

        public CWCategoriesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public CWCategory Get(int ID)
        {
            CWCategory result;

            result = (from a in context.CWCategories
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<CWCategory> GetAll()
        {
            List<CWCategory> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCategories                          
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(string Name, int? ParentCategoryID, int? Priority)
        {
            int result = 1;
            CWCategory sr = CWCategory.CreateCWCategory(1);
            sr.Name = Name;
            sr.ParentCategoryID = ParentCategoryID;
            sr.Priority = Priority;
            context.AddToCWCategories(sr);
            return result;
        }

        public int Update(int ID, string Name, int? ParentCategoryID, int? Priority)
        {
            int result = 1;
            CWCategory sr = (from a in context.CWCategories
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.ParentCategoryID = ParentCategoryID;
            sr.Priority = Priority;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            CWCategory sr = (from a in context.CWCategories
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.CWCategories.DeleteObject(sr);

            return result;
        }

        
    }
}
