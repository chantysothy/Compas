namespace Compas.AdminUI.Wares.Ware
{
    partial class WaresList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaresList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.PricesSB = new System.Windows.Forms.ToolStripButton();
            this.ComponentsSB = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.DataGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ціниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.categoriesFilterUC1 = new Compas.UC.CategoriesFilterUC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.AddCategorySB = new System.Windows.Forms.ToolStripButton();
            this.EditCategorySB = new System.Windows.Forms.ToolStripButton();
            this.DeleteCategorySB = new System.Windows.Forms.ToolStripButton();
            this.RefreshCategoriesSB = new System.Windows.Forms.ToolStripButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ComponentsTV = new System.Windows.Forms.TreeView();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareCodesString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryUnitQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricesC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ComponentsC = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            this.DataGVContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
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
            this.DeleteSB,
            this.PricesSB,
            this.ComponentsSB});
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
            // PricesSB
            // 
            this.PricesSB.Image = ((System.Drawing.Image)(resources.GetObject("PricesSB.Image")));
            this.PricesSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PricesSB.Name = "PricesSB";
            this.PricesSB.Size = new System.Drawing.Size(80, 36);
            this.PricesSB.Text = "Ціни";
            this.PricesSB.Click += new System.EventHandler(this.PricesSB_Click);
            // 
            // ComponentsSB
            // 
            this.ComponentsSB.Image = global::Compas.AdminUI.Properties.Resources.puzzlered32;
            this.ComponentsSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ComponentsSB.Name = "ComponentsSB";
            this.ComponentsSB.Size = new System.Drawing.Size(135, 36);
            this.ComponentsSB.Text = "Компоненти";
            this.ComponentsSB.Click += new System.EventHandler(this.ComponentsSB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Код:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(60, 6);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(231, 20);
            this.NameTB.TabIndex = 21;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Назва:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CodeTB
            // 
            this.CodeTB.Location = new System.Drawing.Point(60, 32);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(231, 20);
            this.CodeTB.TabIndex = 24;
            this.CodeTB.TextChanged += new System.EventHandler(this.CodeTB_TextChanged);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGV);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(942, 456);
            this.splitContainerControl1.SplitterPosition = 321;
            this.splitContainerControl1.TabIndex = 26;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(321, 456);
            this.splitContainerControl2.SplitterPosition = 270;
            this.splitContainerControl2.TabIndex = 28;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.splitContainerControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(321, 270);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Фільтр";
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(2, 22);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.label1);
            this.splitContainerControl3.Panel1.Controls.Add(this.label2);
            this.splitContainerControl3.Panel1.Controls.Add(this.NameTB);
            this.splitContainerControl3.Panel1.Controls.Add(this.CodeTB);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(317, 246);
            this.splitContainerControl3.SplitterPosition = 60;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.categoriesFilterUC1);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(317, 181);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Категорії номенклатури";
            // 
            // categoriesFilterUC1
            // 
            this.categoriesFilterUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesFilterUC1.Location = new System.Drawing.Point(2, 52);
            this.categoriesFilterUC1.Name = "categoriesFilterUC1";
            this.categoriesFilterUC1.Size = new System.Drawing.Size(313, 127);
            this.categoriesFilterUC1.TabIndex = 2;
            this.categoriesFilterUC1.SelectedCategoryChanged += new System.EventHandler(this.categoriesFilterUC1_SelectedCategoryChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 30);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategorySB,
            this.EditCategorySB,
            this.DeleteCategorySB,
            this.RefreshCategoriesSB});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(313, 25);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // AddCategorySB
            // 
            this.AddCategorySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCategorySB.Image = global::Compas.AdminUI.Properties.Resources.add2_;
            this.AddCategorySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCategorySB.Name = "AddCategorySB";
            this.AddCategorySB.Size = new System.Drawing.Size(23, 22);
            this.AddCategorySB.Text = "Додати";
            this.AddCategorySB.Click += new System.EventHandler(this.AddCategorySB_Click);
            // 
            // EditCategorySB
            // 
            this.EditCategorySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditCategorySB.Image = global::Compas.AdminUI.Properties.Resources.edit;
            this.EditCategorySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCategorySB.Name = "EditCategorySB";
            this.EditCategorySB.Size = new System.Drawing.Size(23, 22);
            this.EditCategorySB.Text = "Редагувати";
            this.EditCategorySB.Click += new System.EventHandler(this.EditCategorySB_Click);
            // 
            // DeleteCategorySB
            // 
            this.DeleteCategorySB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCategorySB.Image = global::Compas.AdminUI.Properties.Resources.delete;
            this.DeleteCategorySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCategorySB.Name = "DeleteCategorySB";
            this.DeleteCategorySB.Size = new System.Drawing.Size(23, 22);
            this.DeleteCategorySB.Text = "Видалити";
            this.DeleteCategorySB.Click += new System.EventHandler(this.DeleteCategorySB_Click);
            // 
            // RefreshCategoriesSB
            // 
            this.RefreshCategoriesSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshCategoriesSB.Image = global::Compas.AdminUI.Properties.Resources.refresh_blue;
            this.RefreshCategoriesSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshCategoriesSB.Name = "RefreshCategoriesSB";
            this.RefreshCategoriesSB.Size = new System.Drawing.Size(23, 22);
            this.RefreshCategoriesSB.Text = "RefreshSB";
            this.RefreshCategoriesSB.Click += new System.EventHandler(this.RefreshCategoriesSB_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ComponentsTV);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(321, 181);
            this.groupControl3.TabIndex = 28;
            this.groupControl3.Text = "Компоненти";
            // 
            // ComponentsTV
            // 
            this.ComponentsTV.Location = new System.Drawing.Point(5, 25);
            this.ComponentsTV.Name = "ComponentsTV";
            this.ComponentsTV.Size = new System.Drawing.Size(311, 133);
            this.ComponentsTV.TabIndex = 0;
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
            this.SecondaryUnitQuantity,
            this.TimeLimit,
            this.PricesC,
            this.ComponentsC});
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
            this.DataGV.Size = new System.Drawing.Size(616, 456);
            this.DataGV.TabIndex = 15;
            this.DataGV.VirtualMode = true;
            this.DataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellClick);
            this.DataGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_RowEnter);
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
            this.Category.DataPropertyName = "WareCategoryName";
            this.Category.HeaderText = "Категорія";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // WareCodesString
            // 
            this.WareCodesString.DataPropertyName = "WareCode";
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
            // TimeLimit
            // 
            this.TimeLimit.DataPropertyName = "TimeLimit";
            this.TimeLimit.HeaderText = "Трив.";
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.ReadOnly = true;
            // 
            // PricesC
            // 
            this.PricesC.FillWeight = 30F;
            this.PricesC.HeaderText = "";
            this.PricesC.MinimumWidth = 30;
            this.PricesC.Name = "PricesC";
            this.PricesC.ReadOnly = true;
            this.PricesC.Text = "Ц";
            this.PricesC.ToolTipText = "Ціни на одиницю";
            this.PricesC.UseColumnTextForButtonValue = true;
            this.PricesC.Width = 30;
            // 
            // ComponentsC
            // 
            this.ComponentsC.FillWeight = 30F;
            this.ComponentsC.HeaderText = "";
            this.ComponentsC.MinimumWidth = 30;
            this.ComponentsC.Name = "ComponentsC";
            this.ComponentsC.ReadOnly = true;
            this.ComponentsC.Text = "К";
            this.ComponentsC.ToolTipText = "Компоненти";
            this.ComponentsC.UseColumnTextForButtonValue = true;
            this.ComponentsC.Width = 30;
            // 
            // WaresList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "WaresList";
            this.Text = "Довідник \"Номенклатура\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WaresList_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DataGVContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton PricesSB;
        private System.Windows.Forms.ToolStripMenuItem ціниToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.ToolStripButton ComponentsSB;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UC.CategoriesUC categoriesUC1;
        private System.Windows.Forms.DataGridView DataGV;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TreeView ComponentsTV;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton AddCategorySB;
        private System.Windows.Forms.ToolStripButton EditCategorySB;
        private System.Windows.Forms.ToolStripButton DeleteCategorySB;
        private System.Windows.Forms.ToolStripButton RefreshCategoriesSB;
        private UC.CategoriesFilterUC categoriesFilterUC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareCodesString;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondaryUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondaryUnitQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
        private System.Windows.Forms.DataGridViewButtonColumn PricesC;
        private System.Windows.Forms.DataGridViewButtonColumn ComponentsC;
    }
}