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
    public partial class DATSEngineering : Form
    {
        string APPROVED_TEXT = "Approved";
        string REVIEWED_TEXT = "Reviewed";
        string PENDING_TEXT = "Unapproved";
        string EXPORTED_TEXT = "Processed";
        Color APPROVED_COLOR = Color.Green;
        Color REVIEWED_COLOR = Color.Orange;
        Color PENDING_COLOR = Color.Red;
        Color EXPORTED_COLOR = Color.Blue;

        public DATSEngineering()
        {
            InitializeComponent();

            //MessageBox.Show(DATSCore.getBankAllotment("Delong, Joshua William Norman").ToString());

            //(new Profile()).ShowDialog();
            //(new TimesheetHistory(624039)).ShowDialog();
            //Get who is logged in
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select username, active from users where displayname=@USERNAME");
            sql.AddParameter("@USERNAME", DATSEngineeringCore.getUsername());
            DataTable dt = sql.Run();

            if (dt.Rows.Count == 0) //If not recognized...
            {
                MessageBox.Show("User \"" + DATSEngineeringCore.getUsername() + "\" not found. Please ask a supervisor to create you a DATS account.");
                this.Close();
            }
            else //Else, do initial setup
            {
                if (bool.Parse(dt.Rows[0]["active"].ToString()) == false)
                {
                    MessageBox.Show("Your account is inactive. Please ask a supervisor to have your account activated.");
                    this.Close();
                }
                else
                {
                    //DATSCore.logHistory("Logged in", Environment.MachineName, "");

                    DateTime start = DateTime.Now;
                    TimeSpan ts = DateTime.Now - start;
                    string output = "";

                    for (int i = 0; i < resultsList.Columns.Count; i++)
                        resultsList.Columns[i].Name = resultsList.Columns[i].Text;

                    if (!DATSEngineeringCore.isAdmin(DATSEngineeringCore.getUsername()))
                        payrollToolStripMenuItem.Visible = false;

                    if (!DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()))
                    {
                        comboBox1.Enabled = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        pendingApprovalToolStripMenuItem.Visible = false;
                        managementOptionsToolStripMenuItem.Visible = false;

                        for (int i = 0; i < toolStripMenuItem2.DropDownItems.Count; i++)
                            toolStripMenuItem2.DropDownItems[i].Visible = false;

                        paychequesToolStripMenuItem.Visible = true;
                        approveToolStripMenuItem.Visible = false;
                    }

                    DataTable cur = Oracle.Run("select YDCTRY, YDDTEY, YDPPNB from CRPDTA.F07210 where YDPAYD='TOWNHOURLY'");
                    string currentPeriod = cur.Rows[0]["YDCTRY"].ToString() + cur.Rows[0]["YDDTEY"].ToString() + cur.Rows[0]["YDPPNB"].ToString().Substring(1, 2);

                    ts = DateTime.Now - start;
                    output += "Step 5 " + ts.TotalSeconds + Environment.NewLine;

                    dt = Oracle.Run("select JDDTEY, JDPPNB from CRPDTA.F069066 where JDPCCD='SAL'");

                    ts = DateTime.Now - start;
                    output += "Step 6 " + ts.TotalSeconds + Environment.NewLine;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string period = "20" + (dt.Rows[i]["JDDTEY"].ToString().Length == 2 ? dt.Rows[i]["JDDTEY"].ToString() : ("0" + dt.Rows[i]["JDDTEY"].ToString())) + dt.Rows[i]["JDPPNB"].ToString().Substring(1, 2);

                        DateTime from = DATSEngineeringCore.getPeriodStart(int.Parse(period));
                        DateTime to = DATSEngineeringCore.getPeriodEnd(int.Parse(period));

                        comboBox3.Items.Add(period + " - " + from.ToString(@"MMM d") + " to " + to.ToString(@"MMM d") + (currentPeriod == period ? " (Current)" : ""));

                        if (currentPeriod == period)
                            comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
                    }

                    updateCalendars();
                    loadUsers();

                    comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;

                    ts = DateTime.Now - start;
                    output += "Step 7 " + ts.TotalSeconds + Environment.NewLine;

                    //sql = new DATSEngineeringSQL("select [from] from periods where [from]<=@DATE and [to]>=@DATE");
                    //sql.AddParameter("@DATE", DateTime.Today);

                    //DateTime startingMonday = DateTime.Parse(sql.Run().Rows[0][0].ToString());
                    //dateTimePicker1.Value = startingMonday;
                    //dateTimePicker2.Value = startingMonday.AddDays(13);

                    //refresh();

                    ts = DateTime.Now - start;
                    output += "Step 8 " + ts.TotalSeconds + Environment.NewLine;

                    refresh();

                    ts = DateTime.Now - start;
                    output += "Step 9 " + ts.TotalSeconds + Environment.NewLine;

                    //MessageBox.Show(output);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkForPrePeriod())
                refresh();
        }

        private bool checkForPrePeriod()
        {
            DataTable cur = Oracle.Run("select YDCTRY, YDDTEY, YDPPNB from CRPDTA.F07210 where YDPAYD='TOWNHOURLY'");
            int period = int.Parse(cur.Rows[0]["YDCTRY"].ToString() + cur.Rows[0]["YDDTEY"].ToString() + cur.Rows[0]["YDPPNB"].ToString().Substring(1, 2));

            //Returns false when no pre-period found, or when user decides to ignore pre-period
            DATSEngineeringSQL sql = new DATSEngineeringSQL(@"SELECT t.timecarddetailid, t.dateworked, DATENAME(MM, t.DateWorked) + ' ' + DATENAME(DD, t.dateworked) + ', ' + DATENAME(YYYY, t.dateworked) + ' (' + DATENAME(DW, t.DateWorked) + ')' as 'Date Worked'
  FROM timesheetdetail t
  where employeeid=@EMPID
  and Period<@PERIOD
  and exported=0
  and recordlocked=0
order by dateworked asc");
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@EMPID", DATSEngineeringCore.getEmpID(getUsername()));
            DataTable dt = sql.Run();

            if (dt.Rows.Count > 0 && DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()))
            {
                string message = getUsername() + " has unapproved pre-period on the following dates:" + Environment.NewLine + Environment.NewLine;

                for (int i = 0; i < dt.Rows.Count && i < 15; i++)
                {
                    message += dt.Rows[i]["Date Worked"].ToString() + Environment.NewLine;
                }

                string result = Core.lookupMessageBox("Pre-period Reminder", message, "Show me");

                if (result == "Show me")
                {
                    ignoreFromCal = true;
                    ignoreToCal = true;

                    dateTimePicker1.Value = DateTime.Parse(dt.Rows[0]["dateworked"].ToString());
                    dateTimePicker2.Value = DateTime.Parse(dt.Rows[dt.Rows.Count - 1]["dateworked"].ToString());

                    ignoreFromCal = false;
                    ignoreToCal = false;

                    refresh();

                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private void refresh()
        {
            DateTime start = DateTime.Now;
            TimeSpan ts = DateTime.Now - start;
            string output = "";

            ts = DateTime.Now - start;
            output += "Step 1 " + ts.TotalSeconds + Environment.NewLine;

            hoursCalendar1.username = getUsername();
            hoursCalendar1.showDate(dateTimePicker1.Value);

            ts = DateTime.Now - start;
            output += "Step 2 " + ts.TotalSeconds + Environment.NewLine;

            resultsList.Items.Clear();

            DATSEngineeringSQL sql = new DATSEngineeringSQL(
    @"SELECT
datediff(day, @DATEWORKED, dateworked) as 'DaysIntoPeriod',
t.[TIMECARDDETAILID] as ID,
u.username as Username,
t.dateworked AS DateWorked,
t.[HOURS] as Hours,
t.workorder as WorkOrder,
DATENAME(MM, t.DATEENTERED) + RIGHT(CONVERT(VARCHAR(12), t.DATEENTERED, 107), 9) as DateEntered,
t.[RecordLocked] as Approved,
t.[Exported] as Exported,
t.DATEWORKED as FullDateWorked,
t.description as Description

FROM [TimeSheetDetail] t

INNER JOIN Users u ON t.employeeid = u.employeeid

WHERE
u.displayname = @USERNAME
AND t.DATEWORKED >= @DATEWORKED
AND t.DATEWORKED <= @DATECUTOFF

ORDER BY t.DATEWORKED ASC");


            //INNER JOIN Roles r ON u.roleid = r.roleid
            //INNER JOIN Department d ON r.departmentid = d.departmentid

            //                sql.AddParameter("@DEPARTMENTUSERNAME", DATSCore.getUsername()); //Username of current user to determine current department
            sql.AddParameter("@USERNAME", getUsername());
            sql.AddParameter("@DATEWORKED", dateTimePicker1.Value);
            sql.AddParameter("@DATECUTOFF", dateTimePicker2.Value);
            DataTable dt = sql.Run();

            ts = DateTime.Now - start;
            output += "Step 3 " + ts.TotalSeconds + Environment.NewLine;

            double totalHours = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ID = dt.Rows[i]["ID"].ToString();
                string username = dt.Rows[i]["Username"].ToString();
                string dateWorked = DateTime.Parse(dt.Rows[i]["DateWorked"].ToString()).ToString("MMM dd ddd");
                string fullDateWorked = dt.Rows[i]["FullDateWorked"].ToString();
                string hours = dt.Rows[i]["Hours"].ToString();
                string workOrder = dt.Rows[i]["WorkOrder"].ToString().Trim();
                int daysIntoPeriod = int.Parse(dt.Rows[i]["DaysIntoPeriod"].ToString());
                string description = dt.Rows[i]["Description"].ToString();

                totalHours += double.Parse(hours);

                Oracle ora = new Oracle("select WADL01, WAVR01 from CRPDTA.F4801 where WADOCO = :WO");
                ora.AddParameter("WO", workOrder);
                DataTable wodt = ora.Run();

                if (wodt.Rows.Count > 0)
                {
                    workOrder += " - " + wodt.Rows[0]["WADL01"].ToString().Trim();

                    if (wodt.Rows[0]["WAVR01"].ToString().Trim() != "")
                        workOrder += " (" + wodt.Rows[0]["WAVR01"].ToString().Trim() + ")";
                }

                bool recordLocked = bool.Parse(dt.Rows[i]["Approved"].ToString());
                bool exported = bool.Parse(dt.Rows[i]["Exported"].ToString());
                string status;
                Color statusColor;

                resultsList.Groups.Add(new ListViewGroup("Week " + ((daysIntoPeriod / 7) + 1), "Week " + ((daysIntoPeriod / 7) + 1)));

                if (exported)
                {
                    status = EXPORTED_TEXT;
                    statusColor = EXPORTED_COLOR;
                }
                else
                {
                    if (recordLocked)
                    {
                        status = APPROVED_TEXT;
                        statusColor = APPROVED_COLOR;
                    }
                    else
                    {
                        status = PENDING_TEXT;
                        statusColor = PENDING_COLOR;
                    }
                }


                ListViewItem x;

                x = new ListViewItem(new[] { dateWorked, hours, workOrder, status, description });

                x.Tag = ID;
                x.SubItems[resultsList.Columns["Status"].Index].ForeColor = statusColor;
                x.UseItemStyleForSubItems = false;
                x.Group = resultsList.Groups["Week " + ((daysIntoPeriod / 7) + 1)];
                resultsList.Items.Add(x);
            }

            ts = DateTime.Now - start;
            output += "Step 4 " + ts.TotalSeconds + Environment.NewLine;

            for (int i = 0; i < resultsList.Columns.Count; i++)
                resultsList.Columns[i].Width = -2;

            ts = DateTime.Now - start;
            output += "Step 4½ " + ts.TotalSeconds + Environment.NewLine;

            //loadPayTypes();

            ts = DateTime.Now - start;
            output += "Step 5 " + ts.TotalSeconds + Environment.NewLine;

            resultsList.Focus();

            ts = DateTime.Now - start;
            output += "Step 6 " + ts.TotalSeconds + Environment.NewLine;

            //MessageBox.Show(output);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
                comboBox1.SelectedIndex--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < comboBox1.Items.Count - 1)
                comboBox1.SelectedIndex++;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(DATSCore.getLockout())
            //{
            //    MessageBox.Show(DATSCore.getLockoutText());
            //    return;
            //}

            (new NewTimesheetold(getUsername())).ShowDialog();
            refresh();
        }

        private string getUsername()
        {
            return comboBox1.Text.Split('(')[0].Trim();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoreFromCal)
                refresh();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoreToCal)
                refresh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DATSCore.getLockout())
            //{
            //    MessageBox.Show(DATSCore.getLockoutText());
            //    return;
            //}

            edit();
        }

        private void edit()
        {
            if (resultsList.SelectedItems.Count > 0)
            {
                bool canEdit = true;
                string errorStatus = "";

                for (int i = 0; i < resultsList.SelectedItems.Count && canEdit; i++)
                {
                    string status = resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text;

                    if (status == APPROVED_TEXT && !DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()))
                    {
                        canEdit = false;
                        errorStatus = "Can't edit records that have been approved.";
                    }

                    if (status == "Processed")
                    {
                        canEdit = false;
                        errorStatus = "Can't edit records that have been processed.";
                    }
                }

                if (canEdit)
                {
                    for (int i = 0; i < resultsList.SelectedItems.Count; i++)
                    {
                        ListViewItem item = resultsList.SelectedItems[i];

                        (new NewTimesheetold(int.Parse(item.Tag.ToString()))).ShowDialog();
                        hoursCalendar1.username = getUsername();
                        hoursCalendar1.showDate(dateTimePicker1.Value);
                    }

                    refresh();
                }
                else
                    MessageBox.Show(errorStatus);
            }
            else
            {
                MessageBox.Show("No timesheet selected.");
            }
        }

        private void resultsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edit();
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count == 0)
                MessageBox.Show("Please select a timesheet.");
            else
            {
                for (int i = 0; i < resultsList.SelectedItems.Count; i++)
                {
                    ListViewItem item = resultsList.SelectedItems[i];

                    DATSEngineeringSQL sql = new DATSEngineeringSQL(@"
select 
DATENAME(DW, t.HistoryTimestamp) + ', ' + DATENAME(MM, t.HistoryTimestamp) + ' ' + DATENAME(DD, t.HistoryTimestamp) + ', ' + CONVERT(VARCHAR(8),t.HistoryTimestamp,108) as 'Timestamp',
PerformedBy as 'Performed By',
HistoryDescription as 'Action Description',
Version,
Period,
DATENAME(MM, t.DateWorked) + ' ' + DATENAME(DD, t.dateworked) + ' (' + DATENAME(DW, t.DateWorked) + ')' as 'Date Worked',
p.Description as 'Pay Type',
StartTime as 'Start Time',
FinishTime as 'Finish Time',
Hours,
WorkOrder as 'Work Order',
LumpSum as 'Lump Sum',
Reviewed,
RecordLocked as 'Approved',
t.Description,
Exported,
BatchId

from historyversions t
join PayCodes p on t.PayType = p.PayType
where timecarddetailid=@ID
order by version");
                    sql.AddParameter("@ID", item.Tag.ToString());
                    DataTable dt = sql.Run();

                    Report r = new Report("Timesheet History", dt);
                    r.Show();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void loadUsers()
        {
            DATSEngineeringSQL sql;

            if (!DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()))
            {
                sql = new DATSEngineeringSQL("select * from users u where u.displayname=@U");
                sql.AddParameter("@U", DATSEngineeringCore.getUsername());
            }
            else
            {
                sql = new DATSEngineeringSQL("select * from users where active=1 order by displayname");
            }
            DataTable dt = sql.Run();

            comboBox1.Items.Clear();

            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;

            for (int i = 0; i < dt.Rows.Count; i++)
                comboBox1.Items.Add(dt.Rows[i]["displayname"].ToString() + " (" + dt.Rows[i]["employeeid"].ToString() + ")");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        bool ignoreFromCal = false;
        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            ignoreFromCal = true;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            ignoreFromCal = false;
            dateTimePicker1_ValueChanged(null, null);
        }

        bool ignoreToCal = false;
        private void dateTimePicker2_DropDown(object sender, EventArgs e)
        {
            ignoreToCal = true;
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            ignoreToCal = false;
            dateTimePicker2_ValueChanged(null, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in resultsList.Items)
            {
                item.Selected = true;
            }
            resultsList.Focus();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL(
    @"SELECT
t.[TIMECARDDETAILID] as ID,
u.username as Username,
t.dateworked AS DateWorked,
t.starttime + ' - ' + t.finishtime as [TimeRange],
pt.[DESCRIPTION] as PayType,
t.[HOURS] as Hours,
t.workorder as WorkOrder,
'$'+convert(varchar,convert(int, t.[LUMPSUM])) as LSum,
DATENAME(MM, t.DATEENTERED) + RIGHT(CONVERT(VARCHAR(12), t.DATEENTERED, 107), 9) as DateEntered,
t.[REVIEWED] as Reviewed,
t.[RecordLocked] as Processed,
t.[DESCRIPTION] as [Description],
t.DATEWORKED as FullDateWorked

FROM [TimeSheetDetail] t

INNER JOIN Users u ON t.employeeid = u.employeeid
INNER JOIN PayCodes pt ON t.paytype = pt.paytype
LEFT OUTER JOIN Mirror_WorkOrders wo ON t.workorder = wo.workorder

WHERE
u.displayname = @USERNAME
AND t.DATEWORKED >= @DATEWORKED
AND t.DATEWORKED <= @DATECUTOFF

ORDER BY u.username, t.DATEWORKED ASC");
            //                sql.AddParameter("@DEPARTMENTUSERNAME", DATSCore.getUsername()); //Username of current user to determine current department
            sql.AddParameter("@USERNAME", getUsername());
            sql.AddParameter("@DATEWORKED", dateTimePicker1.Value);
            sql.AddParameter("@DATECUTOFF", dateTimePicker2.Value);
            DataTable dt = sql.Run();

            DATSEngineeringCore.export("Timesheet Report", dt);
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool showMessage = false;
            bool showMessage2 = false;

            for (int i = 0; i < resultsList.SelectedItems.Count; i++)
            {
                string currentStatus = resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text;

                //Exported
                if (currentStatus == EXPORTED_TEXT && resultsList.SelectedItems.Count == 1)
                {
                    MessageBox.Show("This timesheet has already been processed by Payroll." + Environment.NewLine +
                        "Please contact Payroll if changes are needed.");
                }
                else if (currentStatus == EXPORTED_TEXT && resultsList.SelectedItems.Count != 1)
                {
                    showMessage2 = true;
                }
                else
                {
                    DATSEngineeringSQL sql = new DATSEngineeringSQL("update timesheetdetail set recordlocked='True' where timecarddetailid=@ID");
                    sql.AddParameter("@ID", resultsList.SelectedItems[i].Tag.ToString());
                    sql.Run();

                    resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text = APPROVED_TEXT;
                    resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].ForeColor = APPROVED_COLOR;
                }
            }

            resultsList.Columns["Status"].Width = -2;

            if (showMessage2)
                MessageBox.Show("Some of the selected timesheets have already been processed by Payroll." + Environment.NewLine +
                        "Please contact Payroll if changes are needed.");
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool showMessage = false;
            bool showMessage2 = false;
            //bool showMessage3 = false;

            for (int i = 0; i < resultsList.SelectedItems.Count; i++)
            {
                string currentStatus = resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text;

                if (DATSEngineeringCore.isTimesheetLocked(int.Parse(resultsList.SelectedItems[i].Tag.ToString())) && resultsList.SelectedItems.Count == 1)
                {
                    //showMessage3 = true;
                }
                //Exported
                else if (currentStatus == EXPORTED_TEXT && resultsList.SelectedItems.Count == 1)
                {
                    MessageBox.Show("This timesheet has already been processed by Payroll." + Environment.NewLine +
                        "Please contact Payroll if changes are needed.");
                }
                else if (currentStatus == EXPORTED_TEXT && resultsList.SelectedItems.Count != 1)
                {
                    showMessage2 = true;
                }
                //Approved, and not allowed to unapprove
                else if (currentStatus == APPROVED_TEXT && !DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()) && resultsList.SelectedItems.Count == 1)
                {
                    MessageBox.Show("You don't have permission to change the status on an approved timesheet.");
                }
                else if (currentStatus == APPROVED_TEXT && !DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()) && resultsList.SelectedItems.Count != 1)
                {
                    showMessage = true;
                }
                //Do it
                else
                {
                    DATSEngineeringSQL sql = new DATSEngineeringSQL("update timesheetdetail set reviewed='True', recordlocked='False' where timecarddetailid=@ID");
                    sql.AddParameter("@ID", resultsList.SelectedItems[i].Tag.ToString());
                    sql.Run();

                    resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text = REVIEWED_TEXT;
                    resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].ForeColor = REVIEWED_COLOR;
                }
            }

            resultsList.Columns["Status"].Width = -2;

            if (showMessage)
                MessageBox.Show("Some records were not updated because you don't have permission to change approved records.");

            if (showMessage2)
                MessageBox.Show("Some of the selected timesheets have already been processed by Payroll." + Environment.NewLine +
                        "Please contact Payroll if changes are needed.");
        }

        private void pendingApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool showMessage = false;
            bool showMessage2 = false;
            //bool showMessage3 = false;

            for (int i = 0; i < resultsList.SelectedItems.Count; i++)
            {
                string currentStatus = resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text;

                if (DATSEngineeringCore.isTimesheetLocked(int.Parse(resultsList.SelectedItems[i].Tag.ToString())) && resultsList.SelectedItems.Count == 1)
                {
                    //showMessage3 = true;
                }
                //Exported
                else if (currentStatus == EXPORTED_TEXT && resultsList.SelectedItems.Count == 1)
                {
                    MessageBox.Show("This timesheet has already been processed by Payroll." + Environment.NewLine +
                        "Please contact Payroll if changes are needed.");
                }
                else if (currentStatus == EXPORTED_TEXT && resultsList.SelectedItems.Count != 1)
                {
                    showMessage2 = true;
                }
                //Approved, and not allowed to unapprove
                else if (currentStatus == APPROVED_TEXT && !DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()) && resultsList.SelectedItems.Count == 1)
                {
                    MessageBox.Show("You don't have permission to change the status on an approved timesheet.");
                }
                else if (currentStatus == APPROVED_TEXT && !DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()) && resultsList.SelectedItems.Count != 1)
                {
                    showMessage = true;
                }
                //Do it
                else
                {
                    DATSEngineeringSQL sql = new DATSEngineeringSQL("update timesheetdetail set recordlocked='False' where timecarddetailid=@ID");
                    sql.AddParameter("@ID", resultsList.SelectedItems[i].Tag.ToString());
                    sql.Run();

                    resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text = PENDING_TEXT;
                    resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].ForeColor = PENDING_COLOR;
                }
            }

            resultsList.Columns["Status"].Width = -2;

            if (showMessage)
                MessageBox.Show("Some records were not updated because you don't have permission to change approved records.");

            if (showMessage2)
                MessageBox.Show("Some of the selected timesheets have already been processed by Payroll." + Environment.NewLine +
                        "Please contact Payroll if changes are needed.");
        }

        private void Profile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DATSCore.getLockout())
            //{
            //    MessageBox.Show(DATSCore.getLockoutText());
            //    return;
            //}

            if (resultsList.SelectedItems.Count > 0)
            {
                bool canRemove = true;
                string errorStatus = "";

                for (int i = 0; i < resultsList.SelectedItems.Count && canRemove; i++)
                {
                    string status = resultsList.SelectedItems[i].SubItems[resultsList.Columns["Status"].Index].Text;

                    if (status == EXPORTED_TEXT)
                    {
                        canRemove = false;
                        errorStatus = "Can't remove records that have been processed.";
                    }
                    else if (status == APPROVED_TEXT && !DATSEngineeringCore.canApprove(DATSEngineeringCore.getUsername()))
                    {
                        canRemove = false;
                        errorStatus = "Can't remove records that have been approved.";
                    }
                }

                if (canRemove)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + (resultsList.SelectedItems.Count > 1 ? "these " + resultsList.SelectedItems.Count + " records?" : "this record?"), "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        for (int i = resultsList.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            string id = resultsList.SelectedItems[i].Tag.ToString();

                            DATSEngineeringSQL sql = new DATSEngineeringSQL("delete from timesheetdetail where timecarddetailid = @ID");
                            sql.AddParameter("@ID", resultsList.SelectedItems[i].Tag.ToString());
                            sql.Run();

                            resultsList.Items.Remove(resultsList.SelectedItems[i]);
                            hoursCalendar1.username = getUsername();
                            hoursCalendar1.showDate(dateTimePicker1.Value);
                        }
                    }
                }
                else
                    MessageBox.Show(errorStatus);
            }
            else
            {
                MessageBox.Show("No timesheet selected.");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCalendars();
            refresh();
        }

        private void updateCalendars()
        {
            int period = int.Parse(comboBox3.Text.Split('-')[0].Trim());
            DateTime start = DATSEngineeringCore.getPeriodStart(period);
            DateTime end = DATSEngineeringCore.getPeriodEnd(period);

            ignoreFromCal = true;
            dateTimePicker1.Value = start;
            ignoreFromCal = false;

            ignoreToCal = true;
            dateTimePicker2.Value = end;
            ignoreToCal = false;
        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            comboBox3_SelectedIndexChanged(null, null);
        }

        private void hoursCalendar1_DayClicked(DateTime x)
        {
            if (getUsername() != "")
                (new NewTimesheetold(getUsername(), x)).ShowDialog();

            refresh();
        }

        private void resultsList_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //    viewHistoryToolStripMenuItem_Click(null, null);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e2)
        {
            Printer queue = new Printer();
            int employeeID = DATSEngineeringCore.getEmpID(getUsername());
            string period = comboBox3.Text.Split('-')[0].Trim();
            DateTime date = DATSEngineeringCore.getPeriodStart(int.Parse(comboBox3.Text.Split('-')[0].Trim())).AddDays(7);

            DATSEngineeringSQL sql = new DATSEngineeringSQL(@"
select dateworked, hours, p.description, workorder, lumpsum, recordlocked
from timesheetdetail t
join paycodes p on t.paytype = p.paytype
where t.employeeid = @EMPID
and period=@PERIOD and dateworked < @DATE
order by t.dateworked asc");
            sql.AddParameter("@EMPID", employeeID);
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@DATE", date);
            DataTable week1 = sql.Run();

            sql = new DATSEngineeringSQL(@"
select dateworked, hours, p.description, workorder, lumpsum, recordlocked
from timesheetdetail t
join paycodes p on t.paytype = p.paytype
where t.employeeid = @EMPID
and period=@PERIOD and dateworked >= @DATE
order by t.dateworked asc");
            sql.AddParameter("@EMPID", employeeID);
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@DATE", date);
            DataTable week2 = sql.Run();

            sql = new DATSEngineeringSQL(@"
select p.description, sum(hours) as Hours
from timesheetdetail t
join paycodes p on t.paytype = p.paytype
where t.employeeid = @EMPID
and period=@PERIOD and dateworked < @DATE
group by p.description, p.paytype
order by p.paytype");
            sql.AddParameter("@EMPID", employeeID);
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@DATE", date);
            DataTable week1PayTypes = sql.Run();

            sql = new DATSEngineeringSQL(@"
select p.description, sum(hours) as Hours
from timesheetdetail t
join paycodes p on t.paytype = p.paytype
where t.employeeid = @EMPID
and period=@PERIOD and dateworked >= @DATE
group by p.description, p.paytype
order by p.paytype");
            sql.AddParameter("@EMPID", employeeID);
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@DATE", date);
            DataTable week2PayTypes = sql.Run();

            sql = new DATSEngineeringSQL(@"
select dateworked, hours, p.description, workorder, lumpsum, recordlocked
from timesheetdetail t
join paycodes p on t.paytype = p.paytype
where t.employeeid = @EMPID
and period<@PERIOD and exported=0
and t.paytype<>0
order by t.dateworked asc");
            sql.AddParameter("@EMPID", employeeID);
            sql.AddParameter("@PERIOD", period);
            DataTable preperiod = sql.Run();

            queue.AddBold("Employee Timesheet");
            queue.Add("From " + DATSEngineeringCore.getPeriodStart(int.Parse(period)).ToString("d") + " to " + DATSEngineeringCore.getPeriodEnd(int.Parse(period)).ToString("d"), 350);
            queue.Add("Period:", 640);
            queue.Add(period, 740);
            queue.AddLine();
            queue.Add("Employee:");
            queue.Add(Oracle.Run("select YAALPH from CRPDTA.F060116 where YAAN8=" + employeeID.ToString()).Rows[0]["YAALPH"].ToString(), 100);
            queue.Add("Employee ID:", 640);
            queue.Add(employeeID.ToString(), 740);
            queue.AddLine();
            queue.Add("Printed:");
            queue.Add(DateTime.Now.ToString(), 100);
            queue.Add("Department:", 640);
            queue.Add(DATSEngineeringSQL.Run("select da.departmentid from users u join departmentassociations da on u.userid = da.userid where u.employeeid=" + employeeID).Rows.Count > 1 ? "Multiple" : DATSEngineeringSQL.Run("select d.department from department d join departmentassociations da on d.departmentid = da.departmentid join users u on u.userid = da.userid where u.employeeid = " + employeeID).Rows[0][0].ToString(), 740);
            queue.AddLine();
            queue.AddDivider();

            queue.AddBold("Week 1");
            queue.AddLine();
            queue.AddBold("Date Worked", 10);
            queue.AddBold("Hours", 118);
            queue.AddBold("Pay Type", 178);
            queue.AddBold("Work Order", 283);
            queue.AddBold("Description", 353);
            queue.AddBold("Lump Sum", 525);
            queue.AddBold("Approved", 615);
            queue.AddLine();

            double week1Sub = 0;
            double lumpSumTotal = 0;

            for (int i = 0; i < week1.Rows.Count; i++)
            {
                week1Sub += double.Parse(week1.Rows[i]["hours"].ToString());
                lumpSumTotal += double.Parse(week1.Rows[i]["lumpsum"].ToString());

                queue.Add(DateTime.Parse(week1.Rows[i]["dateworked"].ToString()).ToString("yyyy-MM-dd ddd"), 10);
                queue.Add(week1.Rows[i]["hours"].ToString(), 118);
                queue.Add(week1.Rows[i]["description"].ToString(), 178);
                queue.Add(week1.Rows[i]["workorder"].ToString(), 283);
                queue.Add(week1.Rows[i]["workorder"].ToString() != "" ? Oracle.Run("select wadl01 from CRPDTA.f4801 where wadoco=" + week1.Rows[i]["workorder"].ToString()).Rows[0][0].ToString() : "", 353);
                queue.Add(((int)double.Parse(week1.Rows[i]["lumpsum"].ToString())) == 0 ? "" : "$" + ((int)double.Parse(week1.Rows[i]["lumpsum"].ToString())), 525);
                queue.Add(week1.Rows[i]["recordlocked"].ToString() == "True" ? "Yes" : "No", 615);
                queue.AddLine();
            }
            double week1LumpSumTotal = lumpSumTotal;

            queue.AddBold("Week 1 sub-total", 10);
            queue.AddBold(week1Sub.ToString(), 118);
            queue.AddBold(string.Format("${0:N2}", lumpSumTotal), 525);
            queue.AddLine();
            queue.AddDivider();

            queue.AddBold("Week 2");
            queue.AddLine();
            queue.AddBold("Date Worked", 10);
            queue.AddBold("Hours", 118);
            queue.AddBold("Pay Type", 178);
            queue.AddBold("Work Order", 283);
            queue.AddBold("Description", 353);
            queue.AddBold("Lump Sum", 525);
            queue.AddBold("Approved", 615);
            queue.AddLine();

            double week2Sub = 0;

            for (int i = 0; i < week2.Rows.Count; i++)
            {
                week2Sub += double.Parse(week2.Rows[i]["hours"].ToString());
                lumpSumTotal += double.Parse(week2.Rows[i]["lumpsum"].ToString());

                queue.Add(DateTime.Parse(week2.Rows[i]["dateworked"].ToString()).ToString("yyyy-MM-dd ddd"), 10);
                queue.Add(week2.Rows[i]["hours"].ToString(), 118);
                queue.Add(week2.Rows[i]["description"].ToString(), 178);
                queue.Add(week2.Rows[i]["workorder"].ToString(), 283);
                queue.Add(week2.Rows[i]["workorder"].ToString() != "" ? Oracle.Run("select wadl01 from CRPDTA.f4801 where wadoco=" + week2.Rows[i]["workorder"].ToString()).Rows[0][0].ToString() : "", 353);
                queue.Add(((int)double.Parse(week2.Rows[i]["lumpsum"].ToString())) == 0 ? "" : "$" + ((int)double.Parse(week2.Rows[i]["lumpsum"].ToString())), 525);
                queue.Add(week2.Rows[i]["recordlocked"].ToString() == "True" ? "Yes" : "No", 615);
                queue.AddLine();
            }

            queue.AddBold("Week 2 sub-total", 10);
            queue.AddBold(week2Sub.ToString(), 118);
            queue.AddBold(string.Format("${0:N2}", lumpSumTotal - week1LumpSumTotal), 525);
            queue.AddLine();
            queue.AddDivider();

            queue.AddBold(string.Format("${0:N2}", lumpSumTotal), 525);
            queue.AddLine();

            for (int i = 0; i < week1PayTypes.Rows.Count; i++)
            {
                queue.Add("Week 1 " + week1PayTypes.Rows[i]["description"].ToString());
                queue.Add(week1PayTypes.Rows[i]["hours"].ToString(), 150);
                queue.AddLine();
            }

            queue.Add("    Week 1 sub-total");
            queue.AddBold(week1Sub.ToString(), 150);
            queue.AddLine();
            queue.AddLine();

            for (int i = 0; i < week2PayTypes.Rows.Count; i++)
            {
                queue.Add("Week 2 " + week2PayTypes.Rows[i]["description"].ToString());
                queue.Add(week2PayTypes.Rows[i]["hours"].ToString(), 150);
                queue.AddLine();
            }

            queue.Add("    Week 2 sub-total");
            queue.AddBold(week2Sub.ToString(), 150);
            queue.AddLine();
            queue.AddLine();

            queue.Add("    Period " + period + " total");
            queue.AddBold((week1Sub + week2Sub).ToString(), 150);
            queue.AddLine();
            queue.AddDivider();

            if (preperiod.Rows.Count > 0)
            {
                queue.AddLine();
                queue.AddBold("Un-Exported Hours form Previous Employee Time Sheets");
                queue.AddLine();
                queue.AddLine();

                lumpSumTotal = 0;
                double preperiodSub = 0;

                for (int i = 0; i < preperiod.Rows.Count; i++)
                {
                    preperiodSub += double.Parse(preperiod.Rows[i]["hours"].ToString());
                    lumpSumTotal += double.Parse(preperiod.Rows[i]["lumpsum"].ToString());

                    queue.Add(DateTime.Parse(preperiod.Rows[i]["dateworked"].ToString()).ToString("yyyy-MM-dd ddd"), 10);
                    queue.Add(preperiod.Rows[i]["hours"].ToString(), 118);
                    queue.Add(preperiod.Rows[i]["description"].ToString(), 178);
                    queue.Add(preperiod.Rows[i]["workorder"].ToString(), 283);
                    queue.Add(preperiod.Rows[i]["workorder"].ToString() != "" ? Oracle.Run("select wadl01 from CRPDTA.f4801 where wadoco=" + preperiod.Rows[i]["workorder"].ToString()).Rows[0][0].ToString() : "", 353);
                    queue.Add(((int)double.Parse(preperiod.Rows[i]["lumpsum"].ToString())) == 0 ? "" : "$" + ((int)double.Parse(preperiod.Rows[i]["lumpsum"].ToString())), 525);
                    queue.Add(preperiod.Rows[i]["recordlocked"].ToString() == "True" ? "Yes" : "No", 615);
                    queue.AddLine();
                }

                queue.AddBold(preperiodSub.ToString(), 118);
                queue.AddBold(string.Format("${0:N2}", lumpSumTotal), 525);
                queue.AddLine();
                queue.AddLine();
            }
            queue.AddPage();

            queue.Print();
        }

        private void selectSpecificDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void paychequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            Oracle ora = new Oracle("select YUCKCN, YUPPED from CRPDTA.F06156 where YUAN8 = @EMPID group by YUCKCN, YUPPED");
//            ora.AddParameter("@EMPID", DATSCore.getEmpID(DATSCore.getUsername()));
//            DataTable dt = ora.Run();

//            FindPaycheque fpc = new FindPaycheque(dt);
//            fpc.ShowDialog();

//            string chequeNumber = fpc.number;

//            if (fpc.number != "")
//            {
//                ora = new Oracle(@"
//select
//Y8DL01 as "" "",
//to_char(Y8HRW/100, '999,999.99') as ""HRS"",
//to_char(Y8SHRT/1000, '999,999.999') as ""Rate"",
//to_char(Y8GPAY/100, '999,999.99') as ""Current"",
//to_char(Y8YTD/100, '999,999.99') as ""Year to Date"",
//Y8DL02 as ""  "",
//to_char(Y8SCUR/100, '999,999.99') as ""Current "",
//to_char(Y8YTDG/100, '999,999.99') as ""Year to Date ""

//from CRPDTA.F07186

//where Y8CKCN = @CN

//order by Y8STLN");
//                ora.AddParameter("@CN", chequeNumber);
//                dt = ora.Run();

//                DataTable dtCloned = dt.Clone();
//                for (int i = 0; i < dt.Columns.Count; i++)
//                {
//                    dtCloned.Columns[i].DataType = typeof(string);
//                }

//                foreach (DataRow row in dt.Rows)
//                {
//                    dtCloned.ImportRow(row);
//                }

//                double totalHours = 0;
//                double totalCurrent = 0;
//                double totalCurrent2 = 0;
//                double total = 0;

//                for (int r = 0; r < dtCloned.Rows.Count; r++)
//                {
//                    for (int c = 0; c < dtCloned.Columns.Count; c++)
//                    {
//                        if (dtCloned.Rows[r][c].ToString() == "0" || dtCloned.Rows[r][c].ToString().Trim() == ".00" || dtCloned.Rows[r][c].ToString().Trim() == ".000")
//                            dtCloned.Rows[r][c] = "";

//                        if (dtCloned.Rows[r][c].ToString().Trim() == "Gross Wages")
//                            dtCloned.Rows[r][c] = "----------- Gross -----------";

//                        if (dtCloned.Rows[r][c].ToString().Trim() == "Bkd OT @ Reg"
//                            || dtCloned.Rows[r][c].ToString().Trim() == "Bk $ Rev"
//                            || dtCloned.Rows[r][c].ToString().Trim() == "Bkd OT @ 1.5")
//                        {
//                            for (int x = 0; x < dtCloned.Columns.Count; x++)
//                                dtCloned.Rows[r][x] = "";
//                        }
//                    }

//                    if (dtCloned.Rows[r][1].ToString() != "")
//                        totalHours += double.Parse(dtCloned.Rows[r][1].ToString());

//                    if (dtCloned.Rows[r][3].ToString() != "")
//                        totalCurrent += double.Parse(dtCloned.Rows[r][3].ToString().Replace('$', ' ').Trim());

//                    if (dtCloned.Rows[r][6].ToString() != "")
//                        totalCurrent2 += double.Parse(dtCloned.Rows[r][6].ToString().Replace('$', ' ').Trim());
//                }

//                totalCurrent2 -= double.Parse(dtCloned.Rows[0][6].ToString().Replace('$', ' ').Trim());
//                total = totalCurrent - totalCurrent2;

//                string[] temp = { };

//                dtCloned.Rows.Add(temp);
//                dtCloned.Rows.Add(temp);
//                dtCloned.Rows.Add(temp);

//                //string[] temp2 = { "* Gross", totalHours.ToString(), "", totalCurrent.ToString(), "", "* Deductions", totalCurrent2.ToString(), "* Net " + total };

//                //dtCloned.Rows.Add(temp2);
//                //            sql = new DATSEngineeringSQL(@"SELECT d.Department as Department, u.USERNAME as Username, u.EMPLOYEEID as 'Employee ID',
//                //t.PayType as 'Pay Code', p.Description as 'Pay Type', t.hours as Hours, t.DateWorked as 'Date Worked'
//                //  FROM [DATS].[dbo].Users u
//                //  join DATS.dbo.DepartmentAssociations da on da.UserID = u.USERID
//                //  join DATS.dbo.Department d on d.DepartmentID = da.DepartmentID
//                //  join DATS.dbo.timesheetdetail t on u.EMPLOYEEID = t.EmployeeID
//                //  join DATS.dbo.PayCodes p on p.PayType = t.PayType
//                //  where Period=@PERIOD and p.AbsYN <> 0
//                //  and d.departmentid in (" + departmentSpread + @")
//                //  order by t.DateWorked, d.Department, u.USERNAME");
//                //            sql.AddParameter("@PERIOD", DATSCore.getPeriod(DateTime.Now));
//                //            dt = sql.Run();

//                ora = new Oracle(@"select
//YAALPH,
//YUAN8,
//YUMAIL,
//YUDOCM,
//YUCKD,
//YUPPED,
//to_char(YUHRW/100, '999,999.99') as YUHRW,
//to_char(sum(YUGPAY)/100, '999,999.99') as YUGPAY,
//to_char(sum((YUGTXW+YUGDED))/100, '999,999.99') as DED,
//to_char(sum(YUNPAY)/100, '999,999.99') as YUNPAY
//from PRODDTA.F06156
//join PRODDTA.F060116 on PRODDTA.F06156.YUAN8 = PRODDTA.F060116.YAAN8
//where YUCKCN=@CHEQUENO
//group by YAALPH, YUAN8, YUMAIL, YUDOCM, YUCKD, YUPPED, YUHRW");
//                ora.AddParameter("@CHEQUENO", chequeNumber);
//                DataTable dt2 = ora.Run();

//                ReportPaycheque rpt = new ReportPaycheque("Paycheque", dtCloned, dt2, chequeNumber);
//                rpt.ShowDialog();
//            }
        }

        private void absencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//            string departmentSpread = "";
//            DATSEngineeringSQL sql = null;
//            DataTable dt = null;

//            FindPeriod fp = new FindPeriod();
//            fp.ShowDialog();
//            string period = fp.period;

//            if (period != "")
//            {
//                if (!DATSCore.isAdmin(DATSCore.getUsername()))
//                {
//                    sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
//                    sql.AddParameter("@USERNAME", DATSCore.getUsername());
//                    dt = sql.Run();

//                    departmentSpread = dt.Rows[0][0].ToString();


//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        departmentSpread += ", " + dt.Rows[i][0].ToString();
//                }
//                else
//                {
//                    dt = DATSEngineeringSQL.Run("select departmentid from department");

//                    departmentSpread = dt.Rows[0][0].ToString();


//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        departmentSpread += ", " + dt.Rows[i][0].ToString();
//                }

//                sql = new DATSEngineeringSQL(@"SELECT d.Department as Department, u.USERNAME as Username, u.EMPLOYEEID as 'Employee ID',
//t.PayType as 'Pay Code', p.Description as 'Pay Type', t.hours as Hours, t.DateWorked as 'Date Worked'
//  FROM [DATS].[dbo].Users u
//  join DATS.dbo.DepartmentAssociations da on da.UserID = u.USERID
//  join DATS.dbo.Department d on d.DepartmentID = da.DepartmentID
//  join DATS.dbo.timesheetdetail t on u.EMPLOYEEID = t.EmployeeID
//  join DATS.dbo.PayCodes p on p.PayType = t.PayType
//  where Period=@PERIOD and p.AbsYN <> 0
//  and d.departmentid in (" + departmentSpread + @")
//  and u.active=1
//  and t.paytype <> 0
//  order by t.DateWorked, d.Department, u.USERNAME");
//                sql.AddParameter("@PERIOD", period);
//                dt = sql.Run();

//                Report rpt = new Report("Absence Report", dt);
//                rpt.Show();
//            }
        }

        private void closedWorkOrdersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//            string departmentSpread = "";
//            DATSEngineeringSQL sql = null;
//            DataTable dt = null;

//            FindPeriod fp = new FindPeriod();
//            fp.ShowDialog();
//            string period = fp.period;

//            if (period != "")
//            {
//                if (!DATSCore.isAdmin(DATSCore.getUsername()))
//                {
//                    sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
//                    sql.AddParameter("@USERNAME", DATSCore.getUsername());
//                    dt = sql.Run();

//                    departmentSpread = dt.Rows[0][0].ToString();


//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        departmentSpread += ", " + dt.Rows[i][0].ToString();
//                }
//                else
//                {
//                    dt = DATSEngineeringSQL.Run("select departmentid from department");

//                    departmentSpread = dt.Rows[0][0].ToString();


//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        departmentSpread += ", " + dt.Rows[i][0].ToString();
//                }

//                dt = Oracle.Run("select WADOCO from PRODDTA.F4801 where WASRST = '99'");
//                string workorderSpread = "";

//                if (dt.Rows.Count > 1)
//                {
//                    workorderSpread = dt.Rows[0][0].ToString();
//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        workorderSpread += ", " + dt.Rows[i][0].ToString();
//                }

//                sql = new DATSEngineeringSQL(@"select u.username as Employee, Hours, dateworked as 'Date Worked', WorkOrder as 'Work Order' from TimeSheetDetail t
//join Users u on t.EmployeeID = u.EMPLOYEEID
//join DepartmentAssociations da on u.USERID = da.UserID
//join Department d on d.DepartmentID = da.DepartmentID

//where
//t.WorkOrder <> 0
//and u.active = 1
//and t.Period = @PERIOD
//and t.WorkOrder is not null
//and d.DepartmentID in (" + departmentSpread + @")
//and t.workorder in (" + workorderSpread + ") order by dateworked");
//                sql.AddParameter("@PERIOD", period);
//                dt = sql.Run();

//                Report rpt = new Report("Closed Work Order Report", dt);
//                rpt.Show();
//            }
        }

        private void notApprovedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
  //          string departmentSpread = "";
  //          DATSEngineeringSQL sql = null;
  //          DataTable dt = null;

  //          FindPeriod fp = new FindPeriod();
  //          fp.ShowDialog();
  //          string period = fp.period;

  //          if (period != "")
  //          {
  //              if (!DATSCore.isAdmin(DATSCore.getUsername()))
  //              {
  //                  sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
  //                  sql.AddParameter("@USERNAME", DATSCore.getUsername());
  //                  dt = sql.Run();

  //                  departmentSpread = dt.Rows[0][0].ToString();


  //                  for (int i = 1; i < dt.Rows.Count; i++)
  //                      departmentSpread += ", " + dt.Rows[i][0].ToString();
  //              }
  //              else
  //              {
  //                  dt = DATSEngineeringSQL.Run("select departmentid from department");

  //                  departmentSpread = dt.Rows[0][0].ToString();


  //                  for (int i = 1; i < dt.Rows.Count; i++)
  //                      departmentSpread += ", " + dt.Rows[i][0].ToString();
  //              }

  //              sql = new DATSEngineeringSQL(@"SELECT d.Department as Department, u.USERNAME as Username, u.EMPLOYEEID as 'Employee ID', sum(t.Hours) as 'Hours Unapproved'
  //FROM [DATS].[dbo].Users u
  //join DATS.dbo.DepartmentAssociations da on da.UserID = u.USERID
  //join DATS.dbo.Department d on d.DepartmentID = da.DepartmentID
  //join DATS.dbo.timesheetdetail t on u.EMPLOYEEID = t.EmployeeID
  //where t.RecordLocked = 'False'
  //and Period=@PERIOD
  //and u.active = 1
  //and t.paytype <> 0
  //and d.departmentid in (" + departmentSpread + @")
  //group by d.Department, u.USERNAME, u.EMPLOYEEID
  //order by d.Department, u.USERNAME");
  //              sql.AddParameter("@PERIOD", period);
  //              dt = sql.Run();

  //              Report rpt = new Report("Not Approved Report", dt);
  //              rpt.Show();
  //          }
        }

        private void notExportedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
  //          string departmentSpread = "";
  //          DATSEngineeringSQL sql = null;
  //          DataTable dt = null;

  //          FindPeriod fp = new FindPeriod();
  //          fp.ShowDialog();
  //          string period = fp.period;

  //          if (period != "")
  //          {
  //              if (!DATSCore.isAdmin(DATSCore.getUsername()))
  //              {
  //                  sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
  //                  sql.AddParameter("@USERNAME", DATSCore.getUsername());
  //                  dt = sql.Run();

  //                  departmentSpread = dt.Rows[0][0].ToString();


  //                  for (int i = 1; i < dt.Rows.Count; i++)
  //                      departmentSpread += ", " + dt.Rows[i][0].ToString();
  //              }
  //              else
  //              {
  //                  dt = DATSEngineeringSQL.Run("select departmentid from department");

  //                  departmentSpread = dt.Rows[0][0].ToString();


  //                  for (int i = 1; i < dt.Rows.Count; i++)
  //                      departmentSpread += ", " + dt.Rows[i][0].ToString();
  //              }

  //              sql = new DATSEngineeringSQL(@"SELECT min(d.Department) as 'Department', u.USERNAME, u.EMPLOYEEID, t.DateWorked, p.Description, t.Hours, t.WorkOrder, t.LumpSum, t.RecordLocked as 'Approved', t.Exported as 'Exported'
  //FROM [DATS].[dbo].Users u
  //join DATS.dbo.DepartmentAssociations da on da.UserID = u.USERID
  //join DATS.dbo.Department d on d.DepartmentID = da.DepartmentID
  //join DATS.dbo.timesheetdetail t on u.EMPLOYEEID = t.EmployeeID
  //join DATS.dbo.PayCodes p on t.PayType = p.PayType
  //where d.departmentid in (" + departmentSpread + @")
  //and Period<=@PERIOD
  //and exported=0
  //and t.paytype<>0
  //group by USERNAME, u.EmployeeID, DateWorked, p.Description, t.Hours, t.WorkOrder, t.LumpSum, t.RecordLocked, t.Exported
  //order by min(d.Department), u.USERNAME");
  //              sql.AddParameter("@PERIOD", period);
  //              dt = sql.Run();

  //              Report rpt = new Report("Not Exported Report", dt);
  //              rpt.Show();
  //          }
        }

        private void paytypeSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            DATSEngineeringSQL sql = new DATSEngineeringSQL(@"select p.Description as 'Pay Type', sum(hours) as 'Hours this year' from TimeSheetDetail t
//join Users u on t.EmployeeID = u.EMPLOYEEID
//join PayCodes p on t.PayType = p.PayType

//where u.displayname = @USERNAME
//and DateWorked >= @DATE

//group by p.Description

//order by p.Description");
//            sql.AddParameter("@USERNAME", DATSCore.getUsername());
//            sql.AddParameter("@DATE", new DateTime(DateTime.Today.Year, 1, 1));
//            DataTable dt = sql.Run();

//            Report rpt = new Report("Paytype Summary", dt);
//            rpt.ShowDialog();
        }

        private void prePeriodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
  //          string departmentSpread = "";
  //          DATSEngineeringSQL sql = null;
  //          DataTable dt = null;

  //          FindPeriod fp = new FindPeriod();
  //          fp.ShowDialog();
  //          string period = fp.period;

  //          if (period != "")
  //          {
  //              if (!DATSCore.isAdmin(DATSCore.getUsername()))
  //              {
  //                  sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
  //                  sql.AddParameter("@USERNAME", DATSCore.getUsername());
  //                  dt = sql.Run();

  //                  departmentSpread = dt.Rows[0][0].ToString();


  //                  for (int i = 1; i < dt.Rows.Count; i++)
  //                      departmentSpread += ", " + dt.Rows[i][0].ToString();
  //              }
  //              else
  //              {
  //                  dt = DATSEngineeringSQL.Run("select departmentid from department");

  //                  departmentSpread = dt.Rows[0][0].ToString();


  //                  for (int i = 1; i < dt.Rows.Count; i++)
  //                      departmentSpread += ", " + dt.Rows[i][0].ToString();
  //              }

  //              sql = new DATSEngineeringSQL(@"SELECT min(d.Department) as 'Department', u.USERNAME, u.EMPLOYEEID, convert(varchar(50), t.DateWorked) as DateWorked, p.Description, t.Hours, t.WorkOrder, t.LumpSum, t.RecordLocked as 'Approved', t.Exported as 'Exported'
  //FROM [DATS].[dbo].Users u
  //join DATS.dbo.DepartmentAssociations da on da.UserID = u.USERID
  //join DATS.dbo.Department d on d.DepartmentID = da.DepartmentID
  //join DATS.dbo.timesheetdetail t on u.EMPLOYEEID = t.EmployeeID
  //join DATS.dbo.PayCodes p on t.PayType = p.PayType
  //where d.departmentid in (" + departmentSpread + @")
  //and Period<@PERIOD
  //and exported=0
  //and p.paytype<>0
  //and u.active = 1
  //group by USERNAME, u.EmployeeID, DateWorked, p.Description, t.Hours, t.WorkOrder, t.LumpSum, t.RecordLocked, t.Exported
  //order by t.dateworked, min(d.Department), u.USERNAME");
  //              sql.AddParameter("@PERIOD", period);
  //              dt = sql.Run();

  //              for (int i = 0; i < dt.Rows.Count; i++)
  //                  dt.Rows[i]["DateWorked"] = DateTime.Parse(dt.Rows[i]["DateWorked"].ToString()).ToString("D");

  //              Report rpt = new Report("Pre-Period Report", dt);
  //              rpt.Show();
  //          }
        }

        private void summaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//            string departmentSpread = "";
//            DATSEngineeringSQL sql = null;
//            DataTable dt = null;

//            FindPeriod fp = new FindPeriod();
//            fp.ShowDialog();
//            string period = fp.period;

//            if (period != "")
//            {
//                if (!DATSCore.isAdmin(DATSCore.getUsername()))
//                {
//                    sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
//                    sql.AddParameter("@USERNAME", DATSCore.getUsername());
//                    dt = sql.Run();

//                    departmentSpread = dt.Rows[0][0].ToString();


//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        departmentSpread += ", " + dt.Rows[i][0].ToString();
//                }
//                else
//                {
//                    dt = DATSEngineeringSQL.Run("select departmentid from department");

//                    departmentSpread = dt.Rows[0][0].ToString();


//                    for (int i = 1; i < dt.Rows.Count; i++)
//                        departmentSpread += ", " + dt.Rows[i][0].ToString();
//                }

//                sql = new DATSEngineeringSQL(@"SELECT min(d.Department) as 'Department', u.USERNAME as 'Username', u.EMPLOYEEID as 'Employee ID',

//(select SUM(hours)
//from DATS.dbo.TimeSheetDetail t2
//join DATS.dbo.PayCodes p2 on t2.PayType = p2.PayType
//where t2.employeeid = min(t.EmployeeID)
//and Period=@PERIOD
//and p2.Description = 'Regular') as Regular,

//(select SUM(hours)
//from DATS.dbo.TimeSheetDetail t2
//join DATS.dbo.PayCodes p2 on t2.PayType = p2.PayType
//where t2.employeeid = min(t.EmployeeID)
//and Period=@PERIOD
//and p2.OTYN <> 0) as Overtime,

//(select SUM(hours)
//from DATS.dbo.TimeSheetDetail t2
//join DATS.dbo.PayCodes p2 on t2.PayType = p2.PayType
//where t2.employeeid = min(t.EmployeeID)
//and Period=@PERIOD
//and p2.VacYN <> 0) as Vacation,

//(select SUM(hours)
//from DATS.dbo.TimeSheetDetail t2
//join DATS.dbo.PayCodes p2 on t2.PayType = p2.PayType
//where t2.employeeid = min(t.EmployeeID)
//and Period=@PERIOD
//and p2.Description <> 'Regular' and p2.VacYN = 0 and p2.OTYN = 0) as Other,

//(select SUM(hours)
//from DATS.dbo.TimeSheetDetail t2
//join DATS.dbo.PayCodes p2 on t2.PayType = p2.PayType
//where t2.employeeid = min(t.EmployeeID)
//and Period=@PERIOD) as Total,

//(select SUM(LumpSum)
//from DATS.dbo.TimeSheetDetail t2
//join DATS.dbo.PayCodes p2 on t2.PayType = p2.PayType
//where t2.employeeid = min(t.EmployeeID)
//and Period=@PERIOD) as 'Lump Sum'

//  FROM [DATS].[dbo].Users u
//  join DATS.dbo.DepartmentAssociations da on da.UserID = u.USERID
//  join DATS.dbo.Department d on d.DepartmentID = da.DepartmentID
//  join DATS.dbo.timesheetdetail t on u.EMPLOYEEID = t.EmployeeID
//  join DATS.dbo.PayCodes p on p.PayType = t.PayType
//  where Period=@PERIOD and p.AbsYN <> 0
//  and d.departmentid in (" + departmentSpread + @")
//  and u.active = 1
//  group by u.USERNAME, u.EMPLOYEEID
//  order by department, username");
//                sql.AddParameter("@PERIOD", period);
//                dt = sql.Run();

//                Report rpt = new Report("Summary Report", dt);
//                rpt.Show();
//            }
        }

        private void summaryBreakdownToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//            string departmentSpread = "";
//            DATSEngineeringSQL sql = null;
//            DataTable dt = null;

//            FindDate fd = new FindDate("Select start date");
//            fd.ShowDialog();
//            DateTime start = fd.date;

//            if (start.Year != 1900)
//            {
//                fd = new FindDate("Select end date");
//                fd.ShowDialog();
//                DateTime end = fd.date;

//                if (end.Year != 1900)
//                {

//                    if (!DATSCore.isAdmin(DATSCore.getUsername()))
//                    {
//                        sql = new DATSEngineeringSQL("select departmentid from departmentassociations da join users u on da.userid = u.userid where u.displayname=@USERNAME");
//                        sql.AddParameter("@USERNAME", DATSCore.getUsername());
//                        dt = sql.Run();

//                        departmentSpread = dt.Rows[0][0].ToString();


//                        for (int i = 1; i < dt.Rows.Count; i++)
//                            departmentSpread += ", " + dt.Rows[i][0].ToString();
//                    }
//                    else
//                    {
//                        dt = DATSEngineeringSQL.Run("select departmentid from department");

//                        departmentSpread = dt.Rows[0][0].ToString();


//                        for (int i = 1; i < dt.Rows.Count; i++)
//                            departmentSpread += ", " + dt.Rows[i][0].ToString();
//                    }

//                    sql = new DATSEngineeringSQL(@"
//select
//min(d.Department) as 'Department',
//u.USERNAME as 'Name',
//u.EMPLOYEEID as 'Employee ID',
//p.Description as 'Pay Type',
//SUM(hours) / count(distinct d.departmentid) as 'Sum of Hours',
//SUM(lumpsum) / count(distinct d.departmentid) as 'Lump Sum'

//from users u
//join TimeSheetDetail t on t.EmployeeID = u.EMPLOYEEID
//join PayCodes p on t.PayType = p.PayType
//join DepartmentAssociations da on u.USERID = da.UserID
//join Department d on da.DepartmentID = d.DepartmentID

//where d.departmentid in (" + departmentSpread + @")
//and t.dateworked >= @START
//and t.dateworked <= @END
//and u.active = 1
//and t.paytype <> 0

//group by
//u.USERNAME,
//u.EMPLOYEEID,
//p.description

//order by min(d.Department)
//");
//                    sql.AddParameter("@START", start);
//                    sql.AddParameter("@END", end);
//                    dt = sql.Run();

//                    Report rpt = new Report("Summary Breakdown Report", dt);
//                    rpt.Show();
//                }
//            }
        }

        private static int exportToJDE(string type)
        {
            DATSEngPayrollExport pe = new DATSEngPayrollExport();
            pe.ShowDialog();

            return pe.batchID;
        }

        private void sendDataToJDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to export hourly timesheet data to JDE." + Environment.NewLine + "Would you like to proceed?", "Export to JDE", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int batchID = exportToJDE("H");
            }
        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ViewAccounts()).ShowDialog();
        }

        private void manageWorkOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GetDepartment gd = new GetDepartment();
            //gd.ShowDialog();

            //if (!gd.quit)
            //    (new ManageWorkOrders(gd.deptID)).ShowDialog();
        }

        private void loginHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ViewHistory vh = new ViewHistory();
            //vh.ShowDialog();
        }

        private void printTimesheetsToolStripMenuItem_Click(object sender, EventArgs e2)
        {
//            string section = Message.Show("Timesheet Report", "Which section would you like to print?", "Parks && Facilities", "Operations", "IT");

//            if (section != "")
//            {
//                FindPeriod fp = new FindPeriod();
//                fp.ShowDialog();

//                if (fp.period != "")
//                {

//                    string departmentSpread = "";

//                    if (section == "Parks && Facilities")
//                        departmentSpread = "2, 5, 12, 14, 15, 16, 17, 18";
//                    else if (section == "Operations")
//                        departmentSpread = "1, 3, 4, 6, 7";
//                    else if (section == "IT")
//                        departmentSpread = "13";


//                    DATSEngineeringSQL sql = new DATSEngineeringSQL(@"
//select u.employeeid from users u
//join departmentassociations da on u.userid = da.userid
//where da.departmentid in (" + departmentSpread + @")
//and u.active = 1 and u.emptype <> 'S'
//group by u.username, u.employeeid");
//                    DataTable employees = sql.Run();

//                    string empIDSpread = "";

//                    for (int i = 0; i < employees.Rows.Count; i++)
//                    {
//                        if (i == employees.Rows.Count - 1)
//                            empIDSpread += employees.Rows[i]["employeeid"].ToString();
//                        else
//                            empIDSpread += employees.Rows[i]["employeeid"].ToString() + ", ";
//                    }

//                    Oracle ora = new Oracle("select YAALPH as username, YAAN8 as employeeid from PRODDTA.F060116 where YAAN8 in (" + empIDSpread + ") order by YAALPH");
//                    employees = ora.Run();

//                    Printer queue = new Printer();

//                    for (int e = 0; e < employees.Rows.Count; e++)
//                    {
//                        sql = new DATSEngineeringSQL(@"
//select dateworked, hours, p.description, workorder, lumpsum, recordlocked
//from timesheetdetail t
//join paycodes p on t.paytype = p.paytype
//where t.employeeid = @EMPID
//and period=@PERIOD and dateworked < @DATE
//order by t.dateworked asc");
//                        sql.AddParameter("@EMPID", employees.Rows[e]["employeeid"].ToString());
//                        sql.AddParameter("@PERIOD", fp.period);
//                        sql.AddParameter("@DATE", DATSCore.getPeriodStart(int.Parse(fp.period)).AddDays(7));
//                        DataTable week1 = sql.Run();

//                        sql = new DATSEngineeringSQL(@"
//select dateworked, hours, p.description, workorder, lumpsum, recordlocked
//from timesheetdetail t
//join paycodes p on t.paytype = p.paytype
//where t.employeeid = @EMPID
//and period=@PERIOD and dateworked >= @DATE
//order by t.dateworked asc");
//                        sql.AddParameter("@EMPID", employees.Rows[e]["employeeid"].ToString());
//                        sql.AddParameter("@PERIOD", fp.period);
//                        sql.AddParameter("@DATE", DATSCore.getPeriodStart(int.Parse(fp.period)).AddDays(7));
//                        DataTable week2 = sql.Run();

//                        sql = new DATSEngineeringSQL(@"
//select p.description, sum(hours) as Hours
//from timesheetdetail t
//join paycodes p on t.paytype = p.paytype
//where t.employeeid = @EMPID
//and period=@PERIOD and dateworked < @DATE
//group by p.description, p.paytype
//order by p.paytype");
//                        sql.AddParameter("@EMPID", employees.Rows[e]["employeeid"].ToString());
//                        sql.AddParameter("@PERIOD", fp.period);
//                        sql.AddParameter("@DATE", DATSCore.getPeriodStart(int.Parse(fp.period)).AddDays(7));
//                        DataTable week1PayTypes = sql.Run();

//                        sql = new DATSEngineeringSQL(@"
//select p.description, sum(hours) as Hours
//from timesheetdetail t
//join paycodes p on t.paytype = p.paytype
//where t.employeeid = @EMPID
//and period=@PERIOD and dateworked >= @DATE
//group by p.description, p.paytype
//order by p.paytype");
//                        sql.AddParameter("@EMPID", employees.Rows[e]["employeeid"].ToString());
//                        sql.AddParameter("@PERIOD", fp.period);
//                        sql.AddParameter("@DATE", DATSCore.getPeriodStart(int.Parse(fp.period)).AddDays(7));
//                        DataTable week2PayTypes = sql.Run();

//                        sql = new DATSEngineeringSQL(@"
//select dateworked, hours, p.description, workorder, lumpsum, recordlocked
//from timesheetdetail t
//join paycodes p on t.paytype = p.paytype
//where t.employeeid = @EMPID
//and period<@PERIOD and exported=0
//and t.paytype<>0
//order by t.dateworked asc");
//                        sql.AddParameter("@EMPID", employees.Rows[e]["employeeid"].ToString());
//                        sql.AddParameter("@PERIOD", fp.period);
//                        DataTable preperiod = sql.Run();

//                        queue.AddBold("Employee Timesheet");
//                        queue.Add("From " + DATSCore.getPeriodStart(int.Parse(fp.period)).ToString("d") + " to " + DATSCore.getPeriodEnd(int.Parse(fp.period)).ToString("d"), 350);
//                        queue.Add("Period:", 640);
//                        queue.Add(fp.period, 740);
//                        queue.AddLine();
//                        queue.Add("Employee:");
//                        queue.Add(Oracle.Run("select YAALPH from PRODDTA.F060116 where YAAN8=" + employees.Rows[e]["employeeid"].ToString()).Rows[0]["YAALPH"].ToString(), 100);
//                        queue.Add("Employee ID:", 640);
//                        queue.Add(employees.Rows[e]["employeeid"].ToString(), 740);
//                        queue.AddLine();
//                        queue.Add("Printed:");
//                        queue.Add(DateTime.Now.ToString(), 100);
//                        queue.Add("Department:", 640);
//                        queue.Add(DATSEngineeringSQL.Run("select da.departmentid from users u join departmentassociations da on u.userid = da.userid where u.employeeid=" + employees.Rows[e]["employeeid"].ToString()).Rows.Count > 1 ? "Multiple" : DATSEngineeringSQL.Run("select d.department from department d join departmentassociations da on d.departmentid = da.departmentid join users u on u.userid = da.userid where u.employeeid = " + employees.Rows[e]["employeeid"].ToString()).Rows[0][0].ToString(), 740);
//                        queue.AddLine();
//                        queue.AddDivider();

//                        queue.AddBold("Week 1");
//                        queue.AddLine();
//                        queue.AddBold("Date Worked", 10);
//                        queue.AddBold("Hours", 118);
//                        queue.AddBold("Pay Type", 178);
//                        queue.AddBold("Work Order", 283);
//                        queue.AddBold("Description", 353);
//                        queue.AddBold("Lump Sum", 525);
//                        queue.AddBold("Approved", 615);
//                        queue.AddLine();

//                        double week1Sub = 0;
//                        double lumpSumTotal = 0;

//                        for (int i = 0; i < week1.Rows.Count; i++)
//                        {
//                            week1Sub += double.Parse(week1.Rows[i]["hours"].ToString());
//                            lumpSumTotal += double.Parse(week1.Rows[i]["lumpsum"].ToString());

//                            queue.Add(DateTime.Parse(week1.Rows[i]["dateworked"].ToString()).ToString("yyyy-MM-dd ddd"), 10);
//                            queue.Add(week1.Rows[i]["hours"].ToString(), 118);
//                            queue.Add(week1.Rows[i]["description"].ToString(), 178);
//                            queue.Add(week1.Rows[i]["workorder"].ToString(), 283);
//                            queue.Add(week1.Rows[i]["workorder"].ToString() != "" ? Oracle.Run("select wadl01 from proddta.f4801 where wadoco=" + week1.Rows[i]["workorder"].ToString()).Rows[0][0].ToString() : "", 353);
//                            queue.Add(((int)double.Parse(week1.Rows[i]["lumpsum"].ToString())) == 0 ? "" : "$" + ((int)double.Parse(week1.Rows[i]["lumpsum"].ToString())), 525);
//                            queue.Add(week1.Rows[i]["recordlocked"].ToString() == "True" ? "Yes" : "No", 615);
//                            queue.AddLine();
//                        }
//                        double week1LumpSumTotal = lumpSumTotal;

//                        queue.AddBold("Week 1 sub-total", 10);
//                        queue.AddBold(week1Sub.ToString(), 118);
//                        queue.AddBold(string.Format("${0:N2}", lumpSumTotal), 525);
//                        queue.AddLine();
//                        queue.AddDivider();

//                        queue.AddBold("Week 2");
//                        queue.AddLine();
//                        queue.AddBold("Date Worked", 10);
//                        queue.AddBold("Hours", 118);
//                        queue.AddBold("Pay Type", 178);
//                        queue.AddBold("Work Order", 283);
//                        queue.AddBold("Description", 353);
//                        queue.AddBold("Lump Sum", 525);
//                        queue.AddBold("Approved", 615);
//                        queue.AddLine();

//                        double week2Sub = 0;

//                        for (int i = 0; i < week2.Rows.Count; i++)
//                        {
//                            week2Sub += double.Parse(week2.Rows[i]["hours"].ToString());
//                            lumpSumTotal += double.Parse(week2.Rows[i]["lumpsum"].ToString());

//                            queue.Add(DateTime.Parse(week2.Rows[i]["dateworked"].ToString()).ToString("yyyy-MM-dd ddd"), 10);
//                            queue.Add(week2.Rows[i]["hours"].ToString(), 118);
//                            queue.Add(week2.Rows[i]["description"].ToString(), 178);
//                            queue.Add(week2.Rows[i]["workorder"].ToString(), 283);
//                            queue.Add(week2.Rows[i]["workorder"].ToString() != "" ? Oracle.Run("select wadl01 from proddta.f4801 where wadoco=" + week2.Rows[i]["workorder"].ToString()).Rows[0][0].ToString() : "", 353);
//                            queue.Add(((int)double.Parse(week2.Rows[i]["lumpsum"].ToString())) == 0 ? "" : "$" + ((int)double.Parse(week2.Rows[i]["lumpsum"].ToString())), 525);
//                            queue.Add(week2.Rows[i]["recordlocked"].ToString() == "True" ? "Yes" : "No", 615);
//                            queue.AddLine();
//                        }

//                        queue.AddBold("Week 2 sub-total", 10);
//                        queue.AddBold(week2Sub.ToString(), 118);
//                        queue.AddBold(string.Format("${0:N2}", lumpSumTotal - week1LumpSumTotal), 525);
//                        queue.AddLine();
//                        queue.AddDivider();

//                        queue.AddBold(string.Format("${0:N2}", lumpSumTotal), 525);
//                        queue.AddLine();

//                        for (int i = 0; i < week1PayTypes.Rows.Count; i++)
//                        {
//                            queue.Add("Week 1 " + week1PayTypes.Rows[i]["description"].ToString());
//                            queue.Add(week1PayTypes.Rows[i]["hours"].ToString(), 150);
//                            queue.AddLine();
//                        }

//                        queue.Add("    Week 1 sub-total");
//                        queue.AddBold(week1Sub.ToString(), 150);
//                        queue.AddLine();
//                        queue.AddLine();

//                        for (int i = 0; i < week2PayTypes.Rows.Count; i++)
//                        {
//                            queue.Add("Week 2 " + week2PayTypes.Rows[i]["description"].ToString());
//                            queue.Add(week2PayTypes.Rows[i]["hours"].ToString(), 150);
//                            queue.AddLine();
//                        }

//                        queue.Add("    Week 2 sub-total");
//                        queue.AddBold(week2Sub.ToString(), 150);
//                        queue.AddLine();
//                        queue.AddLine();

//                        queue.Add("    Period " + fp.period + " total");
//                        queue.AddBold((week1Sub + week2Sub).ToString(), 150);
//                        queue.AddLine();
//                        queue.AddDivider();

//                        if (preperiod.Rows.Count > 0)
//                        {
//                            queue.AddLine();
//                            queue.AddBold("Un-Exported Hours form Previous Employee Time Sheets");
//                            queue.AddLine();
//                            queue.AddLine();

//                            lumpSumTotal = 0;
//                            double preperiodSub = 0;

//                            for (int i = 0; i < preperiod.Rows.Count; i++)
//                            {
//                                preperiodSub += double.Parse(preperiod.Rows[i]["hours"].ToString());
//                                lumpSumTotal += double.Parse(preperiod.Rows[i]["lumpsum"].ToString());

//                                queue.Add(DateTime.Parse(preperiod.Rows[i]["dateworked"].ToString()).ToString("yyyy-MM-dd ddd"), 10);
//                                queue.Add(preperiod.Rows[i]["hours"].ToString(), 118);
//                                queue.Add(preperiod.Rows[i]["description"].ToString(), 178);
//                                queue.Add(preperiod.Rows[i]["workorder"].ToString(), 283);
//                                queue.Add(preperiod.Rows[i]["workorder"].ToString() != "" ? Oracle.Run("select wadl01 from proddta.f4801 where wadoco=" + preperiod.Rows[i]["workorder"].ToString()).Rows[0][0].ToString() : "", 353);
//                                queue.Add(((int)double.Parse(preperiod.Rows[i]["lumpsum"].ToString())) == 0 ? "" : "$" + ((int)double.Parse(preperiod.Rows[i]["lumpsum"].ToString())), 525);
//                                queue.Add(preperiod.Rows[i]["recordlocked"].ToString() == "True" ? "Yes" : "No", 615);
//                                queue.AddLine();
//                            }

//                            queue.AddBold(preperiodSub.ToString(), 118);
//                            queue.AddBold(string.Format("${0:N2}", lumpSumTotal), 525);
//                            queue.AddLine();
//                            queue.AddLine();
//                        }

//                        queue.AddPage();
//                    }

//                    queue.Print();

//                    modifyEmailPayrollToolStripMenuItem_Click(null, null);
//                }
//            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > 0)
                comboBox3.SelectedIndex--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex < comboBox3.Items.Count - 1)
                comboBox3.SelectedIndex++;
        }

        private void vacationRemainingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bankedTimeRemainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private double gev(int paytype)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select sum(t.hours) from timesheetdetail t join users u on t.employeeid = u.employeeid where u.displayname=@NAME and t.paytype=@PAY and t.dateworked >= @START and t.dateworked < @END");
            sql.AddParameter("@NAME", getUsername());
            sql.AddParameter("@PAY", paytype);
            sql.AddParameter("@START", new DateTime(DateTime.Now.Year, 1, 1));
            sql.AddParameter("@END", new DateTime(DateTime.Now.Year + 1, 1, 1));

            double k = 0;
            double.TryParse(sql.Run().Rows[0][0].ToString(), out k);

            return k;
        }

        private double gev(int paytype, string name)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select sum(t.hours) from timesheetdetail t join users u on t.employeeid = u.employeeid where u.displayname=@NAME and t.paytype=@PAY and t.dateworked >= @START and t.dateworked < @END");
            sql.AddParameter("@NAME", name);
            sql.AddParameter("@PAY", paytype);
            sql.AddParameter("@START", new DateTime(DateTime.Now.Year, 1, 1));
            sql.AddParameter("@END", new DateTime(DateTime.Now.Year + 1, 1, 1));

            double k = 0;
            double.TryParse(sql.Run().Rows[0][0].ToString(), out k);

            return k;
        }

        private void workOrderUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            string departmentSpread = "";
//            DATSEngineeringSQL sql = null;
//            DataTable dt = null;

//            FindDate fd = new FindDate("Select start date");
//            fd.ShowDialog();
//            DateTime start = fd.date;

//            if (start.Year != 1900)
//            {
//                fd = new FindDate("Select end date");
//                fd.ShowDialog();
//                DateTime end = fd.date;

//                if (end.Year != 1900)
//                {
//                    FindWorkOrder fw = new FindWorkOrder(DATSCore.getUsername());
//                    fw.ShowDialog();

//                    if (fw.woID != null)
//                    {
//                        int woid = int.Parse(fw.woID);
//                        string wodesc = fw.woDesc;

//                        sql = new DATSEngineeringSQL(@"
//select
//TimeCardDetailID as ID,
//CreateUser as 'Created By',
//Period as 'Pay Period',
//u.DISPLAYNAME as Employee,
//DateWorked as 'Date Worked',
//p.Description as 'Pay Type',
//Hours,
//WorkOrder,
//LumpSum as 'Lump Sum',
//DateEntered as 'Date Entered',
//Reviewed as 'Reviewed',
//RecordLocked as 'Approved',
//Exported as 'Exported',
//BatchId as 'Batch ID',
//t.Description as 'Description',
//StartTime as 'Start Time',
//FinishTime as 'Finish Time'

//from TimeSheetDetail t
//join PayCodes p on t.PayType = p.PayType
//join Users u on t.EmployeeID = u.EMPLOYEEID

//where t.workorder = @WOID
//and t.dateworked >= @START
//and t.dateworked <= @END

//order by t.dateworked
//");
//                        sql.AddParameter("@WOID", woid);
//                        sql.AddParameter("@START", start);
//                        sql.AddParameter("@END", end);
//                        dt = sql.Run();

//                        Report rpt = new Report("Work Order Usage Report", dt);
//                        rpt.Show();
//                    }
//                }
//            }
        }

        private void sendDataToJDEToolStripMenuItem_Click2(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to export salary timesheet data to JDE." + Environment.NewLine + "Would you like to proceed?", "Export to JDE", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int batchID = exportToJDE("S");
            }
        }
    }
}
