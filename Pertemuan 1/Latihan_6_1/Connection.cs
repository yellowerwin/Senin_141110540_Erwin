﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Latihan_6_1
{
    class Connection
    {
        string cs = @"server=localhost;userid=root;
            password=;database=TugasFramework";

        MySqlConnection conn = null;
        public void Connect()
        {
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        public void Insert(string input)
        {
            Connect();

            string Query = "INSERT INTO String (Input) values('" + input + "');";
            MySqlCommand cmd = new MySqlCommand(Query, conn);

            conn.Open();
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();

            conn.Close();
        }

        public void Delete(int ID)
        {
            Connect();

            string Query = "DELETE FROM String WHERE ID='" + ID + "';";

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            
            conn.Open();
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateData(int ID, string input)
        {
            Connect();

            string Query = "UPDATE String SET input = '"+ input+"' WHERE ID='" + ID +"';";

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            
            conn.Open();
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();

            conn.Close();
        }
    }
}
