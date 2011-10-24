namespace Compas.AdminUI.CashRegisters
{
    partial class CashRegisterData
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.LogicNumberTB = new System.Windows.Forms.TextBox();
            this.PortNumberTB = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ModesCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.TestConnectionBt = new System.Windows.Forms.Button();
            this.TestCheckBt = new System.Windows.Forms.Button();
            this.Z1Bt = new System.Windows.Forms.Button();
            this.Z2Bt = new System.Windows.Forms.Button();
            this.Z3Bt = new System.Windows.Forms.Button();
            this.X3Bt = new System.Windows.Forms.Button();
            this.X1Bt = new System.Windows.Forms.Button();
            this.CancelCheckBt = new System.Windows.Forms.Button();
            this.StartShiftBt = new System.Windows.Forms.Button();
            this.StartCheckBt = new System.Windows.Forms.Button();
            this.AddPositionBt = new System.Windows.Forms.Button();
            this.AddPaymentBt = new System.Windows.Forms.Button();
            this.CloseCheckBt = new System.Windows.Forms.Button();
            this.DeleteAllWaresBt = new System.Windows.Forms.Button();
            this.TestIndicatorBt = new System.Windows.Forms.Button();
            this.CopyCheckBt = new System.Windows.Forms.Button();
            this.PrintTextCommentBt = new System.Windows.Forms.Button();
            this.MoneysInBt = new System.Windows.Forms.Button();
            this.LastCheckInfoBt = new System.Windows.Forms.Button();
            this.MoneysOutBt = new System.Windows.Forms.Button();
            this.OpenSafeBt = new System.Windows.Forms.Button();
            this.CheckConnectionBt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.89941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.10059F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.UserTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LogicNumberTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PortNumberTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModesCB, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(88, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Режим:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(82, 215);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Пароль:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(148, 212);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(140, 26);
            this.PasswordTB.TabIndex = 8;
            // 
            // UserTB
            // 
            this.UserTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTB.Location = new System.Drawing.Point(148, 162);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(140, 26);
            this.UserTB.TabIndex = 7;
            // 
            // LogicNumberTB
            // 
            this.LogicNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogicNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogicNumberTB.Location = new System.Drawing.Point(148, 112);
            this.LogicNumberTB.Name = "LogicNumberTB";
            this.LogicNumberTB.Size = new System.Drawing.Size(140, 26);
            this.LogicNumberTB.TabIndex = 6;
            // 
            // PortNumberTB
            // 
            this.PortNumberTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PortNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortNumberTB.Location = new System.Drawing.Point(148, 62);
            this.PortNumberTB.Name = "PortNumberTB";
            this.PortNumberTB.Size = new System.Drawing.Size(140, 26);
            this.PortNumberTB.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(51, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Користувач:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(19, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Логічний номер:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(70, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "№ порта:";
            // 
            // ModesCB
            // 
            this.ModesCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModesCB.FormattingEnabled = true;
            this.ModesCB.Location = new System.Drawing.Point(148, 11);
            this.ModesCB.Name = "ModesCB";
            this.ModesCB.Size = new System.Drawing.Size(187, 28);
            this.ModesCB.TabIndex = 10;
            this.ModesCB.SelectedIndexChanged += new System.EventHandler(this.ModesCB_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CancelBt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveBt, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(151, 487);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 63);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(126, 3);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(118, 50);
            this.CancelBt.TabIndex = 19;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(3, 3);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(117, 50);
            this.SaveBt.TabIndex = 18;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // TestConnectionBt
            // 
            this.TestConnectionBt.Location = new System.Drawing.Point(188, 282);
            this.TestConnectionBt.Name = "TestConnectionBt";
            this.TestConnectionBt.Size = new System.Drawing.Size(140, 35);
            this.TestConnectionBt.TabIndex = 5;
            this.TestConnectionBt.Text = "Підключитись";
            this.TestConnectionBt.UseVisualStyleBackColor = true;
            this.TestConnectionBt.Click += new System.EventHandler(this.TestConnectionBt_Click);
            // 
            // TestCheckBt
            // 
            this.TestCheckBt.Location = new System.Drawing.Point(334, 446);
            this.TestCheckBt.Name = "TestCheckBt";
            this.TestCheckBt.Size = new System.Drawing.Size(140, 35);
            this.TestCheckBt.TabIndex = 6;
            this.TestCheckBt.Text = "Тест-чек";
            this.TestCheckBt.UseVisualStyleBackColor = true;
            this.TestCheckBt.Click += new System.EventHandler(this.TestCheckBt_Click);
            // 
            // Z1Bt
            // 
            this.Z1Bt.Location = new System.Drawing.Point(12, 282);
            this.Z1Bt.Name = "Z1Bt";
            this.Z1Bt.Size = new System.Drawing.Size(140, 35);
            this.Z1Bt.TabIndex = 7;
            this.Z1Bt.Text = "Z1-звіт";
            this.Z1Bt.UseVisualStyleBackColor = true;
            this.Z1Bt.Click += new System.EventHandler(this.Z1Bt_Click);
            // 
            // Z2Bt
            // 
            this.Z2Bt.Location = new System.Drawing.Point(12, 323);
            this.Z2Bt.Name = "Z2Bt";
            this.Z2Bt.Size = new System.Drawing.Size(140, 35);
            this.Z2Bt.TabIndex = 8;
            this.Z2Bt.Text = "Z2-звіт";
            this.Z2Bt.UseVisualStyleBackColor = true;
            this.Z2Bt.Click += new System.EventHandler(this.Z2Bt_Click);
            // 
            // Z3Bt
            // 
            this.Z3Bt.Location = new System.Drawing.Point(12, 364);
            this.Z3Bt.Name = "Z3Bt";
            this.Z3Bt.Size = new System.Drawing.Size(140, 35);
            this.Z3Bt.TabIndex = 9;
            this.Z3Bt.Text = "Z3-звіт";
            this.Z3Bt.UseVisualStyleBackColor = true;
            this.Z3Bt.Click += new System.EventHandler(this.Z3Bt_Click);
            // 
            // X3Bt
            // 
            this.X3Bt.Location = new System.Drawing.Point(12, 446);
            this.X3Bt.Name = "X3Bt";
            this.X3Bt.Size = new System.Drawing.Size(140, 35);
            this.X3Bt.TabIndex = 11;
            this.X3Bt.Text = "X3-звіт";
            this.X3Bt.UseVisualStyleBackColor = true;
            this.X3Bt.Click += new System.EventHandler(this.X3Bt_Click);
            // 
            // X1Bt
            // 
            this.X1Bt.Location = new System.Drawing.Point(12, 405);
            this.X1Bt.Name = "X1Bt";
            this.X1Bt.Size = new System.Drawing.Size(140, 35);
            this.X1Bt.TabIndex = 10;
            this.X1Bt.Text = "X1-звіт";
            this.X1Bt.UseVisualStyleBackColor = true;
            this.X1Bt.Click += new System.EventHandler(this.X1Bt_Click);
            // 
            // CancelCheckBt
            // 
            this.CancelCheckBt.Location = new System.Drawing.Point(334, 405);
            this.CancelCheckBt.Name = "CancelCheckBt";
            this.CancelCheckBt.Size = new System.Drawing.Size(140, 35);
            this.CancelCheckBt.TabIndex = 12;
            this.CancelCheckBt.Text = "Відміна чеку";
            this.CancelCheckBt.UseVisualStyleBackColor = true;
            this.CancelCheckBt.Click += new System.EventHandler(this.CancelCheckBt_Click);
            // 
            // StartShiftBt
            // 
            this.StartShiftBt.Location = new System.Drawing.Point(188, 323);
            this.StartShiftBt.Name = "StartShiftBt";
            this.StartShiftBt.Size = new System.Drawing.Size(140, 35);
            this.StartShiftBt.TabIndex = 13;
            this.StartShiftBt.Text = "Почати зміну";
            this.StartShiftBt.UseVisualStyleBackColor = true;
            this.StartShiftBt.Click += new System.EventHandler(this.StartShiftBt_Click);
            // 
            // StartCheckBt
            // 
            this.StartCheckBt.Location = new System.Drawing.Point(188, 364);
            this.StartCheckBt.Name = "StartCheckBt";
            this.StartCheckBt.Size = new System.Drawing.Size(140, 35);
            this.StartCheckBt.TabIndex = 14;
            this.StartCheckBt.Text = "Почати чек";
            this.StartCheckBt.UseVisualStyleBackColor = true;
            this.StartCheckBt.Click += new System.EventHandler(this.StartCheckBt_Click);
            // 
            // AddPositionBt
            // 
            this.AddPositionBt.Location = new System.Drawing.Point(188, 405);
            this.AddPositionBt.Name = "AddPositionBt";
            this.AddPositionBt.Size = new System.Drawing.Size(140, 35);
            this.AddPositionBt.TabIndex = 15;
            this.AddPositionBt.Text = "Додати позицію";
            this.AddPositionBt.UseVisualStyleBackColor = true;
            this.AddPositionBt.Click += new System.EventHandler(this.AddPositionBt_Click);
            // 
            // AddPaymentBt
            // 
            this.AddPaymentBt.Location = new System.Drawing.Point(188, 446);
            this.AddPaymentBt.Name = "AddPaymentBt";
            this.AddPaymentBt.Size = new System.Drawing.Size(140, 35);
            this.AddPaymentBt.TabIndex = 16;
            this.AddPaymentBt.Text = "Додати оплату";
            this.AddPaymentBt.UseVisualStyleBackColor = true;
            this.AddPaymentBt.Click += new System.EventHandler(this.AddPaymentBt_Click);
            // 
            // CloseCheckBt
            // 
            this.CloseCheckBt.Location = new System.Drawing.Point(334, 364);
            this.CloseCheckBt.Name = "CloseCheckBt";
            this.CloseCheckBt.Size = new System.Drawing.Size(140, 35);
            this.CloseCheckBt.TabIndex = 17;
            this.CloseCheckBt.Text = "Закрити чек";
            this.CloseCheckBt.UseVisualStyleBackColor = true;
            this.CloseCheckBt.Click += new System.EventHandler(this.CloseCheckBt_Click);
            // 
            // DeleteAllWaresBt
            // 
            this.DeleteAllWaresBt.Location = new System.Drawing.Point(489, 282);
            this.DeleteAllWaresBt.Name = "DeleteAllWaresBt";
            this.DeleteAllWaresBt.Size = new System.Drawing.Size(140, 35);
            this.DeleteAllWaresBt.TabIndex = 18;
            this.DeleteAllWaresBt.Text = "Стерти всі товари";
            this.DeleteAllWaresBt.UseVisualStyleBackColor = true;
            // 
            // TestIndicatorBt
            // 
            this.TestIndicatorBt.Location = new System.Drawing.Point(489, 323);
            this.TestIndicatorBt.Name = "TestIndicatorBt";
            this.TestIndicatorBt.Size = new System.Drawing.Size(140, 35);
            this.TestIndicatorBt.TabIndex = 19;
            this.TestIndicatorBt.Text = "Тест індикатора";
            this.TestIndicatorBt.UseVisualStyleBackColor = true;
            this.TestIndicatorBt.Click += new System.EventHandler(this.TestIndicatorBt_Click);
            // 
            // CopyCheckBt
            // 
            this.CopyCheckBt.Location = new System.Drawing.Point(489, 364);
            this.CopyCheckBt.Name = "CopyCheckBt";
            this.CopyCheckBt.Size = new System.Drawing.Size(140, 35);
            this.CopyCheckBt.TabIndex = 20;
            this.CopyCheckBt.Text = "Копія чеку";
            this.CopyCheckBt.UseVisualStyleBackColor = true;
            this.CopyCheckBt.Click += new System.EventHandler(this.CopyCheckBt_Click);
            // 
            // PrintTextCommentBt
            // 
            this.PrintTextCommentBt.Location = new System.Drawing.Point(489, 405);
            this.PrintTextCommentBt.Name = "PrintTextCommentBt";
            this.PrintTextCommentBt.Size = new System.Drawing.Size(140, 35);
            this.PrintTextCommentBt.TabIndex = 21;
            this.PrintTextCommentBt.Text = "Друк коментарю";
            this.PrintTextCommentBt.UseVisualStyleBackColor = true;
            this.PrintTextCommentBt.Click += new System.EventHandler(this.PrintTextCommentBt_Click);
            // 
            // MoneysInBt
            // 
            this.MoneysInBt.Location = new System.Drawing.Point(489, 446);
            this.MoneysInBt.Name = "MoneysInBt";
            this.MoneysInBt.Size = new System.Drawing.Size(140, 35);
            this.MoneysInBt.TabIndex = 22;
            this.MoneysInBt.Text = "Службове внесення";
            this.MoneysInBt.UseVisualStyleBackColor = true;
            this.MoneysInBt.Click += new System.EventHandler(this.MoneysInBt_Click);
            // 
            // LastCheckInfoBt
            // 
            this.LastCheckInfoBt.Location = new System.Drawing.Point(635, 282);
            this.LastCheckInfoBt.Name = "LastCheckInfoBt";
            this.LastCheckInfoBt.Size = new System.Drawing.Size(140, 35);
            this.LastCheckInfoBt.TabIndex = 23;
            this.LastCheckInfoBt.Text = "Інфо про останній чек";
            this.LastCheckInfoBt.UseVisualStyleBackColor = true;
            this.LastCheckInfoBt.Click += new System.EventHandler(this.LastCheckInfoBt_Click);
            // 
            // MoneysOutBt
            // 
            this.MoneysOutBt.Location = new System.Drawing.Point(489, 490);
            this.MoneysOutBt.Name = "MoneysOutBt";
            this.MoneysOutBt.Size = new System.Drawing.Size(140, 35);
            this.MoneysOutBt.TabIndex = 25;
            this.MoneysOutBt.Text = "Службове винесення";
            this.MoneysOutBt.UseVisualStyleBackColor = true;
            this.MoneysOutBt.Click += new System.EventHandler(this.MoneysOutBt_Click);
            // 
            // OpenSafeBt
            // 
            this.OpenSafeBt.Location = new System.Drawing.Point(635, 323);
            this.OpenSafeBt.Name = "OpenSafeBt";
            this.OpenSafeBt.Size = new System.Drawing.Size(140, 35);
            this.OpenSafeBt.TabIndex = 26;
            this.OpenSafeBt.Text = "Відкрити сейф";
            this.OpenSafeBt.UseVisualStyleBackColor = true;
            this.OpenSafeBt.Click += new System.EventHandler(this.OpenSafeBt_Click);
            // 
            // CheckConnectionBt
            // 
            this.CheckConnectionBt.Location = new System.Drawing.Point(334, 282);
            this.CheckConnectionBt.Name = "CheckConnectionBt";
            this.CheckConnectionBt.Size = new System.Drawing.Size(140, 35);
            this.CheckConnectionBt.TabIndex = 27;
            this.CheckConnectionBt.Text = "Перевірити підключення";
            this.CheckConnectionBt.UseVisualStyleBackColor = true;
            this.CheckConnectionBt.ClientSizeChanged += new System.EventHandler(this.CheckConnectionBt_ClientSizeChanged);
            this.CheckConnectionBt.Click += new System.EventHandler(this.CheckConnectionBt_Click);
            // 
            // CashRegisterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
            this.Controls.Add(this.CheckConnectionBt);
            this.Controls.Add(this.OpenSafeBt);
            this.Controls.Add(this.MoneysOutBt);
            this.Controls.Add(this.LastCheckInfoBt);
            this.Controls.Add(this.MoneysInBt);
            this.Controls.Add(this.PrintTextCommentBt);
            this.Controls.Add(this.CopyCheckBt);
            this.Controls.Add(this.TestIndicatorBt);
            this.Controls.Add(this.DeleteAllWaresBt);
            this.Controls.Add(this.CloseCheckBt);
            this.Controls.Add(this.AddPaymentBt);
            this.Controls.Add(this.AddPositionBt);
            this.Controls.Add(this.StartCheckBt);
            this.Controls.Add(this.StartShiftBt);
            this.Controls.Add(this.CancelCheckBt);
            this.Controls.Add(this.X3Bt);
            this.Controls.Add(this.X1Bt);
            this.Controls.Add(this.Z3Bt);
            this.Controls.Add(this.Z2Bt);
            this.Controls.Add(this.Z1Bt);
            this.Controls.Add(this.TestCheckBt);
            this.Controls.Add(this.TestConnectionBt);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CashRegisterData";
            this.Text = "Дані РРО";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.TextBox PortNumberTB;
        private System.Windows.Forms.TextBox LogicNumberTB;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox ModesCB;
        private System.Windows.Forms.Button TestConnectionBt;
        private System.Windows.Forms.Button TestCheckBt;
        private System.Windows.Forms.Button Z1Bt;
        private System.Windows.Forms.Button Z2Bt;
        private System.Windows.Forms.Button Z3Bt;
        private System.Windows.Forms.Button X3Bt;
        private System.Windows.Forms.Button X1Bt;
        private System.Windows.Forms.Button CancelCheckBt;
        private System.Windows.Forms.Button StartShiftBt;
        private System.Windows.Forms.Button StartCheckBt;
        private System.Windows.Forms.Button AddPositionBt;
        private System.Windows.Forms.Button AddPaymentBt;
        private System.Windows.Forms.Button CloseCheckBt;
        private System.Windows.Forms.Button DeleteAllWaresBt;
        private System.Windows.Forms.Button TestIndicatorBt;
        private System.Windows.Forms.Button CopyCheckBt;
        private System.Windows.Forms.Button PrintTextCommentBt;
        private System.Windows.Forms.Button MoneysInBt;
        private System.Windows.Forms.Button LastCheckInfoBt;
        private System.Windows.Forms.Button MoneysOutBt;
        private System.Windows.Forms.Button OpenSafeBt;
        private System.Windows.Forms.Button CheckConnectionBt;
    }
}