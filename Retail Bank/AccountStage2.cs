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
    public partial class AccountStage2 : UserControl
    {
        Administrator admin = new Administrator();
        public AccountStage2()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> _accounts()
        {
            var newAccountData = new Dictionary<string, string>
            {
                {"AccountNumber", TextAccountNumber.Text },
                {"AccountName", TextVerifyAccountName.Text},
                {"AccountType", cmbAccountType.SelectedItem.ToString()},
                {"Email", TxtVerifyEmail.Text},
            };
            return newAccountData;
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(TextAccountNumber.Text) == false &&
                    string.IsNullOrEmpty(TextVerifyAccountName.Text) == false &&
                    string.IsNullOrEmpty(TxtVerifyEmail.Text) == false)
                {
                    string selectedaccountType = cmbAccountType.SelectedItem.ToString();

                    string availableAccount =  admin.VerifyAccount(TextAccountNumber.Text, TextVerifyAccountName.Text);

                    if (availableAccount ==  selectedaccountType)
                    {
                        MessageBox.Show("You cannot create two similar accounts, please try the other account");
                    }
                    else
                    {
                        Dictionary<string, string> newAccountData = _accounts();
                        admin.pairSecondAccountData(newAccountData);
                        string userid = admin.getUserID();
                        string accountid = admin.getAccountID();

                        if(string.IsNullOrEmpty(userid) == false && string.IsNullOrEmpty(accountid) == false)
                        {
                            int uID = int.Parse(userid);
                            int accID =int.Parse(accountid);

                            int result = admin.UpdateAddedAccounts(uID, accID);

                            if(result > 0)
                            {
                                MessageBox.Show("Account added successfully");
                            }
                            else
                            {
                                MessageBox.Show("Opps ran into an error, check your details or try later");
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
        }
    }
}
