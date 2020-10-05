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
    public partial class FindWorkOrder : Form
    {
        public string woID = null;
        public string woDesc = null;
        string forUser = DATSEngineeringCore.getUsername();
        public bool quit = true;

        public FindWorkOrder()
        {
            InitializeComponent();

            forUser = DATSEngineeringCore.getUsername();

            //button1_Click(null, null);

            textBox3.Select();

            disableContinue();
        }

        public void disableContinue()
        {
            button1.BackColor = Color.DarkGray;
            button1.Text = "Please select a work order";
            button1.Enabled = false;
        }

        public void enableContinue()
        {
            button1.BackColor = Color.FromArgb(0, 108, 255);
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WO Search
            DataTable dt = new DataTable();
            DATSEngineeringSQL sql;

            disableContinue();

            int temp;
            bool numbersOnly = int.TryParse(textBox3.Text, out temp);

            string queryString = "";

            if (textBox3.Text != "" && !numbersOnly)
                queryString = @"
select WADOCO, WADL01, WAVR01

from CRPDTA.F4801

where upper(WADL01) like '%' || :QUERY || '%'
and WASRST <> '99'

order by WADOCO";
            else if(textBox3.Text != "" && numbersOnly)
                queryString = @"
select WADOCO, WADL01, WAVR01

from CRPDTA.F4801

where WADOCO = :QUERY
and WASRST <> '99'

order by WADOCO";
            else
                queryString = @"
select WADOCO, WADL01, WAVR01

from CRPDTA.F4801

where WASRST <> '99'

order by WADOCO";

            Oracle ora = new Oracle(queryString);
            ora.AddParameter("QUERY", textBox3.Text.ToUpper());
            dt = ora.Run();


            sql = new DATSEngineeringSQL(
@"SELECT
TimeSheetDetail.WorkOrder as WOID,
Count(TimeSheetDetail.WorkOrder) AS CountOfWorkOrder

FROM TimeSheetDetail, Users

WHERE
TimeSheetDetail.DateWorked > @DATE AND
TimeSheetDetail.WorkOrder IS NOT NULL AND
Users.EmployeeID = TimeSheetDetail.EmployeeID AND
Users.displayname = @USERNAME

GROUP BY
TimeSheetDetail.WorkOrder

ORDER BY Count(TimeSheetDetail.WorkOrder) DESC;

");
            sql.AddParameter("@DATE", DateTime.Now.AddDays(-60));
            sql.AddParameter("@USERNAME", forUser);
            DataTable dt2 = sql.Run();

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
                string workorder = dtSorted.Rows[i]["WADOCO"].ToString();
                string description = dtSorted.Rows[i]["WADL01"].ToString().Trim();
                string count = dtSorted.Rows[i]["Count"].ToString(); //Custom column

                ora = new Oracle("select WAVR01 from CRPDTA.F4801 where WADOCO=@WORKORDER and WASRST <> '99'");
                ora.AddParameter("@WORKORDER", workorder);
                dt = ora.Run();

                if (dt.Rows.Count > 0)
                {
                    string asset = dt.Rows[0]["WAVR01"].ToString().Trim();

                    if (asset != "")
                        description += " (" + asset + ")";



                    if (count != "" || textBox3.Text != "")
                    {
                        ListViewItem x = new ListViewItem(new[] { workorder, description });
                        x.Tag = workorder;
                        listView1.Items.Add(x);
                    }
                }
            }

            if (listView1.Items.Count == 1)
                listView1.SelectedIndices.Add(0);

            for (int i = 0; i < listView1.Columns.Count; i++)
                listView1.Columns[i].Width = -2;
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
            if (e.KeyCode == Keys.Escape)
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
                button1.Text = "I used #" + listView1.SelectedItems[0].Text;
                enableContinue();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                MessageBox.Show("You haven't selected a work order!", "Error");
            else
            {
                woID = listView1.SelectedItems[0].Tag.ToString();
                woDesc = listView1.SelectedItems[0].SubItems[1].Text;
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
