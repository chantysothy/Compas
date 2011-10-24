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
    public class DocumentTypesLogic : IGenericInterface<WareDocumentType>
    {

        private CompasDataContext context;

        public DocumentTypesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDocumentType Get(int ID)
        {
            WareDocumentType result;

            result = (from a in context.WareDocumentTypes
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareDocumentType> GetAll()
        {
            List<WareDocumentType> result;

            result = (from a in context.WareDocumentTypes
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }




        public int Create(int ID, string Name, bool Input, bool Output)
        {
            int result = 1;
            WareDocumentType sr = WareDocumentType.CreateWareDocumentType(ID, Name, Input, Output);

            context.AddToWareDocumentTypes(sr);
            return result;
        }

        public int Update(int ID, string Name, bool Input, bool Output)
        {
            int result = 1;
            WareDocumentType sr = (from a in context.WareDocumentTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;
            sr.Input = Input;
            sr.Output = Output;
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentType sr = (from a in context.WareDocumentTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            if ((sr != null) & (ID > 5))
                context.WareDocumentTypes.DeleteObject(sr);

            return result;
        }


    }
}
