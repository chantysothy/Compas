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


namespace Compas.AdminUI.Cars
{
    public partial class ModelData : Form
    {
        string mode;
        
        int? id;
        int? brandId;
        byte[] image;
        Image _image;
        

        ContextManager manager;
        private void Fill()
        {
            CWCarModelsLogic models = new CWCarModelsLogic(manager);
            CWCategoriesLogic categories = new CWCategoriesLogic(manager);

            CategoriesCB.DisplayMember = "Name";
            CategoriesCB.ValueMember = "ID";
            CategoriesCB.DataSource = categories.GetAll();
            

            if (mode == "edit")
            {
                CWCarModel model = models.Get(Convert.ToInt32(id));
                if (model != null)
                {
                    NameTB.Text = model.Name;
                    BrandImagePB.SizeMode = PictureBoxSizeMode.Zoom;
                    
                    _image = Helpers.ImageOperations.ByteArrayToImage(model.Image);
                    image = model.Image;
                    BrandImagePB.Image = _image;
                    foreach (object category in CategoriesCB.Items)
                    {
                        if (((CWCategory)category).ID == model.CategoryID)
                        {
                            CategoriesCB.SelectedItem = category;
                        }
                    }
                }
            }
            
        }

        public ModelData(string _mode, int? _id, int? _brandId)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            image = null;
            id = _id;
            brandId = _brandId;
            Fill();
            if (mode == "edit")
            {
                
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            CWCarModelsLogic models = new CWCarModelsLogic(manager);

            if (mode == "new")
            {
                image = Helpers.ImageOperations.ConvertImageToByteArray(openFileDialog1.FileName);
                
                models.Create(NameTB.Text, Convert.ToInt32(brandId), image, Convert.ToInt32(CategoriesCB.SelectedValue));
            }
            if (mode == "edit")
            {
                if (_image != null)
                    image = Helpers.ImageOperations.ImageToByteArray(_image);
                else
                    image = null;
                models.Update(Convert.ToInt32(id), NameTB.Text, image, Convert.ToInt32(CategoriesCB.SelectedValue));
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

        private void AddImageBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BrandImagePB.SizeMode = PictureBoxSizeMode.Zoom;
                BrandImagePB.Image = new Bitmap(openFileDialog1.OpenFile());
                _image = BrandImagePB.Image;
            }   
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            _image = null;
            BrandImagePB.Image = _image;
        }
    }
}
