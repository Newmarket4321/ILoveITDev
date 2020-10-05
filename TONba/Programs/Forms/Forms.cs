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
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();

            list.Columns.Add("Title");
            list.Columns.Add("Questions");
            list.Columns.Add("Responses");
            list.Columns.Add("Notification Frequency");
            list.Columns.Add("Notification E-mail");
            list.Columns.Add("Submission Screen");
            list.Columns.Add("Date Last Modified");
            
            refresh();

            if (list.Items.Count > 0)
                list.Items[0].Selected = true;
        }

        public void refresh()
        {
            string cursor = "";

            if (list.SelectedItems.Count > 0)
                cursor = list.SelectedItems[0].Tag.ToString();

            list.Items.Clear();

            DataTable dt = SQL.Run("use forms; select * from forms order by datelastmodified desc");

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                int numResponses = SQL.Run("use forms; select submissionid from answers where formid = @ID group by submissionid", dt.Rows[i]["ID"].ToString()).Rows.Count;
                int numQuestions = SQL.Run("use forms; select id from questions where formid = @ID group by id", dt.Rows[i]["ID"].ToString()).Rows.Count;
                string[] data = { dt.Rows[i]["Title"].ToString(), numQuestions.ToString(), numResponses.ToString(), dt.Rows[i]["NotifyWhen"].ToString(), dt.Rows[i]["NotifyWho"].ToString(), dt.Rows[i]["ReturnAfterSubmit"].ToString(), dt.Rows[i]["DateLastModified"].ToString() };
                
                ListViewItem li = new ListViewItem(data);
                li.Tag = dt.Rows[i]["ID"].ToString();

                if(Core.isAdmin() || SQL.Run("select * from permissions where username = @USERNAME and program = @PROGRAM", Core.getUsername(), "Forms-" + dt.Rows[i]["ID"].ToString()).Rows.Count > 0) //If you have permission
                    list.Items.Add(li);
            }

            for (int i = 0; i < list.Columns.Count; i++)
                list.Columns[i].Width = -2;

            if (cursor != "")
            {
                for (int i = 0; i < list.Items.Count; i++)
                    if (list.Items[i].Tag.ToString() == cursor)
                        list.Items[i].Selected = true;
            }

            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();

                webBrowser1.Url = new Uri("http://forms.newmarket.ca/Form.aspx?id=" + formID);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string formID = "";
            string title = "";
            string notifyWho = "";
            string notifyWhen = "";
            bool success;

            //Gather information
            title = Core.getString("What is the title of your form/survey?", out success);

            if (!success)
                return;

            notifyWhen = Core.lookupMessageBox("Notify when?", "When would you like to be notified of new responses to your form/survey?", new string[] { "Never", "Daily", "Weekly", "Monthly" });

            if (!success)
                return;

            if (notifyWhen != "Never")
            {
                notifyWho = Core.getString("Enter the e-mail address that will receive notifications. Use commas for multiple.", out success);

                if (!success)
                    return;
            }

            //Generate URL code
            bool keepGoing = true;

            while (keepGoing)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var stringChars = new char[12];
                Random random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                    stringChars[i] = chars[random.Next(chars.Length)];

                formID = new string(stringChars);

                //Ensure it's not already in use
                if (SQL.Run("use forms; select * from forms where ID = @ID", formID).Rows.Count == 0)
                    keepGoing = false;
            }

            //Enter form into table
            SQL.Run("use forms; insert into forms values (@ID, @TITLE, @DATECREATED, @CREATEDBY, @DATELASTMODIFIED, @LASTMODIFIEDBY, @NOTIFYWHEN, @NOTIFYWHO, @RETURNAFTERSUBMIT, @NOTIFICATIONSLASTSENT)", formID, title, DateTime.Now, Core.getUsername(), DateTime.Now, Core.getUsername(), notifyWhen, notifyWho, "Thank you screen", DateTime.Now);

            //Add permission for this user
            SQL.Run("insert into permissions values (@USERNAME, @PROGRAM)", Core.getUsername(), "Forms-" + formID);

            Core.log("Forms", "New Form", formID);

            MessageBox.Show("Your new form has been created.");

            refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                if (MessageBox.Show("Are you sure you would like to delete " + title + "? Everything, including responses, will be deleted.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.Run("use forms; delete from answers where formid = @ID", formID);
                    SQL.Run("use forms; delete from listoptions where questionid in (select id from questions where formid = @ID)", formID);
                    SQL.Run("use forms; delete from questions where formid = @ID", formID);
                    SQL.Run("use forms; delete from forms where id = @ID", formID);

                    Core.log("Forms", "Delete Form", formID + " (" + title + ")");

                    MessageBox.Show("The form has been deleted.");

                    refresh();
                }
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                DataTable questions = SQL.Run("use forms; select question from answers where formid = @ID group by question order by min(questionid)", formID);
                DataTable submissions = SQL.Run("use forms; select submissionid, timestamp from answers where formid = @ID group by submissionid, timestamp order by submissionid", formID);

                DataTable dt = new DataTable();

                dt.Columns.Add("Submission ID");
                dt.Columns.Add("Timestamp");

                for (int i = 0; i < questions.Rows.Count; i++)
                    dt.Columns.Add(questions.Rows[i]["question"].ToString());

                for(int i = 0; i < submissions.Rows.Count; i++)
                {
                    string[] values = new string[dt.Columns.Count];

                    values[0] = submissions.Rows[i]["submissionid"].ToString();
                    values[1] = submissions.Rows[i]["timestamp"].ToString();

                    for (int j = 0; j < questions.Rows.Count; j++)
                    {
                        try
                        {
                            values[2 + j] = SQL.RunString("use forms; select answer from answers where submissionid = @ID and question = @QUESTION", submissions.Rows[i]["submissionid"].ToString(), questions.Rows[j]["question"].ToString());
                        }
                        catch
                        {

                        }
                    }

                    dt.Rows.Add(values);
                }

                Report r = new Report(title, dt);
                r.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();

                System.Diagnostics.Process.Start("http://forms.newmarket.ca/Form.aspx?id=" + formID);

                //Clipboard.SetText("http://forms.newmarket.ca/Form.aspx?id=" + formID);
                //MessageBox.Show("The form link has been copied to your clipboard.");
            }
        }

        private void givePermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                bool success;
                string target = Core.getString("Windows username of the person to give permission to:", out success);

                if (!success)
                    return;

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("insert into permissions values (@USERNAME, @PROGRAM)", target, "Forms-" + formID);
                Core.log("Forms", "Give Permission", formID + " to " + target);

                MessageBox.Show(target + " has been given permission to manage " + title + ".");
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                revokePermissionFromToolStripMenuItem.DropDownItems.Clear();
                DataTable dt = SQL.Run("select username from permissions where program = @PROGRAM", "Forms-" + formID);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(dt.Rows[i]["username"].ToString());
                    item.Click += Item_Click;

                    revokePermissionFromToolStripMenuItem.DropDownItems.Add(item);
                }

                webBrowser1.Url = new Uri("http://forms.newmarket.ca/Form.aspx?id=" + formID);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                string target = (sender as ToolStripMenuItem).Text;

                if (target == Core.getUsername())
                {
                    MessageBox.Show("You can't remove yourself from permissions.");

                    return;
                }

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("delete from permissions where username = @USERNAME and program = @PROGRAM", target, "Forms-" + formID);
                Core.log("Forms", "Revoke Permission", formID + " from " + target);

                MessageBox.Show(target + " no longer has access to " + title + ".");
            }
        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                EditForm ef = new EditForm(formID, title);
                ef.ShowDialog();

                refresh();
            }
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            questionsToolStripMenuItem_Click(null, null);
        }

        private void revokePermissionFromToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();

                bool success;
                string title = Core.getString("New title", out success);

                if (!success)
                    return;

                SQL.Run("use forms; update forms set title = @TITLE, datelastmodified = @DATE where id = @QID", title, DateTime.Now, formID);
                Core.log("Forms", "Change Form Title", formID + " to " + title);

                refresh();
            }
        }

        private void notificationFrequencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();

                string notifyWhen = Core.lookupMessageBox("Notify when?", "When would you like to be notified?", new string[] { "Never", "Daily", "Weekly", "Monthly" });

                SQL.Run("use forms; update forms set notifywhen = @NOTIFYWHEN, datelastmodified = @DATE where id = @QID", notifyWhen, DateTime.Now, formID);
                Core.log("Forms", "Change Notification Frequency", formID + " to " + notifyWhen);

                refresh();
            }
        }

        private void notificationEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();

                bool success;
                string notifyWho = Core.getString("E-mail address to notify of responses (use commas for multiple)", out success);

                if (!success)
                    return;

                SQL.Run("use forms; update forms set notifywho = @NOTIFYWHO, datelastmodified = @DATE where id = @QID", notifyWho, DateTime.Now, formID);
                Core.log("Forms", "Change Notification E-mails", formID + " to " + notifyWho);

                refresh();
            }
        }

        private void showthankYouScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string nextStep = "Thank you screen";

                SQL.Run("use forms; update forms set returnaftersubmit = @NEXTSTEP, datelastmodified = @DATE where id = @QID", nextStep, DateTime.Now, formID);
                Core.log("Forms", "Change Return After Submit", formID + " to " + nextStep);

                refresh();
            }
        }

        private void returnToFormToGetReadyForNextSubmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string nextStep = "Return to form";

                SQL.Run("use forms; update forms set returnaftersubmit = @NEXTSTEP, datelastmodified = @DATE where id = @QID", nextStep, DateTime.Now, formID);
                Core.log("Forms", "Change Return After Submit", formID + " to " + nextStep);

                refresh();
            }
        }
    }
}
