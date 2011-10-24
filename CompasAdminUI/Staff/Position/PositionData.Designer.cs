namespace Compas.AdminUI.Staff.Position
{
    partial class PositionData
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Назва:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(103, 13);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(460, 20);
            this.NameTB.TabIndex = 14;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(323, 83);
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
            this.SaveBt.Location = new System.Drawing.Point(121, 83);
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
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Активна:";
            // 
            // ActiveCB
            // 
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Location = new System.Drawing.Point(104, 50);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(15, 14);
            this.ActiveCB.TabIndex = 19;
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // PositionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 145);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Name = "PositionData";
            this.Text = "Дані посади";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ActiveCB;
    }
}