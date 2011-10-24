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
using Compas.Logic.Config;
using Compas.Logic.Security;


namespace Compas.AdminUI.Configuration
{
    public partial class ConfigurationData : Form
    {
        string mode;
        
        int? id;
        ContextManager manager;
        private void Fill()
        {
            ParametersLogic parameters = new ParametersLogic();
            ParametersCB.DataSource = parameters.GetAll();
            ParametersCB.DisplayMember = "Name";
            ParametersCB.ValueMember = "ID";

            ModesLogic modes = new ModesLogic(manager);
            ModeCB.DataSource = modes.GetAll();
            ModeCB.DisplayMember = "Name";
            ModeCB.ValueMember = "ID";

            SecurityUsersLogic usersLogic = new SecurityUsersLogic(manager);
           
            UsersCB.DisplayMember = "Login";
            UsersCB.ValueMember = "ID";

            SecurityUser u0 = new SecurityUser();
            u0.ID = -1;
            u0.Login = "- не вказано -";
            UsersCB.Items.Add(u0);
            foreach (SecurityUser sm in usersLogic.GetAll())
            {
                UsersCB.Items.Add(sm);
            }
            UsersCB.SelectedIndex = 0;

            if (mode == "edit")
            {

                if (id != null)
                {
                    
                }
                //WareDiscountType discountTypes = discountTypes.Get(Convert.ToInt32(id));
                //if (currency != null)
                //{
                //   NameTB.Text = currency.Name;
                //}
            }
            
        }

        public ConfigurationData(string _mode, int? _id)
        {
            
            InitializeComponent();
            manager = new ContextManager();
            mode = _mode;
            
            id = _id;
            Fill();
            //if (mode == "edit")
            //{
                
            //}
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            int modeId;
            int? userId;
            string parameter;
            string value;
            string comment;

            modeId = Convert.ToInt32(ModeCB.SelectedValue);
            userId = Convert.ToInt32(UsersCB.SelectedValue);
            parameter = ParametersCB.SelectedValue.ToString();
            value = ValueTB.Text;
            comment = CommentTB.Text;

            if (userId <= 0)
                userId = null;

            if (mode == "new")
            {
                config.Create(modeId, userId, parameter, value, comment);
            }
            if (mode == "edit")
            {
                config.Update(Convert.ToInt32(id), modeId, userId, parameter, value, comment);
            }
            manager.Save();

            this.Close();

            //WareDiscountsLogic discounts = new WareDiscountsLogic(manager);
            //int discountTypeId = Convert.ToInt32(DiscountTypesCB.SelectedValue);
            //string name = NameTB.Text;
            //bool active = ActiveCB.Checked;
            //decimal defaultDiscountPercent = DefaultDiscountPercentNUD.Value;
            //if (mode == "new")
            //{
            //    discounts.Create(name, active, discountTypeId, defaultDiscountPercent);
            //}
            //if (mode == "edit")
            //{
            //    discounts.Update(Convert.ToInt32(id), name, active, discountTypeId, defaultDiscountPercent);
            //}
            //manager.Save();

            //this.Close();
        }

        

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTypeBt_Click(object sender, EventArgs e)
        {
            Wares.Discount.DiscountTypesList form = new Wares.Discount.DiscountTypesList();

            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
