
using MySql.Data.MySqlClient;

namespace the_billing_concept
{
    internal class Connection
    { 
        string connectionString = string.Format("server={0};user id={1};password={2};database={3};",
                "localhost", "root", "", "billing");
        public MySqlConnection conn;
        public Connection()
        {
             conn = new MySqlConnection(connectionString);
        }

  
    }
}

 