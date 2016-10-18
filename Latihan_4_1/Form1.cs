using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
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

        private void btnColor_Click(object sender, EventArgs e)
        {
            var color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.ForeColor = color.Color;
        }

        private void toolBold_Click(object sender, EventArgs e)
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
   
        private void cmbSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(cmbSize.SelectedItem.ToString()));
        }

        private void cmbFont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cmbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        
        OpenFileDialog ofd = new OpenFileDialog();

        private void OpenTool_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Rich Text Box(*.rtf)|*.rtf";
            ofd.FileName = "";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                String text = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(text);
            }   
        }
        SaveFileDialog sfd = new SaveFileDialog();
        private void SaveTool_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Rich Text Box(*.rtf)|*.rtf";
            sfd.FileName = "";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Modified)
            {
                if (MessageBox.Show("File Anda Belum Disimpan!! Apakah anda ingin keluar ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sfd.Filter = "Rich Text Box(*.rtf)|*.rtf";
                    sfd.FileName = "";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    }
                }
            }
            else
            {
                Application.Exit();
            }

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!richTextBox1.Modified)
            {
                richTextBox1.Clear();
            }
            else
            {
                if (MessageBox.Show("File Anda Belum Disimpan!! Ingin disimpan ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sfd.Filter = "Rich Text Box(*.rtf)|*.rtf";
                    sfd.FileName = "";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, richTextBox1.Text);
                    }
                }
                richTextBox1.Clear();
            }
        }

    }
}
