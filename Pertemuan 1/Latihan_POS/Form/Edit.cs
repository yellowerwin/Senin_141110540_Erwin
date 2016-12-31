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
    }
}
