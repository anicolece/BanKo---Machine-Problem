namespace login_signup
{
    partial class WithdrawForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(10, 10);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(68, 30);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(34, 48);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(184, 26);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Current Balance";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblCurrentAmount
            // 
            this.lblCurrentAmount.AutoSize = true;
            this.lblCurrentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAmount.Location = new System.Drawing.Point(34, 76);
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            this.lblCurrentAmount.Size = new System.Drawing.Size(66, 26);
            this.lblCurrentAmount.TabIndex = 3;
            this.lblCurrentAmount.Text = "₱0.00";
            this.lblCurrentAmount.Click += new System.EventHandler(this.lblCurrentAmount_Click);
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawAmount.Location = new System.Drawing.Point(34, 115);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(206, 26);
            this.lblWithdrawAmount.TabIndex = 1;
            this.lblWithdrawAmount.Text = "Withdraw Amount:";
            this.lblWithdrawAmount.Click += new System.EventHandler(this.lblWithdrawAmount_Click);
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawAmount.Location = new System.Drawing.Point(39, 147);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(140, 26);
            this.txtWithdrawAmount.TabIndex = 1;
            this.txtWithdrawAmount.TextChanged += new System.EventHandler(this.txtWithdrawAmount_TextChanged);
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceFee.Location = new System.Drawing.Point(37, 195);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(48, 17);
            this.lblServiceFee.TabIndex = 5;
            this.lblServiceFee.Text = "--------";
            this.lblServiceFee.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(36, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "--------";
            this.lblTotal.Visible = false;
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(60, 285);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(172, 41);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 355);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWithdrawAmount);
            this.Controls.Add(this.txtWithdrawAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Withdrawal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WithdrawForm_FormClosed);
            this.Load += new System.EventHandler(this.WithdrawForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCurrentAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Button btnWithdraw;
    }
}
