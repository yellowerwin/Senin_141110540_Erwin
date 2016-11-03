using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

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
            setcbFontSize();
            setcbFont();
            setcbColor();
            setcbBgColor();
            cbColor.SelectedItem = cbColor.Items[8];
            cbBgColor.SelectedItem = cbColor.Items[137];
            cbFontSize.SelectedItem = cbFontSize.Items[4];
            cbFont.SelectedItem = cbFont.Items[320];
            richTextBox.Focus();

            perubahan_text = false;
        }

        public Color form1_RichTextBox
        {
            get { return this.richTextBox.BackColor; }
            set { this.richTextBox.BackColor = value; }
        }

        private void setcbFontSize()
        {
            int[] size = new int[16] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            for (int i = 0; i < 16; i++)
                cbFontSize.Items.Add(size[i]);
        }

        private void setcbFont()
        {
            cbFont.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFont.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (FontFamily font in FontFamily.Families)
            {
                cbFont.Items.Add(font.Name.ToString());
            }
        }

        

        private void setcbBgColor()
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbBgColor.Items.Add(c.Name);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Bold);
            richTextBox.Focus();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Italic);
            richTextBox.Focus();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style ^ FontStyle.Underline);
            richTextBox.Focus();
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size;
            try
            {

                size = Int32.Parse(cbFontSize.Text);
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, size);

                richTextBox.Focus();
            }
            catch
            {
                richTextBox.Focus();
            }
        }

        public void used_font_size()
        {

            try
            {
                string used_fontsize = richTextBox.SelectionFont.SizeInPoints.ToString();
                cbFontSize.Text = used_fontsize;

            }
            catch
            {
                cbFontSize.Text = "";
            }
        }

        private void style(FontStyle style, Button button)
        {
            if (richTextBox.SelectionFont.Style == style)
            {
                button.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                button.FlatStyle = FlatStyle.Standard;
            }
        }

        private void used_style()
        {
            style(FontStyle.Bold, btnBold);
            style(FontStyle.Italic, btnItalic);
            style(FontStyle.Underline, btnUnderline);
        }

        public void used_font()
        {
            try
            {
                string used_font = richTextBox.SelectionFont.FontFamily.Name.ToString();
                int index = cbFont.Items.IndexOf(used_font);
                cbFont.SelectedItem = cbFont.Items[index];
            }
            catch
            {
                cbFont.Text = "";
            }

        }

        public void used_color()
        {
            int end = cbColor.Items.Count;
            string[] warna = new string[end];
            string used_color = richTextBox.SelectionColor.Name;

            for (int i = 0; i < end; i++)
            {
                warna[i] = cbColor.Items[i].ToString();

                if (warna[i] == used_color)
                {
                    cbColor.SelectedItem = cbColor.Items[i];
                    break;
                }
            }

        }

        public void used_Bg_color()
        {
            int end = cbBgColor.Items.Count;
            string[] warna = new string[end];
            string used_color = richTextBox.SelectionBackColor.Name;

            for (int i = 0; i < end; i++)
            {
                warna[i] = cbBgColor.Items[i].ToString();

                if (warna[i] == used_color)
                {
                    cbBgColor.SelectedItem = cbBgColor.Items[i];
                    break;
                }
            }
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = this.cbFont.SelectedItem.ToString();

            richTextBox.SelectionFont = new Font(font, richTextBox.SelectionFont.SizeInPoints);
            richTextBox.Focus();
        }

        private bool perubahan_text;

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            used_font();
            perubahan_text = true;
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = this.cbColor.SelectedItem.ToString();
            richTextBox.SelectionColor = Color.FromName(color);
            richTextBox.Focus();
        }

        private void setcbColor()
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbColor.Items.Add(c.Name);
            }
        }

        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void cbBgColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = this.cbBgColor.SelectedItem.ToString();
            richTextBox.SelectionBackColor = Color.FromName(color);
            richTextBox.Focus();
        }

        private void richTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            used_font();
            used_color();
            used_font_size();
            used_style();
            used_Bg_color();
        }

        private void richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            used_font();
            used_color();
            used_font_size();
            used_style();
            used_Bg_color();
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            used_font();
            used_color();
            used_font_size();
            used_style();
            used_Bg_color();
        }

        private void richTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            used_font();
            used_color();
            used_font_size();
            used_style();
            used_Bg_color();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perubahan_text)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        richTextBox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
            }
            else
            {
                ActiveForm.Hide();
                Form1 newform = new Form1();
                newform.ShowDialog();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                richTextBox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perubahan_text)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        richTextBox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (result == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void cbColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string color = this.cbColor.SelectedItem.ToString();
            richTextBox.SelectionColor = Color.FromName(color);
            richTextBox.Focus();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 setting = new Form2(this);
            setting.Show();
            
        }

        public Color textboxparent { get; set; }
    }
}
