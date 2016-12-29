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
    public partial class FormListBarang : Form
    {
        fill fill = new fill();
        public FormListBarang()
        {
            InitializeComponent();
            
            fill.fillTable(dgvBarang);
            dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListItem lst = new FormListItem();
            lst.Show();
        }

        public void refresh()
        {
            fill.fillTable(dgvBarang);
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (dgvBarang.SelectedRows.Count > 0)
                {
                     if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                     {
                         string barang = dgvBarang.SelectedCells[1].Value.ToString();
                         Delete hapus = new Delete();
                         hapus.hapusBarang(barang);
                         refresh();
                     }
                     else
                     {
                         refresh();
                     }
                    
                }
                else
                {
                    MessageBox.Show("Nothing To Delete");
                }
            
        }

     
    }
}

        

        

        

         
    
