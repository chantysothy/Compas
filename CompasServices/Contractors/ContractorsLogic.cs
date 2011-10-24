using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;

namespace Compas.Logic.Contractors
{



    public class ContractorView:Contractor
    {
       
        private ContextManager manager;
        private string contractorTypesList;
        private List<ContractorType> contractorTypesObjectsList;

        public ContractorView(Contractor contractor, ContextManager Manager)
        {
            manager = Manager;
            this.LastName = contractor.LastName;
            this.FirstName = contractor.FirstName;
            this.MiddleName = contractor.MiddleName;
            this.Country = contractor.Country;
            this.Region = contractor.Region;
            this.District = contractor.District;
            this.City = contractor.City;
            this.Street = contractor.Street;
            this.Building = contractor.Building;
            this.Flat = contractor.Flat;
            this.ID = contractor.ID;
            this.Phone = contractor.Phone;
            this.MobilePhone = contractor.MobilePhone;

            this.EMail = contractor.EMail;
            this.Site = contractor.Site;
            this.Birthdate = contractor.Birthdate;
            this.Sex = contractor.Sex;
            this.Person = contractor.Person;

            ContractorsLogic cl = new ContractorsLogic(manager);
           
            contractorTypesObjectsList = new List<ContractorType>();
            foreach (var a in cl.GetContractorTypesForContractor(this.ID))
            {
                this.contractorTypesList = this.contractorTypesList + a.ContractorType.Name + "; ";
                this.contractorTypesObjectsList.Add(a.ContractorType);
            }


        }

        public string FullAddress
        {
            get
            {
                return (this.Country.Length > 0 ? this.Country + ", " : "") +
                    (this.Region.Length > 0 ? this.Region + ", " : "") +
                    (this.District.Length > 0 ? this.District + ", " : "") +
                    (this.City.Length > 0 ? this.City + ", " : "") +
                    (this.Street.Length > 0 ? this.Street + ", " : "") +
                    (this.Building.Length > 0 ? this.Building + " " : "") +
                    (this.Flat.Length > 0 ? this.Flat + " " : "");
            }
        }
        public string FullName
        { get { return this.LastName + " " + this.FirstName + " " + this.MiddleName; } 
         }
        public string Phones
        {
            get 
            {
                return (this.Phone.Length > 0 ? "Тел: " + this.Phone + " " : "") +
                    (this.MobilePhone.Length > 0 ? " Моб: " + this.MobilePhone + " " : "");
            }
        }
        public string SexValue
        {
            get 
            {
                string result = "";
                if (this.Sex != null)
                {
                    result = this.Sex == true ? "ч." : "ж.";
                }
                return result;
            }
        }
        public string PersonStringValue
        {
            get
            {
                string result = "";
                if (this.Person != null)
                {
                    switch (this.Person)
                    {
                        case true: result = "Юридична";
                            break;
                        case false: result = "Фізична";
                            break;
                    }
                }
                return result;
            }
        }

        public string ContractorTypesList
        {
            get
            {
                return contractorTypesList;
            }
        }
        public List<ContractorType> ContractorTypesObjectsList
        {
            get
            {
                return contractorTypesObjectsList;
            }
        }
    }

    /// <summary>
    /// Упавління довідником контрагентів
    /// </summary>
    public class ContractorsLogic : IGenericInterface<Contractor>
    {

        private CompasDataContext context;
        private ContextManager manager;

        public ContractorsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public Contractor Get(int ID)
        {
            Contractor result;

            result = (from a in context.Contractors
                      where a.ID == ID
                      select a).FirstOrDefault();


            return result;
        }

        public List<Contractor> GetAll()
        {
            List<Contractor> result;

            result = (from a in context.Contractors
                      select a).ToList().OrderBy(a => a.LastName).ThenBy(a=> a.FirstName).ThenBy(a=> a.MiddleName).ToList();
            
            return result;
        }




        public Contractor Create(string PrefixName, string LastName, string FirstName, string MiddleName, 
            string Country, string Region, string District, string City, string Street, string Building, string Flat,
            string Phone, string MobilePhone, string Email, string Site, DateTime? Birthdate, bool? Sex, bool? Person,
            List<int> ContractorTypes)
        {
           
            Contractor sr = Contractor.CreateContractor(1, LastName);
            sr.FirstName = FirstName;
            sr.MiddleName = MiddleName;
            sr.Country = Country;
            sr.City = City;
            sr.Region = Region;
            sr.District = District;
            sr.Street = Street;
            sr.Building = Building;
            sr.Flat = Flat;
            sr.Phone = Phone;
            sr.MobilePhone = MobilePhone;
            sr.EMail = Email;
            sr.Site = Site;
            sr.Birthdate = Birthdate;
            sr.Sex = Sex;
            sr.Person = Person;
            sr.PrefixName = PrefixName;
            context.AddToContractors(sr);


            foreach (int a in ContractorTypes)
            {
                ContractorContractorType ct = new ContractorContractorType();
                ct.ContractorTypeID = a;
                sr.ContractorContractorTypes.Add(ct);
            }

            return sr;
        }

        public Contractor Update(int ID, string PrefixName, string LastName, string FirstName, string MiddleName,
            string Country, string Region, string District, string City, string Street, string Building, string Flat,
            string Phone, string MobilePhone, string Email, string Site, DateTime? Birthdate, bool? Sex, bool? Person,
            List<int> ContractorTypes)
        {
            
            Contractor sr = (from a in context.Contractors
                           where a.ID == ID
                           select a).FirstOrDefault();
            sr.LastName = LastName;
            
            

            sr.FirstName = FirstName;
            sr.MiddleName = MiddleName;
            sr.Country = Country;
            sr.District = District;
            sr.Region = Region;
            sr.City = City;
            sr.Street = Street;
            sr.Building = Building;
            sr.Flat = Flat;
            sr.Phone = Phone;
            sr.MobilePhone = MobilePhone;
            sr.EMail = Email;
            sr.Site = Site;
            sr.Birthdate = Birthdate;
            sr.Sex = Sex;
            sr.Person = Person;
            sr.PrefixName = PrefixName;

            foreach (int i in ContractorTypes)
            {
                var check = (from a in context.ContractorContractorTypes
                             where a.ContractorID == ID & a.ContractorTypeID == i
                             select a).FirstOrDefault();
                //видаляємо невідмічені
                IEnumerable<ContractorContractorType> forDelete = from a in context.ContractorContractorTypes
                             where a.ContractorID == ID & ContractorTypes.Contains(a.ContractorTypeID) == false
                             select a;
                foreach (ContractorContractorType t in forDelete)
                {
                    context.ContractorContractorTypes.DeleteObject(t);
                }

                if (check == null)
                {
                    ContractorContractorType ct = new ContractorContractorType();
                    ct.ContractorTypeID = i;
                    sr.ContractorContractorTypes.Add(ct);
                }
            }

            return sr;
        }


        public List<ContractorContractorType> GetContractorTypesForContractor(int ContractorID)
        {
            return (from a in context.ContractorContractorTypes
                   where a.ContractorID == ContractorID
                   select a).ToList();
        }

        public int Delete(int ID)
        {
            int result = 1;
            Contractor sr = (from a in context.Contractors
                           where a.ID == ID
                           select a).FirstOrDefault();
            if (sr != null)
                context.Contractors.DeleteObject(sr);

            return result;
        }


        public void AddCard(Contractor _Contractor, string CardCode)
        {
            CardsLogic cardsLogic = new CardsLogic(manager);
            WareCard card = cardsLogic.GetByCode(CardCode);
            if (card != null)
            {
                ContractorCard contractorCard = new ContractorCard();
                contractorCard.CardID = card.ID;
                _Contractor.ContractorCards.Add(contractorCard);
                context.AddToContractorCards(contractorCard);

            }
        }

        public List<ViewContractorCard> GetCards(int ContractorID)
        {
            List<ViewContractorCard> cards = (from a in context.ViewContractorCards
                                    where a.ContractorID == ContractorID
                                    select a).ToList();
            return cards;
        }

        public ViewContractorCard GetCard(int CardID)
        {
            ViewContractorCard cards = (from a in context.ViewContractorCards
                                        where a.ID == CardID
                                        select a).FirstOrDefault();
            return cards;
        }

    }
}
