using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Staff

{
    public class StaffShiftsLogic : IGenericInterface<StaffShift>
    {

        private CompasDataContext context;

        public StaffShiftsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public StaffShift Get(int ID)
        {
            StaffShift result;

            result = (from a in context.StaffShifts
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<StaffShift> GetAll()
        {
            List<StaffShift> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffShifts                          
                          select a).ToList();
            //}
            return result;
        }

       
       

        public int Create(string Name,  TimeSpan StartTime, TimeSpan EndTime)
        {
            int result = 1;
            StaffShift sr = StaffShift.CreateStaffShift(1, Name, StartTime, EndTime);
            context.AddToStaffShifts(sr);
           
            return result;
        }

        public int Update(int ID, string Name, TimeSpan StartTime, TimeSpan EndTime)
        {
            int result = 1;
            StaffShift sr = (from a in context.StaffShifts
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.StartTime = StartTime;
            sr.EndTime = EndTime;           
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffShift sr = (from a in context.StaffShifts
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffShifts.DeleteObject(sr);

            return result;
        }

        
    }
}
