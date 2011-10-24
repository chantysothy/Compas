using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Documents;

namespace Compas.Logic.Staff
{
    /// <summary>
    /// Управління ставками працівників
    /// </summary>
    public class StaffEmployeeSalariesLogic: IGenericInterface<StaffEmployeeSalary>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public StaffEmployeeSalariesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public StaffEmployeeSalary Get(int ID)
        {
            StaffEmployeeSalary result;

            result = (from a in context.StaffEmployeeSalaries
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        


        /// <summary>
        /// Загальний перелік всіх ставок всіх працівників за весь час
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployeeSalary> GetAll()
        {
            List<StaffEmployeeSalary> result;
           
            result = (from a in context.StaffEmployeeSalaries                          
                          select a).ToList();
            
            return result;
        }

        /// <summary>
        /// Загальний перелік ставок по відділу
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployeeSalary> GetAll(int? StructureObjectID)
        {
            List<StaffEmployeeSalary> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeeSalaries
                      where a.StructureObjectID == StructureObjectID
                      select a).Distinct().ToList();
            //}
            return result;
        }
        

        /// <summary>
        /// Перелік ставок по відділу за місяць 
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployeeSalary> GetAll(int? StructureObjectID, DateTime Month)
        {
            List<StaffEmployeeSalary> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeeSalaries
                      where a.StructureObjectID == StructureObjectID & a.Month == Month
                      select a).Distinct().ToList();
            //}
            return result;
        }

        /// <summary>
        /// Перелік ставок працівника
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployeeSalary> GetByEmployeeID(int EmployeeID)
        {
            List<StaffEmployeeSalary> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeeSalaries
                      where a.EmployeeID == EmployeeID
                      select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Перелік ставок працівника
        /// </summary>
        /// <returns></returns>
        public StaffEmployeeSalary GetByEmployeeID(int EmployeeID, DateTime Month)
        {
            StaffEmployeeSalary result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeeSalaries
                      where a.EmployeeID == EmployeeID & a.Month == Month
                      select a).FirstOrDefault();
            //}
            return result;
        }

        /// <summary>
        /// Перелік ставок працівника
        /// </summary>
        /// <returns></returns>
        public List<ViewStaffEmployeeSalary> GetViewByEmployeeID(int EmployeeID)
        {
            List<ViewStaffEmployeeSalary> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.ViewStaffEmployeeSalaries
                      where a.EmployeeID == EmployeeID
                      select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Перелік ставок
        /// </summary>
        /// <returns></returns>
        public List<ViewStaffEmployeeSalary> GetView()
        {
            List<ViewStaffEmployeeSalary> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.ViewStaffEmployeeSalaries                     
                      select a).ToList();
            //}
            return result;
        }

       

        /// <summary>
        /// Створення запису про нарахування оплати працівнику. 
        /// </summary>
        /// <param name="Month">Місяць нарахування</param>
        /// <param name="StructureObjectID">Об'єкт по якому здіснено нарахування.</param>
        /// <param name="EmployeeID">Працівник</param>
        /// <param name="SumSale">Сума продаж за місяць</param>
        /// <param name="ExtraPercent">Процент від суми продажу</param>
        /// <param name="Salary">Ставка</param>
        /// <returns></returns>
        public int Create(DateTime Month, int StructureObjectID, int EmployeeID, decimal SumSale, decimal ExtraPercent, decimal Salary)
        {
            int result = 1;
            StaffEmployeeSalary sr = new StaffEmployeeSalary();
            sr.Month = Month;
            sr.StructureObjectID = StructureObjectID;
            sr.EmployeeID = EmployeeID;
            sr.SumSale = SumSale;
            sr.ExtraPercent = ExtraPercent;
            sr.Salary = Salary;//ставка
            sr.SumSalary = (SumSale / 100) * ExtraPercent + Salary;//процент від продажу + ставка

           
            context.AddToStaffEmployeeSalaries(sr);
            result = sr.ID;
            return result;
        }

        public int Update(int ID, DateTime Month, int StructureObjectID, decimal SumSale, decimal ExtraPercent, decimal Salary)
        {
            int result = 1;

            StaffEmployeeSalary sr = (from a in context.StaffEmployeeSalaries
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Month = Month;
            sr.StructureObjectID = StructureObjectID;
            sr.SumSale = SumSale;
            sr.ExtraPercent = ExtraPercent;
            sr.Salary = Salary;
            sr.SumSalary = (SumSale / 100) * ExtraPercent + Salary;
            return result;
        }

        public int Recalculate(DateTime Month, int StructureObjectID)
        {
            int result = 1;
            StaffEmployeeLogic employeesLogic = new StaffEmployeeLogic(manager);
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            //List<Helpers.ItemIntValue> structureObjects = structureObjectsLogic.GetStructureObjectsHierarchy(false, StructureObjectID).ToList();
             //спочатку вибираємо працівників, що працюють в цьому відділі і всіх дочірніх відділах
            StaffEmployeePositionsLogic positionsLogic = new StaffEmployeePositionsLogic(manager);


            List<StaffEmployee> employees = positionsLogic.GetAllWithSubDepartments(StructureObjectID); ;  
            //проходимо покожному окремому працівнику
            foreach(StaffEmployee employee in employees)
            {                
            //здійснюємо перерахунок по цьому працівнику
            
                decimal prevMonthSalary = 0;
                decimal prevMonthExtraPercent = 0;
                decimal currentMonthSalary = 0;
                decimal currentMonthExtraPercent = 0;
                decimal documentsSum = 0;

                //шукаємо документи до яких прикріплений даний працівник
                DocumentsLogic documentsLogic = new DocumentsLogic(manager);
                DocumentDetailsLogic documentDetailsLogic = new DocumentDetailsLogic(manager);
                DocumentStaffDetailsLogic documentStaffDetailsLogic = new DocumentStaffDetailsLogic(manager);
                List<WareDocument> documents = documentsLogic.GetDocumentsByEmployeeID(employee.ID, Month, Month.AddMonths(1));
                
                //визначаємо суму документів
                foreach (WareDocument document in documents)
                {
                    documentsSum = documentsSum + document.DocumentSum;
                }


                //для цього спочатку шукаємо оклад працівника за ПОТОЧНИЙ місяць, якщо такий відсутній, то прирівнюємо до 0
                StaffEmployeeSalary currentSalary = this.GetByEmployeeID(employee.ID, Month);
                if (currentSalary != null)
                {
                    currentMonthSalary = currentSalary.Salary;
                    currentMonthExtraPercent = currentSalary.ExtraPercent;
                    currentSalary.SumSale = documentsSum;
                    currentSalary.SumSalary = currentSalary.SumSale * (currentMonthExtraPercent / 100) + currentMonthSalary;
                }
                else
                {
                    //для цього спочатку шукаємо оклад працівника за попередній місяць, якщо такий відсутній, то прирівнюємо до 0
                    StaffEmployeeSalary prevSalary = this.GetByEmployeeID(employee.ID, Month.AddMonths(-1));
                    if (prevSalary != null)
                    {
                        prevMonthSalary = prevSalary.Salary;
                        prevMonthExtraPercent = prevSalary.ExtraPercent;
                    }
                    currentMonthSalary = prevMonthSalary;
                    currentMonthExtraPercent = prevMonthExtraPercent;
                    this.Create(Month, StructureObjectID, employee.ID, documentsSum, currentMonthExtraPercent, currentMonthSalary); 
                }

            }
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffEmployeeSalary sr = (from a in context.StaffEmployeeSalaries
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffEmployeeSalaries.DeleteObject(sr);

            return result;
        }

        
    }
}
