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
    public partial class ListOptions : Form
    {
        int questionID;

        public ListOptions(int id)
        {
            InitializeComponent();

            questionID = id;

            Text = SQL.RunString("use forms; select text from questions where id=@QID", questionID) + " - Multiple choice options";

            list.Columns.Add("Order");
            list.Columns.Add("Text");

            refresh();
        }

        public void refresh()
        {
            int cursor = -1;

            if (list.SelectedItems.Count > 0)
                cursor = int.Parse(list.SelectedItems[0].Tag.ToString());

            list.Items.Clear();

            DataTable dt = SQL.Run("use forms; select * from listoptions where questionid = @ID order by orderno", questionID);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string[] data = { dt.Rows[i]["OrderNo"].ToString(), dt.Rows[i]["Text"].ToString() };
                
                ListViewItem li = new ListViewItem(data);
                li.Tag = dt.Rows[i]["ID"].ToString();

                list.Items.Add(li);
            }

            for (int i = 0; i < list.Columns.Count; i++)
                list.Columns[i].Width = -2;

            if(cursor != -1)
            {
                for (int i = 0; i < list.Items.Count; i++)
                    if (int.Parse(list.Items[i].Tag.ToString()) == cursor)
                        list.Items[i].Selected = true;
            }
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            int orderNo;

            if (list.Items.Count > 0)
            {
                if (list.SelectedItems.Count > 0)
                {
                    orderNo = int.Parse(list.SelectedItems[0].Text) + 1;

                    //Move other options down to make room for this one
                    SQL.Run("use forms; update listoptions set orderno = orderno+1 where questionid=@QID and orderno >= @ONO", questionID, orderNo);
                }
                else
                    orderNo = int.Parse(list.Items[list.Items.Count - 1].Text) + 1;
            }
            else
                orderNo = 1;

            //Enter form into table
            SQL.Run("use forms; insert into listoptions values (@QID, @ONO, @TEXT)", questionID, orderNo, "");
            Core.log("Forms", "New List Option", "QID " + questionID);

            refresh();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                if (list.SelectedItems[0].Index <= 0)
                    return;
                
                int id = int.Parse(list.SelectedItems[0].Tag.ToString());
                int swapID = int.Parse(list.Items[list.SelectedItems[0].Index - 1].Tag.ToString());

                //Move up
                SQL.Run("use forms; update listoptions set orderno = orderno-1 where id=@ID", id);
                SQL.Run("use forms; update listoptions set orderno = orderno+1 where id=@ID", swapID);

                refresh();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                if (list.SelectedItems[0].Index >= list.Items.Count - 1)
                    return;

                int id = int.Parse(list.SelectedItems[0].Tag.ToString());
                int swapID = int.Parse(list.Items[list.SelectedItems[0].Index + 1].Tag.ToString());

                SQL.Run("use forms; update listoptions set orderno = orderno+1 where id=@ID", id);
                SQL.Run("use forms; update listoptions set orderno = orderno-1 where id=@ID", swapID);

                refresh();
            }
        }
        
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int id = int.Parse(list.SelectedItems[0].Tag.ToString());

                if (MessageBox.Show("Are you sure you would like to delete this option?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.Run("use forms; delete from listoptions where id = @QID", id);
                    
                    Core.log("Forms", "Delete List Option", "QID " + questionID);

                    refresh();
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int id = int.Parse(list.SelectedItems[0].Tag.ToString());

                bool success;
                string newText = Core.getString("New text", out success);

                if (!success)
                    return;

                SQL.Run("use forms; update listoptions set text = @TEXT where id = @ID", newText, id);
                Core.log("Forms", "Change List Option Text", "LO ID - " + id + " to " + newText);

                refresh();
            }
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toolStripMenuItem3_Click(null, null);
        }

        private void list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
