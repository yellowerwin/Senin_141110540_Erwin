using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    class Pembelian
    {
        private Connection koneksi = new Connection();

        private string kode;
        private int idSupplier;
        private int idBarang;
        private int hargaBarang;
        private int kuantitas;
        private int totalHarga;

        // Kode Pembelian
        public Pembelian setKode(string kode)
        {
            this.kode = kode;
            return this;
        }
        public string getKode()
        {
            return kode;
        }
        // Id Supplier Pembelian
        public Pembelian setIdSupplier(int idSupplier)
        {
            this.idSupplier = idSupplier;
            return this;
        }
        public int getCode()
        {
            return idSupplier;
        }
        // Id Barang Pembelian
        public Pembelian setIdBarang(int idBarang)
        {
            this.idBarang = idBarang;
            return this;
        }
        public int getIdBarang()
        {
            return idBarang;
        }
        // Harga Barang Pembelian
        public Pembelian setHargaBarang(int hargaBarang)
        {
            this.hargaBarang = hargaBarang;
            return this;
        }
        public int getHargaBarang()
        {
            return hargaBarang;
        }
        // Kuantitas Pembelian
        public Pembelian setKuantitas(int kuantitas)
        {
            this.kuantitas = kuantitas;
            return this;
        }
        public int getKuantitas()
        {
            return kuantitas;
        }
        // Total Harga Pembelian
        public Pembelian setTotalHarga(int totalHarga)
        {
            this.totalHarga = totalHarga;
            return this;
        }
        public int getTotalHarga()
        {
            return totalHarga;
        }

        // Insert Pembelian
        public void Insert()
        {
            koneksi.Connect();
            string sql = "INSERT INTO pembelian(Kode,IdSupplier,IdBarang,HargaBarang,Kuantitas,TotalHarga)VALUES(@Kode,@IdSupplier,@IdBarang,@HargaBarang,@Kuantitas,@TotalHarga)";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            cmd.Parameters.AddWithValue("@Kode", this.kode);
            cmd.Parameters.AddWithValue("@IdSupplier", this.idSupplier);
            cmd.Parameters.AddWithValue("@IdBarang", this.idBarang);
            cmd.Parameters.AddWithValue("@HargaBarang", this.hargaBarang);
            cmd.Parameters.AddWithValue("@Kuantitas", this.kuantitas);
            cmd.Parameters.AddWithValue("@TotalHarga", this.totalHarga);
            cmd.ExecuteNonQuery();
            koneksi.Disconnect();
        }
        // Update Pembelian
        public void Update()
        {
            koneksi.Connect();
            string sql =
            "UPDATE pembelian SET TotalHarga='" + this.totalHarga + "',IdSupplier='" + this.idSupplier + "',IdBarang='" + this.idBarang + "',HargaBarang='" + this.hargaBarang + "',Kuantitas='" + this.kuantitas + "' WHERE Kode='" + this.kode + "';";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi.conn);
            MySqlDataReader Reader = cmd.ExecuteReader();
            koneksi.Disconnect();
        }
        // Delete Pembelian
        public void Delete()
        {
            koneksi.Connect();
            string sql = "DELETE FROM pembelian WHERE Kode='" + this.kode + "'";
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
                using (MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM pembelian", koneksi.conn))
                {
                    sql.Fill(table_brg);
                }
                koneksi.Disconnect();
            }
            return table_brg;
        }
    }
}
