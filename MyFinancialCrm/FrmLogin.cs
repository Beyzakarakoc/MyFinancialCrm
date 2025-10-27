using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Kullanıcı adı ve şifre boş bırakılamaz.";
                return;
            }

            try
            {
                using (var context = new FinancialCrmDbEntities()) // kendi context ismini kullan
                {
                    var user = context.Users
                        .FirstOrDefault(u => u.Username == username && u.Password == password);

                    if (user != null)
                    {
                        MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 👇 Ekleme 1: Kullanıcı adını FrmDashboard’a aktar
                        FrmDashboard.userName = user.Username;

                        // 👇 Ekleme 2: FrmDashboard formunu aç (parametresiz şekilde)
                        FrmDashboard dashboard = new FrmDashboard();
                        dashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Kullanıcı adı veya şifre hatalı!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

