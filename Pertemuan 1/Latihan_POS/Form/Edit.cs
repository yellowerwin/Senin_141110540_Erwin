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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        public void OpenForm(Form Form)
        {
            Form.Show();
            this.Dispose();
            this.Close();
        }

        private void btnBatalBarang_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalSupplier_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnSimpanBarang_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();

            try
            {
                barang.setCode(txtKodeBarang.Text.ToString());
                barang.setId(Convert.ToInt32(txtIdBarang.Text));
                barang.setJumlah(Convert.ToInt32(txtJumlahBarang.Text));
                barang.setNama(txtNamaBarang.Text.ToString());
                barang.setHargaJual(Convert.ToInt32(txtHargaJualBarang.Text));
                barang.setHpp(Convert.ToInt32(txtHargaPokokBarang.Text));

                barang.Update();
                MessageBox.Show("Success");
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Data Harus Terisi Semua");
            }
        }

        private void btnSimpanCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            try
            {
                customer.setCode(txtKodeCustomer.Text.ToString());
                customer.setId(Convert.ToInt32(txtIdCustomer.Text));
                customer.setAlamat(txtAlamatCustomer.Text);
                customer.setNama(txtNamaCustomer.Text.ToString());
                customer.setTelp(txtTelpCustomer.Text);
                customer.setHp(txtHpCustomer.Text);

                customer.Update();
                MessageBox.Show("Success");
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Data Harus Terisi Semua");
            }
        }

        private void btnSimpanSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            try
            {
                supplier.setCode(txtKodeSupplier.Text.ToString());
                supplier.setId(Convert.ToInt32(txtIdSupplier.Text));
                supplier.setAlamat(txtAlamatSupplier.Text);
                supplier.setNama(txtNamaSupplier.Text.ToString());
                supplier.setTelp(txtTelpSupplier.Text);
                supplier.setHp(txtHpSupplier.Text);

                supplier.Update();
                MessageBox.Show("Success");
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Data Harus Terisi Semua");
            }
        }

        private void btnBatalPenjualan_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalPembelian_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnUpdatePembelian_Click(object sender, EventArgs e)
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

                beli.Update();
                MessageBox.Show("Success");
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Data Harus Terisi Semua");
            }
        }

        private void btnUpdatePenjualan_Click(object sender, EventArgs e)
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

                jual.Update();
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
