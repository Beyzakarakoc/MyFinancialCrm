using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace MyFinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public string UserName { get; set; } // Kullanıcıya özel göstermek için
        public int UserId { get; set; } // Eğer kullanıcı Id ile takip ediyorsan
        public FrmSpending(int userId, string username)
        {
            InitializeComponent();
            UserId = userId;
            UserName = username;
        }
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            LoadSpendings();
            LoadChart();
        }

        private void LoadSpendings()
        {
            var spendings = db.Spendings
     .Select(s => new
     {
         s.SpendingId,
         s.SpendingTitle,
         s.SpendingAmount,
         s.SpendingDate,
         s.CategoryId
     })
     .ToList();

            dgvSpendings.DataSource = spendings;

            dgvSpendings.DataSource = spendings;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Bu örnek form kontrolleri olmadan
            string title = "Örnek Harcama"; // txtTitle.Text yerine
            decimal amount = 100;           // txtAmount.Text yerine

            try
            {
                Spendings newSpending = new Spendings
                {
                    SpendingTitle = title,      // EF modelinde büyük harf ile
                    SpendingAmount = amount,    // EF modelinde büyük harf ile
                    SpendingDate = DateTime.Now,
                    CategoryId = 1              // Sabit kategori
                };

                db.Spendings.Add(newSpending);
                db.SaveChanges();

                MessageBox.Show("Harcama eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // LoadSpendings(); // DataGridView yoksa comment bırak
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }


            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Başlık ve tutar boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal Amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Tutar geçerli bir sayı olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                Spendings newSpending = new Spendings
                {
                    SpendingTitle = txtTitle.Text.Trim(),
                    SpendingAmount = amount,
                    SpendingDate = DateTime.Now,
                    CategoryId = (int)cmbCategory.SelectedValue
                };

                db.Spendings.Add(newSpending);
                db.SaveChanges();

                LoadSpendings();
                txtTitle.Clear();
                txtAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSpendings.CurrentRow != null)
            {
                int id = (int)dgvSpendings.CurrentRow.Cells["spendingId"].Value;
                var spending = db.Spendings.Find(id);
                if (spending != null)
                {
                    db.Spendings.Remove(spending);
                    db.SaveChanges();
                    LoadSpendings();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartSpendings_Click(object sender, EventArgs e)
        {

        }

        private void LoadChart()
        {
            // SpendingDate null olmayanları al, EF LINQ uyumlu şekilde grup
            var data = db.Spendings
                .Where(s => s.SpendingDate != null)
                .GroupBy(s => DbFunctions.TruncateTime(s.SpendingDate))
                .Select(g => new
                {
                    Date = g.Key, // DateTime?
                    TotalAmount = g.Sum(x => x.SpendingAmount)
                })
                .OrderBy(x => x.Date)
                .ToList();

            chartTrend.Series.Clear();
            chartTrend.Titles.Clear();
            chartTrend.Titles.Add("Günlük Harcama Trendleri");

            Series columnSeries = new Series("Column")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true
            };

            Series lineSeries = new Series("Line")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true
            };

            chartTrend.Series.Add(columnSeries);
            chartTrend.Series.Add(lineSeries);

            foreach (var item in data)
            {
                if (item.Date.HasValue)
                {
                    string dateStr = item.Date.Value.ToString("dd.MM.yyyy"); // X ekseni
                    columnSeries.Points.AddXY(dateStr, item.TotalAmount);
                    lineSeries.Points.AddXY(dateStr, item.TotalAmount);
                }
            }

            chartTrend.Invalidate();
        }

        private void dgvSpendings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSpendings.CurrentRow != null)
            {
                txtId.Text = dgvSpendings.CurrentRow.Cells["SpendingId"].Value.ToString();
                txtTitle.Text = dgvSpendings.CurrentRow.Cells["SpendingTitle"].Value.ToString();
                txtAmount.Text = dgvSpendings.CurrentRow.Cells["SpendingAmount"].Value.ToString();
                cmbCategory.SelectedValue = dgvSpendings.CurrentRow.Cells["CategoryId"].Value;
            }
        }
    }
}