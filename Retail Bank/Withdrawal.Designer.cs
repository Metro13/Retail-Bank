namespace Retail_Bank
{
    partial class Withdrawal
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
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAccountNumber = new System.Windows.Forms.TextBox();
            this.cmdWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cmbAccountType.Location = new System.Drawing.Point(72, 238);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(170, 23);
            this.cmbAccountType.TabIndex = 66;
            this.cmbAccountType.Text = "Select account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(72, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Account Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(365, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Account Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(362, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "Withdraw Funds";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(72, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 60;
            this.label11.Text = "Account Number";
            // 
            // TxtAccountNumber
            // 
            this.TxtAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAccountNumber.Location = new System.Drawing.Point(72, 90);
            this.TxtAccountNumber.Multiline = true;
            this.TxtAccountNumber.Name = "TxtAccountNumber";
            this.TxtAccountNumber.Size = new System.Drawing.Size(175, 33);
            this.TxtAccountNumber.TabIndex = 59;
            // 
            // cmdWithdraw
            // 
            this.cmdWithdraw.BackColor = System.Drawing.Color.White;
            this.cmdWithdraw.Location = new System.Drawing.Point(72, 286);
            this.cmdWithdraw.Name = "cmdWithdraw";
            this.cmdWithdraw.Size = new System.Drawing.Size(120, 42);
            this.cmdWithdraw.TabIndex = 58;
            this.cmdWithdraw.Text = "Withdraw Funds";
            this.cmdWithdraw.UseVisualStyleBackColor = false;
            this.cmdWithdraw.Click += new System.EventHandler(this.cmdWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(72, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Withdraw Amount";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWithdrawAmount.Location = new System.Drawing.Point(72, 167);
            this.txtWithdrawAmount.Multiline = true;
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(175, 33);
            this.txtWithdrawAmount.TabIndex = 67;
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtAccountNumber);
            this.Controls.Add(this.cmdWithdraw);
            this.Name = "Withdrawal";
            this.Size = new System.Drawing.Size(549, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbAccountType;
        private Label label3;
        private Label label8;
        private Label label14;
        private Label label11;
        private TextBox TxtAccountNumber;
        private Button cmdWithdraw;
        private Label label1;
        private TextBox txtWithdrawAmount;
    }
}
