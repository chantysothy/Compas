namespace Compas.AdminUI.Cars
{
    partial class CarData
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddModelBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModelsDataGV = new System.Windows.Forms.DataGridView();
            this.ModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrandsDataGV = new System.Windows.Forms.DataGridView();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddBrandBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsDataGV)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandsDataGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumberTB
            // 
            this.NumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTB.Location = new System.Drawing.Point(103, 14);
            this.NumberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(410, 26);
            this.NumberTB.TabIndex = 14;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(363, 16);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(150, 50);
            this.CancelBt.TabIndex = 17;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(161, 16);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddModelBt
            // 
            this.AddModelBt.FlatAppearance.BorderSize = 0;
            this.AddModelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddModelBt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddModelBt.Image = global::Compas.AdminUI.Properties.Resources.add_16x161;
            this.AddModelBt.Location = new System.Drawing.Point(4, 4);
            this.AddModelBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddModelBt.Name = "AddModelBt";
            this.AddModelBt.Size = new System.Drawing.Size(37, 28);
            this.AddModelBt.TabIndex = 32;
            this.AddModelBt.UseVisualStyleBackColor = true;
            this.AddModelBt.Click += new System.EventHandler(this.AddModelBt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBt);
            this.panel1.Controls.Add(this.SaveBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 78);
            this.panel1.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModelsDataGV);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 254);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Модель";
            // 
            // ModelsDataGV
            // 
            this.ModelsDataGV.AllowUserToAddRows = false;
            this.ModelsDataGV.AllowUserToDeleteRows = false;
            this.ModelsDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelsDataGV.ColumnHeadersVisible = false;
            this.ModelsDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelID,
            this.ModelImage,
            this.dataGridViewTextBoxColumn1});
            this.ModelsDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelsDataGV.Location = new System.Drawing.Point(3, 22);
            this.ModelsDataGV.MultiSelect = false;
            this.ModelsDataGV.Name = "ModelsDataGV";
            this.ModelsDataGV.ReadOnly = true;
            this.ModelsDataGV.RowTemplate.Height = 100;
            this.ModelsDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModelsDataGV.Size = new System.Drawing.Size(402, 229);
            this.ModelsDataGV.TabIndex = 13;
            this.ModelsDataGV.VirtualMode = true;
            // 
            // ModelID
            // 
            this.ModelID.DataPropertyName = "ID";
            this.ModelID.HeaderText = "ModelID";
            this.ModelID.Name = "ModelID";
            this.ModelID.ReadOnly = true;
            this.ModelID.Visible = false;
            // 
            // ModelImage
            // 
            this.ModelImage.DataPropertyName = "Image";
            this.ModelImage.FillWeight = 120F;
            this.ModelImage.HeaderText = "Зображення";
            this.ModelImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ModelImage.MinimumWidth = 120;
            this.ModelImage.Name = "ModelImage";
            this.ModelImage.ReadOnly = true;
            this.ModelImage.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AddModelBt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(405, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 229);
            this.panel5.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(864, 254);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrandsDataGV);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Марка";
            // 
            // BrandsDataGV
            // 
            this.BrandsDataGV.AllowUserToAddRows = false;
            this.BrandsDataGV.AllowUserToDeleteRows = false;
            this.BrandsDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrandsDataGV.ColumnHeadersVisible = false;
            this.BrandsDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandID,
            this.BrandImage,
            this.name});
            this.BrandsDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandsDataGV.Location = new System.Drawing.Point(3, 22);
            this.BrandsDataGV.MultiSelect = false;
            this.BrandsDataGV.Name = "BrandsDataGV";
            this.BrandsDataGV.ReadOnly = true;
            this.BrandsDataGV.RowTemplate.Height = 60;
            this.BrandsDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BrandsDataGV.Size = new System.Drawing.Size(346, 229);
            this.BrandsDataGV.TabIndex = 13;
            this.BrandsDataGV.VirtualMode = true;
            this.BrandsDataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BrandsDataGV_CellClick);
            this.BrandsDataGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BrandsDataGV_RowEnter);
            this.BrandsDataGV.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.BrandsDataGV_RowStateChanged);
            this.BrandsDataGV.SelectionChanged += new System.EventHandler(this.BrandsDataGV_SelectionChanged);
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "ID";
            this.BrandID.HeaderText = "BrandID";
            this.BrandID.Name = "BrandID";
            this.BrandID.ReadOnly = true;
            this.BrandID.Visible = false;
            // 
            // BrandImage
            // 
            this.BrandImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandImage.DataPropertyName = "Image";
            this.BrandImage.HeaderText = "Зображення";
            this.BrandImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.BrandImage.MinimumWidth = 60;
            this.BrandImage.Name = "BrandImage";
            this.BrandImage.ReadOnly = true;
            this.BrandImage.Width = 60;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Назва";
            this.name.MinimumWidth = 120;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AddBrandBt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(349, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 229);
            this.panel4.TabIndex = 0;
            // 
            // AddBrandBt
            // 
            this.AddBrandBt.FlatAppearance.BorderSize = 0;
            this.AddBrandBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBrandBt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBrandBt.Image = global::Compas.AdminUI.Properties.Resources.add_16x161;
            this.AddBrandBt.Location = new System.Drawing.Point(4, 4);
            this.AddBrandBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddBrandBt.Name = "AddBrandBt";
            this.AddBrandBt.Size = new System.Drawing.Size(37, 28);
            this.AddBrandBt.TabIndex = 31;
            this.AddBrandBt.UseVisualStyleBackColor = true;
            this.AddBrandBt.Click += new System.EventHandler(this.AddBrandBt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CategoriesCB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NumberTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 104);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 254);
            this.panel3.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Категорія:";
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(103, 45);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(410, 28);
            this.CategoriesCB.TabIndex = 27;
            // 
            // CarData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarData";
            this.Text = "Дані автомобіля";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModelsDataGV)).EndInit();
            this.panel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BrandsDataGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddModelBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView ModelsDataGV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BrandsDataGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddBrandBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewImageColumn BrandImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelID;
        private System.Windows.Forms.DataGridViewImageColumn ModelImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoriesCB;
    }
}