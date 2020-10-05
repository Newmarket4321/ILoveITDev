using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace I_IT
{
    public partial class AccessITExpress : Form
    {
        const string allTickets = "All_Requests";

        string viewName = "";
        string technicianName = "";

        public AccessITExpress()
        {
            InitializeComponent();

            technicianName = Core.getADValueFromUsername(Core.getUsername(), "displayname");

            if(SQL.Run("select * from AccessITExpressTechnicians where displayname = @NAME", technicianName).Rows.Count == 0)
            {
                MessageBox.Show(technicianName + " not found in the list of technicians.");
                Close();

                return;
            }

            viewName = SQL.RunString("select PreferredView from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            refresh();
        }
        
        private void refresh()
        {
            listView1.Items.Clear();

            List<Request> list = AccessIT.getRequests(technicianName, 75, viewName);

            for (int i = 0; list != null && i < list.Count; i++)
            {
                Request r = AccessIT.getRequest(technicianName, list[i].workorderid);

                ListViewItem item = new ListViewItem(r.workorderid.ToString());
                item.SubItems.Add(r.subject);
                item.SubItems.Add(r.requester);
                item.SubItems.Add(r.group);
                item.SubItems.Add(r.technician);
                item.SubItems.Add(r.status);
                item.SubItems.Add(r.createddate.ToString());
                item.SubItems.Add(r.duebydate.Year != 1969 ?r.duebydate.ToString() : "");

                listView1.Items.Add(item);
            }

            for (int c = 0; c < listView1.Columns.Count; c++)
                listView1.Columns[c].Width = -2;

            listView1.Columns[1].Width = 350;
            listView1.Columns[3].Width = 200;
        }

        private void NewTicket(object sender, EventArgs e)
        {
            bool success;

            Request r = new Request();
            r.subject = Core.getString("Subject/Title", out success);

            if (!success)
                return;

            r.description = Core.getString("Description", true, out success).Replace(Environment.NewLine, "&lt;br /&gt;");

            if (!success)
                return;

            r.requester = Core.getString("Requester (Last, First)", out success);

            if (!success)
                return;

            r.technician = technicianName;
            r.group = SQL.RunString("select GroupName from AccessITExpressTechnicians where displayname = @NAME", technicianName);
            r.category = SQL.RunString("select DefaultCategory from AccessITExpressTechnicians where displayname = @NAME", technicianName);

            AccessIT.createRequest(technicianName, r);

            refresh();
        }

        private void AutoRefresh(object sender, EventArgs e)
        {
            refresh();
        }

        private void CloseTicket(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                bool success;
                string resolution = Core.getString("Resolution", true, out success).Replace(Environment.NewLine, "&lt;br /&gt;");

                if (!success)
                    return;

                if (AccessIT.getRequest(technicianName, id).category == null)
                    AccessIT.updateCategory(technicianName, id, SQL.RunString("select DefaultCategory from AccessITExpressTechnicians where displayname = @NAME", technicianName));

                AccessIT.closeRequest(technicianName, id, resolution);

                refresh();
            }
            else
                MessageBox.Show("Please select a ticket");
        }

        private void RefreshView(object sender, EventArgs e)
        {
            refresh();
        }

        private void SwitchView(object sender, EventArgs e)
        {
            if(toolStripMenuItem6.Text == "View All Tickets")
            {
                viewName = allTickets;
                toolStripMenuItem6.Text = "Preferred View";

                refresh();
            }
            else if(toolStripMenuItem6.Text == "Preferred View")
            {
                viewName = SQL.RunString("select PreferredView from AccessITExpressTechnicians where displayname = @NAME", technicianName);
                toolStripMenuItem6.Text = "View All Tickets";

                refresh();
            }
        }

        private void loadTicket(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            const int fontSize = 3;

            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                Request r = AccessIT.getRequest(technicianName, id);

                List<Message> messages = AccessIT.getMessages(technicianName, id);
                List<Note> notes = AccessIT.getNotes(technicianName, id);
                string m = "";

                int nextMessage = messages != null ? messages.Count - 1 : -1;
                int nextNote = notes != null ? 0 : -1;

                while (nextMessage >= 0 || (nextNote < (notes != null ? notes.Count : 0) && nextNote != -1))
                {
                    Message message = nextMessage != -1 ? messages[nextMessage] : null;
                    Note note = nextNote != -1 && nextNote < notes.Count ? notes[nextNote] : null;

                    if (note == null || messages[nextMessage].createdDate > notes[nextNote].notesDate)
                    {
                        if (messages[nextMessage].from != "System")
                        {
                            m += "<font face=\"Arial\" size=\"" + fontSize + "\">";
                            m += "<table width=\"100%\" height=\"10px\"><tr><td bgcolor=\"#A5D6F7\"><b>" + messages[nextMessage].from + "</b><font color=\"#0E649E\" size=\"" + fontSize + "\"> on " + messages[nextMessage].createdDate.ToString("MMMM dd, yyyy  h:mm tt") + "</font></td></tr></table>";
                            m += messages[nextMessage].description;
                            m += "<br /><br /></font>";
                        }

                        nextMessage--;
                    }
                    else
                    {
                        m += "<font face=\"Arial\" size=\"" + fontSize + "\">";
                        m += "<table width=\"100%\" height=\"10px\"><tr><td bgcolor=\"#F4F7A5\"><b>" + notes[nextNote].username + "</b><font color=\"#999E0F\" size=\"" + fontSize + "\"> on " + notes[nextNote].notesDate.ToString("MMMM dd, yyyy  h:mm tt") + "</font></td></tr></table>";
                        m += notes[nextNote].notesText;
                        m += "<br /><br /></font>";

                        nextNote++;
                    }
                }

                webBrowser1.DocumentText = "<font face=\"Arial\" size=\"" + fontSize + "\">" + r.description.Replace("/inlineimages", "http://accessit:8080/inlineimages").Replace("<p>", "</br>").Replace("</p>", "") + "</font>";
                webBrowser2.DocumentText = m.Replace("/inlineimages", "http://accessit:8080/inlineimages").Replace("<p>", "</br>").Replace("</p>", "");
            }
        }

        private void PickUpTicket(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                
                AccessIT.assignTicket(technicianName, id, int.Parse(SQL.RunString("select TechnicianID from AccessITExpressTechnicians where displayname = @NAME", technicianName)));

                refresh();
            }
            else
                MessageBox.Show("Please select a ticket");
        }

        private void AssignToGroup(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                string groupName = ((ToolStripMenuItem)sender).OwnerItem.Tag.ToString();
                AccessIT.updateGroup(technicianName, id, groupName);
                
                refresh();
            }
            else
                MessageBox.Show("Please select a ticket");
        }

        private void AssignToTechnician(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int ticketID = int.Parse(listView1.SelectedItems[0].Text);
                string assignToTechnician = ((ToolStripMenuItem)sender).Text;

                AccessIT.updateGroup(technicianName, ticketID, SQL.RunString("select GroupName from AccessITExpressTechnicians where displayname = @NAME", assignToTechnician));
                AccessIT.assignTicket(technicianName, ticketID, int.Parse(SQL.RunString("select TechnicianID from AccessITExpressTechnicians where displayname = @NAME", assignToTechnician)));

                refresh();
            }
            else
                MessageBox.Show("Please select a ticket");
        }
        
        private void ReplyToTicket(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                bool success;
                string description = Core.getString("Message", true, out success).Replace(Environment.NewLine, "&lt;br /&gt;");

                if (!success)
                    return;

                AccessIT.reply(technicianName, id, description);

                loadTicket(null, null);
            }
            else
                MessageBox.Show("Please select a ticket");
        }

        private void AddNoteToTicket(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].Text);
                bool success;
                string description = Core.getString("Note", true, out success).Replace(Environment.NewLine, "&lt;br /&gt;");

                if (!success)
                    return;

                AccessIT.addNote(technicianName, id, description);

                loadTicket(null, null);
            }
            else
                MessageBox.Show("Please select a ticket");
        }
    }
}
