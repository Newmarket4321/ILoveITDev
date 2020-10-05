using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class GetString : Form
    {
        public string r = "";
        public bool quit = true;

        public GetString(string text)
        {
            InitializeComponent();

            label1.Text = text;
        }

        public GetString(string text, bool multiline)
        {
            InitializeComponent();

            if (multiline)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                textBox1.Multiline = true;
                textBox1.AcceptsReturn = true;
                Height = 400;
            }

            label1.Text = text;
        }

        public GetString(string text, string defaultText)
        {
            InitializeComponent();

            label1.Text = text;
            textBox1.Text = defaultText;
        }

        public GetString(string text, string defaultText, bool multiline)
        {
            InitializeComponent();

            if (multiline)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                textBox1.Multiline = true;
                textBox1.AcceptsReturn = true;
                Height = 400;
                //Width = 482;
            }

            label1.Text = text;
            textBox1.Text = defaultText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            r = textBox1.Text;
            quit = false;
            
            Close();
        }

        private void LookupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
                textBox1.SelectAll();
            else if (e.KeyCode == Keys.Enter && textBox1.Multiline == false)
                button8_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
