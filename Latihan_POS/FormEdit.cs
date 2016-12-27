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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            pnlBarang.Visible = false;
            pnlCustomer.Visible = false;
            pnlSupplier.Visible = false;
            cmbCari.SelectedIndex = 0;
            if (cmbCari.SelectedItem.ToString() == "Customer")
            {
                label1.Text = "Nama";
            }
            Status status = new Status();
        }

       
        private void btnCari_Click(object sender, EventArgs e)
        {
            String kode = txtCariKode.Text;   
            if(cmbCari.SelectedIndex ==0)
            {
                
                string nama = cmbCari.SelectedItem.ToString();
           
                Status status = new Status();
                bool hasil = status.cekKode(kode, nama);
            
                if(kode.Trim() !="" && hasil)
                {
                    pnlBarang.Visible = true;
                    txtKodeBarang.Text = kode;
                    pnlCustomer.Visible = false;
                    pnlSupplier.Visible = false;
                }
                else
                {
                    MessageBox.Show("Kode tidak ditemukan");
                }
                
            }
            if(cmbCari.SelectedIndex == 1 )
            {
                string nama = cmbCari.SelectedItem.ToString();
                Status status = new Status();
                label1.Text = "Nama";
                bool hasil = status.cekKode(kode, nama);
                if(kode.Trim() !="" && hasil)
                {
                    pnlCustomer.Visible = true;
                    txtNamaCus.Text = kode;
                    pnlBarang.Visible = false;
                    pnlSupplier.Visible = false;
                }
                else
                {
                    MessageBox.Show("Nama Customer Tidak ditemukan");
                }
            }
            if(cmbCari.SelectedIndex == 2)
            {
                string nama = cmbCari.SelectedItem.ToString();
                Status status = new Status();
                bool hasil = status.cekKode(kode, nama);
                if(kode.Trim() !="" && hasil)
                {
                    pnlSupplier.Visible = true;
                    txtKodeSupplier.Text = kode;
                    pnlBarang.Visible = false;
                    pnlCustomer.Visible = false;
                }
                else
                {
                    MessageBox.Show("Kode Supplier tidak ditemukan");
                }
            
            }
        }

        private void btnSimpanBarang_Click(object sender, EventArgs e)
        {
            string nama = cmbCari.SelectedItem.ToString();
            Edit editbarang = new Edit();
            editbarang.edit(nama, txtKodeBarang.Text, txtNamaBarang.Text, txtJumlahBarang.Text, txtHargaAwal.Text, txtHargaJual.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSimpanCustomer_Click(object sender, EventArgs e)
        {
            string nama = cmbCari.SelectedItem.ToString();
            Edit customer = new Edit();
            customer.editCustomer(nama, txtCariKode.Text, txtAlamatCus.Text, txtNoHpCus.Text);
        }

        private void btnSimpanSupplier_Click(object sender, EventArgs e)
        {
            string nama = cmbCari.SelectedItem.ToString();
            Edit supplier = new Edit();
            supplier.editSupplier(nama, txtCariKode.Text, txtNamaSupplier.Text, txtAlamatSupplier.Text, txtKotaSupplier.Text, txtNoHPSupplier.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHome home = new formHome();
            home.Show();
        }

      
    }
}
