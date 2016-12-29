using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
namespace Latihan_POS.Class
{
    class fill
    {
        public void fillTable(DataGridView dgvBarang)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            dgvBarang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBarang.Rows.Clear();
            dgvBarang.Refresh();
            String sql = "SELECT * FROM tblbarang";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvBarang, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(),
                    reader.GetString(4).ToString(), reader.GetString(5).ToString(), reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss"), reader.GetDateTime(7).ToString("dd-MM-yyyy HH:mm:ss"));
                dgvBarang.Rows.Add(row);
            }

             conn.Close();
            
        }
        public void fillCustomer(DataGridView dgvCustomer)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            dgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Rows.Clear();
            dgvCustomer.Refresh();
            String sql = "SELECT * FROM tblcustomer";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCustomer, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(),
                    reader.GetDateTime(4).ToString("dd-MM-yyyy HH:mm:ss"), reader.GetDateTime(5).ToString("dd-MM-yyyy HH:mm:ss"));
                dgvCustomer.Rows.Add(row);
            }

            conn.Close();
        }
        public void fillSupplier(DataGridView dgvSupplier)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            dgvSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSupplier.Rows.Clear();
            dgvSupplier.Refresh();
            String sql = "SELECT * FROM tblSupplier";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSupplier, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(),
                    reader.GetString(4).ToString(), reader.GetString(5).ToString(), reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss"), reader.GetDateTime(7).ToString("dd-MM-yyyy HH:mm:ss"));
                dgvSupplier.Rows.Add(row);
            }

            conn.Close();
        }
        public void fillJual(DataGridView dgvJual,Label harga)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            dgvJual.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJual.Rows.Clear();
            dgvJual.Refresh();
            String sql = "SELECT * FROM tblpenjualan";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            int hargaJ = 0;
            while (reader.Read())
            {
            
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvJual, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetString(5).ToString(), reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss"));
                hargaJ += reader.GetInt32(5);
                //hargaJ += Convert.ToInt32(reader.GetString(5).ToString());
                dgvJual.Rows.Add(row);
            }
            harga.Text = String.Format("{0:C},00",hargaJ);
            conn.Close();
        }
        public void fillBeli(DataGridView dgvJual, Label harga)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            dgvJual.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvJual.Rows.Clear();
            dgvJual.Refresh();
            String sql = "SELECT * FROM tblpembelian";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            int hargaJ = 0;
            while (reader.Read())
            {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvJual, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetString(5).ToString(), reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss"));
                hargaJ += reader.GetInt32(5);
                //hargaJ += Convert.ToInt32(reader.GetString(5).ToString());
                dgvJual.Rows.Add(row);
            }
            harga.Text = String.Format("{0:C},00", hargaJ);
            conn.Close();
        }
    }
}
