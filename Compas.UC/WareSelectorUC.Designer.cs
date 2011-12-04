namespace Compas.UC
{
    partial class WareSelectorUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WaresUpBt = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WaresDownBt = new System.Windows.Forms.Button();
            this.CategoriesDownBt = new System.Windows.Forms.Button();
            this.CategoriesUpBt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.WaresGV = new System.Windows.Forms.DataGridView();
            this.WareIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CancelBt = new System.Windows.Forms.Button();
            this.WaresFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.categoriesUC2 = new Compas.UC.CategoriesUC();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaresGV)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(452, 75);
            this.panel8.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.72222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.27778F));
            this.tableLayoutPanel1.Controls.Add(this.CodeTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CodeTB
            // 
            this.CodeTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeTB.Location = new System.Drawing.Point(111, 38);
            this.CodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(200, 26);
            this.CodeTB.TabIndex = 0;
            this.CodeTB.TextChanged += new System.EventHandler(this.CodeTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Код:";
            // 
            // NameTB
            // 
            this.NameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(111, 4);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 26);
            this.NameTB.TabIndex = 24;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(43, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Назва:";
            // 
            // WaresUpBt
            // 
            this.WaresUpBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.WaresUpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaresUpBt.Image = global::Compas.UC.Properties.Resources.navigate_up;
            this.WaresUpBt.Location = new System.Drawing.Point(0, 0);
            this.WaresUpBt.Name = "WaresUpBt";
            this.WaresUpBt.Size = new System.Drawing.Size(452, 62);
            this.WaresUpBt.TabIndex = 0;
            this.WaresUpBt.UseVisualStyleBackColor = true;
            this.WaresUpBt.Click += new System.EventHandler(this.WaresUpBt_Click);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.WaresUpBt);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(452, 62);
            this.panel7.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.categoriesUC2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 367);
            this.panel4.TabIndex = 3;
            // 
            // WaresDownBt
            // 
            this.WaresDownBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WaresDownBt.Image = global::Compas.UC.Properties.Resources.navigate_down__1_;
            this.WaresDownBt.Location = new System.Drawing.Point(0, 0);
            this.WaresDownBt.Name = "WaresDownBt";
            this.WaresDownBt.Size = new System.Drawing.Size(452, 62);
            this.WaresDownBt.TabIndex = 1;
            this.WaresDownBt.UseVisualStyleBackColor = true;
            this.WaresDownBt.Click += new System.EventHandler(this.WaresDownBt_Click);
            // 
            // CategoriesDownBt
            // 
            this.CategoriesDownBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CategoriesDownBt.Image = global::Compas.UC.Properties.Resources.navigate_down__1_;
            this.CategoriesDownBt.Location = new System.Drawing.Point(0, 0);
            this.CategoriesDownBt.Name = "CategoriesDownBt";
            this.CategoriesDownBt.Size = new System.Drawing.Size(342, 62);
            this.CategoriesDownBt.TabIndex = 2;
            this.CategoriesDownBt.UseVisualStyleBackColor = true;
            this.CategoriesDownBt.Click += new System.EventHandler(this.CategoriesDownBt_Click);
            // 
            // CategoriesUpBt
            // 
            this.CategoriesUpBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesUpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesUpBt.Image = global::Compas.UC.Properties.Resources.navigate_up;
            this.CategoriesUpBt.Location = new System.Drawing.Point(0, 0);
            this.CategoriesUpBt.Name = "CategoriesUpBt";
            this.CategoriesUpBt.Size = new System.Drawing.Size(342, 62);
            this.CategoriesUpBt.TabIndex = 1;
            this.CategoriesUpBt.UseVisualStyleBackColor = true;
            this.CategoriesUpBt.Click += new System.EventHandler(this.CategoriesUpBt_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.CategoriesDownBt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 62);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(798, 555);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.CategoriesUpBt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 62);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            this.splitContainer2.Panel1.Controls.Add(this.panel6);
            this.splitContainer2.Panel1.Controls.Add(this.panel7);
            this.splitContainer2.Panel1.Controls.Add(this.panel8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.CancelBt);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(452, 555);
            this.splitContainer2.SplitterDistance = 356;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.WaresFLP);
            this.panel5.Controls.Add(this.WaresGV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(452, 356);
            this.panel5.TabIndex = 7;
            // 
            // WaresGV
            // 
            this.WaresGV.AllowUserToAddRows = false;
            this.WaresGV.AllowUserToDeleteRows = false;
            this.WaresGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaresGV.ColumnHeadersVisible = false;
            this.WaresGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WareIDColumn,
            this.WareName,
            this.Price,
            this.UnitName});
            this.WaresGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaresGV.Location = new System.Drawing.Point(0, 0);
            this.WaresGV.Name = "WaresGV";
            this.WaresGV.ReadOnly = true;
            this.WaresGV.RowHeadersVisible = false;
            this.WaresGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaresGV.RowTemplate.Height = 40;
            this.WaresGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WaresGV.Size = new System.Drawing.Size(452, 356);
            this.WaresGV.TabIndex = 0;
            this.WaresGV.SelectionChanged += new System.EventHandler(this.WaresGV_SelectionChanged);
            // 
            // WareIDColumn
            // 
            this.WareIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareIDColumn.DataPropertyName = "ID";
            this.WareIDColumn.HeaderText = "WareID";
            this.WareIDColumn.Name = "WareIDColumn";
            this.WareIDColumn.ReadOnly = true;
            this.WareIDColumn.Visible = false;
            // 
            // WareName
            // 
            this.WareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareName.DataPropertyName = "Name";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WareName.DefaultCellStyle = dataGridViewCellStyle1;
            this.WareName.HeaderText = "Назва";
            this.WareName.Name = "WareName";
            this.WareName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Ціна";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "UnitName";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.WaresDownBt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 493);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(452, 62);
            this.panel6.TabIndex = 6;
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBt.Location = new System.Drawing.Point(27, 601);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(200, 62);
            this.CancelBt.TabIndex = 12;
            this.CancelBt.Text = "Закрити";
            this.CancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBt.UseVisualStyleBackColor = true;
            // 
            // WaresFLP
            // 
            this.WaresFLP.AutoScroll = true;
            this.WaresFLP.Location = new System.Drawing.Point(36, 28);
            this.WaresFLP.Name = "WaresFLP";
            this.WaresFLP.Size = new System.Drawing.Size(377, 280);
            this.WaresFLP.TabIndex = 1;
            // 
            // categoriesUC2
            // 
            this.categoriesUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesUC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriesUC2.Location = new System.Drawing.Point(0, 0);
            this.categoriesUC2.Margin = new System.Windows.Forms.Padding(6);
            this.categoriesUC2.Name = "categoriesUC2";
            this.categoriesUC2.Size = new System.Drawing.Size(342, 367);
            this.categoriesUC2.TabIndex = 0;
            this.categoriesUC2.ViewMode = Compas.UC.CategoriesUC.Mode.Button;
            this.categoriesUC2.SelectedCategoryChanged += new System.EventHandler(this.categoriesUC2_SelectedCategoryChanged_1);
            // 
            // WareSelectorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "WareSelectorUC";
            this.Size = new System.Drawing.Size(798, 555);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaresGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button WaresUpBt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private CategoriesUC categoriesUC1;
        private System.Windows.Forms.Button WaresDownBt;
        private System.Windows.Forms.Button CategoriesDownBt;
        private System.Windows.Forms.Button CategoriesUpBt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView WaresGV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private CategoriesUC categoriesUC2;
        private System.Windows.Forms.FlowLayoutPanel WaresFLP;
    }
}
