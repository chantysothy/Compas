namespace Compas.AdminUI.Reports
{
    partial class WaresDetalisationReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewWaresDetalisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKSDBDataSet = new Compas.AdminUI.MKSDBDataSet();
            this.viewWaresDetalisationTableAdapter = new Compas.AdminUI.MKSDBDataSetTableAdapters.ViewWaresDetalisationTableAdapter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.OkBt = new System.Windows.Forms.Button();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputRB = new System.Windows.Forms.RadioButton();
            this.InputRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewWaresDetalisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewWaresDetalisationBindingSource
            // 
            this.viewWaresDetalisationBindingSource.DataMember = "ViewWaresDetalisation";
            this.viewWaresDetalisationBindingSource.DataSource = this.mKSDBDataSet;
            // 
            // mKSDBDataSet
            // 
            this.mKSDBDataSet.DataSetName = "MKSDBDataSet";
            this.mKSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewWaresDetalisationTableAdapter
            // 
            this.viewWaresDetalisationTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.OkBt);
            this.splitContainer2.Panel1.Controls.Add(this.EndDateDTP);
            this.splitContainer2.Panel1.Controls.Add(this.StartDateDTP);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer2.Size = new System.Drawing.Size(686, 486);
            this.splitContainer2.SplitterDistance = 72;
            this.splitContainer2.TabIndex = 2;
            // 
            // OkBt
            // 
            this.OkBt.Location = new System.Drawing.Point(284, 40);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(75, 23);
            this.OkBt.TabIndex = 2;
            this.OkBt.Text = "Вибрати";
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Location = new System.Drawing.Point(284, 11);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(200, 20);
            this.EndDateDTP.TabIndex = 1;
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Location = new System.Drawing.Point(42, 12);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(200, 20);
            this.StartDateDTP.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "WareDetalisationDataset";
            reportDataSource4.Value = this.viewWaresDetalisationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Compas.AdminUI.Reports.RDLC.WaresDetalisationReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "З:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "По:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputRB);
            this.panel1.Controls.Add(this.OutputRB);
            this.panel1.Location = new System.Drawing.Point(42, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 26);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип:";
            // 
            // OutputRB
            // 
            this.OutputRB.AutoSize = true;
            this.OutputRB.Checked = true;
            this.OutputRB.Location = new System.Drawing.Point(4, 4);
            this.OutputRB.Name = "OutputRB";
            this.OutputRB.Size = new System.Drawing.Size(57, 17);
            this.OutputRB.TabIndex = 0;
            this.OutputRB.TabStop = true;
            this.OutputRB.Text = "Розхід";
            this.OutputRB.UseVisualStyleBackColor = true;
            // 
            // InputRB
            // 
            this.InputRB.AutoSize = true;
            this.InputRB.Location = new System.Drawing.Point(67, 3);
            this.InputRB.Name = "InputRB";
            this.InputRB.Size = new System.Drawing.Size(58, 17);
            this.InputRB.TabIndex = 1;
            this.InputRB.TabStop = true;
            this.InputRB.Text = "Прихід";
            this.InputRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(не включаючи)";
            // 
            // WaresDetalisationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 486);
            this.Controls.Add(this.splitContainer2);
            this.Name = "WaresDetalisationReport";
            this.Text = "Звіт по  номенклатурі за період";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WaresDetalisationReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewWaresDetalisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKSDBDataSet)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MKSDBDataSet mKSDBDataSet;
        private System.Windows.Forms.BindingSource viewWaresDetalisationBindingSource;
        private MKSDBDataSetTableAdapters.ViewWaresDetalisationTableAdapter viewWaresDetalisationTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton InputRB;
        private System.Windows.Forms.RadioButton OutputRB;
        private System.Windows.Forms.Label label4;
    }
}