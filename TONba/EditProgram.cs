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
    public partial class EditProgram : Form
    {
        ImageList store = null;

        public EditProgram(string program, ImageList icons)
        {
            InitializeComponent();

            Text += " - " + program;
            Tag = program;
            store = icons;
            textBox2.Text = program;
            pictureBox1.Image = store.Images["Services.png"];

            refresh();
        }

        private void refresh()
        {
            SQL sql = new SQL("select * from programs where code = @CODE");
            sql.AddParameter("@CODE", Tag);
            DataTable dt = sql.Run();

            if (dt.Rows.Count > 0)
            {
                textBox2.Text = dt.Rows[0]["description"].ToString();
                comboBox1.Text = dt.Rows[0]["category"].ToString();
                pictureBox1.Image = store.Images[dt.Rows[0]["icon"].ToString()];
                pictureBox1.Tag = dt.Rows[0]["icon"].ToString();
                textBox4.Text = dt.Rows[0]["tooltip"].ToString();
            }

            dt = SQL.Run("select category from programs group by category order by category");

            comboBox1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
                comboBox1.Items.Add(dt.Rows[i][0].ToString());

            listView1.Items.Clear();

            dt = SQL.Run("select username from permissions where program = @code order by username", Tag);

            for (int i = 0; i < dt.Rows.Count; i++)
                listView1.Items.Add(dt.Rows[i]["username"].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Change to work on new programs
            SQL sql = new SQL("select * from programs where code = @CODE");
            sql.AddParameter("@CODE", Tag);
            DataTable dt = sql.Run();

            if (dt.Rows.Count > 0)
            {
                sql = new SQL("update programs set description = @DESCRIPTION, category = @CATEGORY, icon = @ICON, tooltip = @TOOLTIP where code = @CODE");
                sql.AddParameter("@CODE", Tag);
                sql.AddParameter("@DESCRIPTION", textBox2.Text);
                sql.AddParameter("@CATEGORY", comboBox1.Text);
                sql.AddParameter("@ICON", pictureBox1.Tag.ToString());
                sql.AddParameter("@TOOLTIP", textBox4.Text);
                sql.Run();
            }
            else
            {
                sql = new SQL("insert into programs (code, description, icon, category, tooltip, hidden) values (@CODE, @DESCRIPTION, @ICON, @CATEGORY, @TOOLTIP, @HIDDEN)");
                sql.AddParameter("@CODE", Tag);
                sql.AddParameter("@DESCRIPTION", textBox2.Text);
                sql.AddParameter("@ICON", pictureBox1.Tag != null ? pictureBox1.Tag.ToString() : "");
                sql.AddParameter("@CATEGORY", comboBox1.Text);
                sql.AddParameter("@TOOLTIP", textBox4.Text);
                sql.AddParameter("@HIDDEN", false);
                sql.Run();
            }
            
            Close();
        }

        private void AddPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            LookupIcon si = new LookupIcon(store, "");
            si.ShowDialog();

            if (si.r != "")
            {
                pictureBox1.Image = store.Images[si.r];
                pictureBox1.Tag = si.r;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hide this program?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQL sql = new SQL("select * from programs where code = @CODE");
                sql.AddParameter("@CODE", Tag);
                DataTable dt = sql.Run();

                if (dt.Rows.Count > 0)
                {
                    sql = new SQL("update programs set hidden = 'True' where code = @CODE");
                    sql.AddParameter("@CODE", Tag);
                    sql.Run();
                }
                else
                {
                    sql = new SQL("insert into programs (code, description, icon, category, tooltip, hidden) values (@CODE, @DESCRIPTION, @ICON, @CATEGORY, @TOOLTIP, @HIDDEN)");
                    sql.AddParameter("@CODE", Tag);
                    sql.AddParameter("@DESCRIPTION", "");
                    sql.AddParameter("@ICON", "");
                    sql.AddParameter("@CATEGORY", "");
                    sql.AddParameter("@TOOLTIP", "");
                    sql.AddParameter("@HIDDEN", true);
                    sql.Run();
                }

                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetString box = new GetString("Windows username");
            box.ShowDialog();

            if (box.r == "")
                return;

            SQL.Run("insert into permissions values (@username, @program)", box.r, Tag);
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SQL.Run("delete from permissions where username = @username and program = @program", listView1.SelectedItems[0].Text, Tag);
                refresh();

                listView1.Focus();
            }
            else
                MessageBox.Show("Please select a user.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string program = Core.lookupDropdown("Select program", SQL.Run("select code from programs where hidden = 0"));

            if(program == "")
                return;

            SQL.Run(@"
insert into permissions
    select username, @TARGETPROGRAM
    from permissions
    where program = @SOURCEPROGRAM
    and username not in (select username from permissions where program = @TARGETPROGRAM2)", Tag.ToString(), program, Tag.ToString());

            refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string program = Core.lookupDropdown("Select program", SQL.Run("select code from programs where hidden = 0"));

            if (program == "")
                return;

            int before = int.Parse(SQL.RunString("select count(*) from permissions where program = @TARGETPROGRAM", program));

            SQL.Run(@"
insert into permissions
    select username, @TARGETPROGRAM
    from permissions
    where program = @SOURCEPROGRAM
    and username not in (select username from permissions where program = @TARGETPROGRAM2)", program, Tag.ToString(), program);

            int after = int.Parse(SQL.RunString("select count(*) from permissions where program = @TARGETPROGRAM", program));

            if (after > before)
                MessageBox.Show((after - before) + " permissions copied to " + program + ".");
            else
                MessageBox.Show(program + " already has those permissions.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Delete all permissions on every program for " + listView1.SelectedItems[0].Text + "?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.Run("delete from permissions where username = @username", listView1.SelectedItems[0].Text);
                    refresh();

                    listView1.Focus();
                }
            }
            else
                MessageBox.Show("Please select a user.");
        }
    }
}
