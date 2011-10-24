namespace Compas.AdminUI.Wares.Discount

{
    partial class DiscountData
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
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountTypesCB = new System.Windows.Forms.ComboBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DefaultDiscountPercentNUD = new System.Windows.Forms.NumericUpDown();
            this.AddTypeBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDiscountPercentNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(302, 148);
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
            this.SaveBt.Location = new System.Drawing.Point(100, 148);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип:";
            // 
            // DiscountTypesCB
            // 
            this.DiscountTypesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscountTypesCB.FormattingEnabled = true;
            this.DiscountTypesCB.Location = new System.Drawing.Point(100, 12);
            this.DiscountTypesCB.Name = "DiscountTypesCB";
            this.DiscountTypesCB.Size = new System.Drawing.Size(359, 21);
            this.DiscountTypesCB.TabIndex = 19;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(100, 42);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(359, 20);
            this.NameTB.TabIndex = 20;
            // 
            // ActiveCB
            // 
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Location = new System.Drawing.Point(100, 74);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(15, 14);
            this.ActiveCB.TabIndex = 21;
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Назва:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Активний:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Процент знижки:";
            // 
            // DefaultDiscountPercentNUD
            // 
            this.DefaultDiscountPercentNUD.Location = new System.Drawing.Point(101, 93);
            this.DefaultDiscountPercentNUD.Name = "DefaultDiscountPercentNUD";
            this.DefaultDiscountPercentNUD.Size = new System.Drawing.Size(120, 20);
            this.DefaultDiscountPercentNUD.TabIndex = 25;
            // 
            // AddTypeBt
            // 
            this.AddTypeBt.Location = new System.Drawing.Point(465, 10);
            this.AddTypeBt.Name = "AddTypeBt";
            this.AddTypeBt.Size = new System.Drawing.Size(31, 23);
            this.AddTypeBt.TabIndex = 26;
            this.AddTypeBt.Text = "...";
            this.AddTypeBt.UseVisualStyleBackColor = true;
            this.AddTypeBt.Click += new System.EventHandler(this.AddTypeBt_Click);
            // 
            // DiscountData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 210);
            this.Controls.Add(this.AddTypeBt);
            this.Controls.Add(this.DefaultDiscountPercentNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.DiscountTypesCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Name = "DiscountData";
            this.Text = "Дані типу знижки";
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDiscountPercentNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DiscountTypesCB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DefaultDiscountPercentNUD;
        private System.Windows.Forms.Button AddTypeBt;
    }
}