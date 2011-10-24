using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління довідником типів карток
    /// </summary>
    public class CardTypesLogic : IGenericInterface<WareCardType>
    {

        private CompasDataContext context;

        public CardTypesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareCardType Get(int ID)
        {
            WareCardType result;

            result = (from a in context.WareCardTypes
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareCardType> GetAll()
        {
            List<WareCardType> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCardTypes                          
                          select a).ToList();
            //}
            return result;
        }




        public WareCardType Create(string Name, bool AllowBalance, bool AllowMultipleCars)
        {
            int result = 1;
            
            WareCardType sr = WareCardType.CreateWareCardType(-1, Name, AllowBalance);           
            context.AddToWareCardTypes(sr);
            return sr;
        }



        public WareCardType Update(int ID, string Name, bool AllowBalance, bool AllowMultipleCars)
        {
            int result = 1;
            WareCardType sr = (from a in context.WareCardTypes
                             where a.ID == ID
                             select a).FirstOrDefault();
            sr.Name = Name;
            sr.AllowBalance = AllowBalance;
            sr.AllowMultipleCars = AllowMultipleCars;
            return sr;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareCardType sr = (from a in context.WareCardTypes
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareCardTypes.DeleteObject(sr);

            return result;
        }

        
    }
}
