using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Compas.Model;
using Compas.Logic.Wares;
using Compas.Logic;


namespace Compas.AdminUI.Wares.Discount
{
    public partial class DiscountRuleData : Form
    {
        string mode;
        
        int? id;
        decimal? discountId;
        ContextManager manager;
        private void Fill()
        {
            WareDiscountRulesLogic discountRules = new WareDiscountRulesLogic(manager);

            if (mode == "edit")
            {
                WareDiscountRule rule = discountRules.Get(Convert.ToInt32(id));
                if (rule != null)
                {
                    StartNUD.Value = rule.StartSuma;
                    if (rule.EndSuma != null)
                    {
                        EndNUD.Value = Convert.ToDecimal(rule.EndSuma);
                    }
                    DiscountPercentNUD.Value = Convert.ToDecimal(rule.DiscountPercent);
                }
            }
            
        }

        public DiscountRuleData(string _mode, int? _id, int? _discountId)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            discountId = _discountId;

            if (mode == "edit")
            {
                Fill();
            }
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {

            WareDiscountRulesLogic discountRules = new WareDiscountRulesLogic(manager);
            decimal startSuma = StartNUD.Value;
            decimal? endSuma = null;
            if (EndCB.Checked == true)
            {
                endSuma = EndNUD.Value;
            }
            decimal? discountPercent = DiscountPercentNUD.Value;

            if (mode == "new")
            {
                discountRules.Create(Convert.ToInt32(discountId), startSuma, endSuma, discountPercent);
            }
            if (mode == "edit")
            {
                discountRules.Update(Convert.ToInt32(id), startSuma, endSuma, discountPercent);
            }
            manager.Save();

            this.Close();
        }

        

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndCB_CheckedChanged(object sender, EventArgs e)
        {
            EndNUD.Enabled = EndCB.Checked;
        }
    }
}
