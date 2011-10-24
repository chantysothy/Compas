using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Contractors
{
    
    /// <summary>
    /// Упавління довідником типів контрагентів
    /// </summary>
    public class ContractorTypesLogic : IGenericInterface<ContractorType>
    {

        private CompasDataContext context;

        public ContractorTypesLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public ContractorType Get(int ID)
        {
            ContractorType result;

            result = (from a in context.ContractorTypes
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<ContractorType> GetAll()
        {
            List<ContractorType> result;

            result = (from a in context.ContractorTypes
                      select a).ToList().OrderBy(a => a.Name).ToList();
            
            return result;
        }




        public int Create(string Name)
        {
            int result = 1;
            ContractorType sr = ContractorType.CreateContractorType(1, Name);

            context.AddToContractorTypes(sr);
            return result;
        }

        public int Update(int ID, string Name)
        {
            int result = 1;
            ContractorType sr = (from a in context.ContractorTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.Name = Name;
            


            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            ContractorType sr = (from a in context.ContractorTypes
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.ContractorTypes.DeleteObject(sr);

            return result;
        }


    }
}
