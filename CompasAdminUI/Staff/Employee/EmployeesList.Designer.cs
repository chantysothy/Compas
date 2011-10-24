namespace Compas.AdminUI.Staff.Employee
{
    partial class EmployeesList
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
            this.ActionsStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RolesLB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PositionsLB = new System.Windows.Forms.ListBox();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.RefreshSB = new System.Windows.Forms.ToolStripButton();
            this.AccessSB = new System.Windows.Forms.ToolStripButton();
            this.RolesSB = new System.Windows.Forms.ToolStripButton();
            this.PositionSB = new System.Windows.Forms.ToolStripButton();
            this.SalaryBt = new System.Windows.Forms.ToolStripButton();
            this.ActionsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionsStrip
            // 
            this.ActionsStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ActionsStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ActionsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.DeleteSB,
            this.EditSB,
            this.RefreshSB,
            this.toolStripSeparator1,
            this.AccessSB,
            this.RolesSB,
            this.PositionSB,
            this.SalaryBt});
            this.ActionsStrip.Location = new System.Drawing.Point(0, 0);
            this.ActionsStrip.Name = "ActionsStrip";
            this.ActionsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ActionsStrip.Size = new System.Drawing.Size(1007, 39);
            this.ActionsStrip.TabIndex = 14;
            this.ActionsStrip.Text = "toolStrip1";
            this.ActionsStrip.Paint += new System.Windows.Forms.PaintEventHandler(this.ActionsStrip_Paint);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StructureObjectsCB);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 478);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 15;
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.DisplayMember = "Name";
            this.StructureObjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(52, 3);
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(404, 21);
            this.StructureObjectsCB.TabIndex = 3;
            this.StructureObjectsCB.ValueMember = "ID";
            this.StructureObjectsCB.SelectedIndexChanged += new System.EventHandler(this.StructureObjectsCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Об\'єкт:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DataGV);
            this.splitContainer2.Size = new System.Drawing.Size(1007, 401);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RolesLB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ролі";
            // 
            // RolesLB
            // 
            this.RolesLB.BackColor = System.Drawing.SystemColors.Control;
            this.RolesLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RolesLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesLB.FormattingEnabled = true;
            this.RolesLB.Location = new System.Drawing.Point(3, 16);
            this.RolesLB.Name = "RolesLB";
            this.RolesLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RolesLB.Size = new System.Drawing.Size(300, 63);
            this.RolesLB.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PositionsLB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Посади";
            // 
            // PositionsLB
            // 
            this.PositionsLB.BackColor = System.Drawing.SystemColors.Control;
            this.PositionsLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionsLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsLB.FormattingEnabled = true;
            this.PositionsLB.Location = new System.Drawing.Point(3, 16);
            this.PositionsLB.Name = "PositionsLB";
            this.PositionsLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PositionsLB.Size = new System.Drawing.Size(300, 63);
            this.PositionsLB.TabIndex = 2;
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.City,
            this.Street,
            this.Building,
            this.Flat,
            this.Phone,
            this.MobPhone,
            this.HireDate,
            this.ReleaseDate});
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(697, 401);
            this.DataGV.TabIndex = 19;
            this.DataGV.VirtualMode = true;
            this.DataGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_RowEnter);
            this.DataGV.SelectionChanged += new System.EventHandler(this.DataGV_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Прізвище";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ім\'я";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "По-батькові";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Місто";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Вулиця";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // Building
            // 
            this.Building.DataPropertyName = "Building";
            this.Building.HeaderText = "Будинок";
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            // 
            // Flat
            // 
            this.Flat.DataPropertyName = "Flat";
            this.Flat.HeaderText = "Квартира";
            this.Flat.Name = "Flat";
            this.Flat.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // MobPhone
            // 
            this.MobPhone.DataPropertyName = "MobPhone";
            this.MobPhone.HeaderText = "Моб. телефон";
            this.MobPhone.Name = "MobPhone";
            this.MobPhone.ReadOnly = true;
            // 
            // HireDate
            // 
            this.HireDate.DataPropertyName = "HireDate";
            this.HireDate.HeaderText = "Прийнято";
            this.HireDate.Name = "HireDate";
            this.HireDate.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Звільнено";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            // 
            // NewSB
            // 
            this.NewSB.Image = global::Compas.AdminUI.Properties.Resources.user1_add;
            this.NewSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewSB.Name = "NewSB";
            this.NewSB.Size = new System.Drawing.Size(99, 36);
            this.NewSB.Text = "Додати";
            this.NewSB.Click += new System.EventHandler(this.NewSB_Click);
            // 
            // DeleteSB
            // 
            this.DeleteSB.Image = global::Compas.AdminUI.Properties.Resources.user1_delete;
            this.DeleteSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteSB.Name = "DeleteSB";
            this.DeleteSB.Size = new System.Drawing.Size(114, 36);
            this.DeleteSB.Text = "Видалити";
            this.DeleteSB.Click += new System.EventHandler(this.DeleteSB_Click);
            // 
            // EditSB
            // 
            this.EditSB.Image = global::Compas.AdminUI.Properties.Resources.user1_edit;
            this.EditSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSB.Name = "EditSB";
            this.EditSB.Size = new System.Drawing.Size(126, 36);
            this.EditSB.Text = "Редагувати";
            this.EditSB.Click += new System.EventHandler(this.EditSB_Click);
            // 
            // RefreshSB
            // 
            this.RefreshSB.Image = global::Compas.AdminUI.Properties.Resources.arrow_refresh;
            this.RefreshSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshSB.Name = "RefreshSB";
            this.RefreshSB.Size = new System.Drawing.Size(109, 36);
            this.RefreshSB.Text = "Оновити";
            this.RefreshSB.Click += new System.EventHandler(this.RefreshSB_Click);
            // 
            // AccessSB
            // 
            this.AccessSB.Image = global::Compas.AdminUI.Properties.Resources.password;
            this.AccessSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AccessSB.Name = "AccessSB";
            this.AccessSB.Size = new System.Drawing.Size(97, 36);
            this.AccessSB.Text = "Доступ";
            this.AccessSB.Click += new System.EventHandler(this.AccessSB_Click);
            // 
            // RolesSB
            // 
            this.RolesSB.Image = global::Compas.AdminUI.Properties.Resources.users;
            this.RolesSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RolesSB.Name = "RolesSB";
            this.RolesSB.Size = new System.Drawing.Size(162, 36);
            this.RolesSB.Text = "Ролі працівника";
            this.RolesSB.Click += new System.EventHandler(this.RolesSB_Click);
            // 
            // PositionSB
            // 
            this.PositionSB.Image = global::Compas.AdminUI.Properties.Resources.applications_engineering;
            this.PositionSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PositionSB.Name = "PositionSB";
            this.PositionSB.Size = new System.Drawing.Size(98, 36);
            this.PositionSB.Text = "Посада";
            this.PositionSB.Click += new System.EventHandler(this.PositionSB_Click);
            // 
            // SalaryBt
            // 
            this.SalaryBt.Image = global::Compas.AdminUI.Properties.Resources.money_dollar;
            this.SalaryBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalaryBt.Name = "SalaryBt";
            this.SalaryBt.Size = new System.Drawing.Size(112, 36);
            this.SalaryBt.Text = "Зарплата";
            this.SalaryBt.Click += new System.EventHandler(this.SalaryBt_Click);
            // 
            // EmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ActionsStrip);
            this.Name = "EmployeesList";
            this.Text = "Працівники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesList_FormClosed);
            this.ActionsStrip.ResumeLayout(false);
            this.ActionsStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ActionsStrip;
        private System.Windows.Forms.ToolStripButton NewSB;
        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.ToolStripButton EditSB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StructureObjectsCB;
        private System.Windows.Forms.ToolStripButton RefreshSB;
        private System.Windows.Forms.ToolStripButton AccessSB;
        private System.Windows.Forms.ToolStripButton RolesSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PositionSB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox PositionsLB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox RolesLB;
        private System.Windows.Forms.ToolStripButton SalaryBt;

    }
}