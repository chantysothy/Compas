namespace Compas.AdminUI.Wares.Ware
{
    partial class WareData
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
            this.label2 = new System.Windows.Forms.Label();
            this.UnitsCB = new System.Windows.Forms.ComboBox();
            this.ManufacturersCB = new System.Windows.Forms.ComboBox();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SecondaryQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.SecondaryUnitsCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.AddCodeBt = new System.Windows.Forms.Button();
            this.DeleteCodeBt = new System.Windows.Forms.Button();
            this.CodesGV = new System.Windows.Forms.DataGridView();
            this.AddComponentsCB = new System.Windows.Forms.CheckBox();
            this.OneChoiceComponentCB = new System.Windows.Forms.CheckBox();
            this.TimeLimitNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddUnit2Bt = new System.Windows.Forms.Button();
            this.AddUnitBt = new System.Windows.Forms.Button();
            this.AddCategoryBt = new System.Windows.Forms.Button();
            this.AddManufacturerBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.AddImageBt = new System.Windows.Forms.Button();
            this.ImagePB = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryQuantityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLimitNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Назва:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Од. вимірювання:";
            // 
            // UnitsCB
            // 
            this.UnitsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsCB.FormattingEnabled = true;
            this.UnitsCB.Location = new System.Drawing.Point(139, 62);
            this.UnitsCB.Margin = new System.Windows.Forms.Padding(4);
            this.UnitsCB.Name = "UnitsCB";
            this.UnitsCB.Size = new System.Drawing.Size(117, 24);
            this.UnitsCB.TabIndex = 1;
            // 
            // ManufacturersCB
            // 
            this.ManufacturersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufacturersCB.FormattingEnabled = true;
            this.ManufacturersCB.Location = new System.Drawing.Point(139, 396);
            this.ManufacturersCB.Margin = new System.Windows.Forms.Padding(4);
            this.ManufacturersCB.Name = "ManufacturersCB";
            this.ManufacturersCB.Size = new System.Drawing.Size(416, 24);
            this.ManufacturersCB.TabIndex = 5;
            this.ManufacturersCB.SelectedIndexChanged += new System.EventHandler(this.ManufacturersCB_SelectedIndexChanged);
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesCB.DropDownWidth = 700;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(139, 144);
            this.CategoriesCB.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(416, 24);
            this.CategoriesCB.TabIndex = 3;
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Виробник:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Категорія:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(139, 18);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(416, 23);
            this.NameTB.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Втор. од. вим.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Втор. к-ть:";
            // 
            // SecondaryQuantityNUD
            // 
            this.SecondaryQuantityNUD.DecimalPlaces = 2;
            this.SecondaryQuantityNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SecondaryQuantityNUD.Location = new System.Drawing.Point(431, 102);
            this.SecondaryQuantityNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SecondaryQuantityNUD.Name = "SecondaryQuantityNUD";
            this.SecondaryQuantityNUD.Size = new System.Drawing.Size(120, 23);
            this.SecondaryQuantityNUD.TabIndex = 33;
            this.SecondaryQuantityNUD.ThousandsSeparator = true;
            // 
            // SecondaryUnitsCB
            // 
            this.SecondaryUnitsCB.FormattingEnabled = true;
            this.SecondaryUnitsCB.Location = new System.Drawing.Point(431, 62);
            this.SecondaryUnitsCB.Name = "SecondaryUnitsCB";
            this.SecondaryUnitsCB.Size = new System.Drawing.Size(121, 24);
            this.SecondaryUnitsCB.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Код одиниці:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CodeTB
            // 
            this.CodeTB.Location = new System.Drawing.Point(139, 190);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(416, 23);
            this.CodeTB.TabIndex = 4;
            this.CodeTB.TextChanged += new System.EventHandler(this.CodeTB_TextChanged);
            this.CodeTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeTB_KeyDown);
            // 
            // AddCodeBt
            // 
            this.AddCodeBt.Location = new System.Drawing.Point(561, 182);
            this.AddCodeBt.Name = "AddCodeBt";
            this.AddCodeBt.Size = new System.Drawing.Size(135, 38);
            this.AddCodeBt.TabIndex = 38;
            this.AddCodeBt.Text = "Додати код";
            this.AddCodeBt.UseVisualStyleBackColor = true;
            this.AddCodeBt.Click += new System.EventHandler(this.AddCodeBt_Click);
            // 
            // DeleteCodeBt
            // 
            this.DeleteCodeBt.Location = new System.Drawing.Point(562, 226);
            this.DeleteCodeBt.Name = "DeleteCodeBt";
            this.DeleteCodeBt.Size = new System.Drawing.Size(135, 38);
            this.DeleteCodeBt.TabIndex = 39;
            this.DeleteCodeBt.Text = "Видалити код";
            this.DeleteCodeBt.UseVisualStyleBackColor = true;
            this.DeleteCodeBt.Click += new System.EventHandler(this.DeleteCodeBt_Click);
            // 
            // CodesGV
            // 
            this.CodesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CodesGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CodesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CodesGV.ColumnHeadersVisible = false;
            this.CodesGV.Location = new System.Drawing.Point(139, 226);
            this.CodesGV.MultiSelect = false;
            this.CodesGV.Name = "CodesGV";
            this.CodesGV.ReadOnly = true;
            this.CodesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CodesGV.Size = new System.Drawing.Size(416, 94);
            this.CodesGV.TabIndex = 41;
            this.CodesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CodesGV_CellContentClick);
            // 
            // AddComponentsCB
            // 
            this.AddComponentsCB.AutoSize = true;
            this.AddComponentsCB.Location = new System.Drawing.Point(139, 338);
            this.AddComponentsCB.Name = "AddComponentsCB";
            this.AddComponentsCB.Size = new System.Drawing.Size(224, 21);
            this.AddComponentsCB.TabIndex = 42;
            this.AddComponentsCB.Text = "Вказати складові компоненти";
            this.AddComponentsCB.UseVisualStyleBackColor = true;
            this.AddComponentsCB.CheckedChanged += new System.EventHandler(this.AddComponentsCB_CheckedChanged);
            // 
            // OneChoiceComponentCB
            // 
            this.OneChoiceComponentCB.AutoSize = true;
            this.OneChoiceComponentCB.Location = new System.Drawing.Point(139, 365);
            this.OneChoiceComponentCB.Name = "OneChoiceComponentCB";
            this.OneChoiceComponentCB.Size = new System.Drawing.Size(327, 21);
            this.OneChoiceComponentCB.TabIndex = 43;
            this.OneChoiceComponentCB.Text = "Складові компоненти для одиничного вибору";
            this.OneChoiceComponentCB.UseVisualStyleBackColor = true;
            this.OneChoiceComponentCB.CheckedChanged += new System.EventHandler(this.OneChoiceComponentCB_CheckedChanged);
            // 
            // TimeLimitNUD
            // 
            this.TimeLimitNUD.Location = new System.Drawing.Point(139, 102);
            this.TimeLimitNUD.Name = "TimeLimitNUD";
            this.TimeLimitNUD.Size = new System.Drawing.Size(120, 23);
            this.TimeLimitNUD.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Тривалість:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "хвилин";
            // 
            // AddUnit2Bt
            // 
            this.AddUnit2Bt.FlatAppearance.BorderSize = 0;
            this.AddUnit2Bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUnit2Bt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUnit2Bt.Image = global::Compas.AdminUI.Properties.Resources.add_16x161;
            this.AddUnit2Bt.Location = new System.Drawing.Point(556, 62);
            this.AddUnit2Bt.Margin = new System.Windows.Forms.Padding(4);
            this.AddUnit2Bt.Name = "AddUnit2Bt";
            this.AddUnit2Bt.Size = new System.Drawing.Size(37, 28);
            this.AddUnit2Bt.TabIndex = 30;
            this.AddUnit2Bt.UseVisualStyleBackColor = true;
            this.AddUnit2Bt.Click += new System.EventHandler(this.AddUnitBt_Click);
            // 
            // AddUnitBt
            // 
            this.AddUnitBt.FlatAppearance.BorderSize = 0;
            this.AddUnitBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUnitBt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUnitBt.Image = global::Compas.AdminUI.Properties.Resources.add_16x161;
            this.AddUnitBt.Location = new System.Drawing.Point(264, 62);
            this.AddUnitBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddUnitBt.Name = "AddUnitBt";
            this.AddUnitBt.Size = new System.Drawing.Size(37, 28);
            this.AddUnitBt.TabIndex = 26;
            this.AddUnitBt.UseVisualStyleBackColor = true;
            this.AddUnitBt.Click += new System.EventHandler(this.AddUnitBt_Click);
            // 
            // AddCategoryBt
            // 
            this.AddCategoryBt.FlatAppearance.BorderSize = 0;
            this.AddCategoryBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryBt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryBt.Image = global::Compas.AdminUI.Properties.Resources.add_16x161;
            this.AddCategoryBt.Location = new System.Drawing.Point(563, 140);
            this.AddCategoryBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCategoryBt.Name = "AddCategoryBt";
            this.AddCategoryBt.Size = new System.Drawing.Size(37, 28);
            this.AddCategoryBt.TabIndex = 25;
            this.AddCategoryBt.UseVisualStyleBackColor = true;
            this.AddCategoryBt.Click += new System.EventHandler(this.AddCategoryBt_Click);
            // 
            // AddManufacturerBt
            // 
            this.AddManufacturerBt.FlatAppearance.BorderSize = 0;
            this.AddManufacturerBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddManufacturerBt.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddManufacturerBt.Image = global::Compas.AdminUI.Properties.Resources.add_16x161;
            this.AddManufacturerBt.Location = new System.Drawing.Point(563, 396);
            this.AddManufacturerBt.Margin = new System.Windows.Forms.Padding(4);
            this.AddManufacturerBt.Name = "AddManufacturerBt";
            this.AddManufacturerBt.Size = new System.Drawing.Size(37, 28);
            this.AddManufacturerBt.TabIndex = 24;
            this.AddManufacturerBt.UseVisualStyleBackColor = true;
            this.AddManufacturerBt.Click += new System.EventHandler(this.AddManufacturerBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(357, 609);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(140, 50);
            this.CancelBt.TabIndex = 17;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(178, 609);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(140, 50);
            this.SaveBt.TabIndex = 6;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(289, 428);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(135, 32);
            this.DeleteBt.TabIndex = 50;
            this.DeleteBt.Text = "Видалити зображення";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Зображення:";
            // 
            // AddImageBt
            // 
            this.AddImageBt.Location = new System.Drawing.Point(139, 428);
            this.AddImageBt.Name = "AddImageBt";
            this.AddImageBt.Size = new System.Drawing.Size(135, 32);
            this.AddImageBt.TabIndex = 48;
            this.AddImageBt.Text = "Додати зображення";
            this.AddImageBt.UseVisualStyleBackColor = true;
            this.AddImageBt.Click += new System.EventHandler(this.AddImageBt_Click);
            // 
            // ImagePB
            // 
            this.ImagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePB.Location = new System.Drawing.Point(139, 466);
            this.ImagePB.Name = "ImagePB";
            this.ImagePB.Size = new System.Drawing.Size(128, 128);
            this.ImagePB.TabIndex = 47;
            this.ImagePB.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WareData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 672);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddImageBt);
            this.Controls.Add(this.ImagePB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeLimitNUD);
            this.Controls.Add(this.OneChoiceComponentCB);
            this.Controls.Add(this.AddComponentsCB);
            this.Controls.Add(this.CodesGV);
            this.Controls.Add(this.DeleteCodeBt);
            this.Controls.Add(this.AddCodeBt);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SecondaryUnitsCB);
            this.Controls.Add(this.SecondaryQuantityNUD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddUnit2Bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.AddUnitBt);
            this.Controls.Add(this.AddCategoryBt);
            this.Controls.Add(this.AddManufacturerBt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoriesCB);
            this.Controls.Add(this.ManufacturersCB);
            this.Controls.Add(this.UnitsCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WareData";
            this.Text = "Дані номенклатурної одиниці";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.Load += new System.EventHandler(this.WareData_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WareData_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryQuantityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLimitNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UnitsCB;
        private System.Windows.Forms.ComboBox ManufacturersCB;
        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddManufacturerBt;
        private System.Windows.Forms.Button AddCategoryBt;
        private System.Windows.Forms.Button AddUnitBt;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button AddUnit2Bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SecondaryQuantityNUD;
        private System.Windows.Forms.ComboBox SecondaryUnitsCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Button AddCodeBt;
        private System.Windows.Forms.Button DeleteCodeBt;
        private System.Windows.Forms.DataGridView CodesGV;
        private System.Windows.Forms.CheckBox AddComponentsCB;
        private System.Windows.Forms.CheckBox OneChoiceComponentCB;
        private System.Windows.Forms.NumericUpDown TimeLimitNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddImageBt;
        private System.Windows.Forms.PictureBox ImagePB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}