using System;
using System.Windows.Forms;

namespace login_signup

{
    public partial class LoginSignUpChoiceForm : Form
    {

        public LoginSignUpChoiceForm()
        {
            InitializeComponent();
        }

        private void loginChoice_Click(object sender, EventArgs e)
        {
            LoginForm loginWindow = new LoginForm();
            loginWindow.Show();
            this.Hide();
        }

        private void signupChoice_Click(object sender, EventArgs e)
        {
            SignupForm signupWindow = new SignupForm();
            signupWindow.Show();
            this.Hide();
        }

        private void LoginSignUpChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
