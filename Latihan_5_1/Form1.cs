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

namespace Latihan_5_1
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

            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                cmbColor.Items.Add(kc);
                cmbBackColor.Items.Add(kc);
            }
            cmbSize.SelectedIndex = 2;
            cmbFont.Text = "Times New Roman";
            cmbColor.Text = "Black";
            cmbBackColor.Text = "White";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

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
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.Font = new Font(cmbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(cmbFont.SelectedItem.ToString(), richTextBox1.Font.Size);

            }

        }


        OpenFileDialog ofd = new OpenFileDialog();

        private void OpenTool_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Rich Text Box(*.rtf)|*.rtf";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
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
            if (sfd.ShowDialog() == DialogResult.OK)
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
            if (!richTextBox1.Modified)
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

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(cmbColor.Text);
        }

        private void cmbBackColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.FromName(cmbBackColor.Text);
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (richTextBox1.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    //contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    //contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

               
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }
        public void bgColor(string color)
        {
            richTextBox1.SelectionBackColor = Color.FromName(cmbBackColor.Text);
        }
        public string getColor()
        {
            return richTextBox1.BackColor.Name;
        }
        Editor edit;
        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (edit == null || !edit.IsHandleCreated)
            {
                edit = new Editor();
                edit.MdiParent = this;
                edit.BringToFront();
                richTextBox1.SendToBack();
                edit.Show();
            }
            else
            {
                edit.Show();
            }
         
        }
        public void shw()
        {
            richTextBox1.BringToFront();
        }

    }
}
