using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    class Connection
    {
        string cs = @"server=localhost;userid=root;
            password=;database=latihanpos";

        public MySqlConnection conn = null;
        public void Connect()
        {
            conn = new MySqlConnection(cs);
            conn.Open();
        }
        
        public void Disconnect()
        {
            conn.Close();
        }
    }
}
