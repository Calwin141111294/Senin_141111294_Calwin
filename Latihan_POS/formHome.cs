using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void toolBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Tambah = new formRegistrasiBarang();
            Tambah.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Customer = new FormRegistrasiCustomer();
            Customer.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Supplier = new FormRegistrasiSupplier();
            Supplier.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Edit = new FormEdit();
            Edit.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegis regis = new formRegis();
            regis.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit edit = new FormEdit();
            edit.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete delete = new FormDelete();
            delete.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListItem list = new FormListItem();
            list.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenjualan jual = new FormPenjualan();
            jual.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPembelian beli = new FormPembelian();
            beli.Show();
        }

        private void formHome_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }
    }
}
