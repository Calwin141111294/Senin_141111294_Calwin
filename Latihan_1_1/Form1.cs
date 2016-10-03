using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(label1.Text);
            int max = Convert.ToInt32(label2.Text);

            int selisih = Math.Abs(max - min);
            if (selisih != 0)
            {
                dateTimePicker1.MinDate = DateTime.Now.AddYears(-(selisih));
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(selisih);
            }
            else
            {
                dateTimePicker1.MaxDate = DateTime.Now;
                dateTimePicker1.MinDate = DateTime.Now;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = ((VScrollBar)sender).Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = ((VScrollBar)sender).Value.ToString();
        }

 
    }
}
