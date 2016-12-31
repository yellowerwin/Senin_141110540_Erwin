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
    }
}
