using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class VacancyAdd : Form
    {
        public VacancyAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vailtech sql = new Vailtech("insert into stormwatervacant values (@rollno, @parkinglot)");
            sql.AddParameter("@rollno", textBox1.Text);
            sql.AddParameter("@parkinglot", checkBox1.Checked ? "Y" : "");
            sql.Run();

            Close();
        }

        private void AddPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }
    }
}
