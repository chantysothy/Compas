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
using Compas.Logic.Wares;

namespace Compas.AdminUI.Cars
{
    public partial class CategoriesList : Form
    {
        
        
        
        ContextManager manager;

        private void Fill()
        {

            CWCategoriesLogic Categories = new CWCategoriesLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = Categories.GetAll();
            DataGV.Update();

        }

        public CategoriesList()
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            if (allowed == true)
            {
                Fill();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

        }

        private void NewSB_Click(object sender, EventArgs e)
        {

            Cars.CategoryData form = new Cars.CategoryData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Cars.CategoryData form = new Cars.CategoryData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            CWCategoriesLogic Categories = new CWCategoriesLogic(manager);
            Categories.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}
