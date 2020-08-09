﻿namespace GestaoFinanceira.Views
{
    partial class FrmListBankAccount
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
            this.dtvBankAccount = new System.Windows.Forms.DataGridView();
            this.pnBankAccount = new System.Windows.Forms.Panel();
            this.lbBankAccount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvBankAccount)).BeginInit();
            this.pnBankAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvBankAccount
            // 
            this.dtvBankAccount.AllowUserToAddRows = false;
            this.dtvBankAccount.AllowUserToDeleteRows = false;
            this.dtvBankAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtvBankAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvBankAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvBankAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cBank,
            this.cAmount,
            this.cHolder,
            this.cAgency,
            this.cAccount,
            this.cLimit});
            this.dtvBankAccount.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvBankAccount.Location = new System.Drawing.Point(49, 13);
            this.dtvBankAccount.MultiSelect = false;
            this.dtvBankAccount.Name = "dtvBankAccount";
            this.dtvBankAccount.ReadOnly = true;
            this.dtvBankAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvBankAccount.Size = new System.Drawing.Size(681, 160);
            this.dtvBankAccount.TabIndex = 9;
            this.dtvBankAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvBankAccount_CellContentClick);
            // 
            // pnBankAccount
            // 
            this.pnBankAccount.Controls.Add(this.lbBankAccount);
            this.pnBankAccount.Location = new System.Drawing.Point(-2, -5);
            this.pnBankAccount.Name = "pnBankAccount";
            this.pnBankAccount.Size = new System.Drawing.Size(45, 234);
            this.pnBankAccount.TabIndex = 14;
            // 
            // lbBankAccount
            // 
            this.lbBankAccount.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBankAccount.Location = new System.Drawing.Point(3, 18);
            this.lbBankAccount.Name = "lbBankAccount";
            this.lbBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBankAccount.Size = new System.Drawing.Size(36, 204);
            this.lbBankAccount.TabIndex = 3;
            this.lbBankAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBankAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.lbBankAccount_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(49, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 36);
            this.btnCancel.TabIndex = 10;
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
            this.btnEdit.Location = new System.Drawing.Point(637, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 36);
            this.btnEdit.TabIndex = 11;
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
            this.btnDelete.Location = new System.Drawing.Point(594, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.Location = new System.Drawing.Point(680, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // cBank
            // 
            this.cBank.DataPropertyName = "Bank";
            this.cBank.HeaderText = "Banco";
            this.cBank.Name = "cBank";
            // 
            // cAmount
            // 
            this.cAmount.DataPropertyName = "balance";
            this.cAmount.HeaderText = "Saldo";
            this.cAmount.Name = "cAmount";
            // 
            // cHolder
            // 
            this.cHolder.DataPropertyName = "holder";
            this.cHolder.HeaderText = "Titular";
            this.cHolder.Name = "cHolder";
            this.cHolder.Width = 170;
            // 
            // cAgency
            // 
            this.cAgency.DataPropertyName = "Agency";
            this.cAgency.HeaderText = "Agencia";
            this.cAgency.Name = "cAgency";
            this.cAgency.Width = 70;
            // 
            // cAccount
            // 
            this.cAccount.DataPropertyName = "AccountBank";
            this.cAccount.HeaderText = "Conta";
            this.cAccount.Name = "cAccount";
            // 
            // cLimit
            // 
            this.cLimit.DataPropertyName = "Limit";
            this.cLimit.HeaderText = "Limite";
            this.cLimit.Name = "cLimit";
            // 
            // FrmListBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 223);
            this.ControlBox = false;
            this.Controls.Add(this.dtvBankAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnBankAccount);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListBankAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmListBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvBankAccount)).EndInit();
            this.pnBankAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvBankAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnBankAccount;
        private System.Windows.Forms.Label lbBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLimit;
    }
}