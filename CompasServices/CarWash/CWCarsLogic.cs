using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Helpers;



namespace Compas.Logic

{

    public class CWCarView
    {
        CWCar car;
        public CWCarView(CWCar Car)
        {
            car = Car;
        }

        public CWCar Car
        {
            get { return car; }
        }

        public string ModelName
        {
            get { return car.CWCarModel == null ? "" : car.CWCarModel.Name; }
        }

        public int? ModelID
        {
            get { return car.ModelID; }
        }

        public string BrandName
        {
            get { return car.CWCarBrand == null ? "" : car.CWCarBrand.Name; }
        }

        public int? BrandID
        {
            get { return car.BrandID; }
        }

        public int ID
        {
            get { return car.ID; }
        }


        public string Number
        {
            get { return car.Number; }
        }

        public string CategoryName
        {
            get { return car.CategoryID == null ? "" : car.CWCategory.Name; }
        }
    }
    /// <summary>
    /// Упавління довідником автомобілів клієнтів
    /// </summary>
    public class CWCarsLogic : IGenericInterface<CWCar>
    {

        private CompasDataContext context;

        public CWCarsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
        }

        public CWCar Get(int ID)
        {
            CWCar result;

            result = (from a in context.CWCars
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public List<CWCar> GetAll()
        {
            List<CWCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCars                          
                          select a).ToList();
            //}
            return result;
        }

        public SortableBindingList<CWCarView> GetAllView()
        {
            List<CWCarView> result = new List<CWCarView>();
            //using (var cdc = new CompasDataContext())
            //{
            foreach (CWCar car in this.GetAll())
            {
                result.Add(new CWCarView(car));
            }
            //}
            SortableBindingList<CWCarView> filteredView = new SortableBindingList<CWCarView>(result);
            return filteredView;
        }

        public List<CWCar> GetAll(int BrandID)
        {
            List<CWCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCars
                      where a.BrandID == BrandID
                      select a).ToList();
            //}
            return result;
        }

        
        public List<CWCar> GetAllByModel(int ModelID)
        {
            List<CWCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCars
                      where a.ModelID == ModelID
                      select a).ToList();
            //}
            return result;
        }

        public List<CWCar> GetAllByContractorID(int ContractorID)
        {
            List<CWCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWContractorCars
                      where a.ContractorID == ContractorID
                      select a.CWCar).ToList();
            //}
            return result;
        }

        public List<CWCar> GetAllByNumber(string Number)
        {
            List<CWCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCars
                      where a.Number == Number
                      select a).ToList();
            //}
            return result;
        }

        public List<CWCar> GetAll(string Number, int? ModelID, int? BrandID)
        {
            List<CWCar> result;
            //using (var cdc = new CompasDataContext())
            //{
            result = (from a in context.CWCars
                      where a.Number.Contains(Number) & ((a.ModelID == ModelID) || (ModelID == null))
                      & ((a.BrandID == BrandID) || (BrandID == null))
                      select a).ToList();
            //}
            return result;
        }


        public List<Contractor> GetContractorsByCarID(int CarID)
        {
            List<Contractor> result;
            result = (from a in context.CWContractorCars
                     where a.CarID == CarID
                     select a.Contractor).ToList();
            return result;
        }

        public CWCar Create(int? BrandID, int? ModelID, string Number, int? CategoryID)
        {
            int result = 1;
            CWCar sr = CWCar.CreateCWCar(1, Number);
            sr.ModelID = ModelID;
            sr.BrandID = BrandID;
            sr.CategoryID = CategoryID;
            context.AddToCWCars(sr);
            return sr;
        }

        public int Update(int ID, int? BrandID, int? ModelID, string Number, int? CategoryID)
        {
            int result = 1;
            CWCar sr = (from a in context.CWCars
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.ModelID = ModelID;
            sr.BrandID = BrandID;
            sr.Number = Number;
            sr.CategoryID = CategoryID;
            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            CWCar sr = (from a in context.CWCars
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.CWCars.DeleteObject(sr);

            return result;
        }

        
    }
}
