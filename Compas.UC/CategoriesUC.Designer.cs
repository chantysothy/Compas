namespace Compas.UC
{
    partial class CategoriesUC
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
            this.CategoriesTV = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // CategoriesTV
            // 
            this.CategoriesTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesTV.FullRowSelect = true;
            this.CategoriesTV.HideSelection = false;
            this.CategoriesTV.HotTracking = true;
            this.CategoriesTV.Location = new System.Drawing.Point(0, 0);
            this.CategoriesTV.Name = "CategoriesTV";
            this.CategoriesTV.Size = new System.Drawing.Size(240, 349);
            this.CategoriesTV.TabIndex = 0;
            this.CategoriesTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CategoriesTV_AfterSelect);
            // 
            // CategoriesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoriesTV);
            this.Name = "CategoriesUC";
            this.Size = new System.Drawing.Size(240, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView CategoriesTV;
    }
}
