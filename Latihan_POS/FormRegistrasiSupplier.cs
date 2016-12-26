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
    public partial class FormRegistrasiSupplier : Form
    {
        public FormRegistrasiSupplier()
        {
            InitializeComponent();
        }

        private void FormRegistrasiSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            String kode = txtKode.Text,
                   nama = txtNama.Text,
                   alamat = txtAlamat.Text,
                   noHp = txtNoHP.Text,
                   kota = txtKota.Text;
            Registrasi Supplier = new Registrasi();
            try
            {
                Supplier.tambahSupplier(kode, nama, alamat, noHp, kota);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

    }
}
