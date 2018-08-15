using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace the_billing_concept.Mysql
{
    class Connection
    {
        protected string connectionString = @"Server=localhost;Database=billing;Uid=root;Pwd=;";
        MySqlConnection conn;

        public Connection()
        {
            conn = new MySqlConnection(connectionString);

        }
    }
}
