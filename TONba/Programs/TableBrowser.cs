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
    public partial class TableBrowser : Form
    {
        public TableBrowser()
        {
            InitializeComponent();

            //search();
        }

        private string dbType()
        {
            string text = resultsList.SelectedItems[0].SubItems[1].Text;

            if (text == "Vailtech")
                return "Vailtech";
            else if (text == "CityView")
                return "CityView";
            else if (text == "ESRI10PUB")
                return "ESRI10PUB";
            else
                return "JDE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultsList.Items.Clear();

            string filter = textBox3.Text.ToUpper();
            string query = "";
            Database db = null;
            DataTable dt = null;

            //JDE
            if (radioButton1.Checked || radioButton2.Checked)
            {
                query = @"
select
trim(SIOBNM) as ""Table"",
trim(SIMD) as ""Description""

from OL910.F9860
where SIFUNO = 'TBLE'
and (upper(SIOBNM) like '%" + filter + "%' or upper(SIMD) like '%" + filter + @"%')

order by SIOBNM";

                db = new Oracle(query);

                dt = db.Run();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem li = new ListViewItem(dt.Rows[i]["Table"].ToString());
                    li.SubItems.Add(dt.Rows[i]["Description"].ToString());
                    li.Tag = dt.Rows[i]["Table"].ToString();

                    resultsList.Items.Add(li);
                }
            }

            //Vailtech
            if (radioButton1.Checked || radioButton4.Checked)
            {
                query = @"SELECT table_name as ""Table"", 'Vailtech' as ""Description"" FROM dba_tables
where owner = 'VAILTECH'
and upper(table_name) like '%" + filter + "%'";
                db = new Vailtech(query);

                dt = db.Run();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem li = new ListViewItem(dt.Rows[i]["Table"].ToString());
                    li.SubItems.Add(dt.Rows[i]["Description"].ToString());
                    li.Tag = dt.Rows[i]["Table"].ToString();

                    resultsList.Items.Add(li);
                }
            }

            //CityView
            if (radioButton1.Checked || radioButton3.Checked)
            {
                query = @"SELECT table_name as ""Table"", 'CityView' as ""Description"" FROM dba_tables
where owner = 'SYSADMIN'
and upper(table_name) like '%" + filter + "%'";
                db = new CityView(query);

                dt = db.Run();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem li = new ListViewItem(dt.Rows[i]["Table"].ToString());
                    li.SubItems.Add(dt.Rows[i]["Description"].ToString());
                    li.Tag = dt.Rows[i]["Table"].ToString();

                    resultsList.Items.Add(li);
                }
            }

//            //ESRI10PUB
//            query = @"SELECT table_name as ""Table"", owner as ""Description"" FROM dba_tables
//where upper(table_name) like '%" + filter + "%'";
//            db = new CityView(query);

//            dt = db.Run();

//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                ListViewItem li = new ListViewItem(dt.Rows[i]["Table"].ToString());
//                li.SubItems.Add(dt.Rows[i]["Description"].ToString());
//                li.Tag = dt.Rows[i]["Table"].ToString();

//                resultsList.Items.Add(li);
//            }
            
            for (int i = 0; i < resultsList.Columns.Count; i++)
                resultsList.Columns[i].Width = -2;

            if (resultsList.Items.Count > 0)
                resultsList.Items[0].Selected = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count > 0)
            {
                string tableName = resultsList.SelectedItems[0].Tag.ToString();
                string tableDescription = resultsList.SelectedItems[0].SubItems[1].Text;
                string schema = "";
                string reportTitle = tableName;
                DataTable dt = null;
                Database db = null;

                if (dbType() == "JDE")
                {
                    db = new Oracle(@"
select owner

from dba_objects

where object_type = 'TABLE'
and object_name = @NAME

order by

CASE
    WHEN owner='CRPDTA' THEN 1
    WHEN owner='PRODCTL' THEN 1
    WHEN owner='PD910' THEN 1

    WHEN owner='CRPDTA' THEN 2
    WHEN owner='CRPCTL' THEN 2
    WHEN owner='PY910' THEN 2

    WHEN owner='TESTDTA' THEN 3
    WHEN owner='TESTCTL' THEN 3
    WHEN owner='DV910' THEN 3

    WHEN owner='PS910DTA' THEN 4
    WHEN owner='PS910CTL' THEN 4
    WHEN owner='PS910' THEN 4
END");
                    db.AddParameter("@NAME", tableName);
                    dt = db.Run();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No schemas were found for this table.");
                        return;
                    }

                    schema = dt.Rows[0][0].ToString();

                    if (dt.Rows.Count > 1)
                    {
                        LookupDropdown box = new LookupDropdown("Select environment", dt);
                        box.ShowDialog();

                        if (box.r != "")
                            schema = box.r;
                        else
                            return;
                    }

                    reportTitle = schema + "." + tableName + " - " + tableDescription;

                    db.Query = "select * from " + schema + "." + tableName;
                }
                else if (dbType() == "Vailtech")
                    db = new Vailtech("select * from " + tableName);
                else if (dbType() == "CityView")
                    db = new CityView("select * from sysadmin." + tableName);
                else
                    throw new Exception("Database type not recognized");

                Report r = new Report(reportTitle, db.Run());
                r.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count > 0)
            {
                string tableName = resultsList.SelectedItems[0].Tag.ToString();
                string tableDescription = resultsList.SelectedItems[0].SubItems[1].Text;
                Database db = null;
                DataTable dt = null;
                string reportTitle = tableName;

                if (dbType() == "Vailtech")
                    db = new Vailtech("");
                else if (dbType() == "CityView")
                    db = new CityView("");

                if (dbType() == "JDE")
                {
                    Oracle ora = new Oracle(@"
select owner

from dba_objects

where object_type = 'TABLE'
and object_name = @NAME

order by

CASE
    WHEN owner='CRPDTA' THEN 1
    WHEN owner='PRODCTL' THEN 1
    WHEN owner='PD910' THEN 1

    WHEN owner='CRPDTA' THEN 2
    WHEN owner='CRPCTL' THEN 2
    WHEN owner='PY910' THEN 2

    WHEN owner='TESTDTA' THEN 3
    WHEN owner='TESTCTL' THEN 3
    WHEN owner='DV910' THEN 3

    WHEN owner='PS910DTA' THEN 4
    WHEN owner='PS910CTL' THEN 4
    WHEN owner='PS910' THEN 4
END");
                    ora.AddParameter("@NAME", tableName);
                    DataTable dt2 = ora.Run();

                    if (dt2.Rows.Count == 0)
                    {
                        MessageBox.Show("No schemas were found for this table.");
                        return;
                    }

                    string schema = dt2.Rows[0][0].ToString();
                    reportTitle = schema + "." + tableName + " - " + tableDescription;

                    ora = new Oracle(@"
        SELECT
    case ALL_CONSTRAINTS.CONSTRAINT_TYPE when 'P' then 'PK' else '' end as ""Key"",
    ALL_TAB_COLS.COLUMN_NAME as ""Column"",
    min(DD910.F9202.FRDSCR) as ""Description"",
    ALL_TAB_COLS.data_type,
    ALL_TAB_COLS.data_length,
    ALL_TAB_COLS.data_precision,
    ALL_TAB_COLS.data_scale,
    ALL_TAB_COLS.nullable

    FROM DD910.F9202
    LEFT JOIN ALL_TAB_COLS ON substr(ALL_TAB_COLS.COLUMN_NAME, 3, length(ALL_TAB_COLS.COLUMN_NAME) - 2) = trim(DD910.F9202.FRDTAI)
    LEFT JOIN ALL_CONS_COLUMNS ON ALL_CONS_COLUMNS.COLUMN_NAME = ALL_TAB_COLS.COLUMN_NAME AND ALL_CONS_COLUMNS.TABLE_NAME = ALL_TAB_COLS.TABLE_NAME AND ALL_CONS_COLUMNS.OWNER = ALL_TAB_COLS.OWNER
    LEFT JOIN ALL_CONSTRAINTS ON ALL_CONSTRAINTS.CONSTRAINT_NAME = ALL_CONS_COLUMNS.CONSTRAINT_NAME AND ALL_CONSTRAINTS.OWNER = ALL_CONS_COLUMNS.OWNER AND ALL_CONSTRAINTS.TABLE_NAME = ALL_CONS_COLUMNS.TABLE_NAME

    WHERE trim(ALL_TAB_COLS.TABLE_NAME) = @TAB
    AND (ALL_CONSTRAINTS.CONSTRAINT_TYPE = 'P' OR ALL_CONSTRAINTS.CONSTRAINT_TYPE is null)

    GROUP BY
    ALL_CONSTRAINTS.CONSTRAINT_TYPE,
    ALL_TAB_COLS.COLUMN_NAME,
    ALL_TAB_COLS.data_type,
    ALL_TAB_COLS.data_length,
    ALL_TAB_COLS.data_precision,
    ALL_TAB_COLS.data_scale,
    ALL_TAB_COLS.nullable,
    ALL_TAB_COLS.COLUMN_ID

    ORDER BY ALL_TAB_COLS.COLUMN_ID, ALL_TAB_COLS.COLUMN_NAME");
                    ora.AddParameter("@TAB", tableName);
                    dt = ora.Run();
                }
                else if (dbType() == "Vailtech" || dbType() == "CityView")
                {
                    db.Query = @"
    SELECT
    case ALL_CONSTRAINTS.CONSTRAINT_TYPE when 'P' then 'PK' else '' end as ""Key"",
    ALL_TAB_COLS.COLUMN_NAME as ""Column"",
    ALL_TAB_COLS.data_type,
    ALL_TAB_COLS.data_length,
    ALL_TAB_COLS.data_precision,
    ALL_TAB_COLS.data_scale,
    ALL_TAB_COLS.nullable

    FROM ALL_TAB_COLS
    LEFT JOIN ALL_CONS_COLUMNS ON ALL_CONS_COLUMNS.COLUMN_NAME = ALL_TAB_COLS.COLUMN_NAME AND ALL_CONS_COLUMNS.TABLE_NAME = ALL_TAB_COLS.TABLE_NAME AND ALL_CONS_COLUMNS.OWNER = ALL_TAB_COLS.OWNER
    LEFT JOIN ALL_CONSTRAINTS ON ALL_CONSTRAINTS.CONSTRAINT_NAME = ALL_CONS_COLUMNS.CONSTRAINT_NAME AND ALL_CONSTRAINTS.OWNER = ALL_CONS_COLUMNS.OWNER AND ALL_CONSTRAINTS.TABLE_NAME = ALL_CONS_COLUMNS.TABLE_NAME

    WHERE trim(ALL_TAB_COLS.TABLE_NAME) = @TAB

    GROUP BY
    ALL_CONSTRAINTS.CONSTRAINT_TYPE,
    ALL_TAB_COLS.COLUMN_NAME,
    ALL_TAB_COLS.data_type,
    ALL_TAB_COLS.data_length,
    ALL_TAB_COLS.data_precision,
    ALL_TAB_COLS.data_scale,
    ALL_TAB_COLS.nullable,
    ALL_TAB_COLS.COLUMN_ID

    ORDER BY ALL_TAB_COLS.COLUMN_ID";
                    db.AddParameter("@TAB", tableName);
                    dt = db.Run();
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["data_type"].ToString() == "NCHAR")
                    {
                        int var;
                        bool success = int.TryParse(dt.Rows[i]["data_length"].ToString(), out var);

                        if (success)
                        {
                            var /= 2;
                            dt.Rows[i]["data_length"] = var;
                        }
                    }
                }

                Report r = new Report(reportTitle, dt);
                r.Show();
            }
        }

        private void TableBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2_Click(null, null);

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from TABLENAME";

            if(radioButton1.Checked)
            {
                MessageBox.Show("Please choose a database.");
                return;
            }

            bool success;

            do
            {
                sql = Core.getString("Enter query", sql, true, out success);

                if (success)
                {
                    try
                    {
                        Database db = null;

                        if (radioButton2.Checked)
                            db = new Oracle(sql);
                        else if (radioButton3.Checked)
                            db = new CityView(sql);
                        else if (radioButton4.Checked)
                            db = new Vailtech(sql);
                        else
                        {
                            MessageBox.Show("Database not coded for. Please let the developer know.");
                            return;
                        }

                        Report r = new Report(sql, db.Run());
                        r.Show();
                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show(e2.Message);
                    }
                }
            } while (success);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool success;
            string s = Core.getString("Enter column name", out success).ToLower();
            
            if (!success || s.Contains("'"))
                return;

            DataTable dt = Oracle.Run(@"
select
trim(TDOBNM) as ""Table"",
trim(SIMD) as ""Table Description"",
trim(TDSQLC) as ""Column""

from PD910.F98711 tc
join OL910.F9860 t on tc.TDOBNM = t.SIOBNM

where lower(TDSQLC) like '%" + s + "%'");

            Report r = new Report("Column Lookup - " + s, dt);
            r.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count > 0)
            {
                string tableName = resultsList.SelectedItems[0].Tag.ToString();
                string tableDescription = resultsList.SelectedItems[0].SubItems[1].Text;
                string schema = "";
                string reportTitle = "Indexes on " + tableName;
                DataTable dt = null;
                Database db = null;

                if (dbType() == "JDE")
                {
                    db = new Oracle(@"
select owner

from dba_objects

where object_type = 'TABLE'
and object_name = @NAME

order by

CASE
    WHEN owner='CRPDTA' THEN 1
    WHEN owner='PRODCTL' THEN 1
    WHEN owner='PD910' THEN 1

    WHEN owner='CRPDTA' THEN 2
    WHEN owner='CRPCTL' THEN 2
    WHEN owner='PY910' THEN 2

    WHEN owner='TESTDTA' THEN 3
    WHEN owner='TESTCTL' THEN 3
    WHEN owner='DV910' THEN 3

    WHEN owner='PS910DTA' THEN 4
    WHEN owner='PS910CTL' THEN 4
    WHEN owner='PS910' THEN 4
END");
                    db.AddParameter("@NAME", tableName);
                    dt = db.Run();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No schemas were found for this table.");
                        return;
                    }

                    schema = dt.Rows[0][0].ToString();

                    if (dt.Rows.Count > 1)
                    {
                        LookupDropdown box = new LookupDropdown("Select environment", dt);
                        box.ShowDialog();

                        if (box.r != "")
                            schema = box.r;
                    }

                    reportTitle = "Indexes on " + schema + "." + tableName;

                    db.Query = @"
SELECT
c.index_owner,
c.table_name,
i.index_name,
c.column_position,
c.column_name,
DECODE(i.uniqueness, 'UNIQUE', 'YES', 'NO') UNIQUENESS
FROM dba_ind_columns c, dba_indexes i
WHERE i.index_name = c.index_name
AND i.table_owner = c.table_owner

AND c.index_owner = '" + schema + @"'
AND c.table_name = '" + tableName + @"'
order by i.index_name, c.column_position
";

                }
                else if (dbType() == "Vailtech")
                    db = new Vailtech(@"
SELECT
c.index_owner,
c.table_name,
i.index_name,
c.column_position,
c.column_name,
DECODE(i.uniqueness, 'UNIQUE', 'YES', 'NO') UNIQUENESS
FROM dba_ind_columns c, dba_indexes i
WHERE i.index_name = c.index_name
AND i.table_owner = c.table_owner
AND c.table_name = '" + tableName + @"'
order by i.index_name, c.column_position");
                else if (dbType() == "CityView")
                    db = new CityView(@"
SELECT
c.index_owner,
c.table_name,
i.index_name,
c.column_position,
c.column_name,
DECODE(i.uniqueness, 'UNIQUE', 'YES', 'NO') UNIQUENESS
FROM dba_ind_columns c, dba_indexes i
WHERE i.index_name = c.index_name
AND i.table_owner = c.table_owner
AND c.table_name = '" + tableName + @"'
order by i.index_name, c.column_position");
                else
                    throw new Exception("Database type not recognized");

            Report r = new Report(reportTitle, db.Run());
            r.Show();
            }
        }

        private void resultsList_DoubleClick(object sender, EventArgs e)
        {
            if(resultsList.SelectedItems.Count > 0)
            {
                button3_Click(null, null);
            }
        }
    }
}
