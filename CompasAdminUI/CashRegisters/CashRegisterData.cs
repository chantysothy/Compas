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
using Compas.CashRegisters;

namespace Compas.AdminUI.CashRegisters
{
    public partial class CashRegisterData : Form
    {
        //id інсталяції
        int installationId;
        CompasDataContext context;
        ContextManager manager;
        CashRegister cashRegister;

        public CashRegister CashRegisterInfo
        {
            get
            {
                return cashRegister;
            }
            set
            {
                cashRegister = value;
            }
        }
        private void Fill()
        {
            Logic.Config.ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            int modeId = ((SecurityMode)(ModesCB.SelectedItem)).ID;
            var parameterPortNumber = config.Get(installationId, Convert.ToInt32(modeId), Logic.Config.ParametersLogic.Parameter.CASHREGISTER_PORTNUMBER.ToString());
            var parameterLogicNumber = config.Get(installationId, Convert.ToInt32(modeId), Logic.Config.ParametersLogic.Parameter.CASHREGISTER_LOGICNUMBER.ToString());
            var parameterUser = config.Get(installationId, Convert.ToInt32(modeId), Logic.Config.ParametersLogic.Parameter.CASHREGISTER_USER.ToString());
            var parameterPassword = config.Get(installationId, Convert.ToInt32(modeId), Logic.Config.ParametersLogic.Parameter.CASHREGISTER_PASSWORD.ToString());

            if (parameterPortNumber != null)
                PortNumberTB.Text = parameterPortNumber.Value;
            else
                PortNumberTB.Text = "";

            if (parameterLogicNumber != null)
                LogicNumberTB.Text = parameterLogicNumber.Value;
            else
                LogicNumberTB.Text = "";

            if (parameterUser != null)
                UserTB.Text = parameterUser.Value;
            else
                UserTB.Text = "";

            if (parameterPassword != null)
                PasswordTB.Text = parameterPassword.Value;
            else
                PasswordTB.Text = "";

        }

        public CashRegisterData(CashRegister _CashRegister)
        {

            InitializeComponent();
            cashRegister = _CashRegister;
            installationId = Logic.Config.InstallationIdentifyLogic.InstallationIDInt;
            manager = new ContextManager();
            context = manager.Context;
            Logic.Config.ModesLogic modesLogic = new ModesLogic(manager);
            ModesCB.DataSource = modesLogic.GetAll();
            ModesCB.DisplayMember = "Name";
            ModesCB.ValueMember = "ID";
            ModesCB.SelectedIndex = 0;
            //id інсталяції
            Fill();
            
            
            
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            string portNumber = PortNumberTB.Text;
            string logicNumber = LogicNumberTB.Text;
            string user = UserTB.Text;
            string password = PasswordTB.Text;
            int modeId = ((SecurityMode)(ModesCB.SelectedItem)).ID;

            Logic.Config.ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            config.Create(installationId, modeId, null, Convert.ToString(Logic.Config.ParametersLogic.Parameter.CASHREGISTER_PORTNUMBER), portNumber, "");
            config.Create(installationId, modeId, null, Convert.ToString(Logic.Config.ParametersLogic.Parameter.CASHREGISTER_LOGICNUMBER), logicNumber, "");
            config.Create(installationId, modeId, null, Convert.ToString(Logic.Config.ParametersLogic.Parameter.CASHREGISTER_USER), user, "");
            config.Create(installationId, modeId, null, Convert.ToString(Logic.Config.ParametersLogic.Parameter.CASHREGISTER_PASSWORD), password, "");

            manager.Save();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void ModesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void TestConnectionBt_Click(object sender, EventArgs e)
        {
            //перевіряємо вказане підключення до РРО
            string portNumber = PortNumberTB.Text;
            string logicNumber = LogicNumberTB.Text;
            string user = UserTB.Text;
            string password = PasswordTB.Text;
            int modeId = ((SecurityMode)(ModesCB.SelectedItem)).ID;

            cashRegister = new CashRegister();
            try
            {
                cashRegister.Connect(CashRegisterModels.UNISYSTEM_MINI_FP, portNumber, logicNumber, user, password);
                MessageBox.Show("Підкючення виконано успішно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TestCheckBt_Click(object sender, EventArgs e)
        {
            if (cashRegister != null)
            {
                
                cashRegister.StartCheck();
                cashRegister.AddCheckPosition(1, 1, 1, "Тесттовар1");
                cashRegister.AddPayment(10);
                cashRegister.EndCheck();
            }
        }

        private void Z1Bt_Click(object sender, EventArgs e)
        {
            cashRegister.GetZ1Report();
        }

        private void Z2Bt_Click(object sender, EventArgs e)
        {
            cashRegister.GetZ2Report();
        }

        private void Z3Bt_Click(object sender, EventArgs e)
        {
            cashRegister.GetZ3Report();
        }

        private void X1Bt_Click(object sender, EventArgs e)
        {
            cashRegister.GetX1Report();
        }

        private void X3Bt_Click(object sender, EventArgs e)
        {
            cashRegister.GetX3Report();
        }

        private void CancelCheckBt_Click(object sender, EventArgs e)
        {
            cashRegister.CancelCheck();
        }

        private void StartShiftBt_Click(object sender, EventArgs e)
        {
            cashRegister.StartShift();
        }

        private void StartCheckBt_Click(object sender, EventArgs e)
        {
            cashRegister.StartCheck();
        }

        private void AddPositionBt_Click(object sender, EventArgs e)
        {
            cashRegister.AddCheckPosition(2, 1, 1, "Позиція №1");
        }

        private void AddPaymentBt_Click(object sender, EventArgs e)
        {
            cashRegister.AddPayment(100);
        }

        private void CloseCheckBt_Click(object sender, EventArgs e)
        {
            cashRegister.EndCheck();
        }

        private void TestIndicatorBt_Click(object sender, EventArgs e)
        {
            cashRegister.DisplayText("ТЕСТ ІНДИКАТОРА!");
        }

        private void CopyCheckBt_Click(object sender, EventArgs e)
        {
            cashRegister.CopyLastCheck();
        }

        private void PrintTextCommentBt_Click(object sender, EventArgs e)
        {
            cashRegister.AddTextComment("КОМЕНТАР");
        }

        private void MoneysInBt_Click(object sender, EventArgs e)
        {
            cashRegister.MoneyInOut(1);
        }

        private void MoneysOutBt_Click(object sender, EventArgs e)
        {
            cashRegister.MoneyInOut(-1);
        }

        private void OpenSafeBt_Click(object sender, EventArgs e)
        {
            cashRegister.OpenSafe();
        }

        private void LastCheckInfoBt_Click(object sender, EventArgs e)
        {
            Check check = cashRegister.LastCheckInfo();
            MessageBox.Show("№ чеку: " + check.Number +
                "\nДата видачі: " + check.FullDate + 
                "\nНомер касира: " + check.OperNumber);
        }

        private void CheckConnectionBt_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void CheckConnectionBt_Click(object sender, EventArgs e)
        {
            cashRegister.CheckConnection();
        }
    }
}
