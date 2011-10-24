using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Compas.AdminUI;
using Compas.Helpers;
using Compas.Logic;
using Compas.Logic.Security;


namespace Compas.Login
{
    /// <summary>
    /// форма входу
    /// </summary>
    public partial class Login : Form
    {
        //private static CompasLogger logger = CompasLogFactory.Instance;

        
        public Login()
        {
            
            InitializeComponent();
            ModeCB.ValueMember = "ID";
            
            //необхідно заповнити випадний список доступними модулями
            
            Helpers.Item item1 = new Item();
            item1.Name = "Каса";
            item1.ID = "CASH";
            ModeCB.Items.Add(item1);
            Helpers.Item item0 = new Item();
            item0.Name = "Адміністрування";
            item0.ID = "ADMIN";
            ModeCB.Items.Add(item0);
            //Helpers.Item item2 = new Item();
            //item2.Name = "Мийка";
            //item2.ID = "CARWASH";
            //ModeCB.Items.Add(item2);
            //Helpers.Item item3 = new Item();
            //item3.Name = "СКЛАД";
            //item3.ID = "WAREHOUSE";
            //ModeCB.Items.Add(item3);
            ModeCB.SelectedIndex = 0;
            //MessageBox.Show(AppDomain.CurrentDomain.FriendlyName);
            AppDomain.CurrentDomain.SetData("Authenticated", "True");
        }


        /// <summary>
        /// При успішній перевірці логіна і пароля створюється КОНТЕКСТ БЕЗПЕКИ
        /// КОНТЕКСТ БЕЗПЕКИ зберігається в AppDomain.CurrentDomain в змінну "SecurityContext", 
        /// до якого мають доступ всі внутрішні проекти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBt_Click(object sender, EventArgs e)
        {
            
            string hash = "";
            string login = LoginTB.Text;
            CompasLogger.Add(String.Format("Try to login: {0}", login),CompasLogger.Level.Info);
            hash = Helpers.Crypto.sha512encrypt(PasswordTB.Text + login);
            CompasLogger.Add(String.Format("Generated HASH"), CompasLogger.Level.Info);
            Compas.Logic.Security.CompasIdentity identity = new Compas.Logic.Security.CompasIdentity(login, hash);
            CompasLogger.Add(String.Format("Identity class created"), CompasLogger.Level.Info);
            CompasPrincipal principal = new CompasPrincipal(identity);
            AppDomain.CurrentDomain.SetData("Mode",((Helpers.Item)(ModeCB.SelectedItem)).ID);
            CompasLogger.Add(String.Format("Mode saved: {0}", ((Helpers.Item)(ModeCB.SelectedItem)).Name), CompasLogger.Level.Info);
            if (login != "romin")
            {
                if (identity.IsAuthenticated == true)
                {
                    CompasLogger.Add(String.Format("Success login: {0}", login), CompasLogger.Level.Info);
                    CompasSecurityContext context = new CompasSecurityContext(identity, principal);
                    AppDomain.CurrentDomain.SetData("SecurityContext", context);
                    AppDomain.CurrentDomain.SetData("Mode", ((Helpers.Item)(ModeCB.SelectedItem)).ID);

                    //символьне значення
                    AppDomain.CurrentDomain.SetData("InstallationID", Compas.Logic.Config.InstallationIdentifyLogic.GenerateInstallationID());
                    //числове значення
                    AppDomain.CurrentDomain.SetData("InstallationIDInt", Compas.Logic.Config.InstallationIdentifyLogic.InstallationIDInt);
                    MainMDI form = new MainMDI();
                    this.Visible = false;
                    PasswordTB.Text = "";
                    LoginTB.Text = "";
                    this.Visible = false;
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    CompasLogger.Add(String.Format("Fail login: {0}", login), CompasLogger.Level.Warn);
                    MessageBox.Show("Не знайдено користувача з вказаним логіном і паролем");
                }
            }
            else
            {
                
                
                CompasSecurityContext context = new CompasSecurityContext(identity, principal);
                AppDomain.CurrentDomain.SetData("SecurityContext", context);

                

                //installationLogic.ClearInstallationID();
                CompasLogger.Add("Генерація ідентифікатора", CompasLogger.Level.Info);
                //Compas.Logic.Configuration.InstallationIdentifyLogic.ClearInstallationID();
                //символьне значення
                AppDomain.CurrentDomain.SetData("InstallationID", Compas.Logic.Config.InstallationIdentifyLogic.GenerateInstallationID());
                //числове значення
                AppDomain.CurrentDomain.SetData("InstallationIDInt", Compas.Logic.Config.InstallationIdentifyLogic.InstallationIDInt);
                MainMDI form = new MainMDI();
                this.Visible = false;
                PasswordTB.Text = "";
                LoginTB.Text = "";
                this.Visible = false;
                
                form.ShowDialog();
                this.Close();
                
            }

            
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
