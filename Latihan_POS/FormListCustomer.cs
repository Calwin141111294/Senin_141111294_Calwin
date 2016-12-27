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
        public FormListCustomer()
        {
            InitializeComponent();
            WhenYouSeeMe fill = new WhenYouSeeMe();
            fill.fillCustomer(dgvCustomer);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListItem lst = new FormListItem();
            lst.Show();
        }

    }
}
