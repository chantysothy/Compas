using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Staff
{
    /// <summary>
    /// Управління посадами, які займає працівник
    /// </summary>
    public class StaffEmployeePositionsLogic: IGenericInterface<StaffEmployeePosition>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public StaffEmployeePositionsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public StaffEmployeePosition Get(int ID)
        {
            StaffEmployeePosition result;

            result = (from a in context.StaffEmployeePositions
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }


        /// <summary>
        /// Загальний перелік всіх посад всіх працівників
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployeePosition> GetAll()
        {
            List<StaffEmployeePosition> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeePositions                          
                          select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Загальний працівників по відділу
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployee> GetAll(int? StructureObjectID)
        {
            List<StaffEmployee> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeePositions
                      where a.StructureObjectID == StructureObjectID
                      select a.StaffEmployee).Distinct().ToList();
            //}
            return result;
        }

        /// <summary>
        /// Загальний працівників по відділу
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployee> GetAllWithSubDepartments(int StructureObjectID)
        {
            List<StaffEmployee> result = new List<StaffEmployee>();
            //using (var cdc = new CompasDataContext())
            //{
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            List<Helpers.ItemIntValue> structureObjects = structureObjectsLogic.GetStructureObjectsHierarchy(false, StructureObjectID).ToList();
            
            Compas.Helpers.ItemIntValue rootItemInt = new Helpers.ItemIntValue();
            rootItemInt.ID =  Convert.ToInt32(StructureObjectID);
            rootItemInt.Name = "root";
            structureObjects.Add(rootItemInt);

            foreach (Helpers.ItemIntValue so in structureObjects)
            {
                foreach (StaffEmployee employee in this.GetAll(so.ID))
                {
                    result.Add(employee);
                }
            }
            return result;
        }
        

        /// <summary>
        /// Загальний перелік всіх посад працівника з історією
        /// </summary>
        /// <returns></returns>
        public List<StaffEmployeePosition> GetByEmployeeID(int EmployeeID)
        {
            List<StaffEmployeePosition> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeePositions
                      where a.EmployeeID == EmployeeID
                      select a).ToList();
            //}
            return result;
        }

        public List<StaffEmployeePosition> GetByPositionID(int PositionID)
        {
            List<StaffEmployeePosition> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeePositions
                      where a.PositionID == PositionID
                      select a).ToList();
            //}
            return result;
        }

        /// <summary>
        /// Загальний перелік всіх посад працівника 
        /// </summary>
        /// <returns></returns>
        public List<StaffPosition> GetPositionsByEmployeeID(int EmployeeID)
        {
            List<StaffPosition> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffEmployeePositions
                      where a.EmployeeID == EmployeeID & a.Active == true
                      select a.StaffPosition).Distinct().ToList();
            //}
            return result;
        }

        public int Create(int EmployeeID, int PositionID, DateTime StartDate, DateTime? EndDate, bool Active, int? StructureObjectID)
        {
            int result = 1;
            StaffEmployeePosition sr = StaffEmployeePosition.CreateStaffEmployeePosition(1, EmployeeID, PositionID, StartDate, Active);
            sr.StructureObjectID = StructureObjectID;
            sr.EndDate = EndDate;
            context.AddToStaffEmployeePositions(sr);
            result = sr.ID;
            return result;
        }

        public int Update(int ID, int PositionID, DateTime StartDate, DateTime? EndDate, bool Active, int? StructureObjectID)
        {
            int result = 1;

            StaffEmployeePosition sr = (from a in context.StaffEmployeePositions
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Active = Active;
            sr.PositionID = PositionID;
            sr.StartDate = StartDate;
            sr.EndDate = EndDate;
            sr.StructureObjectID = StructureObjectID;

            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffEmployeePosition sr = (from a in context.StaffEmployeePositions
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffEmployeePositions.DeleteObject(sr);

            return result;
        }

        
    }
}
