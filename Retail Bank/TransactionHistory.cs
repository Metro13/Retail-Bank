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
    public partial class TransactionHistory : Form
    {
        Consumer user = new Consumer();

        Dictionary<string, string> data = new Dictionary<string, string>();
        public TransactionHistory(Dictionary<string, string> values)
        {
            InitializeComponent();
            data = values;
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            ClientDashboard clientDashboard = new ClientDashboard();
            clientDashboard.Show();
            Hide();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            Transactionview.DataSource = user.ViewTransaction(data);
        }
    }
}
