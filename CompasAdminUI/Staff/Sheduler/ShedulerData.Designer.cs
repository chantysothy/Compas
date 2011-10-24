namespace Compas.AdminUI.Staff.Sheduler
{
    partial class ShedulerData
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
            this.SaveBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.EndTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamsCB = new System.Windows.Forms.ComboBox();
            this.ShiftsCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.AddBt = new System.Windows.Forms.Button();
            this.RemoveBt = new System.Windows.Forms.Button();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.AvailableEmployeesLB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PositionsCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectedEmployeesLB = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(292, 417);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(468, 417);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(150, 50);
            this.CancelBt.TabIndex = 17;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Початок зміни:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Кінець зміни:";
            // 
            // StartTimeDTP
            // 
            this.StartTimeDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeDTP.Location = new System.Drawing.Point(322, 125);
            this.StartTimeDTP.Name = "StartTimeDTP";
            this.StartTimeDTP.ShowUpDown = true;
            this.StartTimeDTP.Size = new System.Drawing.Size(88, 26);
            this.StartTimeDTP.TabIndex = 20;
            // 
            // EndTimeDTP
            // 
            this.EndTimeDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeDTP.Location = new System.Drawing.Point(322, 162);
            this.EndTimeDTP.Name = "EndTimeDTP";
            this.EndTimeDTP.ShowUpDown = true;
            this.EndTimeDTP.Size = new System.Drawing.Size(88, 26);
            this.EndTimeDTP.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Зміна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Бригада:";
            // 
            // TeamsCB
            // 
            this.TeamsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsCB.FormattingEnabled = true;
            this.TeamsCB.Location = new System.Drawing.Point(110, 87);
            this.TeamsCB.Name = "TeamsCB";
            this.TeamsCB.Size = new System.Drawing.Size(300, 28);
            this.TeamsCB.TabIndex = 26;
            // 
            // ShiftsCB
            // 
            this.ShiftsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShiftsCB.FormattingEnabled = true;
            this.ShiftsCB.Location = new System.Drawing.Point(110, 50);
            this.ShiftsCB.Name = "ShiftsCB";
            this.ShiftsCB.Size = new System.Drawing.Size(300, 28);
            this.ShiftsCB.TabIndex = 28;
            this.ShiftsCB.SelectedIndexChanged += new System.EventHandler(this.ShiftsCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Відділ/підрозділ:";
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(110, 13);
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(300, 28);
            this.StructureObjectsCB.TabIndex = 30;
            this.StructureObjectsCB.SelectedIndexChanged += new System.EventHandler(this.StructureObjectsCB_SelectedIndexChanged);
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateDTP.Location = new System.Drawing.Point(110, 125);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(200, 26);
            this.StartDateDTP.TabIndex = 31;
            this.StartDateDTP.ValueChanged += new System.EventHandler(this.StartDateDTP_ValueChanged);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(110, 207);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(332, 154);
            this.DescriptionTB.TabIndex = 32;
            // 
            // AddBt
            // 
            this.AddBt.Image = global::Compas.AdminUI.Properties.Resources.forward;
            this.AddBt.Location = new System.Drawing.Point(690, 161);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(47, 50);
            this.AddBt.TabIndex = 36;
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // RemoveBt
            // 
            this.RemoveBt.Image = global::Compas.AdminUI.Properties.Resources.delete;
            this.RemoveBt.Location = new System.Drawing.Point(690, 214);
            this.RemoveBt.Name = "RemoveBt";
            this.RemoveBt.Size = new System.Drawing.Size(47, 50);
            this.RemoveBt.TabIndex = 37;
            this.RemoveBt.UseVisualStyleBackColor = true;
            this.RemoveBt.Click += new System.EventHandler(this.RemoveBt_Click);
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateDTP.Location = new System.Drawing.Point(110, 162);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(200, 26);
            this.EndDateDTP.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Нотатки:";
            // 
            // AvailableEmployeesLB
            // 
            this.AvailableEmployeesLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableEmployeesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableEmployeesLB.FormattingEnabled = true;
            this.AvailableEmployeesLB.ItemHeight = 20;
            this.AvailableEmployeesLB.Location = new System.Drawing.Point(0, 0);
            this.AvailableEmployeesLB.Name = "AvailableEmployeesLB";
            this.AvailableEmployeesLB.Size = new System.Drawing.Size(234, 334);
            this.AvailableEmployeesLB.TabIndex = 34;
            this.AvailableEmployeesLB.Enter += new System.EventHandler(this.AvailableEmployeesLB_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(448, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 389);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доступні працівники";
            // 
            // PositionsCB
            // 
            this.PositionsCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionsCB.FormattingEnabled = true;
            this.PositionsCB.Location = new System.Drawing.Point(0, 0);
            this.PositionsCB.Name = "PositionsCB";
            this.PositionsCB.Size = new System.Drawing.Size(234, 28);
            this.PositionsCB.TabIndex = 35;
            this.PositionsCB.SelectedIndexChanged += new System.EventHandler(this.PositionsCB_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectedEmployeesLB);
            this.groupBox2.Location = new System.Drawing.Point(739, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 389);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Закріплені працівники";
            // 
            // SelectedEmployeesLB
            // 
            this.SelectedEmployeesLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedEmployeesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedEmployeesLB.FormattingEnabled = true;
            this.SelectedEmployeesLB.ItemHeight = 20;
            this.SelectedEmployeesLB.Location = new System.Drawing.Point(3, 16);
            this.SelectedEmployeesLB.Name = "SelectedEmployeesLB";
            this.SelectedEmployeesLB.Size = new System.Drawing.Size(222, 370);
            this.SelectedEmployeesLB.TabIndex = 34;
            this.SelectedEmployeesLB.Enter += new System.EventHandler(this.SelectedEmployeesLB_Enter);
            this.SelectedEmployeesLB.Leave += new System.EventHandler(this.SelectedEmployeesLB_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PositionsCB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 36);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AvailableEmployeesLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 334);
            this.panel2.TabIndex = 37;
            // 
            // ShedulerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EndDateDTP);
            this.Controls.Add(this.RemoveBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.StartDateDTP);
            this.Controls.Add(this.StructureObjectsCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShiftsCB);
            this.Controls.Add(this.TeamsCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndTimeDTP);
            this.Controls.Add(this.StartTimeDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Name = "ShedulerData";
            this.Text = "Дані робочої зміни";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartTimeDTP;
        private System.Windows.Forms.DateTimePicker EndTimeDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TeamsCB;
        private System.Windows.Forms.ComboBox ShiftsCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StructureObjectsCB;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button RemoveBt;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox AvailableEmployeesLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox SelectedEmployeesLB;
        private System.Windows.Forms.ComboBox PositionsCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;


    }
}