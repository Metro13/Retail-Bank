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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.cmdAddAccount.Location = new System.Drawing.Point(41, 84);
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
            this.button1.Location = new System.Drawing.Point(41, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close Account";
            this.button1.UseVisualStyleBackColor = false;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(41, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Process Deposits";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(41, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Process Withdrawals";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(41, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "View Accounts";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdAddAccount);
            this.Controls.Add(this.ActionPanel);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button cmdAddAccount;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        public Panel ActionPanel;
    }
}