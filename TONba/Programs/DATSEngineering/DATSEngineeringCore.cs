using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using ClosedXML.Excel;
using System.IO;
using System.Reflection;

namespace I_IT
{
    class DATSEngineeringCore
    {
        public static string getUsername()
        {
            string name = Environment.UserName;

            //if (Environment.MachineName == Core.getDevMachineName())
            //    name = "Ellis, Lisa";

            try
            {
                DATSEngineeringSQL sql = new DATSEngineeringSQL("select displayname from users where username=@NAME");
                sql.AddParameter("@NAME", name);
                name = sql.Run().Rows[0][0].ToString();

                name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1);

                for (int i = 1; i < name.Length; i++)
                    if (name[i - 1] == ' ')
                        name = name.Substring(0, i) + name[i].ToString().ToUpper() + name.Substring(i + 1, name.Length - i - 1);

                if (name.ToLower() == "mary-anne wigmore")
                    name = "Mary-Anne Wigmore";
            }
            catch
            {

            }

            return name;
        }

        public static string getDeploymentPath()
        {
            try
            {
                return @"T:\PCapps\DATS\" + Path.GetFileName(Assembly.GetEntryAssembly().Location);
            }
            catch
            {
                return "";
            }
        }

        public static bool isTimesheetLocked(int id)
        {
            DateTime date = DateTime.Parse(DATSEngineeringSQL.Run("select dateworked from timesheetdetail where timecarddetailid=" + id).Rows[0]["dateworked"].ToString());
            return isDateLocked(date);
        }

        public static bool isDateLocked(DateTime date)
        {
            return date <= getPeriodEnd(getPeriod(DateTime.Today.AddDays(-14)));
        }

        public static DateTime getPeriodStart(int x)
        {
            string year = x.ToString().Substring(2, 2);
            string period = '0' + x.ToString().Substring(4, 2);

            DataTable dt = Oracle.Run("select JDPPED from CRPDTA.F069066 where JDPCCD='SAL' and JDPPNB=" + period + " and JDDTEY=" + year);
            DateTime endDate = DATSEngineeringCore.JDEToDate(dt.Rows[0][0].ToString());

            return endDate.AddDays(-13);
        }

        public static DateTime getPeriodEnd(int x)
        {
            string year = x.ToString().Substring(2, 2);
            string period = '0' + x.ToString().Substring(4, 2);

            DataTable dt = Oracle.Run("select JDPPED from CRPDTA.F069066 where JDPCCD='SAL' and JDPPNB=" + period + " and JDDTEY=" + year);
            DateTime endDate = DATSEngineeringCore.JDEToDate(dt.Rows[0][0].ToString());

            return endDate;
        }

        public static void deleteTimesheet(int id)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("delete from timesheetdetail where timecarddetailid = @ID");
            sql.AddParameter("@ID", id);
            sql.Run();

            sql = new DATSEngineeringSQL("delete from equipmenttimeentry where timesheetid = @ID");
            sql.AddParameter("@ID", id);
            sql.Run();
        }

        public static void sendMail(string to, string subject, string body)
        {
            Core.sendMail(to, subject, body, "dats@newmarket.ca", "dats", "datsgood");
        }

        public static bool canEnterTimesheet(DateTime requestedDate)
        {
            DateTime startingMonday = getStartingMonday();
            DateTime cutoff = getTimeCutoff();

            if (requestedDate >= startingMonday)
                return true;
            else if (requestedDate < startingMonday.AddDays(-14))
                return false;
            else
            {
                if (DateTime.Now < cutoff)
                    return true;
                else
                    return false;

            }
        }

        public static DateTime getTimeCutoff()
        {
            DateTime cutoff = getStartingMonday();

            cutoff = cutoff.AddHours(8); //8:00AM

            return cutoff;
        }

        public static string getUsernameFromEmpID(int empID)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select displayname from users where employeeid = @EMPLOYEEID");
            sql.AddParameter("@EMPLOYEEID", empID);

            return sql.Run().Rows[0]["displayname"].ToString();
        }

        public static Color getPayTypeColor(string pt)
        {
            return Color.Green;
        }

        public static void export(string filename, DataTable dt)
        {
            XLWorkbook wb = new XLWorkbook();
            var ws = wb.Worksheets.Add(dt, "Report");

            string filePath = "C:\\DATS\"" + filename;
            string add = "";

            //Keep looking for file names untl you find one that doesn't exist.
            //Starts with filename.xlsx, then filename 2.xlsx, and so on.
            while (File.Exists(filePath + (add != "" ? " " : "") + add + ".xlsx"))
            {
                if (add == "")
                    add = "2";
                else
                    add = (int.Parse(add) + 1).ToString();
            }

            filePath += (add != "" ? " " : "") + add + ".xlsx";

            wb.SaveAs(filePath);

            System.Diagnostics.Process.Start(filePath);
        }

        public static int getPeriod(DateTime x)
        {
            string jdeDate = DATSEngineeringCore.dateToJDE(x.ToString());

            DataTable dt = Oracle.Run(@"
select
min(JDDTEY || JDPPNB)

from CRPDTA.F069066

where
JDPCCD='HR' and
JDPPED >= " + jdeDate);

            string temp = dt.Rows[0][0].ToString();

            return int.Parse("20" + temp.Substring(0, 2) + temp.Substring(3, 2));
        }

        public static void newTimesheet(string username, DateTime date, double hours, string workOrder, string description)
        {
            //Grab values
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select employeeid from users where displayname=@USERNAME");
            sql.AddParameter("@USERNAME", username);

            string employeeID = sql.Run().Rows[0][0].ToString();
            int period = getPeriod(date);
            
            DateTime startingMonday = date;

            while (startingMonday.DayOfWeek != DayOfWeek.Monday)
                startingMonday = startingMonday.AddDays(-1);

            sql = new DATSEngineeringSQL("select sum(t.hours) from timesheetdetail t, users u where t.dateworked >= @START and t.dateworked <= @END and t.employeeid = u.employeeid and u.username = @USERNAME");
            sql.AddParameter("@START", startingMonday);
            sql.AddParameter("@END", startingMonday.AddDays(7));
            sql.AddParameter("@USERNAME", username);

            double numHoursSoFar = 0;

            try
            {
                numHoursSoFar = double.Parse(sql.Run().Rows[0][0].ToString());
            }
            catch
            {

            }

            double regularHours;
            
            regularHours = hours;

            sql = new DATSEngineeringSQL(@"insert into timesheetdetail output inserted.timecarddetailid values(
                                    @CREATEUSER,
                                    @PERIOD,
                                    @EMPLOYEEID,
                                    @DATEWORKED,
                                    @HOURS,
                                    @WORKORDER,
                                    @DATEENTERED,
                                    @RECORDLOCKED,
                                    @EXPORTED,
                                    @BATCHID,
                                    @DESCRIPTION)");


            sql.AddParameter("@CREATEUSER", DATSEngineeringCore.getUsername());
            sql.AddParameter("@PERIOD", period);
            sql.AddParameter("@EMPLOYEEID", employeeID);
            sql.AddParameter("@DATEWORKED", date);
            sql.AddParameter("@HOURS", regularHours);

            if (workOrder != "" && workOrder != null)
                sql.AddParameter("@WORKORDER", workOrder);
            else
                sql.AddParameter("@WORKORDER", DBNull.Value);
            
            sql.AddParameter("@DATEENTERED", DateTime.Now);
            sql.AddParameter("@RECORDLOCKED", false);
            sql.AddParameter("@EXPORTED", false);
            sql.AddParameter("@BATCHID", 0);
            sql.AddParameter("@DESCRIPTION", description);

            DataTable output = sql.Run();
            int timesheetID = int.Parse(output.Rows[0][0].ToString());
        }

        public static void fillHoursCalendar(HoursCalendar hc, string username, DateTime targetDay)
        {
            //Calculate pay period
            //DATSEngineeringSQL sql = new DATSEngineeringSQL("select [from] from periods where [from]<=@DATE and [to]>=@DATE");
            //sql.AddParameter("@DATE", DateTime.Today);

            //DateTime startingMonday = DateTime.Parse(sql.Run().Rows[0][0].ToString());
            DATSEngineeringSQL sql;
            DateTime startingMonday = DATSEngineeringCore.getPeriodStart(DATSEngineeringCore.getPeriod(DateTime.Today));

            if (targetDay < startingMonday) //We are looking at the past
            {
                while (targetDay < startingMonday)
                    startingMonday = startingMonday.AddDays(-14);
            }
            else if (targetDay < startingMonday.AddDays(14)) //We are looking at the present
            {

            }
            else //We are looking at the future
            {
                while (startingMonday < targetDay)
                    startingMonday = startingMonday.AddDays(14);
            }

            sql = new DATSEngineeringSQL(
@"SELECT
t.[HOURS] as Hours,
t.DATEWORKED as FullDateWorked

FROM [TimeSheetDetail] t

INNER JOIN Users u ON t.employeeid = u.employeeid

WHERE u.displayname=@USERNAME
and t.dateworked >= @AFTERTHISDATE
and t.dateworked <= @BEFORETHISDATE

ORDER BY t.TIMECARDDETAILID ASC");
            sql.AddParameter("@AFTERTHISDATE", startingMonday);
            sql.AddParameter("@BEFORETHISDATE", startingMonday.AddDays(14));
            sql.AddParameter("@USERNAME", username);
            DataTable dt = sql.Run();

            hc.clearHours();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string fullDateWorked = dt.Rows[i]["FullDateWorked"].ToString();
                string hours = dt.Rows[i]["Hours"].ToString();

                hc.addHoursToDay(DateTime.Parse(fullDateWorked), decimal.Parse(hours));
            }
        }

        public static int getEmpID(string username)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select employeeid from users where displayname = @USERNAME");
            sql.AddParameter("@USERNAME", username);

            return int.Parse(sql.Run().Rows[0]["employeeid"].ToString());
        }

        public static bool isAdmin(string username)
        {
            return username == "Smyth, Graeme T." || username == "Umphrey, Susan";
        }

        public static bool canApprove(string username)
        {
            DATSEngineeringSQL sql = new DATSEngineeringSQL("select u.approver from Users u where u.displayname = @USERNAME");
            sql.AddParameter("@USERNAME", username);
            bool manager = bool.Parse(sql.Run().Rows[0]["approver"].ToString());

            return manager || isAdmin(username);
        }

        public static DateTime getStartingMonday()
        {
            return getStartingMonday(DateTime.Today);
        }

        public static DateTime getStartingMonday(DateTime date)
        {
            return getPeriodStart(getPeriod(date));
        }

        //Takes a date in string format, and returns that string in JDE-style date
        public static string dateToJDE(string date)
        {
            string returnable = "1";

            DateTime temp = DateTime.Parse(date);

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

        //Takes a date in JDE format, and returns that string as a date
        public static DateTime JDEToDate(string JDEDate)
        {
            int year = 0;
            int daysToAdd = 0;

            if (JDEDate.Length == 5)
            {
                year = int.Parse(JDEDate.Substring(0, 2)) + 1900;
                daysToAdd = int.Parse(JDEDate.Substring(2, 3));
            }
            else if (JDEDate.Length == 6)
            {
                if (JDEDate[0] == '0')
                    year = int.Parse(JDEDate.Substring(1, 2)) + 1900;
                else if (JDEDate[0] == '1')
                    year = int.Parse(JDEDate.Substring(1, 2)) + 2000;

                daysToAdd = int.Parse(JDEDate.Substring(3, 3));
            }

            DateTime date = new DateTime(year, 1, 1);

            date = date.AddDays(daysToAdd - 1);

            return date;
        }

        public static bool isUsernameTaken(string username)
        {
            bool returnable;

            DATSEngineeringSQL sql = new DATSEngineeringSQL("select count(*) from users where username=@USERNAME");
            sql.AddParameter("@USERNAME", username);

            returnable = (int.Parse(sql.Run().Rows[0][0].ToString()) >= 1);

            return returnable;
        }

        public static bool isEmpIDValid(string empID)
        {
            bool returnable = false;

            if (empID == null || empID == "")
                return false;

            try
            {
                Oracle ora = new Oracle("select YAAN8 from CRPDTA.F060116 where YAAN8 = :EMP_ID");
                ora.AddParameter("EMP_ID", int.Parse(empID));
                DataTable dt = ora.Run();

                returnable = dt.Rows.Count > 0; //If employeeID is valid
                //System.Diagnostics.Debug.WriteLine(dt.Rows[0][0].ToString());
            }
            catch (System.TypeInitializationException e2)
            {
                throw e2;
            }
            catch
            {
                return false;
            }
            return returnable;
        }
    }
}
