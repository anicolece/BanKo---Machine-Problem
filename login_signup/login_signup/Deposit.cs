using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login_signup
{
    public partial class DepositForm : Form
    {
        private string currentUserId;
        private decimal currentBalance;
        public DepositForm(string userId, decimal balance)
        {
            InitializeComponent();
            currentUserId = userId;
            currentBalance = balance;
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

        }

        private void lblWithdrawAmount_Click(object sender, EventArgs e)
        {

        }
        private void DepositForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPageForm mainPageWindow = new MainPageForm(currentUserId);
            mainPageWindow.Show();
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            UpdateBalanceinFile(currentUserId, currentBalance + decimal.Parse(txtDepositAmount.Text));
            MainPageForm mainPage = new MainPageForm(currentUserId);
            mainPage.Show();
            this.Hide();
            MessageBox.Show("Deposit successful!");
        }

        private void UpdateBalanceinFile(string userId, decimal newBalance)
        {
            string filepath = "users.txt";
            if (!File.Exists(filepath)) return;
            string[] lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim() == "UserId: " + userId)
                {
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].StartsWith("Balance: "))
                        {
                            lines[j] = "Balance: " + newBalance.ToString("0.00");
                            File.WriteAllLines(filepath, lines);
                            return;
                        }
                        if (lines[j].StartsWith("---")) break;
                    }
                }
            }
        }
    }
}
