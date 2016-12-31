using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        public void OpenForm(Form Form)
        {
            Form.Show();
            this.Dispose();
            this.Close();
        }

        private void btnBatalPembelian_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalPenjualan_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBeliPembelian_Click(object sender, EventArgs e)
        {
            Pembelian beli = new Pembelian();

            try
            {
                beli.setKode(txtKodePembelian.Text);
                beli.setIdBarang(Convert.ToInt32(txtIdBarangPembelian.Text));
                beli.setIdSupplier(Convert.ToInt32(txtIdSupplierPembelian.Text));
                beli.setHargaBarang(Convert.ToInt32(txtHargaBarangPembelian.Text));
                beli.setKuantitas(Convert.ToInt32(txtKuantitasPembelian.Text));
                beli.setTotalHarga(Convert.ToInt32(txtTotalHargaPembelian.Text));

                beli.Insert();
                MessageBox.Show("Success");
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Data Harus Terisi Semua");
            }
        }


        private void btnJualPenjualan_Click(object sender, EventArgs e)
        {
            Penjualan jual = new Penjualan();

            try
            {
                jual.setKode(txtKodePenjualan.Text);
                jual.setIdBarang(Convert.ToInt32(txtIdBarangPenjualan.Text));
                jual.setIdCustomer(Convert.ToInt32(txtIdCustomerPenjualan.Text));
                jual.setHargaBarang(Convert.ToInt32(txtHargaBarangPenjualan.Text));
                jual.setKuantitas(Convert.ToInt32(txtKuantitasPenjualan.Text));
                jual.setTotalHarga(Convert.ToInt32(txtTotalHargaPenjualan.Text));

                jual.Insert();
                MessageBox.Show("Success");
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Data Harus Terisi Semua");
            }
        }
    }
}
