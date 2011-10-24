using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Config
{
    
    /// <summary>
    /// Упавління конфігураціями
    /// 
    /// </summary>
    public class ModesLogic// : IGenericInterface<Configuration>
    {

        private CompasDataContext context;

        public ModesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public SecurityMode Get(int ID)
        {
            SecurityMode result;

            result = (from a in context.SecurityModes
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<SecurityMode> GetAll()
        {
            List<SecurityMode> result;

            result = (from a in context.SecurityModes
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }




        public int Create(string Name)
        {
            int result = 1;
            SecurityMode sr = SecurityMode.CreateSecurityMode(0, Name, Name);

            context.AddToSecurityModes(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            SecurityMode sr = (from a in context.SecurityModes
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;
           
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityMode sr = (from a in context.SecurityModes
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.SecurityModes.DeleteObject(sr);

            return result;
        }


    }
}
