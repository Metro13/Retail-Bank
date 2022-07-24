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
        public void getAccountDetails(Dictionary<string, string> AccountDetails)
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
        public int OpenAccount()
        {
            
                if (AccountType == "Savings Account".ToLowerInvariant())
                {
                    InterestEligibility = "Applicable";
                }
                else
                {
                    InterestEligibility = "Not Applicable";
                }

                const string query = "INSERT INTO Account (AccountNumber, AccountName, AccountType, AccountPin, AccountBalance, InterestEligibility) VALUES (@AccountNumber, @AccountName, @AccountType, @AccountPin , @AccountBalance, @interestEligibility)";

                var args = new Dictionary<string, object>
                {
                    {"@Accountname", AccountName},
                    {"@AccountNumber", AccountNumber},
                    {"@AccountType", AccountType},
                    {"@AccountBalance", AccountBalance},
                    {"@AccountPin", AccountPin },
                    {"@interestEligibility", InterestEligibility },

                };

             return conn.MyCommandExecuter(query, args);
            
        }
        public void CloseAccount()
        {
           
          
        }
        public void MakeDeposit()
        {

        }
        public void Withdraw()
        {
           
        }
    }
}
