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
            if (txtWithdrawAmount.Text == "Enter amount")
            {
                txtWithdrawAmount.Text = "";
            }
            lblTotal.Visible = false;
            lblServiceFee.Visible = false;
            UpdateBalanceUI();
        }

        private void WithdrawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dialog closed; MainPageForm resumes and updates balance automatically
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private decimal CalculateServiceFee(decimal amount)
        {
            return amount * 0.02m;
        }

        private void UpdatePreview()
        {
            if (decimal.TryParse(txtWithdrawAmount.Text.Trim(), out decimal withdrawAmount) && withdrawAmount > 0)
            {
                decimal fee = CalculateServiceFee(withdrawAmount);
                decimal totalDeduction = withdrawAmount + fee;

                lblServiceFee.Visible = true;
                lblTotal.Visible = true;
                lblServiceFee.Text = $"Service Fee(2%): ₱{fee:0.00}";
                lblTotal.Text = $"Total Deduction: ₱{totalDeduction:0.00}";
            }
            else
            {
                lblServiceFee.Visible = false;
                lblTotal.Visible = false;
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
            if (!decimal.TryParse(txtWithdrawAmount.Text.Trim(), out decimal withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal fee = CalculateServiceFee(withdrawAmount);
            decimal totalDeduction = withdrawAmount + fee;

            if (totalDeduction > currentBalance)
            {
                MessageBox.Show("Insufficient balance for this withdrawal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentBalance -= totalDeduction;
            UpdateBalanceInFile(currentUserId, currentBalance);
            UpdateBalanceUI();

            MessageBox.Show(
                $"Withdrawal successful!\nAmount: ₱{withdrawAmount:0.00}\nService Fee (2%): ₱{fee:0.00}\nTotal Deducted: ₱{totalDeduction:0.00}\nRemaining Balance: ₱{currentBalance:0.00}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
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
