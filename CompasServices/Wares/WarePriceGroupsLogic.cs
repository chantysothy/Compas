using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Wares
{
    
    /// <summary>
    /// Упавління групами прайсів товарів і послуг
    /// Дозволяє здійснити групування цін: Оптові, ВІП, Акційні і т.д
    /// </summary>
    public class WarePriceGroupsLogic : IGenericInterface<WarePriceGroup>
    {

        private CompasDataContext context;

        public WarePriceGroupsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WarePriceGroup Get(int ID)
        {
            WarePriceGroup result;

            result = (from a in context.WarePriceGroups
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WarePriceGroup> GetAll()
        {
            List<WarePriceGroup> result;

            result = (from a in context.WarePriceGroups
                      select a).ToList();
            
            return result;
        }

        public List<WarePriceGroup> GetAll(int WareID)
        {
            List<WarePriceGroup> result;

            result = (from a in context.WarePrices
                      where a.WareID == WareID & a.Active == true
                      select a.WarePriceGroup).Distinct().ToList();

            return result;
        }




        public int Create(string Name, bool Active, int? DefaultExtraPercent)
        {
            int result = 1;
            WarePriceGroup sr = WarePriceGroup.CreateWarePriceGroup(1, Name, Active);
            sr.DefaultExtraPercent = DefaultExtraPercent;
            context.AddToWarePriceGroups(sr);
            return result;
        }

        public int Update(int ID, string Name, bool Active, int? DefaultExtraPercent)
        {
            int result = 1;
            WarePriceGroup sr = (from a in context.WarePriceGroups
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;
            sr.Active = Active;
            sr.DefaultExtraPercent = DefaultExtraPercent;


            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WarePriceGroup sr = (from a in context.WarePriceGroups
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WarePriceGroups.DeleteObject(sr);

            return result;
        }


    }
}
