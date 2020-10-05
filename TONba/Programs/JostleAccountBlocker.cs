using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace I_IT
{
    public partial class JostleAccountBlocker : Form
    {
        public JostleAccountBlocker()
        {
            InitializeComponent();

            listView1.Columns[0].Width = -2;

            //foreach(string word in words)
            //{
            //    SQL sql = new SQL("insert into jostle_donotcreateaccounts values (@WORD)");
            //    sql.AddParameter("@WORD", word);
            //    sql.Run();
            //}

            refresh();
        }

        private void refresh()
        {
            SQL sql = new SQL("select * from JostleAccountBlocker order by commonname");
            DataTable dt = sql.Run();

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
            }

            toolStripStatusLabel1.Text = listView1.Items.Count + " accounts in this list";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                SQL.Run("delete from JostleAccountBlocker where commonname = @CN", item.Text);
                
                listView1.Items.Remove(item);
            }

            toolStripStatusLabel1.Text = listView1.Items.Count + " accounts in this list";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetString ltb = new GetString("Account name");
            ltb.ShowDialog();

            if (ltb.r != "")
            {
                SQL sql = new SQL("insert into JostleAccountBlocker values (@CN)");
                sql.AddParameter("@CN", ltb.r);
                sql.Run();
            }

            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool success;
            string field = Core.getString("Search for what?", out success);

            if (!success)
                return;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text.ToLower().Contains(field.ToLower()))
                {
                    listView1.SelectedIndices.Clear();
                    listView1.SelectedIndices.Add(i);
                    listView1.Select();

                    listView1.EnsureVisible(i);

                    return;
                }
            }
        }

        private void JostleAccountBlocker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
                button3_Click(null, null);
        }
    }
}
