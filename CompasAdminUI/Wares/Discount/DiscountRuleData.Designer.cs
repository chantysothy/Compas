namespace Compas.AdminUI.Wares.Discount

{
    partial class DiscountRuleData
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
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartNUD = new System.Windows.Forms.NumericUpDown();
            this.EndNUD = new System.Windows.Forms.NumericUpDown();
            this.DiscountPercentNUD = new System.Windows.Forms.NumericUpDown();
            this.EndCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountPercentNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(248, 144);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(150, 50);
            this.CancelBt.TabIndex = 17;
            this.CancelBt.Text = "Відмінити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(46, 144);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Починаючи з:";
            // 
            // StartNUD
            // 
            this.StartNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartNUD.Location = new System.Drawing.Point(171, 22);
            this.StartNUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.StartNUD.Name = "StartNUD";
            this.StartNUD.Size = new System.Drawing.Size(141, 26);
            this.StartNUD.TabIndex = 19;
            // 
            // EndNUD
            // 
            this.EndNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndNUD.Location = new System.Drawing.Point(171, 57);
            this.EndNUD.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.EndNUD.Name = "EndNUD";
            this.EndNUD.Size = new System.Drawing.Size(141, 26);
            this.EndNUD.TabIndex = 21;
            // 
            // DiscountPercentNUD
            // 
            this.DiscountPercentNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountPercentNUD.Location = new System.Drawing.Point(171, 89);
            this.DiscountPercentNUD.Name = "DiscountPercentNUD";
            this.DiscountPercentNUD.Size = new System.Drawing.Size(141, 26);
            this.DiscountPercentNUD.TabIndex = 22;
            // 
            // EndCB
            // 
            this.EndCB.AutoSize = true;
            this.EndCB.Checked = true;
            this.EndCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EndCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndCB.Location = new System.Drawing.Point(318, 63);
            this.EndCB.Name = "EndCB";
            this.EndCB.Size = new System.Drawing.Size(15, 14);
            this.EndCB.TabIndex = 23;
            this.EndCB.UseVisualStyleBackColor = true;
            this.EndCB.CheckedChanged += new System.EventHandler(this.EndCB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "По:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "% знижки:";
            // 
            // DiscountRuleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndCB);
            this.Controls.Add(this.DiscountPercentNUD);
            this.Controls.Add(this.EndNUD);
            this.Controls.Add(this.StartNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Name = "DiscountRuleData";
            this.Text = "Дані правила знижки";
            ((System.ComponentModel.ISupportInitialize)(this.StartNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountPercentNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StartNUD;
        private System.Windows.Forms.NumericUpDown EndNUD;
        private System.Windows.Forms.NumericUpDown DiscountPercentNUD;
        private System.Windows.Forms.CheckBox EndCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}