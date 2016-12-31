using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    class Barang
    {
        private Connection koneksi = new Connection();

        private int id;
        private string code;
        private string nama;
        private int jumlah;
        private int hpp;
        private int hargajual;
        
        // ID Barang
        public Barang setId(int id)
        {
            this.id = id;
            return this;
        }
        public int getId()
        {
            return id;
        }
        // Code Barang
        public Barang setCode(string code)
        {
            this.code = code;
            return this;
        }
        public string getCode()
        {
            return code;
        }
        // Nama Barang
        public Barang setNama(string nama)
        {
            this.nama = nama;
            return this;
        }
        public string getNama()
        {
            return nama;
        }
        // Jumlah Barang
        public Barang setJumlah(int jumlah)
        {
            this.jumlah = jumlah;
            return this;
        }
        public int getJumlah()
        {
            return jumlah;
        }
        // HPP
        public Barang setHpp(int hpp)
        {
            this.hpp = hpp;
            return this;
        }
        public int getHpp()
        {
            return hpp;
        }
        // Harga Jual
        public Barang setHargaJual(int hargajual)
        {
            this.hargajual = hargajual;
            return this;
        }
        public int getHargaJual()
        {
            return hargajual;
        }

        // Insert Barang
        public void Insert()
        {
            koneksi.Connect();
            string sql = "INSERT INTO barang(ID,Kode,Nama,Jumlah,HargaHPP,HargaJual)VALUES(@ID,@Kode,@Nama,@Jumlah,@HargaHPP,@HargaJual)";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            cmd.Parameters.AddWithValue("@ID", this.id);
            cmd.Parameters.AddWithValue("@Kode", this.code);
            cmd.Parameters.AddWithValue("@Nama", this.nama);
            cmd.Parameters.AddWithValue("@Jumlah", this.jumlah);
            cmd.Parameters.AddWithValue("@HargaHPP", this.hpp);
            cmd.Parameters.AddWithValue("@HargaJual", this.hargajual);
            cmd.ExecuteNonQuery();
            koneksi.Disconnect();
        }

        // Update Barang
        public void Update()
        {
            koneksi.Connect();
            string sql ="UPDATE barang SET Kode='"+this.code+"',Nama='"+this.nama+"',Jumlah='"+this.jumlah+"',HargaHPP='"+this.hpp+"',HargaJual='"+this.hargajual+"' WHERE ID='"+this.id+"';";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            MySqlDataReader Reader = cmd.ExecuteReader();
            koneksi.Disconnect();
        }

        // Delete Barang
        public void Delete()
        {
            koneksi.Connect();
            string sql = "DELETE FROM barang WHERE ID='"+this.id+"'";
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
                using (MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM barang", koneksi.conn))
                {
                    sql.Fill(table_brg);
                }
                koneksi.Disconnect();
            }
            return table_brg;
        }
    }
}
