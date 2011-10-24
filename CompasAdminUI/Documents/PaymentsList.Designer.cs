namespace Compas.AdminUI.Documents
{
    partial class PaymentsList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.ExportSB = new System.Windows.Forms.ToolStripSplitButton();
            this.ExcelMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StructureObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SummaryDataGV = new System.Windows.Forms.DataGridView();
            this.FullEmployeeNameG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeNameG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumaG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.OkBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteSB,
            this.ExportSB});
            this.toolStrip1.Location = new System.Drawing.Point(273, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(516, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
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
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Suma,
            this.DocumentNumber,
            this.CheckNumber,
            this.CurrencyName,
            this.PaymentTypeName,
            this.StructureObjectName,
            this.FullEmployeeName,
            this.Login,
            this.Date,
            this.CreatedDate,
            this.CardCode});
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(276, 43);
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(510, 317);
            this.DataGV.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Suma
            // 
            this.Suma.DataPropertyName = "Suma";
            this.Suma.HeaderText = "Сума";
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.DataPropertyName = "DocumentNumber";
            this.DocumentNumber.HeaderText = "№Докум.";
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.ReadOnly = true;
            // 
            // CheckNumber
            // 
            this.CheckNumber.DataPropertyName = "CheckNumber";
            this.CheckNumber.HeaderText = "№ Чека";
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.ReadOnly = true;
            // 
            // CurrencyName
            // 
            this.CurrencyName.DataPropertyName = "CurrencyName";
            this.CurrencyName.HeaderText = "Валюта";
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.ReadOnly = true;
            // 
            // PaymentTypeName
            // 
            this.PaymentTypeName.DataPropertyName = "PaymentTypeName";
            this.PaymentTypeName.HeaderText = "Тип оплати";
            this.PaymentTypeName.Name = "PaymentTypeName";
            this.PaymentTypeName.ReadOnly = true;
            // 
            // StructureObjectName
            // 
            this.StructureObjectName.DataPropertyName = "StructureObjectName";
            this.StructureObjectName.HeaderText = "Місце оплати";
            this.StructureObjectName.Name = "StructureObjectName";
            this.StructureObjectName.ReadOnly = true;
            // 
            // FullEmployeeName
            // 
            this.FullEmployeeName.DataPropertyName = "FullEmployeeName";
            this.FullEmployeeName.HeaderText = "Провів";
            this.FullEmployeeName.Name = "FullEmployeeName";
            this.FullEmployeeName.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Логін";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата оплати";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Дата проведення";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // CardCode
            // 
            this.CardCode.DataPropertyName = "CardCode";
            this.CardCode.HeaderText = "Картка";
            this.CardCode.Name = "CardCode";
            this.CardCode.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SummaryDataGV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataGV, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 495);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // SummaryDataGV
            // 
            this.SummaryDataGV.AllowUserToAddRows = false;
            this.SummaryDataGV.AllowUserToDeleteRows = false;
            this.SummaryDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullEmployeeNameG,
            this.PaymentTypeNameG,
            this.CountG,
            this.SumaG});
            this.SummaryDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryDataGV.Location = new System.Drawing.Point(276, 366);
            this.SummaryDataGV.Name = "SummaryDataGV";
            this.SummaryDataGV.ReadOnly = true;
            this.SummaryDataGV.Size = new System.Drawing.Size(510, 127);
            this.SummaryDataGV.TabIndex = 16;
            // 
            // FullEmployeeNameG
            // 
            this.FullEmployeeNameG.DataPropertyName = "FullEmployeeName";
            this.FullEmployeeNameG.HeaderText = "Працівник";
            this.FullEmployeeNameG.Name = "FullEmployeeNameG";
            this.FullEmployeeNameG.ReadOnly = true;
            // 
            // PaymentTypeNameG
            // 
            this.PaymentTypeNameG.DataPropertyName = "PaymentTypeName";
            this.PaymentTypeNameG.HeaderText = "Тип оплати";
            this.PaymentTypeNameG.Name = "PaymentTypeNameG";
            this.PaymentTypeNameG.ReadOnly = true;
            // 
            // CountG
            // 
            this.CountG.DataPropertyName = "Count";
            this.CountG.HeaderText = "К-ть";
            this.CountG.Name = "CountG";
            this.CountG.ReadOnly = true;
            // 
            // SumaG
            // 
            this.SumaG.DataPropertyName = "Suma";
            this.SumaG.HeaderText = "Сума";
            this.SumaG.Name = "SumaG";
            this.SumaG.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.EndDateDTP, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.StartDateDTP, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.OkBt, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 100);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EndDateDTP.Location = new System.Drawing.Point(73, 35);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(185, 20);
            this.EndDateDTP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "З:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "По(не вкл):";
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartDateDTP.Location = new System.Drawing.Point(73, 5);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(185, 20);
            this.StartDateDTP.TabIndex = 2;
            // 
            // OkBt
            // 
            this.OkBt.Location = new System.Drawing.Point(73, 63);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(90, 23);
            this.OkBt.TabIndex = 4;
            this.OkBt.Text = "Застосувати";
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фільтр платежів";
            // 
            // PaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaymentsList";
            this.Text = "Оплати по документам";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.ToolStripSplitButton ExportSB;
        private System.Windows.Forms.ToolStripMenuItem ExcelMI;
        private System.Windows.Forms.ToolStripMenuItem PDFMI;
        private System.Windows.Forms.ToolStripMenuItem HTMLMI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView SummaryDataGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullEmployeeNameG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeNameG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumaG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StructureObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardCode;
        private System.Windows.Forms.Label label3;
    }
}