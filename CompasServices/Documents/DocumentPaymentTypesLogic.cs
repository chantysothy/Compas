using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Documents
{
    
    /// <summary>
    /// Упавління довідником типів документів
    /// (прихідні накладні, розхідні накладні, замовлення, і т.д.)
    /// </summary>
    public class DocumentPaymentTypesLogic : IGenericInterface<WareDocumentPaymentType>
    {

        private CompasDataContext context;

        public DocumentPaymentTypesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDocumentPaymentType Get(int ID)
        {
            WareDocumentPaymentType result;

            result = (from a in context.WareDocumentPaymentTypes
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareDocumentPaymentType> GetAll()
        {
            List<WareDocumentPaymentType> result;

            result = (from a in context.WareDocumentPaymentTypes
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }




        public int Create(string Name)
        {
            int result = 1;
            WareDocumentPaymentType sr = WareDocumentPaymentType.CreateWareDocumentPaymentType(1, Name);

            context.AddToWareDocumentPaymentTypes(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            WareDocumentPaymentType sr = (from a in context.WareDocumentPaymentTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;           
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentPaymentType sr = (from a in context.WareDocumentPaymentTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareDocumentPaymentTypes.DeleteObject(sr);

            return result;
        }


    }
}
