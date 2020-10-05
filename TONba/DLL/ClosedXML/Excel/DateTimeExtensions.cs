// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.DateTimeExtensions
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public static class DateTimeExtensions
  {
    public static double MaxOADate
    {
      get
      {
        return 2958465.99999999;
      }
    }

    public static DateTime NextWorkday(this DateTime date, List<DateTime> bankHolidays)
    {
      DateTime dateTime = date.AddDays(1.0);
      while (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday || bankHolidays.Contains(dateTime))
        dateTime = dateTime.AddDays(1.0);
      return dateTime;
    }
  }
}
