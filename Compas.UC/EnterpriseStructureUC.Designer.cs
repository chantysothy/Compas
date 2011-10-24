namespace Compas.UC
{
    partial class EnterpriseStructureUC
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
            this.StructureObjectsCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShiftsCB = new System.Windows.Forms.ComboBox();
            this.TeamsCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StructureObjectsCB
            // 
            this.StructureObjectsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StructureObjectsCB.FormattingEnabled = true;
            this.StructureObjectsCB.Location = new System.Drawing.Point(104, 8);
            this.StructureObjectsCB.Name = "StructureObjectsCB";
            this.StructureObjectsCB.Size = new System.Drawing.Size(242, 28);
            this.StructureObjectsCB.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Відділ/підрозділ:";
            // 
            // ShiftsCB
            // 
            this.ShiftsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShiftsCB.FormattingEnabled = true;
            this.ShiftsCB.Location = new System.Drawing.Point(104, 45);
            this.ShiftsCB.Name = "ShiftsCB";
            this.ShiftsCB.Size = new System.Drawing.Size(242, 28);
            this.ShiftsCB.TabIndex = 38;
            // 
            // TeamsCB
            // 
            this.TeamsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsCB.FormattingEnabled = true;
            this.TeamsCB.Location = new System.Drawing.Point(104, 89);
            this.TeamsCB.Name = "TeamsCB";
            this.TeamsCB.Size = new System.Drawing.Size(242, 28);
            this.TeamsCB.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Бригада:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Зміна:";
            // 
            // DateDTP
            // 
            this.DateDTP.Checked = false;
            this.DateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateDTP.Location = new System.Drawing.Point(104, 127);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.ShowCheckBox = true;
            this.DateDTP.Size = new System.Drawing.Size(180, 26);
            this.DateDTP.TabIndex = 43;
            this.DateDTP.ValueChanged += new System.EventHandler(this.DateDTP_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Початок зміни:";
            // 
            // EnterpriseStructureUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StructureObjectsCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShiftsCB);
            this.Controls.Add(this.TeamsCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "EnterpriseStructureUC";
            this.Size = new System.Drawing.Size(349, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StructureObjectsCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ShiftsCB;
        private System.Windows.Forms.ComboBox TeamsCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.Label label2;

    }
}
