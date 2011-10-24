namespace Compas.AdminUI.Wares.Price
{
    partial class PricesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.RefreshSB = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.universalFilter1 = new Compas.UC.UniversalFilter();
            this.OkBt = new System.Windows.Forms.Button();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarePriceGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowDiscount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PurshasePriceForUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePriceForUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarePriceGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.DataGVContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.EditSB,
            this.DeleteSB,
            this.RefreshSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1018, 39);
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
            // RefreshSB
            // 
            this.RefreshSB.Image = global::Compas.AdminUI.Properties.Resources.refresh_blue;
            this.RefreshSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshSB.Name = "RefreshSB";
            this.RefreshSB.Size = new System.Drawing.Size(109, 36);
            this.RefreshSB.Text = "Оновити";
            this.RefreshSB.Click += new System.EventHandler(this.RefreshSB_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.universalFilter1);
            this.splitContainer1.Panel1.Controls.Add(this.OkBt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DataGV);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 456);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 14;
            // 
            // universalFilter1
            // 
            this.universalFilter1.Location = new System.Drawing.Point(13, 4);
            this.universalFilter1.Name = "universalFilter1";
            this.universalFilter1.Size = new System.Drawing.Size(311, 257);
            this.universalFilter1.TabIndex = 0;
            // 
            // OkBt
            // 
            this.OkBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.OkBt.Location = new System.Drawing.Point(123, 267);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(189, 41);
            this.OkBt.TabIndex = 24;
            this.OkBt.Text = "Застосувати фільтр";
            this.OkBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.WareName,
            this.CategoryID,
            this.CategoryName,
            this.WarePriceGroupID,
            this.DocumentID,
            this.AllowDiscount,
            this.PurshasePriceForUnit,
            this.SalePriceForUnit,
            this.Active,
            this.UnitID,
            this.UnitName,
            this.ManufacturerID,
            this.ManufacturerName,
            this.WarePriceGroupName});
            this.DataGV.ContextMenuStrip = this.DataGVContextMenu;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(681, 456);
            this.DataGV.TabIndex = 13;
            this.DataGV.VirtualMode = true;
            this.DataGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGV_CellMouseClick);
            this.DataGV.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGV_CellMouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // WareName
            // 
            this.WareName.DataPropertyName = "WareName";
            this.WareName.HeaderText = "Номенклатурна одиниця";
            this.WareName.Name = "WareName";
            this.WareName.ReadOnly = true;
            this.WareName.Width = 200;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Категорія";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // WarePriceGroupID
            // 
            this.WarePriceGroupID.DataPropertyName = "WarePriceGroupID";
            this.WarePriceGroupID.HeaderText = "WarePriceGroupID";
            this.WarePriceGroupID.Name = "WarePriceGroupID";
            this.WarePriceGroupID.ReadOnly = true;
            this.WarePriceGroupID.Visible = false;
            // 
            // DocumentID
            // 
            this.DocumentID.DataPropertyName = "DocumentID";
            this.DocumentID.HeaderText = "DocumentID";
            this.DocumentID.Name = "DocumentID";
            this.DocumentID.ReadOnly = true;
            this.DocumentID.Visible = false;
            // 
            // AllowDiscount
            // 
            this.AllowDiscount.DataPropertyName = "AllowDiscount";
            this.AllowDiscount.HeaderText = "Знижка дозв.";
            this.AllowDiscount.Name = "AllowDiscount";
            this.AllowDiscount.ReadOnly = true;
            this.AllowDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AllowDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AllowDiscount.Width = 30;
            // 
            // PurshasePriceForUnit
            // 
            this.PurshasePriceForUnit.DataPropertyName = "PurshasePriceForUnit";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.PurshasePriceForUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.PurshasePriceForUnit.HeaderText = "Закупка";
            this.PurshasePriceForUnit.Name = "PurshasePriceForUnit";
            this.PurshasePriceForUnit.ReadOnly = true;
            this.PurshasePriceForUnit.Width = 50;
            // 
            // SalePriceForUnit
            // 
            this.SalePriceForUnit.DataPropertyName = "SalePriceForUnit";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.SalePriceForUnit.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalePriceForUnit.HeaderText = "Продаж";
            this.SalePriceForUnit.Name = "SalePriceForUnit";
            this.SalePriceForUnit.ReadOnly = true;
            this.SalePriceForUnit.Width = 50;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Акт.";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 30;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Один. вим.";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 30;
            // 
            // ManufacturerID
            // 
            this.ManufacturerID.DataPropertyName = "ManufacturerID";
            this.ManufacturerID.HeaderText = "ManufacturerID";
            this.ManufacturerID.Name = "ManufacturerID";
            this.ManufacturerID.ReadOnly = true;
            this.ManufacturerID.Visible = false;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.DataPropertyName = "ManufacturerName";
            this.ManufacturerName.HeaderText = "Виробник";
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.ReadOnly = true;
            // 
            // WarePriceGroupName
            // 
            this.WarePriceGroupName.DataPropertyName = "WarePriceGroupName";
            this.WarePriceGroupName.HeaderText = "Група цін";
            this.WarePriceGroupName.Name = "WarePriceGroupName";
            this.WarePriceGroupName.ReadOnly = true;
            // 
            // DataGVContextMenu
            // 
            this.DataGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.RefreshToolStripMenuItem});
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
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.RefreshToolStripMenuItem.Text = "Оновити";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshSB_Click);
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
            // PricesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 495);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PricesList";
            this.Text = "Прайси";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.DataGVContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.ContextMenuStrip DataGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarePriceGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurshasePriceForUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePriceForUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarePriceGroupName;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.ToolStripButton RefreshSB;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private UC.UniversalFilter universalFilter1;
    }
}