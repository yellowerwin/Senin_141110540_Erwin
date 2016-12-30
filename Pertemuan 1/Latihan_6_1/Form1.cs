using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Latihan_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form Insert = new Insert();
            Insert.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;
            password=;database=TugasFramework";

            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            string Query = "SELECT * FROM String;";

            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);

            
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            conn.Close();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form Delete = new Delete();
            Delete.Show();

            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form Update = new Update();
            Update.Show();

            this.Hide();
        }
    }
}
