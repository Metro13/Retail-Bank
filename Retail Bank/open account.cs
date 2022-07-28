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
    public partial class open_account : UserControl
    {
        Administrator admin = new Administrator();
        int userID;
        int accountID;
        public open_account()
        {
            InitializeComponent();
            
            
        }

        private void open_account_Load(object sender, EventArgs e)
        {
            panelStage1.Visible = true;
            panelStage2.Visible = false;
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(Txtfullname.Text) == false
                    && string.IsNullOrEmpty(TxtEmailAddress.Text) == false
                    && string.IsNullOrEmpty(TxtPhoneNumber.Text) == false
                    && string.IsNullOrEmpty(TextHomeAddress.Text) == false)
                {
                    string name = Txtfullname.Text;
                    string[] splitted = name.Split(" ");

                    var PersonalData = new Dictionary<string, string>
                    {
                        {"Firstname", splitted[0] },
                        {"Lastname", splitted[1] },
                        {"Email", TxtEmailAddress.Text },
                        {"Address", TextHomeAddress.Text },
                        { "Phone", TxtPhoneNumber.Text},

                    };

                    admin.getPersonalDetails(PersonalData);


                    int Result = admin.AddAccountPersonalDetails();

                    if (Result > 0)
                    {
                        userID = int.Parse(admin.getUserID());

                        if(userID > 0)
                        {
                            panelStage1.Visible = false;
                            panelStage2.Visible = true;
                            LblAccountName.Text = Txtfullname.Text;
                        }
                        else
                        {
                            return;
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Opps! ran into an Error processing personal details");
                    }
                }
                else
                {
                    MessageBox.Show("Opps! Can't proceed with empty fields");
                }

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private Dictionary<string, string> AccountDetails(string accountType)
        {
            var AccountData = new Dictionary<string, string>
            {
                {"AccountNumber", TxtAccountNumber.Text },
                {"AccountType",accountType},
                {"AccountPin", TxtPincode.Text },
                {"InitialBalance", TxtDeposit.Text},
            };

            return AccountData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtAccountNumber.Text) == false
                    && string.IsNullOrEmpty(TxtPincode.Text) == false
                    && string.IsNullOrEmpty(TxtDeposit.Text) == false)
                {
                    //account verification

                    string  accountType = cmbAccountType.SelectedItem.ToString();
                            
                    Dictionary<string, string> newAccountData = AccountDetails(accountType);
                    admin.PairAccountDetails(newAccountData);

                    int QueryResult = admin.OpenBankAccount();

                     if (QueryResult > 0)
                     {

                        accountID = int.Parse(admin.getAccountID());

                        if (accountID > 0)
                        {
                            int updateAccountsResult = admin.UpdateAddedAccounts(userID, accountID);
                            if (updateAccountsResult > 0)
                            {
                                MessageBox.Show("Bank Account Opened Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Opps! ran into an error creating account");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opps ran into an error try check the details");
                        }
                     }
                     else
                     {
                        MessageBox.Show("Opps ran into an error try check the details");
                     }
                       
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
