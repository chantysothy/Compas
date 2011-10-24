namespace Compas.AdminUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.securityCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.securityCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add.png");
            this.imageList1.Images.SetKeyName(1, "Bank.png");
            this.imageList1.Images.SetKeyName(2, "Briefcase.png");
            this.imageList1.Images.SetKeyName(3, "Business People.png");
            this.imageList1.Images.SetKeyName(4, "Business_People_01.png");
            this.imageList1.Images.SetKeyName(5, "Calculator.png");
            this.imageList1.Images.SetKeyName(6, "Calendar.png");
            this.imageList1.Images.SetKeyName(7, "Calendar_01.png");
            this.imageList1.Images.SetKeyName(8, "Card.png");
            this.imageList1.Images.SetKeyName(9, "Catalog.png");
            this.imageList1.Images.SetKeyName(10, "Chart.png");
            this.imageList1.Images.SetKeyName(11, "Chart_01.png");
            this.imageList1.Images.SetKeyName(12, "Chart_02.png");
            this.imageList1.Images.SetKeyName(13, "Chat.png");
            this.imageList1.Images.SetKeyName(14, "Chat_01.png");
            this.imageList1.Images.SetKeyName(15, "Close.png");
            this.imageList1.Images.SetKeyName(16, "Configure.png");
            this.imageList1.Images.SetKeyName(17, "Cut.png");
            this.imageList1.Images.SetKeyName(18, "Delete.png");
            this.imageList1.Images.SetKeyName(19, "StructureObject.png");
            this.imageList1.Images.SetKeyName(20, "Diagram.png");
            this.imageList1.Images.SetKeyName(21, "Fix.png");
            this.imageList1.Images.SetKeyName(22, "Flag.png");
            this.imageList1.Images.SetKeyName(23, "Flag_01.png");
            this.imageList1.Images.SetKeyName(24, "Folder.png");
            this.imageList1.Images.SetKeyName(25, "Folder_01.png");
            this.imageList1.Images.SetKeyName(26, "Folder_share.png");
            this.imageList1.Images.SetKeyName(27, "Help.png");
            this.imageList1.Images.SetKeyName(28, "Home_01.png");
            this.imageList1.Images.SetKeyName(29, "House.png");
            this.imageList1.Images.SetKeyName(30, "increase.png");
            this.imageList1.Images.SetKeyName(31, "Internet.png");
            this.imageList1.Images.SetKeyName(32, "Internet_link.png");
            this.imageList1.Images.SetKeyName(33, "Internet_link_02.png");
            this.imageList1.Images.SetKeyName(34, "Key.png");
            this.imageList1.Images.SetKeyName(35, "light.png");
            this.imageList1.Images.SetKeyName(36, "Lock.png");
            this.imageList1.Images.SetKeyName(37, "marked_price.png");
            this.imageList1.Images.SetKeyName(38, "options.png");
            this.imageList1.Images.SetKeyName(39, "People.png");
            this.imageList1.Images.SetKeyName(40, "Refresh.png");
            this.imageList1.Images.SetKeyName(41, "Shopping.png");
            this.imageList1.Images.SetKeyName(42, "Tool.png");
            this.imageList1.Images.SetKeyName(43, "Trash.png");
            this.imageList1.Images.SetKeyName(44, "Unlocked.png");
            this.imageList1.Images.SetKeyName(45, "User Card.png");
            this.imageList1.Images.SetKeyName(46, "User_info.png");
            this.imageList1.Images.SetKeyName(47, "Usercard_01.png");
            this.imageList1.Images.SetKeyName(48, "Users_Group.png");
            this.imageList1.Images.SetKeyName(49, "Zoom in.png");
            this.imageList1.Images.SetKeyName(50, "Zoom out.png");
            // 
            // securityCategoryBindingSource
            // 
            this.securityCategoryBindingSource.DataSource = typeof(Compas.Model.SecurityCategory);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 264);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.securityCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource securityCategoryBindingSource;
        private AdminMenuUC adminMenuUC1;
    }
}