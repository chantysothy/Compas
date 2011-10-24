using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Wares

{
    /// <summary>
    /// Упавління кодами товарів та послуг
    /// </summary>
    public class WareCodesLogic : IGenericInterface<WareCode>
    {

        private CompasDataContext context;

        public WareCodesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WareCode Get(int ID)
        {
            WareCode result;

            result = (from a in context.WareCodes
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public Ware GetWareByCode(string Code)
        {
            Ware result;

            result = (from a in context.WareCodes
                      where a.Code == Code
                      select a.Ware).FirstOrDefault();


            return result;
        }

        public int GetWareIDByCode(string Code)
        {
            WareCode result;

            result = (from a in context.WareCodes
                      where a.Code == Code
                      select a).FirstOrDefault();


            return result.WareID;
        }

        
        public bool CodeForOtherWareExists(int? WareID, string Code)
        {
            bool result = false;

            var exists = from a in context.WareCodes
                         where ((WareID != null) & (a.WareID != WareID & a.Code == Code))
                                || ((WareID == null) & (a.Code == Code))
                         select a;
            if (exists.Count() > 0)
                result = true;
            return result;
        }


        public List<WareCode> GetAll()
        {
            List<WareCode> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCodes                          
                          select a).ToList();
            //}
            return result;
        }

        public List<WareCode> GetAll(int WareID)
        {
            List<WareCode> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.WareCodes
                      where a.WareID == WareID
                      select a).ToList();
            //}
            return result;
        }

        
       

        public int Create(int WareID, string Code)
        {
            int result = 1;
            WareCode sr = WareCode.CreateWareCode(1, WareID, Code);


            context.AddToWareCodes(sr);
            return result;
        }

        public int Create(Ware ware, string Code)
        {
            int result = 1;
            //ware.WareCodes.Load();
            //WareCode codeExists = (from a in context.WareCodes
            //                       where a.Ware == ware & a.Code == Code
                                   //select a).FirstOrDefault();
            WareCode codeExists = ware.WareCodes.Where(a => a.Code == Code).FirstOrDefault();
            if (codeExists == null)
            {
                WareCode wareCode = new WareCode();
                wareCode.Code = Code;
                ware.WareCodes.Add(wareCode);
                context.AddToWareCodes(wareCode);
            }
            return result;
        }

        public int Update(int ID, string Code)
        {
            int result = 1;
            WareCode sr = (from a in context.WareCodes
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Code = Code;
            
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareCode sr = (from a in context.WareCodes
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareCodes.DeleteObject(sr);

            return result;
        }

        public int DeleteByWareID(int WareID)
        {
            int result = 1;
            IEnumerable<WareCode> codes = from a in context.WareCodes
                           where a.WareID == WareID
                           select a;
            foreach (WareCode code in codes)
            {
                context.WareCodes.DeleteObject(code);
            }
            return result;
        }

        public int Delete(int WareID, string Code)
        {
            int result = 1;
            WareCode sr = (from a in context.WareCodes
                           where a.WareID == WareID & a.Code == Code
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareCodes.DeleteObject(sr);

            return result;
        }

        
    }
}
