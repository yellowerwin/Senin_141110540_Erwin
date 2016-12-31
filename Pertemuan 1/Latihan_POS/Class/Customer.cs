using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Latihan_POS
{
    class Customer
    {
        private Connection koneksi = new Connection();

        private int id;
        private string code;
        private string nama;
        private string alamat;
        private string telp;
        private string hp;

        // ID Customer
        public Customer setId(int id)
        {
            this.id = id;
            return this;
        }
        public int getId()
        {
            return id;
        }
        // Code Customer
        public Customer setCode(string code)
        {
            this.code = code;
            return this;
        }
        public string getCode()
        {
            return code;
        }
        // Nama Customer
        public Customer setNama(string nama)
        {
            this.nama = nama;
            return this;
        }
        public string getNama()
        {
            return nama;
        }
        // Alamat Customer
        public Customer setAlamat(string alamat)
        {
            this.alamat = alamat;
            return this;
        }
        public string getAlamat()
        {
            return alamat;
        }
        // Hp Customer
        public Customer setHp(string hp)
        {
            this.hp = hp;
            return this;
        }
        public string getHp()
        {
            return hp;
        }
        // Telp Customer
        public Customer setTelp(string telp)
        {
            this.telp = telp;
            return this;
        }
        public string getTelp()
        {
            return telp;
        }

        // Insert Customer
        public void Insert()
        {
            koneksi.Connect();
            string sql = "INSERT INTO customer(ID,Kode,Nama,Alamat,Telp,HP)VALUES(@ID,@Kode,@Nama,@Alamat,@Telp,@HP)";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            cmd.Parameters.AddWithValue("@ID", this.id);
            cmd.Parameters.AddWithValue("@Kode", this.code);
            cmd.Parameters.AddWithValue("@Nama", this.nama);
            cmd.Parameters.AddWithValue("@Alamat", this.alamat);
            cmd.Parameters.AddWithValue("@Telp", this.telp);
            cmd.Parameters.AddWithValue("@HP", this.hp);
            cmd.ExecuteNonQuery();
            koneksi.Disconnect();
        }

        // Update Customer
        public void Update()
        {
            koneksi.Connect();
            string sql =
            "UPDATE customer SET Kode='" + this.code + "',Nama='" + this.nama + "',Alamat='" + this.alamat + "',Telp='" + this.telp + "',HP='" + this.hp + "' WHERE ID='" + this.id + "';";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            MySqlDataReader Reader = cmd.ExecuteReader();
            koneksi.Disconnect();
        }

        // Delete Customer
        public void Delete()
        {
            koneksi.Connect();
            string sql = "DELETE FROM customer WHERE ID='" + this.id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            MySqlDataReader Reader = cmd.ExecuteReader();
            koneksi.Disconnect();
        }

        // Display Barang
        public DataTable DisplayBarang()
        {
            koneksi.Connect();
            DataTable table_brg = new DataTable();
            using (koneksi.conn)
            {
                using (MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM customer", koneksi.conn))
                {
                    sql.Fill(table_brg);
                }
                koneksi.Disconnect();
            }
            return table_brg;
        }
    }
}
