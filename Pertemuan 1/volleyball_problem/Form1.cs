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
            
            long a = Convert.ToInt64(txta.Text);
            
            long b = Convert.ToInt64(txtb.Text);
            long HasilAkhir = -1;

            // cek nilai terbesar (harus a) 
            if (b > a)
            {
                long c = b;
                b = a;
                a = c;
            }

            if ((a == 25 && b < 24) || (b == 25 && a < 24) || (a >= 24 && b >= 24 && a - b == 2))
            {
                long max = a + b - 1;
                long min = b;
                long[] Perkali = new long[min];
                long[] Pembagi = new long[min];

                // masukan nilai ke array
                int index = 0;
                for (long i = max; i > max - min; i--)
                {
                    Perkali[index] = i;
                    index++;
                }
                index = 0;
                for (long i = min; i >= 1; i--)
                {
                    Pembagi[index] = i;
                    index++;
                }

                // Filter Array
                for (int i = 0; i < min; i++)
                {
                    for (int j = 0; j < min; j++)
                    {
                        if (Pembagi[i] == 1)
                        {
                            break;
                        }
                        else
                        {
                            if (Perkali[j] % Pembagi[i] == 0)
                            {
                                Perkali[j] /= Pembagi[i];
                                Pembagi[i] /= Pembagi[i];
                            }
                        }
                    }
                }


                HasilAkhir = 1;
                for (int i = 0; i < min; i++)
                {
                    HasilAkhir *= Perkali[i];
                    if (HasilAkhir > 1000000007)
                        HasilAkhir %= 1000000007;
                }
            }
            else
            {
                HasilAkhir = 0;
            }

            txthasil.Text = HasilAkhir.ToString();
            
        }
    }
}
