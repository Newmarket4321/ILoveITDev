using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Collections;
using System.Text.RegularExpressions;

namespace I_IT
{
    public partial class MinutesOnline : Form
    {
        string[] xs;
        string[] itemNumberSubmission;
        DateTime releaseDate;

        public MinutesOnline()
        {
            InitializeComponent();
            minutesFound.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void process()
        {
            try
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Document doc = app.Documents.Open(openFileDialog1.FileName);

                app.Visible = false;

                string okay = doc.Sections.Count.ToString();

                string dateString = doc.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.Text;
                dateString = dateString.Substring(dateString.IndexOf("\r\r")).Trim();
                dateString = dateString.Substring(0, dateString.IndexOf('\r'));
                dateString = dateString.Replace(" at ", ", ");

                releaseDate = DateTime.Parse(dateString);

                ArrayList minuteNumbers = new ArrayList();
                ArrayList minuteNumberIndexes = new ArrayList();
                ArrayList minuteText = new ArrayList();
                string currentMinuteText = "";

                this.Invoke((MethodInvoker)delegate {
                    progressBar1.Enabled = true;
                    label1.Enabled = true;
                    minutesFound.Enabled = true;
                    progressBar1.Maximum = doc.Sentences.Count;

                    button1.Enabled = false;
                });

                for (int i = 1; i <= doc.Sentences.Count; i++)
                {
                    if (doc.Sentences[i].Text.Contains("Moved by:")) //Find the start of a vote
                    {
                        minuteNumberIndexes.Add(i);

                        bool found = false;
                        int firstNumber = -1;
                        int voteIndexStart = -1;

                        for (int j = i; j >= 1 && !found; j--) //Move backwards to find the first number
                        {
                            if (Regex.IsMatch(doc.Sentences[j].Text, @"\d+[.]\r\a")
                                && !doc.Sentences[j].Text.Contains(DateTime.Now.Year.ToString() + ".\r\a")
                                && !doc.Sentences[j].Text.Contains(DateTime.Now.AddYears(-1).Year.ToString() + ".\r\a"))
                            {
                                found = true;
                                firstNumber = int.Parse(Regex.Match(doc.Sentences[j].Text, @"\d+").Value);
                                voteIndexStart = j;
                            }
                        }

                        found = false;
                        int secondNumber = -1;
                        int voteIndexEnd = -1;

                        for (; i <= doc.Sentences.Count && !found; i++)
                        {
                            if (doc.Sentences[i].Text.Contains("Carried")) //Find the end of a vote
                            {
                                found = true;
                                voteIndexEnd = i;

                                bool found2 = false;

                                for (int j = i; j >= 1 && !found2; j--) //Move backwards to find the second number
                                {
                                    if (Regex.IsMatch(doc.Sentences[j].Text, @"\d+[.]\r\a")
                                        && !doc.Sentences[j].Text.Contains(DateTime.Now.Year.ToString() + ".\r\a")
                                        && !doc.Sentences[j].Text.Contains(DateTime.Now.AddYears(-1).Year.ToString() + ".\r\a"))
                                    {
                                        found2 = true;
                                        secondNumber = int.Parse(Regex.Match(doc.Sentences[j].Text, @"\d+").Value);
                                    }
                                }
                            }

                            this.Invoke((MethodInvoker)delegate
                            {
                                progressBar1.Value = i;
                                minutesFound.Text = minuteNumbers.Count + " movement" + (minuteNumbers.Count != 1 ? "s" : "") + " found";
                                button1.Visible = false;
                            });
                        }

                        currentMinuteText = "";

                        for (int x = voteIndexStart; x <= voteIndexEnd; x++)
                            currentMinuteText += doc.Sentences[x].Text;

                        string numberValue;

                        if (firstNumber == secondNumber)
                            numberValue = firstNumber.ToString();
                        else
                            numberValue = firstNumber + "-" + secondNumber;

                        minuteText.Add(currentMinuteText);
                        minuteNumbers.Add(numberValue);
                    }

                    this.Invoke((MethodInvoker)delegate {
                        progressBar1.Value = i;
                        minutesFound.Text = minuteNumbers.Count + " movement" + (minuteNumbers.Count != 1 ? "s" : "") + " found";
                        button1.Visible = false;
                    });
                }

                this.Invoke((MethodInvoker)delegate {
                    progressBar1.Value = progressBar1.Maximum;
                    progressBar1.Enabled = false;
                    label1.Enabled = false;
                    minutesFound.Enabled = false;
                });

                xs = new string[minuteNumbers.Count];
                itemNumberSubmission = new string[minuteNumbers.Count];

                //Process minutes
                for (int i = 0; i < minuteNumbers.Count; i++)
                {
                    xs[i] = minuteText[i].ToString();
                    string itemNumber = minuteNumbers[i].ToString();
                    itemNumberSubmission[i] = itemNumber;

                    int number = 1;
                    bool stop = false;

                    for (int j = i - 1; j >= 0 && !stop; j--)
                    {
                        if (minuteNumbers[i].ToString() == minuteNumbers[j].ToString())
                            number++;
                        else
                            stop = true;
                    }

                    if (number > 1)
                        itemNumberSubmission[i] = itemNumber + "(" + number + ")";

                    //submitVote(x, itemNumberSubmission, releaseDate);

                    if (xs[i].Contains("In Favour:\r\a")) //If a vote exists
                    {
                        string title = getTitle(xs[i]);

                        ListViewItem newItem = new ListViewItem(itemNumberSubmission[i]);
                        newItem.SubItems.Add(title);

                        this.Invoke((MethodInvoker)delegate { listView1.Items.Add(newItem); });
                    }

                    for (int c = 0; c < listView1.Columns.Count; c++)
                        this.Invoke((MethodInvoker)delegate { listView1.Columns[c].Width = -2; });
                }

                this.Invoke((MethodInvoker)delegate
                {
                    button2.Enabled = true;
                    listView1.Enabled = true;
                    progressBar3.Enabled = true;
                    progressBar3.Maximum = 10;
                });

                app.Quit();
            }
            catch(Exception e)
            {
                Core.error(e);
            }

            //this.Invoke((MethodInvoker)delegate {
            //    label2.Enabled = false;
            //    progressBar3.Value = progressBar3.Maximum;
            //    progressBar3.Enabled = false;
            //    label4.Visible = true;

            //    button1.Enabled = true;
            //});
        }

        private string getTitle(string x)
        {
            string title = x.Substring(x.IndexOf("\r\a") + "\r\a".Length);

            //If a by-law (2014-14)
            if (title.Length >= 7 && (title[0] == '1' || title[0] == '2') && (title[1] == '0' || title[1] == '9') &&
                (title[2] == '0' || title[2] == '1' || title[2] == '2' || title[2] == '3' || title[2] == '4' || title[2] == '5' || title[2] == '6' || title[2] == '7' || title[2] == '8' || title[2] == '9') &&
                (title[3] == '0' || title[3] == '1' || title[3] == '2' || title[3] == '3' || title[3] == '4' || title[3] == '5' || title[3] == '6' || title[3] == '7' || title[3] == '8' || title[3] == '9') &&
                title[4] == '-' &&
                (title[5] == '0' || title[5] == '1' || title[5] == '2' || title[5] == '3' || title[5] == '4' || title[5] == '5' || title[5] == '6' || title[5] == '7' || title[5] == '8' || title[5] == '9') &&
                (title[6] == '0' || title[6] == '1' || title[6] == '2' || title[6] == '3' || title[6] == '4' || title[6] == '5' || title[6] == '6' || title[6] == '7' || title[6] == '8' || title[6] == '9'))
            {
                title = title.Split('\r')[0] + " - " + title.Split('\r')[1];
                title = title.Replace("\r", "").Replace("\a", "").Trim();
            }
            else
                title = title.Substring(0, title.IndexOf("\r"));

            if (title.Contains("regarding"))
                title = title.Substring(title.IndexOf("regarding") + "regarding".Length).Trim();

            if (title.Length - 1 >= 0 && title[title.Length - 1] == '.')
                title = title.Substring(0, title.Length - 1); //Don't end in a period

            if (title.Length > 0)
                title = title[0].ToString().ToUpper() + title.Substring(1, title.Length - 1); //Capitalize first letter

            if (title.Length > 200)
                title = "MAXED";

            return title;
        }

        private void submitVote(string x, string itemNumber, DateTime releaseDate)
        {
            if (x.Contains("In Favour:\r\a")) //If a vote exists
            {
                string title = getTitle(x);

                //In Favour
                int start = x.IndexOf("In Favour:\r\a") + "In Favour:\r\a".Length;
                int length = x.IndexOf("Opposed:\r\a") - start;

                string favourString = x.Substring(start, length);

                while (favourString[favourString.Length - 1] == '\a' || favourString[favourString.Length - 1] == '\r' || favourString[favourString.Length - 1] == ',')
                    favourString = favourString.Substring(0, favourString.Length - 1);

                string[] inFavour = favourString.Trim().Split(',');

                for (int j = 0; j < inFavour.Length; j++)
                    inFavour[j] = inFavour[j].Trim();

                //Opposed
                start = x.IndexOf("Opposed:\r\a") + "Opposed:\r\a".Length;
                length = (x.Substring(start)).IndexOf(" in favour, ");

                string opposedString = x.Substring(start, length);

                while (opposedString[opposedString.Length - 1] == '\a' || opposedString[opposedString.Length - 1] == '\r' || favourString[favourString.Length - 1] == ',')
                    opposedString = opposedString.Substring(0, opposedString.Length - 1);

                string[] opposed = opposedString.Trim().Split(',');

                for (int j = 0; j < opposed.Length; j++)
                {
                    opposed[j] = opposed[j].Trim();

                    if (opposed[j].Contains('\r'))
                        opposed[j] = opposed[j].Substring(0, opposed[j].IndexOf('\r'));
                }

                string motionType = "-";

                if (x.Contains("be approved"))
                    motionType = "To be approved";
                else if (x.Contains("be adopted"))
                    motionType = "To be adopted";
                else if (x.Contains("be enacted"))
                    motionType = "To be enacted";
                else if (x.Contains("be received"))
                    motionType = "To be received";

                if (motionType == "-")
                {
                    if (x.Contains("approve"))
                        motionType = "To be approved";
                    else if (x.Contains("adopt"))
                        motionType = "To be adopted";
                    else if (x.Contains("enact"))
                        motionType = "To be enacted";
                    else if (x.Contains("receive"))
                        motionType = "To be received";
                }

                SQL sql = new SQL("use sire; insert into votingitems values (@RELEASEDATE, @ITEMNUMBER, @ITEMTITLE, @MOTIONTYPE, @DETAIL, @VOTESYES, @VOTESNO)");
                sql.AddParameter("@RELEASEDATE", releaseDate);
                sql.AddParameter("@ITEMNUMBER", itemNumber);
                sql.AddParameter("@ITEMTITLE", title);
                sql.AddParameter("@MOTIONTYPE", motionType);
                sql.AddParameter("@DETAIL", x);
                sql.AddParameter("@VOTESYES", inFavour.Length);
                sql.AddParameter("@VOTESNO", opposed[0].Contains("(None") ? 0 : opposed.Length);
                sql.Run();

                for (int i = 0; i < inFavour.Length; i++)
                {
                    sql = new SQL("use sire; insert into votes values (@PERSONNAME, @RELEASEDATE, @ITEMNUMBER, @VOTE)");
                    sql.AddParameter("@PERSONNAME", inFavour[i]);
                    sql.AddParameter("@RELEASEDATE", releaseDate);
                    sql.AddParameter("@ITEMNUMBER", itemNumber);
                    sql.AddParameter("@VOTE", true);
                    sql.Run();
                }

                for (int i = 0; i < opposed.Length; i++)
                {
                    if (!opposed[i].Contains("(None)"))
                    {
                        sql = new SQL("use sire; insert into votes values (@PERSONNAME, @RELEASEDATE, @ITEMNUMBER, @VOTE)");
                        sql.AddParameter("@PERSONNAME", opposed[i]);
                        sql.AddParameter("@RELEASEDATE", releaseDate);
                        sql.AddParameter("@ITEMNUMBER", itemNumber);
                        sql.AddParameter("@VOTE", false);
                        sql.Run();
                    }
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MethodInvoker myProcessStarter = new MethodInvoker(process);

            myProcessStarter.BeginInvoke(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            progressBar3.Maximum = xs.Length;

            for (int i = 0; i < xs.Length; i++)
            {
                submitVote(xs[i], itemNumberSubmission[i], releaseDate);
                progressBar3.Value = i + 1;
            }

            MessageBox.Show("Document has successfully uploaded.");

            listView1.Items.Clear();
            button1.Visible = true;
            listView1.Enabled = false;
            button1.Enabled = true;
            progressBar1.Value = 0;
            progressBar3.Value = 0;
        }
    }
}
