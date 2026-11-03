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
            lblBalance.Text = $"₱{currentBalance:N2}";
            CalculateInterestProjection();
        }

        private void CalculateInterestProjection()
        {
            if (numInterestRate == null || numYears == null) return;

            decimal ratePercent = numInterestRate.Value;
            int years = (int)numYears.Value;

            // Compound interest projection: A = P * (1 + r)^t
            double p = (double)currentBalance;
            double r = (double)(ratePercent / 100m);
            double a = p * Math.Pow(1.0 + r, years);

            decimal projectedTotal = (decimal)a;
            decimal projectedInterest = projectedTotal - currentBalance;
            if (projectedInterest < 0) projectedInterest = 0;

            decimal monthlyEarnings = years > 0 ? projectedInterest / (years * 12) : 0;

            lblProjectedInterest.Text = $"₱{projectedInterest:N2}";
            lblProjectedTotal.Text = $"₱{projectedTotal:N2}";
            lblMonthlyEarnings.Text = $"Est. Monthly Earnings: ₱{monthlyEarnings:N2}";
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

        private void numInterestRate_ValueChanged(object sender, EventArgs e)
        {
            CalculateInterestProjection();
        }

        private void numYears_ValueChanged(object sender, EventArgs e)
        {
            CalculateInterestProjection();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositWindow = new DepositForm(currentUserId, currentBalance);
            this.Hide();
            depositWindow.ShowDialog();
            currentBalance = GetBalanceByUserId(currentUserId);
            UpdateBalanceUI();
            this.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawWindow = new WithdrawForm(currentUserId, currentBalance);
            this.Hide();
            withdrawWindow.ShowDialog();
            currentBalance = GetBalanceByUserId(currentUserId);
            UpdateBalanceUI();
            this.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer transferForm = new Transfer(currentUserId);

            transferForm.FormClosed += (s, args) => this.Show();

            transferForm.Show();
            this.Hide();
        }

        private void MainPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void grpInterest_Enter(object sender, EventArgs e)
        {

        }

        private void lblProjectionPeriod_Click(object sender, EventArgs e)
        {

        }
    }
}
