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
    public partial class LookupEmployee : Form
    {
        public string empNo = null;
        public string empDesc = null;
        public bool quit = true;

        public LookupEmployee()
        {
            InitializeComponent();
            
            textBox3.Select();

            disableContinue();
        }

        public void disableContinue()
        {
            button1.BackColor = Color.DarkGray;
            button1.Text = "Please select an employee";
            button1.Enabled = false;
        }

        public void enableContinue()
        {
            button1.BackColor = Color.FromArgb(0, 108, 255);
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Core.isStrictlyAlphanumeric(textBox3.Text))
            {
                MessageBox.Show("Please search for name only, or employee number only");
                return;
            }

            //Emp Search
            DataTable dt = new DataTable();

            disableContinue();

            bool numbersOnly = Core.isNumeric(textBox3.Text);
            
            string queryString = "";

            if (textBox3.Text != "" && !numbersOnly)
                queryString = @"
select YAAN8, YAALPH
from CRPDTA.F060116
where upper(YAALPH) like '%' || :QUERY || '%'
and trim(YAPAST) <> 'T'
order by YAALPH";
            else if (textBox3.Text != "" && numbersOnly)
                queryString = @"
select YAAN8, YAALPH
from CRPDTA.F060116
where YAAN8 = :QUERY
and trim(YAPAST) <> 'T'
order by YAALPH";
            else
                queryString = @"
select YAAN8, YAALPH
from CRPDTA.F060116
where trim(YAPAST) <> 'T'
order by YAALPH";

            Oracle ora = new Oracle(queryString);
            ora.AddParameter("QUERY", textBox3.Text.ToUpper());
            dt = ora.Run();


            //            sql = new SQL(
            //@"
            //use inventorymanagement;

            //SELECT
            //empno,
            //Count(empno) AS CountOfEmpNo

            //FROM Log

            //WHERE date > @DATE

            //GROUP BY log.empno

            //ORDER BY Count(log.empno) DESC;

            //");
            //            sql.AddParameter("@DATE", DateTime.Now.AddDays(-60));
            DataTable dt2 = new DataTable(); //sql.Run();

            dt.Columns.Add("Count");

            DataTable dtSorted = dt.Clone();
            dtSorted.Columns["Count"].DataType = Type.GetType("System.Int32");

            foreach (DataRow dr in dt.Rows)
            {
                dtSorted.ImportRow(dr);
            }
            dtSorted.AcceptChanges();

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dtSorted.PrimaryKey = new DataColumn[] { dtSorted.Columns[0] };
                DataRow dr = dtSorted.Rows.Find(dt2.Rows[i][0].ToString());

                if (dr != null)
                    dr[2] = dt2.Rows[i][1].ToString();
            }

            DataView dv = dtSorted.DefaultView;
            dv.Sort = "count desc";
            dtSorted = dv.ToTable();

            listView1.Items.Clear();

            for (int i = 0; i < Math.Min(dtSorted.Rows.Count, 500); i++)
            {
                string empNo = dtSorted.Rows[i]["YAAN8"].ToString();
                string description = dtSorted.Rows[i]["YAALPH"].ToString().Trim();
                string count = dtSorted.Rows[i]["Count"].ToString(); //Custom column

                if (count != "" || textBox3.Text != "")
                {
                    ListViewItem x = new ListViewItem(new[] { empNo, description });
                    x.Tag = empNo;
                    listView1.Items.Add(x);
                }
            }

            if (listView1.Items.Count == 1)
            {
                listView1.SelectedIndices.Add(0);
                button1_Click_1(null, null);
            }

            for (int i = 0; i < listView1.Columns.Count; i++)
                listView1.Columns[i].Width = -2;

            if (numbersOnly && listView1.Items.Count == 0)
                MessageBox.Show("Employee number not found.");
        }

        private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1_Click_1(null, null);
        }

        private void FindWorkOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && ControlBox)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            //button1_Click(null, null);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //button1.Text = "I used #" + listView1.SelectedItems[0].Text;
                enableContinue();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                MessageBox.Show("You haven't selected an employee!", "Error");
            else
            {
                empNo = listView1.SelectedItems[0].Tag.ToString();
                empDesc = listView1.SelectedItems[0].SubItems[1].Text;
                quit = false;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            quit = false;
            this.Close();
        }

        private void FindWorkOrder_Load(object sender, EventArgs e)
        {
            textBox3.Select();
        }
    }
}
