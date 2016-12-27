using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Latihan_POS.Class
{
    class Delete
    {
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=latihan_pos; Uid=root; pwd=''";
        
        public void hapusBarang(string kode)
        {
            conn = new MySqlConnection(connString);
            
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM tblbarang WHERE kodeBarang = @kode";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@kode", kode);              
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void hapusCustomer(string kode)
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM tblcustomer WHERE nama_customer = @nama";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nama", kode);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void hapusSupplier(string kode)
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM tblsupplier WHERE kodeSupplier = @kode";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
