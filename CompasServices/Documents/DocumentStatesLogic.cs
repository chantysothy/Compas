using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Documents
{
    
    /// <summary>
    /// Управління статусом документів
    /// 
    /// </summary>
    public class DocumentStatesLogic : IGenericInterface<WareDocumentState>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public DocumentStatesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public WareDocumentState Get(int ID)
        {
            WareDocumentState result;

            result = (from a in context.WareDocumentStates
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        

        public List<WareDocumentState> GetAll()
        {
            List<WareDocumentState> result;

            result = (from a in context.WareDocumentStates                      
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }


        public List<WareDocumentState> GetByDocumentID(int DocumentID)
        {
            List<WareDocumentState> result;

            result = (from a in context.WareDocumentStates
                      where a.DocumentID == DocumentID
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }


        public int Create(WareDocument Document, StatesOfDocument State)
        {
            int result = 1;
            WareDocumentState DocumentState = new WareDocumentState();
            Document.WareDocumentStates.Add(DocumentState);
            State.WareDocumentStates.Add(DocumentState);
            return result;
        }
        
        

        public int Create(int DocumentID, int StateID, DateTime StartDate)
        {
            int result = 1;
            WareDocumentState sr = new WareDocumentState();
            sr.DocumentID = DocumentID;
            sr.Active = true;
            sr.StateID = StateID;
            sr.StartDate = StartDate;
            int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
            Logic.Staff.StaffEmployeeLogic staffLogic = new Staff.StaffEmployeeLogic(manager);
            StaffEmployee employee = staffLogic.GetByUserID(userId);
            if (employee != null)
                sr.EmployeeID = employee.ID;
            context.WareDocumentStates.AddObject(sr);
            return result;
        }

        public int Update()
        {
            int result = 1;
            
            
            
            return result;
        }


        


        public int Delete(int ID)
        {
            int result = 1;
            WareDocumentState sr = (from a in context.WareDocumentStates
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.WareDocumentStates.DeleteObject(sr);

            return result;
        }


    }
}
