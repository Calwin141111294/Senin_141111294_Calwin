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
        public int pascal(int a, int b, int mod)
        {
            //Membuat Segitiga Pascal
            int[] segitiga = new int[b];

            //Nilai Awal Segitiga pascal = 1
            for (int i = 0; i < b; i++)
            {
                segitiga[i] = 1;
             //   MessageBox.Show(string.Join(",",segitiga));
            }

            //Pembuatan Segitiga sebanyak inputan
            for (int i = b - 2; i > 0; i--)
            {
                for (int j = i; j < b - 1; j++)
                {
                    segitiga[j] += segitiga[j + 1];
                    //MessageBox.Show(string.Join(",", segitiga));
                    segitiga[j] %= mod;
                    //MessageBox.Show(string.Join(",", segitiga));
                }
            }

            //Perhitungan kemungkinan main
            int kemungkinan = 1; //jika ada permainan maka minimal permainan = 1
            for (int i = 0; i < a; i++) //a = 25
            {
                for (int j = 0; j < b - 1; j++) // b == 9
                {
                    segitiga[j] += segitiga[j + 1]; //segitiga[0] += segitiga[1];
                    //MessageBox.Show(string.Join(",", segitiga));
                    segitiga[j] %= mod;
                   // MessageBox.Show(string.Join(",", segitiga));
                }

                kemungkinan += segitiga[0];
                //MessageBox.Show(game.ToString());
                kemungkinan %= mod;
            }
            return kemungkinan;
        }
        public long ex(long x, long exp_a, int mod)
        {
            long result = 1;
            while (exp_a > 0)
            {
                if (exp_a % 2 == 1)
                {
                    result *= x;
                    result %= mod;
                }
                exp_a /= 2;
                x *= x;
                x %= mod;
            }
            //MessageBox.Show(result.ToString());
            return result % mod;
            
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int mod = 1000000007;
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int temp;
            long hasil;
            // membuat nilai a > b
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if( a < 25 )
            {
                TxtHasil.Text = "0";
            }
            else if( a > 25 && a - b !=2)
            {
                TxtHasil.Text = "0";
            }
            else if (a == 25 && a - b !=2)
            {
                hasil = (long)pascal(a - 1, b,mod);
                TxtHasil.Text = hasil.ToString();   
            }
            else if (a > 25 && b == a - 2)
            {
                hasil = (long)pascal(24, 24, mod);
                //MessageBox.Show(hasil.ToString());
                int exp_a = b - 24;
                //MessageBox.Show("hasil : ");
                //MessageBox.Show(exp_a.ToString());
                hasil *= ex(2, exp_a, mod);
                hasil %= mod;
                TxtHasil.Text = hasil.ToString();
            }
        }
    }
}
