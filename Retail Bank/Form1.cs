namespace Retail_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdProceed_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Hide();
        }
    }
}
