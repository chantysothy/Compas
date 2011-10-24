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
using Compas.Logic.Documents;
using Compas.Helpers;
using DgvFilterPopup;

namespace Compas.AdminUI.Documents
{
    public partial class PaymentsList : Form
    {


        int? documentId = null;
        ContextManager manager;

        private void Fill()
        {
            DocumentPaymentsLogic payments = new DocumentPaymentsLogic(manager);
            DataGV.AutoGenerateColumns = false;           
            ListToDataTable listToDataTable = new ListToDataTable();
            List<ViewPayment> paymentsList = new List<ViewPayment>();
            if (documentId == null)
                paymentsList = payments.GetAllViewByPeriod(StartDateDTP.Value, EndDateDTP.Value);
            else
            {
                paymentsList = payments.GetAllViewByDocumentID(Convert.ToInt32(documentId));
                StartDateDTP.Enabled = false;
                EndDateDTP.Enabled = false;
            }
            DataGV.DataSource = listToDataTable.ToDataTable<ViewPayment>(paymentsList);
            DgvFilterManager filterManager = new DgvFilterManager(DataGV);
            DataGV.Update();

            SummaryDataGV.AutoGenerateColumns = true;
            var groupResult = from p in paymentsList
                              group p by new { p.FullEmployeeName, p.PaymentTypeName }
                                  into myGroup
                                  where myGroup.Count() > 0
                                  select new { myGroup.Key.FullEmployeeName, myGroup.Key.PaymentTypeName, Count = myGroup.Count(), Suma = myGroup.Sum(a => a.Suma) };
            SummaryDataGV.DataSource = groupResult.ToList();
            SummaryDataGV.Update();
        }

        public PaymentsList(int? DocumentID)
        {
            InitializeComponent();
            manager = new ContextManager();
            bool allowed = Compas.Logic.Security.CurrentSecurityContext.Principal.OpperationAllowed("StaffShiftsList");
            documentId = DocumentID;
            if (allowed == true)
            {
                StartDateDTP.Value = DateTime.Now.Date.AddDays(-1);
                EndDateDTP.Value = StartDateDTP.Value.AddDays(1);
                
                Fill();
            }
            else
            {
                MessageBox.Show("Дія заборонена. Зверніться до адміністратора.");
                this.Close();
            }

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

        

        

        private void DeleteSB_Click(object sender, EventArgs e)
        {
            DocumentPaymentsLogic brands = new DocumentPaymentsLogic(manager);
            brands.CancelPayment(Convert.ToInt32(DataGV.SelectedRows[0].Cells["ID"].Value));
            manager.Save();
            Fill();
        }

        private void ShiftsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.CloseContext();
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            Fill();
        }

        

        

       
    }
}
