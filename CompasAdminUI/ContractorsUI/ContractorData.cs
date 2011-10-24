using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic;
using Compas.Logic.Contractors;

namespace Compas.AdminUI.ContractorsUI
{
    public partial class ContractorData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            ContractorsLogic cl = new ContractorsLogic(manager);
            ContractorTypesLogic types = new ContractorTypesLogic(manager);
            
            ContractorTypesCBE.Properties.ValueMember = "ID";
            ContractorTypesCBE.Properties.DisplayMember = "Name";
            
            foreach (var a in types.GetAll())
            {
                ContractorTypesCBE.Properties.Items.Add(a.ID, a.Name, CheckState.Unchecked, true);
            }

            if (mode == "edit")
            {

                Contractor contractor = cl.Get(Convert.ToInt32(id));
                if (contractor != null)
                {
                    PrefixNameTE.Text = contractor.PrefixName;
                    LastNameTE.Text = contractor.LastName;
                    FirstNameTE.Text = contractor.FirstName;
                    MiddleNameE.Text = contractor.MiddleName;
                   
                    CountryTE.Text = contractor.Country;
                    RegionTE.Text = contractor.Region;
                    DistrictTE.Text = contractor.District;
                    CityTE.Text = contractor.City;
                    StreetTE.Text = contractor.Street;
                    BuildingTE.Text = contractor.Building;
                    FlatTE.Text = contractor.Flat;
                    PhoneTE.Text = contractor.Phone;
                    MobPhoneTE.Text = contractor.MobilePhone;
                    EmailTE.Text = contractor.EMail;
                    SiteTE.Text = contractor.Site;

                    if (contractor.Birthdate != null)
                        BirthDateTE.DateTime = Convert.ToDateTime(contractor.Birthdate);

                    if (contractor.Sex != null)
                    {
                        if (contractor.Sex == true)
                            SexRG.SelectedIndex = 0;
                        if (contractor.Sex == false)
                            SexRG.SelectedIndex = 1;
                    }

                    if (contractor.Person != null)
                    {
                        if (contractor.Person == true)
                            PersonRG.SelectedIndex = 1;
                        if (contractor.Person == false)
                            PersonRG.SelectedIndex = 0;
                    }

                    List<ContractorContractorType> checkedTypes = cl.GetContractorTypesForContractor(contractor.ID);
                    
                    foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem i in ContractorTypesCBE.Properties.Items)
                    {
                        foreach(var a in checkedTypes)
                        {
                            if(a.ContractorTypeID == Convert.ToInt32(i.Value))
                            {
                                i.CheckState = CheckState.Checked;
                            }
                        }
                        
                    }

                    //вибираємо картки по клієнту
                    DataGV.AutoGenerateColumns = false;
                    DataGV.DataSource = cl.GetCards(contractor.ID);
                    DataGV.Update();

                }
                
            }
            
        }

        public ContractorData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            Fill();
            if (mode == "new")
            {
                PersonRG.SelectedIndex = 0;
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            ContractorsLogic cl = new ContractorsLogic(manager);
            string lastName = LastNameTE.Text;
            string firstName = FirstNameTE.Text;
            if (FirstNameTE.Enabled == false)
                firstName = "";

            string middleName = MiddleNameE.Text;
            if (MiddleNameE.Enabled == false)
                middleName = "";
            
            string country = CountryTE.Text;
            string region = RegionTE.Text;
            string district = DistrictTE.Text;
            string city = CityTE.Text;
            string street = StreetTE.Text;
            string building = BuildingTE.Text;
            string flat = FlatTE.Text;
            string phone = PhoneTE.Text;
            string mobilePhone = MobPhoneTE.Text;
            string email = EmailTE.Text;
            string site = SiteTE.Text;
            string prefixName = PrefixNameTE.Text;

            DateTime? birthDate = null;
            if (BirthDateTE.Text.Length > 0)
                birthDate = BirthDateTE.DateTime;
            bool? sex = null;
            if (SexRG.SelectedIndex == 0)
                //чоловік
                sex = true;
            if (SexRG.SelectedIndex == 1)
                //жінка
                sex = false;
            bool? person = null;
            switch (PersonRG.SelectedIndex)
            {
                case 0:
                    {
                        person = false; //фізична особа
                        break;
                    }
                case 1:
                    {
                        person = true; //фізична особа 
                        break;
                    }            
            }
            string newCardCode = CardCodeTB.Text.Trim();
            
            //List<DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit> checkedItems;
            //checkedItems = (List<DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit>)ContractorTypesCBE.Properties.GetCheckedItems();
            //List<ContractorType> selectedTypes = (List<ContractorType>)ContractorTypesCBE.Properties.GetCheckedItems();

            List<int> selectedTypes = new List<int>();
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem i in ContractorTypesCBE.Properties.Items)
            {
                if (i.CheckState == CheckState.Checked)
                {
                    selectedTypes.Add(Convert.ToInt32(i.Value));
                }
            }
            Contractor contractor = new Contractor();
            if (mode == "new")
            {
                contractor = cl.Create(prefixName, lastName, firstName, middleName, 
                    country, region, district, city, street, building, flat, phone,
                    mobilePhone, email, site, birthDate, sex, person, selectedTypes);                
                
            }
            if (mode == "edit")
            {
                contractor = cl.Update(Convert.ToInt32(id), prefixName, lastName, firstName, middleName, 
                   country, region, district, city, street, building, flat, phone,
                   mobilePhone, email, site, birthDate, sex, person, selectedTypes);
            }

            cl.AddCard(contractor, newCardCode);
            manager.Save();          

            this.Close();
        }

        private void EnterpriseData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void PersonRG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonRG.SelectedIndex == 0)
            { 
                //фізичні особи
                LastNameLC.Text = "Прізвище:";
                FirstNameLC.Text = "Ім'я";
                MiddleNameLC.Text = "По-батькові";
                FirstNameLC.Enabled = true;
                FirstNameTE.Enabled = true;
                MiddleNameLC.Enabled = true;
                MiddleNameE.Enabled = true;
                PrefixNameLC.Enabled = false;
                PrefixNameTE.Enabled = false;
            }

            if (PersonRG.SelectedIndex == 1)
            {
                //юридичні особи
                LastNameLC.Text = "  Назва:";
                FirstNameLC.Enabled = false;
                FirstNameTE.Enabled = false;
                MiddleNameLC.Enabled = false;
                MiddleNameE.Enabled = false;
                PrefixNameLC.Enabled = true;
                PrefixNameTE.Enabled = true;
            }
        }
    }
}
