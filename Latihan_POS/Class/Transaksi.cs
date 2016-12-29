using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Latihan_POS.Class;
namespace Latihan_POS.Class
{
    class Transaksi
    {
        MySqlConnection conn;
        String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
        

        public void beli(String nama, String supp, Decimal jumlah,Decimal hargawal, Decimal harga)
        {
            conn = new MySqlConnection(ConnString);
            
            try
            {
                conn.Open();
                string insert = "INSERT INTO tblpembelian (namaBarang,namaSupplier,jumlahBeli,hargabeli,hargaakhir,waktubeli)";
                insert += " VALUES (@kode,@nama,@jumlah,@hargahpp,@hargajual,@createDate)";
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@kode", nama);
                cmd.Parameters.AddWithValue("@nama", supp);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@hargahpp", hargawal);
                cmd.Parameters.AddWithValue("@hargajual", harga);
                cmd.Parameters.AddWithValue("@createDate", waktuNow);
                cmd.ExecuteNonQuery();
                MessageBox.Show("barang berhasil dibeli");
            }
            finally
            {
                conn.Close();
            }
        }
        public void jual(String nama, String cust, Decimal jumlah, Decimal hargawal, Decimal harga)
        {
            conn = new MySqlConnection(ConnString);
            
            try
            {
                conn.Open();
                string insert = "INSERT INTO tblpenjualan (namaBarang,namaCustomer,jumlahBeli,hargajual,hargaakhir,waktujual)";
                insert += " VALUES (@kode,@nama,@jumlah,@hargahpp,@hargajual,@createDate)";
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@kode", nama);
                cmd.Parameters.AddWithValue("@nama", cust);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@hargahpp", hargawal);
                cmd.Parameters.AddWithValue("@hargajual", harga);
                cmd.Parameters.AddWithValue("@createDate", waktuNow);
                cmd.ExecuteNonQuery();
                MessageBox.Show("barang berhasil dibeli");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
