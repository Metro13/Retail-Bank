namespace Retail_Bank
{
    partial class AccountSelection
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
            this.cmdStartTransactions = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(96, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose what to do";
            // 
            // cmdStartTransactions
            // 
            this.cmdStartTransactions.BackColor = System.Drawing.Color.White;
            this.cmdStartTransactions.Location = new System.Drawing.Point(69, 196);
            this.cmdStartTransactions.Name = "cmdStartTransactions";
            this.cmdStartTransactions.Size = new System.Drawing.Size(212, 42);
            this.cmdStartTransactions.TabIndex = 1;
            this.cmdStartTransactions.Text = "Perform Transaction";
            this.cmdStartTransactions.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(69, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login as Admin";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AccountSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(363, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdStartTransactions);
            this.Controls.Add(this.label1);
            this.Name = "AccountSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button cmdStartTransactions;
        private Button button2;
    }
}