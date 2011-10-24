namespace Compas.AdminUI.Staff.StructureObject
{
    partial class StructureObjectData
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.AllowServicesCB = new System.Windows.Forms.CheckBox();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Може надавати послуги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Батьківський об\'єкт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(227, 12);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(400, 26);
            this.NameTB.TabIndex = 1;
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.DisplayMember = "Name";
            this.StructureObjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(227, 54);
            this.StructureObjectsCB.MaxDropDownItems = 100;
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(400, 28);
            this.StructureObjectsCB.TabIndex = 3;
            this.StructureObjectsCB.ValueMember = "ID";
            // 
            // AllowServicesCB
            // 
            this.AllowServicesCB.AutoSize = true;
            this.AllowServicesCB.Location = new System.Drawing.Point(227, 98);
            this.AllowServicesCB.Name = "AllowServicesCB";
            this.AllowServicesCB.Size = new System.Drawing.Size(15, 14);
            this.AllowServicesCB.TabIndex = 5;
            this.AllowServicesCB.UseVisualStyleBackColor = true;
            // 
            // ActiveCB
            // 
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Location = new System.Drawing.Point(227, 128);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(15, 14);
            this.ActiveCB.TabIndex = 6;
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(349, 167);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(150, 50);
            this.CancelBt.TabIndex = 15;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(163, 167);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 14;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Активний:";
            // 
            // StructureObjectData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.AllowServicesCB);
            this.Controls.Add(this.StructureObjectsCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StructureObjectData";
            this.Text = "Дані об\'єкта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StructureObjectsCB;
        private System.Windows.Forms.CheckBox AllowServicesCB;
        private System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label4;

    }
}