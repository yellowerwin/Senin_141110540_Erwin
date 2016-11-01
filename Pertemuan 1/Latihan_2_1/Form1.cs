using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1996, 9, 23));
            DateTime start = new DateTime(2016, 1, 1);
            DateTime end = new DateTime(2017, 1, 1);
            while (start < end)
            {
                if (start.DayOfWeek == DayOfWeek.Saturday)
                {
                    // bold sabtu
                    monthCalendar1.AddBoldedDate(start);
                    // bold minggu
                    start = start.AddDays(1);
                    if (start != end)
                        monthCalendar1.AddBoldedDate(start);

                    start = start.AddDays(5);
                }

                start = start.AddDays(1);

            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private String[] bulan;
        private int[] array;
        private void Form1_Load(object sender, EventArgs e)
        {
            tanggalUpDown.ReadOnly = true;
            bulanUpDown.ReadOnly = true;

            bulan = new String[] { "January","February", "March"
            , "April", "May", "June", "Juli", "August", "September", "October",
            "November", "December"};

            array = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Input Item Tanggal pada tanggalUpDown
            for (int i = 1; i <= array[0]; i++)
                tanggalUpDown.Items.Add(i);

            // Input Item Tanggal pada bulanUpDown
            for (int i = 0; i < 12; i++)
                bulanUpDown.Items.Add(bulan[i]);

            // set selected Item pada tanggalUpdown dan bulanUpDown
            tanggalUpDown.SelectedItem = 1;
            bulanUpDown.SelectedItem = "January";
        }

        private void bulanUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < 12; i++)
            {
                if (bulanUpDown.SelectedItem == bulan[i])
                {
                    tanggalUpDown.Items.Clear();
                    for (int j = 1; j <= array[i]; j++)
                        tanggalUpDown.Items.Add(j);

                    tanggalUpDown.SelectedItem = 1;
                    break;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bulan = bulanUpDown.SelectedIndex + 1;
            int tanggal = tanggalUpDown.SelectedIndex + 1;
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, bulan, tanggal));

            monthCalendar1.UpdateBoldedDates();
        }

            private void buttonDelete_Click(object sender, EventArgs e)
            {
            int bulan = bulanUpDown.SelectedIndex + 1;
            int tanggal = tanggalUpDown.SelectedIndex + 1;
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, bulan, tanggal));
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1996, 9, 23));
            monthCalendar1.UpdateBoldedDates();
        }

        
    }
}
