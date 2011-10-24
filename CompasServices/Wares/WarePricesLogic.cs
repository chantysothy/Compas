using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Wares
{
    /// <summary>
    /// Клас для відображення  прайсу товарів і послуг
    /// </summary>
    public class PricesView
    {
        int id;
        string wareName;
        int wareId;
        int? categoryId;
        string categoryName;
        int warePriceGroupId;
        int? documentId;
        bool allowDiscount;
        decimal purshasePriceForUnit;
        decimal salePriceForUnit;
        bool active;
        int unitId;
        string unitName;
        int? manufacturerId;
        string manufacturerName;
        string warePriceGroupName;

        public int ID
        { get { return id; } set { id = value; } }

        public string WareName
        { get { return wareName; } set { wareName = value; } }


        public int WareID
        { get { return wareId; } set { wareId = value; } }

        public int? CategoryID
        { get { return categoryId; } set { categoryId = value; } }

        public string CategoryName
        { get { return categoryName; } set { categoryName = value; } }

        public int WarePriceGroupID
        { get { return warePriceGroupId; } set { warePriceGroupId = value; } }

        public int? DocumentID
        { get { return documentId; } set { documentId = value; } }

        public bool AllowDiscount
        { get { return allowDiscount; } set { allowDiscount = value; } }

        public decimal PurshasePriceForUnit
        { get { return purshasePriceForUnit; } set { purshasePriceForUnit = value; } }

        public decimal SalePriceForUnit
        { get { return salePriceForUnit; } set { salePriceForUnit = value; } }

        public bool Active
        { get { return active; } set { active = value; } }

        public int UnitID
        { get { return unitId; } set { unitId = value; } }

        public string UnitName
        { get { return unitName; } set { unitName = value; } }

        public int? ManufacturerID
        { get { return manufacturerId; } set { manufacturerId = value; } }

        public string ManufacturerName
        { get { return manufacturerName; } set { manufacturerName = value; } }

        public string WarePriceGroupName
        { get { return warePriceGroupName; } set { warePriceGroupName = value; } }
    }

    /// <summary>
    /// Упавління прайсом товарів і послуг
    /// </summary>
    public class WarePricesLogic : IGenericInterface<WarePrice>
    {

        private CompasDataContext context;

        public WarePricesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public WarePrice Get(int ID)
        {
            WarePrice result;

            result = (from a in context.WarePrices
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WarePrice> GetAll()
        {
            List<WarePrice> result;
            
            result = (from a in context.WarePrices
                      select a).ToList();
            
            return result;
        }

        public List<WarePrice> GetAll(int? WareID)
        {
            List<WarePrice> result;

            result = (from a in context.WarePrices
                      where (WareID == null) || (a.WareID == WareID)
                      select a).ToList();

            return result;
        }

        public List<WarePrice> GetAll(int? WareID, int? PriceGroupID)
        {
            List<WarePrice> result;

            result = (from a in context.WarePrices
                      where ((WareID == null) || (a.WareID == WareID)) & ((PriceGroupID == null) || (a.WarePriceGroupID == PriceGroupID) )
                      select a).ToList();

            return result;
        }

        public WarePrice Get(int? WareID, int? PriceGroupID)
        {
            WarePrice result;

            result = (from a in context.WarePrices
                      where ((WareID == null) || (a.WareID == WareID)) & ((PriceGroupID == null) || (a.WarePriceGroupID == PriceGroupID))
                      select a).FirstOrDefault();

            return result;
        }



        public int Create(int WareID, int WarePriceGroupID, int? DocumentID, bool AllowDiscount, 
            decimal PurchasePriceForUnit,
            decimal SalePriceForUnit, bool Active)
        {
            int result = 1;
            WarePrice sr = WarePrice.CreateWarePrice(1, WareID, WarePriceGroupID, AllowDiscount, 
                PurchasePriceForUnit, SalePriceForUnit, Active);

            context.AddToWarePrices(sr);
            return result;
        }

        public int Update(int ID, int WareID, int WarePriceGroupID, int? DocumentID, 
            bool AllowDiscount, decimal PurchasePriceForUnit,
            decimal SalePriceForUnit, bool Active)
        {
            int result = 1;
            WarePrice sr = (from a in context.WarePrices
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.WareID = WareID;
            sr.WarePriceGroupID = WarePriceGroupID;
            sr.DocumentID = DocumentID;
            sr.AllowDiscount = AllowDiscount;
            sr.PurchasePriceForUnit = PurchasePriceForUnit;
            sr.SalePriceForUnit = SalePriceForUnit;
            sr.Active = Active;

            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WarePrice sr = (from a in context.WarePrices
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WarePrices.DeleteObject(sr);

            return result;
        }


    }
}
