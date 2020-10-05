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
    public partial class ViewAccounts : Form
    {
        const int VIEWMODE = 0;
        const int SELECTMODE = 1;
        int mode = VIEWMODE;
        public string selection = "";

        public ViewAccounts()
        {
            InitializeComponent();

            for (int i = 0; i < listView1.Columns.Count; i++)
                listView1.Columns[i].Name = listView1.Columns[i].Text;

            refresh();
        }

        public ViewAccounts(bool selectMode)
        {
            InitializeComponent();

            for (int i = 0; i < listView1.Columns.Count; i++)
                listView1.Columns[i].Name = listView1.Columns[i].Text;

            if (selectMode)
            {
                mode = SELECTMODE;
                button7.Visible = false;
                button8.Visible = false;
                //button1.BackColor = Color.FromArgb(164, 209, 255);
                button9.Text = "Select";
                this.Text = "Select Account";
            }
        }

        public int refresh()
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL(
@"SELECT
u.userid as ID, u.displayname as Username, u.approver, u.employeeid as EmpID, u.active as Active
FROM users u
order by u.displayname
");
            DataTable dt = sql.Run();

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ID = dt.Rows[i]["ID"].ToString();
                string username = dt.Rows[i]["Username"].ToString();
                string employeeID = dt.Rows[i]["EmpID"].ToString();
                bool manager = bool.Parse(dt.Rows[i]["approver"].ToString());
                bool active = bool.Parse(dt.Rows[i]["active"].ToString());
                string role;
                Color roleColor;

                if (!active)
                {
                    role = "Inactive";
                    roleColor = Color.Red;
                }
                else if (manager)
                {
                    role = "Approver";
                    roleColor = Color.Purple;
                }
                else
                {
                    role = "User";
                    roleColor = Color.Green;
                }

                ListViewItem x = new ListViewItem(new[] { username, role, employeeID });
                x.Tag = ID;
                x.SubItems[listView1.Columns["Role"].Index].ForeColor = roleColor;
                x.UseItemStyleForSubItems = false;

                listView1.Items.Add(x);
            }

            for (int i = 0; i < listView1.Columns.Count; i++)
                listView1.Columns[i].Width = -2;

            return dt.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == VIEWMODE)
            {
                (new NewAccount()).ShowDialog();
                refresh();
            }
            else if (mode == SELECTMODE)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    selection = listView1.SelectedItems[0].SubItems[listView1.Columns.IndexOfKey("Account")].Text;
                    this.Close();
                }
                else
                    MessageBox.Show("No user selected.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete " + listView1.SelectedItems[0].SubItems[listView1.Columns.IndexOfKey("Account")].Text + "'s account?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DATSEngineeringSQL sql = new DATSEngineeringSQL("delete from users where USERID=@USERID");
                    sql.AddParameter("@USERID", listView1.SelectedItems[0].Tag.ToString());
                    sql.Run();

                    SQL sql2 = new SQL("delete from permissions where username=@username and program=@program");
                    sql2.AddParameter("@username", listView1.SelectedItems[0].Text);
                    sql2.AddParameter("@program", "DATSEngineering");
                    sql2.Run();

                    refresh();
                }
            }
            else
                MessageBox.Show("No user selected.");
        }

        private void ViewAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Delete)
                button5_Click(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                (new NewAccount(listView1.SelectedItems[0].SubItems[listView1.Columns.IndexOfKey("Account")].Text)).ShowDialog();
                refresh();
            }
            else
                MessageBox.Show("No user selected.");
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mode == VIEWMODE)
                button6_Click(null, null);
            else if (mode == SELECTMODE)
                button1_Click(null, null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
