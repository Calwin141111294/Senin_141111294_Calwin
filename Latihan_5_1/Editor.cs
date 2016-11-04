using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Latihan_5_1
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Form1 form = (Form1)MdiParent;
            foreach(KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                comboBox1.Items.Add(kc);
            }
            
            panel1.Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Text == "Background")
            {
                panel1.Visible = true;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)MdiParent;
            form.richTextBox1.BackColor = Color.FromName(comboBox1.Text);
            form.shw();
            this.Close();
        }
    }
}

