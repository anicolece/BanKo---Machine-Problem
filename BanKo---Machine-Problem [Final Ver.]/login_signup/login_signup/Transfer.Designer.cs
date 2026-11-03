namespace login_signup
{
    partial class Transfer
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
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.txtRecipientAcc = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblSelectBank = new System.Windows.Forms.Label();
            this.lblRcpntAccNumber = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBankName
            // 
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(89, 120);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(409, 24);
            this.cmbBankName.TabIndex = 0;
            this.cmbBankName.SelectedIndexChanged += new System.EventHandler(this.Transfer_Load);
            // 
            // txtRecipientAcc
            // 
            this.txtRecipientAcc.Location = new System.Drawing.Point(89, 207);
            this.txtRecipientAcc.Name = "txtRecipientAcc";
            this.txtRecipientAcc.Size = new System.Drawing.Size(409, 22);
            this.txtRecipientAcc.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(89, 283);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(409, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(161, 367);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(232, 39);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblSelectBank
            // 
            this.lblSelectBank.AutoSize = true;
            this.lblSelectBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBank.Location = new System.Drawing.Point(40, 75);
            this.lblSelectBank.Name = "lblSelectBank";
            this.lblSelectBank.Size = new System.Drawing.Size(296, 29);
            this.lblSelectBank.TabIndex = 4;
            this.lblSelectBank.Text = "Select Recepient\'s Bank";
            this.lblSelectBank.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRcpntAccNumber
            // 
            this.lblRcpntAccNumber.AutoSize = true;
            this.lblRcpntAccNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcpntAccNumber.Location = new System.Drawing.Point(42, 175);
            this.lblRcpntAccNumber.Name = "lblRcpntAccNumber";
            this.lblRcpntAccNumber.Size = new System.Drawing.Size(204, 18);
            this.lblRcpntAccNumber.TabIndex = 5;
            this.lblRcpntAccNumber.Text = "Recepient\'s Account Number:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(42, 248);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(63, 18);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 491);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblRcpntAccNumber);
            this.Controls.Add(this.lblSelectBank);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRecipientAcc);
            this.Controls.Add(this.cmbBankName);
            this.Name = "Transfer";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.TextBox txtRecipientAcc;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblSelectBank;
        private System.Windows.Forms.Label lblRcpntAccNumber;
        private System.Windows.Forms.Label lblAmount;
    }
}