namespace Retail_Bank
{
    partial class Deposit
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
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDepositAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAccountNumber = new System.Windows.Forms.TextBox();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(347, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Account Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(344, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 21);
            this.label14.TabIndex = 54;
            this.label14.Text = "Deposit Funds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(54, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Deposit Amount";
            // 
            // TxtDepositAmount
            // 
            this.TxtDepositAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtDepositAmount.Location = new System.Drawing.Point(54, 153);
            this.TxtDepositAmount.Multiline = true;
            this.TxtDepositAmount.Name = "TxtDepositAmount";
            this.TxtDepositAmount.Size = new System.Drawing.Size(175, 33);
            this.TxtDepositAmount.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(54, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Account Number";
            // 
            // TxtAccountNumber
            // 
            this.TxtAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAccountNumber.Location = new System.Drawing.Point(54, 87);
            this.TxtAccountNumber.Multiline = true;
            this.TxtAccountNumber.Name = "TxtAccountNumber";
            this.TxtAccountNumber.Size = new System.Drawing.Size(175, 33);
            this.TxtAccountNumber.TabIndex = 50;
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.BackColor = System.Drawing.Color.White;
            this.cmdDeposit.Location = new System.Drawing.Point(54, 271);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(120, 42);
            this.cmdDeposit.TabIndex = 49;
            this.cmdDeposit.Text = "Deposit Funds";
            this.cmdDeposit.UseVisualStyleBackColor = false;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cmbAccountType.Location = new System.Drawing.Point(54, 225);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(170, 23);
            this.cmbAccountType.TabIndex = 57;
            this.cmbAccountType.Text = "Select account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(54, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Account Type";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtDepositAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtAccountNumber);
            this.Controls.Add(this.cmdDeposit);
            this.Name = "Deposit";
            this.Size = new System.Drawing.Size(549, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Label label14;
        private Label label10;
        private TextBox TxtDepositAmount;
        private Label label11;
        private TextBox TxtAccountNumber;
        private Button cmdDeposit;
        private ComboBox cmbAccountType;
        private Label label3;
    }
}
