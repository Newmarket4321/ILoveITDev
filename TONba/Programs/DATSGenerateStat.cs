using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I_IT
{
    class DATSGenerateStat
    {
        static DATSGenerateStat()
        {
            /*
            Weeks ending on Sunday (inclusive)
            Take sum of 4 weeks prior, not including week of stat

            Multiply by rate of pay
            Multiply by 1.04
            Divide by 20 (days)
            Divide by rate of pay
            Result is in hours, round to .0, .25, .5, .75.

            The rounding goes as follows:
            0 - .13  Delete the hours
            .14 - .30 = .25
            .31 - .60 = .50
            .61 - .80 = .75
            .81 - 1.13 = 1 hour
            */

            //List of who we're looking at
            DataTable dt = SQL.Run(@"
use DATS;
select employeeid,
username

from users u

join departmentassociations da on u.userid = da.userid

group by
employeeid,
username");

            DateTime today = DateTime.Today;
            DateTime to = today;

            while (to.DayOfWeek != DayOfWeek.Sunday)
                to = to.AddDays(-1);

            DateTime from = to.AddDays(-27);
            string output = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string employeeID = dt.Rows[i]["employeeid"].ToString();
                string username = dt.Rows[i]["username"].ToString();
                bool good = true;

                Oracle ora = new Oracle("select YAEST from CRPDTA.F060116 where YAUN <> 'XGRD  ' and YAEST <> ' ' and YAEST <> '5' and YAAN8 = " + employeeID);

                good = ora.Run().Rows.Count >= 1;

                if (good)
                {
                    DataTable hdt = SQL.Run(@"
use DATS;
select SUM(hours) from timesheets t
join PayCodes p on t.PayType = p.PayType
where employeeid = @EMPID and dateworked >= @FROM and t.paytype <> 0 and dateworked <= @TO
and p.RegYN <> 0", employeeID, from, to);

                    if (hdt.Rows.Count > 0 && hdt.Rows[0][0].ToString() != "")
                    {
                        double hours = double.Parse(hdt.Rows[0][0].ToString());

                        hours = hours * 1.04 / 20;
                        string temp = hours.ToString() + "000";
                        int dec = int.Parse(temp.Substring(temp.IndexOf('.') + 1, 3));

                        hours = (int)hours;

                        if (dec >= 0 && dec <= 134)
                        {
                            //Do nothing
                        }
                        else if (dec >= 135 && dec <= 304)
                            hours += 0.25;
                        else if (dec >= 305 && dec <= 604)
                            hours += 0.5;
                        else if (dec >= 605 && dec <= 804)
                            hours += 0.75;
                        else if (dec >= 805)
                            hours += 1;

                        output += username + "\t (" + employeeID + ") \t" + hours + Environment.NewLine;
                    }
                }
            }

            if (isHolidayForFulltime(today))
            {
                // dt = SQL.Run("use DATS; select employeeid from users u join departmentassociations da on u.userid = da.userid where u.active=1 and u.emptype <> 'S'  group by employeeid");

                dt = SQL.Run("use DATS; select employeeid from users u join departmentassociations da on u.userid = da.userid where u.active=1  group by employeeid");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string employeeID = dt.Rows[i]["employeeid"].ToString();
                    // string employeeID = "106051";
                    //if (employeeID != "999999"
                    //    && isFullTime(employeeID)
                    //    && !isIT(employeeID)
                    //    && !isPayroll(employeeID)
                    //    && (!isFacilities(employeeID) || isOpsAdmin(employeeID))
                    //    && !alreadyHasStat(employeeID, today))
                    if (employeeID != "999999" && isFullTime(employeeID)
                        && (!isFacilities(employeeID) || isOpsAdmin(employeeID))
                        && !alreadyHasStat(employeeID, today)
                        )
                    {
                        createStat(employeeID, today);
                    }
                }
            }

            ///NOT ALWAYS 8
        }

        public static bool alreadyHasStat(string employeeID, DateTime today)
        {
            SQL sql = new SQL("use DATS; select * from timesheets where paytype=811 and dateworked=@TODAY and employeeid=@EMPID");
            sql.AddParameter("@TODAY", today);
            sql.AddParameter("@EMPID", employeeID);
            return sql.Run().Rows.Count > 0;
        }

        public static void createStat(string empID, DateTime today)
        {
            Oracle ora = new Oracle(@"
select YAEST from CRPDTA.F060116 where YAAN8 = @EMPNO");
            ora.AddParameter("@EMPNO", empID);
            string code  = ora.Run().Rows[0]["YAEST"].ToString().Trim();
            

            //   Full - time Regular
            //1  Part - Time Casual
            //2  Part - Time Hourly
            //3  Contract
            //4  Elected Officials
            //5  Full Time Hourly
            //6  Contract Salary
            //7  LTD
            float Hours = 0;

            if (code == "")
                Hours = 7;
            else if (code == "5")
                Hours = 8;
           //else if (isFacilities(empID) && isFullTime(empID))
           //     Hours = 8;

            SQL sql = new SQL(@"use DATS; insert into timesheets output inserted.timecarddetailid values(
                                    @CREATEUSER,
                                    @PERIOD,
                                    @EMPLOYEEID,
                                    @DATEWORKED,
                                    @PAYTYPE,
                                    @HOURS,
                                    @WORKORDER,
                                    @LUMPSUM,
                                    @OVERRIDERATE,
                                    @DATEENTERED,
                                    @RECORDLOCKED,
                                    @TRANSACTIONTYPE,
                                    @EXPORTED,
                                    @BATCHID,
                                    @DESCRIPTION,
                                    @STARTTIME,
                                    @FINISHTIME,
                                    @REVIEWED)");

            sql.AddParameter("@CREATEUSER", "StatGenerator");
            sql.AddParameter("@PERIOD", getPeriod(today));
            sql.AddParameter("@EMPLOYEEID", empID);
            sql.AddParameter("@DATEWORKED", today);
            sql.AddParameter("@PAYTYPE", 811);
            sql.AddParameter("@HOURS", Hours);
            sql.AddParameter("@WORKORDER", DBNull.Value);
            sql.AddParameter("@LUMPSUM", 0);
            sql.AddParameter("@OVERRIDERATE", DBNull.Value);
            sql.AddParameter("@DATEENTERED", DateTime.Now);
            sql.AddParameter("@RECORDLOCKED", false);
            sql.AddParameter("@TRANSACTIONTYPE", DBNull.Value);
            sql.AddParameter("@EXPORTED", false);
            sql.AddParameter("@BATCHID", 0);
            sql.AddParameter("@DESCRIPTION", "");
            sql.AddParameter("@STARTTIME", "");
            sql.AddParameter("@FINISHTIME", "");
            sql.AddParameter("@REVIEWED", false);

            DataTable output = sql.Run();
            int timesheetID = int.Parse(output.Rows[0][0].ToString());

            logHistory("New timesheet", "Timesheet ID# " + timesheetID, "");
            logTimesheetHistory("Timesheet created", timesheetID);
        }

        public static int getPeriod(DateTime x)
        {
            string jdeDate = Core.dateToJDE(x.ToString());

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

        public static void logHistory(string eventStr, string dataFrom, string dataTo)
        {
            string envName = Environment.UserName;

            try
            {
                envName = envName[0].ToString().ToUpper() + envName.Substring(1, envName.Length - 1);

                for (int i = 1; i < envName.Length; i++)
                    if (envName[i - 1] == ' ')
                        envName = envName.Substring(0, i) + envName[i].ToString().ToUpper() + envName.Substring(i + 1, envName.Length - i - 1);
            }
            catch
            {

            }

            string username = "StatGenerator";

            DateTime date = DateTime.Now;

            SQL sql = new SQL("use DATS; insert into history (username, timestamp, event, datafrom, datato) values (@USERNAME, @DATE, @EVENT, @DATAFROM, @DATATO)");
            sql.AddParameter("@USERNAME", username);
            sql.AddParameter("@DATE", date);
            sql.AddParameter("@EVENT", eventStr);
            sql.AddParameter("@DATAFROM", dataFrom);
            sql.AddParameter("@DATATO", dataTo);
            sql.Run();
        }

        public static void logTimesheetHistory(string description, int timesheetID)
        {
            string envName = Environment.UserName;

            try
            {
                envName = envName[0].ToString().ToUpper() + envName.Substring(1, envName.Length - 1);

                for (int i = 1; i < envName.Length; i++)
                    if (envName[i - 1] == ' ')
                        envName = envName.Substring(0, i) + envName[i].ToString().ToUpper() + envName.Substring(i + 1, envName.Length - i - 1);
            }
            catch
            {

            }

            string username = "StatGenerator";

            DateTime date = DateTime.Now;

            int version = 1;

            SQL sql = new SQL("use DATS; select version from historyversions where timecarddetailid=@ID order by version desc");
            sql.AddParameter("@ID", timesheetID);
            DataTable dt = sql.Run();

            if (dt.Rows.Count > 0)
                version = int.Parse(dt.Rows[0][0].ToString()) + 1;

            sql = new SQL("use DATS; insert into historyversions select @TIMESTAMP, @USERNAME, @DESCRIPTION, @VERSION, * from timesheets where timecarddetailid = @ID");
            sql.AddParameter("@ID", timesheetID);
            sql.AddParameter("@USERNAME", username);
            sql.AddParameter("@TIMESTAMP", DateTime.Now);
            sql.AddParameter("@DESCRIPTION", description);
            sql.AddParameter("@DATE", date);
            sql.AddParameter("@VERSION", version);
            sql.Run();
        }

        public static bool isFacilities(string empID)
        {
            SQL sql = new SQL(@"
use DATS;
select
d.department

from department d
join departmentassociations da on d.departmentid = da.departmentid
join users u on da.userid = u.userid

where
u.employeeid = @EMPID");
            sql.AddParameter("@EMPID", empID);
            DataTable dt = sql.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["department"].ToString().Contains("Facilities"))
                    return true;

            return false;
        }

        public static bool isIT(string empID)
        {
            SQL sql = new SQL(@"
use DATS;
select
d.department

from department d
join departmentassociations da on d.departmentid = da.departmentid
join users u on da.userid = u.userid

where
u.employeeid = @EMPID");
            sql.AddParameter("@EMPID", empID);
            DataTable dt = sql.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["department"].ToString().Trim().Substring(0,2) == "IT")
                    return true;

            return false;
        }

        public static bool isOpsAdmin(string empID)
        {
            SQL sql = new SQL(@"
use DATS;
select
d.department

from department d
join departmentassociations da on d.departmentid = da.departmentid
join users u on da.userid = u.userid

where
u.employeeid = @EMPID");
            sql.AddParameter("@EMPID", empID);
            DataTable dt = sql.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["department"].ToString().Trim() == "Ops Office")
                    return true;

            return false;
        }

        public static bool isPayroll(string empID)
        {
            SQL sql = new SQL(@"
use DATS;
select
d.department

from department d
join departmentassociations da on d.departmentid = da.departmentid
join users u on da.userid = u.userid

where
u.employeeid = @EMPID");
            sql.AddParameter("@EMPID", empID);
            DataTable dt = sql.Run();

            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["department"].ToString().Trim() == "Payroll")
                    return true;

            return false;
        }

        public static bool isFullTime(string empID)
        {
            Oracle ora = new Oracle(@"
select YAEST from CRPDTA.F060116 where YAAN8 = @EMPNO");
            ora.AddParameter("@EMPNO", empID);
            string code = ora.Run().Rows[0]["YAEST"].ToString().Trim();
                
            //else
            //Console.WriteLine("No "+ empID +" found at -" + ora.Run().Rows.Count);

            //   Full - time Regular
            //1  Part - Time Casual
            //2  Part - Time Hourly
            //3  Contract
            //4  Elected Officials
            //5  Full Time Hourly
            //6  Contract Salary
            //7  LTD
          

            if (code == "" || code == "5")
                return true;
            else
                return false;
        }

        private static bool isHolidayForFulltime(DateTime date)
        {
            bool returnable = false;

            try
            {
                DataTable dt = SQL.Run("use DATS; select date, description from holidays");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Parse(dt.Rows[i][0].ToString()) == date)
                    {
                        returnable = true;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Crashed trying to find out whether or not today was a holiday.");
            }
            return returnable;
        }
    }
}
