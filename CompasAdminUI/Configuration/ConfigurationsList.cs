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
using Compas.Logic.Config;
using Compas.Helpers;
using DgvFilterPopup;

namespace Compas.AdminUI.Configuration
{
    public partial class  ConfigurationsList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void FillDataGV()
        {

            Compas.Logic.Config.ConfigurationParametersLogic configurationsLogic = new ConfigurationParametersLogic(manager);
            ListToDataTable listToDataTable = new ListToDataTable();
            
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = listToDataTable.ToDataTable<ViewConfigurationParameter>(configurationsLogic.GetAllView());
            DgvFilterManager filterManager = new DgvFilterManager(DataGV);
            DataGV.Update();
        }

        private void Fill()
        {
            FillDataGV();
            
        }

        public ConfigurationsList()
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

            ConfigurationData form = new ConfigurationData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            //DiscountData form = new DiscountData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            //form.ShowDialog();
            //manager.Save();
            //manager.CloseContext();
            //manager = new ContextManager();
            //Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ConfigurationParametersLogic parametersLogic = new ConfigurationParametersLogic(manager);
            parametersLogic.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
            
        }

        private void DiscountTypesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGV();
        }

        private void ActiveCB_CheckedChanged(object sender, EventArgs e)
        {
            FillDataGV();
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

       
    }
}
