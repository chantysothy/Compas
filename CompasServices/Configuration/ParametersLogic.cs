using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Logic;

namespace Compas.Logic.Config
{
    
    /// <summary>
    /// Упавління параметрами
    /// 
    /// </summary>
    /// 
    

    public class ParametersLogic
    {

        private List<Helpers.Item> AvailableParameters;
        //private CompasDataContext context;
        public enum Parameter
        { 
            DOCUMENT_TYPE,
            DOCUMENT_TYPE_ENABLED,
            DOCUMENT_TO_OBJECT,
            DOCUMENT_FROM_OBJECT,
            DOCUMENT_TO_OBJECT_ENABLED,
            DOCUMENT_FROM_OBJECT_ENABLED,
            DOCUMENT_DATE_ENABLED,
            DOCUMENT_CURRENCY,
            DOCUMENT_CURRENCY_ENABLED,
            DOCUMENT_CAR_VISIBLE,
            DOCUMENT_CAR_DEFAULT_CATEGORY,
            DOCUMENT_PARAMETERS_IN_DOCUMENTDATA_VISIBLE,

            DOCUMENTDETAILS_SHOW_SECONDARY_UNIT,

            PAYMENTS_SHOW_CARD,

            MENUITEM_CARWASH_VISIBLE,
            MENUITEM_CARDS_VISIBLE,
            MENUITEM_STAFF_ENABLED,
            MENUITEM_SECURITY_ENABLED,

            CASHREGISTER_PORTNUMBER,
            CASHREGISTER_LOGICNUMBER,
            CASHREGISTER_USER,
            CASHREGISTER_PASSWORD



        };

        public ParametersLogic()
        {
            AvailableParameters = new List<Helpers.Item>();
            foreach (Parameter p in Enum.GetValues(typeof(Parameter)))
            {
                Helpers.Item item = new Helpers.Item(p.ToString(), p.ToString());
                AvailableParameters.Add(item);
            }
            //AvailableParameters.Add(new Helpers.Item(", ""));
            //AvailableParameters.Add(new Helpers.Item("", ""));
            //AvailableParameters.Add(new Helpers.Item("", ""));
            //AvailableParameters.Add(new Helpers.Item("", ""));
            //AvailableParameters.Add(new Helpers.Item("", ""));
            //AvailableParameters.Add(new Helpers.Item("", ""));

        }

        

        public List<Helpers.Item> GetAll()
        {
            List<Helpers.Item> result = (from a in AvailableParameters
                                        select a).ToList();       
            
            return result;
        }




       


    }
}
