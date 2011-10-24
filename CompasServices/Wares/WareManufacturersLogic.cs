using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{
    /// <summary>
    /// Упавління довідником Виробників товарів
    /// </summary>
    public class WareManufacturersLogic : IGenericInterface<WareManufacturer>
    {

        private CompasDataContext context;

        public WareManufacturersLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareManufacturer Get(int ID)
        {
            WareManufacturer result;

            result = (from a in context.WareManufacturers
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareManufacturer> GetAll()
        {
            List<WareManufacturer> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareManufacturers                          
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(string Name)
        {
            int result = 1;
            WareManufacturer sr = WareManufacturer.CreateWareManufacturer(1);
            sr.Name = Name;
            context.AddToWareManufacturers(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            WareManufacturer sr = (from a in context.WareManufacturers
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareManufacturer sr = (from a in context.WareManufacturers
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareManufacturers.DeleteObject(sr);

            return result;
        }

        
    }
}
