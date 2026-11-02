namespace login_signup
{
    partial class MainPageForm
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
            this.lblBalanceHeader = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBalanceHeader
            // 
            this.lblBalanceHeader.AutoSize = true;
            this.lblBalanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceHeader.Location = new System.Drawing.Point(49, 52);
            this.lblBalanceHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanceHeader.Name = "lblBalanceHeader";
            this.lblBalanceHeader.Size = new System.Drawing.Size(240, 36);
            this.lblBalanceHeader.TabIndex = 0;
            this.lblBalanceHeader.Text = "Account Balance";
            this.lblBalanceHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(52, 36);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(82, 16);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User ID: ------";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(49, 87);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(90, 31);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "₱0.00";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(55, 203);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(119, 42);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(55, 154);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(119, 42);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(55, 252);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(119, 42);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblBalanceHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPageForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalanceHeader;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
    }
}