using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Staff

{
    public class StaffTeamsLogic : IGenericInterface<StaffTeam>
    {

        private CompasDataContext context;

        public StaffTeamsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public StaffTeam Get(int ID)
        {
            StaffTeam result;

            result = (from a in context.StaffTeams
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<StaffTeam> GetAll()
        {
            List<StaffTeam> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffTeams                          
                          select a).ToList();
            //}
            return result;
        }

        public List<StaffTeam> GetByStructureObject(int StructureObjectID)
        {
            List<StaffTeam> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.StaffTeams
                      where a.StructureObjectID == StructureObjectID
                      select a).ToList();
            //}
            return result;
        }
       

        public int Create(string Name,  int StructureObjectID)
        {
            int result = 1;
            StaffTeam sr = StaffTeam.CreateStaffTeam(1, StructureObjectID, Name);            
            context.AddToStaffTeams(sr);
            return result;
        }

        public int Update(int ID, string Name, int StructureObjectID)
        {
            int result = 1;
            StaffTeam sr = (from a in context.StaffTeams
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.Name = Name;
            sr.StructureObjectID = StructureObjectID;
                      
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            StaffTeam sr = (from a in context.StaffTeams
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.StaffTeams.DeleteObject(sr);

            return result;
        }

        
    }
}
