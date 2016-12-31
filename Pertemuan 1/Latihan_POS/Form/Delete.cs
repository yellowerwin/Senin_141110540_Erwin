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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        public void OpenForm(Form Form)
        {
            Form.Show();
            this.Dispose();
            this.Close();
        }

        private void btnBatalSupplier_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalBarang_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnBatalCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new Index());
        }

        private void btnDeleteBarang_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();

            try
            {
                barang.setId(Convert.ToInt32(txtIdBarang.Text));

                barang.Delete();
                MessageBox.Show("Deleted ID =" + barang.getId());
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            try
            {
                customer.setId(Convert.ToInt32(txtIdCustomer.Text));

                customer.Delete();
                MessageBox.Show("Deleted ID =" + customer.getId());
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            try
            {
                supplier.setId(Convert.ToInt32(txtIdSupplier.Text));

                supplier.Delete();
                MessageBox.Show("Deleted ID =" + supplier.getId());
                OpenForm(new Index());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
