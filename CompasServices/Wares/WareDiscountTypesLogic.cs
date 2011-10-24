using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{
    /// <summary>
    /// Упавління довідником Типи знижок
    /// </summary>
    public class WareDiscountTypesLogic : IGenericInterface<WareDiscountType>
    {

        private CompasDataContext context;

        public WareDiscountTypesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDiscountType Get(int ID)
        {
            WareDiscountType result;

            result = (from a in context.WareDiscountTypes
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareDiscountType> GetAll()
        {
            List<WareDiscountType> result;
           
            result = (from a in context.WareDiscountTypes                          
                          select a).ToList();
           
            return result;
        }


        public int Create(string Name)
        {
            int result = 1;
            WareDiscountType sr = WareDiscountType.CreateWareDiscountType(1, Name);

            context.AddToWareDiscountTypes(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            WareDiscountType sr = (from a in context.WareDiscountTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            if(sr != null)
                sr.Name = Name;           
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDiscountType sr = (from a in context.WareDiscountTypes
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareDiscountTypes.DeleteObject(sr);

            return result;
        }

        
    }
}
