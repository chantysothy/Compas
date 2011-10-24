namespace Compas.AdminUI.Security
{
    partial class RoleActionsF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RolesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ActionsGV = new System.Windows.Forms.DataGridView();
            this.AllowAction = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.MsgL = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.DisplayMember = "Name";
            this.CategoriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(103, 28);
            this.CategoriesCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(266, 21);
            this.CategoriesCB.TabIndex = 7;
            this.CategoriesCB.ValueMember = "ID";
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(40, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Категорія:";
            // 
            // RolesCB
            // 
            this.RolesCB.DisplayMember = "Name";
            this.RolesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolesCB.FormattingEnabled = true;
            this.RolesCB.Location = new System.Drawing.Point(103, 2);
            this.RolesCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RolesCB.Name = "RolesCB";
            this.RolesCB.Size = new System.Drawing.Size(266, 21);
            this.RolesCB.TabIndex = 5;
            this.RolesCB.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(64, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Роль:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 515);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45763F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.54237F));
            this.tableLayoutPanel1.Controls.Add(this.ActionsGV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoriesCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RolesCB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MsgL, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 515);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // ActionsGV
            // 
            this.ActionsGV.AllowUserToAddRows = false;
            this.ActionsGV.AllowUserToDeleteRows = false;
            this.ActionsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActionsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllowAction,
            this.ID,
            this.ActionName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActionsGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.ActionsGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.ActionsGV.Location = new System.Drawing.Point(103, 54);
            this.ActionsGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActionsGV.Name = "ActionsGV";
            this.ActionsGV.RowHeadersVisible = false;
            this.ActionsGV.Size = new System.Drawing.Size(266, 389);
            this.ActionsGV.TabIndex = 20;
            this.ActionsGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ActionsGV_CellPainting);
            // 
            // AllowAction
            // 
            this.AllowAction.FillWeight = 38.07107F;
            this.AllowAction.HeaderText = "Дозволити";
            this.AllowAction.Name = "AllowAction";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ActionName
            // 
            this.ActionName.DataPropertyName = "Name";
            this.ActionName.FillWeight = 111.9289F;
            this.ActionName.HeaderText = "Назва дії";
            this.ActionName.Name = "ActionName";
            this.ActionName.ReadOnly = true;
            this.ActionName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 387);
            this.label3.TabIndex = 19;
            this.label3.Text = "Доступні дії:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25F));
            this.tableLayoutPanel2.Controls.Add(this.DeleteBt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveBt, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 447);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(266, 45);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // DeleteBt
            // 
            this.DeleteBt.Image = global::Compas.AdminUI.Properties.Resources.button_cancel__1_;
            this.DeleteBt.Location = new System.Drawing.Point(134, 2);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(110, 40);
            this.DeleteBt.TabIndex = 19;
            this.DeleteBt.Text = "Відмінити";
            this.DeleteBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = global::Compas.AdminUI.Properties.Resources.button_ok__1_;
            this.SaveBt.Location = new System.Drawing.Point(2, 2);
            this.SaveBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(110, 40);
            this.SaveBt.TabIndex = 18;
            this.SaveBt.Text = "Зберегти";
            this.SaveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // MsgL
            // 
            this.MsgL.AutoSize = true;
            this.MsgL.Location = new System.Drawing.Point(104, 495);
            this.MsgL.Name = "MsgL";
            this.MsgL.Size = new System.Drawing.Size(0, 13);
            this.MsgL.TabIndex = 22;
            // 
            // RoleActionsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 527);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(401, 1053);
            this.Name = "RoleActionsF";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Text = "Дії ролей";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RolesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ActionsGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label MsgL;

    }
}