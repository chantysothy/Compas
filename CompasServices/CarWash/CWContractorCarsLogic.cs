using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Helpers;



namespace Compas.Logic

{

    
    /// <summary>
    /// Упавління довідником автомобілів клієнтів
    /// </summary>
    public class CWContractorCarsLogic : IGenericInterface<CWContractorCar>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public CWContractorCarsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public CWContractorCar Get(int ID)
        {
            CWContractorCar result;

            result = (from a in context.CWContractorCars
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<CWContractorCar> GetAll()
        {
            List<CWContractorCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWContractorCars                          
                          select a).ToList();
            //}
            return result;
        }

        //public SortableBindingList<CWContractorCar> GetAllView()
        //{
        //    List<CWContractorCar> result = new List<CWContractorCar>();
        //    //using (var cdc = new CompasDataContext())
        //    //{
        //    foreach (CWContractorCar ContractorCar in this.GetAll())
        //    {
        //        result.Add(new CWContractorCar(ContractorCar));
        //    }
        //    //}
        //    SortableBindingList<CWContractorCarView> filteredView = new SortableBindingList<CWContractorCarView>(result);
        //    return filteredView;
        //}

        public List<CWContractorCar> GetAll(int ContractorID)
        {
            List<CWContractorCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWContractorCars
                      where a.ContractorID == ContractorID
                      select a).ToList();
            //}
            return result;
        }

        
        
       

        public int Create(int ContractorID, int CarID)
        {
            int result = 1;
            CWContractorCar sr = CWContractorCar.CreateCWContractorCar(1, ContractorID, CarID);
           
            context.AddToCWContractorCars(sr);
            return result;
        }

        public int Create(int ContractorID, CWCar Car)
        {
            int result = 1;

            Contractors.ContractorsLogic contractorsLogic = new Contractors.ContractorsLogic(manager);
            var carExists = from a in context.CWContractorCars
                            where a.ContractorID == ContractorID & a.CWCar.Number == Car.Number &
                            a.CWCar.ModelID == Car.ModelID & a.CWCar.BrandID == Car.BrandID
                            select a;
            if (carExists.Count() == 0)
            {
                Contractor contractor = contractorsLogic.Get(ContractorID);
                if (contractor != null)
                {
                    CWContractorCar cc = new CWContractorCar();
                    cc.ContractorID = ContractorID;
                    Car.CWContractorCars.Add(cc);
                    context.AddToCWContractorCars(cc);
                }
            }
            
            return result;
        }

        public int Update(int ID)
        {
            int result = 1;
            
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            CWContractorCar sr = (from a in context.CWContractorCars
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.CWContractorCars.DeleteObject(sr);

            return result;
        }

        
    }
}
