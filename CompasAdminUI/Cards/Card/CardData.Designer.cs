namespace Compas.AdminUI.Cards
{
    partial class CardData
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
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CardTypesCB = new System.Windows.Forms.ComboBox();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IssuedDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CardsQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.CharsQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FillCodeCB = new System.Windows.Forms.CheckBox();
            this.BarcodePB = new System.Windows.Forms.PictureBox();
            this.ContractorLL = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CardsQuantityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharsQuantityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "№ 1-ї картки:";
            // 
            // CodeTB
            // 
            this.CodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeTB.Location = new System.Drawing.Point(125, 113);
            this.CodeTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(460, 26);
            this.CodeTB.TabIndex = 14;
            this.CodeTB.TextChanged += new System.EventHandler(this.CodeTB_TextChanged);
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(344, 260);
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
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(142, 260);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Тип:";
            // 
            // CardTypesCB
            // 
            this.CardTypesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTypesCB.FormattingEnabled = true;
            this.CardTypesCB.Location = new System.Drawing.Point(125, 147);
            this.CardTypesCB.Name = "CardTypesCB";
            this.CardTypesCB.Size = new System.Drawing.Size(460, 28);
            this.CardTypesCB.TabIndex = 19;
            // 
            // ActiveCB
            // 
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Checked = true;
            this.ActiveCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveCB.Location = new System.Drawing.Point(125, 213);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(92, 24);
            this.ActiveCB.TabIndex = 20;
            this.ActiveCB.Text = "Активна";
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата:";
            // 
            // IssuedDateDTP
            // 
            this.IssuedDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssuedDateDTP.Location = new System.Drawing.Point(126, 181);
            this.IssuedDateDTP.Name = "IssuedDateDTP";
            this.IssuedDateDTP.Size = new System.Drawing.Size(200, 26);
            this.IssuedDateDTP.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "К-ть карток:";
            // 
            // CardsQuantityNUD
            // 
            this.CardsQuantityNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardsQuantityNUD.Location = new System.Drawing.Point(126, 16);
            this.CardsQuantityNUD.Name = "CardsQuantityNUD";
            this.CardsQuantityNUD.Size = new System.Drawing.Size(120, 26);
            this.CardsQuantityNUD.TabIndex = 24;
            this.CardsQuantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CharsQuantityNUD
            // 
            this.CharsQuantityNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharsQuantityNUD.Location = new System.Drawing.Point(126, 48);
            this.CharsQuantityNUD.Name = "CharsQuantityNUD";
            this.CharsQuantityNUD.Size = new System.Drawing.Size(120, 26);
            this.CharsQuantityNUD.TabIndex = 26;
            this.CharsQuantityNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "К-ть знаків:";
            // 
            // FillCodeCB
            // 
            this.FillCodeCB.AutoSize = true;
            this.FillCodeCB.Checked = true;
            this.FillCodeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FillCodeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillCodeCB.Location = new System.Drawing.Point(126, 81);
            this.FillCodeCB.Name = "FillCodeCB";
            this.FillCodeCB.Size = new System.Drawing.Size(289, 24);
            this.FillCodeCB.TabIndex = 27;
            this.FillCodeCB.Text = "Доповнити до необхідної довжини";
            this.FillCodeCB.UseVisualStyleBackColor = true;
            // 
            // BarcodePB
            // 
            this.BarcodePB.Location = new System.Drawing.Point(344, 181);
            this.BarcodePB.Name = "BarcodePB";
            this.BarcodePB.Size = new System.Drawing.Size(241, 73);
            this.BarcodePB.TabIndex = 28;
            this.BarcodePB.TabStop = false;
            // 
            // ContractorLL
            // 
            this.ContractorLL.AutoSize = true;
            this.ContractorLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContractorLL.Location = new System.Drawing.Point(328, 28);
            this.ContractorLL.Name = "ContractorLL";
            this.ContractorLL.Size = new System.Drawing.Size(102, 20);
            this.ContractorLL.TabIndex = 29;
            this.ContractorLL.TabStop = true;
            this.ContractorLL.Text = "ContractorLL";
            // 
            // CardData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 319);
            this.Controls.Add(this.ContractorLL);
            this.Controls.Add(this.BarcodePB);
            this.Controls.Add(this.FillCodeCB);
            this.Controls.Add(this.CharsQuantityNUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CardsQuantityNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IssuedDateDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.CardTypesCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeTB);
            this.Name = "CardData";
            this.Text = "Дані картки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CardsQuantityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharsQuantityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CardTypesCB;
        private System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker IssuedDateDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CardsQuantityNUD;
        private System.Windows.Forms.NumericUpDown CharsQuantityNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox FillCodeCB;
        private System.Windows.Forms.PictureBox BarcodePB;
        private System.Windows.Forms.LinkLabel ContractorLL;
    }
}