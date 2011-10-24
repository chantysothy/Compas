namespace Compas.AdminUI.Documents
{
    partial class DocumentsAlternateList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ApplyFilterBt = new System.Windows.Forms.Button();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.RefreshSB = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExportSB = new System.Windows.Forms.ToolStripSplitButton();
            this.ExcelMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCategoriesLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.documentFilterUC1 = new Compas.UC.DocumentFilterUC();
            this.universalFilter1 = new Compas.UC.UniversalFilter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCategoriesLUE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.ApplyFilterBt);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGV);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(821, 540);
            this.splitContainerControl1.SplitterPosition = 335;
            this.splitContainerControl1.TabIndex = 14;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.documentFilterUC1);
            this.groupControl1.Controls.Add(this.universalFilter1);
            this.groupControl1.Controls.Add(this.ViewCategoriesLUE);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(335, 459);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Фільтр документів";
            // 
            // ApplyFilterBt
            // 
            this.ApplyFilterBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.ApplyFilterBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFilterBt.Location = new System.Drawing.Point(71, 465);
            this.ApplyFilterBt.Name = "ApplyFilterBt";
            this.ApplyFilterBt.Size = new System.Drawing.Size(151, 63);
            this.ApplyFilterBt.TabIndex = 1;
            this.ApplyFilterBt.Text = "Застосувати фільтр";
            this.ApplyFilterBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyFilterBt.UseVisualStyleBackColor = true;
            this.ApplyFilterBt.Click += new System.EventHandler(this.ApplyFilterBt_Click);
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(481, 540);
            this.DataGV.TabIndex = 13;
            this.DataGV.VirtualMode = true;
            this.DataGV.DoubleClick += new System.EventHandler(this.DataGV_DoubleClick);
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
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.EditSB,
            this.DeleteSB,
            this.RefreshSB,
            this.ExportSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(821, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
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
            // ViewCategoriesLUE
            // 
            this.ViewCategoriesLUE.Location = new System.Drawing.Point(71, 402);
            this.ViewCategoriesLUE.Name = "ViewCategoriesLUE";
            this.ViewCategoriesLUE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ViewCategoriesLUE.Properties.Appearance.Options.UseFont = true;
            this.ViewCategoriesLUE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.ViewCategoriesLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ViewCategoriesLUE.Properties.DropDownRows = 10;
            this.ViewCategoriesLUE.Properties.NullText = "[Категорія не обрана]";
            this.ViewCategoriesLUE.Size = new System.Drawing.Size(245, 26);
            this.ViewCategoriesLUE.TabIndex = 4;
            // 
            // documentFilterUC1
            // 
            this.documentFilterUC1.Location = new System.Drawing.Point(46, 25);
            this.documentFilterUC1.Name = "documentFilterUC1";
            this.documentFilterUC1.Size = new System.Drawing.Size(228, 90);
            this.documentFilterUC1.TabIndex = 2;
            // 
            // universalFilter1
            // 
            this.universalFilter1.Location = new System.Drawing.Point(5, 121);
            this.universalFilter1.Name = "universalFilter1";
            this.universalFilter1.Size = new System.Drawing.Size(311, 275);
            this.universalFilter1.TabIndex = 3;
            this.universalFilter1.Load += new System.EventHandler(this.universalFilter1_Load);
            // 
            // DocumentsAlternateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 579);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DocumentsAlternateList";
            this.Text = "Перелік документів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCategoriesLUE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.Button ApplyFilterBt;
        private DevExpress.XtraEditors.GroupControl groupControl1;
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
        private DevExpress.XtraEditors.LookUpEdit ViewCategoriesLUE;
    }
}