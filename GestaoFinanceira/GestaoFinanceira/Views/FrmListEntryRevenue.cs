﻿using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmListEntryRevenue : Form
    {
        public readonly EntryType entryType;
        private readonly EntryExpensesController ctr;
        private DateTime date;

        public FrmListEntryRevenue(EntryType entryType, DateTime date)
        {
            InitializeComponent();
            pnEtries.BackColor = entryType == EntryType.Revenue ? SystemColors.GREEN : SystemColors.RED;
            this.entryType = entryType;
            this.date = date;
            ctr = new EntryExpensesController();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(entryType);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dtvRevenue.DataSource = LoadEntriesTypes();
            }
        }

        private void dtvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void lbEntries_Paint(object sender, PaintEventArgs e)
        {
            string msg = entryType == EntryType.Revenue ? "Receitas" : "Despesas";
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(10, 100);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(msg, myFont, myBrush, 0, 0);
        }

        private void FrmListEntryRevenue_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

        }

        private BindingList<EntryExpenses> LoadEntriesTypes()
        {
            return new BindingList<EntryExpenses>(ctr.List().Where(entry => entry.EntryType == this.entryType && (entry.Date.ToString("MM yyyy") == date.ToString("MM yyyy"))).ToList());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EntryExpenses editEntry = (EntryExpenses)dtvRevenue.SelectedRows[0].DataBoundItem;
            FrmEntryExpenses form = new FrmEntryExpenses(editEntry);
            if (form.ShowDialog() == DialogResult.OK)
            {
                editEntry = form.getEntryExpenses();
                ctr.Save(editEntry);
                dtvRevenue.Rows.Clear();
                dtvRevenue.DataSource = LoadEntriesTypes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtvRevenue.CurrentRow != null)
            {
                if (MessageBox.Show("Tem certeza que deseja apagar este item ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EntryExpenses deleteEntry = (EntryExpenses)dtvRevenue.SelectedRows[0].DataBoundItem;
                    ctr.Remove(deleteEntry);
                    dtvRevenue.DataSource = LoadEntriesTypes();
                }
            }
        }

        private async void FrmListEntryRevenue_Shown(object sender, EventArgs e)
        {
            BindingList<EntryExpenses> entries = null ;
            await this.Loading(() => entries = LoadEntriesTypes());
            dtvRevenue.DataSource = entries;
        }
    }
}
