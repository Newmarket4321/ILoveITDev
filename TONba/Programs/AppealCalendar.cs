using System;
using System.Data;
using System.Windows.Forms;

namespace I_IT
{
    public partial class AssessmentAppealCalendar : Form
    {
        string aText = "A - General";
        string bText = "B - Summary";

        public AssessmentAppealCalendar()
        {
            InitializeComponent();

            refreshList();
        }

        private void refreshList()
        {
            list.Items.Clear();

            DataTable dt = SQL.Run(@"
select
appealid as 'ID',
rollno as 'Roll Number',
appealno as 'Appeal Number',
format(commencementdate, 'MMMM d, yyyy') as 'Commencement Date',
type as 'Type'

from AppealCalendar_Appeals

order by commencementdate desc");

            list.Columns.Clear();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                list.Columns.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                list.Columns[i].Name = dt.Columns[i].ColumnName;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] data = new string[dt.Columns.Count];

                for (int j = 0; j < dt.Columns.Count; j++)
                    data[j] = dt.Rows[i][j].ToString();

                ListViewItem x = new ListViewItem(data);
                list.Items.Add(x);
            }

            for (int i = 0; i < list.Columns.Count; i++)
                list.Columns[i].Width = -2;
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                Report r = new Report(list.SelectedItems[0].SubItems[1].Text, SQL.Run(@"
select
eventid as 'Event ID',
format(startdate, 'MMMM d, yyyy') as 'Start Date',
format(enddate, 'MMMM d, yyyy') as 'End Date',
case when sent = 1 then 'Yes' else 'No' end as 'Notification Sent',
description as 'Description'

from AppealCalendar_Events

where AppealID = @ID

order by startdate asc", list.SelectedItems[0].SubItems[0].Text));
                r.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool success;
            string rollNo = Core.getString("Roll number", out success);

            if (!success)
                return;

            string appealNo = Core.getString("Appeal number", out success);

            if (!success)
                return;

            DateTime date = Core.getDate("Commencement date", out success);

            if (!success)
                return;

            string type = Core.lookupMessageBox("Schedule", "Which schedule is this?", aText, bText);

            if (type == "")
                return;

            SQL.Run("insert into AppealCalendar_Appeals values (@ROLLNO, @APPEALNO, @DATE, @TYPR)", rollNo, appealNo, date, type);

            int id = int.Parse(SQL.RunString("select max(appealid) from AppealCalendar_Appeals"));

            generateEvents(id, type);

            refreshList();
        }

        private void addEvent(int appealID, DateTime commencementDate, int eventID, int startWeek, int endWeek, string description)
        {
            DateTime startDate = commencementDate.AddDays((startWeek - 1) * 7);
            DateTime endDate = commencementDate.AddDays(endWeek * 7 - 1);

            SQL.Run("insert into AppealCalendar_Events values (@APPEALID, @EVENTID, @DESCRIPTION, @STARTDATE, @ENDDATE, 0)", appealID, eventID, description, startDate, endDate);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Are you sure you'd like to delete this appeal?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.Run("delete from AppealCalendar_Appeals where appealid = @ID", list.SelectedItems[0].SubItems[0].Text);
                    SQL.Run("delete from AppealCalendar_Events where appealid = @ID", list.SelectedItems[0].SubItems[0].Text);

                    MessageBox.Show("Appeal deleted.");

                    refreshList();
                }
            }
            else
                MessageBox.Show("Please select an appeal.");
        }

        private void AssessmentAppealCalendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                toolStripMenuItem1_Click(null, null);

            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void changeRollNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                bool success;
                string rollNo = Core.getString("Roll number", out success);

                if (!success)
                    return;
                
                SQL.Run("update AppealCalendar_Appeals set rollno = @ROLLNO where appealid = @ID", rollNo, list.SelectedItems[0].SubItems[0].Text);

                refreshList();
            }
            else
                MessageBox.Show("Please select an appeal.");
        }

        private void changeAppealNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                bool success;
                string appealNo = Core.getString("Appeal number", out success);

                if (!success)
                    return;

                SQL.Run("update AppealCalendar_Appeals set appealno = @APPEALNO where appealid = @ID", appealNo, list.SelectedItems[0].SubItems[0].Text);

                refreshList();
            }
            else
                MessageBox.Show("Please select an appeal.");
        }

        private void changeCommencementDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                bool success;
                DateTime date = Core.getDate("Commencement date", out success);

                if (!success)
                    return;

                SQL.Run("update AppealCalendar_Appeals set commencementdate = @DATE where appealid = @ID", date, list.SelectedItems[0].SubItems[0].Text);

                string type = SQL.RunString("select type from AppealCalendar_Appeals where appealid = @ID", list.SelectedItems[0].SubItems[0].Text);
                generateEvents(int.Parse(list.SelectedItems[0].SubItems[0].Text), type);

                refreshList();
            }
            else
                MessageBox.Show("Please select an appeal.");
        }

        private void generateEvents(int id, string type)
        {
            SQL.Run("delete from AppealCalendar_Events where appealid = @ID", id);

            DateTime date = DateTime.Parse(SQL.RunString("select commencementdate from AppealCalendar_Appeals where appealid = @ID", id));

            if (type == aText)
            {
                addEvent(id, date, 0, 1, 4, "MPAC provides initial disclosure to all other parties");
                addEvent(id, date, 1, 5, 5, "All other parties must request any additional disclosure from MPAC");
                addEvent(id, date, 2, 6, 6, "MPAC to advise other parties if it disputes a request for disclosure");
                addEvent(id, date, 3, 7, 9, "Motion for Disclosure completed (if required); MPAC provides any additional required disclosure");
                addEvent(id, date, 4, 10, 21, "Each Appellant provides its disclosure and Statement of Issues to all other parties");
                addEvent(id, date, 5, 22, 24, "Each party who responds to the Appellant(s) to advise if an inspection or any additional disclosure is requested.");
                addEvent(id, date, 6, 25, 29, "Any objection regarding a request for an inspection or a request for additional disclosure is to be resolved by motion");
                addEvent(id, date, 7, 30, 34, "Where an inspection or additional disclosure is required, these are to be completed");
                addEvent(id, date, 8, 35, 46, "Each party who responds to the Appellant(s) is to provide its Statement of Response and any additional supporting disclosure");
                addEvent(id, date, 9, 47, 50, "Each Appellant to provide its statement of reply and any additional disclosure to support of its reply to all other parties");
                addEvent(id, date, 10, 51, 62, "All parties are required to schedule and complete a mandatory settlement meeting to attempt to resolve the appeal among themselves. If the appeal is resolved, MPAC (or the Municipality, if MPAC is not a party to the appeal), must, on behalf of all parties, also: 1) Advise the Board in writing that the appeal is being withdrawn or will be resolved through minutes of settlement; and 2) Advise the Board if the parties request an extension of the due date specified in the Board's Rules for filing minutes of settlement with the Board. /////////// If the appeal is not resolved, MPAC (or the Municipality, if MPAC is not a party to the appeal), on behalf of all parties, must also: 1) Advise the Board in writing that the appeal has not been resolved, and 2) Advise the Board whether any of the parties intend to obtain any additional expert reports before the Board schedules a settlement conference or mediation.");
                addEvent(id, date, 11, 63, 66, "If the appeal is not resolved, and none of the parties intend to obtain any additional expert reports, each party shall file with the Board: 1) its SOI, SOR and Reply (as the case may be); 2) All documentary evidence, witness statements and expert reports on which the party intends to rely if the matter proceeds to mediation or a hearing; and 3) its Settlement Conference Brief. 4) On the consent the parties, the parties may submit a request in writing to the Board to conduct a mediation before the Settlement Conference. If the appeal is not resolved at the mediation, the mediator will then immediately proceed to conduct the Settlement Conference.");
                addEvent(id, date, 12, 63, 78, "If the appeal is not resolved, and any of the parties intend to obtain any additional expert reports: Each Appellant must server on all other parties any expert reports on which the Appellant intends to rely at the hearing, as well as any amendment to the Appellant's Statement of Issues to address any additional evidence or issues raised in an expert's report.");
                addEvent(id, date, 13, 79, 94, "If the appeal is not resolved, and any of the parties intend to obtain any additional expert reports: Each Responding Party must then serve on all other parties any expert reports on which the Responding Party intends to rely at the hearing, as well as any amendment to the Responding Party's Statement of Response to address any additional evidence or issues raised in an expert's report.");
                addEvent(id, date, 14, 95, 100, "If the appeal is not resolved, and any of the parties intend to obtain any additional expert reports: Each Appellant must then provide any supplementary reports by its experts in reply to any expert reports served by a Responding Party.");
                addEvent(id, date, 15, 101, 104, "If the appeal is not resolved, and any of the parties intend to obtain any additional expert reports: If, after the completion of the additional exchange of expert reports, the Parties are still unable to resolve the appeal, each party shall file with the Board: 1) its amended SOI, SOR, and Reply (as the case may be); 2) all documentary evidence, witness statements and expert reports on which the party intends to rely if the matter proceeds to mediation or a hearing; and 3) its Settlement Conference Brief. 4) On the consent the parties, the parties may submit a request in writing to the Board to conduct a mediation before the Settlement Conference. If the appeal is not resolved at the mediation, the mediator will then immediately proceed to conduct the Settlement Conference.");
            }
            else if (type == bText)
            {
                addEvent(id, date, 0, 1, 4, "The parties to complete exchange of disclosure.");
                addEvent(id, date, 1, 5, 12, "Parties to schedule and complete a mandatory settlement meeting to attempt to resolve tthe appeal among themselves. If the appeal is resolved, MPAC (or the Municipality, if MPAC is not a party to the appeal), on behalf of all parties, must: 1) advise the Board in writing that the appeal is being withdrawn or will be resolved through minutes of settlement; and 2) Advise the Board if the parties request an extension of the due date, specified in the Board's Rules, for filing minutes of settlement with the Board. ///// If the appeal is not resolved, MPAC (or the Municipality, if MPAC is not a party to the appeal), on behalf of all parties, must: 1) advise the Board in writing that the appeal has not been resolved, and request that the Board schedule a hearing of the appeal; and 2) advise the Board whether any of the parties requests a hearing in person, and/or that the hearing be scheduled for longer than 2 hours.");
                addEvent(id, date, 2, 13, 14, "Where a hearing has been requested, the parties must file with the Board all documents and any written submissions on which they will rely at the hearing.");
            }

            SQL.Run("update AppealCalendar_Events set sent = 1 where appealid = @ID and enddate < @NOW", id, DateTime.Today);
        }

        private void changeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string type = Core.lookupMessageBox("Schedule", "Which schedule is this?", aText, bText);

                if (type == "")
                    return;

                SQL.Run("update AppealCalendar_Appeals set type = @TYPE where appealid = @ID", type, list.SelectedItems[0].SubItems[0].Text);

                generateEvents(int.Parse(list.SelectedItems[0].SubItems[0].Text), type);

                refreshList();
            }
            else
                MessageBox.Show("Please select an appeal.");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Report r = new Report("Appeals", SQL.Run(@"SELECT AppealID
	  ,[RollNo]
      ,[AppealNo]
	  ,[CommencementDate]
	  ,year(CommencementDate) as Year
      ,[Type]
  FROM [IHeartIT].[dbo].[AppealCalendar_Appeals]
  order by commencementdate"));
            r.Show();
        }
    }
}
