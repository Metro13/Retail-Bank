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
    public partial class TableView : UserControl
    {
        Consumer user = new Consumer();

        Dictionary<string, string> data = new Dictionary<string, string>();
        public TableView(Dictionary<string, string> values)
        {
            InitializeComponent();
            data = values;
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            Transactionview.DataSource = user.ViewTransaction(data);    
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            ClientDashboard clientDashboard = new ClientDashboard();
            clientDashboard.Show();
            Hide();
        }
    }
}
