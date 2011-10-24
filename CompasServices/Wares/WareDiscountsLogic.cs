using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{
    /// <summary>
    /// Упавління довідником Знижки
    /// </summary>
    public class WareDiscountsLogic : IGenericInterface<WareDiscount>
    {

        private CompasDataContext context;

        public WareDiscountsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDiscount Get(int ID)
        {
            WareDiscount result;

            result = (from a in context.WareDiscounts
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareDiscount> GetAll()
        {
            List<WareDiscount> result;

            result = (from a in context.WareDiscounts                          
                          select a).ToList();
            
            return result;
        }

        public List<WareDiscount> GetAll(int? DiscountTypeID, bool? Active)
        {
            List<WareDiscount> result;

            result = (from a in context.WareDiscounts
                      where ((DiscountTypeID == null) || (a.DiscountTypeID == DiscountTypeID)) &
                      ((Active == null) || (a.Active == Active))
                      select a).ToList();

            return result;
        }
        
       

        public int Create(string Name, bool Active, int DiscountTypeID, decimal DefaultDiscountPercent)
        {
            int result = 1;
            WareDiscount sr = WareDiscount.CreateWareDiscount(1, Name, Active, DefaultDiscountPercent);
            sr.DiscountTypeID = DiscountTypeID;
            context.AddToWareDiscounts(sr);
            return result;
        }

        public int Update(int ID, string Name, bool Active, int DiscountTypeID, decimal DefaultDiscountPercent)
        {
            int result = 1;
            WareDiscount sr = (from a in context.WareDiscounts
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
            {
                sr.Name = Name;
                sr.DiscountTypeID = DiscountTypeID;
                sr.DefaultDiscountPercent = DefaultDiscountPercent;
            }
            
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDiscount sr = (from a in context.WareDiscounts
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareDiscounts.DeleteObject(sr);

            return result;
        }

        
    }
}
