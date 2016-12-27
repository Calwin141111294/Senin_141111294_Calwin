using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Class
{

    class Edit
    {
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=latihan_pos; Uid=root; pwd=''";
        MySqlCommand cmd;

        private bool Angka(String angka)
        {

            for (int i = 0; i < angka.Length; i++)
                if (!char.IsNumber(angka[i]))
                    return false;
            return true;
        }
        
        public void edit(string item,string kodeB,string nama,string jumlah,string beli,string jual)
        {
            conn = new MySqlConnection(connString);
             if(item == "Barang")
             {
                 try
                 {

                     conn.Open();
                     DateTime now = DateTime.Now;
                     String waktuNow = now.ToString("yyyy/MM/dd HH:mm:ss");
                     String sql = "UPDATE tblbarang SET nama='" + nama + "'" +","+"jumlahawal='"+ jumlah + "'" +"," + "hargahpp= '" + Convert.ToDecimal(beli) + "'" + "," + "hargajual='" + Convert.ToDecimal(jual) + "'" + "," + "updatedate='" + waktuNow + "'" + "WHERE kodeBarang='"+ kodeB +"'" ;
                     cmd = new MySqlCommand(sql, conn);
                     cmd.ExecuteNonQuery();
                     //MessageBox.Show(sql);
                     MessageBox.Show("Produk barang berhasil diubah", "Edited");    
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
             else
             {
                 MessageBox.Show("kode tidak ditemukan");
             }       
            }
            public void editCustomer(string item, string namaCus,string alamat,string noHP)
            {
                conn = new MySqlConnection(connString);
                if(!Angka(noHP))
                {
                    MessageBox.Show("Nomor HP Diisi dengan angka");
                }
                else if(noHP.Length > 12)
                {
                    MessageBox.Show("Nomor HP Tidak boleh lebih panjang dari 12 digit");
                }
                else if( noHP.Length < 11)
                {
                    MessageBox.Show("Nomor HP Minimal 11 Digit");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        DateTime now = DateTime.Now;
                        String waktuNow = now.ToString("yyyy/MM/dd HH:mm:ss");
                        String sql = "UPDATE tblcustomer SET nama_customer='" + namaCus + "'" + "," + "alamat_customer='" + alamat + "'" + "," + "noHPCustomer= '" + noHP + "'" + "," + "updatedate='" + waktuNow + "'" + "WHERE nama_customer='" + namaCus + "'";
                        //MessageBox.Show(sql);
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show(sql);
                        MessageBox.Show("Tabel Customer sudah berhasil diubah", "Edited");
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
            public void editSupplier(string item, string kodeSup, string namaSup, string alamatSup,string kotaSup,string nohpsup)
            {
                conn = new MySqlConnection(connString);
                if (!Angka(nohpsup))
                {
                    MessageBox.Show("Nomor HP Diisi dengan angka");
                }
                else if (nohpsup.Length > 12)
                {
                    MessageBox.Show("Nomor HP Tidak boleh lebih panjang dari 12 digit");
                }
                else if (nohpsup.Length < 11)
                {
                    MessageBox.Show("Nomor HP Bro Minimal 11 Digit");
                    
                }
                else
                {
                    try
                    {
                        conn.Open();
                        DateTime now = DateTime.Now;
                        String waktuNow = now.ToString("yyyy/MM/dd HH:mm:ss");
                        String sql = "UPDATE tblsupplier SET kodeSupplier='" + kodeSup + "'" + "," + "nama='" + namaSup + "'" + "," + "alamat= '" + kotaSup + "'" + "," + "noHPSupplier='" + nohpsup + "'" + "," + "updatedate='" + waktuNow + "'" + "WHERE kodeSupplier='" + kodeSup + "'";
                        
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                //        MessageBox.Show(sql);
                        MessageBox.Show("Tabel Supplier sudah berhasil diubah", "Edited");
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
    }
    
