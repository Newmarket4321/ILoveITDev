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
    public partial class ExportToMTO : Form
    {
        public ExportToMTO()
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
                string nlicence;
                string ndate;
                DateTime dissuedate;

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
                    if (line.Length > 24)
                    {
                        nlicence =line.Substring(4, 7);
                        nTicket = line.Substring(20, 8)+"%";
                        //ndate = line.Substring(14,6);
                        ndate = "20"+line.Substring(14, 2)+"-"+line.Substring(16, 2)+"-"+ line.Substring(18, 2);
                        dissuedate = Convert.ToDateTime(ndate);

                        dt = SQL.Run(@"select number , issuedate from Aims.dbo.T_Tickets where platenumber = @nlicence and convert(date, issuedate) = @dissuedate and number like @nTicket", nlicence,dissuedate,@nTicket);

                        if (dt.Rows.Count == 1)
                        {
                            //Ticket number was found
                            nTicket = line.Substring(35, 10);
                            dt = SQL.Run(@"select number , issuedate from Aims.dbo.T_Tickets where number = @nTicket", nTicket);
                            if (dt.Rows.Count > 0)
                            {
                                //    nYear = dt.Rows[0]["number"].ToString().Substring(2, 2);
                                nYear = dt.Rows[0]["number"].ToString();
                                newLine = line.Substring(0, 20) + nYear + line.Substring(29, 18);
                                sw.WriteLine(newLine);
                            }

                        }
                        else
                        {
                            // Ticket number not found
                            newLine = line.Substring(0, 135);
                            //sw.WriteLine(newLine);
                        }
                        line = reader.ReadLine();
                        Core.passBack(this, delegate
                        {
                            progressBarDetailed1.Value++;
                        });
                    }
                }

                reader.Close();
                sw.Close();
                file.Close();

            }
        }

    }
}
