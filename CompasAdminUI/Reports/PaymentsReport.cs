using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;

using Compas.Logic.Reports;
using Compas.Logic.Documents;
using Compas.Logic.Staff;
using Compas.Logic;
using Compas.Model;
namespace Compas.AdminUI.Reports
{
    public partial class PaymentsReport : Form
    {
        ReportsLogic reportsLogic;
        ContextManager manager = new ContextManager();
        public PaymentsReport()
        {
            InitializeComponent();
            reportsLogic = new ReportsLogic(manager);
            EndDateDTP.Value = DateTime.Now.AddDays(1).Date;
            FillDocumentTypes();
            FillStructureObjects();
            FillPaymentTypes();
        }

        private void FillDocumentTypes()
        {
            DocumentTypesLogic documentTypesLogic = new DocumentTypesLogic(manager);
            DocumentTypesCB.DataSource = documentTypesLogic.GetAll();
            DocumentTypesCB.ValueMember = "ID";
            DocumentTypesCB.DisplayMember = "Name";
            DocumentTypesCB.Update();
        }

        private void FillStructureObjects()
        {
            StaffStructureObjectsLogic structureObjectsLogic = new StaffStructureObjectsLogic(manager);
            StructureObjectsCB.DataSource = structureObjectsLogic.GetHeirarchyView();
            StructureObjectsCB.ValueMember = "ID";
            StructureObjectsCB.DisplayMember = "Name";
            StructureObjectsCB.Update();
        }

        private void FillPaymentTypes()
        {
            Compas.Logic.Documents.DocumentPaymentTypesLogic paymentTypesLogic = new DocumentPaymentTypesLogic(manager);
            PaymentTypesCB.DataSource = paymentTypesLogic.GetAll();
            PaymentTypesCB.ValueMember = "ID";
            PaymentTypesCB.DisplayMember = "Name";
            PaymentTypesCB.Update();
        }

        private void PaymentsReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
        private void OkBt_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDateDTP.Value;
            DateTime endDate = EndDateDTP.Value;
            int? documentTypeId = Convert.ToInt32(DocumentTypesCB.SelectedValue);
            int? paymentTypeId = Convert.ToInt32(PaymentTypesCB.SelectedValue);
            int? structureObjectId = Convert.ToInt32(StructureObjectsCB.SelectedValue);
            //BindingSource bs = new BindingSource();
            ViewPaymentBindingSource.DataSource = reportsLogic.GetPaymentsReport(startDate, endDate, documentTypeId, paymentTypeId,structureObjectId);
            
            //thi.Fill(this.mKSDBDataSet.ViewWaresDetalisation);
            //dataGridView1.DataSource = reportsLogic.GetWaresReport(startDate, endDate);
            //// TODO: This line of code loads data into the 'mKSDBDataSet.ViewWaresDetalisation' table. You can move, or remove it, as needed.
            //this.viewWaresDetalisationTableAdapter.Fill(this.mKSDBDataSet.ViewWaresDetalisation);
           

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("ReportName", "Звіт по оплатам за період");
            //if (OutputRB.Checked == true)
            //    parameters[0] = new ReportParameter("ReportName", "Звіт по оплатам за період - " + "Прихід");
            //else
            //    parameters[0] = new ReportParameter("ReportName", "Звіт по оплатам за період - " + "Розхід");


            ////parameters[1] = new ReportParameter("EndDate", "1/1/2003");
            reportViewer1.LocalReport.SetParameters(parameters);

            ////reportViewer1.ShowParameterPrompts = true;
            //this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
