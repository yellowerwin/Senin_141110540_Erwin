using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    class Supplier
    {
        private Connection koneksi = new Connection();

        private int id;
        private string code;
        private string nama;
        private string alamat;
        private string telp;
        private string hp;

        // ID Supplier
        public Supplier setId(int id)
        {
            this.id = id;
            return this;
        }
        public int getId()
        {
            return id;
        }
        // Code Supplier
        public Supplier setCode(string code)
        {
            this.code = code;
            return this;
        }
        public string getCode()
        {
            return code;
        }
        // Nama Supplier
        public Supplier setNama(string nama)
        {
            this.nama = nama;
            return this;
        }
        public string getNama()
        {
            return nama;
        }
        // Alamat Supplier
        public Supplier setAlamat(string alamat)
        {
            this.alamat = alamat;
            return this;
        }
        public string getAlamat()
        {
            return alamat;
        }
        // Hp Supplier
        public Supplier setHp(string hp)
        {
            this.hp = hp;
            return this;
        }
        public string getHp()
        {
            return hp;
        }
        // Telp Supplier
        public Supplier setTelp(string telp)
        {
            this.telp = telp;
            return this;
        }
        public string getTelp()
        {
            return telp;
        }

        // Insert Supplier
        public void Insert()
        {
            koneksi.Connect();
            string sql = "INSERT INTO supplier(ID,Kode,Nama,Alamat,Telp,HP)VALUES(@ID,@Kode,@Nama,@Alamat,@Telp,@HP)";
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

        // Update Supplier
        public void Update()
        {
            koneksi.Connect();
            string sql =
            "UPDATE supplier SET Kode='" + this.code + "',Nama='" + this.nama + "',Alamat='" + this.alamat + "',Telp='" + this.telp + "',HP='" + this.hp + "' WHERE ID='" + this.id + "';";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            MySqlDataReader Reader = cmd.ExecuteReader();
            koneksi.Disconnect();
        }

        // Delete Supplier
        public void Delete()
        {
            koneksi.Connect();
            string sql = "DELETE FROM supplier WHERE ID='" + this.id + "'";
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
                using (MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM supplier", koneksi.conn))
                {
                    sql.Fill(table_brg);
                }
                koneksi.Disconnect();
            }
            return table_brg;
        }
    }
}
