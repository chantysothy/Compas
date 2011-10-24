using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Staff

{
    public class StaffShedulersLogic : IGenericInterface<StaffSheduler>
    {

        private CompasDataContext context;

        public StaffShedulersLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public StaffSheduler Get(int ID)
        {
            StaffSheduler result;

            result = (from a in context.StaffShedulers
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<StaffSheduler> GetAll()
        {
            List<StaffSheduler> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffShedulers                          
                          select a).ToList();
            //}
            return result;
        }

        public List<StaffSheduler> GetAll(int? StructureObjectID, int? ShiftID, 
            int? TeamID, DateTime? StartDate)
        {
            List<StaffSheduler> result;
            //using (var cdc = new CompasDataContext())
            //{
            //int enterpriseId = Convert.ToInt32(EnterpriseID);
            //DateTime startDate = Convert.ToDateTime(StartDate);

            result = (from a in context.StaffShedulers
                      where (StructureObjectID == null || a.StructureObjectID == StructureObjectID)
                      & (ShiftID == null || a.ShiftID == ShiftID)
                      & (TeamID == null || a.TeamID == TeamID)                      
                      & (StartDate == null || a.StartDate >= StartDate)
                      select a).ToList();
            //}
            return result;
        }






        public StaffSheduler Create(int? StructureObjectID, int? ShiftID, int? TeamID, 
            DateTime StartDate, DateTime EndDate, int CreatedUserID, DateTime CreatedDate, string Description)
        {
            
            StaffSheduler sr = StaffSheduler.CreateStaffSheduler(1, StartDate, EndDate, CreatedUserID, CreatedDate);
            sr.StructureObjectID = StructureObjectID;
            sr.ShiftID = ShiftID;
            sr.TeamID = TeamID;
            
            sr.Description = Description;

            context.AddToStaffShedulers(sr);

            return sr;
        }

        public StaffSheduler Update(int ID, int? StructureObjectID, int? ShiftID, int? TeamID, 
            DateTime StartDate, DateTime EndDate, string Description)
        {
            
            StaffSheduler sr = (from a in context.StaffShedulers
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
            {
                sr.StructureObjectID = StructureObjectID;
                sr.ShiftID = ShiftID;
                sr.TeamID = TeamID;
                
                sr.Description = Description;

               
                sr.StartDate = StartDate;
                sr.EndDate = EndDate;
                
            }
            return sr;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffSheduler sr = (from a in context.StaffShedulers
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffShedulers.DeleteObject(sr);

            return result;
        }

        
    }
}
