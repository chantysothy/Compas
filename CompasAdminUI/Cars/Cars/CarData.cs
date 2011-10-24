using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Compas.Model;
using Compas.Logic;
using Compas.Logic.Wares;
using System.Drawing.Imaging;

namespace Compas.AdminUI.Cars

{
    public partial class CarData : Form
    {
        string mode;        
        int? id;

        ContextManager manager;

        private void FillBrands()
        {

            CWCarBrandsLogic brands = new CWCarBrandsLogic(manager);
            BrandsDataGV.AutoGenerateColumns = false;
            BrandsDataGV.DataSource = brands.GetAll();
            BrandsDataGV.Update();

        }

        private void FillModels()
        {

            CWCarModelsLogic models = new CWCarModelsLogic(manager);
            ModelsDataGV.AutoGenerateColumns = false;
            int? brandId = null;
            if (BrandsDataGV.SelectedRows.Count > 0)
            {
                brandId = Convert.ToInt32(BrandsDataGV.CurrentRow.Cells["BrandID"].Value);
            }
            if (brandId != null)
                ModelsDataGV.DataSource = models.GetAll(Convert.ToInt32(brandId));
            else
                ModelsDataGV.DataSource = models.GetAll();
            ModelsDataGV.Update();

        }

        private void Fill()
        {
            CWCarsLogic cars = new CWCarsLogic(manager);
            CWCategoriesLogic categories = new CWCategoriesLogic(manager);

            CategoriesCB.DisplayMember = "Name";
            CategoriesCB.ValueMember = "ID";
            CategoriesCB.DataSource = categories.GetAll();

            FillBrands();
            

            if (mode == "edit")
            {
                CWCar car = cars.Get(Convert.ToInt32(id));
                if (car != null)
                {
                    foreach (object category in CategoriesCB.Items)
                    {
                        if (((CWCategory)category).ID == car.CategoryID)
                        {
                            CategoriesCB.SelectedItem = category;
                        }
                    }
                    
                }
            }
            
        }

        public CarData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;

            CWCarBrandsLogic carBrandsLogic = new CWCarBrandsLogic(manager);
            int i = 0;
                
            foreach (CWCarBrand brand in carBrandsLogic.GetAll())
            { 
                //BrandsICB.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(brand, i));
            }
          
            CWCarModelsLogic carModelsLogic = new CWCarModelsLogic(manager);
            //ModelsLUE.Properties.DataSource = carModelsLogic.GetAll();

            id = _id;
            Fill();
            if (mode == "edit")
            {
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            CWCarsLogic cars = new CWCarsLogic(manager);

            int? brandId = null;
            int? modelId = null;
            string number = "";



            number = NumberTB.Text;
            if (BrandsDataGV.CurrentRow != null)
                brandId = Convert.ToInt32(BrandsDataGV.CurrentRow.Cells["BrandID"].Value);
            if (ModelsDataGV.CurrentRow != null)
                modelId = Convert.ToInt32(ModelsDataGV.CurrentRow.Cells["ModelID"].Value);

            if (mode == "new")
            {
                cars.Create(brandId, modelId, number, Convert.ToInt32(CategoriesCB.SelectedValue));
            }
            if (mode == "edit")
            {
                cars.Update(Convert.ToInt32(id), brandId, modelId, number, Convert.ToInt32(CategoriesCB.SelectedValue));
            }
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

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BrandsDataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillModels();
        }

        private void BrandsDataGV_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void BrandsDataGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BrandsDataGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void AddBrandBt_Click(object sender, EventArgs e)
        {
            Cars.BrandData form = new BrandData("new", null);
            form.ShowDialog();
        }

        private void AddModelBt_Click(object sender, EventArgs e)
        {
            Cars.BrandsList form = new BrandsList();
            form.ShowDialog();
        }

        
    }
}
