using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Latihan_POS.Class
{
    class Status
    {
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=latihan_pos; Uid=root; pwd=''";
        MySqlCommand cmd;
        public bool cekKode(String kode, String item)
        {
            conn = new MySqlConnection(connString);
            bool hasil = false;
            if (item == "Barang")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblbarang where kodeBarang = '" + kode + "' ";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
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
            else if(item=="Customer")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblcustomer where nama_customer = '" + kode + "'";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
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
            else if (item == "Supplier")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblsupplier where kodesupplier = '" + kode + "'";
                    cmd = new MySqlCommand(sql, conn);
                    hasil = cmd.ExecuteReader().HasRows;
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
            return hasil;
        }

    }
}
