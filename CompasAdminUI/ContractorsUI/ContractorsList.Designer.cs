namespace Compas.AdminUI.ContractorsUI
{
    partial class ContractorsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.RefreshSB = new System.Windows.Forms.ToolStripButton();
            this.ExportSB = new System.Windows.Forms.ToolStripSplitButton();
            this.ExcelMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLMI = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ContractorTypesDDL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PersonCB = new System.Windows.Forms.ComboBox();
            this.MiddleNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FlatTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuildingTB = new System.Windows.Forms.TextBox();
            this.StreetTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractorTypesList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.RefreshSB,
            this.ExportSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(612, 39);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(880, 495);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 14;
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
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DataGV);
            this.splitContainer2.Size = new System.Drawing.Size(612, 495);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтр";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Типи:";
            // 
            // ContractorTypesDDL
            // 
            this.ContractorTypesDDL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContractorTypesDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContractorTypesDDL.FormattingEnabled = true;
            this.ContractorTypesDDL.Location = new System.Drawing.Point(107, 244);
            this.ContractorTypesDDL.Name = "ContractorTypesDDL";
            this.ContractorTypesDDL.Size = new System.Drawing.Size(148, 21);
            this.ContractorTypesDDL.TabIndex = 38;
            this.ContractorTypesDDL.SelectedIndexChanged += new System.EventHandler(this.ContractorTypesDDL_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Особа:";
            // 
            // PersonCB
            // 
            this.PersonCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PersonCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonCB.FormattingEnabled = true;
            this.PersonCB.Items.AddRange(new object[] {
            "- всі -",
            "Фізичні",
            "Юридичні"});
            this.PersonCB.Location = new System.Drawing.Point(107, 214);
            this.PersonCB.Name = "PersonCB";
            this.PersonCB.Size = new System.Drawing.Size(148, 21);
            this.PersonCB.TabIndex = 36;
            this.PersonCB.SelectedIndexChanged += new System.EventHandler(this.PersonCB_SelectedIndexChanged);
            // 
            // MiddleNameTB
            // 
            this.MiddleNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MiddleNameTB.Location = new System.Drawing.Point(107, 65);
            this.MiddleNameTB.Name = "MiddleNameTB";
            this.MiddleNameTB.Size = new System.Drawing.Size(148, 20);
            this.MiddleNameTB.TabIndex = 35;
            this.MiddleNameTB.TextChanged += new System.EventHandler(this.MiddleNameTB_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "По-батькові:";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstNameTB.Location = new System.Drawing.Point(107, 35);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(148, 20);
            this.FirstNameTB.TabIndex = 33;
            this.FirstNameTB.TextChanged += new System.EventHandler(this.FirstNameTB_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ім\'я:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FlatTB
            // 
            this.FlatTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FlatTB.Location = new System.Drawing.Point(107, 185);
            this.FlatTB.Name = "FlatTB";
            this.FlatTB.Size = new System.Drawing.Size(71, 20);
            this.FlatTB.TabIndex = 28;
            this.FlatTB.TextChanged += new System.EventHandler(this.FlatTB_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "кв:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Вулиця:";
            // 
            // BuildingTB
            // 
            this.BuildingTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BuildingTB.Location = new System.Drawing.Point(107, 155);
            this.BuildingTB.Name = "BuildingTB";
            this.BuildingTB.Size = new System.Drawing.Size(71, 20);
            this.BuildingTB.TabIndex = 25;
            this.BuildingTB.TextChanged += new System.EventHandler(this.BuildingTB_TextChanged);
            // 
            // StreetTB
            // 
            this.StreetTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StreetTB.Location = new System.Drawing.Point(107, 125);
            this.StreetTB.Name = "StreetTB";
            this.StreetTB.Size = new System.Drawing.Size(148, 20);
            this.StreetTB.TabIndex = 24;
            this.StreetTB.TextChanged += new System.EventHandler(this.StreetTB_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "буд:";
            // 
            // CityTB
            // 
            this.CityTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CityTB.Location = new System.Drawing.Point(107, 95);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(148, 20);
            this.CityTB.TabIndex = 22;
            this.CityTB.TextChanged += new System.EventHandler(this.CityTB_TextChanged);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastNameTB.Location = new System.Drawing.Point(107, 5);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(148, 20);
            this.LastNameTB.TabIndex = 21;
            this.LastNameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Місто:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Прізвище/назва:";
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.ContractorTypesList,
            this.Person,
            this.FullAddress,
            this.Phones,
            this.Sex});
            this.DataGV.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(612, 451);
            this.DataGV.TabIndex = 13;
            this.DataGV.VirtualMode = true;
            this.DataGV.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGV_CellMouseDown);
            this.DataGV.DoubleClick += new System.EventHandler(this.DataGV_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Повне ім\'я(назва)";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 300;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Прізвище";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ім\'я";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Visible = false;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "По-батькові";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            this.MiddleName.Visible = false;
            // 
            // ContractorTypesList
            // 
            this.ContractorTypesList.DataPropertyName = "ContractorTypesList";
            this.ContractorTypesList.HeaderText = "Типи";
            this.ContractorTypesList.Name = "ContractorTypesList";
            this.ContractorTypesList.ReadOnly = true;
            // 
            // Person
            // 
            this.Person.DataPropertyName = "PersonStringValue";
            this.Person.HeaderText = "Особа";
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            // 
            // FullAddress
            // 
            this.FullAddress.DataPropertyName = "FullAddress";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FullAddress.DefaultCellStyle = dataGridViewCellStyle5;
            this.FullAddress.HeaderText = "Адреса";
            this.FullAddress.Name = "FullAddress";
            this.FullAddress.ReadOnly = true;
            this.FullAddress.Width = 300;
            // 
            // Phones
            // 
            this.Phones.DataPropertyName = "Phones";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Phones.DefaultCellStyle = dataGridViewCellStyle6;
            this.Phones.HeaderText = "Телефони";
            this.Phones.Name = "Phones";
            this.Phones.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "SexValue";
            this.Sex.HeaderText = "Стать";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.оновитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 92);
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
            // оновитиToolStripMenuItem
            // 
            this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.оновитиToolStripMenuItem.Text = "Оновити";
            this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.RefreshSB_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.31008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.68992F));
            this.tableLayoutPanel1.Controls.Add(this.ContractorTypesDDL, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PersonCB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FlatTB, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.MiddleNameTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LastNameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BuildingTB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.StreetTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CityTB, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContractorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ContractorsList";
            this.Text = "Довідник \"Контрагенти\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton EditSB;
        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripButton NewSB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FlatTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuildingTB;
        private System.Windows.Forms.TextBox StreetTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PersonCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MiddleNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ContractorTypesDDL;
        private System.Windows.Forms.ToolStripButton RefreshSB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractorTypesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSplitButton ExportSB;
        private System.Windows.Forms.ToolStripMenuItem ExcelMI;
        private System.Windows.Forms.ToolStripMenuItem PDFMI;
        private System.Windows.Forms.ToolStripMenuItem HTMLMI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}