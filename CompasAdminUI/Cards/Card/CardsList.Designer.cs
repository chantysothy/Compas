namespace Compas.AdminUI.Cards
{
    partial class CardsList
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
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IssuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportSB = new System.Windows.Forms.ToolStripSplitButton();
            this.ExcelMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.CardType,
            this.Active,
            this.IssuedDate,
            this.UsedDate});
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 39);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(789, 456);
            this.DataGV.TabIndex = 12;
            this.DataGV.VirtualMode = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.EditSB,
            this.DeleteSB,
            this.ExportSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(789, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Code";
            this.name.HeaderText = "Код";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // CardType
            // 
            this.CardType.DataPropertyName = "CardTypeName";
            this.CardType.HeaderText = "Тип";
            this.CardType.Name = "CardType";
            this.CardType.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Акт.";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // IssuedDate
            // 
            this.IssuedDate.DataPropertyName = "IssuedDate";
            this.IssuedDate.HeaderText = "Дата видачі";
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            this.IssuedDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IssuedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UsedDate
            // 
            this.UsedDate.DataPropertyName = "UsedDate";
            this.UsedDate.HeaderText = "Дата використання";
            this.UsedDate.Name = "UsedDate";
            this.UsedDate.ReadOnly = true;
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
            this.ExcelMI.Size = new System.Drawing.Size(152, 26);
            this.ExcelMI.Text = "Excel";
            this.ExcelMI.Click += new System.EventHandler(this.ExcelMI_Click);
            // 
            // PDFMI
            // 
            this.PDFMI.Name = "PDFMI";
            this.PDFMI.Size = new System.Drawing.Size(152, 26);
            this.PDFMI.Text = "PDF";
            this.PDFMI.Click += new System.EventHandler(this.PDFMI_Click);
            // 
            // HTMLMI
            // 
            this.HTMLMI.Name = "HTMLMI";
            this.HTMLMI.Size = new System.Drawing.Size(152, 26);
            this.HTMLMI.Text = "HTML";
            this.HTMLMI.Click += new System.EventHandler(this.HTMLMI_Click);
            // 
            // CardsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CardsList";
            this.Text = "Довідник \"Картки\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton EditSB;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripButton NewSB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedDate;
        private System.Windows.Forms.ToolStripSplitButton ExportSB;
        private System.Windows.Forms.ToolStripMenuItem ExcelMI;
        private System.Windows.Forms.ToolStripMenuItem PDFMI;
        private System.Windows.Forms.ToolStripMenuItem HTMLMI;
    }
}