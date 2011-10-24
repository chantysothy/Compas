using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;



namespace Compas.Logic.Security
{
    public class SecurityRoleActionsLogic : IGenericInterface<SecurityRoleAction>
    {

        private CompasDataContext context;

        public SecurityRoleActionsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public SecurityRoleAction Get(int ID)
        {
            SecurityRoleAction result;

            result = (from a in context.SecurityRoleActions
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public SecurityRoleAction Get(int RoleID, int ActionID)
        {
            SecurityRoleAction result;

            result = (from a in context.SecurityRoleActions
                      where a.RoleID == RoleID & a.ActionID == ActionID
                      select a).FirstOrDefault();


            return result;
        }

        public bool Exists(int RoleID, int ActionID, bool Allow)
        {
            SecurityRoleAction result;

            result = (from a in context.SecurityRoleActions
                      where a.RoleID == RoleID & a.ActionID == ActionID & a.Allow == Allow
                      select a).FirstOrDefault();

            if (result != null)
                return true;
            else
                return false;
        }

        public List<SecurityRoleAction> GetAll()
        {
            List<SecurityRoleAction> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.SecurityRoleActions
                      select a).ToList();
            //}
            return result;
        }

       
        public int Create(int RoleID, int ActionID, bool Allow)
        {
            int result = 1;
            SecurityRoleAction sr = SecurityRoleAction.CreateSecurityRoleAction(1, RoleID, ActionID, Allow);
            
            context.AddToSecurityRoleActions(sr);
            return result;
        }

        public int Update(int ID, int RoleID, int ActionID, bool Allow)
        {
            int result = 1;
            SecurityRoleAction sr = (from a in context.SecurityRoleActions
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.RoleID = RoleID;
            sr.ActionID = ActionID;
            sr.Allow = Allow;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            SecurityRoleAction sr = (from a in context.SecurityRoleActions
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.SecurityRoleActions.DeleteObject(sr);

            return result;
        }

        public int Delete(int RoleID, int ActionID)
        {
            int result = 1;
            SecurityRoleAction sr = (from a in context.SecurityRoleActions
                                     where a.RoleID == RoleID & a.ActionID == ActionID
                                     select a).FirstOrDefault();
            if (sr != null)
                context.SecurityRoleActions.DeleteObject(sr);

            return result;
        }


    }
}
