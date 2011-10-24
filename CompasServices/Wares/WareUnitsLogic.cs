using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{
    /// <summary>
    /// Упавління довідником Одиниць вимірювання товарів і послуг
    /// </summary>
    public class WareUnitsLogic : IGenericInterface<WareUnit>
    {

        private CompasDataContext context;

        public WareUnitsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareUnit Get(int ID)
        {
            WareUnit result;

            result = (from a in context.WareUnits
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareUnit> GetAll()
        {
            List<WareUnit> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareUnits                          
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(string Name)
        {
            int result = 1;
            WareUnit sr = WareUnit.CreateWareUnit(1, Name);
            
            context.AddToWareUnits(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            WareUnit sr = (from a in context.WareUnits
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareUnit sr = (from a in context.WareUnits
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareUnits.DeleteObject(sr);

            return result;
        }

        
    }
}
