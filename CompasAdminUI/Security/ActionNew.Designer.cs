namespace Compas.AdminUI.Security
{
    partial class ActionNew
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(97, 17);
            this.NameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(273, 20);
            this.NameTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Назва:";
            // 
            // DeleteBt
            // 
            this.DeleteBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.DeleteBt.Location = new System.Drawing.Point(244, 187);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(110, 40);
            this.DeleteBt.TabIndex = 11;
            this.DeleteBt.Text = "Відмінити";
            this.DeleteBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(120, 187);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(110, 40);
            this.SaveBt.TabIndex = 10;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CodeTB
            // 
            this.CodeTB.Location = new System.Drawing.Point(97, 53);
            this.CodeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(273, 20);
            this.CodeTB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Код:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(97, 130);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(273, 35);
            this.DescriptionTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Опис:";
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DisplayMember = "Name";
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(97, 88);
            this.CategoriesCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(273, 21);
            this.CategoriesCB.TabIndex = 16;
            this.CategoriesCB.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Категорія:";
            // 
            // ActionNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoriesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ActionNew";
            this.Text = "RoleNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.Label label4;
    }
}