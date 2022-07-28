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
    internal class DBConnection
    {
        private int numrows;
        public string returnvalue;
    
        public string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public int MyCommandExecuter(string query, Dictionary<string, object> args)
        {
           
            // database connection using Connection string from AppConfig
            using (var connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (var pair in args)
                    {
                        command.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    // execute the Query & Returning Number of Rows
                    numrows = command.ExecuteNonQuery();

                }
                return numrows;
            }
        }

        public string ReturnQueryValueExecutor(string query, Dictionary<string, object> args)
        {
            try
            {
                // database connection using Connection string from AppConfig
                using (var connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        foreach (var pair in args)
                        {
                            command.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                        // execute the Query & Returning Number of Rows
                        returnvalue = command.ExecuteScalar().ToString();

                    }
                    
                }
               
            }
            catch(NullReferenceException err)
            {
                MessageBox.Show(err.Message);
            }

            return returnvalue;
        }

    }
}
