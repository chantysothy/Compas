using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Documents
{
    
    /// <summary>
    /// Упавління оплатами
    /// (прихідні накладні, розхідні накладні, замовлення, і т.д.)
    /// </summary>
    public class DocumentPaymentsLogic : IGenericInterface<WareDocumentPayment>
    {

        private CompasDataContext context;

        public DocumentPaymentsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDocumentPayment Get(int ID)
        {
            WareDocumentPayment result;

            result = (from a in context.WareDocumentPayments
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareDocumentPayment> GetAll()
        {
            List<WareDocumentPayment> result;

            result = (from a in context.WareDocumentPayments
                      where a.Active == true
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }

        public List<ViewPayment> GetAllView()
        {
            List<ViewPayment> result;

            result = (from a in context.ViewPayments
                      where a.Active == true
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        public List<ViewPayment> GetAllViewByPeriod(DateTime? StartDate, DateTime? EndDate)
        {
            List<ViewPayment> result;

            result = (from a in context.ViewPayments
                      where a.Active == true & (StartDate == null || (StartDate != null & a.Date >= StartDate)) &
                      (EndDate == null || (EndDate != null & a.Date < EndDate))
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        public List<ViewPayment> GetAllViewByDocumentID(int DocumentID)
        {
            List<ViewPayment> result;

            result = (from a in context.ViewPayments
                      where a.Active == true & a.DocumentID == DocumentID
                      select a).OrderBy(a => a.ID).ToList();

            return result;
        }

        public List<WareDocumentPayment> GetAllByPeriod(DateTime StartDate, DateTime EndDate)
        {
            List<WareDocumentPayment> result;

            result = (from a in context.WareDocumentPayments
                      where a.Active == true & a.Date >= StartDate & a.Date < EndDate
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        public List<WareDocumentPayment> GetByDocumentID(int DocumentID)
        {
            List<WareDocumentPayment> result;

            result = (from a in context.WareDocumentPayments
                      where a.DocumentID == DocumentID & a.Active == true
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        public decimal GetSumByDocumentID(int DocumentID)
        {
            decimal result = 0;

            var payments = from a in context.WareDocumentPayments
                      where a.DocumentID == DocumentID & a.Active == true
                      select a;
            foreach (var p in payments)
            {
                result = result + p.Suma;
            }

            

            return result;
        }

        public void UpdateDocumentPaymentSum(int DocumentID)
        {
            decimal sum = this.GetSumByDocumentID(DocumentID);
            WareDocument document = (from a in context.WareDocuments
                                     where a.ID == DocumentID
                                     select a).FirstOrDefault();

            if (document != null)
                document.PaySum = sum;
        }

        

        public int Create(DateTime Date, decimal Suma, bool Active, 
            int DocumentID, int CurrencyID, int StructureObjectID, int PaymentTypeID, int? CardID, string CheckNumber)
        {
            int result = 1;
             int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
             WareDocumentPayment sr = WareDocumentPayment.CreateWareDocumentPayment(1, Date, Suma, userId,
                 DateTime.Now, Active, DocumentID, CurrencyID, PaymentTypeID, StructureObjectID);
            //WareDocumentPayment sr = WareDocumentPayment.CreateWareDocumentType(ID, Name, Input, Output);
            if(CardID != null) 
                sr.CardID = CardID;
            sr.CheckNumber = CheckNumber;
            context.AddToWareDocumentPayments(sr);
            WareDocument document = (from a in context.WareDocuments
                                     where a.ID == DocumentID
                                     select a).FirstOrDefault();
            document.PaySum = this.GetSumByDocumentID(DocumentID) + Suma;
            return result;
        }

        public int Update(int ID, DateTime? Date, decimal Suma, int StructureObjectID, bool Active,
            int DocumentID, int CurrencyID, string CheckNumber)
        {
            int result = 1;
            WareDocumentPayment sr = (from a in context.WareDocumentPayments
                           where a.ID == ID
                           select a).FirstOrDefault();
            //if(Date != null)
            //    sr.Date = Convert.ToDateTime(Date);
            
            
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        public void CancelPayment(int ID)
        {
            WareDocumentPayment sr = (from a in context.WareDocumentPayments
                                      where a.ID == ID
                                      select a).FirstOrDefault();
            sr.Active = false;
            sr.WareDocument.PaySum = sr.WareDocument.PaySum - sr.Suma;
        }


        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentPayment sr = (from a in context.WareDocumentPayments
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareDocumentPayments.DeleteObject(sr);

            return result;
        }


    }
}
