
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;


namespace I_IT
{

    class FixARRemarks
    {
        public FixARRemarks()
        {


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            DataTable dt = null;

            string str,inv,sfx,sfxdesc,newLine;
            int rCnt;
            int rw = 0;
            int cl = 0;



            //  string path = @"c:\Apps\OutPut.txt";
            string path = @"c:\users\ealarcon\desktop\Working on\Output.txt";

            StreamWriter sw = new StreamWriter(path);

            //
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"c:\users\ealarcon\desktop\Working on\test2.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            // start from row 2 - Header
            for (rCnt = 2; rCnt <= rw; rCnt++)
            {
 

                inv = (range.Cells[rCnt, 4] as Excel.Range).Value.ToString(); //Doc Number
       
                str = (range.Cells[rCnt, 1] as Excel.Range).Value.ToString();
                sfx = (range.Cells[rCnt, 6] as Excel.Range).Value.ToString();
                sfxdesc = (range.Cells[rCnt, 29] as Excel.Range).Value.ToString();

                Oracle ora = new Oracle("select rpdoc, rpdct,rpkco, rpsfx, rpan8, rprmk from CRPDTA.F03b11 where rpdoc=@RPDOC and rpsfx=@RPSFX");
                        ora.AddParameter("@RPDOC", inv);
                        ora.AddParameter("@RPSFX", sfx);
                        dt = ora.Run();

                        if (dt.Rows.Count >= 1)
                        {
                    //load file
                    //try
                    //{
                    //    ora = new Oracle("update   CRPDTA.F03b11 set rprmk = @RPRMK where rpdoc=@RPDOC and rpsfx=@RPSFX");
                    //ora.AddParameter("@RPRMK", sfxdesc);
                    //ora.AddParameter("@RPDOC", inv);
                    //    ora.AddParameter("@RPSFX", sfx);

                    //    dt = ora.Run();
                    //}
                    //catch (Exception)
                    //{
                    //}

                    newLine = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString() + " " + dt.Rows[0][5].ToString() + " " + sfxdesc;
                    sw.WriteLine(newLine);
                }
                        else
                        {
                            newLine = str+" " + sfx+" "+ sfxdesc +" "+  " NOT FOUND";
                            sw.WriteLine(newLine);
                        }
                             
            }
    
            sw.Close();
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
//            Core.sendMail("ealarcon@newmarket.ca", "LicenceTracker", "Completed:" + DateTime.Now.ToString());

        }

    }
}




