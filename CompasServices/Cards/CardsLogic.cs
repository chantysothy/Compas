using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління картками
    /// </summary>
    /// 
    public class CardView
    {
        WareCard card;
        public CardView(WareCard Card)
        {
            card = Card;
        }

        
        public int ID
        {
            get { return card.ID; }
        }
        public string Code
        {
            get { return card.Code; }
        }

        public string CardTypeName
        {
            get { return card.WareCardType.Name; }
        }
        public bool Active
        {
            get { return card.Active; }
        }

        public DateTime? IssuedDate
        {
            get { return card.IssuedDate; }
        }

        public DateTime? UsedDate
        {
            get { return card.UsedDate; }
        }


    }


    public class CardsLogic : IGenericInterface<WareCard>
    {

        private CompasDataContext context;

        public CardsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareCard Get(int ID)
        {
            WareCard result;

            result = (from a in context.WareCards
                         where a.ID == ID
                         select a).FirstOrDefault();
            
            return result;
        }

        public WareCard GetByCode(string Code)
        {
            WareCard result;

            result = (from a in context.WareCards
                      where a.Code == Code
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareCard> GetAll()
        {
            List<WareCard> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCards 
                      orderby a.Code   
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(string Code, int CardTypeID, bool Active, DateTime? IssuedDate)
        {
            int result = 1;
            WareCard sr = WareCard.CreateWareCard(1, Code, CardTypeID, Active);
            sr.IssuedDate = IssuedDate;
            
            context.AddToWareCards(sr);
            return result;
        }

        public int Update(int ID, string Code, int CardTypeID, bool Active, DateTime? IssuedDate)
        {
            int result = 1;
            WareCard sr = (from a in context.WareCards
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Code = Code;
            sr.CardTypeID = CardTypeID;
            sr.Active = Active;
            sr.IssuedDate = IssuedDate;
            return result;
        }

        public int Update(int ID, DateTime UsedDate)
        {
            int result = 1;
            WareCard sr = this.Get(ID);
            if (sr != null)
                sr.UsedDate = UsedDate;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareCard sr = (from a in context.WareCards
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareCards.DeleteObject(sr);

            return result;
        }

        
    }
}
