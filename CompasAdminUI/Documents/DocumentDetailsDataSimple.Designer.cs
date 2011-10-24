namespace Compas.AdminUI.Documents
{
    partial class DocumentDetailsDataSimple
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.categoriesUC1 = new Compas.UC.CategoriesUC();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CategoriesDownBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoriesUpBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numPad1 = new Compas.UC.NumPad();
            this.WaresGV = new System.Windows.Forms.DataGridView();
            this.WareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.WaresDownBt = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.WaresUpBt = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TotalPriceL = new System.Windows.Forms.Label();
            this.ShowNumPadBt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DiscountForUnitNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UnitPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.SecondaryGroupGB = new System.Windows.Forms.GroupBox();
            this.SecondaryUnitQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnitQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.SaveBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.MessageL = new System.Windows.Forms.Label();
            this.AddAndCloseBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaresGV)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountForUnitNUD)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceNUD)).BeginInit();
            this.SecondaryGroupGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryUnitQuantityNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(997, 725);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.categoriesUC1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 537);
            this.panel4.TabIndex = 3;
            // 
            // categoriesUC1
            // 
            this.categoriesUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriesUC1.Location = new System.Drawing.Point(0, 0);
            this.categoriesUC1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.categoriesUC1.Name = "categoriesUC1";
            this.categoriesUC1.Size = new System.Drawing.Size(303, 537);
            this.categoriesUC1.TabIndex = 0;
            this.categoriesUC1.SelectedCategoryChanged += new System.EventHandler(this.categoriesUC1_SelectedCategoryChanged);
            this.categoriesUC1.Click += new System.EventHandler(this.categoriesUC1_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.CategoriesDownBt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 663);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 62);
            this.panel3.TabIndex = 2;
            // 
            // CategoriesDownBt
            // 
            this.CategoriesDownBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CategoriesDownBt.Image = global::Compas.AdminUI.Properties.Resources.navigate_down;
            this.CategoriesDownBt.Location = new System.Drawing.Point(0, 0);
            this.CategoriesDownBt.Name = "CategoriesDownBt";
            this.CategoriesDownBt.Size = new System.Drawing.Size(303, 62);
            this.CategoriesDownBt.TabIndex = 2;
            this.CategoriesDownBt.UseVisualStyleBackColor = true;
            this.CategoriesDownBt.Click += new System.EventHandler(this.CategoriesDownBt_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.CategoriesUpBt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 62);
            this.panel2.TabIndex = 1;
            // 
            // CategoriesUpBt
            // 
            this.CategoriesUpBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesUpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesUpBt.Image = global::Compas.AdminUI.Properties.Resources.navigate_up;
            this.CategoriesUpBt.Location = new System.Drawing.Point(0, 0);
            this.CategoriesUpBt.Name = "CategoriesUpBt";
            this.CategoriesUpBt.Size = new System.Drawing.Size(303, 62);
            this.CategoriesUpBt.TabIndex = 1;
            this.CategoriesUpBt.UseVisualStyleBackColor = true;
            this.CategoriesUpBt.Click += new System.EventHandler(this.CategoriesUpBt_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            this.splitContainer2.Panel1.Controls.Add(this.panel6);
            this.splitContainer2.Panel1.Controls.Add(this.panel7);
            this.splitContainer2.Panel1.Controls.Add(this.panel8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AddAndCloseBt);
            this.splitContainer2.Panel2.Controls.Add(this.MessageL);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel2.Controls.Add(this.ShowNumPadBt);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.SecondaryGroupGB);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.SaveBt);
            this.splitContainer2.Panel2.Controls.Add(this.CancelBt);
            this.splitContainer2.Size = new System.Drawing.Size(690, 725);
            this.splitContainer2.SplitterDistance = 446;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numPad1);
            this.panel5.Controls.Add(this.WaresGV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 568);
            this.panel5.TabIndex = 7;
            // 
            // numPad1
            // 
            this.numPad1.AutoSize = true;
            this.numPad1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.numPad1.Location = new System.Drawing.Point(102, 125);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(229, 305);
            this.numPad1.TabIndex = 0;
            this.numPad1.Visible = false;
            // 
            // WaresGV
            // 
            this.WaresGV.AllowUserToAddRows = false;
            this.WaresGV.AllowUserToDeleteRows = false;
            this.WaresGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaresGV.ColumnHeadersVisible = false;
            this.WaresGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WareID,
            this.WareName,
            this.Price,
            this.UnitName});
            this.WaresGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaresGV.Location = new System.Drawing.Point(0, 0);
            this.WaresGV.Name = "WaresGV";
            this.WaresGV.ReadOnly = true;
            this.WaresGV.RowHeadersVisible = false;
            this.WaresGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaresGV.RowTemplate.Height = 40;
            this.WaresGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WaresGV.Size = new System.Drawing.Size(446, 568);
            this.WaresGV.TabIndex = 0;
            this.WaresGV.SelectionChanged += new System.EventHandler(this.WaresGV_SelectionChanged);
            // 
            // WareID
            // 
            this.WareID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareID.DataPropertyName = "ID";
            this.WareID.HeaderText = "WareID";
            this.WareID.Name = "WareID";
            this.WareID.ReadOnly = true;
            this.WareID.Visible = false;
            // 
            // WareName
            // 
            this.WareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareName.DataPropertyName = "Name";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WareName.DefaultCellStyle = dataGridViewCellStyle4;
            this.WareName.HeaderText = "Назва";
            this.WareName.Name = "WareName";
            this.WareName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Ціна";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "UnitName";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.WaresDownBt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 663);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 62);
            this.panel6.TabIndex = 6;
            // 
            // WaresDownBt
            // 
            this.WaresDownBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WaresDownBt.Image = global::Compas.AdminUI.Properties.Resources.navigate_down;
            this.WaresDownBt.Location = new System.Drawing.Point(0, 0);
            this.WaresDownBt.Name = "WaresDownBt";
            this.WaresDownBt.Size = new System.Drawing.Size(446, 62);
            this.WaresDownBt.TabIndex = 1;
            this.WaresDownBt.UseVisualStyleBackColor = true;
            this.WaresDownBt.Click += new System.EventHandler(this.WaresDownBt_Click);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.WaresUpBt);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(446, 62);
            this.panel7.TabIndex = 4;
            // 
            // WaresUpBt
            // 
            this.WaresUpBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.WaresUpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaresUpBt.Image = global::Compas.AdminUI.Properties.Resources.navigate_up;
            this.WaresUpBt.Location = new System.Drawing.Point(0, 0);
            this.WaresUpBt.Name = "WaresUpBt";
            this.WaresUpBt.Size = new System.Drawing.Size(446, 62);
            this.WaresUpBt.TabIndex = 0;
            this.WaresUpBt.UseVisualStyleBackColor = true;
            this.WaresUpBt.Click += new System.EventHandler(this.WaresUpBt_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(446, 33);
            this.panel8.TabIndex = 5;
            this.panel8.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TotalPriceL);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(0, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 67);
            this.groupBox5.TabIndex = 81;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Загальна вартість";
            // 
            // TotalPriceL
            // 
            this.TotalPriceL.AutoSize = true;
            this.TotalPriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPriceL.Location = new System.Drawing.Point(6, 22);
            this.TotalPriceL.Name = "TotalPriceL";
            this.TotalPriceL.Size = new System.Drawing.Size(29, 31);
            this.TotalPriceL.TabIndex = 0;
            this.TotalPriceL.Text = "0";
            // 
            // ShowNumPadBt
            // 
            this.ShowNumPadBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowNumPadBt.Image = global::Compas.AdminUI.Properties.Resources.keyboard__48_;
            this.ShowNumPadBt.Location = new System.Drawing.Point(27, 364);
            this.ShowNumPadBt.Margin = new System.Windows.Forms.Padding(4);
            this.ShowNumPadBt.Name = "ShowNumPadBt";
            this.ShowNumPadBt.Size = new System.Drawing.Size(200, 62);
            this.ShowNumPadBt.TabIndex = 80;
            this.ShowNumPadBt.Text = "Клавіатура";
            this.ShowNumPadBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowNumPadBt.UseVisualStyleBackColor = true;
            this.ShowNumPadBt.Click += new System.EventHandler(this.ShowNumPadBt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DiscountForUnitNUD);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(0, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 67);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Знижка на одиницю";
            // 
            // DiscountForUnitNUD
            // 
            this.DiscountForUnitNUD.DecimalPlaces = 2;
            this.DiscountForUnitNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountForUnitNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountForUnitNUD.Location = new System.Drawing.Point(3, 22);
            this.DiscountForUnitNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.DiscountForUnitNUD.Name = "DiscountForUnitNUD";
            this.DiscountForUnitNUD.Size = new System.Drawing.Size(234, 38);
            this.DiscountForUnitNUD.TabIndex = 0;
            this.DiscountForUnitNUD.ValueChanged += new System.EventHandler(this.DiscountForUnitNUD_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UnitPriceNUD);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(0, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 67);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ціна за одиницю";
            // 
            // UnitPriceNUD
            // 
            this.UnitPriceNUD.DecimalPlaces = 2;
            this.UnitPriceNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitPriceNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitPriceNUD.Location = new System.Drawing.Point(3, 22);
            this.UnitPriceNUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.UnitPriceNUD.Name = "UnitPriceNUD";
            this.UnitPriceNUD.Size = new System.Drawing.Size(234, 38);
            this.UnitPriceNUD.TabIndex = 0;
            this.UnitPriceNUD.ValueChanged += new System.EventHandler(this.UnitPriceNUD_ValueChanged_1);
            // 
            // SecondaryGroupGB
            // 
            this.SecondaryGroupGB.Controls.Add(this.SecondaryUnitQuantityNUD);
            this.SecondaryGroupGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondaryGroupGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondaryGroupGB.Location = new System.Drawing.Point(0, 64);
            this.SecondaryGroupGB.Name = "SecondaryGroupGB";
            this.SecondaryGroupGB.Size = new System.Drawing.Size(240, 67);
            this.SecondaryGroupGB.TabIndex = 77;
            this.SecondaryGroupGB.TabStop = false;
            this.SecondaryGroupGB.Text = "К-ть одиниць(втор)";
            // 
            // SecondaryUnitQuantityNUD
            // 
            this.SecondaryUnitQuantityNUD.DecimalPlaces = 2;
            this.SecondaryUnitQuantityNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondaryUnitQuantityNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondaryUnitQuantityNUD.Location = new System.Drawing.Point(3, 22);
            this.SecondaryUnitQuantityNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.SecondaryUnitQuantityNUD.Name = "SecondaryUnitQuantityNUD";
            this.SecondaryUnitQuantityNUD.Size = new System.Drawing.Size(234, 38);
            this.SecondaryUnitQuantityNUD.TabIndex = 0;
            this.SecondaryUnitQuantityNUD.ValueChanged += new System.EventHandler(this.SecondaryUnitQuantityNUD_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnitQuantityNUD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 64);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "К-ть одиниць(основна)";
            // 
            // UnitQuantityNUD
            // 
            this.UnitQuantityNUD.DecimalPlaces = 2;
            this.UnitQuantityNUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitQuantityNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitQuantityNUD.Location = new System.Drawing.Point(3, 22);
            this.UnitQuantityNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.UnitQuantityNUD.Name = "UnitQuantityNUD";
            this.UnitQuantityNUD.Size = new System.Drawing.Size(234, 38);
            this.UnitQuantityNUD.TabIndex = 0;
            this.UnitQuantityNUD.ThousandsSeparator = true;
            this.UnitQuantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnitQuantityNUD.ValueChanged += new System.EventHandler(this.UnitQuantityNUD_ValueChanged);
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBt.Location = new System.Drawing.Point(27, 463);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(200, 62);
            this.SaveBt.TabIndex = 11;
            this.SaveBt.Text = "Додати";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBt.Location = new System.Drawing.Point(27, 601);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(200, 62);
            this.CancelBt.TabIndex = 12;
            this.CancelBt.Text = "Закрити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // MessageL
            // 
            this.MessageL.AutoSize = true;
            this.MessageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageL.ForeColor = System.Drawing.Color.Green;
            this.MessageL.Location = new System.Drawing.Point(22, 430);
            this.MessageL.Name = "MessageL";
            this.MessageL.Size = new System.Drawing.Size(189, 26);
            this.MessageL.TabIndex = 82;
            this.MessageL.Text = "Оберіть одиницю";
            // 
            // AddAndCloseBt
            // 
            this.AddAndCloseBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAndCloseBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.AddAndCloseBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAndCloseBt.Location = new System.Drawing.Point(27, 531);
            this.AddAndCloseBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddAndCloseBt.Name = "AddAndCloseBt";
            this.AddAndCloseBt.Size = new System.Drawing.Size(200, 62);
            this.AddAndCloseBt.TabIndex = 83;
            this.AddAndCloseBt.Text = "Додати і закр.";
            this.AddAndCloseBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddAndCloseBt.UseVisualStyleBackColor = true;
            this.AddAndCloseBt.Click += new System.EventHandler(this.AddAndCloseBt_Click);
            // 
            // DocumentDetailsDataSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 725);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DocumentDetailsDataSimple";
            this.Text = "Додавання номенклатурної одиниці";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaresGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountForUnitNUD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceNUD)).EndInit();
            this.SecondaryGroupGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryUnitQuantityNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitQuantityNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button WaresDownBt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button WaresUpBt;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown UnitQuantityNUD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown DiscountForUnitNUD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown UnitPriceNUD;
        private System.Windows.Forms.GroupBox SecondaryGroupGB;
        private System.Windows.Forms.NumericUpDown SecondaryUnitQuantityNUD;
        private UC.NumPad numPad1;
        private System.Windows.Forms.Button CategoriesDownBt;
        private System.Windows.Forms.Button CategoriesUpBt;
        private UC.CategoriesUC categoriesUC1;
        private System.Windows.Forms.DataGridView WaresGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.Button ShowNumPadBt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label TotalPriceL;
        private System.Windows.Forms.Label MessageL;
        private System.Windows.Forms.Button AddAndCloseBt;
    }
}