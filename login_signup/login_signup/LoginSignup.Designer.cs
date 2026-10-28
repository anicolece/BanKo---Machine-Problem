namespace login_signup
{
    partial class LoginSignUpChoiceForm
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
            this.loginChoice = new System.Windows.Forms.Button();
            this.signupChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginChoice
            // 
            this.loginChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginChoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginChoice.Location = new System.Drawing.Point(160, 258);
            this.loginChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginChoice.Name = "loginChoice";
            this.loginChoice.Size = new System.Drawing.Size(148, 36);
            this.loginChoice.TabIndex = 0;
            this.loginChoice.Text = "Log in";
            this.loginChoice.UseVisualStyleBackColor = true;
            this.loginChoice.Click += new System.EventHandler(this.loginChoice_Click);
            // 
            // signupChoice
            // 
            this.signupChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.signupChoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signupChoice.Location = new System.Drawing.Point(160, 305);
            this.signupChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupChoice.Name = "signupChoice";
            this.signupChoice.Size = new System.Drawing.Size(148, 36);
            this.signupChoice.TabIndex = 1;
            this.signupChoice.Text = "Sign Up";
            this.signupChoice.UseVisualStyleBackColor = true;
            this.signupChoice.Click += new System.EventHandler(this.signupChoice_Click);
            // 
            // LoginSignUpChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 550);
            this.Controls.Add(this.signupChoice);
            this.Controls.Add(this.loginChoice);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginSignUpChoiceForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginSignUpChoice_FormClosed);
            this.Load += new System.EventHandler(this.LoginSignUpChoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginChoice;
        private System.Windows.Forms.Button signupChoice;
    }
}

