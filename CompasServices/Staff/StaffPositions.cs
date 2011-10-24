using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Staff

{
    public class StaffPositionsLogic : IGenericInterface<StaffPosition>
    {

        private CompasDataContext context;

        public StaffPositionsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public StaffPosition Get(int ID)
        {
            StaffPosition result;

            result = (from a in context.StaffPositions
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<StaffPosition> GetAll()
        {
            List<StaffPosition> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffPositions                          
                          select a).ToList();
            //}
            return result;
        }

       
       

        public int Create(string Name,  bool Active)
        {
            int result = 1;
            StaffPosition sr = StaffPosition.CreateStaffPosition(1, Name, Active);
            context.AddToStaffPositions(sr);
           
            return result;
        }

        public int Update(int ID, string Name, bool Active)
        {
            int result = 1;
            StaffPosition sr = (from a in context.StaffPositions
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.Active = Active;
                     
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffPosition sr = (from a in context.StaffPositions
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffPositions.DeleteObject(sr);

            return result;
        }

        
    }
}
