using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Compas.Model;



namespace Compas.Logic.Wares

{
    public class WareView
    {
        public WareView()
        { 
            
        }


        private int id;
        private string name;
        private string unitName;
        private string manufacturerName;
        private string categoryName;
        private int? categoryId;
        private int? secondaryUnitID;
        private string secondaryUnitName;
        private decimal? secondaryUnitQuantity;
        private List<WareCode> wareCodes;
        private decimal? timeLimit;

        public int ID
        { get { return id; } set { id = value; } }
        public int? CategoryID
        { get { return categoryId; } set { categoryId = value; } }
        public string Name
        { get { return name; } set { name = value; } }
        public string UnitName
        { get { return unitName; } set { unitName = value; } }
        public string ManufacturerName
        { get { return manufacturerName; } set { manufacturerName = value; } }
        public string CategoryName
        { get { return categoryName; } set { categoryName = value; } }

        public int? SecondaryUnitID
        { get { return secondaryUnitID; } set { secondaryUnitID = value; } }

        public string SecondaryUnitName
        { get { return secondaryUnitName; } set { secondaryUnitName = value; } }

        public decimal? SecondaryUnitQuantity
        { get { return secondaryUnitQuantity; } set { secondaryUnitQuantity = value; } }

        public List<WareCode> WareCodes
        {
            get { return wareCodes; }
            set { wareCodes = value; }
        }

        public decimal? TimeLimit
        {
            get { return timeLimit == 0 ? null : timeLimit; }
            set { timeLimit = value; }
        }

        public string WareCodesString
        {
            get 
            {
                string code = "";
                //var codes = from a in this.WareCodes
                //            select a;
                //foreach (var a in codes)
                //{
                //    code = code + a.Code + "; ";
                //}
                return code;             
            }            
        }

        public string WareCodesStringForSearch
        {
            get
            {
                string code = "";
                //var codes = from a in this.WareCodes
                //            select a;
                //foreach (var a in codes)
                //{
                //    code = code + "<" + a.Code + "/>";
                //}
                return code;
            }
        }

       
    }
    /// <summary>
    /// Упавління довідником Номенклатури товарів і послуг
    ///
    /// </summary>
    public class WaresLogic : IGenericInterface<Ware>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public WaresLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public Ware Get(int ID)
        {
            Ware result;

            result = (from a in context.Wares
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<Ware> GetAll()
        {
            List<Ware> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.Wares                          
                          select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// без номенклатурних одиниць у підкатегоріях
        /// </summary>
        /// <param name="CategoryID"></param>
        /// <returns></returns>
        public List<Ware> GetAll(int CategoryID)
        {
            List<Ware> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.Wares
                      where a.CategoryID == CategoryID
                      select a).ToList();
            //}
            return result;
        }

        public List<Ware> GetAllByWareID(int WareID)
        {
            List<Ware> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.Wares
                      where a.ID == WareID
                      select a).ToList();
            //}
            return result;
        }


        public List<Ware> GetAll(string Name, int? CategoryID, int? ManufacturerID, int? UnitID)
        {
            List<Ware> result;          
            List<WareCategory> childs = new List<WareCategory>();
            List<int?> childsId = new List<int?>();
            if (CategoryID != null)
            { 
                //int? parentId  = null;
                //int currentCategoryId = -1;
                WareCategoriesLogic categories = new WareCategoriesLogic(manager);
                childs = categories.GetAllChilds(Convert.ToInt32(CategoryID));
                foreach(var a in childs)
                {
                    childsId.Add(a.ID);
                }                
            }
            result = (from a in context.Wares
                      where 
                      ((Name == null) || (a.Name.Contains(Name))) &
                      ((CategoryID == null) || ((a.CategoryID == CategoryID) || childsId.Contains(a.CategoryID))) &
                      ((ManufacturerID == null) || (a.ManufacturerID == ManufacturerID)) &
                      ((UnitID == null) || (a.UnitID == UnitID))
                      select a).ToList();
            
            return result;
        }

        public List<ViewWare> GetAllView(string Name, int? CategoryID, int? ManufacturerID, int? UnitID)
        {
            List<ViewWare> result;
            List<WareCategory> childs = new List<WareCategory>();
            List<int?> childsId = new List<int?>();
            if (CategoryID != null)
            {
                //int? parentId  = null;
                //int currentCategoryId = -1;
                WareCategoriesLogic categories = new WareCategoriesLogic(manager);
                childs = categories.GetAllChilds(Convert.ToInt32(CategoryID));
                foreach (var a in childs)
                {
                    childsId.Add(a.ID);
                }
            }
            result = (from a in context.ViewWares
                      where
                      ((Name == null) || (a.Name.Contains(Name))) &
                      ((CategoryID == null) || ((a.CategoryID == CategoryID) || childsId.Contains(a.CategoryID))) &
                      ((ManufacturerID == null) || (a.ManufacturerID == ManufacturerID)) &
                      ((UnitID == null) || (a.UnitID == UnitID))
                      select a).ToList();

            return result;
        }


        public decimal GetSummaryTimeLimit(int WareID)
        {
            WareComponentsLogic componentsLogic = new WareComponentsLogic(manager);
            List<WareComponent> components = componentsLogic.GetAllRecursively(WareID, null);
            decimal suma = 0;
            foreach (WareComponent component in components)
            { 
                //foreach
            }
            return suma;
        }

        public Model.Ware Create(string Name, int UnitID, decimal UnitQuantity, int? ManufacturerID, int? CategoryID,
            int? SecondaryUnitID, decimal? SecondaryUnitQuantity)
        {
            
            Ware sr = Ware.CreateWare(1, Name, UnitID, UnitQuantity);
            sr.CategoryID = CategoryID;
            sr.ManufacturerID = ManufacturerID;
            sr.SecondaryUnitID = SecondaryUnitID;
            sr.SecondaryUnitQuantity = SecondaryUnitQuantity;
           
            context.AddToWares(sr);
            return sr;
        }

        public Model.Ware Update(int ID, string Name, int UnitID, int? ManufacturerID, int? CategoryID,
            int? SecondaryUnitID, decimal? SecondaryUnitQuantity)
        {
            
            Ware sr = (from a in context.Wares
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.UnitID = UnitID;
            
            sr.ManufacturerID = ManufacturerID;
            sr.CategoryID = CategoryID;
            sr.SecondaryUnitID = SecondaryUnitID;
            sr.SecondaryUnitQuantity = SecondaryUnitQuantity;
     
            return sr;
        }

        public int Delete(int ID)
        {
            int result = 1;
            //спочатку видаляємо коди
            WareCodesLogic codesLogic = new WareCodesLogic(manager);
            codesLogic.DeleteByWareID(ID);
            
            Ware sr = (from a in context.Wares
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.Wares.DeleteObject(sr);

            return result;
        }

        
    }
}
