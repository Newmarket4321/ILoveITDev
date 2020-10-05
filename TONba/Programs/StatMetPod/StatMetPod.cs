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
    public partial class StatMetPod : Form
    {
        public StatMetPod()
        {
            InitializeComponent();
        }

        private void StatMetPod_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            DataTable dt = SQL.Run(@"
use statmetpod;

select t.ID, t.Date, t.Topic, count(s.topicid) as Count

from topics t
left join subscriptions s on t.id = s.topicid

group by t.ID, t.date, t.topic
order by date, topic");

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem li = new ListViewItem(new string[] { DateTime.Parse(dt.Rows[i]["Date"].ToString()).ToString("MMMM dd, yyyy"), dt.Rows[i]["Topic"].ToString(), dt.Rows[i]["Count"].ToString() });
                li.Tag = dt.Rows[i]["ID"].ToString();
                li.Name = dt.Rows[i]["Topic"].ToString();

                listView1.Items.Add(li);
            }

            for (int i = 0; i < listView1.Columns.Count; i++)
                listView1.Columns[i].Width = -2;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetString box = new GetString("New topic name");
            box.ShowDialog();

            if (box.r != "")
            {
                GetDate date = new GetDate("New topic date");
                date.ShowDialog();

                if (date.r != null)
                {
                    SQL sql = new SQL(@"use statmetpod; insert into topics values (@DATE, @TOPIC)");
                    sql.AddParameter("@DATE", date.r);
                    sql.AddParameter("@TOPIC", box.r);
                    sql.Run();

                    int id = int.Parse(SQL.RunString("use statmetpod; select max(id) from topics"));

                    ChooseFields cf = new ChooseFields(id);
                    cf.ShowDialog();

                    StatMetPod_Load(null, null);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string response = Core.lookupMessageBox("Are you sure?", "Delete topic \"" + listView1.SelectedItems[0].Name + "\" and all its subscriptions?", "Yes", "No");
                
                if (response == "Yes")
                {
                    SQL sql = new SQL("use statmetpod; delete from subscriptions where topicid = @ID");
                    sql.AddParameter("@ID", listView1.SelectedItems[0].Tag.ToString());
                    sql.Run();

                    sql = new SQL("use statmetpod; delete from topics where id = @ID");
                    sql.AddParameter("@ID", listView1.SelectedItems[0].Tag.ToString());
                    sql.Run();

                    StatMetPod_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Please select a topic.");
            }
        }

        private void seeSubscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Subscriptions sub = new Subscriptions(int.Parse(listView1.SelectedItems[0].Tag.ToString()));
                sub.ShowDialog();

                refresh();
            }
            else
            {
                MessageBox.Show("Please select a topic.");
            }

        }

        private void changeTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                GetString box = new GetString("New topic name");
                box.ShowDialog();

                if(box.r != "")
                {
                    SQL sql = new SQL(@"
use statmetpod;

update topics set topic = @TOPIC where id = @ID
");
                    sql.AddParameter("@TOPIC", box.r);
                    sql.AddParameter("@ID", listView1.SelectedItems[0].Tag.ToString());
                    sql.Run();

                    StatMetPod_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Please select a topic.");
            }
        }

        private void changeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                bool success;
                DateTime date = Core.getDate("Select new date", out success);
                int id = int.Parse(listView1.SelectedItems[0].Tag.ToString());

                if (success)
                {
                    SQL.Run(@"use statmetpod; update topics set date = @DATE where id = @ID", date, id);
                    
                    StatMetPod_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Please select a topic.");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            seeSubscribersToolStripMenuItem_Click(null, null);
        }

        private void chooseFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Tag.ToString());

                ChooseFields cf = new ChooseFields(id);
                cf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a topic.");
            }
        }
    }
}
