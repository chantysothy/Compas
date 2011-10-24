namespace Compas.AdminUI.Staff
{
    partial class EmployeeSalaryData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeL = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaleSumNUD = new System.Windows.Forms.NumericUpDown();
            this.ExtraPercentNUD = new System.Windows.Forms.NumericUpDown();
            this.SalaryNUD = new System.Windows.Forms.NumericUpDown();
            this.SumL = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSumNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraPercentNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сума продаж:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Процент від продажу:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(127, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Працівник:";
            // 
            // EmployeeL
            // 
            this.EmployeeL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeL.AutoSize = true;
            this.EmployeeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeL.Location = new System.Drawing.Point(223, 10);
            this.EmployeeL.Name = "EmployeeL";
            this.EmployeeL.Size = new System.Drawing.Size(118, 20);
            this.EmployeeL.TabIndex = 22;
            this.EmployeeL.Text = "Employee Data";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(155, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Відділ:";
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StructureObjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructureObjectsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(223, 86);
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(232, 28);
            this.StructureObjectsCB.TabIndex = 50;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.15789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.84211F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.SumL, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.SalaryNUD, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ExtraPercentNUD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SaleSumNUD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StructureObjectsCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 285);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(154, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Оклад:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(166, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Сума:";
            // 
            // SaleSumNUD
            // 
            this.SaleSumNUD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaleSumNUD.DecimalPlaces = 2;
            this.SaleSumNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleSumNUD.Location = new System.Drawing.Point(223, 127);
            this.SaleSumNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.SaleSumNUD.Name = "SaleSumNUD";
            this.SaleSumNUD.Size = new System.Drawing.Size(120, 26);
            this.SaleSumNUD.TabIndex = 55;
            this.SaleSumNUD.ValueChanged += new System.EventHandler(this.SaleSumNUD_ValueChanged);
            this.SaleSumNUD.Enter += new System.EventHandler(this.SaleSumNUD_Enter);
            // 
            // ExtraPercentNUD
            // 
            this.ExtraPercentNUD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExtraPercentNUD.DecimalPlaces = 2;
            this.ExtraPercentNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtraPercentNUD.Location = new System.Drawing.Point(223, 167);
            this.ExtraPercentNUD.Name = "ExtraPercentNUD";
            this.ExtraPercentNUD.Size = new System.Drawing.Size(120, 26);
            this.ExtraPercentNUD.TabIndex = 56;
            this.ExtraPercentNUD.ValueChanged += new System.EventHandler(this.ExtraPercentNUD_ValueChanged);
            // 
            // SalaryNUD
            // 
            this.SalaryNUD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalaryNUD.DecimalPlaces = 2;
            this.SalaryNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryNUD.Location = new System.Drawing.Point(223, 207);
            this.SalaryNUD.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.SalaryNUD.Name = "SalaryNUD";
            this.SalaryNUD.Size = new System.Drawing.Size(120, 26);
            this.SalaryNUD.TabIndex = 57;
            this.SalaryNUD.ValueChanged += new System.EventHandler(this.SalaryNUD_ValueChanged);
            // 
            // SumL
            // 
            this.SumL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SumL.AutoSize = true;
            this.SumL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumL.Location = new System.Drawing.Point(223, 252);
            this.SumL.Name = "SumL";
            this.SumL.Size = new System.Drawing.Size(47, 20);
            this.SumL.TabIndex = 58;
            this.SumL.Text = "Сума";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM.yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Місяць:";
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(258, 303);
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
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(99, 303);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // EmployeeSalaryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Name = "EmployeeSalaryData";
            this.Text = "Дані про зарплату працівника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSumNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraPercentNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmployeeL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox StructureObjectsCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown SaleSumNUD;
        private System.Windows.Forms.NumericUpDown ExtraPercentNUD;
        private System.Windows.Forms.NumericUpDown SalaryNUD;
        private System.Windows.Forms.Label SumL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}