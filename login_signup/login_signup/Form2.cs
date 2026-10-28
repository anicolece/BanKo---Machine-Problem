
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
using System.Xml.Linq;

namespace login_signup
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string filepath = "users.txt";

        private void loginUsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginSignUpChoiceForm choiceWindow = new LoginSignUpChoiceForm();
            choiceWindow.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text.Trim();
            string password = loginPassword.Text;

            if (!validate(username, password))
            {
                return;
            }

            if (isValidUserAccount(username, password))
            {
                MessageBox.Show("Login successful!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPageForm mainPageWindow = new MainPageForm();
                mainPageWindow.Show();
                this.Hide();
            }
            else
            {
                showErrorMessage("Invalid username or password.", "Login Failed");
            }
        }

        private bool validate(string username, string password)
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(username))
            {
                showErrorMessage("Username is required.", "Validation Error");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                showErrorMessage("Password is required.", "Validation Error");
                valid = false;
            }

            return valid;
        }

        private bool isValidUserAccount(string name, string password)
        {
            if (File.Exists(filepath))
            {
                string[] savedData = File.ReadAllLines(filepath);

                for (int i = 0; i < savedData.Length; i++)
                {
                    if (savedData[i].StartsWith("Username: "))
                    {
                        string savedUsername = savedData[i]
                            .Substring("Username: ".Length).Trim();

                        if (savedUsername == name && i + 1 < savedData.Length)
                        {
                            if (savedData[i + 1].StartsWith("Password: "))
                            {
                                string savedPassword = savedData[i + 1]
                                    .Substring("Password: ".Length).Trim();

                                if (savedPassword == password)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void showErrorMessage(string message, string caption)
        {
            MessageBox.Show(message, caption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
