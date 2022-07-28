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
    public partial class Deposit : UserControl
    {
        Administrator admin = new Administrator();
        public Deposit()
        {
            InitializeComponent();
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            string accountType = cmbAccountType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(TxtAccountNumber.Text) == false &&
                string.IsNullOrEmpty(TxtDepositAmount.Text) == false &&
                string.IsNullOrEmpty(accountType) == false)
            {
                
                string accountnumber = TxtAccountNumber.Text;
                double depositAmount = double.Parse(TxtDepositAmount.Text);

                double currentBalance = double.Parse(admin.getCurrentBalance(accountnumber, accountType));

                if(currentBalance >= 0)
                {
                    int result = admin.MakeDeposit(accountnumber, depositAmount, currentBalance, accountType);

                    if(result > 0)
                    {
                        MessageBox.Show("Deposit of Mwk" + depositAmount + " to Account number " + accountnumber + " " + accountType + " successfull");
                    }
                    else
                    {
                        MessageBox.Show("Opps failed to make the deposit try later..");
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill the fields to complete the request");
            }
        }
    }
}
