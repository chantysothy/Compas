using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Wares
{
    
    /// <summary>
    /// Упавління довідником валют
    /// </summary>
    public class CurrenciesLogic : IGenericInterface<Currency>
    {

        private CompasDataContext context;

        public CurrenciesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public Currency Get(int ID)
        {
            Currency result;

            result = (from a in context.Currencies
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public Currency GetDefault()
        {
            Currency result;

            result = (from a in context.Currencies                      
                      select a).FirstOrDefault();


            return result;
        }

        public List<Currency> GetAll()
        {
            List<Currency> result;

            result = (from a in context.Currencies
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }




        public int Create(string Name)
        {
            int result = 1;
            Currency sr = Currency.CreateCurrency(1, Name);

            context.AddToCurrencies(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            Currency sr = (from a in context.Currencies
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            Currency sr = (from a in context.Currencies
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.Currencies.DeleteObject(sr);

            return result;
        }


    }
}
