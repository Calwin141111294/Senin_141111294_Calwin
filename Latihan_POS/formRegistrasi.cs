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
namespace Latihan_POS
{
    public partial class formRegistrasi : Form
    {
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=barang; Uid=root; pwd=''";
        MySqlCommand cmd;
        public formRegistrasi()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
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
            this.Refresh();
        }
        private bool Angka(String angka)
        {

            for (int i = 0; i < angka.Length; i++)
                if ((int)angka[i] < 48 || (int)angka[i] > 57)
                    return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String kode = txtKode.Text,
                   nama = txtNama.Text,
                   jumlah = txtJumlah.Text,
                   hargaAwal = txtModal.Text,
                   hargaJual = txtJual.Text;
            if(kode =="")
            {
                MessageBox.Show("Kode Tidak boleh kosong");
                return;
            }
            if( nama =="")
            {
                MessageBox.Show("Nama Tidak boleh kosong");
                return;
            }
            if( jumlah =="" || !Angka(jumlah))
             {
                 MessageBox.Show("Jumlah isi dengan angka");
                 return;
             }
            if( hargaAwal=="" || !Angka(hargaAwal))
            {
                MessageBox.Show("Harga isi dengan angka");
                return;
            }
            if( hargaJual=="" || !Angka(hargaJual))
            {
                MessageBox.Show("Harga isi dengan angka");
                return;
            }
            try
            {
                conn.Open();
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                DateTime update = DateTime.Now;
                String waktuUpdate = update.ToString("yyyy/MM/dd HH:mm:ss");
                String values = "VALUES ('" + kode + "', '" + nama + "', '" + jumlah + "', '" + Convert.ToDecimal(hargaAwal) + "', '" + Convert.ToDecimal(hargaJual) + "','" + waktuNow + "','" + waktuUpdate + "' );";
                MessageBox.Show(values);
                String sql = "INSERT INTO tblbarang(kode,nama,jumlahawal,hargahpp,hargaJual,createdate,updatedate) " + values;
                cmd = new MySqlCommand(sql, conn);   
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Barang Sukses");       
            }
            catch
            {
                MessageBox.Show("DB Error");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
