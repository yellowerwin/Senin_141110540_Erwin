﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_6_1
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form index = new Form1();
            index.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection konek = new Connection();
            try
            {
                konek.Delete(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Berhasil dihapus");
                Form index = new Form1();
                index.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
