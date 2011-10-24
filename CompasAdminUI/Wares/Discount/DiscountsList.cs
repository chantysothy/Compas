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
    public partial class  DiscountsList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void FillDataGV()
        {
            WareDiscountsLogic discounts = new WareDiscountsLogic(manager);
            DataGV.AutoGenerateColumns = false;
            int? discountTypeId = null;
            if (DiscountTypesCB.SelectedItem != null)
                discountTypeId = Convert.ToInt32(DiscountTypesCB.SelectedValue);
            bool? active = ActiveCB.Checked;

            DataGV.DataSource = discounts.GetAll(discountTypeId, active);
            DataGV.Update();
        }

        private void Fill()
        {
            
            WareDiscountTypesLogic types = new WareDiscountTypesLogic(manager);
            DiscountTypesCB.ValueMember = "ID";
            DiscountTypesCB.DisplayMember = "Name";
            DiscountTypesCB.DataSource = types.GetAll();
            DiscountTypesCB.Update();

            FillDataGV();
            

        }

        public DiscountsList()
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

            DiscountData form = new DiscountData("new", null);
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            DiscountData form = new DiscountData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WareDiscountsLogic dicounts = new WareDiscountsLogic(manager);
            dicounts.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
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
            if (DataGV.SelectedRows[0].Cells[e.ColumnIndex].OwningColumn.Name == "Rules")
            {
                DiscountRulesList form = new DiscountRulesList(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
                form.ShowDialog();
            }
                    
               
           
        }

        

       
    }
}
