namespace Retail_Bank
{
    partial class TransferFunds
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
            this.cmbFromAccountType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtAccountNumber = new System.Windows.Forms.TextBox();
            this.cmdTransfer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.cmdToAccountType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFromAccountType
            // 
            this.cmbFromAccountType.FormattingEnabled = true;
            this.cmbFromAccountType.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cmbFromAccountType.Location = new System.Drawing.Point(73, 142);
            this.cmbFromAccountType.Name = "cmbFromAccountType";
            this.cmbFromAccountType.Size = new System.Drawing.Size(170, 23);
            this.cmbFromAccountType.TabIndex = 66;
            this.cmbFromAccountType.Text = "Select account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(342, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Account Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(73, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(73, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "From Account Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(73, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Account Number";
            // 
            // TxtAccountNumber
            // 
            this.TxtAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAccountNumber.Location = new System.Drawing.Point(73, 71);
            this.TxtAccountNumber.Multiline = true;
            this.TxtAccountNumber.Name = "TxtAccountNumber";
            this.TxtAccountNumber.Size = new System.Drawing.Size(170, 33);
            this.TxtAccountNumber.TabIndex = 60;
            // 
            // cmdTransfer
            // 
            this.cmdTransfer.BackColor = System.Drawing.Color.White;
            this.cmdTransfer.Location = new System.Drawing.Point(73, 312);
            this.cmdTransfer.Name = "cmdTransfer";
            this.cmdTransfer.Size = new System.Drawing.Size(120, 42);
            this.cmdTransfer.TabIndex = 59;
            this.cmdTransfer.Text = "Transfer Funds";
            this.cmdTransfer.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(339, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 21);
            this.label14.TabIndex = 58;
            this.label14.Text = "Transfer Funds";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAmount.Location = new System.Drawing.Point(73, 263);
            this.TxtAmount.Multiline = true;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(175, 33);
            this.TxtAmount.TabIndex = 63;
            // 
            // cmdToAccountType
            // 
            this.cmdToAccountType.FormattingEnabled = true;
            this.cmdToAccountType.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cmdToAccountType.Location = new System.Drawing.Point(73, 205);
            this.cmdToAccountType.Name = "cmdToAccountType";
            this.cmdToAccountType.Size = new System.Drawing.Size(170, 23);
            this.cmdToAccountType.TabIndex = 68;
            this.cmdToAccountType.Text = "Select account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(73, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "To Account Type";
            // 
            // TransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.cmdToAccountType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFromAccountType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtAccountNumber);
            this.Controls.Add(this.cmdTransfer);
            this.Controls.Add(this.label14);
            this.Name = "TransferFunds";
            this.Size = new System.Drawing.Size(549, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbFromAccountType;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox TxtAccountNumber;
        private Button cmdTransfer;
        private Label label14;
        private TextBox TxtAmount;
        private ComboBox cmdToAccountType;
        private Label label1;
    }
}
