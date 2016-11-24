using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            
            long a = Convert.ToInt64(Txt1.Text);
            
            long b = Convert.ToInt64(Txt2.Text);
            long HasilAkhir = -1;

            // cek nilai terbesar (harus a) 
            if (b > a)
            {
                long c = b;
                b = a;
                a = c;
            }

            if ((a == 25 && b < 24))
            {
                long max = a + b - 1;
                long min = b;

                //Hitung
                HasilAkhir = 1;
                for (int i = 1; i <= min; i++)
                {
                    HasilAkhir *= max;
                    HasilAkhir /= i;
                    max--;

                }
                if (HasilAkhir > 1000000007)
                    HasilAkhir %= 1000000007;
            }
            else if (a >= 24 && b >= 24 && a - b == 2)
            {
                long max = a + b - 49;
                long min = b - 24;

                //Hitung
                HasilAkhir = 603457371;
                for (int i = 1; i <= min; i++)
                {
                    HasilAkhir *= max;
                    HasilAkhir /= i;
                    max--;

                }
                if (HasilAkhir > 1000000007)
                    HasilAkhir %= 1000000007;
            }
            else
            {
                HasilAkhir = 0;
            }

            TxtHasil.Text = HasilAkhir.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
