using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_POS.Class;

namespace Latihan_POS
{
    public partial class FormRegistrasiCustomer : Form
    {
        Registrasi barang = new Registrasi();
        public FormRegistrasiCustomer()
        {
            InitializeComponent();
        }

        private void FormRegistrasiCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtSimpan_Click(object sender, EventArgs e)
        {
            String namaCustomer = txtNamCustomer.Text,
                    AlamatCustomer = txtAlamatCustomer.Text,
                  NoHpCustomer = txtNoHp.Text;
            try
            {
                barang.tambahCustomer(namaCustomer,AlamatCustomer,NoHpCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                  
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            txtNamCustomer.Text = "";
            txtAlamatCustomer.Text = "";
            txtNoHp.Text = "";
        }

        private void txtKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Home = new formHome();
            Home.Show();
        }
    }
}
