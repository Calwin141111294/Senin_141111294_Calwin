using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Latihan_POS.Class;

namespace Latihan_POS
{
    public partial class formRegistrasiBarang : Form
    {

        public formRegistrasiBarang()
        {
            InitializeComponent();
        }

        private void formRegistrasi_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Home = new formHome();
            Home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtJumlah.Text = "";
            txtModal.Text = "";
            txtJual.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kode = txtKode.Text,
                   nama = txtNama.Text,
                   jumlah = txtJumlah.Text,
                   hargaAwal = txtModal.Text,
                   hargaJual = txtJual.Text;
            Registrasi barang = new Registrasi();
            try
            {
                barang.tambahBarang(kode, nama, jumlah, hargaAwal, hargaJual);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
