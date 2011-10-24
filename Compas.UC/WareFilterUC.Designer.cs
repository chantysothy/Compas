namespace Compas.UC
{
    partial class WareFilterUC
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
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.ManufacturersCB = new System.Windows.Forms.ComboBox();
            this.UnitsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DropDownWidth = 500;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(109, 9);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(334, 21);
            this.CategoriesCB.TabIndex = 0;
            // 
            // ManufacturersCB
            // 
            this.ManufacturersCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ManufacturersCB.DropDownWidth = 500;
            this.ManufacturersCB.FormattingEnabled = true;
            this.ManufacturersCB.Location = new System.Drawing.Point(109, 36);
            this.ManufacturersCB.Name = "ManufacturersCB";
            this.ManufacturersCB.Size = new System.Drawing.Size(334, 21);
            this.ManufacturersCB.TabIndex = 1;
            // 
            // UnitsCB
            // 
            this.UnitsCB.DropDownWidth = 500;
            this.UnitsCB.FormattingEnabled = true;
            this.UnitsCB.Location = new System.Drawing.Point(109, 63);
            this.UnitsCB.Name = "UnitsCB";
            this.UnitsCB.Size = new System.Drawing.Size(334, 21);
            this.UnitsCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Категорія:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Виробник:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Од. вимірювання:";
            // 
            // WareFilterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnitsCB);
            this.Controls.Add(this.ManufacturersCB);
            this.Controls.Add(this.CategoriesCB);
            this.Name = "WareFilterUC";
            this.Size = new System.Drawing.Size(461, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.ComboBox ManufacturersCB;
        private System.Windows.Forms.ComboBox UnitsCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
