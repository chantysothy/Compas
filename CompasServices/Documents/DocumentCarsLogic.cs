using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Documents
{
    
    /// <summary>
    /// Управління авто закріпленими за документами
    /// 
    /// </summary>
    public class DocumentCarsLogic : IGenericInterface<WareDocumentCar>
    {

        private CompasDataContext context;

        public DocumentCarsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareDocumentCar Get(int ID)
        {
            WareDocumentCar result;

            result = (from a in context.WareDocumentCars
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        

        public List<WareDocumentCar> GetAll()
        {
            List<WareDocumentCar> result;

            result = (from a in context.WareDocumentCars                      
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }


        public List<WareDocumentCar> GetByDocumentID(int DocumentID)
        {
            List<WareDocumentCar> result;

            result = (from a in context.WareDocumentCars
                      where a.DocumentID == DocumentID
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }


        public int Create(WareDocument Document, CWCar Car)
        {
            int result = 1;
            WareDocumentCar documentCar = new WareDocumentCar();
            Document.WareDocumentCars.Add(documentCar);
            Car.WareDocumentCars.Add(documentCar);
            return result;
        }
        
        

        public int Create(int ContractorID, int CarID)
        {
            int result = 1;
            CWContractorCar sr = new CWContractorCar();
            sr.CarID = CarID;
            sr.ContractorID = ContractorID;

            return result;
        }

        public int Update()
        {
            int result = 1;
            
            
            
            return result;
        }


        


        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentCar sr = (from a in context.WareDocumentCars
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareDocumentCars.DeleteObject(sr);

            return result;
        }


    }
}
