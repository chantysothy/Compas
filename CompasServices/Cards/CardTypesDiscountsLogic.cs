using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління присвоєнням знижок типам карток
    /// 
    /// </summary>
    public class CardTypesDiscountsLogic : IGenericInterface<WareCardTypeDiscount>
    {

        private CompasDataContext context;

        public CardTypesDiscountsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareCardTypeDiscount Get(int ID)
        {
            WareCardTypeDiscount result;

            result = (from a in context.WareCardTypeDiscounts
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareCardTypeDiscount> GetAll()
        {
            List<WareCardTypeDiscount> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCardTypeDiscounts                          
                          select a).ToList();
            //}
            return result;
        }

        public List<WareCardTypeDiscount> GetAll(int CardTypeID)
        {
            List<WareCardTypeDiscount> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCardTypeDiscounts
                      where a.CardTypeID == CardTypeID
                      select a).ToList();
            //}
            return result;
        }


        public bool Check(WareCardType CardType, int DiscountID)
        {
            List<WareCardTypeDiscount> result = new List<WareCardTypeDiscount>();
            //using (var cdc = new CompasDataContext())
            //{
            if (CardType != null)
            {
                result = (from a in context.WareCardTypeDiscounts
                          where a.DiscountID == DiscountID & a.CardTypeID == CardType.ID
                          select a).ToList();
            }
            //}

            return result.Count > 0 ? true : false;
        }

        public int Create(int CardTypeID, int DiscountID, DateTime StartDate, DateTime? EndDate)
        {
            int result = 1;
            WareCardTypeDiscount sr = WareCardTypeDiscount.CreateWareCardTypeDiscount(1, CardTypeID, DiscountID, StartDate);
            sr.EndDate = EndDate;
            
            context.AddToWareCardTypeDiscounts(sr);
            return result;
        }

        public int Create(WareCardType CardType, int DiscountID, DateTime StartDate, DateTime? EndDate)
        {
            int result = 1;

            if (this.Check(CardType, DiscountID) == false)
            {

                WareCardTypeDiscount sr = new WareCardTypeDiscount();
                sr.DiscountID = DiscountID;
                sr.StartDate = StartDate;
                sr.EndDate = EndDate;


                CardType.WareCardTypeDiscounts.Add(sr);
                context.AddToWareCardTypeDiscounts(sr);
            }
            return result;
        }

        public int Update(int ID, int DiscountID, DateTime StartDate, DateTime? EndDate)
        {
            int result = 1;
            WareCardTypeDiscount sr = (from a in context.WareCardTypeDiscounts
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.DiscountID = DiscountID;
            sr.StartDate = StartDate;
            sr.EndDate = EndDate;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareCardTypeDiscount sr = (from a in context.WareCardTypeDiscounts
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareCardTypeDiscounts.DeleteObject(sr);

            return result;
        }

        public int DeleteAll(int CarTypeID)
        {
            int result = 1;
            IEnumerable<WareCardTypeDiscount> sr = from a in context.WareCardTypeDiscounts
                                       where a.CardTypeID == CarTypeID
                                       select a;
            foreach (WareCardTypeDiscount a in sr)
            {
                context.WareCardTypeDiscounts.DeleteObject(a);
            }

            return result;
        }

        public int Delete(List<WareDiscount> Discounts, int CardTypeID  )
        {
            int result = 1;
            List<int> discountsId = (from a in Discounts
                                     select a.ID).ToList();
            IEnumerable<WareCardTypeDiscount> sr = from a in context.WareCardTypeDiscounts
                                                   where a.CardTypeID == CardTypeID
                                                   & !discountsId.Contains(a.DiscountID)
                                                   select a;
            foreach (WareCardTypeDiscount a in sr)
            {
                context.WareCardTypeDiscounts.DeleteObject(a);
            }

            return result;
        }

        
    }
}
