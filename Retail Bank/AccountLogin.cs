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
    public partial class AccountLogin : Form
    {
        Consumer user = new Consumer();
        public AccountLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string accountnumber = TxtAccountNumber.Text;
            string pin = TxtAccountPin.Text;

            if(string.IsNullOrEmpty(accountnumber) == false && string.IsNullOrEmpty(pin) == false)
            {
                int accountpin =  Convert.ToInt32(pin);

                int result = user.AuthenticateConsumer(accountnumber, accountpin);

                if(result > 0)
                {
                    ClientDashboard clientDashboard = new ClientDashboard();
                    clientDashboard.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account Number or Pin Try again");
                }
            }
            else
            {
                MessageBox.Show("Please enter details before proceeding");
            }
        }
    }
}
