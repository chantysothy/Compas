using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Staff
{

    public class StaffEmployeeView
    {
        public StaffEmployee _StaffEmployee;
        public StaffEmployeeView(StaffEmployee Employee)
        {
            _StaffEmployee = Employee;
        }

        public StaffEmployee Employee
        {
            get { return _StaffEmployee; }
        }

        public string FullName
        {
            get { return _StaffEmployee.LastName + " " + _StaffEmployee.FirstName + " " + _StaffEmployee.MiddleName; }
        }

        public int ID
        {
            get { return _StaffEmployee.ID; }
        }
    }
    public class StaffEmployeeLogic: IGenericInterface<StaffEmployee>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public StaffEmployeeLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public List<StaffEmployeeView> ConvertListToListView(List<StaffEmployee> Employees)
        {
            List<StaffEmployeeView> result = new List<StaffEmployeeView>();
            foreach (StaffEmployee employee in Employees)
            {
                result.Add(new StaffEmployeeView(employee));
            }
            return result;
        }


        public StaffEmployee Get(int ID)
        {
            StaffEmployee result;

            result = (from a in context.StaffEmployees
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public StaffEmployee GetByUserID(int UserID)
        {
            StaffEmployee result;

            result = (from a in context.StaffEmployees
                      where a.UserID == UserID
                      select a).FirstOrDefault();


            return result;
        }


        /// <summary>
        /// Всі працівники
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployee> GetAll()
        {
            List<StaffEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployees                          
                          select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Всі працівники, які належать до бригади і вказаної зміни
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployee> GetAll(int TeamID, int StaffID)
        {
            List<StaffEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployees
                      select a).ToList();
            //}
            return result;
        }


        /// <summary>
        /// Весь персонал по підприємству
        /// </summary>
        
        public List<StaffEmployee> GetAll(int StructureObjectID)
        {
            List<StaffEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployees
                      where a.StructureObjectID == StructureObjectID 
                      select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Весь персонал по StructureObjectID
        /// </summary>

        public List<StaffEmployeeView> GetAllView(int StructureObjectID)
        {
            List<StaffEmployeeView> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = this.ConvertListToListView( (from a in context.StaffEmployees
                      where a.StructureObjectID == StructureObjectID
                      select a).ToList());
            //}
            return result;
        }

        /// <summary>
        /// Весь персонал по StructureObjectID недороблено
        /// </summary>

        public List<StaffEmployeeView> GetAllHierarhyView(int StructureObjectID)
        {
            List<StaffEmployeeView> result;
            //using (var cdc = new CompasDataContext())
            //{
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            //List<Helpers.ItemIntValue> allObjects = structureObjectsLogic.GetStructureObjectsHierarchy(StructureObjectID);
            result = this.ConvertListToListView((from a in context.StaffEmployees
                                                 where a.StructureObjectID == StructureObjectID
                                                 select a).ToList());
            //}
            return result;
        }

        /// <summary>
        /// Весь персонал по StructureObjectID  не робить
        /// </summary>

        public List<StaffEmployee> GetAllHierarhy(int StructureObjectID)
        {
            List<StaffEmployee> result = new List<StaffEmployee>();
            //using (var cdc = new CompasDataContext())
            //{
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            List<Helpers.ItemIntValue> structureObjects = structureObjectsLogic.GetStructureObjectsHierarchy(false, StructureObjectID).ToList();
            Compas.Helpers.ItemIntValue rootItemInt = new Helpers.ItemIntValue();
            rootItemInt.ID = StructureObjectID;
            rootItemInt.Name = "root";
            structureObjects.Add(rootItemInt);
            foreach(Helpers.ItemIntValue so in structureObjects)
            {
                foreach(StaffEmployee employee in this.GetAll(so.ID))
                {
                    result.Add(employee);
                }
            }
           
            //}
            return result;
        }

        public List<StaffEmployeeView> GetAllView()
        {
            List<StaffEmployeeView> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = this.ConvertListToListView((from a in context.StaffEmployees                                                
                                                 select a).ToList());
            //}
            return result;
        }
        /// <summary>
        /// працівники бригади
        /// </summary>
        /// <param name="TeamID"></param>
        /// <returns></returns>
        public List<StaffEmployee> GetAllByTeamID(int TeamID)
        {
            List<StaffEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffTeamEmployees
                      where a.TeamID == TeamID
                      select a.StaffEmployee).Distinct().ToList();
            //}
            return result;
        }

        /// <summary>
        /// працівники бригади
        /// </summary>
        /// <param name="TeamID"></param>
        /// <returns></returns>
        public List<StaffEmployeeView> GetAllViewByTeamID(int TeamID)
        {
            List<StaffEmployeeView> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = this.ConvertListToListView((from a in context.StaffTeamEmployees
                      where a.TeamID == TeamID
                      select a.StaffEmployee).Distinct().ToList());
            //}
            return result;
        }

        /// <summary>
        /// Працівники відділу
        /// </summary>
        /// <param name="EnterpriseID"></param>
        /// <param name="StructureObjectID"></param>
        /// <returns></returns>
        public List<StaffEmployee> GetAll(int EnterpriseID, int? StructureObjectID)
        {
            List<StaffEmployee> result = new List<StaffEmployee>();
            
            return result;
        }

        //public List<StaffEmployee> GetByStructureObject(int StructureObjectID)
        //{
        //    List<StaffTeam> result;
        //    //using (var cdc = new CompasDataContext())
        //    //{
        //    result = (from a in context.StaffEmployees
        //              where a.StaffStructureObjectEmployees.StructureObjectID == StructureObjectID
        //              select a).ToList();
        //    //}
        //    return result;
        //}
       

        public int Create(string LastName, string FirstName, string MiddleName,
            string City, string Street, string Building, string Flat, string Phone,
            string MobPhone, DateTime? HireDate, int? StructureObjectID)
        {
            int result = 1;
            StaffEmployee sr = StaffEmployee.CreateStaffEmployee(1, LastName, FirstName, MiddleName);
            sr.StructureObjectID = StructureObjectID;
            sr.City = City;
            sr.Street = Street;
            sr.Building = Building;
            sr.Flat = Flat;
            sr.Phone = Phone;
            sr.MobPhone = MobPhone;
            sr.HireDate = HireDate;

            //StaffStructureObjectEmployee staffDep = new StaffStructureObjectEmployee();
            //if(StructureObjectID != null)
            //{
            //    staffDep.StructureObjectID = Convert.ToInt32(StructureObjectID);
            //    staffDep.StaffEmployee = sr;
            //}
            //StaffStructureObjectEmployee staffStructureObject = StaffStructureObjectEmployee.CreateStaffStructureObjectEmployee(1, Convert.ToInt32(StructureObjectID),

            context.AddToStaffEmployees(sr);
            result = sr.ID;
            return result;
        }

        public int Update(int ID,string LastName, string FirstName, string MiddleName,
            string City, string Street, string Building, string Flat, string Phone,
            string MobPhone, DateTime? HireDate, DateTime? ReleaseDate, int? StructureObjectID)
        {
            int result = 1;
            StaffEmployee sr = (from a in context.StaffEmployees
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.LastName = LastName;
            sr.FirstName = FirstName;
            sr.MiddleName = MiddleName;
            sr.City = City;
            sr.Street = Street;
            sr.Building = Building;
            sr.Flat = Flat;
            sr.Phone = Phone;
            sr.MobPhone = MobPhone;
            sr.HireDate = HireDate;
            sr.ReleaseDate = ReleaseDate;
            sr.StructureObjectID = StructureObjectID;

            //int StructureObjectId;
            //if (StructureObjectID != null)
            //{
            //    StructureObjectId = Convert.ToInt32(StructureObjectID);
            //    //StaffStructureObjectEmployee staffDepExist0 = (from a in context.StaffStructureObjectEmployees
            //    //                                    where a.EmployeeID == ID & a.StructureObjectID == StructureObjectId
            //    //                                    select a).FirstOrDefault();
            //    //if (staffDepExist0 == null)
            //    //{
            //    //    StaffStructureObjectEmployee staffDep = new StaffStructureObjectEmployee();
            //    //    staffDep.StructureObjectID = Convert.ToInt32(StructureObjectID);
            //    //    staffDep.StaffEmployee = sr;
            //    //}

            //    //else
            //    //{
            //    //    StaffStructureObjectEmployee staffDepExist1 = (from a in context.StaffStructureObjectEmployees
            //    //                                              where a.EmployeeID == ID & a.StructureObjectID != StructureObjectId
            //    //                                              select a).FirstOrDefault();

            //    //    if (staffDepExist1 != null)
            //    //    {
            //    //        staffDepExist1.StructureObjectID = StructureObjectId;
            //    //    }
            //    //}
            //}

            

            return result;
        }


       

        public int Delete(int ID)
        {
            int result = 1;
            StaffEmployee sr = (from a in context.StaffEmployees
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffEmployees.DeleteObject(sr);

            return result;
        }

        
    }
}
