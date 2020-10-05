using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace I_IT
{
    public partial class AdvancedSearch : Form
    {
        public int value;

        public int getValue()
        {
            return value;
        }

        public AdvancedSearch()
        {
            InitializeComponent();
            searchBox.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                searchBox.Enabled = false;
                searchBox.Update();
                
                searchButton.Enabled = false;
                searchButton.Update();

                string[] words = searchBox.Text.Trim().Split(' ');
                
                string strSql = "use knowledgegarden; select n.id, n.[description], n.[message] from nodes n, cache c where n.id = c.nodeid and n.deleted='false' and c.keyword = @QUERY"; // or [description] like @QUERY";

                for (int i = 1; i < words.Length; i++)
                    strSql += " and n.id in (select nodeid from cache where keyword = @PARA" + i.ToString() + ")";

                SQL sql = new SQL(strSql);
                sql.AddParameter("@QUERY", words[0]);

                for (int i = 1; i < words.Length; i++)
                    sql.AddParameter("@PARA" + i.ToString(), words[i]);

                DataTable dt = sql.Run();
                
                listView1.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RichTextBox r = new RichTextBox();
                    r.Rtf = dt.Rows[i][2].ToString();

                    listView1.Items.Add(new ListViewItem(new string[] { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), r.Text }));
                }

                listView1.Columns[2].Width = 500;

                searchBox.Enabled = true;
                searchBox.Update();

                searchButton.Enabled = true;
                searchButton.Update();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            value = int.Parse(listView1.SelectedItems[0].Text);
            this.Close();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                searchButton_Click(null, null);
            searchBox.Select();
        }

        private void AdvancedSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
