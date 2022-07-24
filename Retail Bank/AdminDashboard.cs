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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();  
        }

     
        private void cmdAddAccount_Click(object sender, EventArgs e)
        {
            open_account _Account = new open_account();
            ActionPanel.Controls.Add(_Account);
            _Account.Show();
        }

        private void ActionPanel_Paint(object sender, PaintEventArgs e)
        { 

        }
    }
}
