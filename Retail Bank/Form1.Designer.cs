namespace Retail_Bank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Max Bank";
            // 
            // cmdProceed
            // 
            this.cmdProceed.BackColor = System.Drawing.Color.White;
            this.cmdProceed.Location = new System.Drawing.Point(100, 224);
            this.cmdProceed.Name = "cmdProceed";
            this.cmdProceed.Size = new System.Drawing.Size(147, 52);
            this.cmdProceed.TabIndex = 1;
            this.cmdProceed.Text = "Proceed";
            this.cmdProceed.UseVisualStyleBackColor = false;
            this.cmdProceed.Click += new System.EventHandler(this.cmdProceed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(361, 411);
            this.Controls.Add(this.cmdProceed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button cmdProceed;
    }
}