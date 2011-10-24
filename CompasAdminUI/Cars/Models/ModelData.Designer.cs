namespace Compas.AdminUI.Cars
{
    partial class ModelData
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
            this.AddImageBt = new System.Windows.Forms.Button();
            this.BrandImagePB = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BrandImagePB)).BeginInit();
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
            this.NameTB.Size = new System.Drawing.Size(387, 20);
            this.NameTB.TabIndex = 14;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(305, 251);
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
            this.SaveBt.Location = new System.Drawing.Point(103, 251);
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
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Зображення:";
            // 
            // AddImageBt
            // 
            this.AddImageBt.Location = new System.Drawing.Point(103, 72);
            this.AddImageBt.Name = "AddImageBt";
            this.AddImageBt.Size = new System.Drawing.Size(135, 32);
            this.AddImageBt.TabIndex = 22;
            this.AddImageBt.Text = "Додати зображення";
            this.AddImageBt.UseVisualStyleBackColor = true;
            this.AddImageBt.Click += new System.EventHandler(this.AddImageBt_Click);
            // 
            // BrandImagePB
            // 
            this.BrandImagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BrandImagePB.Location = new System.Drawing.Point(103, 110);
            this.BrandImagePB.Name = "BrandImagePB";
            this.BrandImagePB.Size = new System.Drawing.Size(128, 128);
            this.BrandImagePB.TabIndex = 21;
            this.BrandImagePB.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(244, 72);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(135, 32);
            this.DeleteBt.TabIndex = 24;
            this.DeleteBt.Text = "Видалити зображення";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Категорія:";
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(104, 42);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(121, 21);
            this.CategoriesCB.TabIndex = 26;
            // 
            // ModelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 311);
            this.Controls.Add(this.CategoriesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddImageBt);
            this.Controls.Add(this.BrandImagePB);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Name = "ModelData";
            this.Text = "Дані Моделі";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BrandImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddImageBt;
        private System.Windows.Forms.PictureBox BrandImagePB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriesCB;
    }
}