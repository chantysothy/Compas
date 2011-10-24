namespace Compas.AdminUI.Documents
{
    partial class DocumentsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.documentFilterUC1 = new Compas.UC.DocumentFilterUC();
            this.universalFilter1 = new Compas.UC.UniversalFilter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterpriseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaryL = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyFilterBt = new System.Windows.Forms.Button();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.RefreshSB = new System.Windows.Forms.ToolStripButton();
            this.ExportSB = new System.Windows.Forms.ToolStripSplitButton();
            this.ExcelMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentsSB = new System.Windows.Forms.ToolStripButton();
            this.AddPaymentSB = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentFilterUC1
            // 
            this.documentFilterUC1.Location = new System.Drawing.Point(41, 19);
            this.documentFilterUC1.Name = "documentFilterUC1";
            this.documentFilterUC1.Size = new System.Drawing.Size(228, 90);
            this.documentFilterUC1.TabIndex = 2;
            // 
            // universalFilter1
            // 
            this.universalFilter1.Location = new System.Drawing.Point(3, 106);
            this.universalFilter1.Name = "universalFilter1";
            this.universalFilter1.Size = new System.Drawing.Size(311, 282);
            this.universalFilter1.TabIndex = 3;
            this.universalFilter1.Load += new System.EventHandler(this.universalFilter1_Load);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DataGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SummaryL);
            this.splitContainer1.Size = new System.Drawing.Size(706, 546);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 0;
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DocumentTypeName,
            this.Number,
            this.Date,
            this.DocumentSum,
            this.PaySum,
            this.CurrencyName,
            this.EnterpriseName,
            this.Address,
            this.EmployeeFullName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(706, 489);
            this.DataGV.TabIndex = 13;
            this.DataGV.VirtualMode = true;
            this.DataGV.DoubleClick += new System.EventHandler(this.DataGV_DoubleClick);
            this.DataGV.ParentChanged += new System.EventHandler(this.DataGV_ParentChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DocumentTypeName
            // 
            this.DocumentTypeName.DataPropertyName = "DocumentTypeName";
            this.DocumentTypeName.HeaderText = "Тип";
            this.DocumentTypeName.Name = "DocumentTypeName";
            this.DocumentTypeName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DocumentSum
            // 
            this.DocumentSum.DataPropertyName = "DocumentSum";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.DocumentSum.DefaultCellStyle = dataGridViewCellStyle4;
            this.DocumentSum.HeaderText = "Вартість";
            this.DocumentSum.Name = "DocumentSum";
            this.DocumentSum.ReadOnly = true;
            // 
            // PaySum
            // 
            this.PaySum.DataPropertyName = "PaySum";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.PaySum.DefaultCellStyle = dataGridViewCellStyle5;
            this.PaySum.HeaderText = "Оплачено";
            this.PaySum.Name = "PaySum";
            this.PaySum.ReadOnly = true;
            // 
            // CurrencyName
            // 
            this.CurrencyName.DataPropertyName = "CurrencyName";
            this.CurrencyName.HeaderText = "Валюта";
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.ReadOnly = true;
            // 
            // EnterpriseName
            // 
            this.EnterpriseName.DataPropertyName = "EnterpriseName";
            this.EnterpriseName.HeaderText = "Підприємство";
            this.EnterpriseName.Name = "EnterpriseName";
            this.EnterpriseName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адреса по документу";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.EmployeeFullName.HeaderText = "Створив";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // SummaryL
            // 
            this.SummaryL.AutoSize = true;
            this.SummaryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaryL.Location = new System.Drawing.Point(27, 20);
            this.SummaryL.Name = "SummaryL";
            this.SummaryL.Size = new System.Drawing.Size(108, 20);
            this.SummaryL.TabIndex = 0;
            this.SummaryL.Text = "Сумарні дані:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.EditSB,
            this.DeleteSB,
            this.RefreshSB,
            this.ExportSB,
            this.PaymentsSB,
            this.AddPaymentSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1029, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 39);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.ApplyFilterBt);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1029, 546);
            this.splitContainer2.SplitterDistance = 319;
            this.splitContainer2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.documentFilterUC1);
            this.groupBox1.Controls.Add(this.universalFilter1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтр документів";
            // 
            // ApplyFilterBt
            // 
            this.ApplyFilterBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.ApplyFilterBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFilterBt.Location = new System.Drawing.Point(118, 417);
            this.ApplyFilterBt.Name = "ApplyFilterBt";
            this.ApplyFilterBt.Size = new System.Drawing.Size(151, 63);
            this.ApplyFilterBt.TabIndex = 1;
            this.ApplyFilterBt.Text = "Застосувати фільтр";
            this.ApplyFilterBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyFilterBt.UseVisualStyleBackColor = true;
            this.ApplyFilterBt.Click += new System.EventHandler(this.ApplyFilterBt_Click);
            // 
            // NewSB
            // 
            this.NewSB.Image = global::Compas.AdminUI.Properties.Resources.add2_;
            this.NewSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewSB.Name = "NewSB";
            this.NewSB.Size = new System.Drawing.Size(99, 36);
            this.NewSB.Text = "Додати";
            this.NewSB.Click += new System.EventHandler(this.NewSB_Click);
            // 
            // EditSB
            // 
            this.EditSB.Image = global::Compas.AdminUI.Properties.Resources.edit;
            this.EditSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSB.Name = "EditSB";
            this.EditSB.Size = new System.Drawing.Size(126, 36);
            this.EditSB.Text = "Редагувати";
            this.EditSB.Click += new System.EventHandler(this.EditSB_Click);
            // 
            // DeleteSB
            // 
            this.DeleteSB.Image = global::Compas.AdminUI.Properties.Resources.delete;
            this.DeleteSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteSB.Name = "DeleteSB";
            this.DeleteSB.Size = new System.Drawing.Size(114, 36);
            this.DeleteSB.Text = "Видалити";
            this.DeleteSB.Click += new System.EventHandler(this.DeleteSB_Click);
            // 
            // RefreshSB
            // 
            this.RefreshSB.Image = global::Compas.AdminUI.Properties.Resources.refresh_blue;
            this.RefreshSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshSB.Name = "RefreshSB";
            this.RefreshSB.Size = new System.Drawing.Size(109, 36);
            this.RefreshSB.Text = "Оновити";
            this.RefreshSB.Click += new System.EventHandler(this.RefreshSB_Click);
            // 
            // ExportSB
            // 
            this.ExportSB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelMI,
            this.PDFMI,
            this.HTMLMI});
            this.ExportSB.Image = global::Compas.AdminUI.Properties.Resources.export;
            this.ExportSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportSB.Name = "ExportSB";
            this.ExportSB.Size = new System.Drawing.Size(115, 36);
            this.ExportSB.Text = "Експорт";
            this.ExportSB.ButtonClick += new System.EventHandler(this.ExportSB_ButtonClick);
            // 
            // ExcelMI
            // 
            this.ExcelMI.Name = "ExcelMI";
            this.ExcelMI.Size = new System.Drawing.Size(121, 26);
            this.ExcelMI.Text = "Excel";
            this.ExcelMI.Click += new System.EventHandler(this.ExcelMI_Click);
            // 
            // PDFMI
            // 
            this.PDFMI.Name = "PDFMI";
            this.PDFMI.Size = new System.Drawing.Size(121, 26);
            this.PDFMI.Text = "PDF";
            this.PDFMI.Click += new System.EventHandler(this.PDFMI_Click);
            // 
            // HTMLMI
            // 
            this.HTMLMI.Name = "HTMLMI";
            this.HTMLMI.Size = new System.Drawing.Size(121, 26);
            this.HTMLMI.Text = "HTML";
            this.HTMLMI.Click += new System.EventHandler(this.HTMLMI_Click);
            // 
            // PaymentsSB
            // 
            this.PaymentsSB.Image = global::Compas.AdminUI.Properties.Resources.money_dollar;
            this.PaymentsSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaymentsSB.Name = "PaymentsSB";
            this.PaymentsSB.Size = new System.Drawing.Size(99, 36);
            this.PaymentsSB.Text = "Оплати";
            this.PaymentsSB.Click += new System.EventHandler(this.PaymentsSB_Click);
            // 
            // AddPaymentSB
            // 
            this.AddPaymentSB.Image = global::Compas.AdminUI.Properties.Resources.money_add;
            this.AddPaymentSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddPaymentSB.Name = "AddPaymentSB";
            this.AddPaymentSB.Size = new System.Drawing.Size(115, 36);
            this.AddPaymentSB.Text = "Оплатити";
            this.AddPaymentSB.Click += new System.EventHandler(this.AddPaymentSB_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Compas.AdminUI.Properties.Resources.file_edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Compas.AdminUI.Properties.Resources.file_delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DocumentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 585);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DocumentsList";
            this.Text = "Перелік документів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.Load += new System.EventHandler(this.DocumentsList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button ApplyFilterBt;
        private UC.DocumentFilterUC documentFilterUC1;
        private UC.UniversalFilter universalFilter1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton NewSB;
        private System.Windows.Forms.ToolStripButton EditSB;
        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.ToolStripButton RefreshSB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton ExportSB;
        private System.Windows.Forms.ToolStripMenuItem ExcelMI;
        private System.Windows.Forms.ToolStripMenuItem PDFMI;
        private System.Windows.Forms.ToolStripMenuItem HTMLMI;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label SummaryL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterpriseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.ToolStripButton PaymentsSB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton AddPaymentSB;
    }
}