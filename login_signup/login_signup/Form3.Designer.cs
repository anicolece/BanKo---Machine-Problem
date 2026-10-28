using System;

namespace login_signup
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signupUsernameLabel = new System.Windows.Forms.Label();
            this.signupNameLabel = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.signupUsername = new System.Windows.Forms.TextBox();
            this.signupName = new System.Windows.Forms.TextBox();
            this.signupBirthLabel = new System.Windows.Forms.Label();
            this.signupPasswordLabel = new System.Windows.Forms.Label();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.signupEmailLabel = new System.Windows.Forms.Label();
            this.signupEmail = new System.Windows.Forms.TextBox();
            this.signupPhoneLabel = new System.Windows.Forms.Label();
            this.signupPhone = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupUsernameLabel
            // 
            this.signupUsernameLabel.AutoSize = true;
            this.signupUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupUsernameLabel.Location = new System.Drawing.Point(291, 228);
            this.signupUsernameLabel.Name = "signupUsernameLabel";
            this.signupUsernameLabel.Size = new System.Drawing.Size(113, 26);
            this.signupUsernameLabel.TabIndex = 9;
            this.signupUsernameLabel.Text = "Username";
            // 
            // signupNameLabel
            // 
            this.signupNameLabel.AutoSize = true;
            this.signupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupNameLabel.Location = new System.Drawing.Point(291, 142);
            this.signupNameLabel.Name = "signupNameLabel";
            this.signupNameLabel.Size = new System.Drawing.Size(112, 26);
            this.signupNameLabel.TabIndex = 8;
            this.signupNameLabel.Text = "Full Name";
            // 
            // signupBtn
            // 
            this.signupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.signupBtn.Location = new System.Drawing.Point(257, 689);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(173, 50);
            this.signupBtn.TabIndex = 7;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // signupUsername
            // 
            this.signupUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupUsername.Location = new System.Drawing.Point(197, 261);
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(302, 32);
            this.signupUsername.TabIndex = 6;
            this.signupUsername.TextChanged += new System.EventHandler(this.signupUsername_TextChanged);
            // 
            // signupName
            // 
            this.signupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupName.Location = new System.Drawing.Point(197, 176);
            this.signupName.Name = "signupName";
            this.signupName.Size = new System.Drawing.Size(302, 32);
            this.signupName.TabIndex = 5;
            this.signupName.TextChanged += new System.EventHandler(this.signupName_TextChanged);
            // 
            // signupBirthLabel
            // 
            this.signupBirthLabel.AutoSize = true;
            this.signupBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupBirthLabel.Location = new System.Drawing.Point(291, 400);
            this.signupBirthLabel.Name = "signupBirthLabel";
            this.signupBirthLabel.Size = new System.Drawing.Size(133, 26);
            this.signupBirthLabel.TabIndex = 13;
            this.signupBirthLabel.Text = "Date of Birth";
            // 
            // signupPasswordLabel
            // 
            this.signupPasswordLabel.AutoSize = true;
            this.signupPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupPasswordLabel.Location = new System.Drawing.Point(291, 315);
            this.signupPasswordLabel.Name = "signupPasswordLabel";
            this.signupPasswordLabel.Size = new System.Drawing.Size(108, 26);
            this.signupPasswordLabel.TabIndex = 12;
            this.signupPasswordLabel.Text = "Password";
            // 
            // signupPassword
            // 
            this.signupPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupPassword.Location = new System.Drawing.Point(197, 349);
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.Size = new System.Drawing.Size(302, 32);
            this.signupPassword.TabIndex = 10;
            this.signupPassword.TextChanged += new System.EventHandler(this.signupPassword_TextChanged);
            // 
            // signupEmailLabel
            // 
            this.signupEmailLabel.AutoSize = true;
            this.signupEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupEmailLabel.Location = new System.Drawing.Point(312, 484);
            this.signupEmailLabel.Name = "signupEmailLabel";
            this.signupEmailLabel.Size = new System.Drawing.Size(75, 26);
            this.signupEmailLabel.TabIndex = 15;
            this.signupEmailLabel.Text = "E-mail";
            // 
            // signupEmail
            // 
            this.signupEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupEmail.Location = new System.Drawing.Point(197, 517);
            this.signupEmail.Name = "signupEmail";
            this.signupEmail.Size = new System.Drawing.Size(302, 32);
            this.signupEmail.TabIndex = 14;
            this.signupEmail.TextChanged += new System.EventHandler(this.signupEmail_TextChanged);
            // 
            // signupPhoneLabel
            // 
            this.signupPhoneLabel.AutoSize = true;
            this.signupPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupPhoneLabel.Location = new System.Drawing.Point(272, 570);
            this.signupPhoneLabel.Name = "signupPhoneLabel";
            this.signupPhoneLabel.Size = new System.Drawing.Size(159, 26);
            this.signupPhoneLabel.TabIndex = 17;
            this.signupPhoneLabel.Text = "Phone Number";
            // 
            // signupPhone
            // 
            this.signupPhone.BackColor = System.Drawing.SystemColors.Window;
            this.signupPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupPhone.Location = new System.Drawing.Point(197, 603);
            this.signupPhone.MaxLength = 11;
            this.signupPhone.Name = "signupPhone";
            this.signupPhone.Size = new System.Drawing.Size(302, 32);
            this.signupPhone.TabIndex = 16;
            this.signupPhone.Text = "09";
            this.signupPhone.TextChanged += new System.EventHandler(this.signupPhone_TextChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(197, 433);
            this.cmbMonth.MaxDropDownItems = 12;
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(123, 34);
            this.cmbMonth.TabIndex = 18;
            this.cmbMonth.Text = "January";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(326, 433);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(78, 34);
            this.cmbDay.TabIndex = 19;
            this.cmbDay.Text = "1";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(410, 433);
            this.cmbYear.MaxDropDownItems = 12;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(89, 34);
            this.cmbYear.TabIndex = 20;
            this.cmbYear.Text = "2008";
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 49);
            this.backBtn.TabIndex = 21;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 846);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.signupPhoneLabel);
            this.Controls.Add(this.signupPhone);
            this.Controls.Add(this.signupEmailLabel);
            this.Controls.Add(this.signupEmail);
            this.Controls.Add(this.signupBirthLabel);
            this.Controls.Add(this.signupPasswordLabel);
            this.Controls.Add(this.signupPassword);
            this.Controls.Add(this.signupUsernameLabel);
            this.Controls.Add(this.signupNameLabel);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.signupUsername);
            this.Controls.Add(this.signupName);
            this.Name = "SignupForm";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignupForm_FormClosed);
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginUsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            int maxYear = DateTime.Now.Year - 18;
            int minYear = DateTime.Now.Year - 100;

            for (int i = maxYear; i >= minYear; i--)
            {
                cmbYear.Items.Add(i.ToString());
            }

        }

        #endregion

        private System.Windows.Forms.Label signupUsernameLabel;
        private System.Windows.Forms.Label signupNameLabel;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.TextBox signupUsername;
        private System.Windows.Forms.TextBox signupName;
        private System.Windows.Forms.Label signupBirthLabel;
        private System.Windows.Forms.Label signupPasswordLabel;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.Label signupEmailLabel;
        private System.Windows.Forms.TextBox signupEmail;
        private System.Windows.Forms.Label signupPhoneLabel;
        private System.Windows.Forms.TextBox signupPhone;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button backBtn;
    }
}