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
    public partial class ClientDashboard : Form
    {
        public ClientDashboard()
        {
            InitializeComponent();
        }

        private void cmdViewBalance_Click(object sender, EventArgs e)
        {
            ViewBalance viewBalance = new ViewBalance();
            ActionPanel.Controls.Add(viewBalance);
            viewBalance.Show();
        }

        private void cmdViewTransactions_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            viewTransaction viewTransaction = new viewTransaction();
            ActionPanel.Controls.Add(viewTransaction);  
            viewTransaction.Show();
        }

        private void cmdTransferFunds_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            TransferFunds transferFunds = new TransferFunds();
            ActionPanel.Controls.Add(transferFunds);
            transferFunds.Show();
        }

        private void cmdAddPayee_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            AddPayee addPayee = new AddPayee();
            ActionPanel.Controls.Add(addPayee);
            addPayee.Show();
        }

        private void cmdMakePaymentt_Click(object sender, EventArgs e)
        {
            ActionPanel.Controls.Clear();
            MakePayment makePayment = new MakePayment();
            ActionPanel.Controls.Add(makePayment);
            makePayment.Show();
        }
    }
}
