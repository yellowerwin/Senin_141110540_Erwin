using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satu
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            tahun.Text = scrollRangeTahun.Value.ToString();
            tahun2.Text = scrollRangeTahun2.Value.ToString();
            // ******************
            dateDisplay.MaxDate = new System.DateTime(2016 + scrollRangeTahun.Value -1, 12, 31, 0, 0, 0, 0);
            dateDisplay2.MaxDate = new DateTime(2016 + scrollRangeTahun.Value - 1, 12, 31, 0, 0, 0, 0);
            // ******************

            label3.Text = dateDisplay.Value.ToString("ddd, dd MMMMM yyyy");

            scrollTahun.Maximum = scrollRangeTahun.Value + 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tahun.Text = scrollRangeTahun.Value.ToString();
            dateDisplay.MaxDate = new System.DateTime(2016+scrollRangeTahun.Value, 12, 31, 0, 0, 0, 0);
            scrollTahun.Maximum = scrollRangeTahun.Value + 8;
        }

        private void dateDisplay_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void scrollTanggal_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue > e.NewValue)
            {
                // scrollUp
                if(scrollTanggal.Value != 0)
                    dateDisplay.Value = dateDisplay.Value.AddDays(-1);
                
            }
            if(e.OldValue < e.NewValue)
            {
                // scrollDown
                if(scrollTanggal.Value != 30)
                    dateDisplay.Value = dateDisplay.Value.AddDays(1);
            }

            label3.Text = dateDisplay.Value.ToString("ddd, dd MMMMM yyyy");            
        }

        private void scrollBulan_Scroll(object sender, ScrollEventArgs e)
        {
            while(scrollTanggal.Value != 0)
            {
                scrollTanggal.Value -= 1;
                dateDisplay.Value = dateDisplay.Value.AddDays(-1);
            }

            if (e.OldValue > e.NewValue)
            {
                // scrollUp
                if (scrollBulan.Value != 0)
                    dateDisplay.Value = dateDisplay.Value.AddMonths(-1);
            }
            if (e.OldValue < e.NewValue)
            {
                // scrollDown
                if (scrollBulan.Value != 11)
                    dateDisplay.Value = dateDisplay.Value.AddMonths(1);
            }

            label3.Text = dateDisplay.Value.ToString("ddd, dd MMMMM yyyy");
        }

        private void scrollTahun_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue > e.NewValue)
            {
                // scrollUp
                if (scrollTahun.Value != 0)
                    dateDisplay.Value = dateDisplay.Value.AddYears(-1);
            }
            if (e.OldValue < e.NewValue)
            {
                // scrollDown
                if (scrollBulan.Value != scrollBulan.Maximum)
                    dateDisplay.Value = dateDisplay.Value.AddYears(1);
            }
            label3.Text = dateDisplay.Value.ToString("ddd, dd MMMMM yyyy");
        }

        private void rangeTahun2_Scroll(object sender, ScrollEventArgs e)
        {
            tahun2.Text = scrollRangeTahun2.Value.ToString();
            dateDisplay2.MaxDate = new System.DateTime(2016 + scrollRangeTahun2.Value, 12, 31, 0, 0, 0, 0);
            scrollTahun.Maximum = scrollRangeTahun.Value + 8;
        }
    }
}
