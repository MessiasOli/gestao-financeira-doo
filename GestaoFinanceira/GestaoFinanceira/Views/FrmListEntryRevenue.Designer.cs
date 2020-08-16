﻿namespace GestaoFinanceira.Views
{
    partial class FrmListEntryRevenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtvRevenue = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRepeatEvery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRepeatUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnEtries = new System.Windows.Forms.Panel();
            this.lbEntries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRevenue)).BeginInit();
            this.pnEtries.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvRevenue
            // 
            this.dtvRevenue.AllowUserToAddRows = false;
            this.dtvRevenue.AllowUserToDeleteRows = false;
            this.dtvRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dtvRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.Descrição,
            this.cValue,
            this.cPaymentMethod,
            this.Column2,
            this.cCategories,
            this.Column3,
            this.cDate,
            this.cRepeatEvery,
            this.Column4,
            this.Column,
            this.cRepeatUntil,
            this.Column1});
            this.dtvRevenue.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvRevenue.Location = new System.Drawing.Point(46, 12);
            this.dtvRevenue.MultiSelect = false;
            this.dtvRevenue.Name = "dtvRevenue";
            this.dtvRevenue.ReadOnly = true;
            this.dtvRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvRevenue.Size = new System.Drawing.Size(740, 238);
            this.dtvRevenue.TabIndex = 0;
            this.dtvRevenue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvRevenue_CellContentClick);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "id";
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cId.Visible = false;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "description";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descrição.Width = 150;
            // 
            // cValue
            // 
            this.cValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cValue.DataPropertyName = "value";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.cValue.DefaultCellStyle = dataGridViewCellStyle1;
            this.cValue.HeaderText = "Valor";
            this.cValue.Name = "cValue";
            this.cValue.ReadOnly = true;
            this.cValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cValue.ToolTipText = "double";
            this.cValue.Width = 70;
            // 
            // cPaymentMethod
            // 
            this.cPaymentMethod.DataPropertyName = "paymentMethod";
            this.cPaymentMethod.HeaderText = "Conta";
            this.cPaymentMethod.Name = "cPaymentMethod";
            this.cPaymentMethod.ReadOnly = true;
            this.cPaymentMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CaptionCategories";
            this.Column2.HeaderText = "Categorias";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 175;
            // 
            // cCategories
            // 
            this.cCategories.DataPropertyName = "Categorie";
            this.cCategories.HeaderText = "Categoria";
            this.cCategories.Name = "cCategories";
            this.cCategories.ReadOnly = true;
            this.cCategories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCategories.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SubCategorie";
            this.Column3.HeaderText = "SubCategoria";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "date";
            this.cDate.HeaderText = "Data";
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRepeatEvery
            // 
            this.cRepeatEvery.DataPropertyName = "Repeat";
            dataGridViewCellStyle2.NullValue = null;
            this.cRepeatEvery.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRepeatEvery.HeaderText = "Repetir";
            this.cRepeatEvery.Name = "cRepeatEvery";
            this.cRepeatEvery.ReadOnly = true;
            this.cRepeatEvery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRepeatEvery.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CaptionRepeat";
            this.Column4.HeaderText = "Recorrente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column
            // 
            this.Column.DataPropertyName = "status";
            this.Column.HeaderText = "Status";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column.Visible = false;
            // 
            // cRepeatUntil
            // 
            this.cRepeatUntil.DataPropertyName = "RepeatUntil";
            this.cRepeatUntil.HeaderText = "Data repetição";
            this.cRepeatUntil.Name = "cRepeatUntil";
            this.cRepeatUntil.ReadOnly = true;
            this.cRepeatUntil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRepeatUntil.Visible = false;
            this.cRepeatUntil.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EntryType";
            this.Column1.HeaderText = "EntryType";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.Location = new System.Drawing.Point(742, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(46, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::GestaoFinanceira.Properties.Resources.icons8_edit_26px_2;
            this.btnEdit.Location = new System.Drawing.Point(699, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 33);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GestaoFinanceira.Properties.Resources.icons8_trash_26px_1;
            this.btnDelete.Location = new System.Drawing.Point(656, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnEtries
            // 
            this.pnEtries.Controls.Add(this.lbEntries);
            this.pnEtries.Location = new System.Drawing.Point(-5, -5);
            this.pnEtries.Name = "pnEtries";
            this.pnEtries.Size = new System.Drawing.Size(45, 308);
            this.pnEtries.TabIndex = 2;
            // 
            // lbEntries
            // 
            this.lbEntries.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntries.Location = new System.Drawing.Point(3, 104);
            this.lbEntries.Name = "lbEntries";
            this.lbEntries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEntries.Size = new System.Drawing.Size(36, 138);
            this.lbEntries.TabIndex = 3;
            this.lbEntries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEntries.Paint += new System.Windows.Forms.PaintEventHandler(this.lbEntries_Paint);
            // 
            // FrmListEntryRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 301);
            this.ControlBox = false;
            this.Controls.Add(this.dtvRevenue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnEtries);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListEntryRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmListEntryRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvRevenue)).EndInit();
            this.pnEtries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnEtries;
        private System.Windows.Forms.Label lbEntries;
        protected System.Windows.Forms.DataGridView dtvRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRepeatEvery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRepeatUntil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}