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

using Compas.Logic;


namespace Compas.AdminUI.Cars

{
    public partial class CategoryData : Form
    {
        string mode;
        byte[] image;
        
        int? id;

        ContextManager manager;
        private void Fill()
        {
            CWCategoriesLogic categories = new CWCategoriesLogic(manager);

            if (mode == "edit")
            {
                CWCategory category = categories.Get(Convert.ToInt32(id));
                if (category != null)
                {
                    NameTB.Text = category.Name;
                    
                }
            }
            
        }

        public CategoryData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;

            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            CWCategoriesLogic categories = new CWCategoriesLogic(manager);
                   

            if (mode == "new")
            {
                
                categories.Create(NameTB.Text, null, null);
            }
            if (mode == "edit")
            {

                categories.Update(Convert.ToInt32(id), NameTB.Text, null, null);
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

        

        private void DeleteBt_Click(object sender, EventArgs e)
        {
           
            
        }

        
    }
}
