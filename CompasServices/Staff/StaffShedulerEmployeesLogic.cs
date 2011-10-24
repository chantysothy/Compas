using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Staff

{
    public class StaffShedulerEmployeesLogic : IGenericInterface<StaffShedulerEmployee>
    {

        private CompasDataContext context;

        public StaffShedulerEmployeesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public StaffShedulerEmployee Get(int ID)
        {
            StaffShedulerEmployee result;

            result = (from a in context.StaffShedulerEmployees
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<StaffShedulerEmployee> GetAll()
        {
            List<StaffShedulerEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffShedulerEmployees                          
                          select a).ToList();
            //}
            return result;
        }

        public List<StaffShedulerEmployee> GetBySheduler(int ShedulerID)
        {
            List<StaffShedulerEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffShedulerEmployees
                      where a.ShedulerID == ShedulerID
                      select a).ToList();
            //}
            return result;
        }

       
       

        public int Create(StaffSheduler Sheduler, int EmployeeID)
        {
            int result = 1;
            StaffShedulerEmployee sr = new StaffShedulerEmployee();
            sr.EmployeeID = EmployeeID;
            sr.StaffSheduler = Sheduler;
            context.AddToStaffShedulerEmployees(sr);
           
            return result;
        }

        public int Update(int ID)
        {
            int result = 1;
            StaffShedulerEmployee sr = (from a in context.StaffShedulerEmployees
                               where a.ID == ID
                               select a).FirstOrDefault();
                 
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffShedulerEmployee sr = (from a in context.StaffShedulerEmployees
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffShedulerEmployees.DeleteObject(sr);

            return result;
        }

        public int DeleteBySheduler(int ShedulerID)
        {
            int result = 1;
            IEnumerable<StaffShedulerEmployee> sr = from a in context.StaffShedulerEmployees
                                        where a.ShedulerID == ShedulerID
                                        select a;
            foreach (StaffShedulerEmployee a in sr)
            {
                context.StaffShedulerEmployees.DeleteObject(a);
            }

            return result;
        }

        
    }
}
