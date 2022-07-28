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
    public partial class viewTransaction : UserControl
    {   
        public viewTransaction()
        {
            InitializeComponent();
        }

        private void cmdViewTransactions_Click(object sender, EventArgs e)
        {
            string accountnumber = TxtAccountNumber.Text;
            string date = dateTimePicker1.Value.ToString("dd/MM/yy");

            if(string.IsNullOrEmpty(accountnumber) == false && string.IsNullOrEmpty(date) == false)
            {
                var mydata = new Dictionary<string, string>
                {
                    {"AccountNumber", accountnumber },
                    {"Date", date }
                };

                TransactionHistory transaction = new TransactionHistory(mydata);
                transaction.Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Please enter the details");
            }
           
        }
    }
}
