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
    public partial class DepositForm : Form
    {
        private string currentUserId;
        private decimal currentBalance;
        private string filepath = "users.txt";

        public DepositForm(string userId, decimal balance)
        {
            InitializeComponent();
            currentUserId = userId;
            currentBalance = balance;
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            if (txtDepositAmount.Text == "Enter amount")
            {
                txtDepositAmount.Text = "";
            }
        }

        private void lblWithdrawAmount_Click(object sender, EventArgs e)
        {

        }

        private void DepositForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dialog closed; MainPageForm resumes and updates balance automatically
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDepositAmount.Text.Trim(), out decimal depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentBalance += depositAmount;
            UpdateBalanceinFile(currentUserId, currentBalance);

            MessageBox.Show($"Deposit of ₱{depositAmount:0.00} was successful!\nNew Balance: ₱{currentBalance:0.00}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void UpdateBalanceinFile(string userId, decimal newBalance)
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
    }
}
