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
    public partial class ChooseModel : Form
    {
        string mode;        
        int? id;
        int? brandId = null;
        int? modelId = null;

        public int? SelectedModelID
        {
            get
            {
                return modelId;
            }
        }

        public int? SelectedBrandId
        {
            get
            {
                return brandId;
            }
        }

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

           

            FillBrands();
            

           
            
        }

        public ChooseModel()
        {
            
            InitializeComponent();
            manager = new ContextManager();
                      
            int i = 0;

            
            Fill();
            if (mode == "edit")
            {
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            CWCarsLogic cars = new CWCarsLogic(manager);

           
            string number = "";



            
            if (BrandsDataGV.CurrentRow != null)
                brandId = Convert.ToInt32(BrandsDataGV.CurrentRow.Cells["BrandID"].Value);
            if (ModelsDataGV.CurrentRow != null)
                modelId = Convert.ToInt32(ModelsDataGV.CurrentRow.Cells["ModelID"].Value);

            

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
