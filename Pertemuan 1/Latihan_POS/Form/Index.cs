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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        public void OpenForm(Form Form)
        {
            Form.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new Register());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpenForm(new Delete());
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            OpenForm(new Transaksi());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            OpenForm(new List());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        
    }
}
