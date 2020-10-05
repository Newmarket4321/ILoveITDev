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
    public partial class CloseWO : Form
    {

        //EAC
        static string environment = "PY";
        static string schema = Core.getSchema(environment);
        static string controlSchema = Core.getControlSchema(environment);
        public CloseWO()
        {
            InitializeComponent();
            Hide();
            Core.invoke(run);
        }
        public void run()
        {

            {
                string line;
                string woStatus= "99";
                int workOrder;
 

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
            

                line = reader.ReadLine();

                 while (line != null)
                {
                    workOrder = int.Parse(line.Substring(0,6));
                    // Search WO
                    Oracle ora = new Oracle("select F1EWST from " + schema + ".F1307 where F1DOCO=@WOID order by F1EFTB desc, F1BEGT desc");
                    ora.AddParameter("@WOID", workOrder);
                    int currentStatus = -1;
                    DataTable check = ora.Run();


                    ora = new Oracle(@"
update " + schema + @".F4801
set
WASRST=@SRST,
WAUPMJ=@UPMJ
where WADOCO=@WADOCO
");
                    ora.AddParameter("@SRST", woStatus);
                    ora.AddParameter("@UPMJ", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                    ora.AddParameter("@WADOCO", workOrder);
                    ora.Run();

                    if (check.Rows.Count > 0)
                    {
                        int.TryParse(check.Rows[0]["F1EWST"].ToString(), out currentStatus);

                     

                        // 01 - Defined
                        // 50 - Active
                        // 80 - Complete
                        // 99 - Closed
                   
                    
                        if (currentStatus.ToString().Trim() != "99") //It's not closed
                        {
                            if (currentStatus.ToString().Trim() == "01")
                            {
                                // Create record "80"
                                ora = new Oracle("insert into " + schema + ".F1307 values (@F1NUMR, @F1TREC, @F1EFTB, @F1BEGT, @F1EWST, @F1DOCO, @F1EFTE, @F1ENDT, @F1STHR, @F1CUMH, @F1LFR, @F1LHR, @F1LMR, @F1RMK, @F1USER, @F1PID, @F1JOBN, @F1UPMJ, @F1UPMT, @F1LM4R, @F1LM5R, @F1LM6R)");
                                ora.AddParameter("@F1NUMR", Oracle.Run("select WANUMB from " + schema + ".F4801 where WADOCO=" + workOrder).Rows[0]["WANUMB"].ToString());
                                ora.AddParameter("@F1TREC", Oracle.Run("select max(F1TREC) from " + schema + ".F1307 where F1DOCO=" + workOrder).Rows[0][0].ToString());
                                ora.AddParameter("@F1EFTB", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                                ora.AddParameter("@F1BEGT", getTime());
                                ora.AddParameter("@F1EWST", "80");
                                ora.AddParameter("@F1DOCO", workOrder);
                                ora.AddParameter("@F1EFTE", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                                ora.AddParameter("@F1ENDT", z(DateTime.Now.Hour.ToString()) + z(DateTime.Now.Minute.ToString()) + z(DateTime.Now.Second.ToString()));
                                ora.AddParameter("@F1STHR", "0");
                                ora.AddParameter("@F1CUMH", "0");
                                ora.AddParameter("@F1LFR", "0");
                                ora.AddParameter("@F1LHR", "0");
                                ora.AddParameter("@F1LMR", "0");
                                ora.AddParameter("@F1RMK", "                              ");
                                ora.AddParameter("@F1USER", "JDE");
                                ora.AddParameter("@F1PID", "CloseWO");
                                ora.AddParameter("@F1JOBN", "SQL2008R2");
                                ora.AddParameter("@F1UPMJ", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                                ora.AddParameter("@F1UPMT", getTime());
                                ora.AddParameter("@F1LM4R", "0");
                                ora.AddParameter("@F1LM5R", "0");
                                ora.AddParameter("@F1LM6R", "0");
                                ora.Run();
                            }

                            ora = new Oracle("update " + schema + ".F1307 set F1EFTE = @F1EFTE, F1ENDT=@F1ENDT where F1DOCO=@F1DOCO and F1EWST=@F1EWST");
                            ora.AddParameter("@F1DOCO", workOrder);
                            ora.AddParameter("@F1EFTE", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                            ora.AddParameter("@F1ENDT", getTime());
                            ora.AddParameter("@F1EWST", currentStatus);

                            ora.Run();

                            //Update max(status)'s end date

                            ora = new Oracle("insert into " + schema + ".F1307 values (@F1NUMR, @F1TREC, @F1EFTB, @F1BEGT, @F1EWST, @F1DOCO, @F1EFTE, @F1ENDT, @F1STHR, @F1CUMH, @F1LFR, @F1LHR, @F1LMR, @F1RMK, @F1USER, @F1PID, @F1JOBN, @F1UPMJ, @F1UPMT, @F1LM4R, @F1LM5R, @F1LM6R)");
                            ora.AddParameter("@F1NUMR", Oracle.Run("select WANUMB from " + schema + ".F4801 where WADOCO=" + workOrder).Rows[0]["WANUMB"].ToString());
                            ora.AddParameter("@F1TREC", Oracle.Run("select max(F1TREC) from " + schema + ".F1307 where F1DOCO=" + workOrder).Rows[0][0].ToString());
                            ora.AddParameter("@F1EFTB", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                            ora.AddParameter("@F1BEGT", getTime());
                            ora.AddParameter("@F1EWST", "99");
                            ora.AddParameter("@F1DOCO", workOrder);
                            ora.AddParameter("@F1EFTE", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                            ora.AddParameter("@F1ENDT", "0");
                            ora.AddParameter("@F1STHR", "0");
                            ora.AddParameter("@F1CUMH", "0");
                            ora.AddParameter("@F1LFR", "0");
                            ora.AddParameter("@F1LHR", "0");
                            ora.AddParameter("@F1LMR", "0");
                            ora.AddParameter("@F1RMK", "                              ");
                            ora.AddParameter("@F1USER", "JDE");
                            ora.AddParameter("@F1PID", "CloseWO");
                            ora.AddParameter("@F1JOBN", "SQL2008R2");
                            ora.AddParameter("@F1UPMJ", dateToJDE(DateTime.Today.ToString("MM/dd/yyyy")));
                            ora.AddParameter("@F1UPMT", getTime());
                            ora.AddParameter("@F1LM4R", "0");
                            ora.AddParameter("@F1LM5R", "0");
                            ora.AddParameter("@F1LM6R", "0");
                            ora.Run();
                        }
                    }
                    //Read next line on txt file

                    line = reader.ReadLine();
                    Core.passBack(this, delegate
                    {
                        progressBarDetailed1.Value++;
                    });
                }

                reader.Close();
                file.Close();

            }
        }



        //Takes a date in string format, and returns that string in JDE-style date
        static string dateToJDE(string date)
        {
            string returnable = "1";

            //"MM/dd/yyyy"
            DateTime temp = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(0, 2)), int.Parse(date.Substring(3, 2)));

            int year = temp.Year;
            int day = temp.DayOfYear;

            returnable += (year.ToString()).Substring(2, 2);

            if (day < 10)
                returnable += "00";
            else if (day < 100)
                returnable += "0";

            returnable += day;

            return returnable;
        }
        public static string getTime()
        {
            return DateTime.Now.Hour.ToString() + z(DateTime.Now.Minute.ToString()) + z(DateTime.Now.Second.ToString());
        }

        static string z(string x)
        {
            if (x.Length >= 2)
                return x;
            else
                return "0" + x;
        }
    }
}
