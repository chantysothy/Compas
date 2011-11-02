namespace Compas.AdminUI.Wares.Ware
{
    partial class WareComponentDataSimple
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
            this.CancelBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.AddComponentBt = new System.Windows.Forms.Button();
            this.WareComponentsGV = new System.Windows.Forms.DataGridView();
            this.WareComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareNameL = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DeleteComponentBt = new System.Windows.Forms.Button();
            this.WareParametersPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UnitQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.wareSelectorUC1 = new Compas.UC.WareSelectorUC();
            ((System.ComponentModel.ISupportInitialize)(this.WareComponentsGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.WareParametersPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitQuantityNUD)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.CancelBt.Location = new System.Drawing.Point(497, 6);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(177, 74);
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
            this.SaveBt.Location = new System.Drawing.Point(305, 6);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(177, 74);
            this.SaveBt.TabIndex = 16;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // AddComponentBt
            // 
            this.AddComponentBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddComponentBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddComponentBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.AddComponentBt.Location = new System.Drawing.Point(214, 3);
            this.AddComponentBt.Name = "AddComponentBt";
            this.AddComponentBt.Size = new System.Drawing.Size(203, 45);
            this.AddComponentBt.TabIndex = 82;
            this.AddComponentBt.Text = "Додати компонент";
            this.AddComponentBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddComponentBt.UseVisualStyleBackColor = true;
            this.AddComponentBt.Click += new System.EventHandler(this.AddComponentBt_Click);
            // 
            // WareComponentsGV
            // 
            this.WareComponentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WareComponentsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WareComponentID,
            this.WareComponentName,
            this.UnitName,
            this.UnitQuantity});
            this.WareComponentsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WareComponentsGV.Location = new System.Drawing.Point(0, 0);
            this.WareComponentsGV.Name = "WareComponentsGV";
            this.WareComponentsGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.WareComponentsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WareComponentsGV.Size = new System.Drawing.Size(422, 345);
            this.WareComponentsGV.TabIndex = 77;
            // 
            // WareComponentID
            // 
            this.WareComponentID.DataPropertyName = "ID";
            this.WareComponentID.HeaderText = "ID";
            this.WareComponentID.Name = "WareComponentID";
            this.WareComponentID.Visible = false;
            // 
            // WareComponentName
            // 
            this.WareComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareComponentName.DataPropertyName = "WareComponentName";
            this.WareComponentName.HeaderText = "Назва";
            this.WareComponentName.Name = "WareComponentName";
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Од. вим.";
            this.UnitName.Name = "UnitName";
            // 
            // UnitQuantity
            // 
            this.UnitQuantity.DataPropertyName = "UnitQuantity";
            this.UnitQuantity.HeaderText = "К-ть";
            this.UnitQuantity.Name = "UnitQuantity";
            // 
            // WareNameL
            // 
            this.WareNameL.AutoSize = true;
            this.WareNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WareNameL.ForeColor = System.Drawing.Color.White;
            this.WareNameL.Location = new System.Drawing.Point(52, 16);
            this.WareNameL.Name = "WareNameL";
            this.WareNameL.Size = new System.Drawing.Size(60, 24);
            this.WareNameL.TabIndex = 1;
            this.WareNameL.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBt);
            this.panel1.Controls.Add(this.SaveBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 86);
            this.panel1.TabIndex = 81;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.wareSelectorUC1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.WareParametersPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 430);
            this.splitContainer1.SplitterDistance = 634;
            this.splitContainer1.TabIndex = 82;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 370);
            this.panel4.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 370);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перелік компонентів номенклатурної одиниці";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.WareComponentsGV);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(422, 345);
            this.panel7.TabIndex = 79;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DeleteComponentBt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(425, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(66, 345);
            this.panel6.TabIndex = 78;
            // 
            // DeleteComponentBt
            // 
            this.DeleteComponentBt.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteComponentBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteComponentBt.Image = global::Compas.AdminUI.Properties.Resources.delete;
            this.DeleteComponentBt.Location = new System.Drawing.Point(0, 0);
            this.DeleteComponentBt.Name = "DeleteComponentBt";
            this.DeleteComponentBt.Size = new System.Drawing.Size(66, 70);
            this.DeleteComponentBt.TabIndex = 78;
            this.DeleteComponentBt.Tag = "Видалити";
            this.DeleteComponentBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteComponentBt.UseVisualStyleBackColor = true;
            this.DeleteComponentBt.Click += new System.EventHandler(this.DeleteComponentBt_Click);
            // 
            // WareParametersPanel
            // 
            this.WareParametersPanel.Controls.Add(this.tableLayoutPanel1);
            this.WareParametersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WareParametersPanel.Location = new System.Drawing.Point(0, 0);
            this.WareParametersPanel.Name = "WareParametersPanel";
            this.WareParametersPanel.Size = new System.Drawing.Size(494, 60);
            this.WareParametersPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.60189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.39811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.AddComponentBt, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnitQuantityNUD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 51);
            this.tableLayoutPanel1.TabIndex = 84;
            // 
            // UnitQuantityNUD
            // 
            this.UnitQuantityNUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitQuantityNUD.DecimalPlaces = 3;
            this.UnitQuantityNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitQuantityNUD.Location = new System.Drawing.Point(95, 12);
            this.UnitQuantityNUD.Name = "UnitQuantityNUD";
            this.UnitQuantityNUD.Size = new System.Drawing.Size(113, 26);
            this.UnitQuantityNUD.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Кількість:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.WareNameL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 53);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(1132, 487);
            this.splitContainer3.SplitterDistance = 53;
            this.splitContainer3.TabIndex = 83;
            // 
            // wareSelectorUC1
            // 
            this.wareSelectorUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wareSelectorUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wareSelectorUC1.Location = new System.Drawing.Point(0, 0);
            this.wareSelectorUC1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wareSelectorUC1.Name = "wareSelectorUC1";
            this.wareSelectorUC1.Size = new System.Drawing.Size(634, 430);
            this.wareSelectorUC1.TabIndex = 0;
            this.wareSelectorUC1.SelectedWareChanged += new System.EventHandler(this.wareSelectorUC1_SelectedWareChanged);
            // 
            // WareComponentDataSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 573);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.panel1);
            this.Name = "WareComponentDataSimple";
            this.Text = "Компоненти";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterpriseData_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WareComponentsGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.WareParametersPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitQuantityNUD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button AddComponentBt;
        private System.Windows.Forms.DataGridView WareComponentsGV;
        private System.Windows.Forms.Label WareNameL;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button DeleteComponentBt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareComponentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitQuantity;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private UC.WareSelectorUC wareSelectorUC1;
        private System.Windows.Forms.NumericUpDown UnitQuantityNUD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel WareParametersPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}