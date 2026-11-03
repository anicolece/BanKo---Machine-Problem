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
            this.grpInterest = new System.Windows.Forms.GroupBox();
            this.lblMonthlyEarnings = new System.Windows.Forms.Label();
            this.lblProjectedTotal = new System.Windows.Forms.Label();
            this.lblEstTotalTitle = new System.Windows.Forms.Label();
            this.lblProjectedInterest = new System.Windows.Forms.Label();
            this.lblEstInterestTitle = new System.Windows.Forms.Label();
            this.numYears = new System.Windows.Forms.NumericUpDown();
            this.lblProjectionPeriod = new System.Windows.Forms.Label();
            this.numInterestRate = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.grpInterest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalanceHeader
            // 
            this.lblBalanceHeader.AutoSize = true;
            this.lblBalanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceHeader.Location = new System.Drawing.Point(40, 59);
            this.lblBalanceHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanceHeader.Name = "lblBalanceHeader";
            this.lblBalanceHeader.Size = new System.Drawing.Size(218, 31);
            this.lblBalanceHeader.TabIndex = 0;
            this.lblBalanceHeader.Text = "Account Balance";
            this.lblBalanceHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(43, 31);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(96, 18);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User ID: ------";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBalance.Location = new System.Drawing.Point(40, 101);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(99, 36);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "₱0.00";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(46, 220);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(160, 47);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(46, 158);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(160, 47);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // grpInterest
            // 
            this.grpInterest.Controls.Add(this.lblMonthlyEarnings);
            this.grpInterest.Controls.Add(this.lblProjectedTotal);
            this.grpInterest.Controls.Add(this.lblEstTotalTitle);
            this.grpInterest.Controls.Add(this.lblProjectedInterest);
            this.grpInterest.Controls.Add(this.lblEstInterestTitle);
            this.grpInterest.Controls.Add(this.numYears);
            this.grpInterest.Controls.Add(this.lblProjectionPeriod);
            this.grpInterest.Controls.Add(this.numInterestRate);
            this.grpInterest.Controls.Add(this.lblInterestRate);
            this.grpInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInterest.Location = new System.Drawing.Point(287, 25);
            this.grpInterest.Margin = new System.Windows.Forms.Padding(4);
            this.grpInterest.Name = "grpInterest";
            this.grpInterest.Padding = new System.Windows.Forms.Padding(4);
            this.grpInterest.Size = new System.Drawing.Size(453, 302);
            this.grpInterest.TabIndex = 5;
            this.grpInterest.TabStop = false;
            this.grpInterest.Text = "Annual Interest Projection";
            this.grpInterest.Enter += new System.EventHandler(this.grpInterest_Enter);
            // 
            // lblMonthlyEarnings
            // 
            this.lblMonthlyEarnings.AutoSize = true;
            this.lblMonthlyEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyEarnings.ForeColor = System.Drawing.Color.DimGray;
            this.lblMonthlyEarnings.Location = new System.Drawing.Point(21, 252);
            this.lblMonthlyEarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyEarnings.Name = "lblMonthlyEarnings";
            this.lblMonthlyEarnings.Size = new System.Drawing.Size(190, 17);
            this.lblMonthlyEarnings.TabIndex = 8;
            this.lblMonthlyEarnings.Text = "Est. Monthly Earnings: ₱0.00";
            // 
            // lblProjectedTotal
            // 
            this.lblProjectedTotal.AutoSize = true;
            this.lblProjectedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProjectedTotal.Location = new System.Drawing.Point(21, 204);
            this.lblProjectedTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectedTotal.Name = "lblProjectedTotal";
            this.lblProjectedTotal.Size = new System.Drawing.Size(68, 25);
            this.lblProjectedTotal.TabIndex = 7;
            this.lblProjectedTotal.Text = "₱0.00";
            // 
            // lblEstTotalTitle
            // 
            this.lblEstTotalTitle.AutoSize = true;
            this.lblEstTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstTotalTitle.Location = new System.Drawing.Point(21, 180);
            this.lblEstTotalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstTotalTitle.Name = "lblEstTotalTitle";
            this.lblEstTotalTitle.Size = new System.Drawing.Size(163, 17);
            this.lblEstTotalTitle.TabIndex = 6;
            this.lblEstTotalTitle.Text = "Projected Total Balance:";
            // 
            // lblProjectedInterest
            // 
            this.lblProjectedInterest.AutoSize = true;
            this.lblProjectedInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedInterest.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProjectedInterest.Location = new System.Drawing.Point(21, 142);
            this.lblProjectedInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectedInterest.Name = "lblProjectedInterest";
            this.lblProjectedInterest.Size = new System.Drawing.Size(68, 25);
            this.lblProjectedInterest.TabIndex = 5;
            this.lblProjectedInterest.Text = "₱0.00";
            // 
            // lblEstInterestTitle
            // 
            this.lblEstInterestTitle.AutoSize = true;
            this.lblEstInterestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstInterestTitle.Location = new System.Drawing.Point(21, 118);
            this.lblEstInterestTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstInterestTitle.Name = "lblEstInterestTitle";
            this.lblEstInterestTitle.Size = new System.Drawing.Size(173, 17);
            this.lblEstInterestTitle.TabIndex = 4;
            this.lblEstInterestTitle.Text = "Projected Interest Earned:";
            // 
            // numYears
            // 
            this.numYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYears.Location = new System.Drawing.Point(240, 73);
            this.numYears.Margin = new System.Windows.Forms.Padding(4);
            this.numYears.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYears.Name = "numYears";
            this.numYears.Size = new System.Drawing.Size(93, 23);
            this.numYears.TabIndex = 3;
            this.numYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYears.ValueChanged += new System.EventHandler(this.numYears_ValueChanged);
            // 
            // lblProjectionPeriod
            // 
            this.lblProjectionPeriod.AutoSize = true;
            this.lblProjectionPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectionPeriod.Location = new System.Drawing.Point(21, 76);
            this.lblProjectionPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectionPeriod.Name = "lblProjectionPeriod";
            this.lblProjectionPeriod.Size = new System.Drawing.Size(171, 17);
            this.lblProjectionPeriod.TabIndex = 2;
            this.lblProjectionPeriod.Text = "Projection Period (Years):";
            this.lblProjectionPeriod.Click += new System.EventHandler(this.lblProjectionPeriod_Click);
            // 
            // numInterestRate
            // 
            this.numInterestRate.DecimalPlaces = 2;
            this.numInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numInterestRate.Location = new System.Drawing.Point(240, 33);
            this.numInterestRate.Margin = new System.Windows.Forms.Padding(4);
            this.numInterestRate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numInterestRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numInterestRate.Name = "numInterestRate";
            this.numInterestRate.Size = new System.Drawing.Size(93, 23);
            this.numInterestRate.TabIndex = 1;
            this.numInterestRate.Value = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            this.numInterestRate.ValueChanged += new System.EventHandler(this.numInterestRate_ValueChanged);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(21, 37);
            this.lblInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(167, 17);
            this.lblInterestRate.TabIndex = 0;
            this.lblInterestRate.Text = "Annual Interest Rate (%):";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.Location = new System.Drawing.Point(46, 280);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(160, 47);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 351);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.grpInterest);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblBalanceHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanKo - Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPageForm_FormClosed);
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.grpInterest.ResumeLayout(false);
            this.grpInterest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalanceHeader;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.GroupBox grpInterest;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.NumericUpDown numInterestRate;
        private System.Windows.Forms.Label lblProjectionPeriod;
        private System.Windows.Forms.NumericUpDown numYears;
        private System.Windows.Forms.Label lblEstInterestTitle;
        private System.Windows.Forms.Label lblProjectedInterest;
        private System.Windows.Forms.Label lblEstTotalTitle;
        private System.Windows.Forms.Label lblProjectedTotal;
        private System.Windows.Forms.Label lblMonthlyEarnings;
        private System.Windows.Forms.Button btnTransfer;
    }
}
