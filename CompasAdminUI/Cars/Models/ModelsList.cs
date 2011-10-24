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
    public partial class ModelsList : Form
    {
        
        int? brandId;
        
        ContextManager manager;

        public int? SelectedModelID
        {
            get 
            {
                int? result = null;
                if (DataGV.CurrentRow != null)
                    result = Convert.ToInt32(DataGV.CurrentRow.Cells["ID"].Value);
                else
                    result = null;
                return result;
            }
        }

        private void Fill()
        {

            CWCarModelsLogic models = new CWCarModelsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            if(brandId != null)
                DataGV.DataSource = models.GetAll(Convert.ToInt32(brandId));
            else
                DataGV.DataSource = models.GetAll();
            DataGV.Update();

        }

        public ModelsList(int? _brandId)
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");
            brandId = _brandId;
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
            
            Cars.ModelData form = new Cars.ModelData("new", null, brandId);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Cars.ModelData form = new Cars.ModelData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            CWCarModelsLogic models = new CWCarModelsLogic(manager);
            models.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

       
    }
}
