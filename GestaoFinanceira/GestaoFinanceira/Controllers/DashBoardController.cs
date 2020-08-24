using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using GestaoFinanceira.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestaoFinanceira.Controllers
{
    public class DashBoardController
    {
        AccountController ctrAcc;
        PaymentMethodController ctrPayment;
        CreditCardController ctrCredit;
        CategoriesController ctrCategories;
        EntryExpensesController ctrEntry;
        ReportController ctrReport;
        public Report report { get; set; }
        public DashBoardController()
        {
            ctrAcc = new AccountController();
            ctrPayment = new PaymentMethodController(ctrAcc.Context);
            ctrCredit = new CreditCardController(ctrAcc.Context);
            ctrCategories = new CategoriesController(ctrAcc.Context);
            ctrEntry = new EntryExpensesController(ctrAcc.Context);
            ctrReport = new ReportController(ctrAcc.Context);
        }
        public List<Button> GenerateCardsForFlp(PaymentMethodType method)
        {
            List<Button> list = new List<Button>();
            Button button;

            foreach (var payment in ctrPayment.List())
            {
                button = new Button();
                button.Font = new Font("Microsoft PhagsPa", 10, FontStyle.Regular);
                button.Size = new Size(158, 40);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = SystemColors.BLUE;
                button.Cursor = Cursors.Hand;
                button.Tag = payment;

                if (method == PaymentMethodType.BankAccount && payment is Account)
                {
                    button.Text = GenerateCaptionHolder(payment.Holder) + " - " + ((Account)payment).Bank;
                    list.Add(button);
                }
                else if (method == PaymentMethodType.CreditCard && payment is CreditCard)
                {
                    button.Text = GenerateCaptionHolder(payment.Holder) + " - " + ((CreditCard)payment).Issuer;
                    list.Add(button);
                }
            }
            return list;
        }

        public string GenerateCaptionHolder(string name)
        {
            string abbreviation = "";
            var names = name.Split(' ');
            for (int i = names.Length; i > 0; i--)
            {
                abbreviation = names[i - 1].Remove(1, names[i - 1].Length - 1) + "." + abbreviation;
            }

            return abbreviation;
        }

        public void GenerateChart(Chart chart, ChartType typeChart, DateTime date)
        {
            double saldoBank = 0.00;
            double percent = 0.00;
            int i = 0;

            switch (typeChart)
            {
                case ChartType.Account:
                    chart.Series["Bank"].Points.Clear();
                    chart.Series["Bank"].ChartType = SeriesChartType.Pie;

                    foreach (var acc in ctrAcc.List())
                    {

                        percent = (acc.Balance / report.TotalIncome);
                        chart.Series["Bank"].Points.Add(i);
                        chart.Series["Bank"].Points[i].LegendText = GenerateCaptionHolder(acc.Holder) + " - " + acc.Bank;
                        chart.Series["Bank"].Points[i].Label = percent.ToString("P");
                        chart.Series["Bank"].Points[i].SetValueXY(percent, percent);
                        i++;
                    }
                    break;

                case ChartType.CreditCard:
                    chart.Series["CreditCard"].Points.Clear();
                    foreach (var card in ctrCredit.List().ToList())
                    {
                        Report reportCard = ctrReport.GenerateByCreditCard(date, card);
                        chart.Series["CreditCard"].Points.Add(i);
                        chart.Series["CreditCard"].Points[i].YValues[0] = reportCard.TotalExpenses;
                        chart.Series["CreditCard"].Points[i].Label = GenerateCaptionHolder(card.Holder) + " - " + card.Issuer;
                        i++;
                    }
                    break;

                case ChartType.Categories:
                    chart.Series["Categories"].Points.Clear();
                    chart.Series["Categories"].ChartType = SeriesChartType.Pie;
                  var listEntries = ctrEntry.List().Where(entry => entry.Date.ToString("MMM yyyy") == date.ToString("MMM yyyy"));
                  double saldoCat = 0.00;

                    foreach (var cat in report.Categories)
                    {
                        saldoCat = 0.00;
                        foreach (var entry in listEntries)
                        {
                            if (cat.type == EntryType.Expense && cat.Description == entry.Category.Description)
                            {
                                foreach (var e in listEntries)
                                    saldoCat += e.Category.Id == cat.Id ? e.Value : 0.00; 

                                percent = (saldoCat / report.TotalExpenses);
                                chart.Series["Categories"].Points.Add(i);
                                chart.Series["Categories"].Points[i].LegendText = cat.Description;
                                chart.Series["Categories"].Points[i].Label = percent.ToString("P");
                                chart.Series["Categories"].Points[i].SetValueXY(percent, percent);
                                i++;
                                break;
                            }
                        }
                    }
                    break;
            }
            try
            {
                chart.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {

            }
        }

        public void CategorieChartForReport(Chart chart, Report report, EntryType entryType)
        {
            double percent = 0.00;
            double saldoCat = 0.00;
            int i = 0;

            chart.Series["Categories"].Points.Clear();
            chart.Series["Categories"].ChartType = SeriesChartType.Pie;
            List<EntryExpenses> listEntries = report.EntryExpenses;

            foreach (var cat in report.Categories)
            {
                saldoCat = 0.00;
                foreach (var entry in listEntries)
                {
                    if (cat.type == entryType && cat.Description == entry.Category.Description)
                    {
                        foreach (var e in listEntries)
                            saldoCat += e.Category.Id == cat.Id ? e.Value : 0.00;

                        percent = (saldoCat / report.TotalExpenses);
                        chart.Series["Categories"].Points.Add(i);
                        chart.Series["Categories"].Points[i].LegendText = cat.Description;
                        chart.Series["Categories"].Points[i].Label = percent.ToString("P");
                        chart.Series["Categories"].Points[i].SetValueXY(percent, percent);
                        i++;
                        break;
                    }
                }
            }
        }

        public void LoadReport(DateTime date)
        {
            this.report = ctrReport.GenerateByMonth(date);
        }

        internal string GetEconomy(DateTime date)
        {
            return ctrReport.CalcEconomy(date);
        }
    }
}
