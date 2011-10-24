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
using Compas.Helpers;

using DgvFilterPopup;

namespace Compas.AdminUI.Cards
{
    public partial class CardsList : Form
    {
        
        int StructureObjectId;
        
        ContextManager manager;

        private void Fill()
        {

            CardsLogic cardsLogic = new CardsLogic(manager);
            DataGV.AutoGenerateColumns = false;


            List<CardView> view = cardsLogic.GetAll().Select(a => new CardView(a)).ToList();
            ListToDataTable listToDataTable = new ListToDataTable();
            DataGV.DataSource = listToDataTable.ToDataTable<CardView>(view);
            DgvFilterManager filterManager = new DgvFilterManager(DataGV);
            DataGV.Update();

        }

        public CardsList()
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

            Cards.CardData form = new Cards.CardData("new", null, null);
            form.ShowDialog();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void EditSB_Click(object sender, EventArgs e)
        {
            Cards.CardData form = new Cards.CardData("edit", Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value), null);
            form.ShowDialog();
            manager.Save();
            manager.CloseContext();
            manager = new ContextManager();
            Fill();
        }

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            CardsLogic cards = new CardsLogic(manager);
            cards.Delete(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void ExcelMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToExcel(DataGV, this.Name);
        }

        private void PDFMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToPDF(DataGV, this.Name);
        }

        private void HTMLMI_Click(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToHTML(DataGV, this.Name);
        }

        private void ExportSB_ButtonClick(object sender, EventArgs e)
        {
            Helpers.DataGridExport.ExportToExcel(DataGV, this.Name);
        }
       
    }
}
