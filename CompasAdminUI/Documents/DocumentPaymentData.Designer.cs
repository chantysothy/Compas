namespace Compas.AdminUI.Documents
{
    partial class DocumentPaymentData
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
            this.DocumentSumaL = new System.Windows.Forms.Label();
            this.SumaSE = new DevExpress.XtraEditors.SpinEdit();
            this.OverPayL = new System.Windows.Forms.Label();
            this.PaySumaL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentTypesLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.StructureObjectsLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.CardTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.PayDateDTP = new System.Windows.Forms.DateTimePicker();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckNumberTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SumaSE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypesLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureObjectsLUE.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума документу:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Внесено коштів:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(222, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Здача:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(183, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Оплачено:";
            // 
            // DocumentSumaL
            // 
            this.DocumentSumaL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DocumentSumaL.AutoSize = true;
            this.DocumentSumaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentSumaL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DocumentSumaL.Location = new System.Drawing.Point(309, 12);
            this.DocumentSumaL.Name = "DocumentSumaL";
            this.DocumentSumaL.Size = new System.Drawing.Size(176, 25);
            this.DocumentSumaL.TabIndex = 4;
            this.DocumentSumaL.Text = "DocumentSumaL";
            // 
            // SumaSE
            // 
            this.SumaSE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SumaSE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SumaSE.Location = new System.Drawing.Point(309, 159);
            this.SumaSE.Name = "SumaSE";
            this.SumaSE.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumaSE.Properties.Appearance.Options.UseFont = true;
            this.SumaSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SumaSE.Size = new System.Drawing.Size(116, 31);
            this.SumaSE.TabIndex = 5;
            this.SumaSE.EditValueChanged += new System.EventHandler(this.SumaSE_EditValueChanged);
            // 
            // OverPayL
            // 
            this.OverPayL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OverPayL.AutoSize = true;
            this.OverPayL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OverPayL.Location = new System.Drawing.Point(309, 262);
            this.OverPayL.Name = "OverPayL";
            this.OverPayL.Size = new System.Drawing.Size(107, 25);
            this.OverPayL.TabIndex = 6;
            this.OverPayL.Text = "OverPayL";
            // 
            // PaySumaL
            // 
            this.PaySumaL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaySumaL.AutoSize = true;
            this.PaySumaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaySumaL.ForeColor = System.Drawing.Color.Green;
            this.PaySumaL.Location = new System.Drawing.Point(309, 405);
            this.PaySumaL.Name = "PaySumaL";
            this.PaySumaL.Size = new System.Drawing.Size(116, 25);
            this.PaySumaL.TabIndex = 7;
            this.PaySumaL.Text = "PaySumaL";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(172, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип оплати:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(125, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Місце внесення:";
            // 
            // PaymentTypesLUE
            // 
            this.PaymentTypesLUE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaymentTypesLUE.Location = new System.Drawing.Point(309, 309);
            this.PaymentTypesLUE.Name = "PaymentTypesLUE";
            this.PaymentTypesLUE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.PaymentTypesLUE.Properties.Appearance.Options.UseFont = true;
            this.PaymentTypesLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PaymentTypesLUE.Properties.NullText = "";
            this.PaymentTypesLUE.Properties.PopupSizeable = false;
            this.PaymentTypesLUE.Size = new System.Drawing.Size(231, 32);
            this.PaymentTypesLUE.TabIndex = 12;
            // 
            // StructureObjectsLUE
            // 
            this.StructureObjectsLUE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StructureObjectsLUE.Location = new System.Drawing.Point(309, 359);
            this.StructureObjectsLUE.Name = "StructureObjectsLUE";
            this.StructureObjectsLUE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.StructureObjectsLUE.Properties.Appearance.Options.UseFont = true;
            this.StructureObjectsLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StructureObjectsLUE.Properties.NullText = "";
            this.StructureObjectsLUE.Properties.PopupSizeable = false;
            this.StructureObjectsLUE.Size = new System.Drawing.Size(231, 32);
            this.StructureObjectsLUE.TabIndex = 13;
            // 
            // CardTB
            // 
            this.CardTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CardTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTB.Location = new System.Drawing.Point(309, 209);
            this.CardTB.Name = "CardTB";
            this.CardTB.Size = new System.Drawing.Size(231, 31);
            this.CardTB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(189, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "№ картки:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DocumentSumaL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PayDateDTP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelBt, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.SaveBt, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.PaySumaL, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.StructureObjectsLUE, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PaymentTypesLUE, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.OverPayL, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CardTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SumaSE, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckNumberTB, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 525);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(157, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата оплати:";
            // 
            // PayDateDTP
            // 
            this.PayDateDTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PayDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayDateDTP.Location = new System.Drawing.Point(309, 59);
            this.PayDateDTP.Name = "PayDateDTP";
            this.PayDateDTP.Size = new System.Drawing.Size(231, 32);
            this.PayDateDTP.TabIndex = 17;
            // 
            // CancelBt
            // 
            this.CancelBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(309, 451);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(214, 57);
            this.CancelBt.TabIndex = 9;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(89, 451);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(214, 57);
            this.SaveBt.TabIndex = 8;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(211, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "№ чеку:";
            // 
            // CheckNumberTB
            // 
            this.CheckNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckNumberTB.Location = new System.Drawing.Point(309, 109);
            this.CheckNumberTB.Name = "CheckNumberTB";
            this.CheckNumberTB.Size = new System.Drawing.Size(231, 32);
            this.CheckNumberTB.TabIndex = 19;
            // 
            // DocumentPaymentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBt;
            this.ClientSize = new System.Drawing.Size(612, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentPaymentData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення оплати";
            ((System.ComponentModel.ISupportInitialize)(this.SumaSE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypesLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureObjectsLUE.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DocumentSumaL;
        private DevExpress.XtraEditors.SpinEdit SumaSE;
        private System.Windows.Forms.Label OverPayL;
        private System.Windows.Forms.Label PaySumaL;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit PaymentTypesLUE;
        private DevExpress.XtraEditors.LookUpEdit StructureObjectsLUE;
        private System.Windows.Forms.TextBox CardTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker PayDateDTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CheckNumberTB;
    }
}