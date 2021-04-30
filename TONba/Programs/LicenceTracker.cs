
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

    class LicenceTracker 
    {
        public LicenceTracker()
        {


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            DataTable dtResults = null;

            string str;
            int rCnt;
            int rw = 0;
            int cl = 0;



            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"c:\users\ealarcon\desktop\Copy of 2021 Business Licence File Tracker.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            // start from row 3
            for (rCnt = 3; rCnt <= rw; rCnt++)
            {
                str = (string)(range.Cells[rCnt, 1] as Excel.Range).Value2;

                str = str.Substring(0, 6) + str.Substring(7, 5);
                //                 str = str.Trim(new char[] { '-',' ' });
                dtResults = SQL.Run(@"select * from [TonApps].[dbo].[LicenceTracker] where LicenceNumber =@LicenceNumber ", str);
                if (dtResults.Rows.Count == 0)
                {
                    if (String.IsNullOrWhiteSpace((string)(range.Cells[rCnt, 3] as Excel.Range).Value2))
                    { }
                    else

                        SQL.Run("insert into [TonApps].[dbo].[LicenceTracker] values(@LicenceNumber,@BusinessName, @Classification, @Status)", str, (string)(range.Cells[rCnt, 3] as Excel.Range).Value2, (string)(range.Cells[rCnt, 4] as Excel.Range).Value2, (string)(range.Cells[rCnt, 7] as Excel.Range).Value2);
                }
                else
                {
                    SQL.Run("update [TonApps].[dbo].[LicenceTracker] set BusinessName =@BusinessName, Classification= @Classification, Status = @Status where LicenceNumber = @LicenceNumber", (string)(range.Cells[rCnt, 3] as Excel.Range).Value2, (string)(range.Cells[rCnt, 4] as Excel.Range).Value2, (string)(range.Cells[rCnt, 7] as Excel.Range).Value, str);
                }

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
//            Core.sendMail("ealarcon@newmarket.ca", "LicenceTracker", "Completed:" + DateTime.Now.ToString());

        }

    }
}




