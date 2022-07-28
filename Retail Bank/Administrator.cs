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
    internal class Administrator:User
    {
        DBConnection conn = new DBConnection();
        private string ?Accountbalance;
        public int AUthenticateAdmin(string userID, string password)
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM user WHERE UserID =@Username AND Password =@Password", conn))
                {

                    command.Parameters.Add(new SQLiteParameter("@Username", userID));
                    command.Parameters.Add(new SQLiteParameter("@Password", password));

                    using (var reader = command.ExecuteReader())
                    {
                        var count = 0;
                        while (reader.Read())
                        {
                            count = count + 1;
                        }

                        return count;
                    }

                }
            }

        }
        public void getPersonalDetails(Dictionary<string, string> AccountDetails)
        {
            //personal details
            Firstname = AccountDetails["Firstname"];
            Lastname = AccountDetails["Lastname"];
            Email = AccountDetails["Email"];
            Address = AccountDetails["Address"];
            PhoneNumber = AccountDetails["Phone"];

        }
        public void PairAccountDetails(Dictionary<string, string> AccountDetails)
        {
              //account Details
             AccountName = Firstname + " " + Lastname;
             AccountNumber = AccountDetails["AccountNumber"];
             AccountType = AccountDetails["AccountType"];
             AccountPin = AccountDetails["AccountPin"];
             Accountbalance = AccountDetails["InitialBalance"];

              //converting account balance to double;
              AccountBalance = double.Parse(Accountbalance);
        }
        public void pairSecondAccountData(Dictionary<string, string> AccountData)
        {
            AccountName = AccountData["AccountName"];
            AccountNumber = AccountData["AccountNumber"];
            AccountType = AccountData["AccountType"];
            Email = AccountData["Email"];
        }
        public int AddAccountPersonalDetails()
        {
            const string query = "INSERT INTO Consumer (Firstname, Lastname, Email, Address, Phone) VALUES (@Firstname, @Lastname, @Email, @Address, @Phone)";

            var args = new Dictionary<string, object>
            {
                {"@Firstname", Firstname},
                {"@Lastname", Lastname},
                {"@Email", Email},
                {"@Address", Address},
                {"@Phone", PhoneNumber},
            };

            return conn.MyCommandExecuter(query, args);
        }

        public string getUserID()
        {
            const string query = "SELECT Id FROM Consumer WHERE Email = @email";

            var args = new Dictionary<string, object>
            {
                {"@email", Email},
            };

            return conn.ReturnQueryValueExecutor(query, args);
        }

        public string getAccountID()
        {
            const string query = "SELECT AccountID FROM Account WHERE AccountName = @accname";

            var args = new Dictionary<string, object>
            {
                {"@accname", AccountName},
            };

            return conn.ReturnQueryValueExecutor(query, args);
        }

        public int UpdateAddedAccounts(int userid, int accountid)
        {
            if (AccountType == "Savings Account")
            {
                InterestEligibility = "Applicable";
            }
            else
            {
                InterestEligibility = "Not Applicable";
            }

            const string query = "INSERT INTO UserAccounts (Id, AccountID, AccountNumber, AccountBalance, AccountType, InterestEligibility) VALUES ( @userid,  @AccId , @Accnumber, @accbalance, @accType, @interestElig)";

            var args = new Dictionary<string, object>
                {
                    {"@userid",userid},
                    {"@AccId", accountid},
                    {"@Accnumber", AccountNumber},
                    {"@accbalance", AccountBalance},
                    {"@AccType", AccountType},
                    {"@interestElig", InterestEligibility}
                };

            return conn.MyCommandExecuter(query, args);


        }
        public int OpenBankAccount()
        {

                const string query = "INSERT INTO Account (AccountName, AccountPin, DateOpened) VALUES ( @AccountName,  @Accountpin,  @openingDate)";

                var args = new Dictionary<string, object>
                {
                    {"@Accountname", AccountName},
                    {"@Accountpin", AccountPin},
                    {"@openingDate", DateTime.Today.Date },

                };

             return conn.MyCommandExecuter(query, args);
            
        }

        public int CloseAccount(string accountName, int pin)
        {
            AccountName = accountName;
            AccountPin = pin.ToString();
            const string query = "UPDATE Account SET AccountStatus = 'Closed' WHERE AccountName = @accname AND AccountPin = @accpin;";

            var args = new Dictionary<string, object>
                {
                    {"@accname", AccountName},
                    {"@accpin", AccountPin},
                };

            return conn.MyCommandExecuter(query, args);
        }

        public string getCurrentBalance(string accountnumber, string accountType)
        {
            AccountNumber = accountnumber;
            AccountType = accountType;
            const string query = "SELECT AccountBalance FROM UserAccounts WHERE AccountNumber = @accnumber AND AccountType=@accType";
            var args = new Dictionary<string, object>
            {
                {"@accnumber", AccountNumber},
                {"@accType", AccountType},
            };
            return conn.ReturnQueryValueExecutor(query, args);
        }

        public int MakeDeposit(string accountnumber, double depositAmount, double currentBalance, string accountType)
        {
            AccountNumber = accountnumber;
            AccountType = accountType;
            double totalbalance =  currentBalance + depositAmount;

            const string query = "UPDATE UserAccounts SET AccountBalance =@accbalance WHERE AccountNumber = @accnumber AND AccountType=@acctype";
            var args = new Dictionary<string, object>
            {
                {"@accnumber", AccountNumber},
                {"@accbalance", totalbalance},
                {"@acctype", AccountType},
            };
            return conn.MyCommandExecuter(query, args);

        }
        public int WithdrawFunds(string accountNumber, double amount, double currentBalance, string accountype) 
        {
            AccountNumber = accountNumber;
            AccountType = accountype;
            double remainingBalance;

            double withdraw() => remainingBalance = currentBalance - amount;
            withdraw();


            const string query = "UPDATE UserAccounts SET AccountBalance =@accbalance WHERE AccountNumber = @accnumber AND AccountType=@acctype";
            var args = new Dictionary<string, object>
            {
                {"@accnumber", AccountNumber},
                {"@accbalance", remainingBalance},
                {"@acctype", AccountType},
            };
            return conn.MyCommandExecuter(query, args);
        }
    }
}
