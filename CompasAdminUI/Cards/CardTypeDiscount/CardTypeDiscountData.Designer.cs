namespace Compas.AdminUI.Cards
{
    partial class CardTypeDiscountData
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
            this.AllowBalanceCB = new System.Windows.Forms.CheckBox();
            this.AllowMultipleCarsCB = new System.Windows.Forms.CheckBox();
            this.RemoveBt = new System.Windows.Forms.Button();
            this.AddBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiscountsGV = new System.Windows.Forms.DataGridView();
            this.AvailableDiscountsGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableDiscountsGV)).BeginInit();
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
            this.CancelBt.Location = new System.Drawing.Point(381, 339);
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
            this.SaveBt.Location = new System.Drawing.Point(179, 339);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // AllowBalanceCB
            // 
            this.AllowBalanceCB.AutoSize = true;
            this.AllowBalanceCB.Location = new System.Drawing.Point(103, 42);
            this.AllowBalanceCB.Name = "AllowBalanceCB";
            this.AllowBalanceCB.Size = new System.Drawing.Size(128, 17);
            this.AllowBalanceCB.TabIndex = 18;
            this.AllowBalanceCB.Text = "Дозволений баланс";
            this.AllowBalanceCB.UseVisualStyleBackColor = true;
            // 
            // AllowMultipleCarsCB
            // 
            this.AllowMultipleCarsCB.AutoSize = true;
            this.AllowMultipleCarsCB.Location = new System.Drawing.Point(103, 66);
            this.AllowMultipleCarsCB.Name = "AllowMultipleCarsCB";
            this.AllowMultipleCarsCB.Size = new System.Drawing.Size(241, 17);
            this.AllowMultipleCarsCB.TabIndex = 19;
            this.AllowMultipleCarsCB.Text = "Дозволено кілька одиниць авто на картку";
            this.AllowMultipleCarsCB.UseVisualStyleBackColor = true;
            // 
            // RemoveBt
            // 
            this.RemoveBt.Image = global::Compas.AdminUI.Properties.Resources.forward;
            this.RemoveBt.Location = new System.Drawing.Point(347, 200);
            this.RemoveBt.Name = "RemoveBt";
            this.RemoveBt.Size = new System.Drawing.Size(47, 50);
            this.RemoveBt.TabIndex = 39;
            this.RemoveBt.UseVisualStyleBackColor = true;
            // 
            // AddBt
            // 
            this.AddBt.Image = global::Compas.AdminUI.Properties.Resources.back;
            this.AddBt.Location = new System.Drawing.Point(347, 144);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(47, 50);
            this.AddBt.TabIndex = 38;
            this.AddBt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DiscountsGV);
            this.groupBox1.Location = new System.Drawing.Point(103, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 243);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Присвоєні знижки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AvailableDiscountsGV);
            this.groupBox2.Location = new System.Drawing.Point(399, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 243);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Доступні знижки";
            // 
            // DiscountsGV
            // 
            this.DiscountsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscountsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountsGV.Location = new System.Drawing.Point(3, 16);
            this.DiscountsGV.Name = "DiscountsGV";
            this.DiscountsGV.Size = new System.Drawing.Size(235, 224);
            this.DiscountsGV.TabIndex = 0;
            // 
            // AvailableDiscountsGV
            // 
            this.AvailableDiscountsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableDiscountsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableDiscountsGV.Location = new System.Drawing.Point(3, 16);
            this.AvailableDiscountsGV.Name = "AvailableDiscountsGV";
            this.AvailableDiscountsGV.Size = new System.Drawing.Size(235, 224);
            this.AvailableDiscountsGV.TabIndex = 0;
            // 
            // CardTypeDiscountData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemoveBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.AllowMultipleCarsCB);
            this.Controls.Add(this.AllowBalanceCB);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Name = "CardTypeDiscountData";
            this.Text = "Дані типу картки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableDiscountsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.CheckBox AllowBalanceCB;
        private System.Windows.Forms.CheckBox AllowMultipleCarsCB;
        private System.Windows.Forms.Button RemoveBt;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DiscountsGV;
        private System.Windows.Forms.DataGridView AvailableDiscountsGV;
    }
}