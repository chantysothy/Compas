using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Compas.Logic.Documents;
using Compas.Model;
using Compas.Logic;
using Compas.Logic.Config;
using Compas.CashRegisters;

namespace Compas.AdminUI
{
    public partial class MainMDI : Form
    {
        private int childFormNumber = 0;
        CashRegister cashRegister;//касового реєстратора або фіскальний принтер

        public MainMDI()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            
           //Початковий запуск - перевіряємо чи заповнений довідник типівдокументів
            ContextManager manager = new ContextManager();
            CompasDataContext context = manager.Context;
            DocumentTypesLogic documentTypes = new DocumentTypesLogic(manager);
            var existTypes = documentTypes.GetAll();
            if (existTypes.Count == 0)
            {
                documentTypes.Create(1, "Прихідна накладна", true, false);
                documentTypes.Create(2, "Розхідна накладна", false, true);
                documentTypes.Create(3, "Чек", false, true);
                documentTypes.Create(4, "Переміщення товару", false, false);
                documentTypes.Create(5, "Замовлення", false, false);
                manager.Save();
            }

            ConfigurationParametersLogic config = new ConfigurationParametersLogic(manager);
            ConfigurationParameter param0 = config.Get(ParametersLogic.Parameter.MENUITEM_CARDS_VISIBLE.ToString());
            if (param0 != null)
            {
                if (param0.Value == "FALSE")
                {                   
                    foreach (ToolStripMenuItem mainMenu in menuStrip.Items)
                    {                       
                        if (mainMenu.Text == @"Довідники")
                        {
                            foreach (ToolStripItem subMenu in mainMenu.DropDownItems)
                            {
                                if (subMenu.Name == "CardsToolStripMenuItem")
                                    subMenu.Visible = false;
                            }
                        }
                    }
                }
            }

            ConfigurationParameter param1 = config.Get(ParametersLogic.Parameter.MENUITEM_CARWASH_VISIBLE.ToString());
            if (param1 != null)
            {
                if (param1.Value == "FALSE")
                {
                    foreach (ToolStripMenuItem mainMenu in menuStrip.Items)
                    {
                        if (mainMenu.Text == @"Довідники")
                        {
                            foreach (ToolStripItem subMenu in mainMenu.DropDownItems)
                            {
                                if (subMenu.Name == "CarWashToolStripMenuItem")
                                    subMenu.Visible = false;
                            }
                        }
                    }
                }
            }

            ConfigurationParameter param2 = config.Get(ParametersLogic.Parameter.MENUITEM_SECURITY_ENABLED.ToString());
            if (param2 != null)
            {
                if (param2.Value == "FALSE")
                {
                    menuStrip.Items["SecurityToolStripMenuItem"].Enabled = false;
                }
            }
            manager.CloseContext();

        }

        private void EnterprisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void StructureObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.StructureObject.StructureObjectsList form = new Staff.StructureObject.StructureObjectsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {

                
                form.MdiParent = this;
                //form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void TeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Staff.Team.TeamsList form = new Staff.Team.TeamsList();
            //form.MdiParent = this;
            //form.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Employee.EmployeesList form = new Staff.Employee.EmployeesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {

                
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void SecurityCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Security.CategoriesForm form = new Security.CategoriesForm();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void SecurityActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.ActionsForm form = new Security.ActionsForm();

           
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void RolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.RolesForm form = new Security.RolesForm();
            
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void RoleActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security.RoleActionsF form = new Security.RoleActionsF();
            
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");

            //if (allowed == true)
            //{
            Staff.Shift.ShiftsList form = new Staff.Shift.ShiftsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
            //}
            //else
            //{
            //    MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            //}
        }

        private void MainMDI_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                
                TabsXTC.Visible = false;
            }
            // If no any child form, hide tabControl 

            else
            {
                //if(this.ActiveMdiChild.WindowState !=
                //FormWindowState.Maximized)
                    this.ActiveMdiChild.WindowState =
                    FormWindowState.Maximized;
                //this.ActiveMdiChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                // Child form always maximized 


                // If child form is new and no has tabPage, 

                // create new tabPage 

                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 

                    // form caption 

                    
                    TabPage tp = new TabPage(this.ActiveMdiChild
                                             .Text);
                    tp.Tag = this.ActiveMdiChild;
                    
                    
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed +=
                        new FormClosedEventHandler(
                                        ActiveMdiChild_FormClosed);

                    

                    
                    DevExpress.XtraTab.XtraTabPage tabPage = new DevExpress.XtraTab.XtraTabPage();
                    tabPage.Tag = this.ActiveMdiChild;
                    tabPage.Parent = TabsXTC;
                    tabPage.Text = this.ActiveMdiChild.Text;
                    TabsXTC.SelectedTabPage = tabPage;
                    TabsXTC.TabPages.Add(tabPage);
                    this.ActiveMdiChild.Tag = tabPage;

                }

               
                if (!TabsXTC.Visible) TabsXTC.Visible = true;
            }



        }

        private void ActiveMdiChild_FormClosed(object sender,
                                    FormClosedEventArgs e)
        {
            //((sender as Form).Tag as TabPage).Dispose();
            if(TabsXTC.SelectedTabPageIndex > 0)
                TabsXTC.SelectedTabPageIndex = TabsXTC.SelectedTabPageIndex - 1;
            ((sender as Form).Tag as DevExpress.XtraTab.XtraTabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender,
                                           EventArgs e)
        {
            //if ((TabsTC.SelectedTab != null) &&
            //    (TabsTC.SelectedTab.Tag != null))
            //    (TabsTC.SelectedTab.Tag as Form).Select();
        }

        private void MainMDI_ControlRemoved(object sender, ControlEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Position.PositionsList form = new Staff.Position.PositionsList();

            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {
                form.MdiParent = this;
                //form.WindowState = FormWindowState.Maximized;
                try
                {
                    form.Show();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Дія заборонена");
            }
        }

        private void ShedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.Sheduler.ShedulersList form = new Staff.Sheduler.ShedulersList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
            
        }

        private void ManufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Manufacturer.ManufacturersList form = new Wares.Manufacturer.ManufacturersList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void WareCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Category.CategoriesList form = new Wares.Category.CategoriesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void UnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Unit.UnitsList form = new Wares.Unit.UnitsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
            
        }

        private void WareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Ware.WaresList form = new Wares.Ware.WaresList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void PricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Price.PricesList form = new Wares.Price.PricesList(null);
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void ExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Extra.ExtrasList form = new Wares.Extra.ExtrasList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void PriceGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.PriceGroup.PriceGroupsList form = new Wares.PriceGroup.PriceGroupsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

      
        private void TabsXTC_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if ((TabsXTC.SelectedTabPage != null) &&
                (TabsXTC.SelectedTabPage.Tag != null))
            {
                
                (TabsXTC.SelectedTabPage.Tag as Form).Select();
                foreach (Form child in this.MdiChildren)
                {
                    
                    //child.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    //child.Text = ""; 
                    //child.ControlBox = false;
                    if (child != (TabsXTC.SelectedTabPage.Tag as Form))
                    {

                        //child.Visible = false;
                        //child.ShowInTaskbar = false;
                        child.WindowState = FormWindowState.Minimized;
                    }
                    else
                    {
                        //child.WindowState = FormWindowState.Maximized;                                           
                        //child.Visible = true;
                        
                    }
                }
            }
        }

        private void NewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.DocumentData form = new Documents.DocumentData("new", null, cashRegister);
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.WindowState = FormWindowState.Maximized;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
           
           
        }

        private void DocumentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.DocumentsList form = new Documents.DocumentsList(cashRegister);
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void ClientTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractorsUI.ContractorTypesList form = new ContractorsUI.ContractorTypesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void ContractorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractorsUI.ContractorsList form = new ContractorsUI.ContractorsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void CurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.CurrencyUI.CurrenciesList form = new Common.CurrencyUI.CurrenciesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void DiscountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Discount.DiscountsList form = new Wares.Discount.DiscountsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void RemainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wares.Remain.RemainsList form = new Wares.Remain.RemainsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void PaymentTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.PaymentTypesList form = new Documents.PaymentTypesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void WareGeneralReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reports.WareGeneralReport form = new Reports.WareGeneralReport();
            //form.MdiParent = this;
            //form.Show();
        }

        private void ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DocumentsAlternativeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.DocumentsAlternateList form = new Documents.DocumentsAlternateList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void BrandsMI_Click(object sender, EventArgs e)
        {
            Cars.BrandsList form = new Cars.BrandsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void ModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cars.ModelsList form = new Cars.ModelsList(null);
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cars.CarsList form = new Cars.CarsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cars.CategoriesList form = new Cars.CategoriesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration.ConfigurationsList form = new Configuration.ConfigurationsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void CardTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cards.CardTypesList form = new Cards.CardTypesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void CardsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cards.CardsList form = new Cards.CardsList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void EnterprisesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EnterprisesList form = new EnterprisesList();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void scanerTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanerTest form = new ScanerTest();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void WaresDetalisationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.WaresDetalisationReport form = new Reports.WaresDetalisationReport();
            form.MaximizeBox = true;
            form.Show();

        }

        private void AllPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.PaymentsList form = new Documents.PaymentsList(null);
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void PaymentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.PaymentsReport form = new Reports.PaymentsReport();
            form.MaximizeBox = true;
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void CashRegisterConfigSMI_Click(object sender, EventArgs e)
        {
            CashRegisters.CashRegisterData form = new CashRegisters.CashRegisterData(cashRegister);            
            form.ShowDialog();
            cashRegister = form.CashRegisterInfo;
        }

        private void SalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compas.AdminUI.Staff.EmployeSalariesList form = new Staff.EmployeSalariesList(null);
            
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

        private void NewDocumentWithoutCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents.DocumentData form = new Documents.DocumentData("new", null, cashRegister);
            form.CloseAfterPayment = false;
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed(form.Name);

            if (allowed == true)
            {


                form.WindowState = FormWindowState.Maximized;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");

            }
        }

       
       

       
    }
}
