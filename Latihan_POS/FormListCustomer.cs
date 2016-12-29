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
    public partial class FormListCustomer : Form
    {
        fill fill = new fill();
        public FormListCustomer()
        {
            InitializeComponent();
            
            fill.fillCustomer(dgvCustomer);
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refresh()
        {
            fill.fillCustomer(dgvCustomer);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListItem lst = new FormListItem();
            lst.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (dgvCustomer.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string customer = dgvCustomer.SelectedCells[1].Value.ToString();
                        Delete hapus = new Delete();
                        hapus.hapusCustomer(customer);
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

