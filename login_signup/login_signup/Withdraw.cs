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
    public partial class WithdrawForm : Form
    {
        private string currentUserId;
        private decimal currentBalance;
        private string filepath = "users.txt";
        public WithdrawForm(string userId, decimal balance)
        {
            InitializeComponent();
            currentUserId = userId;
            currentBalance = balance;
        }
        private void UpdateBalanceUI()
        {
            lblCurrentAmount.Text = $"₱{currentBalance:0.00}";
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            UpdateBalanceUI();
        }

        private void WithdrawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPageForm mainPageWindow = new MainPageForm(currentUserId);
            mainPageWindow.Show();
        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Visible = true;
            lblServiceFee.Visible = true;
            CalculateWithdrawAmount();
        }

        private decimal serviceFee()
        {
            if (decimal.TryParse(txtWithdrawAmount.Text, out decimal withdrawAmount))
            {
                return withdrawAmount * 0.02m;
            }
            return 0.00m;
        }

        private void CalculateWithdrawAmount()
        {
            if (decimal.TryParse(txtWithdrawAmount.Text, out decimal withdrawAmount))
            {
                decimal totalDeduction = withdrawAmount + serviceFee();
                if (totalDeduction > currentBalance)
                {
                    MessageBox.Show("Insufficient balance for this withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                currentBalance -= totalDeduction;
                UpdateBalanceUI();
                lblTotal.Text = $"Total Deduction: ₱{totalDeduction:0.00}";
                lblServiceFee.Text = $"Service Fee(2%): ₱{serviceFee():0.00}";
            }
            else
            {
                MessageBox.Show("Please enter a valid withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBalanceInFile(string userId, decimal newBalance)
        {
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

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            UpdateBalanceInFile(currentUserId, currentBalance);

            MessageBox.Show(
                "Withdrawal successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblWithdrawAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentAmount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
