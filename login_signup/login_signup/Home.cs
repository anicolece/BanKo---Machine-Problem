using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup
{
    public partial class MainPageForm : Form
    {
        private string currentUserId;
        private decimal currentBalance;
        private string filepath = "users.txt";

        public MainPageForm(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private decimal GetBalanceByUserId(string id)
        {
            if (!File.Exists(filepath)) return 0.00m;

            string[] lines = File.ReadAllLines(filepath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim() == "UserId: " + id)
                {
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].StartsWith("Balance: "))
                        {
                            string rawAmount = lines[j].Replace("Balance: ", "").Trim();
                            if (decimal.TryParse(rawAmount, out decimal balance))
                            {
                                return balance;
                            }
                        }


                        if (lines[j].StartsWith("---")) break;
                    }
                }
            }
            return 0.00m;
        }
        private void UpdateBalanceUI()
        {
            lblBalance.Text = $"₱{currentBalance:0.00}";
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
            lblUserId.Text = "User ID: " + currentUserId;
            currentBalance = GetBalanceByUserId(currentUserId);
            UpdateBalanceUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositWindow = new DepositForm(currentUserId, currentBalance);
            depositWindow.Show();
            this.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawWindow = new WithdrawForm(currentUserId, currentBalance);
            withdrawWindow.Show();
            this.Close();
        }
        private void MainPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
