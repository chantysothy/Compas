using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic

{
    /// <summary>
    /// Упавління довідником виробників автомобілів
    /// </summary>
    public class CWCarBrandsLogic : IGenericInterface<CWCarBrand>
    {

        private CompasDataContext context;

        public CWCarBrandsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public CWCarBrand Get(int ID)
        {
            CWCarBrand result;

            result = (from a in context.CWCarBrands
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<CWCarBrand> GetAll()
        {
            List<CWCarBrand> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCarBrands                          
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(string Name, byte[] Image)
        {
            int result = 1;
            CWCarBrand sr = CWCarBrand.CreateCWCarBrand(1, Name);
            sr.Image = Image;
            context.AddToCWCarBrands(sr);
            return result;
        }

        public int Update(int ID, string Name, byte[] Image)
        {
            int result = 1;
            CWCarBrand sr = (from a in context.CWCarBrands
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.Image = Image;
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            CWCarBrand sr = (from a in context.CWCarBrands
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.CWCarBrands.DeleteObject(sr);

            return result;
        }

        
    }
}
