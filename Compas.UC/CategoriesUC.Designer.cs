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
            this.components = new System.ComponentModel.Container();
            this.CategoriesTV = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CategoriesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CategoriesTV
            // 
            this.CategoriesTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesTV.FullRowSelect = true;
            this.CategoriesTV.HideSelection = false;
            this.CategoriesTV.HotTracking = true;
            this.CategoriesTV.ImageIndex = 0;
            this.CategoriesTV.ImageList = this.imageList1;
            this.CategoriesTV.Location = new System.Drawing.Point(0, 0);
            this.CategoriesTV.Name = "CategoriesTV";
            this.CategoriesTV.SelectedImageIndex = 0;
            this.CategoriesTV.Size = new System.Drawing.Size(240, 349);
            this.CategoriesTV.TabIndex = 0;
            this.CategoriesTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CategoriesTV_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CategoriesFLP
            // 
            this.CategoriesFLP.AutoScroll = true;
            this.CategoriesFLP.Location = new System.Drawing.Point(14, 49);
            this.CategoriesFLP.Name = "CategoriesFLP";
            this.CategoriesFLP.Size = new System.Drawing.Size(205, 237);
            this.CategoriesFLP.TabIndex = 1;
            // 
            // CategoriesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CategoriesFLP);
            this.Controls.Add(this.CategoriesTV);
            this.Name = "CategoriesUC";
            this.Size = new System.Drawing.Size(240, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView CategoriesTV;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel CategoriesFLP;
    }
}
