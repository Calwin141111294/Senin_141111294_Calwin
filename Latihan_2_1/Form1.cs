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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime x = new DateTime(2016, (int)Bulan.SelectedIndex + 1, (int)tanggal.SelectedIndex + 1);
            MonthCalender.AddAnnuallyBoldedDate(x);
        }

        private void MonthCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime tanggallahir = new DateTime(2016, 9, 2);
            MonthCalender.AddAnnuallyBoldedDate(tanggallahir);
           
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime awal = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2016, 12, 31);
            for (int i = 0; i < akhir.DayOfYear; i++)
            {
                if (awal.DayOfWeek.ToString() == "Saturday" || awal.DayOfWeek.ToString() == "Sunday")
                {
                    MonthCalender.AddBoldedDate(awal);
                }
               awal= awal.AddDays(1);
            }
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime x = new DateTime(2016, (int)Bulan.SelectedIndex + 1, (int)tanggal.SelectedIndex + 1);
            if( x.DayOfWeek.ToString() != "Saturday" || x.DayOfWeek.ToString() != "Sunday" || x.Day != 2 || x.Month != 9)
            {
                MonthCalender.RemoveAnnuallyBoldedDate(x);
            }
            

        }
    }
}
