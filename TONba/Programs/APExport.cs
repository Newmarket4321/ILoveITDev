using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class APExport : Form
    {
        static string environment = "PY";

        //Pending EAC
        //static string environment = "PD";
        static string schema = Core.getSchema(environment);
        static string controlSchema = Core.getControlSchema(environment);

        bool actuallySendEmailsToVendors = true;

        public APExport()
        {
            InitializeComponent();

            if (environment != "PD")
                MessageBox.Show("The current environment is " + environment + " (test mode).");

            Oracle ora = new Oracle(@"
select DRDL01
from " + schema + @".F04571
join " + controlSchema + @".F0005 on " + schema + @".F04571.KHPYIN = trim(" + controlSchema + @".F0005.DRKY)
where " + controlSchema + @".F0005.DRSY = '00  '
and " + controlSchema + @".F0005.DRRT = 'PY'
group by DRDL01
order by DRDL01");
            DataTable dt = ora.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                checkedListBox1.Items.Add(dt.Rows[i][0].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.invoke(process);
        }

        private void process()
        {
            try
            {
                string split = "";

                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    split += "'" + checkedListBox1.CheckedItems[i].ToString() + (i + 1 < checkedListBox1.CheckedItems.Count ? "', " : "'");

                if (split == "")
                    MessageBox.Show("Please select a payment group");
                else
                {
                    //Oracle ora = new Oracle(@"select * from " + schema + @".F04571 where Y6PAYD in (" + split + ") order by Y6PAYD, Y6MATH06");
                    Oracle ora = new Oracle(@"
SELECT
 " + schema + @".F04572.KKHDC,
 " + schema + @".F04572.KKCKC,
 " + schema + @".F04572.KKDOCM,
 " + schema + @".F04572.KKPSTT,
 " + schema + @".F04572.KKAN8,
 " + schema + @".F04572.KKALPH,
 " + schema + @".F04572.KKDETL,
 " + schema + @".F04572.KKCO,
 " + schema + @".F04572.KKTNST,
 " + schema + @".F04572.KKCBNK,
 " + schema + @".F04572.KKPAAP,
 " + schema + @".F04572.KKDGJ,
 " + schema + @".F04572.KKUPMJ,
 " + schema + @".F04572.KKVLDT
FROM (" + schema + @".F04571
JOIN " + schema + @".F04572 ON " + schema + @".F04571.KHHDC = " + schema + @".F04572.KKHDC)
JOIN " + controlSchema + @".F0005 on " + schema + @".F04571.KHPYIN = trim(" + controlSchema + @".F0005.DRKY)

WHERE " + controlSchema + @".F0005.DRDL01 in (" + split + @")
AND " + controlSchema + @".F0005.DRSY = '00  '
AND " + controlSchema + @".F0005.DRRT = 'PY'
");
                    DataTable dt = ora.Run();

                    while (!IsHandleCreated) ;

                    if (dt.Rows.Count > 0)
                    {
                        string output = "";
                        int lineNo = 1;
                        int totalNumTransactions = 0;
                        double totalValueTransactions = 0;

                        Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Maximum = dt.Rows.Count;
                        });

                        //Header
                        output += "A";
                        output += pad(lineNo++, 9);
                        output += textBox3.Text; //Originator
                        output += pad(int.Parse(Oracle.Run("select NNN008 from " + controlSchema + @".F0002 where NNSY = '00'").Rows[0][0].ToString()), 4); //File creation number
                        output += "0" + DateTime.Today.Year.ToString().Substring(2, 2) + pad(DateTime.Today.DayOfYear, 3);
                        output += textBox3.Text.Substring(0, 5);
                        output += "                    ";
                        output += "CAD";
                        output += "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ";
                        output += "0001";
                        output += "01"; //Number of settlement accounts
                        output += textBox1.Text;
                        output += pad(int.Parse(textBox2.Text), 12);
                        output += "                                                                                                                                                                                             ";
                        output += Environment.NewLine;

                        ArrayList al = new ArrayList();

                        //Detail
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            totalNumTransactions++;

                            output += "C";
                            output += pad(lineNo++, 9);
                            output += textBox3.Text + pad(int.Parse(Oracle.Run("select NNN008 from " + controlSchema + @".F0002 where NNSY = '00'").Rows[0][0].ToString()), 4);
                            output += "430";
                            output += pad(int.Parse(dt.Rows[i]["KKPAAP"].ToString()), 10);

                            totalValueTransactions += int.Parse(dt.Rows[i]["KKPAAP"].ToString());
                            //Console.WriteLine("Adding " + int.Parse(dt.Rows[i]["KKPAAP"].ToString()));

                            DateTime kkvldt = Core.JDEToDate(dt.Rows[i]["KKVLDT"].ToString());

                            if (!al.Contains(kkvldt.ToString()))
                                al.Add(kkvldt.ToString());

                            //DateTime kkvldt = new DateTime(2017, 8, 8);
                            output += "0" + kkvldt.Year.ToString().Substring(2, 2) + pad(kkvldt.DayOfYear, 3);
                            output += dt.Rows[i]["KKTNST"].ToString().Trim();

                            for (int j = 0; dt.Rows[i]["KKTNST"].ToString().Trim().Length + j < 9; j++) //Pad right with spaces up to 12 characters
                                output += " ";

                            //output += dt.Rows[i]["KKTNST"].ToString();
                            output += dt.Rows[i]["KKCBNK"].ToString().Trim();

                            for (int j = 0; dt.Rows[i]["KKCBNK"].ToString().Trim().Length + j < 12; j++) //Pad right with spaces up to 12 characters
                                output += " ";

                            output += "0000000000000000000000";
                            output += "000";
                            output += "NEWMARKET      ";

                            string name = dt.Rows[i]["KKALPH"].ToString().Trim();

                            if (name.Length > 30)
                                name = name.Substring(0, 30);

                            output += name;

                            for (int j = 0; name.Length + j < 30; j++) //Pad right with spaces up to 12 characters
                                output += " ";

                            output += "TOWN OF NEWMARKET             ";
                            output += textBox3.Text;
                            output += dt.Rows[i]["KKAN8"].ToString().Trim();

                            for (int j = 0; dt.Rows[i]["KKAN8"].ToString().Trim().Length + j < 19; j++) //Pad right with spaces up to 12 characters
                                output += " ";

                            output += textBox1.Text;
                            output += textBox2.Text;

                            for (int j = 0; textBox2.Text.Length + j < 12; j++) //Pad right with spaces up to 12 characters
                                output += " ";

                            output += dt.Rows[i]["KKDOCM"].ToString().Trim();

                            for (int j = 0; dt.Rows[i]["KKDOCM"].ToString().Trim().Length + j < 15; j++) //Pad right with spaces up to 12 characters
                                output += " ";

                            output += "                      ";
                            output += "01";
                            output += "00000000000";
                            output += "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ";
                            output += Environment.NewLine;

                            Invoke((MethodInvoker)delegate
                            {
                                progressBar1.Value = i;
                                progressBar1.Update();
                            });
                        }

                        //Console.WriteLine("Total is " + totalValueTransactions.ToString("N0").Replace(",", ""));

                        //Footer
                        output += "Z";
                        output += pad(lineNo, 9);
                        output += textBox3.Text; //Originator
                        output += pad(int.Parse(Oracle.Run("select NNN008 from " + controlSchema + @".F0002 where NNSY = '00'").Rows[0][0].ToString()), 4); //File creation number
                        output += "00000000000000";
                        output += "00000000";
                        output += pad(totalValueTransactions, 14);
                        output += pad(totalNumTransactions, 8);
                        output += "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ";
                        output += Environment.NewLine;

                        Oracle.Run("update " + controlSchema + @".F0002 set NNN008 = NNN008 + " + al.Count + " where NNSY = '00'");

                        Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = progressBar1.Maximum;
                            progressBar1.Update();

                            SaveFileDialog test = new SaveFileDialog();
                            test.ShowDialog();

                            string path = test.FileName;

                            if (!path.ToLower().Contains(".txt"))
                                path = path + ".txt";

                            File.WriteAllText(path, output);

                            Core.run(path);

                            Close();
                        });
                    }
                    else
                        Invoke((MethodInvoker)delegate
                        {
                            Close();
                        });
                }
            }
            catch (Exception e2)
            {
                Core.error(e2);
            }
        }

        string padSpaces(string source, int totalLength)
        {
            while (source.Length < totalLength)
                source += " ";

            return source;
        }

        string convertDate(string date)
        {
            string year = date.Substring(0, 4);
            string dayOfYear = date.Substring(4, 3);

            return "0" + year.Substring(2, 2) + dayOfYear;
        }

        string get(string line, out int posOut, int pos, int length)
        {
            string r = line.Substring(pos, length);

            posOut = pos + length;

            return r;
        }

        string pad(int no, int length)
        {
            string r = no.ToString();

            while (r.Length < length)
                r = "0" + r;

            return r;
        }

        string pad(double no, int length)
        {
            string r = no.ToString("N0").Replace(",", "");

            while (r.Length < length)
                r = "0" + r;

            return r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string response = Core.lookupMessageBox("Are you sure?", "Has the text file been uploaded to the bank and validated?", "Yes", "No");

            if (response == "Yes")
            {
                int numRows = Oracle.Run("select * from " + schema + @".F04572").Rows.Count;

                if (numRows == 0)
                    Core.lookupMessageBox("Error", "Can't send e-mails, as batch has already been posted within JDE.");
                else
                {
                    string split = "";

                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                        split += "'" + checkedListBox1.CheckedItems[i].ToString() + (i + 1 < checkedListBox1.CheckedItems.Count ? "', " : "'");

                    if (split == "")
                        MessageBox.Show("Please select a payment group");
                    else
                    {
                        Oracle ora = new Oracle(@"
SELECT
e.EAEMAL,
d.KKALPH,
d.KKDOCM,
d.KKHDC,
d.KKCKC,
d.KKALPP,
d.KKPAAP,
m.A6CRMD,
d.KKAN8,
d.KKDGJ

FROM (" + schema + @".F04571 h
JOIN " + schema + @".F04572 d ON h.KHHDC = d.KKHDC)
JOIN " + controlSchema + @".F0005 u on h.KHPYIN = trim(u.DRKY)
JOIN " + schema + @".F0401 m on d.KKAN8 = m.A6AN8
LEFT JOIN " + schema + @".F01151 e ON d.KKAN8 = e.EAAN8

WHERE u.DRDL01 in (" + split + @")
AND u.DRSY = '00  '
AND u.DRRT = 'PY'
AND e.EAUPMJ =
   (SELECT max(e2.EAUPMJ)
    FROM " + schema + @".F01151 e2
    JOIN " + schema + @".F04572 d2 on e2.EAAN8 = d2.KKAN8
    WHERE d.KKHDC = d2.KKHDC
    AND d.KKCKC = d2.KKCKC)

GROUP BY
e.EAEMAL,
d.KKALPH,
d.KKDOCM,
d.KKHDC,
d.KKCKC,
d.KKALPP,
d.KKPAAP,
m.A6CRMD,
d.KKAN8,
d.KKDGJ
");
                        DataTable header = ora.Run();
                        Printer queue = new Printer();

                        //--------EAC-------
                       
                        string path = @"c:\data\"+ Text;
                        StreamWriter sw = new StreamWriter(path);

                        //----------------------

                        bool print = false;

                        int success = 0;
                        int cant = 0;
                        int invalid = 0;

                        for (int h = 0; h < header.Rows.Count; h++)
                        {
                            //UDC 00/SM
                            //  Print/Mail
                            //1 Fax
                            //2 EDI
                            //3 Email
                            //4 Post
                            //5 XPIx External Events
                            //0 No Notification

                            //E-mail
                            if (header.Rows[h]["A6CRMD"].ToString() == "3")
                            {
                                string content = "";

                                content += "<b>Please note this may take up to 48 hours to be deposited into your bank account.</b>";
                                content += Environment.NewLine;
                                content += Environment.NewLine + DateTime.Now.ToString("D");
                                content += Environment.NewLine + "Originator - TOWN OF NEWMARKET";
                                content += Environment.NewLine + "Receiver - " + header.Rows[h]["KKALPP"].ToString();
                                content += Environment.NewLine + "Contact - " + header.Rows[h]["KKALPH"].ToString();
                                content += Environment.NewLine + "Direct responses/queries to - " + Core.getVariable("APExportContact");
                                content += Environment.NewLine + "Payor - Town of Newmarket";
                                content += Environment.NewLine + "Trace No - " + header.Rows[h]["KKDOCM"].ToString();
                                content += Environment.NewLine + "Payment Amount - " + String.Format("{0:C}", double.Parse(header.Rows[h]["KKPAAP"].ToString()) / 100);
                                content += Environment.NewLine;
                                content += Environment.NewLine + "<table border=\"1\"><tr><td>Reference</td><td>Date</td><td>Discount</td><td>Amount Paid</td><td>Date Payment Released</td></tr>";

                                DataTable detail = getDetail(header.Rows[h]["KKHDC"].ToString(), header.Rows[h]["KKCKC"].ToString());

                                for (int d = 0; d < detail.Rows.Count; d++)
                                {
                                    content += "<tr>";
                                    content += "<td>" + detail.Rows[d]["KIVINV"].ToString() + "</td>";
                                    content += "<td>" + Core.JDEToDate(detail.Rows[d]["KIDIVJ"].ToString()).ToString("MMMM dd, yyyy") + "</td>";
                                    content += "<td align=\"right\">" + String.Format("{0:C}", double.Parse(detail.Rows[d]["KIADSA"].ToString()) / 100) + "</td>";
                                    content += "<td align=\"right\">" + String.Format("{0:C}", double.Parse(detail.Rows[d]["KIPAAP"].ToString()) / 100) + " </td>";
                                    content += "<td>" + Core.JDEToDate(header.Rows[h]["KKDGJ"].ToString()).ToString("MMMM dd, yyyy") + "</td>";
                                    content += "</tr>";
                                }

                                content += "</table>";
                                content += Environment.NewLine;
                                content += Environment.NewLine + "<i>The information contained in this message is directed in confidence solely to the person(s) named above and may not be otherwise distributed, copied or disclosed. The message may contain information that is privileged, confidential and exempt from disclosure under the Municipal Freedom of Information and Protection of Privacy Act. If you have received this message in error, please notify the sender immediately advising of the error and delete the message without making a copy. Thank you.</i>";

                                if (environment == "PD")
                                {
                                    bool result = sendAPEmail(int.Parse(header.Rows[h]["KKAN8"].ToString()), header.Rows[h]["EAEMAL"].ToString(), content);

                                    if (result)
                                        success++;
                                    else
                                        invalid++;
                                }
                                else
                                {
                                    bool result = sendAPEmail(int.Parse(header.Rows[h]["KKAN8"].ToString()), "ealarcon@newmarket.ca", content);

                                    if (result)
                                        success++;
                                    else
                                        invalid++;
                                }
                            }
                            //else if(header.Rows[h]["A6CRMD"].ToString() == "0")
                            //{

                            //}
                            else
                            {
                                string method = "";

                                if (header.Rows[h]["A6CRMD"].ToString().Trim() != "")
                                    method = Oracle.RunString("select DRDL01 from " + controlSchema + @".F0005 where trim(DRSY)='00' and trim(DRRT)='SM' and trim(DRKY) = @CODE", header.Rows[h]["A6CRMD"].ToString().Trim());
                                else
                                    method = Oracle.RunString("select DRDL01 from " + controlSchema + @".F0005 where trim(DRSY)='00' and trim(DRRT)='SM' and trim(DRKY) is null");

                                string emailAddress = "";

                                if (environment == "PD" && actuallySendEmailsToVendors)
                                    emailAddress = Core.getVariable("APExportContactList");
                                else
                                    emailAddress = "ealarcon@newmarket.ca";

                                Core.sendMail(emailAddress, "APExport vendor not contacted",
                                    "A vendor was not sent an e-mail because their contact method within JDE indicates they would rather be contacted another way." + Environment.NewLine
                                    + Environment.NewLine
                                    + "<b>Vendor:</b> " + header.Rows[h]["KKALPP"].ToString() + Environment.NewLine
                                    + "<b>Vendor number:</b> " + header.Rows[h]["KKAN8"].ToString() + Environment.NewLine
                                    + "<b>Preferred contact method:</b> " + method);
                                cant++;
                            }
                        }

                        MessageBox.Show(success + " vendors emailed successfully." + Environment.NewLine
                            + (cant > 0 ? cant + " vendors did not receive e-mails because their contact method within JDE indicates they would rather be contacted another way." : "") + Environment.NewLine
                            + (cant > 0 ? "E-mails have been sent to Teena, Sharon and Christine with more information." : ""));

                        if (invalid > 0)
                            MessageBox.Show(invalid + " vendors not contacted due to invalid e-mail address on file. See your e-mail for more information.");

                        if (print)
                            queue.Print();
                    }
                }
            }
            else
                Core.lookupMessageBox("Error", "That will need to be done before e-mails should be sent.");
        }

        private bool sendAPEmail(int vendorNumber, string email, string content)
        {
            try
            {
                if (actuallySendEmailsToVendors)
                {
                    Core.sendMail(email, "Payment Notification from Town of Newmarket", content, "paymentnotification@newmarket.ca", "paymentnotification", "Love2help");
                    Core.log(Name, "E-mail success", "SUCCESS - Vendor #" + vendorNumber + ", " + email);
                }

                return true;
            }
            catch(FormatException)
            {
                if (actuallySendEmailsToVendors)
                {
                    Core.sendMail(Core.getVariable("APExportContactList"), "Payment Notification Failure", "Attempted to send an e-mail to vendor #" + vendorNumber + " however, their e-mail was not in a correct format." + Environment.NewLine
                        + "E-mail address is: " + email + Environment.NewLine
                        + Environment.NewLine
                        + "Please go into JDE and correct this e-mail address, then send an individual e-mail to this vendor via the AP Export program in I♥IT.");
                    Core.log(Name, "E-mail failure", "FAILURE - Vendor #" + vendorNumber + ", " + email);
                }
            }

            return false;
        }

        private DataTable getDetail(string hdc, string ckc)
        {
            //Centralized to avoid duplication.
            Oracle ora = new Oracle(@"
select
" + schema + @".F04573.KIVINV,
min(" + schema + @".F04573.KIDIVJ) as KIDIVJ,
sum(" + schema + @".F04573.KIPAAP) as KIPAAP,
sum(" + schema + @".F04573.KIADSA) as KIADSA,
min(" + schema + @".F04573.KIDGJ) as KIDGJ

from " + schema + @".F04573

where " + schema + @".F04573.KIHDC = @HDC
and " + schema + @".F04573.KICKC = @CKC

group by " + schema + @".F04573.KIVINV
");
            ora.AddParameter("@HDC", hdc);
            ora.AddParameter("@CKC", ckc);

            return ora.Run();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numRows = Oracle.Run("select * from " + schema + @".F04572").Rows.Count;

            if (numRows == 0)
            {
                Core.lookupMessageBox("Error", "Can't print, as the batch has already been posted within JDE.");
            }
            else
            {
                string split = "";

                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    split += "'" + checkedListBox1.CheckedItems[i].ToString() + (i + 1 < checkedListBox1.CheckedItems.Count ? "', " : "'");

                if (split == "")
                    MessageBox.Show("Please select a payment group");
                else
                {
                    Oracle ora = new Oracle(@"
SELECT
d.KKALPH,
d.KKDOCM,
d.KKHDC,
d.KKCKC,
d.KKALPP,
d.KKPAAP,
m.A6CRMD,
d.KKAN8,
d.KKDGJ

FROM (" + schema + @".F04571 h
JOIN " + schema + @".F04572 d ON h.KHHDC = d.KKHDC)
JOIN " + controlSchema + @".F0005 u on h.KHPYIN = trim(u.DRKY)
JOIN " + schema + @".F0401 m on d.KKAN8 = m.A6AN8
LEFT JOIN " + schema + @".F01151 e ON d.KKAN8 = e.EAAN8

WHERE u.DRDL01 in (" + split + @")
AND u.DRSY = '00  '
AND u.DRRT = 'PY'
AND (e.EAUPMJ =
(SELECT max(e2.EAUPMJ)
FROM " + schema + @".F01151 e2
JOIN " + schema + @".F04572 d2 on e2.EAAN8 = d2.KKAN8
WHERE d.KKHDC = d2.KKHDC
AND d.KKCKC = d2.KKCKC)
or e.EAUPMJ is null)

GROUP BY
d.KKALPH,
d.KKDOCM,
d.KKHDC,
d.KKCKC,
d.KKALPP,
d.KKPAAP,
m.A6CRMD,
d.KKAN8,
d.KKDGJ

ORDER BY d.KKALPH
");
                    DataTable header = ora.Run();
                    Printer queue = new Printer();
                    bool print = false;

                    for (int h = 0; h < header.Rows.Count; h++)
                    {
                        print = true;

                        queue.AddBold("Payment Notification from Town of Newmarket");
                        queue.AddLine();
                        queue.AddLine();
                        queue.AddBold("Please note this may take up to 48 hours to be deposited into your bank account.");
                        queue.AddLine();
                        queue.AddLine();
                        queue.Add(DateTime.Now.ToString("D"));
                        queue.AddLine();
                        queue.Add("Originator - TOWN OF NEWMARKET");
                        queue.AddLine();
                        queue.Add("Vendor # - " + header.Rows[h]["KKAN8"].ToString());
                        queue.AddLine();
                        queue.AddLine();
                        queue.Add("Receiver - " + header.Rows[h]["KKALPP"].ToString());
                        queue.AddLine();
                        queue.AddLine();
                        queue.Add("Contact - " + header.Rows[h]["KKALPH"].ToString());
                        queue.AddLine();
                        queue.Add("Direct responses/queries to - " + Core.getVariable("APExportContact"));
                        queue.AddLine();
                        queue.Add("Payor - Town of Newmarket");
                        queue.AddLine();
                        queue.Add("Trace No - " + header.Rows[h]["KKDOCM"].ToString());
                        queue.AddLine();
                        queue.Add("Payment Amount - " + String.Format("{0:C}", double.Parse(header.Rows[h]["KKPAAP"].ToString()) / 100));
                        queue.AddLine();
                        queue.AddLine();
                        queue.Add("Reference");
                        queue.Add("Date", 150);
                        queue.Add("Discount", 300);
                        queue.Add("Amount Paid", 400);
                        queue.Add("Date Payment Released", 550);
                        queue.AddLine();

                        DataTable detail = getDetail(header.Rows[h]["KKHDC"].ToString(), header.Rows[h]["KKCKC"].ToString());

                        for (int d = 0; d < detail.Rows.Count; d++)
                        {
                            queue.Add(detail.Rows[d]["KIVINV"].ToString());
                            queue.Add(Core.JDEToDate(detail.Rows[d]["KIDIVJ"].ToString()).ToString("MMMM dd, yyyy"), 150);
                            queue.Add(String.Format("{0:C}", double.Parse(detail.Rows[d]["KIADSA"].ToString()) / 100), 300);
                            queue.Add(String.Format("{0:C}", double.Parse(detail.Rows[d]["KIPAAP"].ToString()) / 100), 400);
                            queue.Add(Core.JDEToDate(header.Rows[h]["KKDGJ"].ToString()).ToString("MMMM dd, yyyy"), 550);
                            queue.AddLine();
                        }

                        queue.AddLine();
                        queue.AddLine();
                        queue.AddItalics("The information contained in this message is directed in confidence solely to the person(s) named above and may not be otherwise distributed, copied or disclosed. The message may contain information that is privileged, confidential and exempt from disclosure under the Municipal Freedom of Information and Protection of Privacy Act. If you have received this message in error, please notify the sender immediately advising of the error and delete the message without making a copy. Thank you.");

                        queue.AddPage();
                    }

                    if (print)
                        queue.Print();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool success2;
            int vendorNumber = Core.getInt("Enter vendor number", out success2);

            if (!success2)
                return;

            string response = Core.lookupMessageBox("Are you sure?", "Has the text file been uploaded to the bank and validated?", "Yes", "No");

            if (response == "Yes")
            {
                int numRows = Oracle.Run("select * from " + schema + @".F04572").Rows.Count;

                if (numRows == 0)
                    Core.lookupMessageBox("Error", "Can't send e-mails, as batch has already been posted within JDE.");
                else
                {
                    string split = "";

                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                        split += "'" + checkedListBox1.CheckedItems[i].ToString() + (i + 1 < checkedListBox1.CheckedItems.Count ? "', " : "'");

                    if (split == "")
                        MessageBox.Show("Please select a payment group");
                    else
                    {
                        DataTable header = Oracle.Run(@"
SELECT
e.EAEMAL,
d.KKALPH,
d.KKDOCM,
d.KKHDC,
d.KKCKC,
d.KKALPP,
d.KKPAAP,
m.A6CRMD,
d.KKAN8,
d.KKDGJ

FROM (" + schema + @".F04571 h
JOIN " + schema + @".F04572 d ON h.KHHDC = d.KKHDC)
JOIN " + controlSchema + @".F0005 u on h.KHPYIN = trim(u.DRKY)
JOIN " + schema + @".F0401 m on d.KKAN8 = m.A6AN8
LEFT JOIN " + schema + @".F01151 e ON d.KKAN8 = e.EAAN8

WHERE u.DRDL01 in (" + split + @")
AND u.DRSY = '00  '
AND u.DRRT = 'PY'
AND d.KKAN8 = @VNO
AND e.EAUPMJ =
   (SELECT max(e2.EAUPMJ)
    FROM " + schema + @".F01151 e2
    JOIN " + schema + @".F04572 d2 on e2.EAAN8 = d2.KKAN8
    WHERE d.KKHDC = d2.KKHDC
    AND d.KKCKC = d2.KKCKC)

GROUP BY
e.EAEMAL,
d.KKALPH,
d.KKDOCM,
d.KKHDC,
d.KKCKC,
d.KKALPP,
d.KKPAAP,
m.A6CRMD,
d.KKAN8,
d.KKDGJ
", vendorNumber);

                        if(header.Rows.Count == 0)
                        {
                            MessageBox.Show("No vendors foundfound.");
                            return;
                        }

                        Printer queue = new Printer();
                        bool print = false;

                        int success = 0;
                        int cant = 0;
                        int invalid = 0;

                        //UDC 00/SM
                        //  Print/Mail
                        //1 Fax
                        //2 EDI
                        //3 Email
                        //4 Post
                        //5 XPIx External Events
                        //0 No Notification

                        //E-mail
                        if (header.Rows[0]["A6CRMD"].ToString() == "3")
                        {
                            string content = "";

                            content += "<b>Please note this may take up to 48 hours to be deposited into your bank account.</b>";
                            content += Environment.NewLine;
                            content += Environment.NewLine + DateTime.Now.ToString("D");
                            content += Environment.NewLine + "Originator - TOWN OF NEWMARKET";
                            content += Environment.NewLine + "Receiver - " + header.Rows[0]["KKALPP"].ToString();
                            content += Environment.NewLine + "Contact - " + header.Rows[0]["KKALPH"].ToString();
                            content += Environment.NewLine + "Direct responses/queries to - " + Core.getVariable("APExportContact");
                            content += Environment.NewLine + "Payor - Town of Newmarket";
                            content += Environment.NewLine + "Trace No - " + header.Rows[0]["KKDOCM"].ToString();
                            content += Environment.NewLine + "Payment Amount - " + String.Format("{0:C}", double.Parse(header.Rows[0]["KKPAAP"].ToString()) / 100);
                            content += Environment.NewLine;
                            content += Environment.NewLine + "<table border=\"1\"><tr><td>Reference</td><td>Date</td><td>Discount</td><td>Amount Paid</td><td>Date Payment Released</td></tr>";

                            DataTable detail = getDetail(header.Rows[0]["KKHDC"].ToString(), header.Rows[0]["KKCKC"].ToString());

                            for (int d = 0; d < detail.Rows.Count; d++)
                            {
                                content += "<tr>";
                                content += "<td>" + detail.Rows[d]["KIVINV"].ToString() + "</td>";
                                content += "<td>" + Core.JDEToDate(detail.Rows[d]["KIDIVJ"].ToString()).ToString("MMMM dd, yyyy") + "</td>";
                                content += "<td align=\"right\">" + String.Format("{0:C}", double.Parse(detail.Rows[d]["KIADSA"].ToString()) / 100) + "</td>";
                                content += "<td align=\"right\">" + String.Format("{0:C}", double.Parse(detail.Rows[d]["KIPAAP"].ToString()) / 100) + " </td>";
                                content += "<td>" + Core.JDEToDate(header.Rows[0]["KKDGJ"].ToString()).ToString("MMMM dd, yyyy") + "</td>";
                                content += "</tr>";
                            }

                            content += "</table>";
                            content += Environment.NewLine;
                            content += Environment.NewLine + "<i>The information contained in this message is directed in confidence solely to the person(s) named above and may not be otherwise distributed, copied or disclosed. The message may contain information that is privileged, confidential and exempt from disclosure under the Municipal Freedom of Information and Protection of Privacy Act. If you have received this message in error, please notify the sender immediately advising of the error and delete the message without making a copy. Thank you.</i>";

                            if (environment == "PD")
                            {
                                bool result = sendAPEmail(int.Parse(header.Rows[0]["KKAN8"].ToString()), header.Rows[0]["EAEMAL"].ToString(), content);

                                if (result)
                                    success++;
                                else
                                    invalid++;
                            }
                            else
                            {
                                bool result = sendAPEmail(int.Parse(header.Rows[0]["KKAN8"].ToString()), "ealarcon@newmarket.ca", content);

                                if (result)
                                    success++;
                                else
                                    invalid++;
                            }
                        }
                        //else if(header.Rows[0]["A6CRMD"].ToString() == "0")
                        //{

                        //}
                        else
                        {
                            string method = "";

                            if (header.Rows[0]["A6CRMD"].ToString().Trim() != "")
                                method = Oracle.RunString("select DRDL01 from " + controlSchema + @".F0005 where trim(DRSY)='00' and trim(DRRT)='SM' and trim(DRKY) = @CODE", header.Rows[0]["A6CRMD"].ToString().Trim());
                            else
                                method = Oracle.RunString("select DRDL01 from " + controlSchema + @".F0005 where trim(DRSY)='00' and trim(DRRT)='SM' and trim(DRKY) is null");

                            string emailAddress = "";

                            if (environment == "PD" && actuallySendEmailsToVendors)
                                emailAddress = Core.getVariable("APExportContactList");
                            else
                                emailAddress = "ealarcon@newmarket.ca";

                            Core.sendMail(emailAddress, "APExport vendor not contacted",
                                "A vendor was not sent an e-mail because their contact method within JDE indicates they would rather be contacted another way." + Environment.NewLine
                                + Environment.NewLine
                                + "<b>Vendor:</b> " + header.Rows[0]["KKALPP"].ToString() + Environment.NewLine
                                + "<b>Vendor number:</b> " + header.Rows[0]["KKAN8"].ToString() + Environment.NewLine
                                + "<b>Preferred contact method:</b> " + method);
                            cant++;
                        }

                        MessageBox.Show(success + " vendors emailed successfully." + Environment.NewLine
                            + (cant > 0 ? cant + " vendors did not receive e-mails because their contact method within JDE indicates they would rather be contacted another way." : "") + Environment.NewLine
                            + (cant > 0 ? "E-mails have been sent to Teena, Sharon and Shivonna with more information." : ""));

                        if (invalid > 0)
                            MessageBox.Show(invalid + " vendors not contacted due to invalid e-mail address on file. See your e-mail for more information.");

                        if (print)
                            queue.Print();
                    }
                }
            }
            else
                Core.lookupMessageBox("Error", "That will need to be done before e-mails should be sent.");
        }
    }
}
