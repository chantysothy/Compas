namespace Compas.AdminUI.Documents
{
    partial class DocumentDetailsData
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.SaveBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.OkBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WareLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.SalePriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceGroupsCBE = new DevExpress.XtraEditors.LookUpEdit();
            this.CurrencyLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.MessageL = new System.Windows.Forms.Label();
            this.wareFilterUC1 = new Compas.UC.WareFilterUC();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.UnitQuantityTB = new DevExpress.XtraEditors.SpinEdit();
            this.SecondaryUnitQuantityTB = new DevExpress.XtraEditors.SpinEdit();
            this.SalePriceForUnitTB = new DevExpress.XtraEditors.SpinEdit();
            this.DiscountForUnitTB = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.EndSalePriceForUnitTB = new System.Windows.Forms.TextBox();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WareLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceGroupsCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitQuantityTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryUnitQuantityTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceForUnitTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountForUnitTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(186, 508);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(200, 62);
            this.SaveBt.TabIndex = 9;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(456, 508);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(200, 62);
            this.CancelBt.TabIndex = 10;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Код:";
            // 
            // CodeTB
            // 
            this.CodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeTB.Location = new System.Drawing.Point(287, 75);
            this.CodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(444, 29);
            this.CodeTB.TabIndex = 0;
            this.CodeTB.TextChanged += new System.EventHandler(this.CodeTB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(209, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Назва:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(287, 37);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(444, 29);
            this.NameTB.TabIndex = 24;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // OkBt
            // 
            this.OkBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBt.Image = global::Compas.AdminUI.Properties.Resources.filter__4_;
            this.OkBt.Location = new System.Drawing.Point(674, 21);
            this.OkBt.Margin = new System.Windows.Forms.Padding(4);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(174, 92);
            this.OkBt.TabIndex = 21;
            this.OkBt.Text = "Застосувати фільтр";
            this.OkBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Номенклатурна одиниця:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "К-ть одиниць(основна):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(418, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "К-ть од.(втор):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(85, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Знижка на одиницю:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Кінцева ціна продажу за од.:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(116, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Ціна за одиницю:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(89, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 31);
            this.label11.TabIndex = 45;
            this.label11.Text = "Ціна продажу:";
            // 
            // WareLUE
            // 
            this.WareLUE.Location = new System.Drawing.Point(288, 175);
            this.WareLUE.Name = "WareLUE";
            this.WareLUE.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.WareLUE.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WareLUE.Properties.Appearance.Options.UseFont = true;
            this.WareLUE.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.WareLUE.Properties.AppearanceDropDown.Options.UseFont = true;
            this.WareLUE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.WareLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WareLUE.Properties.DropDownRows = 10;
            this.WareLUE.Properties.NullText = "одиниця не обрана";
            this.WareLUE.Properties.NullValuePrompt = "одиниця не обрана";
            this.WareLUE.Properties.EditValueChanged += new System.EventHandler(this.WareLUE_Properties_EditValueChanged);
            this.WareLUE.Size = new System.Drawing.Size(452, 30);
            this.WareLUE.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.WareLUE, conditionValidationRule1);
            this.WareLUE.EditValueChanged += new System.EventHandler(this.WareLUE_EditValueChanged);
            // 
            // SalePriceTB
            // 
            this.SalePriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalePriceTB.Location = new System.Drawing.Point(285, 441);
            this.SalePriceTB.Name = "SalePriceTB";
            this.SalePriceTB.ReadOnly = true;
            this.SalePriceTB.Size = new System.Drawing.Size(125, 38);
            this.SalePriceTB.TabIndex = 8;
            this.SalePriceTB.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(182, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Група цін:";
            // 
            // PriceGroupsCBE
            // 
            this.PriceGroupsCBE.Location = new System.Drawing.Point(288, 221);
            this.PriceGroupsCBE.Name = "PriceGroupsCBE";
            this.PriceGroupsCBE.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceGroupsCBE.Properties.Appearance.Options.UseFont = true;
            this.PriceGroupsCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PriceGroupsCBE.Properties.NullText = "";
            this.PriceGroupsCBE.Properties.PopupSizeable = false;
            this.PriceGroupsCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.PriceGroupsCBE.Properties.EditValueChanged += new System.EventHandler(this.PriceGroupsCBE_Properties_EditValueChanged);
            this.PriceGroupsCBE.Size = new System.Drawing.Size(452, 30);
            this.PriceGroupsCBE.TabIndex = 1;
            this.PriceGroupsCBE.EditValueChanged += new System.EventHandler(this.PriceGroupsCBE_EditValueChanged);
            // 
            // CurrencyLUE
            // 
            this.CurrencyLUE.Location = new System.Drawing.Point(567, 309);
            this.CurrencyLUE.Name = "CurrencyLUE";
            this.CurrencyLUE.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyLUE.Properties.Appearance.Options.UseFont = true;
            this.CurrencyLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrencyLUE.Size = new System.Drawing.Size(122, 30);
            this.CurrencyLUE.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.CurrencyLUE, conditionValidationRule2);
            // 
            // MessageL
            // 
            this.MessageL.AutoSize = true;
            this.MessageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageL.ForeColor = System.Drawing.Color.Maroon;
            this.MessageL.Location = new System.Drawing.Point(492, 400);
            this.MessageL.Name = "MessageL";
            this.MessageL.Size = new System.Drawing.Size(97, 24);
            this.MessageL.TabIndex = 68;
            this.MessageL.Text = "MessageL";
            // 
            // wareFilterUC1
            // 
            this.wareFilterUC1.FieldWidth = null;
            this.wareFilterUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wareFilterUC1.Location = new System.Drawing.Point(-9, 2);
            this.wareFilterUC1.Margin = new System.Windows.Forms.Padding(5);
            this.wareFilterUC1.Name = "wareFilterUC1";
            this.wareFilterUC1.Size = new System.Drawing.Size(868, 134);
            this.wareFilterUC1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(867, 164);
            this.xtraTabControl1.TabIndex = 32;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Selected += new DevExpress.XtraTab.TabPageEventHandler(this.xtraTabControl1_Selected);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label8);
            this.xtraTabPage1.Controls.Add(this.CodeTB);
            this.xtraTabPage1.Controls.Add(this.NameTB);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(861, 138);
            this.xtraTabPage1.Text = "Код і назва";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.OkBt);
            this.xtraTabPage2.Controls.Add(this.wareFilterUC1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(861, 138);
            this.xtraTabPage2.Text = "Фільтр";
            // 
            // UnitQuantityTB
            // 
            this.UnitQuantityTB.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UnitQuantityTB.Location = new System.Drawing.Point(287, 264);
            this.UnitQuantityTB.Name = "UnitQuantityTB";
            this.UnitQuantityTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.UnitQuantityTB.Properties.Appearance.Options.UseFont = true;
            this.UnitQuantityTB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UnitQuantityTB.Size = new System.Drawing.Size(122, 32);
            this.UnitQuantityTB.TabIndex = 69;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dxValidationProvider1.SetValidationRule(this.UnitQuantityTB, conditionValidationRule3);
            this.UnitQuantityTB.EditValueChanged += new System.EventHandler(this.UnitQuantityTB_EditValueChanged);
            // 
            // SecondaryUnitQuantityTB
            // 
            this.SecondaryUnitQuantityTB.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SecondaryUnitQuantityTB.Location = new System.Drawing.Point(567, 264);
            this.SecondaryUnitQuantityTB.Name = "SecondaryUnitQuantityTB";
            this.SecondaryUnitQuantityTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.SecondaryUnitQuantityTB.Properties.Appearance.Options.UseFont = true;
            this.SecondaryUnitQuantityTB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SecondaryUnitQuantityTB.Size = new System.Drawing.Size(122, 32);
            this.SecondaryUnitQuantityTB.TabIndex = 70;
            // 
            // SalePriceForUnitTB
            // 
            this.SalePriceForUnitTB.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SalePriceForUnitTB.Location = new System.Drawing.Point(286, 309);
            this.SalePriceForUnitTB.Name = "SalePriceForUnitTB";
            this.SalePriceForUnitTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.SalePriceForUnitTB.Properties.Appearance.Options.UseFont = true;
            this.SalePriceForUnitTB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SalePriceForUnitTB.Size = new System.Drawing.Size(122, 32);
            this.SalePriceForUnitTB.TabIndex = 71;
            this.SalePriceForUnitTB.EditValueChanged += new System.EventHandler(this.SalePriceForUnitTB_EditValueChanged);
            // 
            // DiscountForUnitTB
            // 
            this.DiscountForUnitTB.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DiscountForUnitTB.Location = new System.Drawing.Point(286, 354);
            this.DiscountForUnitTB.Name = "DiscountForUnitTB";
            this.DiscountForUnitTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.DiscountForUnitTB.Properties.Appearance.Options.UseFont = true;
            this.DiscountForUnitTB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DiscountForUnitTB.Size = new System.Drawing.Size(122, 32);
            this.DiscountForUnitTB.TabIndex = 72;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.DiscountForUnitTB, conditionValidationRule4);
            this.DiscountForUnitTB.EditValueChanged += new System.EventHandler(this.DiscountForUnitTB_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(479, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 74;
            this.label6.Text = "Валюта:";
            // 
            // EndSalePriceForUnitTB
            // 
            this.EndSalePriceForUnitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndSalePriceForUnitTB.Location = new System.Drawing.Point(285, 395);
            this.EndSalePriceForUnitTB.Name = "EndSalePriceForUnitTB";
            this.EndSalePriceForUnitTB.ReadOnly = true;
            this.EndSalePriceForUnitTB.Size = new System.Drawing.Size(123, 32);
            this.EndSalePriceForUnitTB.TabIndex = 75;
            // 
            // DocumentDetailsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 594);
            this.Controls.Add(this.EndSalePriceForUnitTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiscountForUnitTB);
            this.Controls.Add(this.SalePriceForUnitTB);
            this.Controls.Add(this.SecondaryUnitQuantityTB);
            this.Controls.Add(this.UnitQuantityTB);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.MessageL);
            this.Controls.Add(this.CurrencyLUE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SalePriceTB);
            this.Controls.Add(this.WareLUE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.PriceGroupsCBE);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocumentDetailsData";
            this.Text = "Дані одиниці вимірювання";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            this.Load += new System.EventHandler(this.DocumentDetailsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WareLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceGroupsCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitQuantityTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryUnitQuantityTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceForUnitTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountForUnitTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button OkBt;
        private UC.WareFilterUC wareFilterUC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.LookUpEdit WareLUE;
        private System.Windows.Forms.TextBox SalePriceTB;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit PriceGroupsCBE;
        private DevExpress.XtraEditors.LookUpEdit CurrencyLUE;
        private System.Windows.Forms.Label MessageL;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SpinEdit UnitQuantityTB;
        private DevExpress.XtraEditors.SpinEdit SecondaryUnitQuantityTB;
        private DevExpress.XtraEditors.SpinEdit SalePriceForUnitTB;
        private DevExpress.XtraEditors.SpinEdit DiscountForUnitTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndSalePriceForUnitTB;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}