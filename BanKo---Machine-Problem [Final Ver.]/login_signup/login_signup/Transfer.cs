using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace login_signup
{
    public partial class Transfer : Form
    {
        private string loggedInUserId;

        private string filepath = "users.txt";

        private const decimal BASE_SERVICE_FEE = 10.00m;
        private const decimal MINIMUM_TRANSFER_AMOUNT = 50.00m;
        private const decimal REQUIRED_MAINTAINING_BALANCE = 1000.00m;

        public Transfer(string userId)
        {
            InitializeComponent();
            this.loggedInUserId = userId;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            if (cmbBankName.Items.Count == 0)
            {
                cmbBankName.Items.Add("Bank Ko");
                cmbBankName.Items.Add("BDO");
                cmbBankName.Items.Add("BPI");
                cmbBankName.Items.Add("GCash");
                cmbBankName.SelectedIndex = 0;
            }
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

        private void UpdateSenderBalance(string id, decimal newBalance)
        {
            if (!File.Exists(filepath)) return;

            string[] lines = File.ReadAllLines(filepath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim() == "UserId: " + id)
                {
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].StartsWith("Balance: "))
                        {
                            lines[j] = "Balance: " + newBalance.ToString("F2");
                            File.WriteAllLines(filepath, lines);
                            return;
                        }

                        if (lines[j].StartsWith("---")) break;
                    }
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal currentSenderBalance = GetBalanceByUserId(loggedInUserId);

            string selectedBank = cmbBankName.SelectedItem != null ? cmbBankName.SelectedItem.ToString() : "";
            string recipientAcc = txtRecipientAcc.Text.Trim();
            string amountInput = txtAmount.Text.Trim();

            if (string.IsNullOrEmpty(selectedBank) || string.IsNullOrEmpty(recipientAcc) || string.IsNullOrEmpty(amountInput))
            {
                MessageBox.Show("Please fill in all details (Bank Name, Recipient Account, and Amount).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountInput, out decimal transferAmount))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (transferAmount < MINIMUM_TRANSFER_AMOUNT)
            {
                MessageBox.Show($"The minimum transfer amount allowed is PHP {MINIMUM_TRANSFER_AMOUNT:N2}.",
                                "Transfer Limit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isInternalBankKo = selectedBank.Equals("Bank Ko", StringComparison.OrdinalIgnoreCase);
            if (isInternalBankKo && recipientAcc == loggedInUserId)
            {
                MessageBox.Show("You cannot transfer funds to your own account.", "Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalFee = isInternalBankKo ? 0.00m : BASE_SERVICE_FEE;

            decimal totalDeduction = transferAmount + totalFee;
            decimal postTransactionBalance = currentSenderBalance - totalDeduction;

            if (postTransactionBalance < REQUIRED_MAINTAINING_BALANCE)
            {
                MessageBox.Show($"Transaction rejected! Post-transaction balance must not fall below PHP {REQUIRED_MAINTAINING_BALANCE:N2}.\n\n" +
                                $"Current Balance: PHP {currentSenderBalance:N2}\n" +
                                $"Transfer Amount: PHP {transferAmount:N2}\n" +
                                $"Fee: PHP {totalFee:N2}\n" +
                                $"Total Deduction: PHP {totalDeduction:N2}\n" +
                                $"Post-Transaction Balance: PHP {postTransactionBalance:N2}",
                                "Insufficient Funds / Maintaining Balance Rule",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             
            UpdateSenderBalance(loggedInUserId, postTransactionBalance);

            if (isInternalBankKo)
            {
                CreditInternalAccount(recipientAcc, transferAmount);
            }

            string bankTypeLabel = isInternalBankKo ? "Intra-Bank (Bank Ko)" : $"Inter-Bank ({selectedBank})";
            MessageBox.Show($"Transfer Successful!\n\n" +
                            $"Type: {bankTypeLabel}\n" +
                            $"Recipient: {recipientAcc}\n" +
                            $"Amount: PHP {transferAmount:N2}\n" +
                            $"Service Fee: PHP {totalFee:N2}\n" +
                            $"New Balance: PHP {postTransactionBalance:N2}",
                            "Transaction Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void CreditInternalAccount(string accountNo, decimal amount)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
