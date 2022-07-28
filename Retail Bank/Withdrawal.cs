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
    public partial class Withdrawal : UserControl
    {
        Administrator admin = new Administrator();
        public Withdrawal()
        {
            InitializeComponent();
        }

        private void cmdWithdraw_Click(object sender, EventArgs e)
        {
            string accountType = cmbAccountType.SelectedItem.ToString();
            string accountnumber = TxtAccountNumber.Text;
            double withdrawAmount = double.Parse(txtWithdrawAmount.Text);

            if (string.IsNullOrEmpty(accountType) == false && 
                string.IsNullOrEmpty(accountnumber) == false)
            {
                double currentBalance = double.Parse(admin.getCurrentBalance(accountnumber, accountType));
                if(withdrawAmount > currentBalance)
                {
                    MessageBox.Show("The client have insufficient funds. The current balance is " + currentBalance);
                }
                else
                {
                    int result = admin.WithdrawFunds(accountnumber, withdrawAmount, currentBalance, accountType);

                    if(result > 0)
                    {
                        double remainingBalance = currentBalance - withdrawAmount;

                        MessageBox.Show("Withdrawal successfull. The remaining balance is " + remainingBalance);
                    }
                    else
                    {
                        MessageBox.Show("Withdrawal failed. Try again later..");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the form to complete the transaction");
            }
        }
    }
}
