namespace Compas.AdminUI.Security
{
    partial class UserRolesForm
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
            this.LFML = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginL = new System.Windows.Forms.Label();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.RolesLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Користувач:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ролі:";
            // 
            // LFML
            // 
            this.LFML.AutoSize = true;
            this.LFML.Location = new System.Drawing.Point(87, 19);
            this.LFML.Name = "LFML";
            this.LFML.Size = new System.Drawing.Size(35, 13);
            this.LFML.TabIndex = 4;
            this.LFML.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Логін:";
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Location = new System.Drawing.Point(87, 48);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(35, 13);
            this.LoginL.TabIndex = 6;
            this.LoginL.Text = "label5";
            // 
            // CancelBt
            // 
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(320, 403);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(150, 50);
            this.CancelBt.TabIndex = 49;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(130, 403);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 48;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // RolesLB
            // 
            this.RolesLB.CheckOnClick = true;
            this.RolesLB.FormattingEnabled = true;
            this.RolesLB.Location = new System.Drawing.Point(90, 78);
            this.RolesLB.Name = "RolesLB";
            this.RolesLB.Size = new System.Drawing.Size(439, 304);
            this.RolesLB.TabIndex = 50;
            // 
            // UserRolesForm
            // 
            this.AcceptButton = this.SaveBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBt;
            this.ClientSize = new System.Drawing.Size(541, 474);
            this.Controls.Add(this.RolesLB);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.LoginL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LFML);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserRolesForm";
            this.Text = "UserRolesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LFML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.CheckedListBox RolesLB;
    }
}