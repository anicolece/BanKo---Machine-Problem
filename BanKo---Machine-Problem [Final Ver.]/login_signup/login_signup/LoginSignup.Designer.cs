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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.loginChoice = new System.Windows.Forms.Button();
            this.signupChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLogo.Location = new System.Drawing.Point(53, 166);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(533, 92);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "BanKo";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblSubtitle.Location = new System.Drawing.Point(53, 265);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(533, 31);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Smart • Secure • Simple Banking";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginChoice
            // 
            this.loginChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginChoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginChoice.Location = new System.Drawing.Point(207, 320);
            this.loginChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginChoice.Name = "loginChoice";
            this.loginChoice.Size = new System.Drawing.Size(227, 52);
            this.loginChoice.TabIndex = 0;
            this.loginChoice.Text = "Log in";
            this.loginChoice.UseVisualStyleBackColor = true;
            this.loginChoice.Click += new System.EventHandler(this.loginChoice_Click);
            // 
            // signupChoice
            // 
            this.signupChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.signupChoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signupChoice.Location = new System.Drawing.Point(207, 388);
            this.signupChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupChoice.Name = "signupChoice";
            this.signupChoice.Size = new System.Drawing.Size(227, 52);
            this.signupChoice.TabIndex = 1;
            this.signupChoice.Text = "Sign Up";
            this.signupChoice.UseVisualStyleBackColor = true;
            this.signupChoice.Click += new System.EventHandler(this.signupChoice_Click);
            // 
            // LoginSignUpChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 677);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.signupChoice);
            this.Controls.Add(this.loginChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginSignUpChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanKo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginSignUpChoice_FormClosed);
            this.Load += new System.EventHandler(this.LoginSignUpChoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button loginChoice;
        private System.Windows.Forms.Button signupChoice;
    }
}
