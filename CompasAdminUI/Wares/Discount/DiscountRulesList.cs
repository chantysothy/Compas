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
    public partial class  DiscountRulesList : Form
    {
        
        
        
        ContextManager manager;
        int discountId;
        

        private void Fill()
        {

            WareDiscountRulesLogic rulesLogic = new WareDiscountRulesLogic(manager);
            DataGV.AutoGenerateColumns = false;
            DataGV.DataSource = rulesLogic.GetAllByDiscountID(discountId);
            DataGV.Update();

        }

        public DiscountRulesList(int _discountId)
        {
            InitializeComponent();
            manager = new ContextManager();
            discountId = _discountId;
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

            DiscountRuleData form = new DiscountRuleData("new", null, Convert.ToInt32(discountId));
            form.ShowDialog();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            DiscountRuleData form = new DiscountRuleData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            WareDiscountRulesLogic rulesLogic = new WareDiscountRulesLogic(manager);
            rulesLogic.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

       
    }
}
