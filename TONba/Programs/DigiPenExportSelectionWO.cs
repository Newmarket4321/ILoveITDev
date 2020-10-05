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
    public partial class DigiPenExportSelectionWO : Form
    {
        public string[] workorders = null;

        public DigiPenExportSelectionWO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Any(x => char.IsLetter(x) || char.IsSymbol(x)))
            {
                MessageBox.Show("Letters or symbols found." + Environment.NewLine + "Please enter work order numbers only, one per line, with no punctuation.");
            }
            else
            {
                if (textBox1.Text.Trim() != "")
                    workorders = textBox1.Text.Trim().Split('\n');

                Close();
            }
        }
    }
}
