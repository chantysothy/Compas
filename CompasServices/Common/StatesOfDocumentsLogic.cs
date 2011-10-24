using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic
{
    
    /// <summary>
    /// Упавління довідником статусу документів
    /// </summary>
    public class StatesOfDocumentsLogic : IGenericInterface<StatesOfDocument>
    {

        private CompasDataContext context;

        public StatesOfDocumentsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public StatesOfDocument Get(int ID)
        {
            StatesOfDocument result;

            result = (from a in context.StatesOfDocuments
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        //public StatesOfDocument GetDefault()
        //{
        //    StatesOfDocument result;

        //    result = (from a in context.Currencies                      
        //              select a).FirstOrDefault();


        //    return result;
        //}

        public List<StatesOfDocument> GetAll()
        {
            List<StatesOfDocument> result;

            result = (from a in context.StatesOfDocuments
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }




        public int Create(int ID, string Name)
        {
            int result = 1;
            StatesOfDocument sr = StatesOfDocument.CreateStatesOfDocument(1, Name);

            context.AddToStatesOfDocuments(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            StatesOfDocument sr = (from a in context.StatesOfDocuments
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StatesOfDocument sr = (from a in context.StatesOfDocuments
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.StatesOfDocuments.DeleteObject(sr);

            return result;
        }


    }
}
