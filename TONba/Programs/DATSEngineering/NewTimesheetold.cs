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
    public partial class NewTimesheetold : Form
    {
        public bool changesMade = false;
        int editingTimesheetID = 0;
        string forUser = "";

        public NewTimesheetold()
        {
            InitializeComponent();

            forUser = DATSEngineeringCore.getUsername();

            dateCalendar.SelectionStart = DateTime.Today;
            dateCalendar.SelectionEnd = DateTime.Today;

            startingSetup();
        }

        public NewTimesheetold(DateTime x)
        {
            InitializeComponent();

            forUser = DATSEngineeringCore.getUsername();

            dateCalendar.SelectionStart = x;
            dateCalendar.SelectionEnd = x;
            dateCalendar.Select();

            startingSetup();
        }

        public NewTimesheetold(string username)
        {
            InitializeComponent();

            //forDifferentUser = true;
            forUser = username;

            dateCalendar.SelectionStart = DateTime.Today;
            dateCalendar.SelectionEnd = DateTime.Today;

            startingSetup();

            this.Text = "Timesheet for " + username;
            dateCalendar.Select();
        }

        public NewTimesheetold(string username, DateTime x)
        {
            InitializeComponent();

            //forDifferentUser = true;
            forUser = username;

            dateCalendar.SelectionStart = x;
            dateCalendar.SelectionEnd = x;
            dateCalendar.Select();

            startingSetup();

            this.Text = "Timesheet for " + username;
            dateCalendar.Select();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FindWorkOrder fwo = new FindWorkOrder();
            fwo.ShowDialog();

            if (!fwo.quit)
            {
                workOrderBar.Items.Add(fwo.woID + " - " + fwo.woDesc);
                workOrderBar.SelectedIndex = workOrderBar.Items.Count - 1;
            }
        }

        public NewTimesheetold(int timesheetID) //Edit Timesheet
        {
            InitializeComponent();

            editingTimesheetID = timesheetID;
            label8.Visible = false;

            DATSEngineeringSQL sql = new DATSEngineeringSQL("select * from timesheetdetail where timecarddetailid = @ID");
            sql.AddParameter("@ID", timesheetID);
            DataTable dt = sql.Run();
            int empID = int.Parse(dt.Rows[0]["employeeid"].ToString());
            string username = DATSEngineeringCore.getUsernameFromEmpID(empID);
            forUser = username;

            startingSetup();

            dateCalendar.MaxSelectionCount = 1;
            dateCalendar.SelectionStart = DateTime.Parse(dt.Rows[0]["DateWorked"].ToString());
            dateCalendar.SelectionEnd = DateTime.Parse(dt.Rows[0]["DateWorked"].ToString());

            if (true)
            {
                workOrder = dt.Rows[0]["WorkOrder"].ToString();

                if (workOrder != "")
                {
                    Oracle ora = new Oracle("select WADL01 from CRPDTA.F4801 where WADOCO = :WO");
                    ora.AddParameter("WO", workOrder);
                    string woDesc = ora.Run().Rows[0]["WADL01"].ToString();

                    //workOrderBar.Items.Clear();
                    workOrderBar.Items.Add(workOrder + " - " + woDesc);
                    workOrderBar.SelectedIndex = workOrderBar.Items.Count - 1;
                }
            }

            this.Text = "Edit Timesheet";
            button2.Text = "Save";
            textBox1.Text = dt.Rows[0]["Description"].ToString();

            dateCalendar.Select();
        }

        public void startingSetup()
        {
            DataTable dt;
            
            //Work orders
            if (true)
            {
                //Work orders this person has used recently
                DATSEngineeringSQL sql = new DATSEngineeringSQL(
    @"SELECT
t.workorder,
Count(t.WorkOrder) AS CountOfWorkOrder

FROM TimeSheetDetail t
join Users u on u.EMPLOYEEID = t.EmployeeID

WHERE
t.DateWorked > @DATE AND
t.WorkOrder IS NOT NULL AND
u.displayname = @USERNAME

GROUP BY
t.workorder

ORDER BY Count(t.WorkOrder) DESC;
");
                sql.AddParameter("@DATE", DateTime.Now.AddMonths(-1));
                sql.AddParameter("@USERNAME", forUser);
                dt = sql.Run();

                workOrderBar.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string workorder = dt.Rows[i]["workorder"].ToString();
                    string count = dt.Rows[i]["CountOfWorkOrder"].ToString();

                    Oracle ora = new Oracle("select WADL01, WAVR01, WASRST from CRPDTA.F4801 where WADOCO = @WADOCO and WASRST<>99");
                    ora.AddParameter("@WADOCO", workorder);
                    DataTable dt2 = ora.Run();

                    if (dt2.Rows.Count > 0)
                    {
                        string description = dt2.Rows[0]["WADL01"].ToString().Trim();
                        string asset = dt2.Rows[0]["WAVR01"].ToString().Trim();

                        workOrderBar.Items.Add(workorder + " - " + description + (asset != "" ? " (" + asset + ")" : ""));
                    }
                }

                if (workOrderBar.Items.Count > 0)
                    workOrderBar.SelectedIndex = 0;
            }
        }

        string workOrder = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FindWorkOrder fwo = new FindWorkOrder();
                fwo.ShowDialog();

                if (!fwo.quit)
                {
                    if (fwo.woID != null)
                    {
                        workOrder = fwo.woID;

                        workOrderBar.Items.Clear();
                        workOrderBar.Items.Add(fwo.woID + " - " + fwo.woDesc);
                        workOrderBar.SelectedIndex = 0;
                    }
                    else
                    {
                        workOrderBar.Items.Clear();
                    }
                }
            }
            catch (TypeInitializationException)
            {
                MessageBox.Show("This component requires Oracle to be installed. Please call IT to have this done.", "Error");
            }
        }

        private bool isHoliday(DateTime date)
        {
            bool returnable = false;

            try
            {
                DataTable dt = DATSEngineeringSQL.Run("select date from holidays");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Parse(dt.Rows[i][0].ToString()) == date)
                    {
                        returnable = true;
                    }
                }
            }
            catch (Exception)
            {
                return returnable;
            }
            return returnable;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //workOrderBar.Enabled = false;
            //workOrderBar.Update();

            //button1_Click(null, null);

            //workOrderBar.Enabled = true;
            //workOrderBar.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkForErrors())
            {
                changesMade = true;

                if (isEditMode())
                    saveEdit();
                else
                    submitNew();

                this.Close();
            }
        }

        private bool checkForErrors()
        {
            bool foundErrors = false;

            if (dateCalendar.SelectionStart.Year >= 2018)
            {
                foundErrors = true;
                MessageBox.Show("This program is designed to no longer be used after December 31st, 2017. Please use the DATS Launcher (leaf icon) on your desktop to open DATS, or call IT (ext. 2300) if you need assistance.");
                return foundErrors;
            }

            if (hourBox.Value * 400 % 100 != 0)
            {
                foundErrors = true;
                MessageBox.Show("Please have your hours be in 0.25 hour (15 minute) increments.");
            }

            if (workOrderBar.Visible == true && (workOrderBar.Items.Count == 0 || workOrderBar.SelectedItem.ToString().Split(' ')[0] == ""))
            {
                foundErrors = true;
                MessageBox.Show("Please select a work order.");
            }

            try
            {
                int period = DATSEngineeringCore.getPeriod(dateCalendar.SelectionEnd);
            }
            catch (IndexOutOfRangeException)
            {
                foundErrors = true;
                MessageBox.Show("The date you chose falls within a pay period that doesn't exist yet." + Environment.NewLine
                    + "Pay periods are created near year-end by Payroll." + Environment.NewLine
                    + Environment.NewLine
                    + "Please contact them for more information.");
            }

            return foundErrors;
        }

        private void saveEdit()
        {
            //Grab values
            int period = DATSEngineeringCore.getPeriod(dateCalendar.SelectionStart);

            //Update detail
            DATSEngineeringSQL sql = new DATSEngineeringSQL(@"update timesheetdetail set
                                        period = @PERIOD,
                                        dateworked = @DATEWORKED,
                                        hours = @HOURS,
                                        workorder = @WORKORDER,
                                        dateentered = @DATEENTERED,
                                        description = @DESCRIPTION
 
                                        WHERE timecarddetailid = @TIMESHEETID");

            sql.AddParameter("@TIMESHEETID", editingTimesheetID);
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@DATEWORKED", dateCalendar.SelectionStart);
            sql.AddParameter("@DESCRIPTION", textBox1.Text);
            sql.AddParameter("@HOURS", hourBox.Value);

            if (workOrderBar.Items.Count == 0 || workOrderBar.Items[0].ToString() == "" || workOrderBar.Visible == false)
                sql.AddParameter("@WORKORDER", DBNull.Value);
            else
                sql.AddParameter("@WORKORDER", workOrderBar.SelectedItem.ToString().Split(' ')[0]);
            sql.AddParameter("@DATEENTERED", DateTime.Now);

            sql.Run();
        }

        private void submitNew()
        {
            string username = forUser;
            DateTime date = dateCalendar.SelectionStart;
            string workorder = "";

            if (workOrderBar.Items.Count > 0 && workOrderBar.Visible)
                workorder = workOrderBar.SelectedItem.ToString().Split(' ')[0];

            for (int i = 0; dateCalendar.SelectionStart.AddDays(i) <= dateCalendar.SelectionEnd; i++)
                DATSEngineeringCore.newTimesheet(username, dateCalendar.SelectionStart.AddDays(i), double.Parse(hourBox.Value.ToString()), workorder, textBox1.Text);
        }

        private int getPeriod(DateTime x)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select period from periods where [from]<=@DATE and [to]>=@DATE");
            sql.AddParameter("@DATE", x);

            return int.Parse(sql.Run().Rows[0][0].ToString());
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);
        }

        public bool isEditMode()
        {
            return this.Text == "Edit Timesheet";
        }

        private void evaluateHours(string oldStart, string oldEnd)
        {
            //TimeSpan now = DateTime.Parse(label10.Text) - DateTime.Parse(label9.Text);
            //TimeSpan before = DateTime.Parse(oldEnd) - DateTime.Parse(oldStart);

            //decimal beforeHours = Math.Abs(before.Hours) + (decimal)(Math.Abs(before.Minutes))/60;
            //decimal nowHours = Math.Abs(now.Hours) + (decimal)(Math.Abs(now.Minutes))/60;

            //if(DATSCore.calculateHoursRelatively())
            //    numericUpDown1.Value = Math.Max(numericUpDown1.Value + nowHours - beforeHours, 0);
            //else //Mathematically
            //    numericUpDown1.Value = Math.Abs(now.Hours) + (decimal)(Math.Abs(now.Minutes))/60;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //if (((decimal)(int)(numericUpDown1.Value * 4)) / 4 != numericUpDown1.Value)
            //    numericUpDown1.Value = Math.Round(numericUpDown1.Value * 4, 0)/4;
        }
        
        private void NewTimesheet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                button4_Click(null, null);
        }

        private void NewTimesheetold_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("This feature will become available soon.");

            //FindEquipment fe = new FindEquipment(forUser, equipment);
            //fe.ShowDialog();

            //if(!fe.quit)
            //{
            //    equipment = fe.equipment;

            //    equipmentBar.Items.Clear();

            //    string eq = "";

            //    for (int i = 0; equipment != null && i < equipment.Length; i++)
            //    {
            //        if (i == 0)
            //            eq += equipment[i].Trim();
            //        else
            //            eq += ", " + equipment[i].Trim();
            //    }

            //    equipmentBar.Items.Add(eq);
            //    equipmentBar.SelectedIndex = 0;
            //}
        }
        private void dateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}
