namespace Compas.AdminUI.Wares
{
    partial class ComponentsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.DataGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ціниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ApplyFilterBt = new System.Windows.Forms.Button();
            this.wareFilterUC1 = new Compas.UC.WareFilterUC();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareCodesString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryUnitQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.DataGVContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.EditSB,
            this.DeleteSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(942, 39);
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
            // DataGVContextMenu
            // 
            this.DataGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.ціниToolStripMenuItem});
            this.DataGVContextMenu.Name = "DataGVContextMenu";
            this.DataGVContextMenu.Size = new System.Drawing.Size(135, 92);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.NewSB_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.EditSB_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.DeleteSB_Click);
            // 
            // ціниToolStripMenuItem
            // 
            this.ціниToolStripMenuItem.Name = "ціниToolStripMenuItem";
            this.ціниToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ціниToolStripMenuItem.Text = "Ціни";
            this.ціниToolStripMenuItem.Click += new System.EventHandler(this.PricesSB_Click);
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGV);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(942, 456);
            this.splitContainerControl1.SplitterPosition = 305;
            this.splitContainerControl1.TabIndex = 14;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ApplyFilterBt);
            this.groupControl1.Controls.Add(this.wareFilterUC1);
            this.groupControl1.Controls.Add(this.NameTB);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.CodeTB);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(305, 239);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Фільтр";
            // 
            // ApplyFilterBt
            // 
            this.ApplyFilterBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.ApplyFilterBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFilterBt.Location = new System.Drawing.Point(114, 171);
            this.ApplyFilterBt.Name = "ApplyFilterBt";
            this.ApplyFilterBt.Size = new System.Drawing.Size(151, 46);
            this.ApplyFilterBt.TabIndex = 31;
            this.ApplyFilterBt.Text = "Застосувати фільтр";
            this.ApplyFilterBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyFilterBt.UseVisualStyleBackColor = true;
            // 
            // wareFilterUC1
            // 
            this.wareFilterUC1.FieldWidth = 175;
            this.wareFilterUC1.Location = new System.Drawing.Point(5, 74);
            this.wareFilterUC1.Name = "wareFilterUC1";
            this.wareFilterUC1.Size = new System.Drawing.Size(286, 91);
            this.wareFilterUC1.TabIndex = 30;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(114, 29);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(177, 20);
            this.NameTB.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Код:";
            // 
            // CodeTB
            // 
            this.CodeTB.Location = new System.Drawing.Point(114, 55);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(177, 20);
            this.CodeTB.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Назва:";
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.AllowUserToOrderColumns = true;
            this.DataGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Category,
            this.WareCodesString,
            this.name,
            this.Manufacturer,
            this.Unit,
            this.SecondaryUnitName,
            this.SecondaryUnitQuantity});
            this.DataGV.ContextMenuStrip = this.DataGVContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
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
            this.DataGV.Size = new System.Drawing.Size(632, 456);
            this.DataGV.TabIndex = 15;
            this.DataGV.VirtualMode = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "CategoryName";
            this.Category.HeaderText = "Категорія";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // WareCodesString
            // 
            this.WareCodesString.DataPropertyName = "WareCodesString";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WareCodesString.DefaultCellStyle = dataGridViewCellStyle1;
            this.WareCodesString.HeaderText = "Коди";
            this.WareCodesString.Name = "WareCodesString";
            this.WareCodesString.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "ManufacturerName";
            this.Manufacturer.HeaderText = "Виробник";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "UnitName";
            this.Unit.HeaderText = "Од. вим.";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // SecondaryUnitName
            // 
            this.SecondaryUnitName.DataPropertyName = "SecondaryUnitName";
            this.SecondaryUnitName.HeaderText = "Вт. од. вим.";
            this.SecondaryUnitName.Name = "SecondaryUnitName";
            this.SecondaryUnitName.ReadOnly = true;
            this.SecondaryUnitName.Width = 30;
            // 
            // SecondaryUnitQuantity
            // 
            this.SecondaryUnitQuantity.DataPropertyName = "SecondaryUnitQuantity";
            this.SecondaryUnitQuantity.HeaderText = "К-ть втор. од.";
            this.SecondaryUnitQuantity.Name = "SecondaryUnitQuantity";
            this.SecondaryUnitQuantity.ReadOnly = true;
            this.SecondaryUnitQuantity.Width = 30;
            // 
            // ComponentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ComponentsList";
            this.Text = "Компоненти";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DataGVContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton EditSB;
        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripButton NewSB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ContextMenuStrip DataGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ціниToolStripMenuItem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareCodesString;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondaryUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondaryUnitQuantity;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Label label1;
        private UC.WareFilterUC wareFilterUC1;
        private System.Windows.Forms.Button ApplyFilterBt;
    }
}