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
    public partial class LookupDropdown : Form
    {
        public string r = "";

        public LookupDropdown(string text, DataTable dt)
        {
            InitializeComponent();

            label1.Text = text;

            for (int i = 0; i < dt.Rows.Count; i++)
                comboBox1.Items.Add(dt.Rows[i][0].ToString());

            if(comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        public LookupDropdown(string text, string[] items)
        {
            InitializeComponent();

            label1.Text = text;

            for (int i = 0; i < items.Length; i++)
                comboBox1.Items.Add(items[i]);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        public LookupDropdown(string text, List<string> items)
        {
            InitializeComponent();

            label1.Text = text;

            for (int i = 0; i < items.Count; i++)
                comboBox1.Items.Add(items[i]);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        public LookupDropdown(string text, DataColumnCollection columns)
        {
            InitializeComponent();

            label1.Text = text;

            for (int i = 0; i < columns.Count; i++)
                comboBox1.Items.Add(columns[i].ColumnName);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains(" - "))
                r = comboBox1.Text.Split(' ')[0];
            else
                r = comboBox1.Text;

            Close();
        }

        private void LookupDropdown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button8_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
