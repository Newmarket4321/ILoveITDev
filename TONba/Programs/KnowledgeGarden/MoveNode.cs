using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace I_IT
{
    public partial class MoveNode : Form
    {
        public int value;

        public int getValue()
        {
            return value;
        }

        public MoveNode(string name)
        {
            InitializeComponent();
            textBox1.Focus();

            label1.Text = "\"" + name + "\" will become a child node of... (Node ID)";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out value))
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdvancedSearch adv = new AdvancedSearch();
            adv.ShowDialog();

            textBox1.Text = adv.getValue().ToString();
        }
    }
}
