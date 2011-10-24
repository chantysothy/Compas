namespace Compas.AdminUI.Staff.EmployeePosition
{
    partial class EmployeePositionData
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
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeL = new System.Windows.Forms.Label();
            this.PositionsCB = new System.Windows.Forms.ComboBox();
            this.StartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.EndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Посада:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(292, 215);
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
            this.SaveBt.Location = new System.Drawing.Point(103, 215);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Початок роботи:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Закінчення роботи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Активна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Працівник:";
            // 
            // EmployeeL
            // 
            this.EmployeeL.AutoSize = true;
            this.EmployeeL.Location = new System.Drawing.Point(142, 10);
            this.EmployeeL.Name = "EmployeeL";
            this.EmployeeL.Size = new System.Drawing.Size(79, 13);
            this.EmployeeL.TabIndex = 22;
            this.EmployeeL.Text = "Employee Data";
            // 
            // PositionsCB
            // 
            this.PositionsCB.DisplayMember = "Name";
            this.PositionsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionsCB.FormattingEnabled = true;
            this.PositionsCB.Location = new System.Drawing.Point(145, 76);
            this.PositionsCB.Name = "PositionsCB";
            this.PositionsCB.Size = new System.Drawing.Size(300, 21);
            this.PositionsCB.TabIndex = 23;
            this.PositionsCB.ValueMember = "ID";
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.Location = new System.Drawing.Point(145, 113);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(200, 20);
            this.StartDateDTP.TabIndex = 24;
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.Checked = false;
            this.EndDateDTP.Location = new System.Drawing.Point(145, 149);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(200, 20);
            this.EndDateDTP.TabIndex = 25;
            this.EndDateDTP.ValueChanged += new System.EventHandler(this.EndDateDTP_ValueChanged);
            // 
            // ActiveCB
            // 
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Location = new System.Drawing.Point(145, 185);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(15, 14);
            this.ActiveCB.TabIndex = 26;
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Відділ:";
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(145, 39);
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(300, 21);
            this.StructureObjectsCB.TabIndex = 50;
            // 
            // EmployeePositionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 277);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.StructureObjectsCB);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.EndDateDTP);
            this.Controls.Add(this.StartDateDTP);
            this.Controls.Add(this.PositionsCB);
            this.Controls.Add(this.EmployeeL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Name = "EmployeePositionData";
            this.Text = "Дані про посаду працівника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmployeeL;
        private System.Windows.Forms.ComboBox PositionsCB;
        private System.Windows.Forms.DateTimePicker StartDateDTP;
        private System.Windows.Forms.DateTimePicker EndDateDTP;
        private System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox StructureObjectsCB;
    }
}