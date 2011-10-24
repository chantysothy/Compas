namespace Compas.AdminUI.Wares.Price

{
    partial class PriceData
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WareCB = new System.Windows.Forms.ComboBox();
            this.PriceGroupsCB = new System.Windows.Forms.ComboBox();
            this.DocumentsCB = new System.Windows.Forms.ComboBox();
            this.AllowDiscountCB = new System.Windows.Forms.CheckBox();
            this.PurchasePriceNUD = new System.Windows.Forms.NumericUpDown();
            this.SalePriceNUD = new System.Windows.Forms.NumericUpDown();
            this.PriceActiveCB = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.OkBt = new System.Windows.Forms.Button();
            this.wareFilterUC1 = new Compas.UC.WareFilterUC();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номенклатурна одиниця:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Група прайсів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "На одиниці з документу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Знижка дозволена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ціна закупки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ціна продажу:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Прайс активний:";
            // 
            // WareCB
            // 
            this.WareCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WareCB.FormattingEnabled = true;
            this.WareCB.Location = new System.Drawing.Point(209, 169);
            this.WareCB.Margin = new System.Windows.Forms.Padding(4);
            this.WareCB.Name = "WareCB";
            this.WareCB.Size = new System.Drawing.Size(465, 24);
            this.WareCB.TabIndex = 25;
            // 
            // PriceGroupsCB
            // 
            this.PriceGroupsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceGroupsCB.FormattingEnabled = true;
            this.PriceGroupsCB.Location = new System.Drawing.Point(209, 209);
            this.PriceGroupsCB.Margin = new System.Windows.Forms.Padding(4);
            this.PriceGroupsCB.Name = "PriceGroupsCB";
            this.PriceGroupsCB.Size = new System.Drawing.Size(465, 24);
            this.PriceGroupsCB.TabIndex = 28;
            // 
            // DocumentsCB
            // 
            this.DocumentsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentsCB.FormattingEnabled = true;
            this.DocumentsCB.Location = new System.Drawing.Point(209, 249);
            this.DocumentsCB.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentsCB.Name = "DocumentsCB";
            this.DocumentsCB.Size = new System.Drawing.Size(465, 24);
            this.DocumentsCB.TabIndex = 29;
            // 
            // AllowDiscountCB
            // 
            this.AllowDiscountCB.AutoSize = true;
            this.AllowDiscountCB.Checked = true;
            this.AllowDiscountCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllowDiscountCB.Location = new System.Drawing.Point(209, 296);
            this.AllowDiscountCB.Name = "AllowDiscountCB";
            this.AllowDiscountCB.Size = new System.Drawing.Size(15, 14);
            this.AllowDiscountCB.TabIndex = 30;
            this.AllowDiscountCB.UseVisualStyleBackColor = true;
            // 
            // PurchasePriceNUD
            // 
            this.PurchasePriceNUD.DecimalPlaces = 2;
            this.PurchasePriceNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PurchasePriceNUD.Location = new System.Drawing.Point(209, 326);
            this.PurchasePriceNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PurchasePriceNUD.Name = "PurchasePriceNUD";
            this.PurchasePriceNUD.Size = new System.Drawing.Size(120, 23);
            this.PurchasePriceNUD.TabIndex = 31;
            // 
            // SalePriceNUD
            // 
            this.SalePriceNUD.DecimalPlaces = 2;
            this.SalePriceNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SalePriceNUD.Location = new System.Drawing.Point(209, 365);
            this.SalePriceNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SalePriceNUD.Name = "SalePriceNUD";
            this.SalePriceNUD.Size = new System.Drawing.Size(120, 23);
            this.SalePriceNUD.TabIndex = 32;
            // 
            // PriceActiveCB
            // 
            this.PriceActiveCB.AutoSize = true;
            this.PriceActiveCB.Checked = true;
            this.PriceActiveCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PriceActiveCB.Location = new System.Drawing.Point(209, 407);
            this.PriceActiveCB.Name = "PriceActiveCB";
            this.PriceActiveCB.Size = new System.Drawing.Size(15, 14);
            this.PriceActiveCB.TabIndex = 33;
            this.PriceActiveCB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.OkBt);
            this.groupBox1.Controls.Add(this.wareFilterUC1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 142);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтр номенклатурних одиниць";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(68, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Назва:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(116, 113);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(334, 23);
            this.NameTB.TabIndex = 24;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // OkBt
            // 
            this.OkBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBt.Image = global::Compas.AdminUI.Properties.Resources.filter__4_;
            this.OkBt.Location = new System.Drawing.Point(486, 100);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(156, 36);
            this.OkBt.TabIndex = 21;
            this.OkBt.Text = "Застосувати фільтр";
            this.OkBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // wareFilterUC1
            // 
            this.wareFilterUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wareFilterUC1.Location = new System.Drawing.Point(7, 20);
            this.wareFilterUC1.Margin = new System.Windows.Forms.Padding(4);
            this.wareFilterUC1.Name = "wareFilterUC1";
            this.wareFilterUC1.Size = new System.Drawing.Size(472, 92);
            this.wareFilterUC1.TabIndex = 0;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(399, 455);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(200, 62);
            this.CancelBt.TabIndex = 17;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(129, 455);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(200, 62);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // PriceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PriceActiveCB);
            this.Controls.Add(this.SalePriceNUD);
            this.Controls.Add(this.PurchasePriceNUD);
            this.Controls.Add(this.AllowDiscountCB);
            this.Controls.Add(this.DocumentsCB);
            this.Controls.Add(this.PriceGroupsCB);
            this.Controls.Add(this.WareCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PriceData";
            this.Text = "Встановлення ціни номенклатурної одиниці";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasePriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox WareCB;
        private System.Windows.Forms.ComboBox PriceGroupsCB;
        private System.Windows.Forms.ComboBox DocumentsCB;
        private System.Windows.Forms.CheckBox AllowDiscountCB;
        private System.Windows.Forms.NumericUpDown PurchasePriceNUD;
        private System.Windows.Forms.NumericUpDown SalePriceNUD;
        private System.Windows.Forms.CheckBox PriceActiveCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private UC.WareFilterUC wareFilterUC1;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameTB;
    }
}