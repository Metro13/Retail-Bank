namespace Retail_Bank
{
    partial class viewAccounts
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
            this.AccountsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsDataGrid
            // 
            this.AccountsDataGrid.AllowUserToAddRows = false;
            this.AccountsDataGrid.AllowUserToDeleteRows = false;
            this.AccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.AccountsDataGrid.Name = "AccountsDataGrid";
            this.AccountsDataGrid.ReadOnly = true;
            this.AccountsDataGrid.RowTemplate.Height = 25;
            this.AccountsDataGrid.Size = new System.Drawing.Size(549, 381);
            this.AccountsDataGrid.TabIndex = 0;
            // 
            // viewAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.AccountsDataGrid);
            this.Name = "viewAccounts";
            this.Size = new System.Drawing.Size(549, 381);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView AccountsDataGrid;
    }
}
