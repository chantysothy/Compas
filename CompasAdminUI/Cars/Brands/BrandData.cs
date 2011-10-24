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
    public partial class BrandData : Form
    {
        string mode;
        byte[] image;
        Image _image;
        int? id;

        ContextManager manager;
        private void Fill()
        {
            CWCarBrandsLogic units = new CWCarBrandsLogic(manager);

            if (mode == "edit")
            {
                CWCarBrand unit = units.Get(Convert.ToInt32(id));
                if (unit != null)
                {
                    NameTB.Text = unit.Name;
                    BrandImagePB.SizeMode = PictureBoxSizeMode.Zoom;
                    _image =  Helpers.ImageOperations.ByteArrayToImage(unit.Image);
                    image = unit.Image;
                    BrandImagePB.Image = _image;
                }
            }
            
        }

        public BrandData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            image = null;
            id = _id;

            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            CWCarBrandsLogic units = new CWCarBrandsLogic(manager);
                   

            if (mode == "new")
            {
                if (openFileDialog1.CheckPathExists == true)
                    image = Helpers.ImageOperations.ConvertImageToByteArray(openFileDialog1.FileName);
                units.Create(NameTB.Text, image);
            }
            if (mode == "edit")
            {
                if (_image != null)
                    image = Helpers.ImageOperations.ImageToByteArray(_image);
                else
                    image = null;
                units.Update(Convert.ToInt32(id), NameTB.Text, image);
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
