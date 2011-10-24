using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління довідником моделей автомобілів
    /// </summary>
    public class CWCarModelsLogic : IGenericInterface<CWCarModel>
    {

        private CompasDataContext context;

        public CWCarModelsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public CWCarModel Get(int ID)
        {
            CWCarModel result;

            result = (from a in context.CWCarModels
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<CWCarModel> GetAll()
        {
            List<CWCarModel> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCarModels                          
                          select a).ToList();
            //}
            return result;
        }

        public List<CWCarModel> GetAll(int BrandID)
        {
            List<CWCarModel> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCarModels
                      where a.BrandID == BrandID
                      select a).ToList();
            //}
            return result;
        }

        public List<CWCarModel> GetAll(int BrandID, int? CategoryID)
        {
            List<CWCarModel> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCarModels
                      where a.BrandID == BrandID & a.CategoryID == CategoryID
                      select a).ToList();
            //}
            return result;
        }
       

        public int Create(string Name, int BrandID, byte[] Image, int CategoryID)
        {
            int result = 1;
            CWCarModel sr = CWCarModel.CreateCWCarModel(1, BrandID);
            sr.Name = Name;
            sr.Image = Image;
            sr.CategoryID = CategoryID;
            context.AddToCWCarModels(sr);
            return result;
        }

        public int Update(int ID, string Name, byte[] Image, int CategoryID)
        {
            int result = 1;
            CWCarModel sr = (from a in context.CWCarModels
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.CategoryID = CategoryID;
            sr.Image = Image;          
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            CWCarModel sr = (from a in context.CWCarModels
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.CWCarModels.DeleteObject(sr);

            return result;
        }

        
    }
}
