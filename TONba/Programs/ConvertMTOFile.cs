using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ConvertMTOFile : Form
    {
        public ConvertMTOFile()
        {
            InitializeComponent();
            Hide();
            Core.invoke(run);
        }
        public void run()
        {

            {
                string line, newLine;
                string nYear;
                string nTicket;


                //Get file
                Core.lookupMessageBox("", "On the next screen, select the txt file.");

                bool success = false;
                string filepath = "";

                Core.passBack(this, delegate { filepath = Core.getFile(out success); });


                if (!success)
                {
                    Core.lookupMessageBox("", "Not successful retrieving file.");
                    Core.passBack(this, delegate { Close(); });
                    return;
                }
                int numRows = File.ReadLines(filepath).Count();


                //Open Text file

                FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(file);

                
                Core.passBack(this, delegate
                {
                    Show();
                    progressBarDetailed1.Maximum = numRows;
                    progressBarDetailed1.Start();
                });

                //  string path = @"c:\Apps\OutPut.txt";

                string path = filepath.Substring(0, filepath.IndexOf(".") ) + "-Output.txt";

                StreamWriter sw = new StreamWriter(path);
              

                line = reader.ReadLine();

                DataTable dt = null;

                 while (line != null)
                {
                    nTicket = line.Substring(37, 8);
                   
                    dt = SQL.Run(@"select number , issuedate from Aims.dbo.T_Tickets where number = @nTicket",nTicket);

                    if (dt.Rows.Count == 0)
                    {
                        //Ticket number was not found
                        nTicket = line.Substring(35, 10);
                        dt = SQL.Run(@"select number , issuedate from Aims.dbo.T_Tickets where number = @nTicket", nTicket);
                        if (dt.Rows.Count > 0)
                        {
                            nYear = dt.Rows[0]["issuedate"].ToString().Substring(2, 2);
                            newLine = line.Substring(0, 35) + nYear + nTicket.Substring(0, 8) + line.Substring(45, 90);
                            sw.WriteLine(newLine);
                        }

                    }
                    else
                    {
                        newLine = line.Substring(0, 135);
                        sw.WriteLine(newLine);
                    }                                        
                    line = reader.ReadLine();
                    Core.passBack(this, delegate
                    {
                        progressBarDetailed1.Value++;
                    });
                }

                reader.Close();
                sw.Close();
                file.Close();

            }
        }

    }
}
