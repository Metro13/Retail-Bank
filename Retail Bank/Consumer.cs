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
    internal class Consumer:User
    {
        DBConnection conn = new DBConnection();
        public int AuthenticateConsumer(string accountnumber, int pin)
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT U.AccountNumber, A.AccountPin  FROM Account A, UserAccounts U WHERE A.AccountID = U.AccountID AND U.AccountNumber=@accnumber AND A.AccountPin=@accpin", conn))
                {
                    AccountNumber = accountnumber;

                    command.Parameters.Add(new SQLiteParameter("@accnumber", AccountNumber));
                    command.Parameters.Add(new SQLiteParameter("@accpin", pin));

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
        public string ViewBalance(string accountnumber, string accounttype)
        {
            AccountNumber = accountnumber;
            AccountType = accounttype;

            const string query = "SELECT AccountBalance FROM UserAccounts WHERE AccountNumber = @accnumber AND AccountType=@accType";

            var args = new Dictionary<string, object>
            {
                {"@accnumber", AccountNumber},
                {"@accType", AccountType},
            };

            return conn.ReturnQueryValueExecutor(query, args);
        }
        public DataTable ViewTransaction(Dictionary<string, string> transactiondata)
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT AccountNumber, TransactionType, Amount, Date FROM Transactions WHERE AccountNumber=@accnumber AND Date=@date", conn))
                {
                    command.Parameters.Add(new SQLiteParameter("@accnumber", transactiondata["AccountNumber"]));
                    command.Parameters.Add(new SQLiteParameter("@date", transactiondata["Date"]));

                    command.ExecuteNonQuery();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();

                    adapter.SelectCommand = command;
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }

            }

        }
        public void TransferMoney()
        {

        }

        public void AddPayee()
        {

        }
        public void MakePayment()
        {

        }
    }
}
