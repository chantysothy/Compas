using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Documents
{
    
    /// <summary>
    /// Упавління працівниками, які закріплені за документом
    /// 
    /// </summary>
    public class DocumentStaffDetailsLogic : IGenericInterface<WareDocumentStaffDetail>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public DocumentStaffDetailsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public WareDocumentStaffDetail Get(int ID)
        {
            WareDocumentStaffDetail result;

            result = (from a in context.WareDocumentStaffDetails
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<WareDocumentStaffDetail> GetByDocumentID(int DocumentID)
        {
            List<WareDocumentStaffDetail> result;

            result = (from a in context.WareDocumentStaffDetails
                      where a.DocumentID == DocumentID
                      select a).ToList();


            return result;
        }

        

        public List<StaffEmployee> GetStaffEmployeesByDocumentID(int DocumentID)
        {
            List<StaffEmployee> result;

            result = (from a in context.WareDocumentStaffDetails
                      where a.DocumentID == DocumentID
                      select a.StaffEmployee).ToList();


            return result;
        }

        public List<WareDocumentStaffDetail> GetAll()
        {
            List<WareDocumentStaffDetail> result;

            result = (from a in context.WareDocumentStaffDetails
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }




        public int Create(int DocumentID, int? DocumentDetailID, int? TeamID, int? EmployeeID)
        {
            int result = 1;
            WareDocumentStaffDetail sr = WareDocumentStaffDetail.CreateWareDocumentStaffDetail(1, DocumentID);
            sr.DocumenDetailID = DocumentDetailID;
            sr.TeamID = TeamID;
            sr.EmployeeID = EmployeeID;
            
            context.AddToWareDocumentStaffDetails(sr);
            return result;
        }

        /// <summary>
        /// Пустий метод - не використовується
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="DocumentID"></param>
        /// <param name="DocumentDetailID"></param>
        /// <param name="TeamID"></param>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public int Update(int ID, int DocumentID, int? DocumentDetailID, int? TeamID, int? EmployeeID)
        {
            int result = 1;
            WareDocumentStaffDetail sr = (from a in context.WareDocumentStaffDetails
                           where a.ID == ID
                           select a).FirstOrDefault();
           
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentStaffDetail sr = (from a in context.WareDocumentStaffDetails
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareDocumentStaffDetails.DeleteObject(sr);

            return result;
        }


    }
}
