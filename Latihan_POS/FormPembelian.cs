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
    public partial class FormPembelian : Form
    {

        fill fill = new fill();
        public FormPembelian()
        {
            InitializeComponent();

        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            refresh();
        }
        public void refresh()
        {

            fill.fillBeli(dgvPenjualan, lblHarga);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            Status stats = new Status();
            bool hasilBarang = stats.cekKode(txtKodeBarang.Text, "Barang");
            bool hasilSupplier = stats.cekKode(txtNamaSupplier.Text, "Supplier");
            if (hasilBarang && hasilSupplier == true)
            {
                panel1.Visible = true;
                stats.cariKode(txtKodeBarang.Text, txtNamaBarang, txtHargaBarang, cmbJumlah);
            }
            else
            {
                MessageBox.Show("Salah Satu kode salah");
                panel1.Visible = false;
            }
        }

        private void btnJual_Click(object sender, EventArgs e)
        {
            Transaksi tranksaksi = new Transaksi();
            Decimal harga;
            Decimal quantity = Convert.ToDecimal(cmbJumlah.SelectedItem);
            Decimal hargawal = Convert.ToDecimal(txtHargaBarang.Text);
            harga = quantity * hargawal;
            tranksaksi.beli(txtNamaBarang.Text, txtNamaSupplier.Text, quantity, hargawal, harga);
            
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = new formHome();
            home.Show();
        }
    }
}
