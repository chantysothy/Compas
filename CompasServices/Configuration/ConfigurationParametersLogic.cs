using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Config
{
    
    /// <summary>
    /// Упавління параметрами
    /// 
    /// </summary>
    public class ConfigurationParametersLogic : IGenericInterface<ConfigurationParameter>
    {

        private CompasDataContext context;
        string modeCode;
        int currentUserId;
        List<ConfigurationParameter> localCopyConfigurationParameters;

        public ConfigurationParametersLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            modeCode = Compas.Logic.Security.CurrentSecurityContext.ModeCode;
            currentUserId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
            localCopyConfigurationParameters = this.GetAll();
        }

        public ConfigurationParameter Get(int ID)
        {
            ConfigurationParameter result;

            result = (from a in context.ConfigurationParameters
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<ConfigurationParameter> GetAll()
        {
            List<ConfigurationParameter> result;

            result = (from a in context.ConfigurationParameters
                      select a).ToList().OrderBy(a => a.ID).ToList();
            
            return result;
        }

        public List<ViewConfigurationParameter> GetAllView()
        {
            List<ViewConfigurationParameter> result;

            result = (from a in context.ViewConfigurationParameters
                      select a).ToList().OrderBy(a => a.ID).ToList();

            return result;
        }

        ///

        
        /// <summary>
        /// повертаємо параметр, необхідний для ПОТОЧНОГО режиму роботи і даного користувача
        /// </summary>
        /// <param name="Parameter"></param>
        /// <returns></returns>
        public ConfigurationParameter Get(string Parameter)
        {

            ConfigurationParameter result;
            //дані по користувачу перекривають дані по режиму
            result = (from a in localCopyConfigurationParameters
                      where a.SecurityMode.Code == modeCode & (a.UserID == currentUserId)
                      & a.Parameter == Parameter
                      select a).FirstOrDefault();

            if (result == null)
            {
                //якщо немає по користувачу то по режиму
                result = (from a in localCopyConfigurationParameters
                          where a.SecurityMode.Code == modeCode & (a.UserID == null)
                          & a.Parameter == Parameter
                          select a).FirstOrDefault();
            }

            return result;
        }

        /// <summary>
        /// повертаємо параметр для ВКАЗАНОГО режиму роботи і даного користувача
        /// </summary>
        /// <param name="Parameter"></param>
        /// <returns></returns>
        public ConfigurationParameter Get(int InstallationID, int ModeID, string Parameter)
        {

            ConfigurationParameter result;
            //дані по користувачу перекривають дані по режиму
            result = (from a in localCopyConfigurationParameters
                      where a.ModeID == ModeID
                      & a.Parameter == Parameter & a.InstallationID == InstallationID
                      select a).FirstOrDefault();

           

            return result;
        }




        public int Create(int ModeID, int? UserID, string Parameter, string Value, string Comment)
        {
            int result = 1;
            ConfigurationParameter sr = ConfigurationParameter.CreateConfigurationParameter(
                1, ModeID, Parameter, Value, Comment);
            sr.UserID = UserID;
            context.AddToConfigurationParameters(sr);
            return result;
        }

        public int Create(int InstallationID, int ModeID, int? UserID, string Parameter, string Value, string Comment)
        {
            int result = 1;

            ConfigurationParameter exists = (from a in context.ConfigurationParameters
                         where a.InstallationID == InstallationID
                         & a.ModeID == ModeID
                         & a.Parameter == Parameter
                         & (UserID == null || (UserID != null & a.UserID == UserID))
                         select a).FirstOrDefault();
            if (exists == null)
            {
                ConfigurationParameter sr = ConfigurationParameter.CreateConfigurationParameter(
                    1, ModeID, Parameter, Value, Comment);
                sr.InstallationID = InstallationID;
                sr.UserID = UserID;
                context.AddToConfigurationParameters(sr);
            }
            else
            {
                exists.Value = Value;
            }
            return result;
        }

        public int Update(int ID, int ModeID, int? UserID, string Parameter, string Value, string Comment)
        {
            int result = 1;
            ConfigurationParameter sr = (from a in context.ConfigurationParameters
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.ModeID = ModeID;
            sr.UserID = UserID;
            sr.Parameter = Parameter;
            sr.Value = Value;
            sr.Comment = Comment;
           
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            ConfigurationParameter sr = (from a in context.ConfigurationParameters
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.ConfigurationParameters.DeleteObject(sr);

            return result;
        }


    }
}
