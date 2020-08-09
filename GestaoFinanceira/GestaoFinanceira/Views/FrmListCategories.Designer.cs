﻿namespace GestaoFinanceira.Views
{
    partial class FrmListCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvCategories = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnCategories = new System.Windows.Forms.Panel();
            this.lbCategories = new System.Windows.Forms.Label();
            this.dtgvSubCategories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategories)).BeginInit();
            this.pnCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCategories
            // 
            this.dtgvCategories.AllowUserToAddRows = false;
            this.dtgvCategories.AllowUserToDeleteRows = false;
            this.dtgvCategories.AllowUserToResizeColumns = false;
            this.dtgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descrição});
            this.dtgvCategories.Location = new System.Drawing.Point(45, 5);
            this.dtgvCategories.MultiSelect = false;
            this.dtgvCategories.Name = "dtgvCategories";
            this.dtgvCategories.ReadOnly = true;
            this.dtgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCategories.Size = new System.Drawing.Size(211, 169);
            this.dtgvCategories.TabIndex = 0;
            this.dtgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategories_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Descrição
            // 
            this.Descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrição.DataPropertyName = "Description";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descrição.HeaderText = "Categoria";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(45, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GestaoFinanceira.Properties.Resources.icons8_trash_can_26px;
            this.btnDelete.Location = new System.Drawing.Point(433, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::GestaoFinanceira.Properties.Resources.icons8_edit_26px;
            this.btnEdit.Location = new System.Drawing.Point(471, 184);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNovo.Location = new System.Drawing.Point(509, 182);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(36, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnCategories
            // 
            this.pnCategories.Controls.Add(this.lbCategories);
            this.pnCategories.Location = new System.Drawing.Point(-1, -2);
            this.pnCategories.Name = "pnCategories";
            this.pnCategories.Size = new System.Drawing.Size(39, 234);
            this.pnCategories.TabIndex = 2;
            // 
            // lbCategories
            // 
            this.lbCategories.Location = new System.Drawing.Point(0, 48);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(35, 159);
            this.lbCategories.TabIndex = 3;
            this.lbCategories.Paint += new System.Windows.Forms.PaintEventHandler(this.lbCategories_Paint);
            // 
            // dtgvSubCategories
            // 
            this.dtgvSubCategories.AllowUserToAddRows = false;
            this.dtgvSubCategories.AllowUserToDeleteRows = false;
            this.dtgvSubCategories.AllowUserToResizeColumns = false;
            this.dtgvSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSubCategories.BackgroundColor = System.Drawing.Color.White;
            this.dtgvSubCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSubCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1});
            this.dtgvSubCategories.Location = new System.Drawing.Point(262, 5);
            this.dtgvSubCategories.MultiSelect = false;
            this.dtgvSubCategories.Name = "dtgvSubCategories";
            this.dtgvSubCategories.ReadOnly = true;
            this.dtgvSubCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSubCategories.Size = new System.Drawing.Size(283, 169);
            this.dtgvSubCategories.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "SubCategorias";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FrmListCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(557, 227);
            this.ControlBox = false;
            this.Controls.Add(this.pnCategories);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtgvSubCategories);
            this.Controls.Add(this.dtgvCategories);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmListCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategories)).EndInit();
            this.pnCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCategories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnCategories;
        private System.Windows.Forms.Label lbCategories;
        private System.Windows.Forms.DataGridView dtgvSubCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}