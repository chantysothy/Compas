namespace Compas.AdminUI.Configuration
{
    partial class ConfigurationsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallationIDCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.DeleteSB});
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 456);
            this.panel2.TabIndex = 15;
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.InstallationIDCode,
            this.Description,
            this.ModeName,
            this.FullName,
            this.Parameter,
            this.Value,
            this.Comment});
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 0);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(789, 456);
            this.DataGV.TabIndex = 13;
            this.DataGV.VirtualMode = true;
            this.DataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // InstallationIDCode
            // 
            this.InstallationIDCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InstallationIDCode.DataPropertyName = "InstallationIDCode";
            this.InstallationIDCode.HeaderText = "Код інсталяції";
            this.InstallationIDCode.Name = "InstallationIDCode";
            this.InstallationIDCode.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle1;
            this.Description.HeaderText = "Опис інсталяції";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ModeName
            // 
            this.ModeName.DataPropertyName = "ModeName";
            this.ModeName.HeaderText = "Режим";
            this.ModeName.Name = "ModeName";
            this.ModeName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Користувач";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Parameter
            // 
            this.Parameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Parameter.DataPropertyName = "Parameter";
            this.Parameter.HeaderText = "Параметр";
            this.Parameter.Name = "Parameter";
            this.Parameter.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Значення";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Коментар";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // ConfigurationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ConfigurationsList";
            this.Text = "Конфігурації";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallationIDCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}