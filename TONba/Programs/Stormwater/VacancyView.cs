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
    public partial class VacancyView : Form
    {
        public VacancyView()
        {
            InitializeComponent();

            refresh();
        }

        public void refresh()
        {
            resultsList.Items.Clear();

            DataTable dt = SQL.Run(@"
use stormwater;
select ROLL_NO, STREET_NO, STREET_NAME, CLASS_NAME
from runoffmap
where class_name = 'Excess and vacant' or class_name = 'Parking lot (Override)'");

            resultsList.Columns.Clear();

            for (int i = 0; i < dt.Columns.Count; i++)
                resultsList.Columns.Add(dt.Columns[i].ColumnName);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] data = new string[dt.Columns.Count];

                for (int j = 0; j < dt.Columns.Count; j++)
                    data[j] = dt.Rows[i][j].ToString();

                ListViewItem x = new ListViewItem(data);
                x.Tag = dt.Rows[i]["ROLL_NO"].ToString();
                resultsList.Items.Add(x);
            }

            for (int i = 0; i < resultsList.Columns.Count; i++)
                resultsList.Columns[i].Width = -2;

            resultsList.Focus();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count == 0)
                MessageBox.Show("Please select an item.");
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete these items?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = resultsList.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        Vailtech sql = new Vailtech("delete from stormwatervacant where roll_no = @rollno");
                        sql.AddParameter("@rollno", resultsList.SelectedItems[0].Tag.ToString());
                        sql.Run();
                    }

                    refresh();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacancyAdd ap = new VacancyAdd();
            ap.ShowDialog();

            refresh();
        }

        private void Permissions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void resultsList_MouseClick(object sender, MouseEventArgs e)
        {
            SQL sql = new SQL(@"
use stormwater;
update runoffmap set class_name = 'Temp' where class_name = 'Excess and vacant' and roll_no = @ROLLNO;
update runoffmap set class_name = 'Excess and vacant', runoff_code = 1 where class_name = 'Parking lot (Override)' and roll_no = @ROLLNO;
update runoffmap set class_name = 'Parking lot (Override)', runoff_code = 3 where class_name = 'Temp' and roll_no = @ROLLNO;
");
            sql.AddParameter("@ROLLNO", resultsList.SelectedItems[0].Tag.ToString());
            sql.Run();

            sql = new SQL(@"
use stormwater;
select CLASS_NAME
from runoffmap
where roll_no = @ROLLNO");
            sql.AddParameter("@ROLLNO", resultsList.SelectedItems[0].Tag.ToString());
            DataTable dt = sql.Run();

            resultsList.SelectedItems[0].SubItems[3].Text = dt.Rows[0][0].ToString();

            for (int i = 0; i < resultsList.Columns.Count; i++)
                resultsList.Columns[i].Width = -2;
        }

        private void resultsList_MouseClick_1(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(resultsList.SelectedItems[0].Tag.ToString());
        }
    }
}
