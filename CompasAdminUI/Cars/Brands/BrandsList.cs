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
    public partial class BrandsList : Form
    {
        
        
        
        ContextManager manager;

        private void Fill()
        {

            CWCarBrandsLogic brands = new CWCarBrandsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = brands.GetAll();
            DataGV.Update();

        }

        public BrandsList()
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

            Cars.BrandData form = new Cars.BrandData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Cars.BrandData form = new Cars.BrandData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            CWCarBrandsLogic brands = new CWCarBrandsLogic(manager);
            brands.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGV.SelectedRows[0].Cells[e.ColumnIndex].OwningColumn.Name == "Models")
            {
                Cars.ModelsList form = new Cars.ModelsList(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
                form.ShowDialog();
            }
        }

       
    }
}
