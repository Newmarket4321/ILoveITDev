// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Functions.DateAndTime
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ClosedXML.Excel.CalcEngine.Functions
{
  internal static class DateAndTime
  {
    public static void Register(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      ce.RegisterFunction("DATE", 3, new CalcEngineFunction(DateAndTime.Date));
      ce.RegisterFunction("DATEVALUE", 1, new CalcEngineFunction(DateAndTime.Datevalue));
      ce.RegisterFunction("DAY", 1, new CalcEngineFunction(DateAndTime.Day));
      ce.RegisterFunction("DAYS360", 2, 3, new CalcEngineFunction(DateAndTime.Days360));
      ce.RegisterFunction("EDATE", 2, new CalcEngineFunction(DateAndTime.Edate));
      ce.RegisterFunction("EOMONTH", 2, new CalcEngineFunction(DateAndTime.Eomonth));
      ce.RegisterFunction("HOUR", 1, new CalcEngineFunction(DateAndTime.Hour));
      ce.RegisterFunction("MINUTE", 1, new CalcEngineFunction(DateAndTime.Minute));
      ce.RegisterFunction("MONTH", 1, new CalcEngineFunction(DateAndTime.Month));
      ce.RegisterFunction("NETWORKDAYS", 2, 3, new CalcEngineFunction(DateAndTime.Networkdays));
      ce.RegisterFunction("NOW", 0, new CalcEngineFunction(DateAndTime.Now));
      ce.RegisterFunction("SECOND", 1, new CalcEngineFunction(DateAndTime.Second));
      ce.RegisterFunction("TIME", 3, new CalcEngineFunction(DateAndTime.Time));
      ce.RegisterFunction("TIMEVALUE", 1, new CalcEngineFunction(DateAndTime.Timevalue));
      ce.RegisterFunction("TODAY", 0, new CalcEngineFunction(DateAndTime.Today));
      ce.RegisterFunction("WEEKDAY", 1, 2, new CalcEngineFunction(DateAndTime.Weekday));
      ce.RegisterFunction("WEEKNUM", 1, 2, new CalcEngineFunction(DateAndTime.Weeknum));
      ce.RegisterFunction("WORKDAY", 2, 3, new CalcEngineFunction(DateAndTime.Workday));
      ce.RegisterFunction("YEAR", 1, new CalcEngineFunction(DateAndTime.Year));
      ce.RegisterFunction("YEARFRAC", 2, 3, new CalcEngineFunction(DateAndTime.Yearfrac));
    }

    private static object Date(List<Expression> p)
    {
      return (object) (int) Math.Floor(new DateTime((int) (double) p[0], (int) (double) p[1], (int) (double) p[2]).ToOADate());
    }

    private static object Datevalue(List<Expression> p)
    {
      return (object) (int) Math.Floor(DateTime.Parse((string) p[0]).ToOADate());
    }

    private static object Day(List<Expression> p)
    {
      return (object) (DateTime) p[0].Day;
    }

    private static object Month(List<Expression> p)
    {
      return (object) (DateTime) p[0].Month;
    }

    private static object Year(List<Expression> p)
    {
      return (object) (DateTime) p[0].Year;
    }

    private static object Minute(List<Expression> p)
    {
      return (object) (DateTime) p[0].Minute;
    }

    private static object Hour(List<Expression> p)
    {
      return (object) (DateTime) p[0].Hour;
    }

    private static object Second(List<Expression> p)
    {
      return (object) (DateTime) p[0].Second;
    }

    private static object Now(List<Expression> p)
    {
      return (object) DateTime.Now;
    }

    private static object Time(List<Expression> p)
    {
      return (object) new TimeSpan(0, (int) (double) p[0], (int) (double) p[1], (int) (double) p[2]);
    }

    private static object Timevalue(List<Expression> p)
    {
      DateTime dateTime = (DateTime) p[0];
      return (object) (DateTime.MinValue + dateTime.TimeOfDay).ToOADate();
    }

    private static object Today(List<Expression> p)
    {
      return (object) DateTime.Now.Date;
    }

    private static object Days360(List<Expression> p)
    {
      return (object) DateAndTime.Days360((DateTime) p[0], (DateTime) p[1], p.Count == 3 && (bool) p[2]);
    }

    private static int Days360(DateTime date1, DateTime date2, bool isEuropean)
    {
      int num1 = date1.Day;
      int month1 = date1.Month;
      int year1 = date1.Year;
      int num2 = date2.Day;
      int month2 = date2.Month;
      int year2 = date2.Year;
      if (isEuropean)
      {
        if (num1 == 31)
          num1 = 30;
        if (num2 == 31)
          num2 = 30;
      }
      else
      {
        if (num1 == 31)
          num1 = 30;
        if (num2 == 31 && num1 == 30)
          num2 = 30;
      }
      return 360 * (year2 - year1) + 30 * (month2 - month1) + (num2 - num1);
    }

    private static object Edate(List<Expression> p)
    {
      return (object) (DateTime) p[0].AddMonths((int) (double) p[1]);
    }

    private static object Eomonth(List<Expression> p)
    {
      DateTime dateTime = (DateTime) p[0].AddMonths((int) (double) p[1]);
      return (object) new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1).AddDays(-1.0);
    }

    private static object Networkdays(List<Expression> p)
    {
      DateTime firstDay = (DateTime) p[0];
      DateTime lastDay = (DateTime) p[1];
      List<DateTime> dateTimeList = new List<DateTime>();
      if (p.Count == 3)
      {
        Tally source = new Tally() { p[2] };
        dateTimeList.AddRange(source.Select<object, DateTime>(new Func<object, DateTime>(XLHelper.GetDate)));
      }
      return (object) DateAndTime.BusinessDaysUntil(firstDay, lastDay, (IEnumerable<DateTime>) dateTimeList);
    }

    private static int BusinessDaysUntil(DateTime firstDay, DateTime lastDay, IEnumerable<DateTime> bankHolidays)
    {
      firstDay = firstDay.Date;
      lastDay = lastDay.Date;
      if (firstDay > lastDay)
        throw new ArgumentException("Incorrect last day " + (object) lastDay);
      int num1 = (lastDay - firstDay).Days + 1;
      int num2 = num1 / 7;
      if (num1 > num2 * 7)
      {
        int dayOfWeek1 = (int) firstDay.DayOfWeek;
        int dayOfWeek2 = (int) lastDay.DayOfWeek;
        if (dayOfWeek2 < dayOfWeek1)
          dayOfWeek2 += 7;
        if (dayOfWeek1 <= 6)
        {
          if (dayOfWeek2 >= 7)
            num1 -= 2;
          else if (dayOfWeek2 >= 6)
            --num1;
        }
        else if (dayOfWeek1 <= 7 && dayOfWeek2 >= 7)
          --num1;
      }
      int num3 = num1 - (num2 + num2);
      foreach (DateTime bankHoliday in bankHolidays)
      {
        if (firstDay <= bankHoliday && bankHoliday <= lastDay)
          --num3;
      }
      return num3;
    }

    private static object Weekday(List<Expression> p)
    {
      int dayOfWeek = (int) (DateTime) p[0].DayOfWeek;
      switch (p.Count == 2 ? (int) (double) p[1] : 1)
      {
        case 1:
          return (object) (dayOfWeek + 1);
        case 2:
          return (object) dayOfWeek;
        default:
          return (object) (dayOfWeek - 1);
      }
    }

    private static object Weeknum(List<Expression> p)
    {
      return (object) new GregorianCalendar(GregorianCalendarTypes.Localized).GetWeekOfYear((DateTime) p[0], CalendarWeekRule.FirstDay, (p.Count == 2 ? (int) (double) p[1] : 1) == 1 ? DayOfWeek.Sunday : DayOfWeek.Monday);
    }

    private static object Workday(List<Expression> p)
    {
      DateTime startDate = (DateTime) p[0];
      int daysRequired = (int) (double) p[1];
      if (daysRequired == 0)
        return (object) startDate;
      if (daysRequired < 0)
        throw new ArgumentOutOfRangeException("DaysRequired must be >= 0.");
      List<DateTime> bankHolidays = new List<DateTime>();
      if (p.Count == 3)
      {
        Tally source = new Tally() { p[2] };
        bankHolidays.AddRange(source.Select<object, DateTime>(new Func<object, DateTime>(XLHelper.GetDate)));
      }
      DateTime testDate = startDate.AddDays((double) ((daysRequired / 7 + 2) * 7));
      return (object) DateAndTime.Workday(startDate, testDate, daysRequired, (IEnumerable<DateTime>) bankHolidays).NextWorkday(bankHolidays);
    }

    private static DateTime Workday(DateTime startDate, DateTime testDate, int daysRequired, IEnumerable<DateTime> bankHolidays)
    {
      int num1 = DateAndTime.BusinessDaysUntil(startDate, testDate, bankHolidays);
      if (num1 == daysRequired)
        return testDate;
      int num2 = num1 > daysRequired ? -1 : 1;
      return DateAndTime.Workday(startDate, testDate.AddDays((double) num2), daysRequired, bankHolidays);
    }

    private static object Yearfrac(List<Expression> p)
    {
      DateTime date1 = (DateTime) p[0];
      DateTime date2 = (DateTime) p[1];
      switch (p.Count == 3 ? (int) (double) p[2] : 0)
      {
        case 0:
          return (object) ((double) DateAndTime.Days360(date1, date2, false) / 360.0);
        case 1:
          return (object) (Math.Floor((date2 - date1).TotalDays) / DateAndTime.GetYearAverage(date1, date2));
        case 2:
          return (object) (Math.Floor((date2 - date1).TotalDays) / 360.0);
        case 3:
          return (object) (Math.Floor((date2 - date1).TotalDays) / 365.0);
        default:
          return (object) ((double) DateAndTime.Days360(date1, date2, true) / 360.0);
      }
    }

    private static double GetYearAverage(DateTime date1, DateTime date2)
    {
      List<int> source = new List<int>();
      for (int year = date1.Year; year <= date2.Year; ++year)
        source.Add(DateTime.IsLeapYear(year) ? 366 : 365);
      return source.Average();
    }
  }
}
