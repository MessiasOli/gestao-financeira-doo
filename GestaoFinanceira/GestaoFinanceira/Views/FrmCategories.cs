﻿using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmCategories : Form
    {
        Categories categorie;
        private readonly CategoriesController controller;
        private BindingList<SubCategories> subCategories;
        public FrmCategories()
        {
            InitializeComponent();
            panel1.BackColor = SystemColors.BLUE;
            this.controller = new CategoriesController(new MemorySQLConnection<Categories>());
            this.subCategories = new BindingList<SubCategories>();
        }

        private bool IsValid()
        {
            return this.ValidFields(txtCategoria, cbType);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                this.Close();
            else
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = IsValid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setCategorie();
            controller.Save(categorie);

            this.DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Categorias salvas com sucesso!", "", MessageBoxButtons.OK);
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            dgvSubcategories.DataSource = subCategories;
            Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    { "Selecione um tipo", null},
                    { "Receita", "Revenue"},
                    { "Despesa", "Expense"}

                };
            cbType.DataSource = new BindingSource(dict, null);
            cbType.DisplayMember = "Key";
            cbType.ValueMember = "Value";
    }

        private void dgvSubcategories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSubcategories.Columns["Id"].Visible = false;
        }

        private void setCategorie()
        {
            categorie = new Categories()
            {
                type = cbType.Text == "Receita" ? Enums.EntryType.Revenue : Enums.EntryType.Expense,
                Description = txtCategoria.Text,
                SubCategories = subCategories.ToList()
            };
        }

        public void setCategorie(Categories categories)
        {
            cbType.FindString(categorie.type == Enums.EntryType.Revenue ? "Receita" : "Despesa");
            txtCategoria.Text = categories.Description;
            subCategories = new BindingList<SubCategories>( categories.SubCategories);
        }

        public Categories GetCategorie()
        {
            return this.categorie;
        }
    }
}
