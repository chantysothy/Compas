//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Compas.Model;



//namespace Compas.Logic.Staff

//{
//    /// <summary>
//    /// Упавління робочими місцями
//    /// </summary>
//    public class StaffWorkPlacesLogic : IGenericInterface<StaffWorkPlace>
//    {

//        private CompasDataContext context;

//        public StaffWorkPlacesLogic(ContextManager contextManager)
//        {
//            context = contextManager.Context;
//        }

//        public StaffWorkPlace Get(int ID)
//        {
//            StaffWorkPlace result;

//            result = (from a in context.StaffWorkPlaces
//                         where a.ID == ID
//                         select a).FirstOrDefault();
            
           
//            return result;
//        }

//        public List<StaffWorkPlace> GetAll()
//        {
//            List<StaffWorkPlace> result;
//            //using (var cdc = new CompasDataContext())
//            //{
//            result = (from a in context.StaffWorkPlaces                          
//                          select a).ToList();
//            //}
//            return result;
//        }

//        /// <summary>
//        /// Робочі місця відділу
//        /// </summary>
//        /// <param name="StructureObjectID"></param>
//        /// <returns></returns>
//        public List<StaffWorkPlace> GetByStructureObject(int StructureObjectID)
//        {
//            List<StaffWorkPlace> result;
//            //using (var cdc = new CompasDataContext())
//            //{
//            result = (from a in context.StaffWorkPlaces
//                      where a.StructureObjectID == StructureObjectID
//                      select a).ToList();
//            //}
//            return result;
//        }
       

//        public int Create(string Name,  int? StructureObjectID)
//        {
//            int result = 1;
//            StaffWorkPlace sr = StaffWorkPlace.CreateStaffWorkPlace(1, Name);
//            sr.StructureObjectID = StructureObjectID;
//            context.AddToStaffWorkPlaces(sr);
//            return result;
//        }

//        public int Update(int ID, string Name, int StructureObjectID)
//        {
//            int result = 1;
//            StaffWorkPlace sr = (from a in context.StaffWorkPlaces
//                               where a.ID == ID
//                               select a).FirstOrDefault();
//            sr.Name = Name;
//            sr.StructureObjectID = StructureObjectID;
                      
//            return result;
//        }

//        public int Delete(int ID)
//        {
//            int result = 1;
//            StaffWorkPlace sr = (from a in context.StaffWorkPlaces
//                               where a.ID == ID
//                               select a).FirstOrDefault();
//            if (sr != null)
//                context.StaffWorkPlaces.DeleteObject(sr);

//            return result;
//        }

        
//    }
//}
