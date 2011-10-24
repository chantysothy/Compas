using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління операціями з балансом картки
    /// </summary>
    public class CardBalanceOperationsLogic : IGenericInterface<WareCardBalanceOperation>
    {

        private CompasDataContext context;

        public CardBalanceOperationsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareCardBalanceOperation Get(int ID)
        {
            WareCardBalanceOperation result;

            result = (from a in context.WareCardBalanceOperations
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareCardBalanceOperation> GetAll()
        {
            List<WareCardBalanceOperation> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCardBalanceOperations                          
                          select a).ToList();
            //}
            return result;
        }




        public WareCardBalanceOperation Create(int CardID, decimal Suma, DateTime Date, int DocumentID )
        {
            int result = 1;
            
            WareCardBalanceOperation sr = WareCardBalanceOperation.CreateWareCardBalanceOperation(-1, CardID, Suma, Date, Security.CurrentSecurityContext.Identity.ID, DocumentID);           
            context.AddToWareCardBalanceOperations(sr);
            return sr;
        }



        public WareCardBalanceOperation Update(int ID, decimal Suma, DateTime Date, int DocumentID)
        {
            int result = 1;
            WareCardBalanceOperation sr = (from a in context.WareCardBalanceOperations
                             where a.ID == ID
                             select a).FirstOrDefault();
            sr.Suma = Suma;
            sr.Date = Date;
            sr.DocumentID = DocumentID;
            return sr;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareCardBalanceOperation sr = (from a in context.WareCardBalanceOperations
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareCardBalanceOperations.DeleteObject(sr);

            return result;
        }

        
    }
}
