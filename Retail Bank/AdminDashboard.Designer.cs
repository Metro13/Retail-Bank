namespace Retail_Bank
{
    partial class AdminDashboard
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
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.cmdAddAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.cmdWithdraw = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmdExistingAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.Color.White;
            this.ActionPanel.Location = new System.Drawing.Point(222, 42);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(555, 387);
            this.ActionPanel.TabIndex = 0;
            this.ActionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ActionPanel_Paint);
            // 
            // cmdAddAccount
            // 
            this.cmdAddAccount.BackColor = System.Drawing.Color.White;
            this.cmdAddAccount.Location = new System.Drawing.Point(39, 68);
            this.cmdAddAccount.Name = "cmdAddAccount";
            this.cmdAddAccount.Size = new System.Drawing.Size(126, 38);
            this.cmdAddAccount.TabIndex = 1;
            this.cmdAddAccount.Text = "Open Account";
            this.cmdAddAccount.UseVisualStyleBackColor = false;
            this.cmdAddAccount.Click += new System.EventHandler(this.cmdAddAccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(665, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logged in as Admin";
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.BackColor = System.Drawing.Color.White;
            this.cmdDeposit.Location = new System.Drawing.Point(39, 242);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(126, 38);
            this.cmdDeposit.TabIndex = 4;
            this.cmdDeposit.Text = "Process Deposits";
            this.cmdDeposit.UseVisualStyleBackColor = false;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // cmdWithdraw
            // 
            this.cmdWithdraw.BackColor = System.Drawing.Color.White;
            this.cmdWithdraw.Location = new System.Drawing.Point(39, 300);
            this.cmdWithdraw.Name = "cmdWithdraw";
            this.cmdWithdraw.Size = new System.Drawing.Size(126, 38);
            this.cmdWithdraw.TabIndex = 5;
            this.cmdWithdraw.Text = "Process Withdrawals";
            this.cmdWithdraw.UseVisualStyleBackColor = false;
            this.cmdWithdraw.Click += new System.EventHandler(this.cmdWithdraw_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(39, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "View Accounts";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // cmdExistingAccount
            // 
            this.cmdExistingAccount.BackColor = System.Drawing.Color.White;
            this.cmdExistingAccount.Location = new System.Drawing.Point(39, 126);
            this.cmdExistingAccount.Name = "cmdExistingAccount";
            this.cmdExistingAccount.Size = new System.Drawing.Size(126, 38);
            this.cmdExistingAccount.TabIndex = 7;
            this.cmdExistingAccount.Text = "Add second account";
            this.cmdExistingAccount.UseVisualStyleBackColor = false;
            this.cmdExistingAccount.Click += new System.EventHandler(this.cmdExistingAccount_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExistingAccount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmdWithdraw);
            this.Controls.Add(this.cmdDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdAddAccount);
            this.Controls.Add(this.ActionPanel);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button cmdAddAccount;
        private Button button1;
        private Label label1;
        private Button cmdDeposit;
        private Button cmdWithdraw;
        private Button button4;
        public Panel ActionPanel;
        private Button cmdExistingAccount;
    }
}