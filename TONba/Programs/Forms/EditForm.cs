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
    public partial class EditForm : Form
    {
        string formID;

        public EditForm(string id, string title)
        {
            InitializeComponent();

            formID = id;

            Text = title + " - Questions";

            list.Columns.Add("Order");
            list.Columns.Add("Text");
            list.Columns.Add("Type");
            list.Columns.Add("Options");
            list.Columns.Add("Mandatory");

            refresh();
        }

        public void refresh()
        {
            int cursor = -1;

            if (list.SelectedItems.Count > 0)
                cursor = int.Parse(list.SelectedItems[0].Tag.ToString());

            list.Items.Clear();

            DataTable dt = SQL.Run("use forms; select * from questions where formid = @ID order by orderno", formID);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string numOptions = SQL.Run("use forms; select questionid from listoptions where questionid = @ID", dt.Rows[i]["ID"].ToString()).Rows.Count.ToString();

                if (numOptions == "0")
                    numOptions = "";

                string[] data = { dt.Rows[i]["OrderNo"].ToString(), dt.Rows[i]["Text"].ToString(), dt.Rows[i]["Type"].ToString(), numOptions, dt.Rows[i]["Mandatory"].ToString() };
                
                ListViewItem li = new ListViewItem(data);
                li.Tag = dt.Rows[i]["ID"].ToString();

                list.Items.Add(li);
            }

            for (int i = 0; i < list.Columns.Count; i++)
                list.Columns[i].Width = -2;

            list.Columns[1].Width = 400;

            if (cursor != -1)
            {
                for (int i = 0; i < list.Items.Count; i++)
                    if (int.Parse(list.Items[i].Tag.ToString()) == cursor)
                        list.Items[i].Selected = true;
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
            title = Core.getString("Form title", out success);

            if (!success)
                return;

            notifyWhen = Core.lookupMessageBox("Notify when?", "When would you like to be notified?", new string[] { "Never", "Daily", "Weekly", "Monthly" });

            if (!success)
                return;

            if (notifyWhen != "Never")
            {
                notifyWho = Core.getString("E-mail address to notify of responses (use commas for multiple)", out success);

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
            SQL.Run("use forms; insert into forms values (@ID, @TITLE, @DATECREATED, @CREATEDBY, @DATELASTMODIFIED, @LASTMODIFIEDBY, @NOTIFYWHEN, @NOTIFYWHO)", formID, title, DateTime.Now, Core.getUsername(), DateTime.Now, Core.getUsername(), notifyWhen, notifyWho);

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

                MessageBox.Show("Are you sure you would like to delete " + title + "? Everything, including responses, will be deleted.", "Are you sure?", MessageBoxButtons.YesNo);

                SQL.Run("use forms; delete from answers where formid = @ID", formID);
                SQL.Run("use forms; delete from listoptions where questionid in (select id from questions where formid = @ID)", formID);
                SQL.Run("use forms; delete from questions where formid = @ID", formID);
                SQL.Run("use forms; delete from forms where id = @ID", formID);

                Core.log("Forms", "Delete Form", formID + " (" + title + ")");

                MessageBox.Show("The form has been deleted.");

                refresh();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();
                string title = list.SelectedItems[0].Text;

                Report r = new Report(title, SQL.Run("use forms; select SubmissionID, Timestamp, Question, Answer from answers where questionid in (select id from questions where formid = @ID) order by SubmissionID, questionID", formID));
                r.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string formID = list.SelectedItems[0].Tag.ToString();

                Clipboard.SetText("http://forms.newmarket.ca/Forms.aspx?id=" + formID);
                MessageBox.Show("The form link has been copied to your clipboard.");
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

                SQL.Run("insert into permissions values (@USERNAME, @PROGRAM)", target, "Forms-" + formID);
                Core.log("Forms", "Give Permission", formID + " to " + target);

                MessageBox.Show(target + " has been given permission to manage " + title + ".");
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string questionID = list.SelectedItems[0].Tag.ToString();
                string type = SQL.RunString("use forms; select type from questions where id = @QID", questionID);

                multipleChoiceOptionsToolStripMenuItem.Enabled = type != "TextBox";
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

                SQL.Run("delete from permissions where username = @USERNAME and program = @PROGRAM", target, "Forms-" + formID);
                Core.log("Forms", "Revoke Permission", formID + " from " + target);

                MessageBox.Show(target + " no longer has access to " + title + ".");
            }
        }

        private void questionTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string questionID = list.SelectedItems[0].Tag.ToString();

                bool success;
                string newText = Core.getString("New text", out success);

                if (!success)
                    return;

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; update questions set text = @TEXT where id = @QID", newText, questionID);
                Core.log("Forms", "Change Question Text", formID + " - QID " + questionID + " to " + newText);

                refresh();
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

                    //Move other questions down to make room for this one
                    SQL.Run("use forms; update questions set orderno = orderno+1 where formid=@FID and orderno >= @ONO", formID, orderNo);
                }
                else orderNo = int.Parse(list.Items[list.Items.Count - 1].Text) + 1;
            }
            else
                orderNo = 1;

            //Enter form into table
            SQL.Run("use forms; insert into questions values (@FORMID, @ORDERNO, @TEXT, @TYPE, @MANDATORY)", formID, orderNo, "", "TextBox", false);
            Core.log("Forms", "New Question", formID);

            refresh();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                if (list.SelectedItems[0].Index <= 0)
                    return;
                
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());
                int swapID = int.Parse(list.Items[list.SelectedItems[0].Index - 1].Tag.ToString());

                SQL.Run("use forms; update questions set orderno = orderno-1 where id=@ID", questionID);
                SQL.Run("use forms; update questions set orderno = orderno+1 where id=@ID", swapID);

                refresh();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                if (list.SelectedItems[0].Index >= list.Items.Count - 1)
                    return;

                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());
                int swapID = int.Parse(list.Items[list.SelectedItems[0].Index + 1].Tag.ToString());

                SQL.Run("use forms; update questions set orderno = orderno+1 where id=@ID", questionID);
                SQL.Run("use forms; update questions set orderno = orderno-1 where id=@ID", swapID);

                refresh();
            }
        }

        private void typeAnAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; delete from listoptions where questionid = @QID", questionID);
                SQL.Run("use forms; update questions set type = @TYPE where id=@ID", "TextBox", questionID);

                refresh();
            }
        }

        private void chooseAnOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; update questions set type = @TYPE where id=@ID", "Radio", questionID);

                refresh();
            }
        }

        private void checkBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; update questions set type = @TYPE where id=@ID", "Check", questionID);
                
                refresh();
            }
        }

        private void makeThisQuestionMandatoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; update questions set mandatory = @MAN where id=@ID", true, questionID);

                refresh();
            }
        }

        private void makeThisQuestionNotMandatoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; update questions set mandatory = @MAN where id=@ID", false, questionID);

                refresh();
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());
                int orderNo = int.Parse(list.SelectedItems[0].Text) + 1;

                if (MessageBox.Show("Are you sure you would like to delete this question?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQL.Run("use forms; delete from listoptions where questionid = @QID", questionID);
                    SQL.Run("use forms; delete from questions where id = @QID", questionID);

                    Core.log("Forms", "Delete Question", formID);

                    refresh();
                }
            }
        }

        private void multipleChoiceOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());
                int orderNo = int.Parse(list.SelectedItems[0].Text) + 1;

                ListOptions lo = new ListOptions(questionID);
                lo.ShowDialog();
                
                refresh();
            }
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                string questionID = list.SelectedItems[0].Tag.ToString();
                string type = SQL.RunString("use forms; select type from questions where id = @QID", questionID);

                if(type != "TextBox")
                    multipleChoiceOptionsToolStripMenuItem_Click(null, null);
            }
        }

        private void EditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void disclaimerInstructionLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int questionID = int.Parse(list.SelectedItems[0].Tag.ToString());

                SQL.Run("use forms; update forms set datelastmodified = @DATE where id = @QID", DateTime.Now, formID);
                SQL.Run("use forms; delete from listoptions where questionid = @QID", questionID);
                SQL.Run("use forms; update questions set type = @TYPE where id=@ID", "Label", questionID);

                refresh();
            }
        }
    }
}
