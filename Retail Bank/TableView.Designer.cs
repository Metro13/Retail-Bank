namespace Retail_Bank
{
    partial class TableView
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
            this.cmdHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Transactionview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactionview)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Location = new System.Drawing.Point(15, 324);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(90, 33);
            this.cmdHome.TabIndex = 0;
            this.cmdHome.Text = "Home";
            this.cmdHome.UseVisualStyleBackColor = true;
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Transactionview);
            this.panel1.Location = new System.Drawing.Point(109, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 368);
            this.panel1.TabIndex = 1;
            // 
            // Transactionview
            // 
            this.Transactionview.AllowUserToAddRows = false;
            this.Transactionview.AllowUserToDeleteRows = false;
            this.Transactionview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactionview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Transactionview.Location = new System.Drawing.Point(0, 0);
            this.Transactionview.Name = "Transactionview";
            this.Transactionview.ReadOnly = true;
            this.Transactionview.RowTemplate.Height = 25;
            this.Transactionview.Size = new System.Drawing.Size(540, 368);
            this.Transactionview.TabIndex = 0;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdHome);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(652, 381);
            this.Load += new System.EventHandler(this.TableView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Transactionview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdHome;
        private Panel panel1;
        private DataGridView Transactionview;
    }
}
