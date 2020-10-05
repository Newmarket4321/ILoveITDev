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
    public partial class Subscriptions : Form
    {
        int topicID;

        public Subscriptions(int id)
        {
            InitializeComponent();

            topicID = id;

            SQL sql = new SQL("use statmetpod; select topic from topics where id = @ID");
            sql.AddParameter("@ID", topicID);
            Text = sql.Run().Rows[0][0].ToString() + " - Subscriptions";

            refresh();
        }

        private void refresh()
        {
            SQL sql = new SQL(@"
use StatMetPod;
select * from subscriptions where topicid = @ID
");
            sql.AddParameter("@ID", topicID);
            DataTable dt = sql.Run();

            Core.fillListView(listView1, dt);
        }

        private void everyoneSubscribedToThisTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL(@"
use statmetpod;

select email
from subscriptions
where topicid=@ID
and email <> ''");
            sql.AddParameter("@ID", topicID);
            DataTable dt = sql.Run();

            string result = "";

            for(int i = 0; i < dt.Rows.Count; i++)
                result += dt.Rows[i]["email"].ToString() + "; ";

            if (result != "")
            {
                Clipboard.SetText(result);
                MessageBox.Show("E-mail addresses have been copied to your clipboard.");
            }
            else
            {
                MessageBox.Show("No e-mail addresses found.");
            }
        }

        private void onlyThoseWhoWishToHearAboutMeetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL(@"
use statmetpod;

select email
from subscriptions
where topicid=@ID
and email <> ''
and notifymeetings = 1
");
            sql.AddParameter("@ID", topicID);
            DataTable dt = sql.Run();

            string result = "";

            for (int i = 0; i < dt.Rows.Count; i++)
                result += dt.Rows[i]["email"].ToString() + "; ";

            if (result != "")
            {
                Clipboard.SetText(result);
                MessageBox.Show("E-mail addresses have been copied to your clipboard.");
            }
            else
            {
                MessageBox.Show("No subscribers meet that criteria.");
            }
        }

        private void onlyThoseWhoWishToHearAboutDecisionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL(@"
use statmetpod;

select email
from subscriptions
where topicid=@ID
and email <> ''
and notifydecisions = 1
");
            sql.AddParameter("@ID", topicID);
            DataTable dt = sql.Run();

            string result = "";

            for (int i = 0; i < dt.Rows.Count; i++)
                result += dt.Rows[i]["email"].ToString() + "; ";

            if (result != "")
            {
                Clipboard.SetText(result);
                MessageBox.Show("E-mail addresses have been copied to your clipboard.");
            }
            else
            {
                MessageBox.Show("No subscribers meet that criteria.");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetString box;
            
            box = new GetString("First name");
            box.ShowDialog();
            string firstName = box.r;
            if (box.r == "")
                return;

            box = new GetString("Last name");
            box.ShowDialog();
            string lastName = box.r;
            if (box.r == "")
                return;

            box = new GetString("Street number");
            box.ShowDialog();
            string streetNumber = box.r;
            if (box.r == "")
                return;

            box = new GetString("Street name");
            box.ShowDialog();
            string streetName = box.r;
            if (box.r == "")
                return;

            box = new GetString("Unit number");
            box.ShowDialog();
            string unitNumber = box.r;

            box = new GetString("City");
            box.ShowDialog();
            string city = box.r;
            if (box.r == "")
                return;

            box = new GetString("Postal code");
            box.ShowDialog();
            string postalCode = box.r;
            if (box.r == "")
                return;

            box = new GetString("Phone number");
            box.ShowDialog();
            string phoneNumber = box.r;
            if (box.r == "")
                return;

            string mailingStreetNumber;
            string mailingStreetName;
            string mailingUnitNumber;
            string mailingCity;
            string mailingPostalCode;
            if(MessageBox.Show("Is mailing address the same as the address given?", "Mailing address", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mailingStreetNumber = streetNumber;
                mailingStreetName = streetName;
                mailingCity = city;
                mailingUnitNumber = unitNumber;
                mailingPostalCode = postalCode;
            }
            else
            {
                box = new GetString("Mailing street number");
                box.ShowDialog();
                mailingStreetNumber = box.r;
                if (box.r == "")
                    return;

                box = new GetString("Mailing street name");
                box.ShowDialog();
                mailingStreetName = box.r;
                if (box.r == "")
                    return;

                box = new GetString("Mailing unit number");
                box.ShowDialog();
                mailingUnitNumber = box.r;
                
                box = new GetString("Mailing city");
                box.ShowDialog();
                mailingCity = box.r;
                if (box.r == "")
                    return;

                box = new GetString("Mailing postal code");
                box.ShowDialog();
                mailingPostalCode = box.r;
                if (box.r == "")
                    return;
            }

            box = new GetString("Email address");
            box.ShowDialog();
            string email = box.r;
            if (box.r == "")
                return;

            bool notifyMeetings = MessageBox.Show("Notify this person of meetings?", "Notify meetings", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            bool notifyDecision = MessageBox.Show("Notify this person of decisions?", "Notify decisions", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            bool deputation = MessageBox.Show("Has this person made a deputation to Council or Committee of the Whole on this matter?", "Deputation", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            bool writtenComments = MessageBox.Show("Has this person provided any written comments on the matter?", "Written comments", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;

            string[] emailOptions = { "Email", "Mail", "Phone" };
            LookupDropdown dropdown = new LookupDropdown("Preferred method of notification", emailOptions);
            dropdown.ShowDialog();
            string preferredContact = dropdown.r;

            SQL sql = new SQL(@"
use StatMetPod;
insert into subscriptions values (
    @TOPICID, 
    @FIRSTNAME, 
    @LASTNAME, 
    @STREETNUMBER, 
    @STREETNAME, 
    @UNITNUMBER, 
    @CITY, 
    @POSTALCODE, 
    @PHONENUMBER, 
    @MAILINGSTREETNUMBER, 
    @MAILINGSTREETNAME, 
    @MAILINGUNITNUMBER, 
    @MAILINGCITY, 
    @MAILINGPOSTALCODE, 
    @EMAIL, 
    @NOTIFYMEETINGS, 
    @NOTIFYDECISIONS, 
    @DEPUTATION, 
    @WRITTENCOMMENTS, 
    @PREFERREDCONTACT)
            ");
            sql.AddParameter("@TOPICID", topicID);
            sql.AddParameter("@FIRSTNAME", firstName);
            sql.AddParameter("@LASTNAME", lastName);
            sql.AddParameter("@STREETNUMBER", streetNumber);
            sql.AddParameter("@STREETNAME", streetName);
            sql.AddParameter("@UNITNUMBER", unitNumber);
            sql.AddParameter("@CITY", city);
            sql.AddParameter("@POSTALCODE", postalCode);
            sql.AddParameter("@PHONENUMBER", phoneNumber);
            sql.AddParameter("@MAILINGSTREETNUMBER", mailingStreetNumber);
            sql.AddParameter("@MAILINGSTREETNAME", mailingStreetName);
            sql.AddParameter("@MAILINGUNITNUMBER", mailingUnitNumber);
            sql.AddParameter("@MAILINGCITY", mailingCity);
            sql.AddParameter("@MAILINGPOSTALCODE", mailingPostalCode);
            sql.AddParameter("@EMAIL", email);
            sql.AddParameter("@NOTIFYMEETINGS", notifyMeetings);
            sql.AddParameter("@NOTIFYDECISIONS", notifyDecision);
            sql.AddParameter("@DEPUTATION", deputation);
            sql.AddParameter("@WRITTENCOMMENTS", writtenComments);
            sql.AddParameter("@PREFERREDCONTACT", preferredContact);
            sql.Run();

            MessageBox.Show("Subscription complete!");

            refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string response = Core.lookupMessageBox("Are you sure?", "Delete subscriber \"" + listView1.SelectedItems[0].SubItems[listView1.Columns["FirstName"].Index].Text + " " + listView1.SelectedItems[0].SubItems[listView1.Columns["LastName"].Index].Text + "\"?", "Yes", "No");
                
                if (response == "Yes")
                {
                    SQL sql = new SQL("use statmetpod; delete from subscriptions where id = @ID");
                    sql.AddParameter("@ID", listView1.SelectedItems[0].SubItems[listView1.Columns["ID"].Index].Text);
                    sql.Run();
                    
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select a subscription.");
            }
        }

        private void update(string columnName, string newValue)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                SQL sql = new SQL("use statmetpod; update subscriptions set " + columnName + " = @VALUE where id = @ID");
                sql.AddParameter("@VALUE", newValue);
                sql.AddParameter("@ID", listView1.SelectedItems[0].SubItems[listView1.Columns["ID"].Index].Text);
                sql.Run();

                listView1.SelectedItems[0].SubItems[listView1.Columns[columnName].Index].Text = newValue;
            }
            else
            {
                MessageBox.Show("Please select a subscription.");
            }
        }
        
        private void newValueTextBox(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            string boxTitle = item.Text.Replace("Change ", "").ToLower();
            boxTitle = boxTitle.Substring(0, 1).ToUpper() + boxTitle.Substring(1, boxTitle.Length - 1); //Capitalise first

            string columnName = item.Text.Replace("Change ", "").Replace(" ", "");

            GetString box = new GetString(boxTitle);
            box.ShowDialog();

            if (box.r != "")
                update(columnName, box.r);
        }

        private void newValueBoolean(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            string boxTitle = item.Text.Replace("Change ", "").ToLower();
            boxTitle = boxTitle.Substring(0, 1).ToUpper() + boxTitle.Substring(1, boxTitle.Length - 1); //Capitalise first

            string columnName = item.Text.Replace("Change ", "").Replace(" ", "");

            bool result = MessageBox.Show("New " + boxTitle + " value?", boxTitle, MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            
            update(columnName, result.ToString());
        }

        private void changePreferredContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            string boxTitle = item.Text.Replace("Change ", "").ToLower();
            boxTitle = boxTitle.Substring(0, 1).ToUpper() + boxTitle.Substring(1, boxTitle.Length - 1); //Capitalise first

            string columnName = item.Text.Replace("Change ", "").Replace(" ", "");

            string[] emailOptions = { "Email", "Mail", "Phone" };
            LookupDropdown dropdown = new LookupDropdown("Preferred method of notification", emailOptions);
            dropdown.ShowDialog();

            if (dropdown.r != "")
                update(columnName, dropdown.r);
        }

        private void Subscriptions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
        }

        private void notifyMeetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run(@"
use statmetpod;

select

*

from subscriptions

where topicid = @ID
and notifymeetings=1", topicID);

            Report r = new Report(Text + " - Notify Meetings Report", dt);
            r.Show();
        }

        private void notifyDecisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run(@"
use statmetpod;

select

*

from subscriptions

where topicid = @ID
and notifydecision=1", topicID);

            Report r = new Report(Text + " - Notify Decision Report", dt);
            r.Show();
        }

        private void deputationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run(@"
use statmetpod;

select

*

from subscriptions

where topicid = @ID
and deputation=1", topicID);

            Report r = new Report(Text + " - Deputation Report", dt);
            r.Show();
        }

        private void writtenCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run(@"
use statmetpod;

select

*

from subscriptions

where topicid = @ID
and writtencomments=1", topicID);

            Report r = new Report(Text + " - Written Comments Report", dt);
            r.Show();
        }

        private void allSubscribersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = SQL.Run(@"
use statmetpod;

select

*

from subscriptions

where topicid = @ID", topicID);

            Report r = new Report(Text + " - All Subscribers Report", dt);
            r.Show();
        }
    }
}
