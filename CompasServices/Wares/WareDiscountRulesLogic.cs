using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{
    /// <summary>
    /// Упавління правилами застосування знижок
    /// </summary>
    public class WareDiscountRulesLogic : IGenericInterface<WareDiscountRule>
    {

        private CompasDataContext context;

        public WareDiscountRulesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDiscountRule Get(int ID)
        {
            WareDiscountRule result;

            result = (from a in context.WareDiscountRules
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareDiscountRule> GetAll()
        {
            List<WareDiscountRule> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareDiscountRules                          
                          select a).ToList();
            //}
            return result;
        }

        public List<WareDiscountRule> GetAllByDiscountID(int DiscountID)
        {
            List<WareDiscountRule> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareDiscountRules
                      where a.DiscountID == DiscountID
                      select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(int DiscountID, decimal StartSuma, decimal? EndSuma, decimal? DiscountPercent)
        {
            int result = 1;
            WareDiscountRule sr = WareDiscountRule.CreateWareDiscountRule(1, DiscountID, StartSuma);
            if(EndSuma != null)
                sr.EndSuma = EndSuma;
            if(DiscountPercent != null)
                sr.DiscountPercent = DiscountPercent;
            
            context.AddToWareDiscountRules(sr);
            return result;
        }

        public int Update(int ID, decimal StartSuma, decimal? EndSuma, decimal? DiscountPercent)
        {
            int result = 1;
            WareDiscountRule sr = (from a in context.WareDiscountRules
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.StartSuma = StartSuma;
            sr.EndSuma = EndSuma;
            sr.DiscountPercent = DiscountPercent;
            
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDiscountRule sr = (from a in context.WareDiscountRules
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareDiscountRules.DeleteObject(sr);

            return result;
        }

        
    }
}
