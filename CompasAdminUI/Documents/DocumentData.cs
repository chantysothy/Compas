using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;
using Compas.Logic.Contractors;
using Compas.Logic.Documents;
using Compas.Logic.Staff;
using Compas.Logic.Security;
using Compas.Helpers;
using Compas.Logic.Config;
using Compas.CashRegisters;


using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Diagnostics;
using Compas.Helpers;

namespace Compas.AdminUI.Documents
{
    public partial class DocumentData : Form
    {
        string mode;
        bool startWareCode = false;
        bool endWareCode = false;
        string scanWareCode = "";

        int? id;
        ContextManager manager;
        WareDocument document;
        List<WareDocumentDetail> documentDetailsNew;
        List<WareDocumentDetail> documentDetailsOld;
        List<WareDocumentDetail> documentDetailsDeleted;
        List<WareDocumentDetail> documentDetailsView;
        List<DocumentDetailView> documentDetailsViewer;
        private decimal documentSum = 0;
        DocumentsLogic documentsLogic;
        DocumentDetailsLogic documentDetailsLogic;
        List<StaffEmployeeView> employeesDetailsView;
        private CashRegister cashRegister;
        private bool closeAfterPayment = true;
        int? modelId;
        int? brandId;
        int? categoryId;
        int? cardId;
        
       /// <summary>
       /// Чи закривати форму створення документу після завершення створення нового документу
       /// </summary>
        public bool CloseAfterPayment
        {
            get
            {
                return closeAfterPayment;
            }
            set
            {
                closeAfterPayment = value;
            }
        }

        /// <summary>
        /// методи запосвнення полів
        /// </summary>
        #region FillMethods

        /// <summary>
        /// Заповнення даних по картці клієнта
        /// </summary>
        private void FillCard()
        {
            string code = CodeTB.Text;
            CardsLogic cardsLogic = new CardsLogic(manager);
            WareCard card = cardsLogic.GetByCode(code);
            if (card == null)
            {
                MessageBox.Show("Картку не знайдено");
            }
            else
            {
                cardId = card.ID;
            }
        }

        /// <summary>
        /// Додавання позицій в документ по коду одиниці
        /// </summary>
        /// <param name="WareCode"></param>
        /// <returns></returns>
        private WareDocumentDetail AddDocumenDetailByWareCode(string WareCode)
        {
            DocumentDetailsLogic details = new DocumentDetailsLogic(manager);
            WareCodesLogic wareCodesLogic = new WareCodesLogic(manager);
            WareDocumentDetail result = null;
            Ware ware = wareCodesLogic.GetWareByCode(WareCode);
            if (ware != null)
            {
                int wareId = ware.ID;
                decimal unitQuantity = 1;
                decimal secondaryUnitQuantity = 0;
                decimal priceForUnit = 0;
                decimal discountForUnit = 0;
                decimal endSalePriceForUnit = 0;
                decimal endPrice = 0;
                
                int currencyId = Convert.ToInt32(CurrencyLUE.EditValue);
                int priceGroupID = 1;

                WareDocumentDetail DocumentDetail = new WareDocumentDetail();
                //створюємо новий запис в деталізації документа і повертаємо його
                DocumentDetail = details.CreateWithNoSave(wareId, unitQuantity, secondaryUnitQuantity,
                    priceForUnit, discountForUnit, endSalePriceForUnit, endPrice, currencyId, priceGroupID);
                documentDetailsView.Add(DocumentDetail);
                result = DocumentDetail;
                FillDetails();
            }
            else
            {
                MessageBox.Show("Товар з даним кодом не знайдено");
            }
            return result;


        }

        /// <summary>
        /// Заповнення переліку контрагентів
        /// </summary>
        private void InitContractorsLookUp()
        {
            ContractorsLogic contractors = new ContractorsLogic(manager);
            BindingSource bs = new BindingSource();
            bs.DataSource = contractors.GetAll();
            // Bind the edit value to the ProductID field of the "Order Details" table.
            // The edit value matches the value of the ValueMember field
            //ContractorLUE.DataBindings.Add("EditValue", bs, "ID");
            // Specify the data source to display in the dropdown.
            ContractorLUE.Properties.DataSource = bs;
            // The field providing the editor's display text.
            ContractorLUE.Properties.DisplayMember = "LastName";
            // The field matching the edit value.
            ContractorLUE.Properties.ValueMember = "ID";
            // Add two columns to the dropdown.
            LookUpColumnInfoCollection coll = ContractorLUE.Properties.Columns;
            // A column to display the ProductID field's values.
            coll.Add(new LookUpColumnInfo("ID", 0));
            // A column to display the ProductName field's values.
            coll.Add(new LookUpColumnInfo("LastName", 0, "Прізвище"));
            // A column to display the QuantityPerUnit field's values.
            coll.Add(new LookUpColumnInfo("FirstName", 0, "Ім'я"));
            coll.Add(new LookUpColumnInfo("MiddleName", 0, "По-батькові"));
            coll.Add(new LookUpColumnInfo("City", 0, "Місто"));
            // Set column widths according to their contents and resize the popup, if required.
            ContractorLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            // Enable auto completion search mode.
            ContractorLUE.Properties.SearchMode = SearchMode.AutoFilter;
            // Specify the column against which to perform the search.
            ContractorLUE.Properties.AutoSearchColumnIndex = 1;
            //ContractorCB.DataSource = contractors.GetAll();
            //ContractorCB.DisplayMember = "LastName";
            //ContractorCB.ValueMember = "ID";
            //ContractorCB.Update();
        }

        /// <summary>
        /// Заповнення даних по підприємствах
        /// </summary>
        private void FillEnterprises()
        {
            EnterprisesLogic enterprisesLogic = new EnterprisesLogic(manager);
            EnterprisesCB.DisplayMember = "Name";
            EnterprisesCB.ValueMember = "ID";
            EnterprisesCB.DataSource = enterprisesLogic.GetAll();
        }

        /// <summary>
        /// Заповнення валют
        /// </summary>
        private void FillCurrencies()
        {
            CurrenciesLogic currencies = new CurrenciesLogic(manager);
            CurrencyLUE.Properties.DataSource = currencies.GetAll();
            CurrencyLUE.Properties.ValueMember = "ID";
            CurrencyLUE.Properties.DisplayMember = "Name";
            CurrencyLUE.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 0, "Назва валюти"));
            CurrencyLUE.EditValue = currencies.GetDefault().ID;
        }

        /// <summary>
        /// заповнення можливих типів документів
        /// </summary>
        private void FillDocumentTypes()
        {
            DocumentTypesLogic types = new DocumentTypesLogic(manager);
            DocumentTypeLUE.Properties.DataSource = types.GetAll();
            DocumentTypeLUE.Properties.DisplayMember = "Name";
            DocumentTypeLUE.Properties.ValueMember = "ID";
            LookUpColumnInfoCollection coll = DocumentTypeLUE.Properties.Columns;
            coll.Add(new LookUpColumnInfo("Name", 0, "Назва"));
            DocumentTypeLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            DocumentTypeLUE.Properties.SearchMode = SearchMode.AutoFilter;
            DocumentTypeLUE.Properties.AutoSearchColumnIndex = 1;

           
        }

        /// <summary>
        /// Заповнюємо перелік вхідних об'єктів
        /// </summary>
        private void FillToObjects()
        {
            StaffStructureObjectsLogic objects = new StaffStructureObjectsLogic(manager);
            BindingList<StructureObjectView> objectsView = objects.GetHeirarchyView();

            //ToObjectCB.ValueMember = "ID";
            //ToObjectCB.DisplayMember = "Name";
            //FromObjectCB.ValueMember = "ID";
            //FromObjectCB.DisplayMember = "Name";
            //foreach (StructureObjectView ov in objectsView)
            //{
            //    ToObjectCB.Items.Add(ov);
            //    FromObjectCB.Items.Add(ov);
            //}

            ToObjectLUE.Properties.DataSource = objectsView;
            ToObjectLUE.Properties.DisplayMember = "Name";
            ToObjectLUE.Properties.ValueMember = "ID";
            LookUpColumnInfoCollection coll = ToObjectLUE.Properties.Columns;
            coll.Add(new LookUpColumnInfo("Name", 0, "Назва"));
            ToObjectLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //ToObjectLUE.Properties.SearchMode = SearchMode.AutoFilter;
            ToObjectLUE.Properties.AutoSearchColumnIndex = 1;

            FromObjectLUE.Properties.DataSource = objectsView;
            FromObjectLUE.Properties.DisplayMember = "Name";
            FromObjectLUE.Properties.ValueMember = "ID";
            LookUpColumnInfoCollection coll1 = FromObjectLUE.Properties.Columns;
            coll1.Add(new LookUpColumnInfo("Name", 0, "Назва"));
            FromObjectLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //FromObjectLUE.Properties.SearchMode = SearchMode.AutoFilter;
            FromObjectLUE.Properties.AutoSearchColumnIndex = 1;
        }

        /// <summary>
        /// Заповнюємо перелік вихідних об'єктів
        /// </summary>
        private void FillFromObjects()
        {
            //StaffStructureObjectsLogic objects = new StaffStructureObjectsLogic(manager);
            //FromObjectLUE.Properties.DataSource = objects.GetHeirarchyView();
            //FromObjectLUE.Properties.DisplayMember = "Name";
            //FromObjectLUE.Properties.ValueMember = "ID";
            //LookUpColumnInfoCollection coll = FromObjectLUE.Properties.Columns;
            //coll.Add(new LookUpColumnInfo("Name", 0, "Назва"));
            //FromObjectLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //FromObjectLUE.Properties.SearchMode = SearchMode.AutoFilter;
            //FromObjectLUE.Properties.AutoSearchColumnIndex = 1;
        }

        /// <summary>
        /// Заповнюємо перелік бригад
        /// </summary>
        private void FillTeams()
        {
            int structureObjectID = -1;
            if (FromObjectLUE.EditValue != null)
            {
                structureObjectID = Convert.ToInt32(FromObjectLUE.EditValue);
            }
            StaffTeamsLogic teamsLogic = new StaffTeamsLogic(manager);

            if (structureObjectID != -1)
                TeamsLUE.Properties.DataSource = teamsLogic.GetByStructureObject(structureObjectID);
            else
                TeamsLUE.Properties.DataSource = teamsLogic.GetAll();

            
            TeamsLUE.Properties.DisplayMember = "Name";
            TeamsLUE.Properties.ValueMember = "ID";
            LookUpColumnInfoCollection coll = TeamsLUE.Properties.Columns;
            coll.Add(new LookUpColumnInfo("Name", 0, "Назва"));
            TeamsLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            TeamsLUE.Properties.SearchMode = SearchMode.AutoFilter;
            TeamsLUE.Properties.AutoSearchColumnIndex = 1;
        }

        /// <summary>
        /// Заповнюємо перелік доступних працівників
        /// </summary>
        private void FillEmployees()
        {
            EmployeesLB.DisplayMember = "FullName";
            EmployeesLB.ValueMember = "ID";
            
            int teamId = -1;
            if (TeamsLUE.EditValue != null)
            {
                teamId = Convert.ToInt32(TeamsLUE.EditValue);
            }
            StaffEmployeeLogic employeesLogic = new StaffEmployeeLogic(manager);


            List<StaffEmployeeView> employeesAll = new List<StaffEmployeeView>();
            if (teamId != -1)
                employeesAll = employeesLogic.GetAllViewByTeamID((teamId)).OrderBy(a => a.FullName).ToList();
            else
                employeesAll = employeesLogic.GetAllView().OrderBy(a => a.FullName).ToList();

            EmployeesLUE.Properties.DataSource = (from a in employeesAll
                                                 where employeesDetailsView.Contains(a) == false
                                                 select a).ToList();
            
            EmployeesLUE.Properties.DisplayMember = "FullName";
            EmployeesLUE.Properties.ValueMember = "ID";
            LookUpColumnInfoCollection coll = EmployeesLUE.Properties.Columns;
            if(coll.Count == 0)
                coll.Add(new LookUpColumnInfo("FullName", 0, "Назва"));
            EmployeesLUE.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            EmployeesLUE.Properties.SearchMode = SearchMode.AutoFilter;
            EmployeesLUE.Properties.AutoSearchColumnIndex = 1;
            
        }

        /// <summary>
        /// Заповнюємо перелік присвоєних працівників
        /// </summary>
        private void FillEmployeeDetails()
        {
            EmployeesLB.DisplayMember = "FullName";
            EmployeesLB.ValueMember = "ID";

            int teamId = -1;
            if (TeamsLUE.EditValue != null)
            {
                teamId = Convert.ToInt32(TeamsLUE.EditValue);
            }
            StaffEmployeeLogic employeesLogic = new StaffEmployeeLogic(manager);


            List<StaffEmployeeView> employeesAll = new List<StaffEmployeeView>();
            
            //вибираємо присвоєних працівників
            DocumentStaffDetailsLogic staffDetailsLogic = new DocumentStaffDetailsLogic(manager);
            
            List<StaffEmployee> staffDetails = staffDetailsLogic.GetStaffEmployeesByDocumentID(Convert.ToInt32(id));
            if (staffDetails != null)
            {

                
                //перетворюємо для відображення
                List<StaffEmployeeView> employees = employeesLogic.ConvertListToListView(staffDetails);
                employeesDetailsView = employees;
                EmployeesLB.DataSource = employees;
            }

            EmployeesLB.ColumnWidth = EmployeesLB.Width;

        }

        /// <summary>
        /// Заповнюємо перелік позицій документу
        /// </summary>
        private void FillDetails()
        {
            CompasLogger.Add(String.Format("FillDetails1"), CompasLogger.Level.Info);
            int? selectedIndex = null;
            if (DetailsGV.SelectedRows.Count > 0)
            {
                selectedIndex = DetailsGV.SelectedRows[0].Index;
            }

            DocumentDetailsLogic detailsLogic = new DocumentDetailsLogic(manager);

            //documentDetailsView = documentDetailsNew;
            if (mode == "edit")
            {
                if (documentDetailsView.Count == 0)
                {
                    documentDetailsView = detailsLogic.GetAll(id);
                }

            }
            if ((mode == "new") & (documentDetailsView == null))
                documentDetailsView = new List<WareDocumentDetail>();

            if (selectedIndex != null)
                DetailsGV.Rows[Convert.ToInt32(selectedIndex)].Selected = true;

            CompasLogger.Add(String.Format("FillDetails2"), CompasLogger.Level.Info);
            //foreach (WareDocumentDetail a in documentDetailsNew)
            //{
            //    documentDetailsView.Add(a);
            //}
            //documentDetailsNew.Clear();

            //конвертуємо в список для перегляду і підраховуємо загальну суму документу
            //if (documentDetailsViewer == null)
            documentDetailsViewer = new List<DocumentDetailView>();
            documentSum = 0;
            decimal documentDuration = 0;
            WareTimeLimitsLogic timeLimitsLogic = new WareTimeLimitsLogic(manager);
            if (documentDetailsView.Count > 0)
            {
                foreach (WareDocumentDetail detail in documentDetailsView.OrderBy(a => a.ID))
                {
                    //if(documentDetailsViewer.Contains(
                    DocumentDetailView detailView = new DocumentDetailView(detail, manager);
                    
                    documentDetailsViewer.Add(detailView);
                    documentSum = documentSum + Convert.ToDecimal(detail.EndPrice);

                    WareTimeLimit timeLimit = timeLimitsLogic.GetByWareID(detail.WareID);
                    if (timeLimit != null)
                    {
                        documentDuration = documentDuration + timeLimit.TimeLimit;
                    }
                    
                }
            }

            CompasLogger.Add(String.Format("FillDetails3"), CompasLogger.Level.Info);
            DurationL.Text = documentDuration.ToString("n2");
            DocumentSumaL.Text = documentSum.ToString("n2");
            DetailsGV.AutoGenerateColumns = false;
            DetailsGV.DataSource = documentDetailsViewer;
            if (DetailsGV.Rows.Count == 0)
            {
                if(DetailsGV.SelectedRows.Count >0)
                    DetailsGV.SelectedRows[0].Selected = false;
            }
            //DetailsGV.Update();
            CompasLogger.Add(String.Format("FillDetails4"), CompasLogger.Level.Info);
        }

        /// <summary>
        /// Оплати по документу
        /// </summary>
        private void FillPayments()
        { 
            DocumentPaymentsLogic paymentsLogic = new DocumentPaymentsLogic(manager);
            if (id != null)
            {
                PaymentSumaL.Text = paymentsLogic.GetSumByDocumentID(Convert.ToInt32(id)).ToString("n2");
            }
        }

        /// <summary>
        /// Заповнення полів про прикріплену машину до документу
        /// </summary>
        private void FillCarInfo()
        {
            //CWContractorCarsLogic contractorCarsLogic = new CWContractorCarsLogic(manager);
            //List<CWContractorCar> contractorCars = contractorCarsLogic.GetAll(ContractorID);
            //CWContractorCar contractorCar = contractorCars.FirstOrDefault();
            if (id != null)
            {
                DocumentCarsLogic documentCars = new DocumentCarsLogic(manager);
                List<WareDocumentCar> cars = documentCars.GetByDocumentID(Convert.ToInt32(id));
                if (cars.Count > 0)
                {
                    CWCar car = cars.FirstOrDefault().CWCar;
                    CarNumberTE.Text = car.Number;
                    CarBrandNameL.Text = car.CWCarBrand.Name;
                    CarModelNameL.Text = car.CWCarModel.Name;
                    CarBrandPB.Image = Helpers.ImageOperations.ByteArrayToImage(car.CWCarBrand.Image);
                    CarModelPB.Image = Helpers.ImageOperations.ByteArrayToImage(car.CWCarModel.Image);
                }
            }
        }
        /// <summary>
        /// Заповнюємо поля відображення даних документу
        /// </summary>
        private void Fill()
        {

            CompasLogger.Add(String.Format("p21"), CompasLogger.Level.Info);
            InitContractorsLookUp();
            CompasLogger.Add(String.Format("p22"), CompasLogger.Level.Info);
            FillDocumentTypes();
            CompasLogger.Add(String.Format("p23"), CompasLogger.Level.Info);
            FillToObjects();
            CompasLogger.Add(String.Format("p24"), CompasLogger.Level.Info);
            //FillFromObjects();
            CompasLogger.Add(String.Format("p25"), CompasLogger.Level.Info);
            FillCurrencies();
            CompasLogger.Add(String.Format("p26"), CompasLogger.Level.Info);
            FillDetails();
            CompasLogger.Add(String.Format("p27"), CompasLogger.Level.Info);
            FillTeams();
            CompasLogger.Add(String.Format("p28"), CompasLogger.Level.Info);
            FillEmployees();
            CompasLogger.Add(String.Format("p29"), CompasLogger.Level.Info);
            FillCategories();
            FillCarInfo();
            FillEnterprises();
            if(mode == "new")
            {
                DateDE.EditValue = DateTime.Now;
                //CurrencyLUE.EditValue = CurrencyLUE.

            }

            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            ConfigurationParameter param0 = config.Get(ParametersLogic.Parameter.DOCUMENT_TYPE.ToString());
            if (param0 != null)
            {
                int value = Convert.ToInt32(param0.Value);
                DocumentTypeLUE.EditValue = value;
            }
            ConfigurationParameter param1 = config.Get(ParametersLogic.Parameter.DOCUMENT_TYPE_ENABLED.ToString());
            if (param1 != null)
            {
                DocumentTypeLUE.Enabled = false;
            }

            ConfigurationParameter param2 = config.Get(ParametersLogic.Parameter.DOCUMENT_CAR_DEFAULT_CATEGORY.ToString());
            if (param2 != null)
            {
                int value = Convert.ToInt32(param2.Value);
                foreach (object a in CarCategoriesCB.Items)
                {
                    if (((CWCategory)a).ID == value)
                    {
                        CarCategoriesCB.SelectedItem = a;
                    }
                }
            }

            ConfigurationParameter param3 = config.Get(ParametersLogic.Parameter.DOCUMENT_CAR_VISIBLE.ToString());
            if (param3 != null)
            {
                CarGB.Visible = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param3.Value);
            }

            ConfigurationParameter param4 = config.Get(ParametersLogic.Parameter.DOCUMENT_CURRENCY.ToString());
            if (param4 != null)
            {
                int value = Convert.ToInt32(param4.Value);
                CurrencyLUE.EditValue = value;
            }

            ConfigurationParameter param5 = config.Get(ParametersLogic.Parameter.DOCUMENT_CURRENCY_ENABLED.ToString());
            if (param5 != null)
            {
                CurrencyLUE.Enabled = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param5.Value);
            }

            ConfigurationParameter param6 = config.Get(ParametersLogic.Parameter.DOCUMENT_DATE_ENABLED.ToString());
            if (param6 != null)
            {
                DateDE.Enabled = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param6.Value);
            }

            ConfigurationParameter param7 = config.Get(ParametersLogic.Parameter.DOCUMENT_FROM_OBJECT.ToString());
            if (param7 != null)
            {
                int value = Convert.ToInt32(param7.Value);
                FromObjectLUE.EditValue = value;
            }

            ConfigurationParameter param8 = config.Get(ParametersLogic.Parameter.DOCUMENT_FROM_OBJECT_ENABLED.ToString());
            if (param8 != null)
            {
                FromObjectLUE.Enabled = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param8.Value);
            }

            ConfigurationParameter param9 = config.Get(ParametersLogic.Parameter.DOCUMENT_TO_OBJECT.ToString());
            if (param9 != null)
            {
                int value = Convert.ToInt32(param9.Value);
                ToObjectLUE.EditValue = value;
            }

            ConfigurationParameter param10 = config.Get(ParametersLogic.Parameter.DOCUMENT_TO_OBJECT_ENABLED.ToString());
            if (param10 != null)
            {
                ToObjectLUE.Enabled = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param10.Value);
            }

            ConfigurationParameter param11 = config.Get(ParametersLogic.Parameter.DOCUMENT_PARAMETERS_IN_DOCUMENTDATA_VISIBLE.ToString());
            if (param11 != null)
            {
                if (Helpers.ConfigDataTypeConverter.ConvertToBoolean(param11.Value) == false)
                {
                    splitContainerControl1.Panel1.Visible = Helpers.ConfigDataTypeConverter.ConvertToBoolean(param11.Value);
                    splitContainerControl1.Panel1.Width = 1;
                    splitContainerControl1.SplitterPosition = 0;
                }
            }

            if (mode == "edit")
            {
                if (document.DocumentTypeID != null)
                    DocumentTypeLUE.EditValue = document.DocumentTypeID;
                ContractorLUE.EditValue = document.ContractorID;
                
                NumberTE.Text = document.Number;
                if(document.Date != null)
                    DateDE.DateTime = Convert.ToDateTime(document.Date);
                if (document.FromStructureObjectID != null)
                    FromObjectLUE.EditValue = document.FromStructureObjectID;
                if (document.ToStructureObjectD != null)
                    ToObjectLUE.EditValue = document.ToStructureObjectD;
                if (document.CurrencyID != null)
                    CurrencyLUE.EditValue = document.CurrencyID;
                DescriptionTE.Text = document.Description;
                AddressTE.Text = document.Address;
                if(document.EnterpriseID != null)                
                    EnterprisesCB.SelectedValue = document.EnterpriseID;
            }        
            
        }

        /// <summary>
        /// заповнення категорій автомобілів
        /// </summary>
        public void FillCategories()
        {
            CWCategoriesLogic categories = new CWCategoriesLogic(manager);

            CarCategoriesCB.DisplayMember = "Name";
            CarCategoriesCB.ValueMember = "ID";

            CWCategory c0 = new CWCategory();
            c0.ID = -1;
            c0.Name = "-не обрано-";
            CarCategoriesCB.Items.Add(c0);
            foreach (CWCategory category in categories.GetAll())
            {
                CarCategoriesCB.Items.Add(category);
            }
        }

        public void FillCarInformation()
        { 
             
        }

        #endregion

        /// <summary>
        /// Конструктор форми створення і редагування документу
        /// </summary>
        /// <param name="_mode">режим - new або edit</param>
        /// <param name="_id">ыдентифыкатор документу для режиму редагування</param>
        /// <param name="_CashRegister">підключений принтер чеків(якщо немає то null)</param>
        public DocumentData(string _mode, int? _id, CashRegister _CashRegister)
        {
            
            InitializeComponent();
            cashRegister = _CashRegister;
            CompasLogger.Add(String.Format("Start opening doc form"), CompasLogger.Level.Info);
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            DetailsGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FillPayments();
            documentDetailsNew = new List<WareDocumentDetail>();
            documentDetailsOld = new List<WareDocumentDetail>();
            documentDetailsDeleted = new List<WareDocumentDetail>();
            employeesDetailsView = new List<StaffEmployeeView>();
            documentsLogic = new DocumentsLogic(manager);
            documentDetailsLogic = new DocumentDetailsLogic(manager);
            if (mode == "new")
            {
                //створюємо документ в памяті                
                document = documentsLogic.CreateEmpty();
            }

            if (mode == "edit")
            {
                //витягуємо документ в память               
                document = documentsLogic.Get(Convert.ToInt32(id));
                //витягуємо детальну інформацію по документу
                documentDetailsOld = documentDetailsLogic.GetAll(id);
                documentDetailsView = documentDetailsOld;
                FillEmployeeDetails();
                
            }
            CompasLogger.Add(String.Format("p1"), CompasLogger.Level.Info);
            Fill();
            
            CompasLogger.Add(String.Format("End opening doc form"), CompasLogger.Level.Info);
        }


        /// <summary>
        /// Збереження даних документу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() == true)
            {

                if (ContractorLUE.EditValue != null)
                    document.ContractorID = Convert.ToInt32(ContractorLUE.EditValue);
                if (CurrencyLUE.EditValue != null)
                    document.CurrencyID = Convert.ToInt32(CurrencyLUE.EditValue);
                if (DateDE.EditValue != null)
                    document.Date = Convert.ToDateTime(DateDE.EditValue);

                document.Description = DescriptionTE.Text;
                document.Address = AddressTE.Text;
                document.Number = NumberTE.Text;
                if (DocumentTypeLUE.EditValue != null)
                    document.DocumentTypeID = Convert.ToInt32(DocumentTypeLUE.EditValue);
                if (FromObjectLUE.EditValue != null)
                    document.FromStructureObjectID = Convert.ToInt32(FromObjectLUE.EditValue);
                if (ToObjectLUE.EditValue != null)
                    document.ToStructureObjectD = Convert.ToInt32(ToObjectLUE.EditValue);

                int enterpriseId = Convert.ToInt32(EnterprisesCB.SelectedValue);

                int? teamId = null;
                if (TeamsLUE.EditValue != null)
                    teamId = Convert.ToInt32(TeamsLUE.EditValue);

                //перезаписуємо дані працівників
                documentsLogic.DeleteDocumentEmployees(document, employeesDetailsView);            
                foreach (StaffEmployeeView item in employeesDetailsView)
                {

                    documentsLogic.SaveDocumentWithEmployees(document, item.Employee, teamId, mode);
                }

                if (cardId != null)
                    document.CardID = cardId;

                document.DocumentSum = documentSum;
                document.EnterpriseID = enterpriseId;
                if (mode == "new")
                {
                    document.CreatedDate = DateTime.Now;
                    document.CreatedUserID = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
                    int userId = Compas.Logic.Security.CurrentSecurityContext.Identity.ID;
                    Logic.Staff.StaffEmployeeLogic staffLogic = new Logic.Staff.StaffEmployeeLogic(manager);
                    StaffEmployee employee = staffLogic.GetByUserID(userId);
                    if (employee != null)
                        document.CreatedEmployeeID = employee.ID;

                    //foreach (WareDocumentDetail detail in documentDetailsNew)
                    //{
                    //    documentDetailsLogic.SaveDocumentDetail(detail);
                    //}
                    documentsLogic.SaveDocumentWithDetails(document, documentDetailsView, "new");

                }
                if (mode == "edit")
                {
                    documentDetailsLogic.DeleteAllForDocument(document.ID);
                    documentsLogic.SaveDocumentWithDetails(document, documentDetailsView, "edit");
                    //documentsLogic.
                }

                //якщо вказані дані про авто до перевіряємо чи дані вже існують
                string carNumber = CarNumberTE.Text;
                if (carNumber.Trim().Length > 0)
                {
                    CWCarsLogic carsLogic = new CWCarsLogic(manager);

                    CWCar car = null;
                    categoryId = null;
                    if (CarCategoriesCB.SelectedItem != null)
                    {
                        if (Convert.ToInt32(CarCategoriesCB.SelectedValue) > 0)
                            categoryId = Convert.ToInt32(CarCategoriesCB.SelectedValue);
                    }
                    List<CWCar> cars = carsLogic.GetAll(CarNumberTE.Text, modelId, brandId);
                    if (cars.Count > 0)
                    {
                        car = cars.FirstOrDefault();
                    }
                    else
                    {
                        car = carsLogic.Create(brandId, modelId, carNumber, categoryId);
                    }

                    if (ContractorLUE.EditValue != null)
                    {
                        CWContractorCarsLogic contractorCars = new CWContractorCarsLogic(manager);
                        contractorCars.Create(Convert.ToInt32(document.ContractorID), car);
                    }

                    DocumentCarsLogic documentCarsLogic = new DocumentCarsLogic(manager);
                    documentCarsLogic.Create(document, car);
                }
                
                
                //Зберігаємо зміни
                manager.Save();

                //Здійснюємо перерахунок залишків
                Compas.Logic.Wares.WareRemainsLogic remainsLogic = new Compas.Logic.Wares.WareRemainsLogic(manager);
                foreach (WareDocumentDetail detail in documentDetailsView)
                {
                    if (document.FromStructureObjectID != null)
                        remainsLogic.UpdateCurrentRemainByDocumentDetail(document.Date, detail.WareID, document.FromStructureObjectID, null);
                    if (document.ToStructureObjectD != null)
                        remainsLogic.UpdateCurrentRemainByDocumentDetail(document.Date, detail.WareID, document.ToStructureObjectD, null);
                }


                manager.Save();
                int documentId = document.ID;
                if (AddPaymentCB.Checked == true)
                {
                    DocumentPaymentData paymentForm = new DocumentPaymentData(documentId, document, cashRegister);
                    paymentForm.ShowDialog();
                }

                if (CloseAfterPayment == true)
                    this.Close();
                else
                {
                    //після збереження даного документу - позиції документа очищаються і форма готова для створення нового документа
                    CompasLogger.Add(String.Format("Start opening doc form"), CompasLogger.Level.Info);
                    manager = new ContextManager();
                   
                    DetailsGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    //FillPayments();
                    documentDetailsNew = new List<WareDocumentDetail>();
                    documentDetailsOld = new List<WareDocumentDetail>();
                    documentDetailsDeleted = new List<WareDocumentDetail>();
                    documentDetailsView = new List<WareDocumentDetail>();
                    employeesDetailsView = new List<StaffEmployeeView>();
                    documentsLogic = new DocumentsLogic(manager);
                    documentDetailsLogic = new DocumentDetailsLogic(manager);
                    if (mode == "new")
                    {
                        //створюємо документ в памяті                
                        document = documentsLogic.CreateEmpty();
                    }
                    documentDetailsViewer.Clear();                   
                    FillDetails();  
                }
            }
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocumentTypeLUE_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DocumentTypeLUE_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DocumentTypeLUE_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DocumentTypeLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void ContractorLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void ToObjectLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void FromObjectLUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (sender as LookUpEdit).EditValue = null;
            }
        }

        private void NewSB_Click(object sender, EventArgs e)
        {
            if (SimpleCB.Checked == true)
            {
                DocumentDetailsData form = new DocumentDetailsData("new", document, documentDetailsView, null);
                form.ShowDialog();
            }
            else
            {
                DocumentDetailsDataSimple form = new DocumentDetailsDataSimple("new", document, documentDetailsView, null);
                form.MaximizeBox = true;
                form.ShowDialog();
            }
            
            
            FillDetails();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            documentDetailsDeleted.Add(((DocumentDetailView)(DetailsGV.SelectedRows[0].DataBoundItem)).DetailObject);
            documentDetailsView.Remove(((DocumentDetailView)(DetailsGV.SelectedRows[0].DataBoundItem)).DetailObject);
            FillDetails();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {

            DocumentDetailsData form = new DocumentDetailsData("edit", document, documentDetailsView,
                    ((DocumentDetailView)(DetailsGV.SelectedRows[0].DataBoundItem)).DetailObject);
                form.ShowDialog();
                FillDetails();
           
            
        }

        private void RefreshSB_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void AbbContractorBt_Click(object sender, EventArgs e)
        {
            ContractorsUI.ContractorData form = new ContractorsUI.ContractorData("new", null);
            form.ShowDialog();
            InitContractorsLookUp();
        }

        private void AddObjectBt_Click(object sender, EventArgs e)
        {
            Staff.StructureObject.StructureObjectData form = new Staff.StructureObject.StructureObjectData("new", null);
            form.ShowDialog();
            FillToObjects();
        }

        private void AddObject2Bt_Click(object sender, EventArgs e)
        {
            Staff.StructureObject.StructureObjectData form = new Staff.StructureObject.StructureObjectData("new", null);
            form.ShowDialog();
            FillFromObjects();
        }

        private void ToObjectLUE_Properties_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ToObjectLUE_TextChanged(object sender, EventArgs e)
        {
            //if (ToObjectLUE.Text.Length == 0)
            //    ToObjectLUE.EditValue = null;
        }

        private void FromObjectLUE_EditValueChanged(object sender, EventArgs e)
        {
            FillTeams();
        }

        private void TeamsLUE_EditValueChanged(object sender, EventArgs e)
        {
            FillEmployees();
        }

        private void EmployeesLUE_EditValueChanged(object sender, EventArgs e)
        {
            if (EmployeesLUE.EditValue != null)
            {
                StaffEmployeeView item = (StaffEmployeeView)(EmployeesLUE.GetSelectedDataRow());
                employeesDetailsView.Add(item);
                FillEmployees();
                //foreach (StaffEmployeeView view in employeesDetailsView)
                //{
                //    EmployeesLB.DisplayMember = "FullName";
                //    EmployeesLB.Items.Add(view);
                //}
                EmployeesLB.DataSource = employeesDetailsView;
                EmployeesLUE.EditValue = null;
            }
        }

        private void RemoveEmployeeBt_Click(object sender, EventArgs e)
        {
            if (EmployeesLB.SelectedIndex >= 0)
            {
                StaffEmployeeView employeeForDelete = (from a in employeesDetailsView
                                                       where a.ID == ((StaffEmployeeView)(EmployeesLB.SelectedItem)).ID
                                                       select a).FirstOrDefault();
                if (employeeForDelete != null)
                {
                    employeesDetailsView.Remove(employeeForDelete);
                    //EmployeesLB.Items.RemoveAt(EmployeesLB.SelectedIndex);
                    EmployeesLB.DataSource = employeesDetailsView;

                    if (EmployeesLB.ItemCount > 0)
                        EmployeesLB.SelectedIndex = 0;
                }
            }
            EmployeesLB.Update();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }

        /// <summary>
        /// вказуємо модель автомобіля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetModelBt_Click(object sender, EventArgs e)
        {
            Cars.ChooseModel form = new Cars.ChooseModel();
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
            modelId = form.SelectedModelID;
            brandId = form.SelectedBrandId;


            if (modelId != null)
            {
                CWCarModelsLogic modelsLogic = new CWCarModelsLogic(manager);
                CWCarModel model = modelsLogic.Get(Convert.ToInt32(modelId));
                CarModelPB.Image = Helpers.ImageOperations.ByteArrayToImage(model.Image);
                CarModelNameL.Text = model.Name;

                foreach (object category in CarCategoriesCB.Items)
                {
                    if (((CWCategory)category).ID == model.CategoryID)
                    {
                        CarCategoriesCB.SelectedItem = category;
                    }
                }

                CarBrandNameL.Text = model.CWCarBrand.Name;
                CarBrandPB.Image = Helpers.ImageOperations.ByteArrayToImage(model.CWCarBrand.Image);
            }
            else
            {
                if (brandId != null)
                {
                    CWCarBrandsLogic brandsLogic = new CWCarBrandsLogic(manager);
                    CWCarBrand brand = brandsLogic.Get(Convert.ToInt32(modelId));
                    CarBrandPB.Image = Helpers.ImageOperations.ByteArrayToImage(brand.Image);
                    CarBrandNameL.Text = brand.Name;
                }
            }
        }

        private void CodeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                FillCard();
                
            }
        }

        private void DocumentData_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            

           

            
        }

        private void DocumentData_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F12)
            {
                e.Handled = true;
                startWareCode = true;
                endWareCode = false;
                WareCodeTB.Focus();
                scanWareCode = "";
            }
            else
            {
                if ((e.KeyCode != Keys.Enter) & (startWareCode == true) & (endWareCode == false))
                {
                    e.Handled = true;
                    scanWareCode = scanWareCode + (char)(e.KeyValue);
                }
            }
            if ((e.KeyCode == Keys.Enter) & (startWareCode == true) & (endWareCode == false))
            {
                e.Handled = true;
                startWareCode = false;
                endWareCode = false;
                //MessageBox.Show(scanWareCode);
                WareDocumentDetail detail = AddDocumenDetailByWareCode(scanWareCode);
                if (ExtendedNewDetailViewCB.Checked == true & detail != null)
                {
                    DocumentDetailsData form = new DocumentDetailsData("edit", document, documentDetailsView, detail);
                    form.ShowDialog();
                   

                    FillDetails();
                }
                
                
            }

            if (e.KeyCode == Keys.F4)
            {
                //Нова НО
                AdminUI.Wares.Ware.WareData form = new Wares.Ware.WareData("new", null, null);
                form.ShowDialog();
            }
        }

       
    }
}
