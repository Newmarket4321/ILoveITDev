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
    public partial class PAPFileConversion : Form
    {
        public PAPFileConversion()
        {
            InitializeComponent();

            Core.invoke(process);
        }

        private void process()
        {
            bool dateError = false;
            string fileCreationDate = "";

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                while (!IsHandleCreated) ;
                Invoke((MethodInvoker)delegate {
                    openFileDialog1.ShowDialog();
                });

                if (openFileDialog1.FileName != "")
                {
                    string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                    StringBuilder output = new StringBuilder();
                    //string output = "";
                    string fileCreationNumber = "";
                    int lineNo = 1;

                    //int sumNumber = 0;
                    //int sumAmount = 0;

                    Invoke((MethodInvoker)delegate
                    {
                        progressBar1.Maximum = lines.Length;
                    });

                    DateTime startTime = DateTime.Now;

                    for (int i = 0; i < lines.Length && !dateError; i += 2)
                    {
                        string line = lines[i] + lines[i + 1].Substring(6);
                        int pos = 0;

                        //Header
                        if (line.Substring(6, 1) == "A")
                        {
                            string lineNumber = get(line, out pos, pos, 6);
                            string recordType = get(line, out pos, pos, 1); //A
                            string transactionType = get(line, out pos, pos, 3);
                            string originatorNumber = get(line, out pos, pos, 10);
                            string clientName = get(line, out pos, pos, 30);
                            fileCreationNumber = get(line, out pos, pos, 4);
                            fileCreationDate = get(line, out pos, pos, 7);
                            string currencyType = get(line, out pos, pos, 3);
                            string inputType = get(line, out pos, pos, 1);

                            output.Append(recordType);
                            output.Append(pad(lineNo++, 9));
                            output.Append("0102025827");
                            output.Append(fileCreationNumber);
                            output.Append(convertDate(fileCreationDate));
                            output.Append("01020");
                            output.Append("                    ");
                            output.Append(currencyType);
                            for (int j = 0; j < 1190; j++)
                                output.Append(" ");
                            output.Append("0001");
                            output.Append("01");
                            output.Append("001000002");
                            output.Append("8193517     ");
                            for (int j = 0; j < 9 * 21; j++)
                                output.Append(" ");
                            output.Append(Environment.NewLine);
                        }

                        //Detail
                        if (line.Substring(6, 1) == "D")
                        {
                            string lineNumber = get(line, out pos, pos, 6);
                            string recordType = get(line, out pos, pos, 1); //D
                            string transactionType = get(line, out pos, pos, 3);
                            string originatorNumber = get(line, out pos, pos, 10);
                            pos += 1;
                            string customerNumber = get(line, out pos, pos, 19); //Roll number
                            string paymentNumber = get(line, out pos, pos, 2);
                            string bankNumber = get(line, out pos, pos, 4);
                            string institutionNumber = get(line, out pos, pos, 5);
                            string accountNumber = get(line, out pos, pos, 18);
                            pos += 1;
                            string paymentAmount = get(line, out pos, pos, 10);
                            string date = get(line, out pos, pos, 7);

                            dateError = checkForError(fileCreationDate, date);

                            string customerName = get(line, out pos, pos, 30);
                            string languageCode = get(line, out pos, pos, 1);
                            pos += 1;
                            string clientShortName = get(line, out pos, pos, 15);
                            string destinationCurrency = get(line, out pos, pos, 3);
                            pos += 1;
                            string destinationCountry = get(line, out pos, pos, 3);
                            pos += 4;
                            string optionalIndicator = get(line, out pos, pos, 1);

                            output.Append("D");
                            output.Append(pad(lineNo++, 9));
                            output.Append("0102025827");
                            output.Append(fileCreationNumber);
                            output.Append(transactionType);
                            output.Append(paymentAmount);
                            output.Append(convertDate(date));
                            output.Append("0" + bankNumber.Substring(1, 3) + institutionNumber);
                            output.Append(accountNumber.Substring(0, 12));
                            output.Append("0000000000000000000000");
                            output.Append("000");
                            output.Append(clientShortName);
                            output.Append(customerName);
                            output.Append("TOWN OF NEWMARKET             ");
                            output.Append("0102025827");
                            output.Append(customerNumber);
                            output.Append("001000002");
                            output.Append("8193517     ");
                            output.Append("PROPERTY TAX   ");
                            output.Append("                      ");
                            output.Append("01");
                            output.Append("00000000000");
                            output.Append("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ");
                            output.Append(Environment.NewLine);

                            Invoke((MethodInvoker)delegate
                            {
                                progressBar1.Value = i;
                                progressBar1.Update();

                                try
                                {
                                    TimeSpan timeSpent = DateTime.Now - startTime;
                                    double secondsRemaining = timeSpent.TotalSeconds * (lines.Length - i) / i;
                                    DateTime finish = DateTime.Now.AddSeconds(secondsRemaining);

                                    progressBar1.Value++;
                                    progressBar1.Update();
                                    label1.Text = finish.ToString("T") + " (" + (progressBar1.Value + 1).ToString() + " / " + progressBar1.Maximum.ToString() + ")";
                                    label1.Update();
                                }
                                catch
                                {

                                }
                            });
                        }

                        //Footer
                        if (line.Substring(6, 1) == "Z")
                        {
                            string lineNumber = get(line, out pos, pos, 6);
                            string recordType = get(line, out pos, pos, 1); //Z
                            string transactionCode = get(line, out pos, pos, 3); //TRL
                            string originatorNumber = get(line, out pos, pos, 10); //Same as header
                            pos += 20;
                            string totalNumberTransactions = get(line, out pos, pos, 6);
                            string totalValueTransactions = get(line, out pos, pos, 14);
                            pos += 2;
                            string totalOptional = get(line, out pos, pos, 6);

                            output.Append(recordType);
                            output.Append(pad(lineNo++, 9));
                            output.Append("0102025827");
                            output.Append(fileCreationNumber);
                            output.Append(totalValueTransactions); //Debit
                            output.Append("00" + totalNumberTransactions); //Debit
                            output.Append("00000000000000"); //Credit
                            output.Append("00000000"); //Credit
                            for (int j = 0; j < 1396; j++)
                                output.Append(" ");
                            output.Append(Environment.NewLine);
                        }
                    }

                    if (!dateError)
                    {

                        Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = progressBar1.Maximum;
                            progressBar1.Update();
                            label1.Text = DateTime.Now.ToString("T") + " (" + progressBar1.Maximum.ToString() + " / " + progressBar1.Maximum.ToString() + ")";
                            label1.Update();

                            saveFileDialog1.ShowDialog();
                        });

                        string path = saveFileDialog1.FileName;

                        try
                        {
                            System.IO.File.WriteAllText(path, output.ToString());

                            MessageBox.Show("Saved to " + path);
                        }
                        catch
                        {
                            MessageBox.Show("Something didn't go as planned. The file did not save.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: DueDate < CreationDate. Records in this file have a due date that occurs before the file creation date. This would likely cause the bank to take money before they should.");
                    }

                    Invoke((MethodInvoker)delegate
                    {
                        Close();
                    });
                }
                else
                    Invoke((MethodInvoker)delegate
                    {
                        Close();
                    });
            }
            catch(Exception e2)
            {
                Core.error(e2);
            }
        }

        string convertDate(string date)
        {
            string year = date.Substring(0, 4);
            string dayOfYear = date.Substring(4, 3);

            return "0" + year.Substring(2, 2) + dayOfYear;
        }

        bool checkForError(string fileCreationDate, string date)
        {
            DateTime creation = new DateTime(int.Parse(fileCreationDate.Substring(0, 4)), 1, 1);
            creation = creation.AddDays(double.Parse(fileCreationDate.Substring(4,3)) - 1);

            DateTime due = new DateTime(int.Parse(date.Substring(0, 4)), 1, 1);
            due = due.AddDays(double.Parse(date.Substring(4, 3)) - 1);

            return due < creation;
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
    }
}
