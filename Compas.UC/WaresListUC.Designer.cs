namespace Compas.UC
{
    partial class WaresListUC
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
            this.WaresLB = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.WaresLB)).BeginInit();
            this.SuspendLayout();
            // 
            // WaresLB
            // 
            this.WaresLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaresLB.Location = new System.Drawing.Point(0, 0);
            this.WaresLB.Name = "WaresLB";
            this.WaresLB.Size = new System.Drawing.Size(242, 307);
            this.WaresLB.TabIndex = 0;
            // 
            // WaresListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WaresLB);
            this.Name = "WaresListUC";
            this.Size = new System.Drawing.Size(242, 307);
            ((System.ComponentModel.ISupportInitialize)(this.WaresLB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl WaresLB;
    }
}
