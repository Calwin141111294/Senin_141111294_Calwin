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
    public partial class FormListBarang : Form
    {
        public FormListBarang()
        {
            InitializeComponent();
            WhenYouSeeMe fill = new WhenYouSeeMe();
            fill.fillTable(dgvBarang);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListItem lst = new FormListItem();
            lst.Show();
        }

         
    }
}
