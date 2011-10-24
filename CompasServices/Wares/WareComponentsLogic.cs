using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{

    public class WareComponentView
    {
        WareComponent component;
        public WareComponentView(WareComponent Component)
        {
            component = Component;
        }

        public int ID
        {
            get
            {
                return component.ID;
            }
        }

        public string WareComponentName
        {
            get
            {
                return component.Ware1.Name;
            }
        }

        public string UnitName
        {
            get
            {
                string unitName = "";
                if (component.UnitQuantity > 0)
                    unitName = component.Ware1.WareUnit.Name;
                else
                    if (component.SecondUnitQuantity > 0)
                        unitName = component.Ware1.WareUnit1.Name;
                return unitName;
            }
        }

        public decimal UnitQuantity
        {
            get
            {
                decimal unitQuantity = 0;
                if (component.UnitQuantity > 0)
                    unitQuantity = Convert.ToDecimal(component.UnitQuantity);
                else
                    if (component.SecondUnitQuantity > 0)
                        unitQuantity = Convert.ToDecimal(component.SecondUnitQuantity);
                return unitQuantity;
            }
        }

        //public string SecondaryUnitName
        //{
        //    get
        //    {
        //        string unitName = "";
        //        if (component.SecondUnitQuantity > 0)
        //            unitName = component.Ware.WareUnit1.Name;
        //        return unitName;
        //    }
        //}

        //public decimal SecondaryUnitQuantity
        //{
        //    get
        //    {
        //        decimal secondaryUnitQuantity = 0;
        //        if (component.UnitQuantity > 0)
        //            secondaryUnitQuantity = Convert.ToDecimal(component.SecondUnitQuantity);
        //        return secondaryUnitQuantity;
        //    }
        //}

    }
    /// <summary>
    /// Упавління компонентами
    /// Якщо компонет містить в собі кілька позицій то це буде відповідати кільком позиціям  WareComponentWares
    /// </summary>
    public class WareComponentsLogic : IGenericInterface<WareComponent>
    {

        private CompasDataContext context;

        public WareComponentsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareComponent Get(int ID)
        {
            WareComponent result;

            result = (from a in context.WareComponents
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<WareComponent> GetAll()
        {
            List<WareComponent> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareComponents                          
                          select a).ToList();
            //}
            return result;
        }

        public List<WareComponent> GetAll(int WareID)
        {
            List<WareComponent> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareComponents
                      where a.WareID == WareID
                      select a).ToList();
            
            //}
            return result;
        }

        /// <summary>
        /// Рекурсивно формуємо перелік компонентів номенклатурної одиниці
        /// </summary>
        /// <param name="WareID"></param>
        /// <param name="components"></param>
        /// <returns></returns>
        public List<WareComponent> GetAllRecursively(int WareID, List<WareComponent> components)
        {
           
            //using (var cdc = new CompasDataContext())
            //{

            if (components == null)
                components = new List<WareComponent>();

            List<WareComponent> foundComponents = (from a in context.WareComponents
                      where a.WareID == WareID
                      select a).ToList();

            foreach (WareComponent component in foundComponents)
            {
                
                this.GetAllRecursively(component.ComponentWareID, components);
                components.Add(component);
            }


            //}
            return components;
        }

        public List<WareComponentView> GetAllView(int WareID)
        {
            List<WareComponentView> result = new List<WareComponentView>();
            //using (var cdc = new CompasDataContext())
            //{

            foreach (WareComponent wc in (from a in context.WareComponents
                                          where a.WareID == WareID
                                          select a))
            {
                WareComponentView wcv = new WareComponentView(wc);
                result.Add(wcv);
            }
            //}
            return result;
        }

        

        
       

        public int Create(int WareID, int ComponentWareID, decimal? UnitQuantity, decimal? SecondaryUnitQuantity)
        {
            int result = 1;
            WareComponent sr = WareComponent.CreateWareComponent(1, WareID, ComponentWareID, 1);
            sr.UnitQuantity = UnitQuantity;
            sr.SecondUnitQuantity = SecondaryUnitQuantity;
            


            context.AddToWareComponents(sr);
            return result;
        }



        public int Update(int ID, decimal? UnitQuantity, decimal? SecondaryUnitQuantity)
        {
            int result = 1;
            WareComponent sr = (from a in context.WareComponents
                               where a.ID == ID
                               select a).FirstOrDefault();

            sr.UnitQuantity = UnitQuantity;
            sr.SecondUnitQuantity = SecondaryUnitQuantity;    
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareComponent sr = (from a in context.WareComponents
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareComponents.DeleteObject(sr);

            return result;
        }

       
        
    }
}
