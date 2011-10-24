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
using DgvFilterPopup;
using Compas.Helpers;

namespace Compas.AdminUI.Cars
{
    public partial class CarsList : Form
    {
        
        
        ContextManager manager;

        private void Fill()
        {
            CWCarsLogic cars = new CWCarsLogic(manager);            
            DataGV.AutoGenerateColumns = false;           
            
            ListToDataTable listToDataTable = new ListToDataTable();
            DataGV.DataSource = listToDataTable.ToDataTable<CWCarView>(cars.GetAllView().ToList());
            DgvFilterManager filterManager = new DgvFilterManager(DataGV);
        }

        public CarsList()
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

            Cars.CarData form = new Cars.CarData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Cars.CarData form = new Cars.CarData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
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
            //if (DataGV.SelectedRows[0].Cells[e.ColumnIndex].OwningColumn.Name == "Models")
            //{
            //    Cars.ModelsList form = new Cars.ModelsList(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            //    form.ShowDialog();
            //}
        }

       
    }
}
