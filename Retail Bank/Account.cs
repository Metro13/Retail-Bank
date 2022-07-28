using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;

namespace Retail_Bank
{
    internal class Account
    {
        private string accountName;
        private string accountNumber;
        private string accountType;
        private string accountPin;
        private double accountBalance;
        

        private string interestEligibility;
        DBConnection connection = new DBConnection();


        public Account()
        {

        }
       
        public string InterestEligibility
        {
            set { interestEligibility = value; }
            get { return interestEligibility; }
        }
       
        public string AccountName
        {
            set { accountName = value; }
            get { return accountName; }
        }
        public string AccountNumber
        {
            set
            {
                accountNumber = value;
            }
            get
            {
                return accountNumber;
            }
        }
        public string AccountType
        {
            set
            {
                accountType = value;
            }
            get { return accountType; }
        }

        public string AccountPin
        {
            set => accountPin = value;
            get { return accountPin; }
        }

        public double AccountBalance
        {
            set=> accountBalance = value; 
            get
            {
                return accountBalance;
            }
        }

        //checking the number of accounts in the database

        public string VerifyAccount(string Accountnumber, string Fullname)
        {
            string query = "SELECT AccountType FROM UserAccounts WHERE AccountNumber =@AccNumber";

            var args = new Dictionary<string, object>
            {
                {"@AccNumber", Accountnumber}
            };

            return connection.ReturnQueryValueExecutor(query, args);
        }
     
    }
}
