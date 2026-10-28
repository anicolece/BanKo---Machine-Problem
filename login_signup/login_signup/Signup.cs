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
using System.Text.RegularExpressions;

namespace login_signup
{
    public partial class SignupForm : Form
    {
        private string[] savedData;
        string filepath = "users.txt";
        private static Random rng = new Random(); // RNG Instance

        public SignupForm()
        {
            InitializeComponent();

            if (File.Exists(filepath))
            {
                savedData = File.ReadAllLines(filepath);
            }
            else
            {
                savedData = new string[0];
            }
        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signupName_TextChanged(object sender, EventArgs e) { }
        private void signupUsername_TextChanged(object sender, EventArgs e) { }
        private void signupPassword_TextChanged(object sender, EventArgs e) { }
        private void signupBirthTextbox_TextChanged(object sender, EventArgs e) { }
        private void signupEmail_TextChanged(object sender, EventArgs e) { }
        private void signupPhone_TextChanged(object sender, EventArgs e) { }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDay.Items.Clear();

            int totalDays = 31;
            string selectedMonth = cmbMonth.Text;

            if (selectedMonth == "April" || selectedMonth == "June" ||
                selectedMonth == "September" || selectedMonth == "November")
            {
                totalDays = 30;
            }
            else if (selectedMonth == "February")
            {
                totalDays = 28;
            }

            for (int i = 1; i <= totalDays; i++)
            {
                cmbDay.Items.Add(i.ToString());
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e) { }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string name = signupName.Text;
            string username = signupUsername.Text;
            string password = signupPassword.Text;
            string email = signupEmail.Text.Trim();
            string phone = signupPhone.Text.Trim();

            savedData = File.Exists(filepath)
                ? File.ReadAllLines(filepath)
                : new string[0];

            if (!validate())
            {
                return;
            }

            // 1. Generate a unique 6-digit User ID
            string userId = GenerateUniqueUserId();
            decimal initialBalance = 0.00m; // Default starting balance

            // 2. Save all details including UserId and Balance to users.txt
            using (TextWriter tw = new StreamWriter(filepath, true))
            {
                tw.WriteLine("UserId: " + userId);
                tw.WriteLine("Full Name: " + name);
                tw.WriteLine("Username: " + username);
                tw.WriteLine("Password: " + password);
                tw.WriteLine("Email: " + email);
                tw.WriteLine("Phone: " + phone);
                tw.WriteLine("Balance: " + initialBalance.ToString("0.00"));
                tw.WriteLine("---------------------------------------------");
            }

            MessageBox.Show($"Account created successfully!\nYour assigned User ID is: {userId}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm loginWindow = new LoginForm();
            loginWindow.Show();
            this.Hide();
        }

        // Generates a 6-digit random number and checks savedData to prevent collisions
        private string GenerateUniqueUserId()
        {
            string newId;
            do
            {
                newId = rng.Next(100000, 1000000).ToString();
            }
            while (savedData.Contains("UserId: " + newId));

            return newId;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            string userId = null; // No user ID to pass back
            LoginSignUpChoiceForm choiceWindow = new LoginSignUpChoiceForm();
            choiceWindow.Show();
            this.Hide();
        }

        public bool validate()
        {
            string name = signupName.Text;
            string username = signupUsername.Text;
            string password = signupPassword.Text;
            string email = signupEmail.Text.Trim();
            string phone = signupPhone.Text.Trim();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone))
            {
                showErrorMessage("All fields are required.", "Validation Error");
                valid = false;
            }

            if (!validateUsername(username))
                valid = false;

            if (!validatePassword(password))
                valid = false;

            if (!validateEmail(email))
                valid = false;

            if (!validatePhone(phone))
                valid = false;

            return valid;
        }

        private bool validateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (!username.All(char.IsLetterOrDigit))
            {
                showErrorMessage(
                    "Username must be alphanumeric and cannot contain spaces.",
                    "Invalid Username");
                return false;
            }

            if (savedData.Contains("Username: " + username))
            {
                showErrorMessage("This username is already taken!",
                    "Username Exists");
                return false;
            }

            return true;
        }

        private bool validatePassword(string password)
        {
            bool valid = true;

            if (password.Length < 10)
            {
                showErrorMessage("Password must be at least 10 characters long.",
                    "Invalid Password");
                valid = false;
            }

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                showErrorMessage("Password must contain at least one special character.",
                    "Invalid Password");
                valid = false;
            }

            return valid;
        }

        private bool validateEmail(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            if (!Regex.IsMatch(email, pattern))
            {
                showErrorMessage("Please enter a valid email address (example: name@gmail.com).",
                    "Invalid Email");
                return false;
            }

            if (savedData.Contains("Email: " + email))
            {
                showErrorMessage("An account with this email already exists!",
                    "Email Exists");
                return false;
            }

            return true;
        }

        private bool validatePhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^09\d{9}$"))
            {
                showErrorMessage("Phone number must contain exactly 11 digits and start with 09.",
                    "Invalid Phone");
                return false;
            }

            if (savedData.Contains("Phone: " + phone))
            {
                showErrorMessage("This phone number is already registered!",
                    "Phone Exists");
                return false;
            }

            return true;
        }

        private void showErrorMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SignupForm_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}