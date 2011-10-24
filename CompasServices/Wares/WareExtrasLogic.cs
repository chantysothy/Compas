using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Wares
{
    
    /// <summary>
    /// Упавління стандартними націнками
    /// </summary>
    public class WareExtrasLogic : IGenericInterface<WareExtra>
    {

        private CompasDataContext context;

        public WareExtrasLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareExtra Get(int ID)
        {
            WareExtra result;

            result = (from a in context.WareExtras
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareExtra> GetAll()
        {
            List<WareExtra> result;

            result = (from a in context.WareExtras
                      select a).ToList().OrderBy(a => a.ExtraPercent).ToList();
            
            return result;
        }




        public int Create(int ExtraPercent, bool IsDefault)
        {
            int result = 1;
            WareExtra sr = WareExtra.CreateWareExtra(1, ExtraPercent, IsDefault);

            context.AddToWareExtras(sr);
            return result;
        }

        public int Update(int ID, int ExtraPercent, bool IsDefault)
        {
            int result = 1;
            WareExtra sr = (from a in context.WareExtras
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.ExtraPercent = ExtraPercent;
            sr.Default = IsDefault;


            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareExtra sr = (from a in context.WareExtras
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareExtras.DeleteObject(sr);

            return result;
        }


    }
}
