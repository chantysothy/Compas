namespace Compas.AdminUI.Wares.Remain
{
    partial class RemainsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemainsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.RefreshSB = new System.Windows.Forms.ToolStripButton();
            this.RecalculateSB = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ApplyFilterBt = new System.Windows.Forms.Button();
            this.universalFilter1 = new Compas.UC.UniversalFilter();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StructureObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSB,
            this.EditSB,
            this.DeleteSB,
            this.RefreshSB,
            this.RecalculateSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(789, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewSB
            // 
            this.NewSB.Image = global::Compas.AdminUI.Properties.Resources.add2_;
            this.NewSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewSB.Name = "NewSB";
            this.NewSB.Size = new System.Drawing.Size(99, 36);
            this.NewSB.Text = "Додати";
            this.NewSB.Click += new System.EventHandler(this.NewSB_Click);
            // 
            // EditSB
            // 
            this.EditSB.Image = global::Compas.AdminUI.Properties.Resources.edit;
            this.EditSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSB.Name = "EditSB";
            this.EditSB.Size = new System.Drawing.Size(126, 36);
            this.EditSB.Text = "Редагувати";
            this.EditSB.Click += new System.EventHandler(this.EditSB_Click);
            // 
            // DeleteSB
            // 
            this.DeleteSB.Image = global::Compas.AdminUI.Properties.Resources.delete;
            this.DeleteSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteSB.Name = "DeleteSB";
            this.DeleteSB.Size = new System.Drawing.Size(114, 36);
            this.DeleteSB.Text = "Видалити";
            this.DeleteSB.Click += new System.EventHandler(this.DeleteSB_Click);
            // 
            // RefreshSB
            // 
            this.RefreshSB.Image = global::Compas.AdminUI.Properties.Resources.refresh_blue;
            this.RefreshSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshSB.Name = "RefreshSB";
            this.RefreshSB.Size = new System.Drawing.Size(109, 36);
            this.RefreshSB.Text = "Оновити";
            this.RefreshSB.Click += new System.EventHandler(this.RefreshSB_Click);
            // 
            // RecalculateSB
            // 
            this.RecalculateSB.Image = ((System.Drawing.Image)(resources.GetObject("RecalculateSB.Image")));
            this.RecalculateSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecalculateSB.Name = "RecalculateSB";
            this.RecalculateSB.Size = new System.Drawing.Size(146, 36);
            this.RecalculateSB.Text = "Перерахувати";
            this.RecalculateSB.Click += new System.EventHandler(this.RecalculateSB_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Compas.AdminUI.Properties.Resources.file_edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Compas.AdminUI.Properties.Resources.file_delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGV);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(789, 456);
            this.splitContainerControl1.SplitterPosition = 327;
            this.splitContainerControl1.TabIndex = 14;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ApplyFilterBt);
            this.groupControl1.Controls.Add(this.universalFilter1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 378);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Фільтр залишків";
            // 
            // ApplyFilterBt
            // 
            this.ApplyFilterBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.ApplyFilterBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFilterBt.Location = new System.Drawing.Point(117, 320);
            this.ApplyFilterBt.Name = "ApplyFilterBt";
            this.ApplyFilterBt.Size = new System.Drawing.Size(151, 46);
            this.ApplyFilterBt.TabIndex = 24;
            this.ApplyFilterBt.Text = "Застосувати фільтр";
            this.ApplyFilterBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyFilterBt.UseVisualStyleBackColor = true;
            this.ApplyFilterBt.Click += new System.EventHandler(this.ApplyFilterBt_Click);
            // 
            // universalFilter1
            // 
            this.universalFilter1.Location = new System.Drawing.Point(6, 26);
            this.universalFilter1.Name = "universalFilter1";
            this.universalFilter1.Size = new System.Drawing.Size(311, 288);
            this.universalFilter1.TabIndex = 25;
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StructureObjectName,
            this.WareName,
            this.StartDate,
            this.EndDate,
            this.UnitQuantity,
            this.UnitName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(457, 456);
            this.DataGV.TabIndex = 14;
            this.DataGV.VirtualMode = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StructureObjectName
            // 
            this.StructureObjectName.DataPropertyName = "StructureObjectName";
            this.StructureObjectName.HeaderText = "Об\'єкт";
            this.StructureObjectName.Name = "StructureObjectName";
            this.StructureObjectName.ReadOnly = true;
            // 
            // WareName
            // 
            this.WareName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareName.DataPropertyName = "WareName";
            this.WareName.HeaderText = "Назва товару";
            this.WareName.Name = "WareName";
            this.WareName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Початок періоду";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "Кінець періоду";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // UnitQuantity
            // 
            this.UnitQuantity.DataPropertyName = "UnitQuantity";
            this.UnitQuantity.HeaderText = "К-ть одиниць";
            this.UnitQuantity.Name = "UnitQuantity";
            this.UnitQuantity.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Од. вим.";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // RemainsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RemainsList";
            this.Text = "Залишки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftsList_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton EditSB;
        private System.Windows.Forms.ToolStripButton DeleteSB;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripButton NewSB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StructureObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.ToolStripButton RefreshSB;
        private System.Windows.Forms.ToolStripButton RecalculateSB;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button ApplyFilterBt;
        private UC.UniversalFilter universalFilter1;
    }
}