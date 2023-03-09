using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class F_NotePad_1 : Form
    {
        string filePath = "";
        public F_NotePad_1()
        {
            InitializeComponent();
            fontDialog1.ShowColor = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument (*.txt)|* .txt|WordDocument|* .docx|PDFDocument|* .pdf", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string data = sr.ReadToEnd();
                        richTextBox1.Text = data;
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument (*.txt)|* .txt|WordDocument|* .docx|PDFDocument|* .pdf", ValidateNames = true})
               
                {
                    if(sfd.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(richTextBox1.Text);
                        }
                    }
                }
            }
            else
            {
                using(StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(richTextBox1.Text);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument (*.txt)|* .txt|WordDocument|* .docx|PDFDocument|* .pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLineAsync(richTextBox1.Text);
                    }
                }
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 10);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0 )
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }

            int col = richTextBox1.Text.Length;
            
            for(int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                if (richTextBox1.Lines[i] == "")
                {
                    if(col > 0)
                    {
                        col--;
                    }
                }
            }
            l_ln_1.Text = "Ln " + Convert.ToString(richTextBox1.Lines.Length); 
            l_col_1.Text = "Col " + Convert.ToString(col);
            
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wordwrapToolStripMenuItem.Checked == true)
            {
                wordwrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else
            {
                wordwrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void backcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }


        float zoom = 1;

        private void l_s_1_Click(object sender, EventArgs e)
        {
            if (zoom <= 2)
            {
                zoom += 0.1f;
                richTextBox1.ZoomFactor = zoom;
                l_zoom_1.Text = Convert.ToString(Convert.ToInt32(zoom * 100)) + " %";
            }
        }

        private void l_m_1_Click(object sender, EventArgs e)
        {
            if(zoom >= 0.1)
            {
                zoom -= 0.1f;
                richTextBox1.ZoomFactor = zoom;
                l_zoom_1.Text = Convert.ToString(Convert.ToInt32(zoom * 100)) + " %";
            }
            
        }

        private void l_s_1_MouseHover(object sender, EventArgs e)
        {
            l_s_1.BackColor = Color.Silver;
        }

        private void l_s_1_MouseLeave(object sender, EventArgs e)
        {
            l_s_1.BackColor = Color.Gainsboro;
        }

        private void l_m_1_MouseHover(object sender, EventArgs e)
        {
            l_m_1.BackColor = Color.Silver;
        }

        private void l_m_1_MouseLeave(object sender, EventArgs e)
        {
            l_m_1.BackColor = Color.Gainsboro;
        }

        private void newwindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NotePad_1 f_NotePad_1 = new F_NotePad_1();
            f_NotePad_1.Show();
        }

        private void lineInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lineInformationToolStripMenuItem.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }
    }
}
