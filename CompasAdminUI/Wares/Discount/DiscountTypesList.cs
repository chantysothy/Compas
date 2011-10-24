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

namespace Compas.AdminUI.Wares.Discount
{
    public partial class  DiscountTypesList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void Fill()
        {

            WareDiscountTypesLogic currencies = new WareDiscountTypesLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = currencies.GetAll();
            DataGV.Update();

        }

        public DiscountTypesList()
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

            DiscountTypeData form = new DiscountTypeData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            DiscountTypeData form = new DiscountTypeData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WareDiscountTypesLogic currencies = new WareDiscountTypesLogic(manager);
            currencies.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

       
    }
}
