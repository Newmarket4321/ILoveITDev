using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace I_IT
{
    public partial class JDEFTP : Form
    {
        public JDEFTP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            process();
        }

        private void process()
        {
            Directory.CreateDirectory("C:\\Newmarket FTP");

            using (StreamWriter sw = new StreamWriter("C:\\Newmarket FTP\\mgsftp.txt"))
            {
                string username = "";
                string password = "";
                string path = "";
                string server = "";

                username = "jde910";
                password = "jde910admin";
                path = "/jde/jdedwards/e910/import";
                server = "e1";

                string data = @"open " + server + @"
" + username + @"
" + password + @"
cd " + path + @"
ascii
put """ + openFileDialog1.FileName + @"""
bye
";

                sw.Write(data);
            }

            using (StreamWriter sw = new StreamWriter("C:\\Newmarket FTP\\mgsftp.bat"))
            {
                string data = @"ftp -s:""C:\\Newmarket FTP\\mgsftp.txt""";

                sw.Write(data);
            }

            progressBar1.Value = progressBar1.Maximum / 2;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = "/C \"C:\\Newmarket FTP\\mgsftp.bat\"";
            process.StartInfo = startInfo;
            process.Start();

            process.WaitForExit();

            progressBar1.Value = progressBar1.Maximum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Newmarket FTP");

            GetString box = new GetString("Attempt to grab a file with the filename...");
            box.ShowDialog();

            MessageBox.Show("Next, select where you'd like to put the file if found.");
            folderBrowserDialog1.ShowDialog();   
            
            if (folderBrowserDialog1.SelectedPath == "" || box.r == "")
            {

            }
            else
            {
                using (StreamWriter sw = new StreamWriter("C:\\Newmarket FTP\\mgsftp.txt"))
                {
                    string username = "";
                    string password = "";
                    string path = "";
                    string server = "";

                    username = "jde910";
                    password = "jde910admin";
                    path = "/jde/jdedwards/e910/export";
                    server = "e1";

                    string data = @"open " + server + @"
" + username + @"
" + password + @"
cd " + path + @"
ascii
lcd """ + folderBrowserDialog1.SelectedPath + @"""
get """ + box.r + @"""
bye
";

                    sw.Write(data);
                }

                using (StreamWriter sw = new StreamWriter("C:\\Newmarket FTP\\mgsftp.bat"))
                {
                    string data = @"ftp -s:""C:\\Newmarket FTP\\mgsftp.txt""";

                    sw.Write(data);
                }

                progressBar1.Value = progressBar1.Maximum / 2;

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";

                startInfo.Arguments = "/C \"C:\\Newmarket FTP\\mgsftp.bat\"";
                process.StartInfo = startInfo;
                process.Start();

                process.WaitForExit();

                progressBar1.Value = progressBar1.Maximum;
            }
        }

        //string output = "";

        //using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
        //{
        //    string line = "";
        //    while (!sr.EndOfStream)
        //    {
        //        line = sr.ReadLine();

        //        if(line.Substring(0, 3) == "88,")
        //        {
        //            string[] split = line.Split(',');

        //            if (split.Length >= 8 && split[2] == "" && split[3] == "" && split[4] == "" && split[5] == "" && split[6] == "" && split[7] == "")
        //            {
        //                //Empty 88 record, do nothing
        //            }
        //            else
        //                output += line + "\r\n"; //Valid 88 record
        //        }
        //        else
        //        {
        //            output += line + "\r\n"; //Valid non-88 record
        //        }
        //    }
        //}

        //if (!Directory.Exists("C:\\Bank Rec Pre-Processor"))
        //    Directory.CreateDirectory("C:\\Bank Rec Pre-Processor");

        //using (StreamWriter sw = new StreamWriter("C:\\Bank Rec Pre-Processor\\RBC.txt"))
        //{
        //    sw.Write(output);
        //}
    }
}
