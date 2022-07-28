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
    public partial class ViewBalance : UserControl
    {
        Consumer user = new Consumer();
        public ViewBalance()
        {
            InitializeComponent();
        }

        private void cmdCheckBalance_Click(object sender, EventArgs e)
        {
            string accountnumber = TxtAccountNumber.Text;
            string accountType = cmbAccountType.SelectedItem.ToString();

            if(string.IsNullOrEmpty(accountType) == false && string.IsNullOrEmpty(accountnumber) == false)
            {
                double balance = double.Parse(user.ViewBalance(accountnumber, accountType));

                MessageBox.Show("Your current balance from " + accountType + " is Mwk " + balance);
            }
            else
            {
                MessageBox.Show("Please enter the form details to proceed");
            }
        }
    }
}
