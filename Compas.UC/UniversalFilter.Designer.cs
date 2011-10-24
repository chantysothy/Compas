namespace Compas.UC
{
    partial class UniversalFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WareCategoriesLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.WareCodeTE = new DevExpress.XtraEditors.TextEdit();
            this.WaresLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.EndDateDE = new DevExpress.XtraEditors.DateEdit();
            this.StartDateDE = new DevExpress.XtraEditors.DateEdit();
            this.StructureObjectsLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.UnitLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CurrencyLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.WareNameTE = new DevExpress.XtraEditors.TextEdit();
            this.StatesCB = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.WareCategoriesLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareCodeTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaresLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDE.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDE.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureObjectsLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareNameTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // WareCategoriesLUE
            // 
            this.WareCategoriesLUE.Location = new System.Drawing.Point(108, 172);
            this.WareCategoriesLUE.Name = "WareCategoriesLUE";
            this.WareCategoriesLUE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.WareCategoriesLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WareCategoriesLUE.Size = new System.Drawing.Size(198, 20);
            this.WareCategoriesLUE.TabIndex = 35;
            this.WareCategoriesLUE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WareCategoriesLUE_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 179);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(99, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Категорія ном. од.:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Код ном. од.:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Номенкл. од.:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(85, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "По:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(92, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(10, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "З:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Об\'єкт:";
            // 
            // WareCodeTE
            // 
            this.WareCodeTE.Location = new System.Drawing.Point(108, 116);
            this.WareCodeTE.Name = "WareCodeTE";
            this.WareCodeTE.Size = new System.Drawing.Size(198, 20);
            this.WareCodeTE.TabIndex = 28;
            this.WareCodeTE.TextChanged += new System.EventHandler(this.WareCodeTE_TextChanged);
            // 
            // WaresLUE
            // 
            this.WaresLUE.Location = new System.Drawing.Point(108, 88);
            this.WaresLUE.Name = "WaresLUE";
            this.WaresLUE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.WaresLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WaresLUE.Size = new System.Drawing.Size(198, 20);
            this.WaresLUE.TabIndex = 27;
            this.WaresLUE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WaresLUE_KeyDown);
            this.WaresLUE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WaresLUE_KeyPress);
            // 
            // EndDateDE
            // 
            this.EndDateDE.EditValue = null;
            this.EndDateDE.Location = new System.Drawing.Point(108, 60);
            this.EndDateDE.Name = "EndDateDE";
            this.EndDateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateDE.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EndDateDE.Size = new System.Drawing.Size(100, 20);
            this.EndDateDE.TabIndex = 26;
            // 
            // StartDateDE
            // 
            this.StartDateDE.EditValue = null;
            this.StartDateDE.Location = new System.Drawing.Point(108, 32);
            this.StartDateDE.Name = "StartDateDE";
            this.StartDateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateDE.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.StartDateDE.Size = new System.Drawing.Size(100, 20);
            this.StartDateDE.TabIndex = 25;
            // 
            // StructureObjectsLUE
            // 
            this.StructureObjectsLUE.Location = new System.Drawing.Point(108, 4);
            this.StructureObjectsLUE.Name = "StructureObjectsLUE";
            this.StructureObjectsLUE.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.StructureObjectsLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StructureObjectsLUE.Properties.NullText = "";
            this.StructureObjectsLUE.Properties.PopupSizeable = false;
            this.StructureObjectsLUE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.StructureObjectsLUE.Size = new System.Drawing.Size(197, 20);
            this.StructureObjectsLUE.TabIndex = 24;
            // 
            // UnitLUE
            // 
            this.UnitLUE.Location = new System.Drawing.Point(108, 200);
            this.UnitLUE.Name = "UnitLUE";
            this.UnitLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UnitLUE.Size = new System.Drawing.Size(198, 20);
            this.UnitLUE.TabIndex = 37;
            this.UnitLUE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitLUE_KeyDown);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(54, 207);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Од. вим.:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // CurrencyLUE
            // 
            this.CurrencyLUE.Location = new System.Drawing.Point(108, 228);
            this.CurrencyLUE.Name = "CurrencyLUE";
            this.CurrencyLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CurrencyLUE.Size = new System.Drawing.Size(198, 20);
            this.CurrencyLUE.TabIndex = 39;
            this.CurrencyLUE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrencyLUE_KeyDown);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(59, 235);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Валюта:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 151);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 13);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "Назва ном. од.:";
            // 
            // WareNameTE
            // 
            this.WareNameTE.Location = new System.Drawing.Point(108, 144);
            this.WareNameTE.Name = "WareNameTE";
            this.WareNameTE.Size = new System.Drawing.Size(198, 20);
            this.WareNameTE.TabIndex = 40;
            this.WareNameTE.TextChanged += new System.EventHandler(this.WareNameTE_TextChanged);
            // 
            // StatesCB
            // 
            this.StatesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatesCB.FormattingEnabled = true;
            this.StatesCB.Location = new System.Drawing.Point(108, 255);
            this.StatesCB.Name = "StatesCB";
            this.StatesCB.Size = new System.Drawing.Size(198, 21);
            this.StatesCB.TabIndex = 42;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(62, 263);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 13);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Статус:";
            // 
            // UniversalFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.StatesCB);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.WareNameTE);
            this.Controls.Add(this.CurrencyLUE);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.UnitLUE);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.WareCategoriesLUE);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.WareCodeTE);
            this.Controls.Add(this.WaresLUE);
            this.Controls.Add(this.EndDateDE);
            this.Controls.Add(this.StartDateDE);
            this.Controls.Add(this.StructureObjectsLUE);
            this.Name = "UniversalFilter";
            this.Size = new System.Drawing.Size(311, 286);
            ((System.ComponentModel.ISupportInitialize)(this.WareCategoriesLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareCodeTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaresLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDE.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDE.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureObjectsLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareNameTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit WareCategoriesLUE;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit WareCodeTE;
        private DevExpress.XtraEditors.LookUpEdit WaresLUE;
        private DevExpress.XtraEditors.DateEdit EndDateDE;
        private DevExpress.XtraEditors.DateEdit StartDateDE;
        private DevExpress.XtraEditors.LookUpEdit StructureObjectsLUE;
        private DevExpress.XtraEditors.LookUpEdit UnitLUE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit CurrencyLUE;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit WareNameTE;
        private System.Windows.Forms.ComboBox StatesCB;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}
