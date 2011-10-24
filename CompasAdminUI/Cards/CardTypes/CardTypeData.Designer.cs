namespace Compas.AdminUI.Cards
{
    partial class CardTypeData
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.AllowBalanceCB = new System.Windows.Forms.CheckBox();
            this.AllowMultipleCarsCB = new System.Windows.Forms.CheckBox();
            this.AvailableDiscountsGV = new System.Windows.Forms.DataGridView();
            this.AddBt = new System.Windows.Forms.Button();
            this.RemoveBt = new System.Windows.Forms.Button();
            this.AcceptedDiscountsGV = new System.Windows.Forms.DataGridView();
            this.DiscountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableDiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountName0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptedDiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountID0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableDiscountsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedDiscountsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Назва:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(103, 13);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(460, 20);
            this.NameTB.TabIndex = 14;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(387, 438);
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
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(185, 438);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(150, 50);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // AllowBalanceCB
            // 
            this.AllowBalanceCB.AutoSize = true;
            this.AllowBalanceCB.Location = new System.Drawing.Point(103, 42);
            this.AllowBalanceCB.Name = "AllowBalanceCB";
            this.AllowBalanceCB.Size = new System.Drawing.Size(128, 17);
            this.AllowBalanceCB.TabIndex = 18;
            this.AllowBalanceCB.Text = "Дозволений баланс";
            this.AllowBalanceCB.UseVisualStyleBackColor = true;
            // 
            // AllowMultipleCarsCB
            // 
            this.AllowMultipleCarsCB.AutoSize = true;
            this.AllowMultipleCarsCB.Location = new System.Drawing.Point(103, 66);
            this.AllowMultipleCarsCB.Name = "AllowMultipleCarsCB";
            this.AllowMultipleCarsCB.Size = new System.Drawing.Size(241, 17);
            this.AllowMultipleCarsCB.TabIndex = 19;
            this.AllowMultipleCarsCB.Text = "Дозволено кілька одиниць авто на картку";
            this.AllowMultipleCarsCB.UseVisualStyleBackColor = true;
            // 
            // AvailableDiscountsGV
            // 
            this.AvailableDiscountsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableDiscountsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiscountName,
            this.AvailableDiscountPercent,
            this.DiscountID});
            this.AvailableDiscountsGV.Location = new System.Drawing.Point(453, 90);
            this.AvailableDiscountsGV.MultiSelect = false;
            this.AvailableDiscountsGV.Name = "AvailableDiscountsGV";
            this.AvailableDiscountsGV.RowHeadersVisible = false;
            this.AvailableDiscountsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableDiscountsGV.Size = new System.Drawing.Size(290, 342);
            this.AvailableDiscountsGV.TabIndex = 21;
            // 
            // AddBt
            // 
            this.AddBt.Image = global::Compas.AdminUI.Properties.Resources.back;
            this.AddBt.Location = new System.Drawing.Point(400, 91);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(47, 50);
            this.AddBt.TabIndex = 38;
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // RemoveBt
            // 
            this.RemoveBt.Image = global::Compas.AdminUI.Properties.Resources.forward;
            this.RemoveBt.Location = new System.Drawing.Point(400, 144);
            this.RemoveBt.Name = "RemoveBt";
            this.RemoveBt.Size = new System.Drawing.Size(47, 50);
            this.RemoveBt.TabIndex = 39;
            this.RemoveBt.UseVisualStyleBackColor = true;
            this.RemoveBt.Click += new System.EventHandler(this.RemoveBt_Click);
            // 
            // AcceptedDiscountsGV
            // 
            this.AcceptedDiscountsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptedDiscountsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiscountName0,
            this.AcceptedDiscountPercent,
            this.DiscountID0});
            this.AcceptedDiscountsGV.Location = new System.Drawing.Point(103, 90);
            this.AcceptedDiscountsGV.MultiSelect = false;
            this.AcceptedDiscountsGV.Name = "AcceptedDiscountsGV";
            this.AcceptedDiscountsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AcceptedDiscountsGV.Size = new System.Drawing.Size(290, 342);
            this.AcceptedDiscountsGV.TabIndex = 20;
            // 
            // DiscountName
            // 
            this.DiscountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiscountName.DataPropertyName = "Name";
            this.DiscountName.HeaderText = "Назва";
            this.DiscountName.Name = "DiscountName";
            // 
            // AvailableDiscountPercent
            // 
            this.AvailableDiscountPercent.DataPropertyName = "DefaultDiscountPercent";
            this.AvailableDiscountPercent.HeaderText = "% по зам.";
            this.AvailableDiscountPercent.Name = "AvailableDiscountPercent";
            // 
            // DiscountID
            // 
            this.DiscountID.DataPropertyName = "ID";
            this.DiscountID.HeaderText = "ID";
            this.DiscountID.Name = "DiscountID";
            this.DiscountID.Visible = false;
            // 
            // DiscountName0
            // 
            this.DiscountName0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiscountName0.DataPropertyName = "Name";
            this.DiscountName0.HeaderText = "Знижка";
            this.DiscountName0.Name = "DiscountName0";
            // 
            // AcceptedDiscountPercent
            // 
            this.AcceptedDiscountPercent.DataPropertyName = "DefaultDiscountPercent";
            this.AcceptedDiscountPercent.HeaderText = "% по зам.";
            this.AcceptedDiscountPercent.Name = "AcceptedDiscountPercent";
            // 
            // DiscountID0
            // 
            this.DiscountID0.DataPropertyName = "ID";
            this.DiscountID0.HeaderText = "DiscountID0";
            this.DiscountID0.Name = "DiscountID0";
            this.DiscountID0.Visible = false;
            // 
            // CardTypeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 500);
            this.Controls.Add(this.RemoveBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.AvailableDiscountsGV);
            this.Controls.Add(this.AcceptedDiscountsGV);
            this.Controls.Add(this.AllowMultipleCarsCB);
            this.Controls.Add(this.AllowBalanceCB);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.Name = "CardTypeData";
            this.Text = "Дані одиниці вимірювання";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableDiscountsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedDiscountsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.CheckBox AllowBalanceCB;
        private System.Windows.Forms.CheckBox AllowMultipleCarsCB;
        private System.Windows.Forms.DataGridView AvailableDiscountsGV;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button RemoveBt;
        private System.Windows.Forms.DataGridView AcceptedDiscountsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableDiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountName0;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptedDiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountID0;
    }
}