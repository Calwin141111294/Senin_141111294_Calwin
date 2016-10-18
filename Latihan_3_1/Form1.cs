using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                cmbFont.Items.Add(font.Name.ToString());
            }
            for (int i = 8; i <= 72; i += 2)
            {
                cmbSize.Items.Add(i);
            }
            
            cmbSize.SelectedIndex = 2;
            cmbFont.Text = "Times New Roman";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbSize_Click(object sender, EventArgs e)
        {
          
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.ForeColor = color.Color;
        }

        private void toolUnderline_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Underline)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Underline);
                toolUnderline.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Underline);
                toolUnderline.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void toolBold_Click_1(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Bold)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Bold);
                toolBold.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Bold);
                toolBold.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void toolItalic_Click(object sender, EventArgs e)
        {
            Font new1, old;
            old = richTextBox1.SelectionFont;
            if (old.Italic)
            {
                new1 = new Font(old, old.Style & ~FontStyle.Italic);
                toolItalic.Checked = false;
            }
            else
            {
                new1 = new Font(old, old.Style | FontStyle.Italic);
                toolItalic.Checked = true;
            }
            richTextBox1.SelectionFont = new1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
          richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(cmbSize.SelectedItem.ToString()));
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cmbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }
    }
}
