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
    public class WareTimeLimitsLogic : IGenericInterface<WareTimeLimit>
    {

        private CompasDataContext context;

        public WareTimeLimitsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareTimeLimit Get(int ID)
        {
            WareTimeLimit result;

            result = (from a in context.WareTimeLimits
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public WareTimeLimit GetByWareID(int WareID)
        {
            WareTimeLimit result;

            result = (from a in context.WareTimeLimits
                      where a.WareID == WareID & a.Active == true
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareTimeLimit> GetAll()
        {
            List<WareTimeLimit> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareTimeLimits                          
                          select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(int WareID, Decimal TimeLimit, bool Active)
        {
            int result = 1;
            WareTimeLimit sr = WareTimeLimit.CreateWareTimeLimit(1, WareID, TimeLimit, Active);
            
            context.AddToWareTimeLimits(sr);
            return result;
        }

        public int Create(Ware ware, Decimal TimeLimit, bool Active)
        {
            int result = 1;

            IEnumerable<WareTimeLimit> timeLimitsExists = ware.WareTimeLimits.Where(a => a.Active == true & a.TimeLimit != TimeLimit);

            if (timeLimitsExists != null)
            {
                if (timeLimitsExists.Count() > 0)
                {
                    foreach (WareTimeLimit limit in timeLimitsExists)
                    {
                        if (limit.TimeLimit != TimeLimit)
                        {
                            limit.Active = false;
                        }
                    }
                }
            }
            IEnumerable<WareTimeLimit> currentTimeLimitsExists = ware.WareTimeLimits.Where(a => a.Active == true & a.TimeLimit == TimeLimit);
            if(currentTimeLimitsExists.Count() == 0)
            {
                WareTimeLimit sr = new WareTimeLimit();
                sr.TimeLimit = TimeLimit;
                sr.Active = Active;
                ware.WareTimeLimits.Add(sr);
                context.AddToWareTimeLimits(sr);
            }
            return result;
        }

       
        public int Update(int ID, Decimal TimeLimit, bool Active)
        {
            int result = 1;
            WareTimeLimit sr = (from a in context.WareTimeLimits
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.TimeLimit = TimeLimit;
            sr.Active = Active;
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareTimeLimit sr = (from a in context.WareTimeLimits
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareTimeLimits.DeleteObject(sr);

            return result;
        }

        
    }
}
