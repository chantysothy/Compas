using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Compas.Model;
using Compas.Logic.Documents;
using Compas.Logic.Staff;


namespace Compas.Logic.Wares

{

    public class RemainView
    {
        WareRemain remain;
        public RemainView(WareRemain Remain)
        {
            remain = Remain;
        }

        public int ID
        {
            get
            {
                return remain.ID;
            }
        }

        public string StructureObjectName
        {
            get
            {
                return remain.StaffStructureObject == null ? "" : remain.StaffStructureObject.Name;
            }
        }

        public string WareName
        {
            get
            {
                return remain.Ware == null ? "" : remain.Ware.Name;
            }
        }

        public decimal UnitQuantity
        {
            get
            {
                return remain.UnitQuantity;
            }
        }

        public string UnitName
        {
            get
            {
                return remain.Ware.WareUnit.Name;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return remain.StartDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return remain.EndDate;
            }
        }
    }
    /// <summary>
    /// Упавління залишками НО 
    /// </summary>
    public class WareRemainsLogic : IGenericInterface<WareRemain>
    {
        public enum Direction
        {
            Input,
            Output
        }
        private CompasDataContext context;
        private ContextManager manager;

        public WareRemainsLogic(ContextManager contextManager)
        {
            context = contextManager.Context;
            manager = contextManager;
        }

        public WareRemain Get(int ID)
        {
            WareRemain result;

            result = (from a in context.WareRemains
                         where a.ID == ID
                         select a).FirstOrDefault();
            
           
            return result;
        }

        public decimal GetQuantityByWare(int StructureObjectID, int WareID, DateTime StartDate, DateTime EndDate, Direction WareMoveDirection)
        {
            decimal result = 0;

            IEnumerable<WareDocumentDetail> details = (from a in context.WareDocumentDetails
                                                       where
                                                       a.WareID == WareID & a.WareDocument.Date >= StartDate
                                                       & a.WareDocument.Date <= EndDate
                                                       & (
                                                          ((WareMoveDirection == Direction.Input) & (a.WareDocument.ToStructureObjectD == StructureObjectID))//прихід
                                                       || ((WareMoveDirection == Direction.Output) & (a.WareDocument.FromStructureObjectID == StructureObjectID))) //розхід
                                                       select a);
            if (details.Count() > 0)
                result = result + details.Sum(a => a.UnitQuantity);


            return result;
        }

        public decimal GetQuantityByWare(int StructureObjectID, int WareID, DateTime StartDate, DateTime EndDate)
        {
            decimal result = 0;


            decimal quantityInput = 0;
            decimal quantityOutput = 0;

            quantityInput = this.GetQuantityByWare(StructureObjectID, WareID, StartDate, EndDate, Direction.Input);
            quantityOutput = this.GetQuantityByWare(StructureObjectID, WareID, StartDate, EndDate, Direction.Output);

            result = quantityInput - quantityOutput;




            return result;
        }

        public decimal GetCurrentRemainOnWare(int WareID, DateTime Date)
        {
            decimal result = 0;
            WareRemain remain;

            remain = (from a in context.WareRemains
                      where a.WareID == WareID & 
                      a.StartDate <= Date & a.EndDate >= Date
                     
                      select a).FirstOrDefault();
            if (remain != null)
            {
                result = remain.UnitQuantity;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        public WareRemain GetLastRemainOnWare(int StructureObjectID, int WareID)
        {
           
            WareRemain remain;

            remain = (from a in context.WareRemains
                      where a.WareID == WareID & a.StructureObjectID == StructureObjectID                      
                      orderby a.StartDate descending
                      select a).FirstOrDefault();


            return remain;
        }

        public List<WareRemain> GetAll()
        {
           
            List<WareRemain> remains = (from a in context.WareRemains                          
                          select a).ToList();


            return remains;
        }

        public List<RemainView> GetAllView()
        {
            List<RemainView> result = new List<RemainView>();
            //using (var cdc = new CompasDataContext())
            //{
            List<WareRemain> remains = (from a in context.WareRemains
                                        select a).ToList();
            foreach (WareRemain a in remains)
            {
                result.Add(new RemainView(a));
            }
            //}
            return result;
        }

        public List<RemainView> GetAllView(int? StructureObjectID, int? WareID, DateTime? StartDate, DateTime? EndDate, int? WareCategoryID)
        {
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            List<int> structureObjects = new List<int>();

            if (StructureObjectID != null)
            {

                structureObjects = structureObjectsLogic.GetByParentStructureObjectID(Convert.ToInt32(StructureObjectID)).Select(a => a.ID).ToList();
                structureObjects.Add(Convert.ToInt32(StructureObjectID));
            }
            List<RemainView> result = new List<RemainView>();
            //вибираємо всі залишки за вказаними критеріями
            List<WareRemain> remains = (from a in context.WareRemains
                                        where ((StartDate == null) || (a.StartDate >= StartDate)) &
                                        ((EndDate == null) || (a.StartDate <= EndDate)) &
                                        ((WareID == null) || (a.WareID == WareID)) &
                                        ((StructureObjectID == null) || (structureObjects.Contains(a.StructureObjectID))) &
                                        ((WareCategoryID == null) || (a.Ware.CategoryID == WareCategoryID))


                                        select a).ToList();
            foreach (WareRemain a in remains)
            {
                result.Add(new RemainView(a));
            }
            //}
            return result;


        }




        public WareRemain Create(int StructureObjectID, int WareID, decimal UnitQuantity, DateTime StartDate, DateTime EndDate)
        {
            
            WareRemain sr = WareRemain.CreateWareRemain(1, StructureObjectID, WareID, UnitQuantity, StartDate, EndDate);
            
            context.AddToWareRemains(sr);
            return sr;
        }


        

        public int Update(int ID, int StructureObjectID, int WareID, int UnitQuantity, DateTime StartDate, DateTime EndDate)
        {
            int result = 1;
            WareRemain sr = (from a in context.WareRemains
                               where a.ID == ID
                               select a).FirstOrDefault();
            sr.StructureObjectID = StructureObjectID;
            sr.WareID = WareID;
            sr.UnitQuantity = UnitQuantity;
            sr.StartDate = StartDate;
            sr.EndDate = EndDate;            
                      
            return result;
        }

        /// <summary>
        /// НЕ ВИКОРИСТОВУВАТИ(ПРАЦЮЄ ЛИШЕ ПО ОСНОВНИМ ОДИНИЦЯМ)
        /// </summary>
        /// <param name="ID"></param>
        public void Recalculate(int ID)
        {
            WareRemain remain = this.Get(ID);
            
           
            this.UpdateCurrentRemainByDocumentDetail(remain.StartDate, remain.WareID, remain.StructureObjectID, null);
        }

        public void Recalculate(DateTime StartDate)
        {
            DocumentsLogic documents = new DocumentsLogic(manager);
            DocumentDetailsLogic detailsLogic = new DocumentDetailsLogic(manager);
            List<WareDocumentDetail> details = detailsLogic.GetAll(StartDate);

            foreach (WareDocumentDetail detail in details)
            {
                if(detail.WareDocument.FromStructureObjectID != null)
                    this.UpdateCurrentRemainByDocumentDetail(StartDate, detail.WareID, detail.WareDocument.FromStructureObjectID, null);
                if (detail.WareDocument.ToStructureObjectD != null)
                    this.UpdateCurrentRemainByDocumentDetail(StartDate, detail.WareID, detail.WareDocument.ToStructureObjectD, null);
            }


            
        } 



        
        
        /// <summary>
        /// Метод здійснює управління залишками
        /// 1. Спочатку шукаємо чи для даної одиниці у вказаний момент часу існує період, 
        /// Якщо період існує то працюємо з ним, якщо ні - створюємо новий        
        /// 2. Шукаємо період, що передує поточному
        /// Якщо попередній період знайдено - то дані в поточному періоді формуються на основі даних знайденого(інкрементально)
        /// 3. Залишок = Залишок попереднього періоду + Прихід - Розхід
        /// </summary>
        /// <param name="DocumentDetail"></param>
        /// <returns></returns>


        public int UpdateCurrentRemainByDocumentDetail(DateTime? StartPeriodDate, int? WareID, int? StructureObjectID, decimal? unitQuantity)
        {
            int result = 1;
           

            //визначаємо дату для якої необхідно зробити перерахунок
            DateTime Date = DateTime.Now;
            //if (DocumentDetail != null)
            //    Date = Convert.ToDateTime(DocumentDetail.WareDocument.Date);
            if (StartPeriodDate != null)
                Date = Convert.ToDateTime(StartPeriodDate);
            
            //задаємо дані періоду
            DateTime StartDate = new DateTime(Date.Year, Date.Month, Date.Day, 0, 0, 0);
            DateTime EndDate = new DateTime(Date.Year, Date.Month, Date.Day, 23, 59, 59);

             //визначаємо перелік складових номенклатурної одиниці, для яких необхідно зробити перерахунок
            //обробка вкладених компонентів
            WareComponentsLogic componentsLogic = new WareComponentsLogic(manager);
            List<WareComponent> components = componentsLogic.GetAll(Convert.ToInt32(WareID));
            foreach (WareComponent component in components)
            {
                this.UpdateCurrentRemainByDocumentDetail(StartDate, component.ComponentWareID, StructureObjectID, component.UnitQuantity);
            }
            //кінець обробки вкладених компонентів


            Compas.Logic.Documents.DocumentsLogic documentsLogic = new Compas.Logic.Documents.DocumentsLogic(manager);
            Compas.Logic.Documents.DocumentDetailsLogic detailsLogic = new Compas.Logic.Documents.DocumentDetailsLogic(manager);

            

            WareRemain output = null;
            WareRemain input = null;

            //спочатку шукаємо попередній запис, що не попадає в поточний період
            WareRemain lastRemain = (from a in context.WareRemains
                                     where a.EndDate < Date
                                            & a.WareID == WareID
                                            & a.StructureObjectID == StructureObjectID
                                     orderby a.StartDate descending
                                     select a).FirstOrDefault();
            //якщо не знайдено но створюємо новий починаючи з 0
            decimal lastRemainQuantity = 0;
            if (lastRemain != null)
                lastRemainQuantity = lastRemain.UnitQuantity;


            //шукаємо поточний залишок
            List<WareRemain> remains = (from a in context.WareRemains
                      where a.StartDate == StartDate
                             & a.WareID == WareID
                             & a.StructureObjectID == StructureObjectID
                      select a).ToList();
            if (remains.Count() == 0)
            {
                //якщо поточного залишка не знайдено, то створюємо
                remains.Add(this.Create(Convert.ToInt32(StructureObjectID), Convert.ToInt32(WareID), lastRemainQuantity, StartDate, Convert.ToDateTime(EndDate)));  
            }

            //проходимось по всім залишкам після вказаної дати
            List<WareRemain> remainsAfter = (from a in context.WareRemains
                                        where a.StartDate > StartDate
                                               & a.WareID == WareID
                                               & a.StructureObjectID == StructureObjectID
                                        select a).ToList();
            remains.AddRange(remainsAfter);

            

            foreach (WareRemain remain in remains.OrderBy(a => a.StartDate))
            {
                //прихід у вказаному періоді
                decimal inputQuantity = 0;
                //розхід у вказаному періоді
                decimal outputQuantity = 0;

                //основна одиниця
                if (unitQuantity == null)
                {
                    
                    //в межах кожного періоду проходимось по всім записам, що містять номенклатурну одиницю
                    List<WareDocumentDetail> details = detailsLogic.GetAll(remain.StartDate, remain.EndDate, Convert.ToInt32(WareID));

                    foreach (WareDocumentDetail detail in details)
                    {
                        if (detail.WareDocument != null)
                        {
                            if (detail.WareDocument.WareDocumentType.Input == true)
                            {
                                //прихід
                                inputQuantity = inputQuantity + detail.UnitQuantity;
                            }
                            if (detail.WareDocument.WareDocumentType.Output == true)
                            {
                                //розхід
                                outputQuantity = outputQuantity + detail.UnitQuantity;
                            }
                        }
                    }
                }
                //компонент
                if (unitQuantity != null)
                {
                    //якщо одиниця багатокомпонента, то компоненти завжди списуються в розхід                    
                    outputQuantity = outputQuantity + Convert.ToDecimal(unitQuantity);
                }

                remain.UnitQuantity = lastRemainQuantity + inputQuantity - outputQuantity;
                lastRemainQuantity = remain.UnitQuantity;
            }



            


            return result;
        }

        public int Delete(int ID)
        {
            int result = 1;
            WareRemain sr = (from a in context.WareRemains
                               where a.ID == ID
                               select a).FirstOrDefault();
            if (sr != null)
                context.WareRemains.DeleteObject(sr);

            return result;
        }

        
    }
}
