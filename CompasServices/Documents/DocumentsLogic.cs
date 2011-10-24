using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Documents
{

    public class DocumentView
    {
        WareDocument document;
        public DocumentView(WareDocument Document)
        {
            document = Document;
        }

        public int ID
        {
            get
            {
                return document.ID;
            }
        }

        public string Number
        {
            get
            {
                return document.Number;
            }
        }

        public DateTime? Date
        {
            get
            {
                return document.Date;
            }
        }

        public string DocumentTypeName
        {
            get
            {
                if (document.WareDocumentType != null)
                {
                    return document.WareDocumentType.Name;
                }
                else
                    return "";
            }
        }

        public DateTime? CreatedDate
        {
            get
            {
                return document.CreatedDate;
            }
        }

        public string Description
        {
            get
            {
                return document.Description;
            }
        }

        public string CurrencyName
        {
            get
            {
                return document.Currency.Name;
            }
        }

        public decimal DocumentSum
        {
            get
            {
                return document.DocumentSum;
            }
        }

        public decimal PaySum
        {
            get
            {
                return document.PaySum;
            }
        }

        public string Address
        {
            get
            {
                return document.Address;
            }
        }

        public int? EnterpriseID
        {
            get
            {
                return document.EnterpriseID;
            }
        }

        public string EnterpriseName
        {
            get
            {
               string result = "";
               if (document.Enterprise != null)
                   result = document.Enterprise.Name;
               return result;
            }
        }


        public string EmployeeFullName
        {
            get
            {
                if (document.StaffEmployee != null)
                {
                    return document.StaffEmployee.LastName + " " + document.StaffEmployee.FirstName + " " + document.StaffEmployee.MiddleName;
                }
                else
                {
                    return "";
                }
            }
        }

        

        public List<WareDocumentDetail> DocumentDetails
        {
            get
            {
                return document.WareDocumentDetails.ToList();
            }
        }

    }
    /// <summary>
    /// Упавління документами
    /// (прихідні накладні, розхідні накладні, замовлення, і т.д.)
    /// </summary>
    public class DocumentsLogic : IGenericInterface<WareDocument>
    {
        
        //private WareDocument document;
        //private List<WareDocumentDetail> details;

        //public WareDocument Document
        //{ get { return document; } set { document = value; } }

        //public List<WareDocumentDetail> Details
        //{ get { return details; } set { details = value; } }

        private CompasDataContext context;
        private ContextManager manager;
        public DocumentsLogic(ContextManager contextManager)
        {
            manager = contextManager;
            context = contextManager.Context;
        }

        public WareDocument Get(int ID)
        {
            WareDocument result;

            result = (from a in context.WareDocuments
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareDocument> GetAll()
        {
            List<WareDocument> result;

            result = (from a in context.WareDocuments
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }

        


       

        public List<DocumentView> GetAllView()
        {
            List<DocumentView> result = new List<DocumentView>();

            List<WareDocument> documents = (from a in context.WareDocuments
                      select a).ToList().OrderBy(a => a.ID).ToList();

            foreach (WareDocument document in documents)
            {
                result.Add(new DocumentView(document));
            }
            return result;
        }

        public List<DocumentView> GetAllView(int? DocumentTypeId,
            string DocumentNumber,
            DateTime StartDate,
            DateTime? EndDate,
            decimal? DocumentSum)
        {

            
            List<DocumentView> result = new List<DocumentView>();

            List<WareDocument> documents = (from a in context.WareDocuments
                                            where ((DocumentTypeId == null) || (a.DocumentTypeID == DocumentTypeId)) &
                                            ((DocumentNumber == "") || (a.Number.Contains(DocumentNumber))) &
                                            ((StartDate == null) || (a.Date >= StartDate)) &
                                            ((EndDate == null) || (a.Date <= EndDate)) &
                                             ((DocumentSum == null) || (a.DocumentSum >= DocumentSum))
                                            select a).ToList().OrderBy(a => a.ID).ToList();

            foreach (WareDocument document in documents)
            {
                result.Add(new DocumentView(document));
            }
            return result;
        }


        public List<WareDocument> GetDocumentsByEmployeeID(int EmployeeID, DateTime StartDate, DateTime EndDate)
        {
            List<WareDocument> result;

            result = (from a in context.WareDocumentStaffDetails
                      where a.EmployeeID == EmployeeID & a.WareDocument.Date >= StartDate & a.WareDocument.Date < EndDate
                      select a.WareDocument).Distinct().ToList();


            return result;
        }

        public List<DocumentView> GetAllView(int? DocumentTypeId,
            string DocumentNumber,
            DateTime StartDate,
            DateTime? EndDate,
            decimal? DocumentSum,
            int? WareID)
        {


            List<DocumentView> result = new List<DocumentView>();

            List<WareDocument> documents = (from a in context.WareDocuments
                                            where ((DocumentTypeId == null) || (a.DocumentTypeID == DocumentTypeId)) &
                                            ((DocumentNumber == "") || (a.Number.Contains(DocumentNumber))) &
                                            ((StartDate == null) || (a.Date >= StartDate)) &
                                            ((EndDate == null) || (a.Date <= EndDate)) &
                                             ((DocumentSum == null) || (a.DocumentSum >= DocumentSum))
                                            select a).ToList().OrderBy(a => a.ID).ToList();

            foreach (WareDocument document in documents)
            {
                if (WareID != null)
                {
                    if (document.WareDocumentDetails != null)
                    { 
                        //перевіряємо наявність номенклатури в документі
                        var exists = (from a in document.WareDocumentDetails
                                      where a.WareID == WareID
                                      select a).FirstOrDefault();
                        if(exists != null)
                            result.Add(new DocumentView(document));
                    }
                }
                else
                    result.Add(new DocumentView(document));
            }
            return result;
        }

        public List<DocumentView> GetAllView(int? DocumentTypeId,
            string DocumentNumber,
            DateTime StartDate,
            DateTime? EndDate,
            decimal? DocumentSum,
            int? WareID,
            int? CategoryID)
        {


            List<DocumentView> result = new List<DocumentView>();

            List<WareDocument> documents = (from a in context.WareDocuments
                                            from b in context.WareDocumentStates
                                            //join b in context.WareDocumentStates on a.ID equals b.DocumentID into temp
                                            where ((DocumentTypeId == null) || (a.DocumentTypeID == DocumentTypeId)) &
                                            ((DocumentNumber == "") || (a.Number.Contains(DocumentNumber))) &
                                            ((StartDate == null) || (a.Date >= StartDate)) &
                                            ((EndDate == null) || (a.Date <= EndDate)) &
                                             ((DocumentSum == null) || (a.DocumentSum >= DocumentSum))
                                             //умова not in - не позначені як видалені
                                            & b.StateID == 3 & a.ID != b.DocumentID

                                            select a).Distinct().ToList().OrderBy(a => a.ID).ToList();

            List<WareCategory> childCategories = new List<WareCategory>(); 
            if (CategoryID != null & WareID == null)
             {
              Compas.Logic.Wares.WareCategoriesLogic categoriesLogic = new Wares.WareCategoriesLogic(manager);
              childCategories = categoriesLogic.GetAllChilds(Convert.ToInt32(CategoryID));
            }

            foreach (WareDocument document in documents)
            {
                if (WareID != null || CategoryID != null)
                {
                    if (WareID != null)
                    {
                        if (document.WareDocumentDetails != null)
                        {
                            //перевіряємо наявність номенклатури в документі
                            var exists = (from a in document.WareDocumentDetails
                                          where a.WareID == WareID
                                          select a).FirstOrDefault();
                            if (exists != null)
                                result.Add(new DocumentView(document));
                        }
                    }
                    else
                    {
                        if (document.WareDocumentDetails != null)
                        {
                            //перевіряємо наявність номенклатури в документі
                            var exists = (from a in document.WareDocumentDetails
                                          where childCategories.Contains(a.Ware.WareCategory) || a.Ware.CategoryID == CategoryID
                                          select a).FirstOrDefault();
                            if (exists != null)
                                result.Add(new DocumentView(document));
                        }
                    }
                }
                else
                    result.Add(new DocumentView(document));
            }
            return result;
        }

        public List<DocumentView> GetAllView(int? DocumentTypeId,
            string DocumentNumber,
            DateTime StartDate,
            DateTime? EndDate,
            decimal? DocumentSum,
            int? WareID,
            int? CategoryID,
            int? StateID)
        {


            List<DocumentView> result = new List<DocumentView>();
            
            List<WareDocument> documents = (from a in context.WareDocuments
                                            //from b in context.WareDocumentStates
                                            //join b in context.WareDocumentStates on a.ID equals b.DocumentID into temp
                                            //from b in temp.DefaultIfEmpty()
                                            where ((DocumentTypeId == null) || (a.DocumentTypeID == DocumentTypeId)) &
                                            ((DocumentNumber == "") || (a.Number.Contains(DocumentNumber))) &
                                            ((StartDate == null) || (a.Date >= StartDate)) &
                                            ((EndDate == null) || (a.Date <= EndDate)) &
                                             ((DocumentSum == null) || (a.DocumentSum >= DocumentSum))
                                                //умова not in - не позначені як видалені
                                                //&  a.WareDocumentStates.Contains(
                                            //& ((StateID == null & b.StateID == 3 & a.ID != b.DocumentID) || (/*StateID > 0 & */b.StateID == StateID & a.ID == b.DocumentID))
                                            //& (StateID != null & b.StateID == StateID) & (StateID == null & b.StateID != 3)

                                            select a).Distinct().ToList().OrderBy(a => a.ID).ToList();
            //фільтр по статусу
            if (StateID != null)
            {
                List<WareDocumentState> documentStates = (from a in context.WareDocumentStates
                                                          where a.StateID == StateID & a.Active == true
                                                          select a).ToList();
                documents = documents.Where(a => documentStates.Select(b => b.WareDocument).ToList().Contains(a)).ToList();
            }
            else
            {
                List<WareDocumentState> documentStates = (from a in context.WareDocumentStates
                                                          where a.StateID == 3 & a.Active == true
                                                          select a).ToList();
                documents = documents.Where(a => !documentStates.Select(b => b.WareDocument).ToList().Contains(a)).ToList();
           
            }
            List<WareCategory> childCategories = new List<WareCategory>();
            if (CategoryID != null & WareID == null)
            {
                Compas.Logic.Wares.WareCategoriesLogic categoriesLogic = new Wares.WareCategoriesLogic(manager);
                childCategories = categoriesLogic.GetAllChilds(Convert.ToInt32(CategoryID));
            }

            foreach (WareDocument document in documents)
            {
                if (WareID != null || CategoryID != null)
                {
                    if (WareID != null)
                    {
                        if (document.WareDocumentDetails != null)
                        {
                            //перевіряємо наявність номенклатури в документі
                            var exists = (from a in document.WareDocumentDetails
                                          where a.WareID == WareID
                                          select a).FirstOrDefault();
                            if (exists != null)
                                result.Add(new DocumentView(document));
                        }
                    }
                    else
                    {
                        if (document.WareDocumentDetails != null)
                        {
                            //перевіряємо наявність номенклатури в документі
                            var exists = (from a in document.WareDocumentDetails
                                          where childCategories.Contains(a.Ware.WareCategory) || a.Ware.CategoryID == CategoryID
                                          select a).FirstOrDefault();
                            if (exists != null)
                                result.Add(new DocumentView(document));
                        }
                    }
                }
                else
                    result.Add(new DocumentView(document));
            }
            return result;
        }

        public WareDocument CreateEmpty()
        {
            WareDocument document = new WareDocument();
            
            return document;
        }


        public void SaveDocument(WareDocument document)
        {
            context.AddToWareDocuments(document);
        }

        public void SaveDocumentWithDetails(WareDocument Document, List<WareDocumentDetail> Details, string Mode)
        {

            //System.Data.Objects.DataClasses.IEntityWithChangeTracker changeTracker0 = Document;
            //changeTracker0.SetChangeTracker(null);
            foreach (WareDocumentDetail detail in Details)
            {
              
                //придодаванні detail виникала помилка, яку не знав як швидко виправити
                //тому створюємо новий обєкт класу WareDocumentDetail

                WareDocumentDetail d = new WareDocumentDetail();
                d.CurrencyID = Document.CurrencyID;
                d.DiscountForUnit = detail.DiscountForUnit;
                d.EndPrice = detail.EndPrice;
                d.EndPriceForUnit = detail.EndPriceForUnit;
                d.PriceForUnit = detail.PriceForUnit;
                d.SecondaryUnitQuantity = detail.SecondaryUnitQuantity;
                d.UnitQuantity = detail.UnitQuantity;
                d.WareID = detail.WareID;

                

                Document.WareDocumentDetails.Add(d);
                context.AddToWareDocumentDetails(d);

                
            }

            if (Mode == "new")
            {
                if (Document.Number.Trim().Length == 0)
                {
                    Document.Number = Document.CreatedDate.ToString("yyyyMMddHHmmss");
                }
                context.AddToWareDocuments(Document);
            }

        }

        public void SaveDocumentWithEmployees(WareDocument Document, StaffEmployee Employee, int? TeamID, string Mode)
        {

               //перевіряємо чи даний працівник закріплений за документом
                WareDocumentStaffDetail exists = (from a in context.WareDocumentStaffDetails
                                        where a.EmployeeID == Employee.ID & a.DocumentID == Document.ID
                                        select a).FirstOrDefault();
                if (exists == null)
                {
                    WareDocumentStaffDetail d = new WareDocumentStaffDetail();
                    d.StaffEmployee = Employee;
                    d.TeamID = TeamID;
                    Document.WareDocumentStaffDetails.Add(d);
                    context.AddToWareDocumentStaffDetails(d);
                }

                //if (Mode == "new")
                //    context.AddToWareDocuments(Document);
               

        }

        public void DeleteDocumentEmployees(WareDocument Document, List<Compas.Logic.Staff.StaffEmployeeView> Employees)
        {

            //працівники на видалення
            IEnumerable<WareDocumentStaffDetail> exists = from a in context.WareDocumentStaffDetails
                                              where a.DocumentID == Document.ID
                                              select a;
            if (exists != null)
            {
                foreach (WareDocumentStaffDetail exist in exists)
                {
                    var notDeleted = (from b in Employees
                                      where b.ID == exist.EmployeeID
                                      select b).FirstOrDefault();
                    if(notDeleted == null)
                        context.WareDocumentStaffDetails.DeleteObject(exist);
                    
                }
            }

            //if (Mode == "new")
            //    context.AddToWareDocuments(Document);


        }

        public int Create(string Number, int? ContractorID, int? ToStructureObjectID, int? FromStructureObjectID,
            DateTime? Date, decimal DocumentSum, decimal PaySum, int DocumentTypeID, int? LinkedDocumentID, string Description,
            int CurrencyID, string Address, int EnterpriseID)
        {
            int result = 1;
            
            int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
            WareDocument sr = WareDocument.CreateWareDocument(1, DocumentSum, PaySum, DocumentTypeID, userId, DateTime.Now, CurrencyID, true);
            sr.Number = Number;
            sr.ContractorID = ContractorID;
            sr.ToStructureObjectD = ToStructureObjectID;
            sr.FromStructureObjectID = FromStructureObjectID;
            sr.Date = Date;
            sr.LinkedDocumentID = LinkedDocumentID;
            sr.Description = Description;
            sr.Address = Address;
            sr.EnterpriseID = EnterpriseID;
            
            Logic.Staff.StaffEmployeeLogic staffLogic = new Staff.StaffEmployeeLogic(manager);
            StaffEmployee employee = staffLogic.GetByUserID(userId);
            if (employee != null)
                sr.CreatedEmployeeID = employee.ID;

            context.AddToWareDocuments(sr);
            return result;
        }

        public int Update(int ID, string Number, int? ContractorID, int? ToStructureObjectID, int? FromStructureObjectID,
            DateTime? Date, decimal DocumentSum, decimal PaySum, int? LinkedDocumentID, string Description, int CurrencyID,
            string Address, int EnterpriseID)
        {
            int result = 1;
            WareDocument sr = (from a in context.WareDocuments
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.DocumentSum = DocumentSum;
            sr.PaySum = PaySum;
                       

            sr.Number = Number;
            sr.ContractorID = ContractorID;
            sr.ToStructureObjectD = ToStructureObjectID;
            sr.FromStructureObjectID = FromStructureObjectID;
            sr.Date = Date;
            sr.LinkedDocumentID = LinkedDocumentID;
            sr.Description = Description;
            sr.CurrencyID = CurrencyID;
            sr.Address = Address;
            sr.EnterpriseID = EnterpriseID;

            return result;
        }

        public int Update(WareDocument document, string Number, int? ContractorID, int? ToStructureObjectID, int? FromStructureObjectID,
            DateTime? Date, decimal DocumentSum, decimal PaySum, int? LinkedDocumentID, string Description, int CurrencyID, string Address, int EnterpriseID)
        {
            int result = 1;

            document.DocumentSum = DocumentSum;
            document.PaySum = PaySum;


            document.Number = Number;
            document.ContractorID = ContractorID;
            document.ToStructureObjectD = ToStructureObjectID;
            document.FromStructureObjectID = FromStructureObjectID;
            document.Date = Date;
            document.LinkedDocumentID = LinkedDocumentID;
            document.Description = Description;
            document.CurrencyID = CurrencyID;
            document.Address = Address;
            document.EnterpriseID = EnterpriseID;

            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDocument sr = (from a in context.WareDocuments
                               where a.ID == ID
                               select a).FirstOrDefault();

            context.WareDocuments.DeleteObject(sr);

            return result;
        }


       

    }
}
