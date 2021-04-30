
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

    class FixPensionAdj
    {
        public FixPensionAdj()
        {


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            DataTable dt,dttx = null;

            string str,empid,yico,taxx,newLine;
            int rCnt;
            int rw = 0;
            int cl = 0;
            DateTime date = DateTime.Now;
            long amount;

            taxx = "";

            //  string path = @"c:\Apps\OutPut.txt";
            string path = @"c:\users\ealarcon\desktop\Working on\Output.txt";

            StreamWriter sw = new StreamWriter(path);

            //
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"c:\users\ealarcon\desktop\Working on\Book1.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            // start from row 2 - Header
            for (rCnt = 2; rCnt <= rw; rCnt++)
            {
 

                empid = (range.Cells[rCnt, 1] as Excel.Range).Value.ToString(); //EMployeeid
       
                str = (range.Cells[rCnt, 2] as Excel.Range).Value.ToString(); //Amount

                amount = long.Parse(str) * 100;

                Oracle ora = new Oracle("select yahmco,yatara from CRPDTA.f060116 where yaan8=@yaan8");
                ora.AddParameter("@yaan8", empid);

                dt = ora.Run();
                        
                if (dt.Rows.Count > 0)
                 {
                  
                    Oracle oratx = new Oracle("select *  from CRPDTA.f77230 where J8TAXYR= @J8TAXYR and J8AN8 = @J8AN8");
                    oratx.AddParameter("@J8TAXYR", 2020);
                    oratx.AddParameter("@J8AN8", int.Parse(empid));

                    dttx = oratx.Run();
                    if (dttx.Rows.Count > 0)
                    {

                        //update F77230 file
                        //try
                        //{

                        ora = new Oracle("update CRPDTA.f77230 set J8AMNT = @J8AMNT where (J8AN8 = @J8AN8 AND J8TAXYR= @J8TAXYR)");
                        ora.AddParameter("@J8TAXYR", 2020);
                        ora.AddParameter("@J8AN8", int.Parse(empid));
                        ora.AddParameter("@J8AMNT", amount);


                        ora.Run();

                        //}
                        //catch (Exception)
                        //{
                        //}
                    }
                    else
                    {
                        newLine = empid;
                        sw.WriteLine(newLine);
                    }
                }
                        //else
                        //{
                        //    newLine = str+" " + sfx+" "+ sfxdesc +" "+  " NOT FOUND";
                        //    sw.WriteLine(newLine);
                        //}
                             
            }
    
            sw.Close();
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
//            Core.sendMail("ealarcon@newmarket.ca", "FixPensionAdj", "Completed:" + DateTime.Now.ToString());

        }

    }
}




