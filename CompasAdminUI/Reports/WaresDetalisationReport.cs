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
using Compas.Model;

namespace Compas.AdminUI.Reports
{
    public partial class WaresDetalisationReport : Form
    {

        ReportsLogic reportsLogic = new ReportsLogic(new Logic.ContextManager());
        public WaresDetalisationReport()
        {
            InitializeComponent();
            EndDateDTP.Value = DateTime.Now.AddDays(1).Date;

            //Compas.Logic.ContextManager manager = new Logic.ContextManager();
            //TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            //ConnectionInfo crConnectionInfo = manager.GetConnectionInfo();
            //TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            //ReportDocument cryRpt = (ReportDocument)crystalReportViewer1.ReportSource;
            //Tables CrTables = cryRpt.Database.Tables;

            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}
            
            
        }

        private void WaresDetalisationReport_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'mKSDBDataSet.ViewWaresDetalisation' table. You can move, or remove it, as needed.
           
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDateDTP.Value;
            DateTime? endDate = EndDateDTP.Value;
            viewWaresDetalisationBindingSource.DataSource = reportsLogic.GetWaresReport(startDate, endDate, InputRB.Checked, OutputRB.Checked);
            this.viewWaresDetalisationTableAdapter.Fill(this.mKSDBDataSet.ViewWaresDetalisation);
            //dataGridView1.DataSource = reportsLogic.GetWaresReport(startDate, endDate);
            //// TODO: This line of code loads data into the 'mKSDBDataSet.ViewWaresDetalisation' table. You can move, or remove it, as needed.
            //this.viewWaresDetalisationTableAdapter.Fill(this.mKSDBDataSet.ViewWaresDetalisation);


            ReportParameter[] parameters = new ReportParameter[1];
            if(OutputRB.Checked == true)
                parameters[0] = new ReportParameter("ReportName", "Звіт по номенклатурі за період - " + "Прихід");
            else
                parameters[0] = new ReportParameter("ReportName", "Звіт по номенклатурі за період - " + "Розхід");
            
            
            ////parameters[1] = new ReportParameter("EndDate", "1/1/2003");
            reportViewer1.LocalReport.SetParameters(parameters);

            ////reportViewer1.ShowParameterPrompts = true;
            //this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
