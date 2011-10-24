using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління довідником підприємств
    /// </summary>
    public class EnterprisesLogic : IGenericInterface<Enterprise>
    {

        private CompasDataContext context;

        public EnterprisesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public Enterprise Get(int ID)
        {
            Enterprise result;

            result = (from a in context.Enterprises
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<Enterprise> GetAll()
        {
            List<Enterprise> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.Enterprises                       
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(string Name)
        {
            int result = 1;
            Enterprise sr = Enterprise.CreateEnterprise(1, Name);

            context.AddToEnterprises(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            Enterprise sr = (from a in context.Enterprises
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            Enterprise sr = (from a in context.Enterprises
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.Enterprises.DeleteObject(sr);

            return result;
        }

        
    }
}
