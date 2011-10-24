namespace Compas.AdminUI.Staff
{
    partial class EmployeSalariesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeL = new System.Windows.Forms.Label();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewExtensionComponent1 = new CompletIT.Windows.DataGridViewExtension.DataGridViewExtensionComponent(this.components);
            this.NewSB = new System.Windows.Forms.ToolStripButton();
            this.EditSB = new System.Windows.Forms.ToolStripButton();
            this.DeleteSB = new System.Windows.Forms.ToolStripButton();
            this.CalculateSalarySB = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StructureObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.CalculateSalarySB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(789, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeeL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 35);
            this.panel1.TabIndex = 14;
            // 
            // EmployeeL
            // 
            this.EmployeeL.AutoSize = true;
            this.EmployeeL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeL.Location = new System.Drawing.Point(8, 8);
            this.EmployeeL.Name = "EmployeeL";
            this.EmployeeL.Size = new System.Drawing.Size(59, 19);
            this.EmployeeL.TabIndex = 0;
            this.EmployeeL.Text = "label1";
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Month,
            this.EmployeeFullName,
            this.StructureObjectName,
            this.SumSale,
            this.ExtraPercent,
            this.Salary,
            this.SumSalary});
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(0, 74);
            this.DataGV.MultiSelect = false;
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(789, 421);
            this.DataGV.TabIndex = 15;
            this.DataGV.VirtualMode = true;
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
            // CalculateSalarySB
            // 
            this.CalculateSalarySB.Image = global::Compas.AdminUI.Properties.Resources.Money1;
            this.CalculateSalarySB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculateSalarySB.Name = "CalculateSalarySB";
            this.CalculateSalarySB.Size = new System.Drawing.Size(139, 36);
            this.CalculateSalarySB.Text = "Нарахування";
            this.CalculateSalarySB.Click += new System.EventHandler(this.CalculateSalarySB_Click);
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Місяць";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.EmployeeFullName.HeaderText = "ПІП Працівника";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // StructureObjectName
            // 
            this.StructureObjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StructureObjectName.DataPropertyName = "StructureObjectName";
            this.StructureObjectName.HeaderText = "Назва відділу";
            this.StructureObjectName.Name = "StructureObjectName";
            this.StructureObjectName.ReadOnly = true;
            // 
            // SumSale
            // 
            this.SumSale.DataPropertyName = "SumSale";
            dataGridViewCellStyle1.Format = "N2";
            this.SumSale.DefaultCellStyle = dataGridViewCellStyle1;
            this.SumSale.HeaderText = "Сума продаж за місяць";
            this.SumSale.Name = "SumSale";
            this.SumSale.ReadOnly = true;
            // 
            // ExtraPercent
            // 
            this.ExtraPercent.DataPropertyName = "ExtraPercent";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ExtraPercent.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExtraPercent.HeaderText = "% від продажу";
            this.ExtraPercent.Name = "ExtraPercent";
            this.ExtraPercent.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Salary.DefaultCellStyle = dataGridViewCellStyle3;
            this.Salary.HeaderText = "Оклад";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // SumSalary
            // 
            this.SumSalary.DataPropertyName = "SumSalary";
            dataGridViewCellStyle4.Format = "N2";
            this.SumSalary.DefaultCellStyle = dataGridViewCellStyle4;
            this.SumSalary.HeaderText = "Оклад + %";
            this.SumSalary.Name = "SumSalary";
            this.SumSalary.ReadOnly = true;
            // 
            // EmployeSalariesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 495);
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmployeSalariesList";
            this.Text = "Дані по зарплатам";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamsList_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmployeeL;
        private System.Windows.Forms.DataGridView DataGV;
        private CompletIT.Windows.DataGridViewExtension.DataGridViewExtensionComponent dataGridViewExtensionComponent1;
        private System.Windows.Forms.ToolStripButton CalculateSalarySB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StructureObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumSalary;
    }
}