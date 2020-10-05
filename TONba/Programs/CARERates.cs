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
    public partial class CARERates : Form
    {
        public CARERates()
        {
            InitializeComponent();

            Core.fillListView(listView1, SQL.Run("use CARE; select * from rates order by familysize, incomemin"));
            textBox1.Text = SQL.RunString("use CARE; select value from systemvariables where variablename = 'PricePerPop'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool success;
            int numPeople = Core.getInt("Number of people", 1, 999, 1, out success);

            if (!success)
                return;

            int minIncome = Core.getInt("Minimum income", 0, 9999999, 0, out success);

            if (!success)
                return;

            int percDiscount = Core.getInt("Percentage discount", 0, 100, 0, out success);

            if (!success)
                return;

            SQL.Run("use CARE; insert into rates values (@FAMILY, @MININCOME, @PERCDISC)", numPeople, minIncome, percDiscount);
            Core.fillListView(listView1, SQL.Run("use CARE; select * from rates order by familysize, incomemin"));

            MessageBox.Show("New entry saved!");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            bool success;
            int numPeople = Core.getInt("Number of people", 1, 999, 1, out success);

            if (!success)
                return;

            int minIncome = Core.getInt("Minimum income", 0, 9999999, 0, out success);

            if (!success)
                return;

            int percDiscount = Core.getInt("Percentage discount", 0, 100, 0, out success);

            if (!success)
                return;

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            SQL.Run("use CARE; update rates set familysize = @FAMILY, minincome = @MININCOME, discountperc = @PERCDISC where id = @ID", numPeople, minIncome, percDiscount, id);
            Core.fillListView(listView1, SQL.Run("use CARE; select * from rates order by familysize, incomemin"));

            MessageBox.Show("Entry updated!");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            SQL.Run("use CARE; delete from rates where id = @ID", id);
            Core.fillListView(listView1, SQL.Run("use CARE; select * from rates order by familysize, incomemin"));

            MessageBox.Show("Entry deleted!");
        }
    }
}
