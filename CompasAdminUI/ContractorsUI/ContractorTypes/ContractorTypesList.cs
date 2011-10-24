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
using Compas.Logic.Contractors;

namespace Compas.AdminUI.ContractorsUI

{
    public partial class ContractorTypesList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void Fill()
        {

            ContractorTypesLogic types = new ContractorTypesLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = types.GetAll();
            DataGV.Update();

        }

        public ContractorTypesList()
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

            ContractorsUI.ContractorTypeData form = new ContractorsUI.ContractorTypeData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            ContractorsUI.ContractorTypeData form = new ContractorsUI.ContractorTypeData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            ContractorTypesLogic types = new ContractorTypesLogic(manager);
            types.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

       
    }
}
