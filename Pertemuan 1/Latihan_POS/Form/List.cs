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
    public partial class List : Form
    {
        public List()
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

        private void List_Load(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            dataGridViewBarang.DataSource = barang.DisplayBarang();

            Customer customer = new Customer();
            dataGridViewCustomer.DataSource = customer.DisplayBarang();

            Supplier supplier = new Supplier();
            dataGridViewSupplier.DataSource = supplier.DisplayBarang();

            Pembelian pembelian = new Pembelian();
            dataGridViewPembelian.DataSource = pembelian.DisplayBarang();

            Penjualan penjualan = new Penjualan();
            dataGridViewPenjualan.DataSource = penjualan.DisplayBarang();
        }

        private void tabPagePenjualan_Click(object sender, EventArgs e)
        {

        }

        private void btnBatalPenjualan_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalPembelian_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }
    }
}
