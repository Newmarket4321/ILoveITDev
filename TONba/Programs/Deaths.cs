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
    public partial class Deaths : Form
    {
        public Deaths()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                StringBuilder output = new StringBuilder(); //Much faster

                int transactionCount = 0;
                int totalAmount = 0;
                int originator = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];

                    //Header
                    if (line.Substring(9, 1) == "A" && i == 0) //Only grab the first header
                    {
                        originator = int.Parse(line.Substring(0, 8));
                        string fileDate = line.Substring(15, 4) + line.Substring(11, 4); //YYYYMMDD --> MMDDYYYY
                        string institutionNumber = "0010";
                        string branchNumber = "00002";
                        string accountNumber = "8193517";

                        output.Append(pad(originator, 10));
                        output.Append("000000000000000000000");
                        output.Append(fileDate);
                        output.Append(institutionNumber);
                        output.Append(branchNumber);
                        output.Append(accountNumber);
                        output.Append("0000000000000000000000000");
                        output.Append(Environment.NewLine);
                        output.Append("00000000000000000000000000000000000000000000000000000000000000000000000000000000");
                        output.Append(Environment.NewLine);
                        output.Append("00000000000000000000000000000000000000000000000000000000000000000000000000000000");
                        output.Append(Environment.NewLine);
                    }

                    //Detail
                    if (line.Substring(9, 2) == "D2")
                    {
                        string rollNumber = line.Substring(18, 19).Trim();
                        
                        if (rollNumber.Substring(0, 4) == "1948") //Remove 1948
                            rollNumber = rollNumber.Substring(4);

                        if (rollNumber.Length == 11) //Add missing zeroes
                            rollNumber += "0000";
                        
                        if (rollNumber.Length > 15)
                            rollNumber = rollNumber.Substring(0, 15);

                        while (rollNumber.Length < 15)
                            rollNumber += "0";

                        string traceNumber = line.Substring(82, 30).Trim();
                        while (traceNumber.Length < 30)
                            traceNumber = "0" + traceNumber;

                        int amount = int.Parse(line.Substring(48, 14)); //Zero fill to 10, no decimal
                        string date = line.Substring(179, 4) + line.Substring(175, 4); //YYYYMMDD --> MMDDYYYY
                        string clientName = line.Substring(194, 30); //Space filled to 30

                        label3.Text += amount + Environment.NewLine;
                        
                        output.Append("000000000000000");
                        output.Append(rollNumber);
                        output.Append("11388");
                        output.Append(traceNumber);
                        output.Append("820000000000000");
                        output.Append(Environment.NewLine);
                        output.Append(pad(amount, 10));
                        output.Append("0000000000");
                        output.Append(date);
                        output.Append("0000");
                        output.Append("                                             ");
                        output.Append("000");
                        output.Append(Environment.NewLine);
                        output.Append(clientName);
                        output.Append("00000000000000000000000000000000000000000000000000");
                        output.Append(Environment.NewLine);

                        transactionCount++;
                        totalAmount += amount;
                    }
                }
                
                //Footer
                output.Append(pad(originator, 10));
                output.Append("999999999999999999999");
                output.Append(pad(transactionCount, 6));
                output.Append(pad(totalAmount, 13));
                output.Append("000000000000000000000000000000");
                output.Append(Environment.NewLine);
                output.Append("00000000000000000000000000000000000000000000000000000000000000000000000000000000");
                output.Append(Environment.NewLine);
                output.Append("00000000000000000000000000000000000000000000000000000000000000000000000000000000");
                output.Append(Environment.NewLine);

                string path = saveFileDialog1.FileName;
                Clipboard.SetText(label3.Text);
                try
                {
                    System.IO.File.WriteAllText(path, output.ToString());

                    MessageBox.Show("Saved to " + path + "." + Environment.NewLine
                        + "The total amount was " + (double.Parse(totalAmount.ToString())/100).ToString("C2") + ".");
                }
                catch
                {
                    MessageBox.Show("Something didn't go as planned. The file did not save.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            textBox2.Text = saveFileDialog1.FileName;
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
