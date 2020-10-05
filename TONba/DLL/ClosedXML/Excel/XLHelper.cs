// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLHelper
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClosedXML.Excel
{
  public static class XLHelper
  {
    internal static readonly System.Globalization.NumberFormatInfo NumberFormatForParse = CultureInfo.InvariantCulture.NumberFormat;
    internal static readonly Graphics Graphic = Graphics.FromImage((Image) new Bitmap(200, 200));
    internal static readonly double DpiX = (double) XLHelper.Graphic.DpiX;
    internal static readonly Regex A1SimpleRegex = new Regex("\\A(?<Reference>(?<Sheet>(\\'([^\\[\\]\\*/\\\\\\?:\\']+|\\'\\')\\'|\\'?\\w+\\'?)!)?(?<Range>\\$?[a-zA-Z]{1,3}\\$?\\d{1,7}(?<RangeEnd>:\\$?[a-zA-Z]{1,3}\\$?\\d{1,7})?|(?<ColumnNumbers>\\$?\\d{1,7}:\\$?\\d{1,7})|(?<ColumnLetters>\\$?[a-zA-Z]{1,3}:\\$?[a-zA-Z]{1,3})))\\Z", RegexOptions.Compiled);
    internal static readonly Regex NamedRangeReferenceRegex = new Regex("^('?(?<Sheet>[^'!]+)'?!(?<Range>.+))|((?<Table>[^\\[]+)\\[(?<Column>[^\\]]+)\\])$", RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.CultureInvariant);
    private static readonly Regex A1RegexRelative = new Regex("(?<=\\W)(?<one>\\$?[a-zA-Z]{1,3}\\$?\\d{1,7})(?=\\W)|(?<=\\W)(?<two>\\$?\\d{1,7}:\\$?\\d{1,7})(?=\\W)|(?<=\\W)(?<three>\\$?[a-zA-Z]{1,3}:\\$?[a-zA-Z]{1,3})(?=\\W)", RegexOptions.Compiled);
    public const int MinRowNumber = 1;
    public const int MinColumnNumber = 1;
    public const int MaxRowNumber = 1048576;
    public const int MaxColumnNumber = 16384;
    public const string MaxColumnLetter = "XFD";
    public const double Epsilon = 1E-10;
    private const int TwoT26 = 676;

    public static int GetColumnNumberFromLetter(string columnLetter)
    {
      if (string.IsNullOrEmpty(columnLetter))
        throw new ArgumentNullException(nameof (columnLetter));
      columnLetter = columnLetter.ToUpper();
      if ((int) columnLetter[0] <= 57)
        return int.Parse(columnLetter, (IFormatProvider) XLHelper.NumberFormatForParse);
      int num = 0;
      for (int index = 0; index < columnLetter.Length; ++index)
        num = num * 26 + ((int) columnLetter[index] - 65 + 1);
      return num;
    }

    public static string GetColumnLetterFromNumber(int columnNumber)
    {
      string str = string.Empty;
      while (columnNumber > 0)
      {
        --columnNumber;
        str = ((int) (ushort) (65 + columnNumber % 26)).ToString() + str;
        columnNumber /= 26;
      }
      return str;
    }

    public static bool IsValidColumn(string column)
    {
      int length = column.Length;
      if (XLHelper.IsNullOrWhiteSpace(column) || length > 3)
        return false;
      string upper = column.ToUpper();
      bool flag = (int) upper[0] >= 65 && (int) upper[0] <= 90;
      switch (length)
      {
        case 1:
          return flag;
        case 2:
          if (flag && (int) upper[1] >= 65)
            return (int) upper[1] <= 90;
          return false;
        default:
          if ((int) upper[0] >= 65 && (int) upper[0] < 88)
          {
            if ((int) upper[1] >= 65 && (int) upper[1] <= 90 && (int) upper[2] >= 65)
              return (int) upper[2] <= 90;
            return false;
          }
          if ((int) upper[0] != 88)
            return false;
          if ((int) upper[1] < 70)
          {
            if ((int) upper[2] >= 65)
              return (int) upper[2] <= 90;
            return false;
          }
          if ((int) upper[1] != 70 || (int) upper[2] < 65)
            return false;
          return (int) upper[2] <= 68;
      }
    }

    public static bool IsValidRow(string rowString)
    {
      int result;
      if (int.TryParse(rowString, out result) && result > 0)
        return result <= 1048576;
      return false;
    }

    public static bool IsValidA1Address(string address)
    {
      if (XLHelper.IsNullOrWhiteSpace(address))
        return false;
      address = address.Replace("$", "");
      int index = 0;
      int length = address.Length;
      while (index < length && ((int) address[index] > 57 || (int) address[index] < 48))
        ++index;
      if (index < length && XLHelper.IsValidRow(address.Substring(index)))
        return XLHelper.IsValidColumn(address.Substring(0, index));
      return false;
    }

    public static bool IsValidRangeAddress(string rangeAddress)
    {
      return XLHelper.A1SimpleRegex.IsMatch(rangeAddress);
    }

    public static bool IsValidRangeAddress(IXLRangeAddress rangeAddress)
    {
      if (!rangeAddress.IsInvalid && rangeAddress.FirstAddress.RowNumber >= 1 && (rangeAddress.LastAddress.RowNumber <= 1048576 && rangeAddress.FirstAddress.ColumnNumber >= 1) && (rangeAddress.LastAddress.ColumnNumber <= 16384 && rangeAddress.FirstAddress.RowNumber <= rangeAddress.LastAddress.RowNumber))
        return rangeAddress.FirstAddress.ColumnNumber <= rangeAddress.LastAddress.ColumnNumber;
      return false;
    }

    public static int GetColumnNumberFromAddress(string cellAddressString)
    {
      int length = 0;
      while ((int) cellAddressString[length] > 57)
        ++length;
      return XLHelper.GetColumnNumberFromLetter(cellAddressString.Substring(0, length));
    }

    internal static string[] SplitRange(string range)
    {
      if (!range.Contains<char>('-'))
        return range.Split(':');
      return range.Replace('-', ':').Split(':');
    }

    public static int GetPtFromPx(double px)
    {
      return Convert.ToInt32(px * 72.0 / XLHelper.DpiX);
    }

    public static double GetPxFromPt(int pt)
    {
      return Convert.ToDouble(pt) * XLHelper.DpiX / 72.0;
    }

    internal static IXLTableRows InsertRowsWithoutEvents(Func<int, bool, IXLRangeRows> insertFunc, XLTableRange tableRange, int numberOfRows, bool expandTable)
    {
      XLWorksheet worksheet = tableRange.Worksheet;
      bool eventTrackingEnabled = worksheet.EventTrackingEnabled;
      worksheet.EventTrackingEnabled = false;
      XLTableRows rows = new XLTableRows(worksheet.Style);
      insertFunc(numberOfRows, false).ForEach<IXLRangeRow>((Action<IXLRangeRow>) (r => rows.Add((IXLTableRow) new XLTableRow(tableRange, r as XLRangeRow))));
      if (expandTable)
        tableRange.Table.ExpandTableRows(numberOfRows);
      worksheet.EventTrackingEnabled = eventTrackingEnabled;
      return (IXLTableRows) rows;
    }

    public static bool IsNullOrWhiteSpace(string value)
    {
      return string.IsNullOrWhiteSpace(value);
    }

    private static string Evaluator(Match match, int row, string column)
    {
      if (match.Groups["one"].Success)
      {
        string[] strArray = match.Groups["one"].Value.Split('$');
        if (strArray.Length == 1)
          return column + (object) row;
        if (strArray.Length == 3)
          return match.Groups["one"].Value;
        XLAddress xlAddress = XLAddress.Create(match.Groups["one"].Value);
        if (strArray[0] == string.Empty)
          return "$" + xlAddress.ColumnLetter + (object) row;
        return column + "$" + (object) xlAddress.RowNumber;
      }
      if (match.Groups["two"].Success)
        return XLHelper.ReplaceGroup(match.Groups["two"].Value, row.ToString());
      return XLHelper.ReplaceGroup(match.Groups["three"].Value, column);
    }

    private static string ReplaceGroup(string value, string item)
    {
      string[] strArray = value.Split(':');
      return (strArray[0].StartsWith("$") ? strArray[0] : item) + ":" + (strArray[1].StartsWith("$") ? strArray[1] : item);
    }

    internal static string ReplaceRelative(string value, int row, string column)
    {
      string input = ">" + value + "<";
      string str = XLHelper.A1RegexRelative.Replace(input, (MatchEvaluator) (m => XLHelper.Evaluator(m, row, column)));
      return str.Substring(1, str.Length - 2);
    }

    public static bool AreEqual(double d1, double d2)
    {
      return Math.Abs(d1 - d2) < 1E-10;
    }

    public static DateTime GetDate(object v)
    {
      if (v is DateTime)
        return (DateTime) v;
      if (v is double)
        return DateTime.FromOADate((double) v);
      return (DateTime) Convert.ChangeType(v, typeof (DateTime));
    }
  }
}
