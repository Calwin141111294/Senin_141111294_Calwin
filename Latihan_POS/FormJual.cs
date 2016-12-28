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
using MySql.Data.MySqlClient;
namespace Latihan_POS
{
    public partial class FormJual : Form
    {
        MySqlConnection conn;
        String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
        MySqlCommand cmd;
        MySqlDataReader reader;
        WhenYouSeeMe fill = new WhenYouSeeMe();
        public FormJual()
        {
            InitializeComponent();
        }

        private void FormJual_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ConnString);
            panel1.Visible = false;
            refresh();

        }

        public void refresh()
        {
            
            fill.fillJual(dgvPenjualan, txtTotal);   
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            Status stats = new Status();
            bool hasilBarang = stats.cekKode(txtKodeBarang.Text, "Barang");
            bool hasilCustomer = stats.cekKode(txtNamaCust.Text, "Customer");
            if( hasilBarang && hasilCustomer == true)
            {
                panel1.Visible = true;
                try
                {
                    conn.Open();
                    string sql = "SELECT nama,jumlahawal,hargajual FROM tblBarang where kodeBarang = '" + txtKodeBarang.Text +"'";
            //        MessageBox.Show(sql);
                    cmd = new MySqlCommand(sql,conn);
                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        
                        txtNamaBarang.Text = reader.GetString(0);
                        txtHargaBarang.Text = reader.GetString(2);
                        string banyak = reader.GetString(1);

                        for (int i = 1; i < Convert.ToInt32(banyak); i++)
                        {
                            cmbJumlah.Items.Add(i);
                        }
                    
                    }
                    
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Salah Satu kode salah");
                panel1.Visible = false;
            }
        }

        private void btnJual_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Decimal harga;
                Decimal quantity = Convert.ToDecimal(cmbJumlah.SelectedItem);
                Decimal hargawal = Convert.ToDecimal(txtHargaBarang.Text);
                harga = quantity * hargawal;

                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();

                string insert = "INSERT INTO tblpenjualan (namaBarang,namaCustomer,jumlahbeli,hargajual,hargaakhir,waktujual)";
                insert += " VALUES (@kode,@nama,@jumlah,@hargahpp,@hargajual,@createDate)";

                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@kode", txtNamaBarang.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaCust.Text);
                cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(quantity));
                cmd.Parameters.AddWithValue("@hargahpp", hargawal);
                cmd.Parameters.AddWithValue("@hargajual", harga);
                cmd.Parameters.AddWithValue("@createDate", waktuNow);
                cmd.ExecuteNonQuery();
                MessageBox.Show("barang berhasil dijual");
                refresh();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
