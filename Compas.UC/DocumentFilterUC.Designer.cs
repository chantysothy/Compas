namespace Compas.UC
{
    partial class DocumentFilterUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DocumentNumberTB = new System.Windows.Forms.TextBox();
            this.DocumentTypesCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DocumentSumSE = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentSumSE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "№ док.:";
            // 
            // DocumentNumberTB
            // 
            this.DocumentNumberTB.Location = new System.Drawing.Point(70, 60);
            this.DocumentNumberTB.Name = "DocumentNumberTB";
            this.DocumentNumberTB.Size = new System.Drawing.Size(138, 20);
            this.DocumentNumberTB.TabIndex = 9;
            // 
            // DocumentTypesCB
            // 
            this.DocumentTypesCB.FormattingEnabled = true;
            this.DocumentTypesCB.Location = new System.Drawing.Point(69, 7);
            this.DocumentTypesCB.Name = "DocumentTypesCB";
            this.DocumentTypesCB.Size = new System.Drawing.Size(138, 21);
            this.DocumentTypesCB.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сума док.:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DocumentSumSE
            // 
            this.DocumentSumSE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DocumentSumSE.Location = new System.Drawing.Point(70, 34);
            this.DocumentSumSE.Name = "DocumentSumSE";
            this.DocumentSumSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DocumentSumSE.Properties.NullValuePromptShowForEmptyValue = true;
            this.DocumentSumSE.Size = new System.Drawing.Size(137, 20);
            this.DocumentSumSE.TabIndex = 13;
            // 
            // DocumentFilterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocumentSumSE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocumentNumberTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocumentTypesCB);
            this.Name = "DocumentFilterUC";
            this.Size = new System.Drawing.Size(228, 86);
            this.Load += new System.EventHandler(this.DocumentFilterUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentSumSE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocumentNumberTB;
        private System.Windows.Forms.ComboBox DocumentTypesCB;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit DocumentSumSE;
    }
}
