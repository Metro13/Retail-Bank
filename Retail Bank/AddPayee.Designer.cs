namespace Retail_Bank
{
    partial class AddPayee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayeeNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPayeeName = new System.Windows.Forms.TextBox();
            this.cmdAddPayee = new System.Windows.Forms.Button();
            this.TxtPayeeType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Payee Number";
            // 
            // txtPayeeNumber
            // 
            this.txtPayeeNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPayeeNumber.Location = new System.Drawing.Point(91, 158);
            this.txtPayeeNumber.Multiline = true;
            this.txtPayeeNumber.Name = "txtPayeeNumber";
            this.txtPayeeNumber.Size = new System.Drawing.Size(175, 33);
            this.txtPayeeNumber.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(91, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Payee Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(360, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Payee Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(357, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 21);
            this.label14.TabIndex = 72;
            this.label14.Text = "Add Payee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(91, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Payee Name";
            // 
            // TxtPayeeName
            // 
            this.TxtPayeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPayeeName.Location = new System.Drawing.Point(91, 84);
            this.TxtPayeeName.Multiline = true;
            this.TxtPayeeName.Name = "TxtPayeeName";
            this.TxtPayeeName.Size = new System.Drawing.Size(175, 33);
            this.TxtPayeeName.TabIndex = 70;
            // 
            // cmdAddPayee
            // 
            this.cmdAddPayee.BackColor = System.Drawing.Color.White;
            this.cmdAddPayee.Location = new System.Drawing.Point(91, 297);
            this.cmdAddPayee.Name = "cmdAddPayee";
            this.cmdAddPayee.Size = new System.Drawing.Size(120, 42);
            this.cmdAddPayee.TabIndex = 69;
            this.cmdAddPayee.Text = "Add Payee";
            this.cmdAddPayee.UseVisualStyleBackColor = false;
            // 
            // TxtPayeeType
            // 
            this.TxtPayeeType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPayeeType.Location = new System.Drawing.Point(91, 236);
            this.TxtPayeeType.Multiline = true;
            this.TxtPayeeType.Name = "TxtPayeeType";
            this.TxtPayeeType.Size = new System.Drawing.Size(175, 33);
            this.TxtPayeeType.TabIndex = 78;
            // 
            // AddPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.TxtPayeeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayeeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPayeeName);
            this.Controls.Add(this.cmdAddPayee);
            this.Name = "AddPayee";
            this.Size = new System.Drawing.Size(549, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPayeeNumber;
        private Label label3;
        private Label label8;
        private Label label14;
        private Label label11;
        private TextBox TxtPayeeName;
        private Button cmdAddPayee;
        private TextBox TxtPayeeType;
    }
}
