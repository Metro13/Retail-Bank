namespace Retail_Bank
{
    partial class ClientDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.cmdViewTransactions = new System.Windows.Forms.Button();
            this.cmdAddPayee = new System.Windows.Forms.Button();
            this.cmdTransferFunds = new System.Windows.Forms.Button();
            this.cmdViewBalance = new System.Windows.Forms.Button();
            this.cmdMakePaymentt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(676, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logged in as User";
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.Color.White;
            this.ActionPanel.Location = new System.Drawing.Point(221, 33);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(555, 387);
            this.ActionPanel.TabIndex = 4;
            // 
            // cmdViewTransactions
            // 
            this.cmdViewTransactions.BackColor = System.Drawing.Color.White;
            this.cmdViewTransactions.Location = new System.Drawing.Point(39, 163);
            this.cmdViewTransactions.Name = "cmdViewTransactions";
            this.cmdViewTransactions.Size = new System.Drawing.Size(126, 38);
            this.cmdViewTransactions.TabIndex = 11;
            this.cmdViewTransactions.Text = "View Transactions";
            this.cmdViewTransactions.UseVisualStyleBackColor = false;
            this.cmdViewTransactions.Click += new System.EventHandler(this.cmdViewTransactions_Click);
            // 
            // cmdAddPayee
            // 
            this.cmdAddPayee.BackColor = System.Drawing.Color.White;
            this.cmdAddPayee.Location = new System.Drawing.Point(39, 279);
            this.cmdAddPayee.Name = "cmdAddPayee";
            this.cmdAddPayee.Size = new System.Drawing.Size(126, 38);
            this.cmdAddPayee.TabIndex = 10;
            this.cmdAddPayee.Text = "Add Payee";
            this.cmdAddPayee.UseVisualStyleBackColor = false;
            this.cmdAddPayee.Click += new System.EventHandler(this.cmdAddPayee_Click);
            // 
            // cmdTransferFunds
            // 
            this.cmdTransferFunds.BackColor = System.Drawing.Color.White;
            this.cmdTransferFunds.Location = new System.Drawing.Point(39, 221);
            this.cmdTransferFunds.Name = "cmdTransferFunds";
            this.cmdTransferFunds.Size = new System.Drawing.Size(126, 38);
            this.cmdTransferFunds.TabIndex = 9;
            this.cmdTransferFunds.Text = "Transfer Funds";
            this.cmdTransferFunds.UseVisualStyleBackColor = false;
            this.cmdTransferFunds.Click += new System.EventHandler(this.cmdTransferFunds_Click);
            // 
            // cmdViewBalance
            // 
            this.cmdViewBalance.BackColor = System.Drawing.Color.White;
            this.cmdViewBalance.Location = new System.Drawing.Point(39, 105);
            this.cmdViewBalance.Name = "cmdViewBalance";
            this.cmdViewBalance.Size = new System.Drawing.Size(126, 38);
            this.cmdViewBalance.TabIndex = 8;
            this.cmdViewBalance.Text = "View Balance";
            this.cmdViewBalance.UseVisualStyleBackColor = false;
            this.cmdViewBalance.Click += new System.EventHandler(this.cmdViewBalance_Click);
            // 
            // cmdMakePaymentt
            // 
            this.cmdMakePaymentt.BackColor = System.Drawing.Color.White;
            this.cmdMakePaymentt.Location = new System.Drawing.Point(39, 336);
            this.cmdMakePaymentt.Name = "cmdMakePaymentt";
            this.cmdMakePaymentt.Size = new System.Drawing.Size(126, 38);
            this.cmdMakePaymentt.TabIndex = 12;
            this.cmdMakePaymentt.Text = "Make Payment";
            this.cmdMakePaymentt.UseVisualStyleBackColor = false;
            this.cmdMakePaymentt.Click += new System.EventHandler(this.cmdMakePaymentt_Click);
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdMakePaymentt);
            this.Controls.Add(this.cmdViewTransactions);
            this.Controls.Add(this.cmdAddPayee);
            this.Controls.Add(this.cmdTransferFunds);
            this.Controls.Add(this.cmdViewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionPanel);
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public Panel ActionPanel;
        private Button cmdViewTransactions;
        private Button cmdAddPayee;
        private Button cmdTransferFunds;
        private Button cmdViewBalance;
        private Button cmdMakePaymentt;
    }
}