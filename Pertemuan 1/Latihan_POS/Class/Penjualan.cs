using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Latihan_POS
{
    class Penjualan
    {
        private Connection koneksi = new Connection();

        private string kode;
        private int idCustomer;
        private int idBarang;
        private int hargaBarang;
        private int kuantitas;
        private int totalHarga;

        // Kode Penjualan
        public Penjualan setKode(string kode)
        {
            this.kode = kode;
            return this;
        }
        public string getKode()
        {
            return kode;
        }
        // Id Customer Penjualan
        public Penjualan setIdCustomer(int idCustomer)
        {
            this.idCustomer = idCustomer;
            return this;
        }
        public int getCode()
        {
            return idCustomer;
        }
        // Id Barang Penjualan
        public Penjualan setIdBarang(int idBarang)
        {
            this.idBarang = idBarang;
            return this;
        }
        public int getIdBarang()
        {
            return idBarang;
        }
        // Harga Barang Penjualan
        public Penjualan setHargaBarang(int hargaBarang)
        {
            this.hargaBarang = hargaBarang;
            return this;
        }
        public int getHargaBarang()
        {
            return hargaBarang;
        }
        // Kuantitas Penjualan
        public Penjualan setKuantitas(int kuantitas)
        {
            this.kuantitas = kuantitas;
            return this;
        }
        public int getKuantitas()
        {
            return kuantitas;
        }
        // Total Harga Penjualan
        public Penjualan setTotalHarga(int totalHarga)
        {
            this.totalHarga = totalHarga;
            return this;
        }
        public int getTotalHarga()
        {
            return totalHarga;
        }

        // Insert Penjualan
        public void Insert()
        {
            koneksi.Connect();
            string sql = "INSERT INTO penjualan(Kode,IdCustomer,IdBarang,HargaBarang,Kuantitas,TotalHarga)VALUES(@Kode,@IdCustomer,@IdBarang,@HargaBarang,@Kuantitas,@TotalHarga)";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            cmd.Parameters.AddWithValue("@Kode", this.kode);
            cmd.Parameters.AddWithValue("@IdCustomer", this.idCustomer);
            cmd.Parameters.AddWithValue("@IdBarang", this.idBarang);
            cmd.Parameters.AddWithValue("@HargaBarang", this.hargaBarang);
            cmd.Parameters.AddWithValue("@Kuantitas", this.kuantitas);
            cmd.Parameters.AddWithValue("@TotalHarga", this.totalHarga);
            cmd.ExecuteNonQuery();
            koneksi.Disconnect();
        }
        // Update Penjualan
        public void Update()
        {
            koneksi.Connect();
            string sql =
            "UPDATE penjualan SET TotalHarga='" + this.totalHarga + "',IdCustomer='" + this.idCustomer + "',IdBarang='" + this.idBarang + "',HargaBarang='" + this.hargaBarang + "',Kuantitas='" + this.kuantitas + "' WHERE Kode='" + this.kode + "';";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            MySqlDataReader Reader = cmd.ExecuteReader();
            koneksi.Disconnect();
        }
        // Delete Penjualan
        public void Delete()
        {
            koneksi.Connect();
            string sql = "DELETE FROM penjualan WHERE Kode='" + this.kode + "'";
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
                using (MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM penjualan", koneksi.conn))
                {
                    sql.Fill(table_brg);
                }
                koneksi.Disconnect();
            }
            return table_brg;
        }
    }
}
