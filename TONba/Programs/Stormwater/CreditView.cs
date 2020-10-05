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
    public partial class CreditView : Form
    {
        public double lowRunoff = 0;
        public double mediumRunoff = 0;
        public double highRunoff = 0;

        public CreditView()
        {
            InitializeComponent();

            refresh();
        }

        public void refresh()
        {
            resultsList.Items.Clear();

            DataTable dt = Vailtech.Run(@"
select
sc.roll_no as ""Roll Number"",
v.street_no as ""Street Number"",
v.street_name as ""Street Name"",
sc.low_area as ""Low Area"",
sc.med_area as ""Medium Area"",
sc.pollution_prevention as ""Pollution Prevention"",
sc.expiry as ""Expiry""

from StormwaterCredits sc
left join tx_roll v on sc.roll_no = v.roll_no
order by v.street_name, v.street_no");

            resultsList.Columns.Clear();

            for (int i = 0; i < dt.Columns.Count; i++)
                resultsList.Columns.Add(dt.Columns[i].ColumnName);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] data = new string[dt.Columns.Count];

                for (int j = 0; j < dt.Columns.Count; j++)
                    data[j] = dt.Rows[i][j].ToString();

                ListViewItem x = new ListViewItem(data);
                x.Tag = dt.Rows[i]["Roll Number"].ToString();
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
                        Vailtech sql = new Vailtech("delete from stormwatercredits where roll_no = @rollno");
                        sql.AddParameter("@rollno", resultsList.SelectedItems[0].Tag.ToString());
                        sql.Run();
                    }

                    refresh();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditAdd ap = new CreditAdd();
            ap.lowRunoff = lowRunoff;
            ap.mediumRunoff = mediumRunoff;
            ap.highRunoff = highRunoff;

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
            if (resultsList.SelectedItems.Count > 0)
            {
                CreditAdd ap = new CreditAdd(resultsList.SelectedItems[0].Text);
                ap.lowRunoff = lowRunoff;
                ap.mediumRunoff = mediumRunoff;
                ap.highRunoff = highRunoff;

                ap.ShowDialog();

                refresh();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void resultsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toolStripMenuItem1_Click(null, null);
        }
    }
}
