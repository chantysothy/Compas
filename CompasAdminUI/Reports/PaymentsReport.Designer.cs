namespace Compas.AdminUI.Reports
{
    partial class PaymentsReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBt = new System.Windows.Forms.Button();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DocumentTypesCB = new System.Windows.Forms.ComboBox();
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.PaymentTypesCB = new System.Windows.Forms.ComboBox();
            this.ViewPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(745, 453);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "(не включаючи)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Тип докум:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "По:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата опл.:";
            // 
            // OkBt
            // 
            this.OkBt.Location = new System.Drawing.Point(74, 123);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(156, 23);
            this.OkBt.TabIndex = 10;
            this.OkBt.Text = "Вибрати";
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EndDateDTP.Location = new System.Drawing.Point(270, 5);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(200, 20);
            this.EndDateDTP.TabIndex = 9;
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartDateDTP.Location = new System.Drawing.Point(74, 5);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(156, 20);
            this.StartDateDTP.TabIndex = 8;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PaymentsDataSet";
            reportDataSource1.Value = this.ViewPaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Compas.AdminUI.Reports.RDLC.PaymentsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(745, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.57851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.42149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartDateDTP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.EndDateDTP, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DocumentTypesCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StructureObjectsCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PaymentTypesCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OkBt, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(606, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Об\'єкт:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Тип оплати:";
            // 
            // DocumentTypesCB
            // 
            this.DocumentTypesCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DocumentTypesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypesCB.FormattingEnabled = true;
            this.DocumentTypesCB.Location = new System.Drawing.Point(74, 34);
            this.DocumentTypesCB.Name = "DocumentTypesCB";
            this.DocumentTypesCB.Size = new System.Drawing.Size(156, 21);
            this.DocumentTypesCB.TabIndex = 18;
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StructureObjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(74, 64);
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(156, 21);
            this.StructureObjectsCB.TabIndex = 19;
            // 
            // PaymentTypesCB
            // 
            this.PaymentTypesCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaymentTypesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentTypesCB.FormattingEnabled = true;
            this.PaymentTypesCB.Location = new System.Drawing.Point(74, 94);
            this.PaymentTypesCB.Name = "PaymentTypesCB";
            this.PaymentTypesCB.Size = new System.Drawing.Size(156, 21);
            this.PaymentTypesCB.TabIndex = 20;
            // 
            // ViewPaymentBindingSource
            // 
            this.ViewPaymentBindingSource.DataSource = typeof(Compas.Model.ViewPayment);
            // 
            // PaymentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 453);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PaymentsReport";
            this.Text = "Звіт по платежам";
            this.Load += new System.EventHandler(this.PaymentsReport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewPaymentBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DocumentTypesCB;
        private System.Windows.Forms.ComboBox StructureObjectsCB;
        private System.Windows.Forms.ComboBox PaymentTypesCB;
    }
}