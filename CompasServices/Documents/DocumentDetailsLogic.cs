using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Logic.Wares;

namespace Compas.Logic.Documents
{
    
    ///
    /// Клас-представлення позицій документу
    /// 
    public class DocumentDetailView
    {
        WareDocumentDetail detail;
        ContextManager manager;
        CompasDataContext context;
        public DocumentDetailView(WareDocumentDetail DocumentDetail)
        {
            detail = DocumentDetail;
            FillFields();
        }

        public DocumentDetailView(WareDocumentDetail DocumentDetail, ContextManager Manager)
        {
            detail = DocumentDetail;
            manager = Manager;
            context = manager.Context;
            FillFields();
        }

        public int ID
        {
            get
            {
                return detail.ID;
            }
        }

        public WareDocumentDetail DetailObject
        { get { return detail; } }

        private string _wareName;
        private decimal _unitQuantity;
        private decimal _secondaryUnitQuantity;
        private string _unitName;
        private string _secondaryUnitName;
        private string _unit;
        private string _secondaryUnit;
        private decimal? _priceForUnit;
        private decimal? _discountForUnit;
        private decimal? _endPriceForUnit;
        private decimal? _endPrice;
        private string _currencyName;

        private void FillFields()
        {
            _unitQuantity = detail.UnitQuantity;
            _secondaryUnitQuantity = detail.SecondaryUnitQuantity;
            _priceForUnit = detail.PriceForUnit;
            _endPriceForUnit = detail.EndPriceForUnit;
            _endPrice = detail.EndPrice;
            _currencyName = (detail.WareDocument == null ? "" : detail.WareDocument.Currency.Name);

            if (detail.Ware != null)
            {
                _wareName = detail.Ware.Name;
                _unitName = detail.Ware.WareUnit == null ? "" : detail.Ware.WareUnit.Name;
                _secondaryUnitName = detail.Ware.WareUnit1 == null ? "" : detail.Ware.WareUnit1.Name;
                _unit = _unitQuantity + " " + (detail.Ware.WareUnit == null ? "" : detail.Ware.WareUnit.Name);
                _secondaryUnit = detail.SecondaryUnitQuantity.ToString() + " " + (detail.Ware.WareUnit1 == null ? "" : detail.Ware.WareUnit1.Name); 
                

                
            }
            else
            {
                WaresLogic waresLogic = new WaresLogic(manager);
                Ware ware = waresLogic.Get(detail.WareID);
                if (ware != null)
                {
                    _wareName = ware.Name;
                }
            }
            
            
        }


        public string WareName
        { get {

            //string result = "";
            //if (detail.Ware != null)
            //{
            //    result = detail.Ware.Name;
            //}
            //else
            //{
            //    WaresLogic waresLogic = new WaresLogic(manager);
            //    Ware ware = waresLogic.Get(detail.WareID);
            //    if (ware != null)
            //    {
            //        result = ware.Name;
            //    }
            //}
            return _wareName;
        
        } }

        public decimal UnitQuantity
        { get { return _unitQuantity; } }

        public decimal SecondaryUnitQuantity
        { get { return _secondaryUnitQuantity; } }

        public string UnitName
        {
            get
            {
                //if (detail.Ware != null)
                //{
                //    return
                //    detail.Ware.WareUnit == null ? "" : detail.Ware.WareUnit.Name;
                //}
                //else
                //    return "";
                return _unitName;
            }
        }

        public string SecondaryUnitName
        {
            get
            {
                //if (detail.Ware != null)
                //{ return detail.Ware.WareUnit1 == null ? "" : detail.Ware.WareUnit1.Name; }
                //else
                //    return "";
                return _secondaryUnitName;
            }
        }

        public string Unit
        {
            get
            {
                //string unitName = "";
                //if (detail.Ware != null)
                //{
                //    unitName = detail.Ware.WareUnit == null ? "" : detail.Ware.WareUnit.Name;
                //}

                //return detail.UnitQuantity.ToString() + " " + unitName;
                return _unit;
            }

        }

        public string SecondaryUnit
        {
            get
            {
                //string secondaryUnitName = "";
                //if (detail.Ware != null)
                //{
                //    secondaryUnitName = detail.Ware.WareUnit1 == null ? "" : detail.Ware.WareUnit1.Name; 
                //}

                //return detail.SecondaryUnitQuantity.ToString() + " " + secondaryUnitName;
                return _secondaryUnit;
            }

        }

        public decimal? PriceForUnit
        { get { return _priceForUnit; } }

        public decimal? DiscountForUnit
        { get { return _discountForUnit; } }

        public decimal? EndPriceForUnit
        { get { return _endPriceForUnit; } }

        public decimal? EndPrice
        { get { return _endPrice; } }

        public string CurrencyName
        { get { return _currencyName; } }


    }
    


    /// <summary>
    /// Упавління документами
    /// (прихідні накладні, розхідні накладні, замовлення, і т.д.)
    /// </summary>
    public class DocumentDetailsLogic : IGenericInterface<WareDocumentDetail>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public DocumentDetailsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public WareDocumentDetail Get(int ID)
        {
            WareDocumentDetail result;

            result = (from a in context.WareDocumentDetails
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareDocumentDetail> GetAll()
        {
            List<WareDocumentDetail> result;

            result = (from a in context.WareDocumentDetails
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }

        public List<WareDocumentDetail> GetAll(int? WareDocumentID)
        {
            List<WareDocumentDetail> result;

            result = (from a in context.WareDocumentDetails
                      where ((WareDocumentID == null) || (a.DocumentID == WareDocumentID))
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        

        public List<WareDocumentDetail> GetAll(DateTime StartDate,
            DateTime EndDate, int WareID)
        {
            List<WareDocumentDetail> result;

            result = (from a in context.WareDocumentDetails
                      where a.WareDocument.Date >= StartDate & a.WareDocument.Date <= EndDate & a.WareID == WareID
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        public List<WareDocumentDetail> GetAllByWareCategory(DateTime StartDate,
           DateTime? EndDate, int WareCategoryID, int DocumentID)
        {
            List<WareDocumentDetail> result;
            WareCategoriesLogic categoriesLogic = new WareCategoriesLogic(manager);
            List<WareCategory> categories = categoriesLogic.GetAllChilds(WareCategoryID);
            List<int?> c = new List<int?>();
            foreach (WareCategory category in categories)
            {
                c.Add(category.ID);
            }
            result = (from a in context.WareDocumentDetails
                      where a.WareDocument.Date >= StartDate & (EndDate == null || a.WareDocument.Date <= EndDate) 
                      & (a.Ware.CategoryID == WareCategoryID || c.Contains(a.Ware.CategoryID))
                      & a.DocumentID == DocumentID

                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        public List<WareDocumentDetail> GetAll(DateTime StartDate)
        {
            List<WareDocumentDetail> result;

            result = (from a in context.WareDocumentDetails
                      where a.WareDocument.Date >= StartDate
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }




        public int Create(WareDocument document, int WareID, decimal UnitQuantity, decimal? SecondaryUnitQuantity,
           decimal PriceForUnit, decimal? DiscountForUnit,
           decimal? EndPriceForUnit, decimal EndPrice, int CurrencyID)
        {
            int result = 1;
            
            int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
            WareDocumentDetail sr = new WareDocumentDetail();

            sr.WareID = WareID;
            sr.UnitQuantity = UnitQuantity;
            if (SecondaryUnitQuantity != null)
                sr.SecondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantity);
            
            sr.DiscountForUnit = DiscountForUnit;
            
            sr.CurrencyID = CurrencyID;


            context.AddToWareDocumentDetails(sr);

            WareRemainsLogic remainsLogic = new WareRemainsLogic(manager);
            //remainsLogic.UpdateCurrentRemainByDocumentDetail(sr);
            return result;
        }

        public WareDocumentDetail CreateWithNoSave(int WareID, decimal UnitQuantity, decimal? SecondaryUnitQuantity,
           decimal PriceForUnit, decimal? DiscountForUnit,
           decimal? EndPriceForUnit, decimal EndPrice, int CurrencyID, int PriceGroupID)
        {
            
            int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
            WareDocumentDetail sr = new WareDocumentDetail();

            //sr.WareID = WareID;

            Wares.WaresLogic wares = new Wares.WaresLogic(manager);
            Ware ware = wares.Get(WareID);

            ware.WareDocumentDetails.Add(sr);
            //sr.WareID = WareID;
            sr.UnitQuantity = UnitQuantity;            
            if(SecondaryUnitQuantity != null)
                sr.SecondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantity);            
            sr.DiscountForUnit = DiscountForUnit;           
            sr.CurrencyID = CurrencyID;
            sr.EndPrice = EndPrice;
            sr.EndPriceForUnit = EndPriceForUnit;
            sr.PriceForUnit = PriceForUnit;        
            


            return sr;
        }

        public WareDocumentDetail UpdateWithNoSave(WareDocumentDetail DocumentDetail, int WareID, decimal UnitQuantity, decimal? SecondaryUnitQuantity,
           decimal PriceForUnit, decimal? DiscountForUnit,
           decimal? EndPriceForUnit, decimal EndPrice, int CurrencyID, int PriceGroupID)
        {

            int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;


            DocumentDetail.WareID = WareID;
            DocumentDetail.UnitQuantity = UnitQuantity;

            if (SecondaryUnitQuantity != null)
                DocumentDetail.SecondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantity);

            DocumentDetail.DiscountForUnit = DiscountForUnit;

            DocumentDetail.CurrencyID = CurrencyID;

            return DocumentDetail;
        }

        public void SaveDocumentDetail(WareDocumentDetail documentDetail)
        {
            
                context.AddToWareDocumentDetails(documentDetail);
        }

      

        public int Update(int ID, int WareID, decimal UnitQuantity, decimal? SecondaryUnitQuantity,
            decimal? PurshasePrice, decimal? PurshasePriceForUnit, decimal? SalePrice, decimal? SalePriceForUnit, decimal? DiscountForUnit,
            decimal? EndSalePriceForUnit, int CurrencyID)
        {
            int result = 1;
            WareDocumentDetail sr = (from a in context.WareDocumentDetails
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.WareID = WareID;
            sr.UnitQuantity = UnitQuantity;
            if (SecondaryUnitQuantity != null)
                sr.SecondaryUnitQuantity = Convert.ToDecimal(SecondaryUnitQuantity);
           
            sr.CurrencyID = CurrencyID;
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentDetail sr = (from a in context.WareDocumentDetails
                           where a.ID == ID
                           select a).FirstOrDefault();

                context.WareDocumentDetails.DeleteObject(sr);

            return result;
        }

        public int DeleteAllForDocument(int DocumentID)
        {
            int result = 1;
            IEnumerable<WareDocumentDetail> sr = from a in context.WareDocumentDetails
                                     where a.DocumentID == DocumentID
                                     select a;

            foreach (WareDocumentDetail a in sr)
            {
                context.WareDocumentDetails.DeleteObject(a);
            }

            return result;
        }


    }
}
