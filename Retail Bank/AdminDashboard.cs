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
            ActionPanel.Controls.Clear();
            open_account _Account = new open_account();
            ActionPanel.Controls.Add(_Account);
            _Account.Show();
        }

        private void ActionPanel_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void cmdExistingAccount_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            AccountStage2 stage2 = new AccountStage2();
            ActionPanel.Controls.Add(stage2);
            stage2.Show();
          
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ActionPanel.Visible = true;
            viewAccounts view = new viewAccounts();
            ActionPanel.Controls.Add(view);
            view.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            Close_Account close_accPanel = new Close_Account();
            ActionPanel.Controls.Add(close_accPanel);
            close_accPanel.Show();  
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            Deposit deposit = new Deposit();
            ActionPanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void cmdWithdraw_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            Withdrawal withdrawal = new Withdrawal();
            ActionPanel.Controls.Add(withdrawal);   
            withdrawal.Show();
        }
    }
}
