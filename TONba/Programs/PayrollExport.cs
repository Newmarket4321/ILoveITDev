using System;
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
    public partial class PayrollExport : Form
    {
        public PayrollExport()
        {
            InitializeComponent();

            Oracle ora = new Oracle("select Y6PAYD from CRPDTA.F07235 group by Y6PAYD order by Y6PAYD");
            DataTable dt = ora.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                checkedListBox1.Items.Add(dt.Rows[i][0].ToString());

            comboBox1.Items.Add(Core.getVariable("PayrollExportAccountNumber") + " Regular");
            comboBox1.Items.Add(Core.getVariable("PayrollExportAccountNumberLT") + " Long Term");

            comboBox1.SelectedIndex = 0;
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

                string accountNumber = "";

                Invoke((MethodInvoker)delegate
                {
                    accountNumber = comboBox1.Text.Split(' ')[0].Trim();
                });

                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    split += "'" + checkedListBox1.CheckedItems[i].ToString() + (i + 1 < checkedListBox1.CheckedItems.Count ? "', " : "'");

                if (split == "")
                    MessageBox.Show("Please select a payroll name");
                else
                {
                    Oracle ora = new Oracle("select * from CRPDTA.F07235 where Y6PAYD in (" + split + ") order by Y6PAYD, Y6MATH06");
                    DataTable dt = ora.Run();

                    while (!IsHandleCreated) ;

                    if (dt.Rows.Count > 0)
                    {
                        string output = "";
                        int fileCreationNumber = -1;
                        int lineNo = 1;
                        int totalNumTransactions = 0;
                        int totalValueTransactions = 0;
                        bool aLine = false;

                        Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Maximum = dt.Rows.Count;
                        });

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string line = dt.Rows[i]["Y6APTA"].ToString();

                            //int pos = 0;

                            //Header
                            if (line.Substring(0, 1) == "A" && !aLine)
                            {
                                aLine = true;

                                Invoke((MethodInvoker)delegate
                                {
                                    fileCreationNumber = int.Parse(numericUpDown1.Value.ToString());
                                //Oracle.Run("update prodctl.f0002 set nnn010 = " + (fileCreationNumber + 1) + " where nnsy='00  '");
                                //fileCreationNumber = int.Parse(Oracle.Run("select nnn009 from prodctl.f0002 where nnsy='00  '").Rows[0][0].ToString());
                                //Oracle.Run("update prodctl.f0002 set nnn009 = " + (fileCreationNumber + 1) + " where nnsy='00  '");
                            });

                                line = line.Substring(0, 1) + pad(lineNo++, 9) + line.Substring(10);
                                line = line.Substring(0, 20) + pad(fileCreationNumber, 4) + line.Substring(24);
                                output +=
    line +
    "                    " +
    "CAD" +
    "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      " +
    "0001" +
    "01" +
    textBox1.Text +
    accountNumber +
    "                                                                                                                                                                                                  " +
    Environment.NewLine;

                            }
                            else if (line.Substring(0, 1) == "C" || line.Substring(0, 1) == "D")
                            {
                                totalNumTransactions++;
                                totalValueTransactions += int.Parse(line.Substring(27, 10));

                                line = line.Substring(0, 1) + pad(lineNo++, 9) + line.Substring(10);
                                line = line.Substring(0, 20) + pad(fileCreationNumber, 4) + line.Substring(24);
                                line = line.Substring(0, 164) + line.Substring(10, 10) + line.Substring(174);
                                line = line.Substring(0, 193) + textBox1.Text + line.Substring(202);
                                line = line.Substring(0, 202) + padSpaces(accountNumber, 12) + line.Substring(214);
                                output +=
    line +
    "     " +
    "                      " +
    "01" +
    "00000000000" +
    "                                                                                                                                                                                                                                                " +
    "                                                                                                                                                                                                                                                " +
    "                                                                                                                                                                                                                                                " +
    "                                                                                                                                                                                                                                                " +
    "                                                                                                                                                                                                                                                " +
    Environment.NewLine;
                            }
                            else if (line.Substring(0, 1) == "Z" && i + 1 == dt.Rows.Count)
                            {
                                line = line.Substring(0, 1) + pad(lineNo++, 9) + line.Substring(10);
                                line = line.Substring(0, 20) + pad(fileCreationNumber, 4) + line.Substring(24);
                                line = line.Substring(0, 46) + pad(totalValueTransactions, 14) + line.Substring(60);
                                line = line.Substring(0, 60) + pad(totalNumTransactions, 8) + line.Substring(68);
                                output += line +
    "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    " +
    Environment.NewLine;
                            }

                            Invoke((MethodInvoker)delegate
                            {
                                progressBar1.Value = i;
                                progressBar1.Update();
                            });
                        }

                        Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = progressBar1.Maximum;
                            progressBar1.Update();

                            numericUpDown1.Value = numericUpDown1.Value + 1;

                            if (comboBox1.Text.Contains("Regular"))
                                Oracle.Run("update prodctl.f0002 set nnn010 = " + numericUpDown1.Value + " where nnsy = '00  '");
                            else //LTD
                            Oracle.Run("update prodctl.f0002 set nnn009 = " + numericUpDown1.Value + " where nnsy = '00  '");

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
            catch(Exception e2)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fileCreationNumber = 0;

            if (comboBox1.Text.Contains("Regular"))
                fileCreationNumber = int.Parse(Oracle.Run("select nnn010 from prodctl.f0002 where nnsy='00  '").Rows[0][0].ToString());
            else //LTD
                fileCreationNumber = int.Parse(Oracle.Run("select nnn009 from prodctl.f0002 where nnsy='00  '").Rows[0][0].ToString());

            numericUpDown1.Value = fileCreationNumber;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("Regular"))
                Oracle.Run("update prodctl.f0002 set nnn010 = " + numericUpDown1.Value + " where nnsy = '00  '");
            else //LTD
                Oracle.Run("update prodctl.f0002 set nnn009 = " + numericUpDown1.Value + " where nnsy = '00  '");

        }
    }
}
