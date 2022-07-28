namespace Retail_Bank
{
    partial class Close_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.TxtAccountPin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(62, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Account Pin";
            // 
            // TxtAccountPin
            // 
            this.TxtAccountPin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAccountPin.Location = new System.Drawing.Point(62, 190);
            this.TxtAccountPin.Multiline = true;
            this.TxtAccountPin.Name = "TxtAccountPin";
            this.TxtAccountPin.Size = new System.Drawing.Size(175, 33);
            this.TxtAccountPin.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(62, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Account Name";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAccountName.Location = new System.Drawing.Point(62, 124);
            this.TxtAccountName.Multiline = true;
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(175, 33);
            this.TxtAccountName.TabIndex = 43;
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.BackColor = System.Drawing.Color.White;
            this.cmdCloseAccount.Location = new System.Drawing.Point(62, 241);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(120, 42);
            this.cmdCloseAccount.TabIndex = 42;
            this.cmdCloseAccount.Text = "Close Account";
            this.cmdCloseAccount.UseVisualStyleBackColor = false;
            this.cmdCloseAccount.Click += new System.EventHandler(this.cmdCloseAccount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(355, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Account Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(352, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 21);
            this.label14.TabIndex = 47;
            this.label14.Text = "Close Account";
            // 
            // Close_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAccountPin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.cmdCloseAccount);
            this.Name = "Close_Account";
            this.Size = new System.Drawing.Size(549, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private TextBox TxtAccountPin;
        private Label label11;
        private TextBox TxtAccountName;
        private Button cmdCloseAccount;
        private Label label8;
        private Label label14;
    }
}
