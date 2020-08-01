﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void HabilitSave()
        {
            if (txtCategoria.Text != "")
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "" || txtSubCategoria.Text != "")
            {
                if (MessageBox.Show("Tem certeza que quer fechar ?", "Confirmação de fechamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            HabilitSave();
        }
    }
}
