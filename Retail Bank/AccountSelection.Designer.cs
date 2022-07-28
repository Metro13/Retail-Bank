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
            this.cmdClientSide = new System.Windows.Forms.Button();
            this.cmdAdmin = new System.Windows.Forms.Button();
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
            // cmdClientSide
            // 
            this.cmdClientSide.BackColor = System.Drawing.Color.White;
            this.cmdClientSide.Location = new System.Drawing.Point(69, 196);
            this.cmdClientSide.Name = "cmdClientSide";
            this.cmdClientSide.Size = new System.Drawing.Size(212, 42);
            this.cmdClientSide.TabIndex = 1;
            this.cmdClientSide.Text = "Login as client";
            this.cmdClientSide.UseVisualStyleBackColor = false;
            this.cmdClientSide.Click += new System.EventHandler(this.cmdClientSide_Click);
            // 
            // cmdAdmin
            // 
            this.cmdAdmin.BackColor = System.Drawing.Color.White;
            this.cmdAdmin.Location = new System.Drawing.Point(69, 257);
            this.cmdAdmin.Name = "cmdAdmin";
            this.cmdAdmin.Size = new System.Drawing.Size(212, 43);
            this.cmdAdmin.TabIndex = 2;
            this.cmdAdmin.Text = "Login as Admin";
            this.cmdAdmin.UseVisualStyleBackColor = false;
            this.cmdAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(363, 438);
            this.Controls.Add(this.cmdAdmin);
            this.Controls.Add(this.cmdClientSide);
            this.Controls.Add(this.label1);
            this.Name = "AccountSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button cmdClientSide;
        private Button cmdAdmin;
    }
}