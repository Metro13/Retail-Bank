namespace Retail_Bank
{
    partial class AccountStage2
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextAccountNumber = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextVerifyAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtVerifyEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(305, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Account Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(302, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Opening Second Account";
            // 
            // cmdOpen
            // 
            this.cmdOpen.BackColor = System.Drawing.Color.White;
            this.cmdOpen.Location = new System.Drawing.Point(55, 271);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(120, 42);
            this.cmdOpen.TabIndex = 48;
            this.cmdOpen.Text = "Open Account";
            this.cmdOpen.UseVisualStyleBackColor = false;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(55, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Account Number";
            // 
            // TextAccountNumber
            // 
            this.TextAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextAccountNumber.Location = new System.Drawing.Point(55, 98);
            this.TextAccountNumber.Multiline = true;
            this.TextAccountNumber.Name = "TextAccountNumber";
            this.TextAccountNumber.Size = new System.Drawing.Size(170, 33);
            this.TextAccountNumber.TabIndex = 46;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cmbAccountType.Location = new System.Drawing.Point(55, 225);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(170, 23);
            this.cmbAccountType.TabIndex = 45;
            this.cmbAccountType.Text = "Select account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(55, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Account Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Verify Account Name";
            // 
            // TextVerifyAccountName
            // 
            this.TextVerifyAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextVerifyAccountName.Location = new System.Drawing.Point(55, 159);
            this.TextVerifyAccountName.Multiline = true;
            this.TextVerifyAccountName.Name = "TextVerifyAccountName";
            this.TextVerifyAccountName.Size = new System.Drawing.Size(170, 33);
            this.TextVerifyAccountName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(302, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Verify Email Address";
            // 
            // TxtVerifyEmail
            // 
            this.TxtVerifyEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtVerifyEmail.Location = new System.Drawing.Point(302, 98);
            this.TxtVerifyEmail.Multiline = true;
            this.TxtVerifyEmail.Name = "TxtVerifyEmail";
            this.TxtVerifyEmail.Size = new System.Drawing.Size(170, 33);
            this.TxtVerifyEmail.TabIndex = 51;
            // 
            // AccountStage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtVerifyEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextAccountNumber);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextVerifyAccountName);
            this.Name = "AccountStage2";
            this.Size = new System.Drawing.Size(555, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label5;
        private Button cmdOpen;
        private Label label4;
        private TextBox TextAccountNumber;
        private ComboBox cmbAccountType;
        private Label label3;
        private Label label2;
        private TextBox TextVerifyAccountName;
        private Label label1;
        private TextBox TxtVerifyEmail;
    }
}
