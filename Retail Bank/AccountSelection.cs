using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Bank
{
    public partial class AccountSelection : Form
    {
        public AccountSelection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Hide();
        }

        private void cmdClientSide_Click(object sender, EventArgs e)
        {
            AccountLogin accountLogin = new AccountLogin();
            accountLogin.Show();
            Hide();
        }
    }
}
