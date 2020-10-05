// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCell
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ClosedXML.Excel
{
  internal class XLCell : IXLCell, IXLStylized
  {
    public static readonly DateTime BaseDate = new DateTime(1899, 12, 30);
    private static readonly Regex A1Regex = new Regex("(?<=\\W)(\\$?[a-zA-Z]{1,3}\\$?\\d{1,7})(?=\\W)|(?<=\\W)(\\$?\\d{1,7}:\\$?\\d{1,7})(?=\\W)|(?<=\\W)(\\$?[a-zA-Z]{1,3}:\\$?[a-zA-Z]{1,3})(?=\\W)", RegexOptions.Compiled);
    public static readonly Regex A1SimpleRegex = new Regex("(?<Reference>(?<Sheet>(\\'([^\\[\\]\\*/\\\\\\?:\\']+|\\'\\')\\'|\\'?\\w+\\'?)!)?(?<Range>\\$?[a-zA-Z]{1,3}\\$?\\d{1,7}(?<RangeEnd>:\\$?[a-zA-Z]{1,3}\\$?\\d{1,7})?|(?<ColumnNumbers>\\$?\\d{1,7}:\\$?\\d{1,7})|(?<ColumnLetters>\\$?[a-zA-Z]{1,3}:\\$?[a-zA-Z]{1,3})))", RegexOptions.Compiled);
    private static readonly Regex A1RowRegex = new Regex("(\\$?\\d{1,7}:\\$?\\d{1,7})", RegexOptions.Compiled);
    private static readonly Regex A1ColumnRegex = new Regex("(\\$?[a-zA-Z]{1,3}:\\$?[a-zA-Z]{1,3})", RegexOptions.Compiled);
    private static readonly Regex R1C1Regex = new Regex("(?<=\\W)([Rr]\\[?-?\\d{0,7}\\]?[Cc]\\[?-?\\d{0,7}\\]?)(?=\\W)|(?<=\\W)([Rr]\\[?-?\\d{0,7}\\]?:[Rr]\\[?-?\\d{0,7}\\]?)(?=\\W)|(?<=\\W)([Cc]\\[?-?\\d{0,5}\\]?:[Cc]\\[?-?\\d{0,5}\\]?)(?=\\W)", RegexOptions.Compiled);
    private static readonly Regex utfPattern = new Regex("(?<!_x005F)_x(?!005F)([0-9A-F]{4})_", RegexOptions.Compiled);
    internal string _cellValue = string.Empty;
    private static Dictionary<int, string> _formatCodes;
    private readonly XLWorksheet _worksheet;
    private XLComment _comment;
    internal XLCellValues _dataType;
    private XLHyperlink _hyperlink;
    private XLRichText _richText;
    private int _styleCacheId;
    public bool SettingHyperlink;
    public int SharedStringId;
    private string _formulaA1;
    private string _formulaR1C1;
    private IXLStyle _style;

    public XLCell(XLWorksheet worksheet, XLAddress address, int styleId)
    {
      this.Address = address;
      this.ShareString = true;
      this._worksheet = worksheet;
      this.SetStyle(styleId);
    }

    private IXLStyle GetStyleForRead()
    {
      return this.Worksheet.Workbook.GetStyleById(this.GetStyleId());
    }

    public int GetStyleId()
    {
      if (this.StyleChanged)
        this.SetStyle(this.Style);
      return this._styleCacheId;
    }

    private void SetStyle(IXLStyle styleToUse)
    {
      this._styleCacheId = this.Worksheet.Workbook.GetStyleId(styleToUse);
      this._style = (IXLStyle) null;
      this.StyleChanged = false;
    }

    private void SetStyle(int styleId)
    {
      this._styleCacheId = styleId;
      this._style = (IXLStyle) null;
      this.StyleChanged = false;
    }

    public XLWorksheet Worksheet
    {
      get
      {
        return this._worksheet;
      }
    }

    public XLAddress Address { get; internal set; }

    public string InnerText
    {
      get
      {
        if (this.HasRichText)
          return this._richText.ToString();
        if (!XLHelper.IsNullOrWhiteSpace(this._cellValue))
          return this._cellValue;
        return this.FormulaA1;
      }
    }

    public IXLDataValidation NewDataValidation
    {
      get
      {
        using (XLRange xlRange = this.AsRange())
          return (IXLDataValidation) xlRange.NewDataValidation;
      }
    }

    public XLDataValidation DataValidation
    {
      get
      {
        using (XLRange xlRange = this.AsRange())
        {
          XLDataValidation dataValidation1 = xlRange.DataValidation;
          foreach (IXLDataValidation dataValidation2 in this.Worksheet.DataValidations)
          {
            IXLRanges ranges = dataValidation2.Ranges;
            if (ranges.Count == 1 && ranges.Single<IXLRange>().RangeAddress.ToStringRelative().Equals(xlRange.RangeAddress.ToStringRelative()))
              return dataValidation2 as XLDataValidation;
          }
        }
        return (XLDataValidation) null;
      }
    }

    internal XLComment Comment
    {
      get
      {
        if (this._comment == null)
          this._comment = new XLComment(this, (IXLFontBase) new XLFont()
          {
            FontName = "Tahoma",
            FontSize = 8.0,
            FontFamilyNumbering = XLFontFamilyNumberingValues.Swiss
          });
        return this._comment;
      }
    }

    IXLDataValidation IXLCell.DataValidation
    {
      get
      {
        return (IXLDataValidation) this.DataValidation;
      }
    }

    IXLWorksheet IXLCell.Worksheet
    {
      get
      {
        return (IXLWorksheet) this.Worksheet;
      }
    }

    IXLAddress IXLCell.Address
    {
      get
      {
        return (IXLAddress) this.Address;
      }
    }

    IXLRange IXLCell.AsRange()
    {
      return (IXLRange) this.AsRange();
    }

    public IXLCell SetValue<T>(T value)
    {
      this.FormulaA1 = string.Empty;
      this._richText = (XLRichText) null;
      if ((object) value is string || (object) value is char)
      {
        this._cellValue = value.ToString();
        this._dataType = XLCellValues.Text;
        if (this._cellValue.Contains(Environment.NewLine) && !this.GetStyleForRead().Alignment.WrapText)
          this.Style.Alignment.WrapText = true;
      }
      else if ((object) value is TimeSpan)
      {
        this._cellValue = value.ToString();
        this._dataType = XLCellValues.TimeSpan;
        this.Style.NumberFormat.NumberFormatId = 46;
      }
      else if ((object) value is DateTime)
      {
        this._dataType = XLCellValues.DateTime;
        DateTime dateTime = (DateTime) Convert.ChangeType((object) value, typeof (DateTime));
        this.Style.NumberFormat.NumberFormatId = dateTime.Date == dateTime ? 14 : 22;
        this._cellValue = dateTime.ToOADate().ToString();
      }
      else if ((object) value is sbyte || (object) value is byte || ((object) value is short || (object) value is ushort) || ((object) value is int || (object) value is uint || ((object) value is long || (object) value is ulong)) || ((object) value is float || (object) value is double || (object) value is Decimal))
      {
        if (((object) value is double || (object) value is float) && (double.IsNaN((double) Convert.ChangeType((object) value, typeof (double))) || double.IsInfinity((double) Convert.ChangeType((object) value, typeof (double)))))
        {
          this._cellValue = value.ToString();
          this._dataType = XLCellValues.Text;
        }
        else
        {
          this._dataType = XLCellValues.Number;
          this._cellValue = value.ToString();
        }
      }
      else if ((object) value is bool)
      {
        this._dataType = XLCellValues.Boolean;
        this._cellValue = (bool) Convert.ChangeType((object) value, typeof (bool)) ? "1" : "0";
      }
      else
      {
        this._cellValue = Convert.ToString((object) value);
        this._dataType = XLCellValues.Text;
      }
      return (IXLCell) this;
    }

    public T GetValue<T>()
    {
      T obj;
      if (this.TryGetValue<T>(out obj))
        return obj;
      throw new Exception("Cannot convert cell value to " + (object) typeof (T));
    }

    public string GetString()
    {
      return this.GetValue<string>();
    }

    public double GetDouble()
    {
      return this.GetValue<double>();
    }

    public bool GetBoolean()
    {
      return this.GetValue<bool>();
    }

    public DateTime GetDateTime()
    {
      return this.GetValue<DateTime>();
    }

    public TimeSpan GetTimeSpan()
    {
      return this.GetValue<TimeSpan>();
    }

    public string GetFormattedString()
    {
      string s;
      if (this.FormulaA1.Length > 0)
      {
        try
        {
          s = this.GetString();
        }
        catch
        {
          s = string.Empty;
        }
      }
      else
        s = this._cellValue;
      if (this._dataType == XLCellValues.Boolean)
        return (s != "0").ToString();
      if (this._dataType == XLCellValues.TimeSpan)
        return s;
      if (this._dataType == XLCellValues.DateTime || this.IsDateFormat())
      {
        double result;
        if (!double.TryParse(s, out result))
          return s;
        string format = this.GetFormat();
        return DateTime.FromOADate(result).ToString(format);
      }
      double result1;
      if (this._dataType != XLCellValues.Number || !double.TryParse(s, out result1))
        return s;
      string format1 = this.GetFormat();
      return result1.ToString(format1);
    }

    public object Value
    {
      get
      {
        string str1 = this.FormulaA1;
        if (!XLHelper.IsNullOrWhiteSpace(str1))
        {
          if ((int) str1[0] == 123)
            str1 = str1.Substring(1, str1.Length - 2);
          string str2;
          string sName;
          if (str1.Contains<char>('!'))
          {
            sName = str1.Substring(0, str1.IndexOf('!'));
            if ((int) sName[0] == 39)
              sName = sName.Substring(1, sName.Length - 2);
            str2 = str1.Substring(str1.IndexOf('!') + 1);
          }
          else
          {
            sName = this.Worksheet.Name;
            str2 = str1;
          }
          if (this._worksheet.Workbook.WorksheetsInternal.Any<XLWorksheet>((Func<XLWorksheet, bool>) (w => string.Compare(w.Name, sName, true) == 0)) && XLHelper.IsValidA1Address(str2))
            return this._worksheet.Workbook.Worksheet(sName).Cell(str2).Value;
          object obj = this.Worksheet.Evaluate(str1);
          IEnumerable enumerable = obj as IEnumerable;
          if (enumerable != null && !(obj is string))
          {
            IEnumerator enumerator = enumerable.GetEnumerator();
            try
            {
              if (enumerator.MoveNext())
                return enumerator.Current;
            }
            finally
            {
              IDisposable disposable = enumerator as IDisposable;
              if (disposable != null)
                disposable.Dispose();
            }
          }
          return obj;
        }
        string s = this.HasRichText ? this._richText.ToString() : this._cellValue;
        if (this._dataType == XLCellValues.Boolean)
          return (object) (s != "0");
        if (this._dataType == XLCellValues.DateTime)
          return (object) DateTime.FromOADate(double.Parse(s));
        if (this._dataType == XLCellValues.Number)
          return (object) double.Parse(s);
        if (this._dataType == XLCellValues.TimeSpan)
          return (object) TimeSpan.Parse(s);
        return (object) s;
      }
      set
      {
        this.FormulaA1 = string.Empty;
        if (value is XLCells)
          throw new ArgumentException("Cannot assign IXLCells object to the cell value.");
        if (this.SetRangeRows(value) || this.SetRangeColumns(value) || (this.SetEnumerable(value) || this.SetRange(value)))
          return;
        if (!this.SetRichText(value))
          this.SetValue(value);
        if (this._cellValue.Length > (int) short.MaxValue)
          throw new ArgumentException("Cells can only hold 32,767 characters.");
      }
    }

    public IXLTable InsertTable<T>(IEnumerable<T> data)
    {
      return this.InsertTable<T>(data, (string) null, true);
    }

    public IXLTable InsertTable<T>(IEnumerable<T> data, bool createTable)
    {
      return this.InsertTable<T>(data, (string) null, createTable);
    }

    public IXLTable InsertTable<T>(IEnumerable<T> data, string tableName)
    {
      return this.InsertTable<T>(data, tableName, true);
    }

    public IXLTable InsertTable<T>(IEnumerable<T> data, string tableName, bool createTable)
    {
      if (data == null || !(data.GetType() != typeof (string)))
        return (IXLTable) null;
      int ro = this.Address.RowNumber + 1;
      int rowNumber = this.Address.RowNumber;
      bool flag1 = false;
      int num = 0;
      bool flag2 = false;
      bool flag3 = false;
      if (!data.Any<T>())
      {
        Type itemType = data.GetItemType<T>();
        num = itemType.IsPrimitive || itemType == typeof (string) || (itemType == typeof (DateTime) || itemType == typeof (Decimal)) ? this.Address.ColumnNumber + 1 : this.Address.ColumnNumber + itemType.GetFields().Length + itemType.GetProperties().Length;
      }
      else
      {
        foreach (T obj1 in data)
        {
          object obj2 = (object) obj1;
          int columnNumber = this.Address.ColumnNumber;
          if (obj2.GetType().IsPrimitive || obj2 is string || (obj2 is DateTime || obj2 is Decimal))
          {
            if (!flag1)
            {
              string str = XLCell.GetFieldName(obj2.GetType().GetCustomAttributes(true));
              if (XLHelper.IsNullOrWhiteSpace(str))
                str = obj2.GetType().Name;
              this.SetValue<string>(str, rowNumber, columnNumber);
              flag1 = true;
              columnNumber = this.Address.ColumnNumber;
            }
            this.SetValue<object>(obj2, ro, columnNumber);
            ++columnNumber;
          }
          else if (obj2.GetType().IsArray)
          {
            foreach (object obj3 in (Array) obj2)
            {
              this.SetValue<object>(obj3, ro, columnNumber);
              ++columnNumber;
            }
          }
          else if (flag2 || obj2 is DataRow)
          {
            if (!flag2)
              flag2 = true;
            if (!flag1)
            {
              foreach (string str in ((DataRow) obj2).Table.Columns.Cast<DataColumn>().Select<DataColumn, string>((Func<DataColumn, string>) (column =>
              {
                if (!XLHelper.IsNullOrWhiteSpace(column.Caption))
                  return column.Caption;
                return column.ColumnName;
              })))
              {
                this.SetValue<string>(str, rowNumber, columnNumber);
                ++columnNumber;
              }
              columnNumber = this.Address.ColumnNumber;
              flag1 = true;
            }
            foreach (object obj3 in ((DataRow) obj2).ItemArray)
            {
              this.SetValue<object>(obj3, ro, columnNumber);
              ++columnNumber;
            }
          }
          else if (flag3 || obj2 is IDataRecord)
          {
            if (!flag3)
              flag3 = true;
            IDataRecord dataRecord = obj2 as IDataRecord;
            int fieldCount = dataRecord.FieldCount;
            if (!flag1)
            {
              for (int i = 0; i < fieldCount; ++i)
              {
                this.SetValue<string>(dataRecord.GetName(i), rowNumber, columnNumber);
                ++columnNumber;
              }
              columnNumber = this.Address.ColumnNumber;
              flag1 = true;
            }
            for (int index = 0; index < fieldCount; ++index)
            {
              this.SetValue<object>(dataRecord[index], ro, columnNumber);
              ++columnNumber;
            }
          }
          else
          {
            FieldInfo[] fields = obj2.GetType().GetFields();
            PropertyInfo[] properties = obj2.GetType().GetProperties();
            if (!flag1)
            {
              foreach (FieldInfo fieldInfo in fields)
              {
                if (!(fieldInfo is IEnumerable))
                {
                  string str = XLCell.GetFieldName(fieldInfo.GetCustomAttributes(true));
                  if (XLHelper.IsNullOrWhiteSpace(str))
                    str = fieldInfo.Name;
                  this.SetValue<string>(str, rowNumber, columnNumber);
                }
                ++columnNumber;
              }
              foreach (PropertyInfo propertyInfo in properties)
              {
                if (!(propertyInfo is IEnumerable))
                {
                  string str = XLCell.GetFieldName(propertyInfo.GetCustomAttributes(true));
                  if (XLHelper.IsNullOrWhiteSpace(str))
                    str = propertyInfo.Name;
                  this.SetValue<string>(str, rowNumber, columnNumber);
                }
                ++columnNumber;
              }
              columnNumber = this.Address.ColumnNumber;
              flag1 = true;
            }
            foreach (FieldInfo fieldInfo in fields)
            {
              this.SetValue<object>(fieldInfo.GetValue(obj2), ro, columnNumber);
              ++columnNumber;
            }
            foreach (PropertyInfo propertyInfo in properties)
            {
              if (!(propertyInfo is IEnumerable))
                this.SetValue<object>(propertyInfo.GetValue(obj2, (object[]) null), ro, columnNumber);
              ++columnNumber;
            }
          }
          if (columnNumber > num)
            num = columnNumber;
          ++ro;
        }
      }
      this.ClearMerged();
      XLRange xlRange = this._worksheet.Range(this.Address.RowNumber, this.Address.ColumnNumber, ro - 1, num - 1);
      if (createTable)
      {
        if (tableName != null)
          return (IXLTable) xlRange.CreateTable(tableName);
        return (IXLTable) xlRange.CreateTable();
      }
      if (tableName != null)
        return xlRange.AsTable(tableName);
      return xlRange.AsTable();
    }

    public IXLTable InsertTable(DataTable data)
    {
      return this.InsertTable(data, (string) null, true);
    }

    public IXLTable InsertTable(DataTable data, bool createTable)
    {
      return this.InsertTable(data, (string) null, createTable);
    }

    public IXLTable InsertTable(DataTable data, string tableName)
    {
      return this.InsertTable(data, tableName, true);
    }

    public IXLTable InsertTable(DataTable data, string tableName, bool createTable)
    {
      if (data == null)
        return (IXLTable) null;
      if (data.Rows.Count > 0)
        return this.InsertTable<DataRow>((IEnumerable<DataRow>) data.AsEnumerable(), tableName, createTable);
      int rowNumber = this.Address.RowNumber;
      int columnNumber = this.Address.ColumnNumber;
      foreach (DataColumn column in (InternalDataCollectionBase) data.Columns)
      {
        this.SetValue<string>(column.ColumnName, rowNumber, columnNumber);
        ++columnNumber;
      }
      this.ClearMerged();
      XLRange xlRange = this._worksheet.Range(this.Address.RowNumber, this.Address.ColumnNumber, rowNumber, columnNumber - 1);
      if (createTable)
      {
        if (tableName != null)
          return (IXLTable) xlRange.CreateTable(tableName);
        return (IXLTable) xlRange.CreateTable();
      }
      if (tableName != null)
        return xlRange.AsTable(tableName);
      return xlRange.AsTable();
    }

    public IXLRange InsertData(IEnumerable data)
    {
      if (data == null || !(data.GetType() != typeof (string)))
        return (IXLRange) null;
      int rowNumber = this.Address.RowNumber;
      int num = 0;
      bool flag1 = false;
      bool flag2 = false;
      foreach (object obj1 in data)
      {
        int columnNumber = this.Address.ColumnNumber;
        if (obj1.GetType().IsPrimitive || obj1 is string || (obj1 is DateTime || obj1 is Decimal))
        {
          this.SetValue<object>(obj1, rowNumber, columnNumber);
          ++columnNumber;
        }
        else if (obj1.GetType().IsArray)
        {
          foreach (object obj2 in (Array) obj1)
          {
            this.SetValue<object>(obj2, rowNumber, columnNumber);
            ++columnNumber;
          }
        }
        else if (flag1 || obj1 is DataRow)
        {
          if (!flag1)
            flag1 = true;
          foreach (object obj2 in (obj1 as DataRow).ItemArray)
          {
            this.SetValue<object>(obj2, rowNumber, columnNumber);
            ++columnNumber;
          }
        }
        else if (flag2 || obj1 is IDataRecord)
        {
          if (!flag2)
            flag2 = true;
          IDataRecord dataRecord = obj1 as IDataRecord;
          int fieldCount = dataRecord.FieldCount;
          for (int index = 0; index < fieldCount; ++index)
          {
            this.SetValue<object>(dataRecord[index], rowNumber, columnNumber);
            ++columnNumber;
          }
        }
        else
        {
          foreach (FieldInfo field in obj1.GetType().GetFields())
          {
            this.SetValue<object>(field.GetValue(obj1), rowNumber, columnNumber);
            ++columnNumber;
          }
          foreach (PropertyInfo property in obj1.GetType().GetProperties())
          {
            if (!(property is IEnumerable))
              this.SetValue<object>(property.GetValue(obj1, (object[]) null), rowNumber, columnNumber);
            ++columnNumber;
          }
        }
        if (columnNumber > num)
          num = columnNumber;
        ++rowNumber;
      }
      this.ClearMerged();
      return (IXLRange) this._worksheet.Range(this.Address.RowNumber, this.Address.ColumnNumber, rowNumber - 1, num - 1);
    }

    public IXLStyle Style
    {
      get
      {
        return this.GetStyle();
      }
      set
      {
        this.SetStyle(value);
      }
    }

    public IXLCell SetDataType(XLCellValues dataType)
    {
      this.DataType = dataType;
      return (IXLCell) this;
    }

    public XLCellValues DataType
    {
      get
      {
        return this._dataType;
      }
      set
      {
        if (this._dataType == value)
          return;
        if (this._richText != null)
        {
          this._cellValue = this._richText.ToString();
          this._richText = (XLRichText) null;
        }
        if (this._cellValue.Length > 0)
        {
          switch (value)
          {
            case XLCellValues.Number:
              double result1;
              if (!double.TryParse(this._cellValue, out result1))
                throw new ArgumentException(string.Format("Cannot set data type to Number because '{0}' is not recognized as a number.", (object) this._cellValue));
              this._cellValue = double.Parse(this._cellValue).ToString();
              break;
            case XLCellValues.Boolean:
              bool result2;
              this._cellValue = !bool.TryParse(this._cellValue, out result2) ? (this._cellValue == "0" || string.IsNullOrEmpty(this._cellValue) ? "0" : "1") : (result2 ? "1" : "0");
              break;
            case XLCellValues.DateTime:
              DateTime result3;
              if (DateTime.TryParse(this._cellValue, out result3))
              {
                this._cellValue = result3.ToOADate().ToString();
              }
              else
              {
                double result4;
                if (!double.TryParse(this._cellValue, out result4))
                  throw new ArgumentException(string.Format("Cannot set data type to DateTime because '{0}' is not recognized as a date.", (object) this._cellValue));
                this._cellValue = result4.ToString();
              }
              IXLStyle styleForRead1 = this.GetStyleForRead();
              if (styleForRead1.NumberFormat.Format == string.Empty && styleForRead1.NumberFormat.NumberFormatId == 0)
              {
                this.Style.NumberFormat.NumberFormatId = this._cellValue.Contains<char>('.') ? 22 : 14;
                break;
              }
              break;
            case XLCellValues.TimeSpan:
              TimeSpan result5;
              if (TimeSpan.TryParse(this._cellValue, out result5))
              {
                this._cellValue = result5.ToString();
                IXLStyle styleForRead2 = this.GetStyleForRead();
                if (styleForRead2.NumberFormat.Format == string.Empty && styleForRead2.NumberFormat.NumberFormatId == 0)
                {
                  this.Style.NumberFormat.NumberFormatId = 46;
                  break;
                }
                break;
              }
              try
              {
                this._cellValue = (DateTime.FromOADate(double.Parse(this._cellValue)) - XLCell.BaseDate).ToString();
                break;
              }
              catch
              {
                throw new ArgumentException(string.Format("Cannot set data type to TimeSpan because '{0}' is not recognized as a TimeSpan.", (object) this._cellValue));
              }
            default:
              if (this._dataType == XLCellValues.Boolean)
              {
                this._cellValue = (this._cellValue != "0").ToString();
                break;
              }
              if (this._dataType == XLCellValues.TimeSpan)
              {
                this._cellValue = XLCell.BaseDate.Add(this.GetTimeSpan()).ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
                break;
              }
              break;
          }
        }
        this._dataType = value;
      }
    }

    public IXLCell Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      return this.Clear(clearOptions, false);
    }

    internal IXLCell Clear(XLClearOptions clearOptions, bool calledFromRange)
    {
      if (this.IsMerged() && !calledFromRange)
      {
        using (XLRange xlRange1 = this.AsRange())
        {
          IXLRange xlRange2 = this.Worksheet.Internals.MergedRanges.FirstOrDefault<IXLRange>(new Func<IXLRange, bool>(((XLRangeBase) xlRange1).Intersects));
          if (xlRange2 != null)
            xlRange2.Clear(clearOptions);
        }
      }
      else
      {
        if (clearOptions == XLClearOptions.Contents || clearOptions == XLClearOptions.ContentsAndFormats)
        {
          this.Hyperlink = (XLHyperlink) null;
          this._richText = (XLRichText) null;
          this._cellValue = string.Empty;
          this.FormulaA1 = string.Empty;
        }
        if (clearOptions == XLClearOptions.Formats || clearOptions == XLClearOptions.ContentsAndFormats)
        {
          if (this.HasDataValidation)
            this.DataValidation.Clear();
          this.SetStyle(this.Worksheet.Style);
        }
      }
      return (IXLCell) this;
    }

    public void Delete(XLShiftDeletedCells shiftDeleteCells)
    {
      this._worksheet.Range((IXLAddress) this.Address, (IXLAddress) this.Address).Delete(shiftDeleteCells);
    }

    public string FormulaA1
    {
      get
      {
        if (XLHelper.IsNullOrWhiteSpace(this._formulaA1))
        {
          if (XLHelper.IsNullOrWhiteSpace(this._formulaR1C1))
            return string.Empty;
          this._formulaA1 = this.GetFormulaA1(this._formulaR1C1);
          return this.FormulaA1;
        }
        if ((int) this._formulaA1.Trim()[0] == 61)
          return this._formulaA1.Substring(1);
        if (this._formulaA1.Trim().StartsWith("{="))
          return "{" + this._formulaA1.Substring(2);
        return this._formulaA1;
      }
      set
      {
        this._formulaA1 = XLHelper.IsNullOrWhiteSpace(value) ? (string) null : value;
        this._formulaR1C1 = (string) null;
      }
    }

    public string FormulaR1C1
    {
      get
      {
        if (XLHelper.IsNullOrWhiteSpace(this._formulaR1C1))
          this._formulaR1C1 = this.GetFormulaR1C1(this.FormulaA1);
        return this._formulaR1C1;
      }
      set
      {
        this._formulaR1C1 = XLHelper.IsNullOrWhiteSpace(value) ? (string) null : value;
      }
    }

    public bool ShareString { get; set; }

    public XLHyperlink Hyperlink
    {
      get
      {
        if (this._hyperlink == null)
          this.Hyperlink = new XLHyperlink();
        return this._hyperlink;
      }
      set
      {
        if (this._worksheet.Hyperlinks.Any<XLHyperlink>((Func<XLHyperlink, bool>) (hl => this.Address.Equals(hl.Cell.Address))))
          this._worksheet.Hyperlinks.Delete((IXLAddress) this.Address);
        this._hyperlink = value;
        if (this._hyperlink == null)
          return;
        this._hyperlink.Worksheet = this._worksheet;
        this._hyperlink.Cell = (IXLCell) this;
        this._worksheet.Hyperlinks.Add(this._hyperlink);
        if (this.SettingHyperlink)
          return;
        if (this.GetStyleForRead().Font.FontColor.Equals(this._worksheet.Style.Font.FontColor))
          this.Style.Font.FontColor = XLColor.FromTheme(XLThemeColor.Hyperlink);
        if (this.GetStyleForRead().Font.Underline != this._worksheet.Style.Font.Underline)
          return;
        this.Style.Font.Underline = XLFontUnderlineValues.Single;
      }
    }

    public IXLCells InsertCellsAbove(int numberOfRows)
    {
      return this.AsRange().InsertRowsAbove(numberOfRows).Cells();
    }

    public IXLCells InsertCellsBelow(int numberOfRows)
    {
      return this.AsRange().InsertRowsBelow(numberOfRows).Cells();
    }

    public IXLCells InsertCellsAfter(int numberOfColumns)
    {
      return this.AsRange().InsertColumnsAfter(numberOfColumns).Cells();
    }

    public IXLCells InsertCellsBefore(int numberOfColumns)
    {
      return this.AsRange().InsertColumnsBefore(numberOfColumns).Cells();
    }

    public IXLCell AddToNamed(string rangeName)
    {
      this.AsRange().AddToNamed(rangeName);
      return (IXLCell) this;
    }

    public IXLCell AddToNamed(string rangeName, XLScope scope)
    {
      this.AsRange().AddToNamed(rangeName, scope);
      return (IXLCell) this;
    }

    public IXLCell AddToNamed(string rangeName, XLScope scope, string comment)
    {
      this.AsRange().AddToNamed(rangeName, scope, comment);
      return (IXLCell) this;
    }

    public string ValueCached { get; internal set; }

    public IXLRichText RichText
    {
      get
      {
        if (this._richText == null)
        {
          IXLStyle styleForRead = this.GetStyleForRead();
          this._richText = this._cellValue.Length == 0 ? new XLRichText((IXLFontBase) styleForRead.Font) : new XLRichText(this.GetFormattedString(), (IXLFontBase) styleForRead.Font);
        }
        return (IXLRichText) this._richText;
      }
    }

    public bool HasRichText
    {
      get
      {
        return this._richText != null;
      }
    }

    IXLComment IXLCell.Comment
    {
      get
      {
        return (IXLComment) this.Comment;
      }
    }

    public bool HasComment
    {
      get
      {
        return this._comment != null;
      }
    }

    public bool IsMerged()
    {
      using (XLRange xlRange = this.AsRange())
        return this.Worksheet.Internals.MergedRanges.Any<IXLRange>(new Func<IXLRange, bool>(((XLRangeBase) xlRange).Intersects));
    }

    public bool IsEmpty()
    {
      return this.IsEmpty(false);
    }

    public bool IsEmpty(bool includeFormats)
    {
      XLRow xlRow;
      XLColumn xlColumn;
      return this.InnerText.Length <= 0 && (!includeFormats || this.Style.Equals(this.Worksheet.Style) && !this.IsMerged() && (!this.HasComment && !this.HasDataValidation) && (this._style != null || (!this.Worksheet.Internals.RowsCollection.TryGetValue(this.Address.RowNumber, out xlRow) || xlRow.Style.Equals(this.Worksheet.Style)) && (!this.Worksheet.Internals.ColumnsCollection.TryGetValue(this.Address.ColumnNumber, out xlColumn) || xlColumn.Style.Equals(this.Worksheet.Style))) && !this.Worksheet.ConditionalFormats.Any<IXLConditionalFormat>((Func<IXLConditionalFormat, bool>) (cf => cf.Range.Contains((IXLCell) this))));
    }

    public IXLColumn WorksheetColumn()
    {
      return (IXLColumn) this.Worksheet.Column(this.Address.ColumnNumber);
    }

    public IXLRow WorksheetRow()
    {
      return (IXLRow) this.Worksheet.Row(this.Address.RowNumber);
    }

    public IXLCell CopyTo(IXLCell target)
    {
      (target as XLCell).CopyFrom(this, true);
      return target;
    }

    public IXLCell CopyTo(string target)
    {
      return this.CopyTo(this.GetTargetCell(target, this.Worksheet));
    }

    public IXLCell CopyFrom(IXLCell otherCell)
    {
      return this.CopyFrom(otherCell as XLCell, true);
    }

    public IXLCell CopyFrom(string otherCell)
    {
      return this.CopyFrom(this.GetTargetCell(otherCell, this.Worksheet));
    }

    public IXLCell SetFormulaA1(string formula)
    {
      this.FormulaA1 = formula;
      return (IXLCell) this;
    }

    public IXLCell SetFormulaR1C1(string formula)
    {
      this.FormulaR1C1 = formula;
      return (IXLCell) this;
    }

    public bool HasDataValidation
    {
      get
      {
        XLRange asRange = this.AsRange();
        try
        {
          return this.Worksheet.DataValidations.Any<IXLDataValidation>((Func<IXLDataValidation, bool>) (dv =>
          {
            if (dv.Ranges.Contains((IXLRange) asRange))
              return dv.IsDirty();
            return false;
          }));
        }
        finally
        {
          if (asRange != null)
            asRange.Dispose();
        }
      }
    }

    public IXLDataValidation SetDataValidation()
    {
      return (IXLDataValidation) this.DataValidation;
    }

    public void Select()
    {
      this.AsRange().Select();
    }

    public IXLConditionalFormat AddConditionalFormat()
    {
      using (XLRange xlRange = this.AsRange())
        return xlRange.AddConditionalFormat();
    }

    public bool Active
    {
      get
      {
        return this.Worksheet.ActiveCell == this;
      }
      set
      {
        if (value)
        {
          this.Worksheet.ActiveCell = (IXLCell) this;
        }
        else
        {
          if (!this.Active)
            return;
          this.Worksheet.ActiveCell = (IXLCell) null;
        }
      }
    }

    public IXLCell SetActive(bool value = true)
    {
      this.Active = value;
      return (IXLCell) this;
    }

    public bool HasHyperlink
    {
      get
      {
        return this._hyperlink != null;
      }
    }

    public XLHyperlink GetHyperlink()
    {
      if (this.HasHyperlink)
        return this.Hyperlink;
      return this.Value as XLHyperlink;
    }

    public bool TryGetValue<T>(out T value)
    {
      object currValue1 = this.Value;
      if (currValue1 == null)
      {
        value = default (T);
        return true;
      }
      bool b;
      if (XLCell.TryGetTimeSpanValue<T>(out value, currValue1, out b))
        return b;
      if (this.TryGetRichStringValue<T>(out value) || XLCell.TryGetStringValue<T>(out value, currValue1))
        return true;
      string currValue2 = currValue1.ToString();
      if (typeof (T) == typeof (bool))
        return XLCell.TryGetBasicValue<T, bool>(out value, currValue2, new XLCell.Func<bool>(bool.TryParse));
      if (typeof (T) == typeof (sbyte))
        return XLCell.TryGetBasicValue<T, sbyte>(out value, currValue2, new XLCell.Func<sbyte>(sbyte.TryParse));
      if (typeof (T) == typeof (byte))
        return XLCell.TryGetBasicValue<T, byte>(out value, currValue2, new XLCell.Func<byte>(byte.TryParse));
      if (typeof (T) == typeof (short))
        return XLCell.TryGetBasicValue<T, short>(out value, currValue2, new XLCell.Func<short>(short.TryParse));
      if (typeof (T) == typeof (ushort))
        return XLCell.TryGetBasicValue<T, ushort>(out value, currValue2, new XLCell.Func<ushort>(ushort.TryParse));
      if (typeof (T) == typeof (int))
        return XLCell.TryGetBasicValue<T, int>(out value, currValue2, new XLCell.Func<int>(int.TryParse));
      if (typeof (T) == typeof (uint))
        return XLCell.TryGetBasicValue<T, uint>(out value, currValue2, new XLCell.Func<uint>(uint.TryParse));
      if (typeof (T) == typeof (long))
        return XLCell.TryGetBasicValue<T, long>(out value, currValue2, new XLCell.Func<long>(long.TryParse));
      if (typeof (T) == typeof (ulong))
        return XLCell.TryGetBasicValue<T, ulong>(out value, currValue2, new XLCell.Func<ulong>(ulong.TryParse));
      if (typeof (T) == typeof (float))
        return XLCell.TryGetBasicValue<T, float>(out value, currValue2, new XLCell.Func<float>(float.TryParse));
      if (typeof (T) == typeof (double))
        return XLCell.TryGetBasicValue<T, double>(out value, currValue2, new XLCell.Func<double>(double.TryParse));
      if (typeof (T) == typeof (Decimal))
        return XLCell.TryGetBasicValue<T, Decimal>(out value, currValue2, new XLCell.Func<Decimal>(Decimal.TryParse));
      if (typeof (T) == typeof (XLHyperlink))
      {
        XLHyperlink hyperlink = this.GetHyperlink();
        if (hyperlink != null)
        {
          value = (T) Convert.ChangeType((object) hyperlink, typeof (T));
          return true;
        }
        value = default (T);
        return false;
      }
      try
      {
        value = (T) Convert.ChangeType(currValue1, typeof (T));
        return true;
      }
      catch
      {
        value = default (T);
        return false;
      }
    }

    private static bool TryGetTimeSpanValue<T>(out T value, object currValue, out bool b)
    {
      if (typeof (T) == typeof (TimeSpan))
      {
        bool flag = true;
        TimeSpan result;
        if (currValue is TimeSpan)
          result = (TimeSpan) currValue;
        else if (!TimeSpan.TryParse(currValue.ToString(), out result))
          flag = false;
        value = (T) Convert.ChangeType((object) result, typeof (T));
        b = flag;
        return true;
      }
      value = default (T);
      b = false;
      return false;
    }

    private bool TryGetRichStringValue<T>(out T value)
    {
      if (typeof (T) == typeof (IXLRichText))
      {
        value = (T) this.RichText;
        return true;
      }
      value = default (T);
      return false;
    }

    private static bool TryGetStringValue<T>(out T value, object currValue)
    {
      if (typeof (T) == typeof (string))
      {
        string input = currValue.ToString();
        if (!XLCell.utfPattern.Match(input).Success)
        {
          value = (T) Convert.ChangeType((object) input, typeof (T));
          return true;
        }
        StringBuilder stringBuilder = new StringBuilder();
        int startIndex = 0;
        foreach (Match match in XLCell.utfPattern.Matches(input))
        {
          string str = match.Value;
          int index = match.Index;
          stringBuilder.Append(input.Substring(startIndex, index - startIndex));
          stringBuilder.Append((char) int.Parse(match.Groups[1].Value, NumberStyles.AllowHexSpecifier));
          startIndex = index + str.Length;
        }
        if (startIndex < input.Length)
          stringBuilder.Append(input.Substring(startIndex));
        value = (T) Convert.ChangeType((object) stringBuilder.ToString(), typeof (T));
        return true;
      }
      value = default (T);
      return false;
    }

    private static bool TryGetBooleanValue<T>(out T value, object currValue)
    {
      bool result;
      if (typeof (T) == typeof (bool) && bool.TryParse(currValue.ToString(), out result))
      {
        value = (T) Convert.ChangeType((object) result, typeof (T));
        return true;
      }
      value = default (T);
      return false;
    }

    private static bool TryGetBasicValue<T, U>(out T value, string currValue, XLCell.Func<U> func)
    {
      U output;
      if (func(currValue, out output))
      {
        value = (T) Convert.ChangeType((object) output, typeof (T));
        return true;
      }
      value = default (T);
      return false;
    }

    public bool StyleChanged { get; set; }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.Style;
        this.UpdatingStyle = false;
      }
    }

    public bool UpdatingStyle { get; set; }

    public IXLStyle InnerStyle
    {
      get
      {
        return this.Style;
      }
      set
      {
        this.Style = value;
      }
    }

    public IXLRanges RangesUsed
    {
      get
      {
        return (IXLRanges) new XLRanges()
        {
          this.AsRange()
        };
      }
    }

    private bool SetRangeColumns(object value)
    {
      XLRangeColumns xlRangeColumns = value as XLRangeColumns;
      if (xlRangeColumns == null)
        return this.SetColumns(value);
      XLCell xlCell = this;
      foreach (IXLRangeColumn xlRangeColumn in xlRangeColumns)
      {
        xlCell.SetRange((object) xlRangeColumn);
        xlCell = xlCell.CellRight();
      }
      return true;
    }

    private bool SetColumns(object value)
    {
      XLColumns xlColumns = value as XLColumns;
      if (xlColumns == null)
        return false;
      XLCell xlCell = this;
      foreach (IXLColumn xlColumn in xlColumns)
      {
        xlCell.SetRange((object) xlColumn);
        xlCell = xlCell.CellRight();
      }
      return true;
    }

    private bool SetRangeRows(object value)
    {
      XLRangeRows xlRangeRows = value as XLRangeRows;
      if (xlRangeRows == null)
        return this.SetRows(value);
      XLCell xlCell = this;
      foreach (IXLRangeRow xlRangeRow in xlRangeRows)
      {
        xlCell.SetRange((object) xlRangeRow);
        xlCell = xlCell.CellBelow();
      }
      return true;
    }

    private bool SetRows(object value)
    {
      XLRows xlRows = value as XLRows;
      if (xlRows == null)
        return false;
      XLCell xlCell = this;
      foreach (IXLRow xlRow in xlRows)
      {
        xlCell.SetRange((object) xlRow);
        xlCell = xlCell.CellBelow();
      }
      return true;
    }

    public XLRange AsRange()
    {
      return this._worksheet.Range((IXLAddress) this.Address, (IXLAddress) this.Address);
    }

    private IXLStyle GetStyle()
    {
      if (this._style != null)
        return this._style;
      return this._style = (IXLStyle) new XLStyle((IXLStylized) this, this.Worksheet.Workbook.GetStyleById(this._styleCacheId), true);
    }

    public void DeleteComment()
    {
      this._comment = (XLComment) null;
    }

    private bool IsDateFormat()
    {
      IXLStyle styleForRead = this.GetStyleForRead();
      if (this._dataType != XLCellValues.Number || !XLHelper.IsNullOrWhiteSpace(styleForRead.NumberFormat.Format))
        return false;
      if (styleForRead.NumberFormat.NumberFormatId >= 14 && styleForRead.NumberFormat.NumberFormatId <= 22)
        return true;
      if (styleForRead.NumberFormat.NumberFormatId >= 45)
        return styleForRead.NumberFormat.NumberFormatId <= 47;
      return false;
    }

    private string GetFormat()
    {
      string str = string.Empty;
      IXLStyle styleForRead = this.GetStyleForRead();
      if (XLHelper.IsNullOrWhiteSpace(styleForRead.NumberFormat.Format))
      {
        Dictionary<int, string> formatCodes = XLCell.GetFormatCodes();
        if (formatCodes.ContainsKey(styleForRead.NumberFormat.NumberFormatId))
          str = formatCodes[styleForRead.NumberFormat.NumberFormatId];
      }
      else
        str = styleForRead.NumberFormat.Format;
      return str;
    }

    private bool SetRichText(object value)
    {
      XLRichText xlRichText = value as XLRichText;
      if (xlRichText == null)
        return false;
      this._richText = xlRichText;
      this._dataType = XLCellValues.Text;
      return true;
    }

    private bool SetRange(object rangeObject)
    {
      XLRangeBase asRange = rangeObject as XLRangeBase;
      if (asRange == null)
      {
        XLCell xlCell = rangeObject as XLCell;
        if (xlCell != null)
          asRange = (XLRangeBase) xlCell.AsRange();
      }
      if (asRange == null)
        return false;
      if (!(asRange is XLRow) && !(asRange is XLColumn))
        this.Worksheet.Range(this.Address.RowNumber, this.Address.ColumnNumber, asRange.RowCount(), asRange.ColumnCount()).Clear(XLClearOptions.ContentsAndFormats);
      int rowNumber = asRange.RangeAddress.FirstAddress.RowNumber;
      int columnNumber = asRange.RangeAddress.FirstAddress.ColumnNumber;
      foreach (XLCell otherCell in asRange.CellsUsed(true))
        this.Worksheet.Cell(this.Address.RowNumber + otherCell.Address.RowNumber - rowNumber, this.Address.ColumnNumber + otherCell.Address.ColumnNumber - columnNumber).CopyFrom(otherCell, true);
      asRange.Worksheet.Internals.MergedRanges.Where<IXLRange>((Func<IXLRange, bool>) (mergedRange => asRange.Contains((IXLRangeBase) mergedRange))).Select(mergedRange => new
      {
        mergedRange = mergedRange,
        initialRo = this.Address.RowNumber + (mergedRange.RangeAddress.FirstAddress.RowNumber - asRange.RangeAddress.FirstAddress.RowNumber)
      }).Select(_param1 => new
      {
        \u003C\u003Eh__TransparentIdentifier11 = _param1,
        initialCo = this.Address.ColumnNumber + (_param1.mergedRange.RangeAddress.FirstAddress.ColumnNumber - asRange.RangeAddress.FirstAddress.ColumnNumber)
      }).Select(_param1 => this.Worksheet.Range(_param1.\u003C\u003Eh__TransparentIdentifier11.initialRo, _param1.initialCo, _param1.\u003C\u003Eh__TransparentIdentifier11.initialRo + _param1.\u003C\u003Eh__TransparentIdentifier11.mergedRange.RowCount() - 1, _param1.initialCo + _param1.\u003C\u003Eh__TransparentIdentifier11.mergedRange.ColumnCount() - 1)).Cast<IXLRange>().ToList<IXLRange>().ForEach((Action<IXLRange>) (r => r.Merge()));
      return true;
    }

    private bool SetEnumerable(object collectionObject)
    {
      return this.InsertData(collectionObject as IEnumerable) != null;
    }

    private void ClearMerged()
    {
      XLRange asRange = this.AsRange();
      List<IXLRange> list;
      try
      {
        list = this.Worksheet.Internals.MergedRanges.Where<IXLRange>((Func<IXLRange, bool>) (merge => merge.Intersects((IXLRangeBase) asRange))).ToList<IXLRange>();
      }
      finally
      {
        if (asRange != null)
          asRange.Dispose();
      }
      list.ForEach((Action<IXLRange>) (m => this.Worksheet.Internals.MergedRanges.Remove(m)));
    }

    private void SetValue<T>(T value, int ro, int co) where T : class
    {
      if ((object) value == null)
        this._worksheet.Cell(ro, co).SetValue<string>(string.Empty);
      else if ((object) value is IConvertible)
        this._worksheet.Cell(ro, co).SetValue<T>((T) Convert.ChangeType((object) value, typeof (T)));
      else
        this._worksheet.Cell(ro, co).SetValue<T>(value);
    }

    private void SetValue(object value)
    {
      this.FormulaA1 = string.Empty;
      string s = value == null ? string.Empty : value.ToString();
      this._richText = (XLRichText) null;
      if (s.Length == 0)
      {
        this._dataType = XLCellValues.Text;
      }
      else
      {
        IXLStyle styleForRead = this.GetStyleForRead();
        if (styleForRead.NumberFormat.Format == "@")
        {
          this._dataType = XLCellValues.Text;
          if (s.Contains(Environment.NewLine) && !styleForRead.Alignment.WrapText)
            this.Style.Alignment.WrapText = true;
        }
        else if ((int) s[0] == 39)
        {
          s = s.Substring(1, s.Length - 1);
          this._dataType = XLCellValues.Text;
          if (s.Contains(Environment.NewLine) && !styleForRead.Alignment.WrapText)
            this.Style.Alignment.WrapText = true;
        }
        else
        {
          double result1;
          TimeSpan result2;
          if (value is TimeSpan || !double.TryParse(s, out result1) && TimeSpan.TryParse(s, out result2))
          {
            if (!(value is TimeSpan) && TimeSpan.TryParse(s, out result2))
              s = result2.ToString();
            this._dataType = XLCellValues.TimeSpan;
            if (styleForRead.NumberFormat.Format == string.Empty && styleForRead.NumberFormat.NumberFormatId == 0)
              this.Style.NumberFormat.NumberFormatId = 46;
          }
          else if (s.Trim() != "NaN" && double.TryParse(s, out result1))
          {
            this._dataType = XLCellValues.Number;
          }
          else
          {
            DateTime result3;
            if (DateTime.TryParse(s, out result3) && result3 >= XLCell.BaseDate)
            {
              this._dataType = XLCellValues.DateTime;
              if (styleForRead.NumberFormat.Format == string.Empty && styleForRead.NumberFormat.NumberFormatId == 0)
                this.Style.NumberFormat.NumberFormatId = result3.Date == result3 ? 14 : 22;
              DateTime dateTime;
              s = !(value is DateTime) || (dateTime = (DateTime) value).Millisecond <= 0 ? result3.ToOADate().ToString() : dateTime.ToOADate().ToString();
            }
            else
            {
              bool result4;
              if (bool.TryParse(s, out result4))
              {
                this._dataType = XLCellValues.Boolean;
                s = result4 ? "1" : "0";
              }
              else
              {
                this._dataType = XLCellValues.Text;
                if (s.Contains(Environment.NewLine) && !styleForRead.Alignment.WrapText)
                  this.Style.Alignment.WrapText = true;
              }
            }
          }
        }
      }
      if (s.Length > (int) short.MaxValue)
        throw new ArgumentException("Cells can only hold 32,767 characters.");
      this._cellValue = s;
    }

    private static Dictionary<int, string> GetFormatCodes()
    {
      if (XLCell._formatCodes == null)
        XLCell._formatCodes = new Dictionary<int, string>()
        {
          {
            0,
            string.Empty
          },
          {
            1,
            "0"
          },
          {
            2,
            "0.00"
          },
          {
            3,
            "#,##0"
          },
          {
            4,
            "#,##0.00"
          },
          {
            7,
            "$#,##0.00_);($#,##0.00)"
          },
          {
            9,
            "0%"
          },
          {
            10,
            "0.00%"
          },
          {
            11,
            "0.00E+00"
          },
          {
            12,
            "# ?/?"
          },
          {
            13,
            "# ??/??"
          },
          {
            14,
            "M/d/yyyy"
          },
          {
            15,
            "d-MMM-yy"
          },
          {
            16,
            "d-MMM"
          },
          {
            17,
            "MMM-yy"
          },
          {
            18,
            "h:mm tt"
          },
          {
            19,
            "h:mm:ss tt"
          },
          {
            20,
            "H:mm"
          },
          {
            21,
            "H:mm:ss"
          },
          {
            22,
            "M/d/yyyy H:mm"
          },
          {
            37,
            "#,##0 ;(#,##0)"
          },
          {
            38,
            "#,##0 ;[Red](#,##0)"
          },
          {
            39,
            "#,##0.00;(#,##0.00)"
          },
          {
            40,
            "#,##0.00;[Red](#,##0.00)"
          },
          {
            45,
            "mm:ss"
          },
          {
            46,
            "[h]:mm:ss"
          },
          {
            47,
            "mmss.0"
          },
          {
            48,
            "##0.0E+0"
          },
          {
            49,
            "@"
          }
        };
      return XLCell._formatCodes;
    }

    private string GetFormulaR1C1(string value)
    {
      return this.GetFormula(value, XLCell.FormulaConversionType.A1ToR1C1, 0, 0);
    }

    private string GetFormulaA1(string value)
    {
      return this.GetFormula(value, XLCell.FormulaConversionType.R1C1ToA1, 0, 0);
    }

    private string GetFormula(string strValue, XLCell.FormulaConversionType conversionType, int rowsToShift, int columnsToShift)
    {
      if (XLHelper.IsNullOrWhiteSpace(strValue))
        return string.Empty;
      string input = ">" + strValue + "<";
      Regex regex = conversionType == XLCell.FormulaConversionType.A1ToR1C1 ? XLCell.A1Regex : XLCell.R1C1Regex;
      StringBuilder stringBuilder = new StringBuilder();
      int startIndex = 0;
      foreach (Match match in regex.Matches(input).Cast<Match>())
      {
        string str = match.Value;
        int index = match.Index;
        if (input.Substring(0, index).CharCount('"') % 2 == 0)
        {
          stringBuilder.Append(input.Substring(startIndex, index - startIndex));
          stringBuilder.Append(conversionType == XLCell.FormulaConversionType.A1ToR1C1 ? this.GetR1C1Address(str, rowsToShift, columnsToShift) : this.GetA1Address(str, rowsToShift, columnsToShift));
        }
        else
          stringBuilder.Append(input.Substring(startIndex, index - startIndex + str.Length));
        startIndex = index + str.Length;
      }
      if (startIndex < input.Length)
        stringBuilder.Append(input.Substring(startIndex));
      string str1 = stringBuilder.ToString();
      return str1.Substring(1, str1.Length - 2);
    }

    private string GetA1Address(string r1C1Address, int rowsToShift, int columnsToShift)
    {
      string upper = r1C1Address.ToUpper();
      if (upper.Contains<char>(':'))
      {
        string[] strArray = upper.Split(':');
        string str1 = strArray[0];
        string str2 = strArray[1];
        string str3;
        string str4;
        if (str1.StartsWith("R"))
        {
          str3 = this.GetA1Row(str1, rowsToShift);
          str4 = this.GetA1Row(str2, rowsToShift);
        }
        else
        {
          str3 = this.GetA1Column(str1, columnsToShift);
          str4 = this.GetA1Column(str2, columnsToShift);
        }
        return str3 + ":" + str4;
      }
      string a1Row = this.GetA1Row(upper.Substring(0, upper.IndexOf("C")), rowsToShift);
      return this.GetA1Column(upper.Substring(upper.IndexOf("C")), columnsToShift) + a1Row;
    }

    private string GetA1Column(string columnPart, int columnsToShift)
    {
      string str;
      if (columnPart == "C")
      {
        str = XLHelper.GetColumnLetterFromNumber(this.Address.ColumnNumber + columnsToShift);
      }
      else
      {
        int num = columnPart.IndexOf("[");
        int startIndex = columnPart.IndexOf("-");
        str = num < 0 ? (startIndex < 0 ? "$" + XLHelper.GetColumnLetterFromNumber(int.Parse(columnPart.Substring(1)) + columnsToShift) : XLHelper.GetColumnLetterFromNumber(this.Address.ColumnNumber + int.Parse(columnPart.Substring(startIndex)) + columnsToShift)) : XLHelper.GetColumnLetterFromNumber(this.Address.ColumnNumber + int.Parse(columnPart.Substring(num + 1, columnPart.Length - num - 2)) + columnsToShift);
      }
      return str;
    }

    private string GetA1Row(string rowPart, int rowsToShift)
    {
      string str;
      if (rowPart == "R")
      {
        str = (this.Address.RowNumber + rowsToShift).ToString();
      }
      else
      {
        int num = rowPart.IndexOf("[");
        str = num < 0 ? "$" + (object) (int.Parse(rowPart.Substring(1)) + rowsToShift) : (this.Address.RowNumber + int.Parse(rowPart.Substring(num + 1, rowPart.Length - num - 2)) + rowsToShift).ToString();
      }
      return str;
    }

    private string GetR1C1Address(string a1Address, int rowsToShift, int columnsToShift)
    {
      if (a1Address.Contains<char>(':'))
      {
        string[] strArray = a1Address.Split(':');
        string source1 = strArray[0];
        string source2 = strArray[1];
        int result;
        if (int.TryParse(source1.Replace("$", string.Empty), out result))
        {
          int rowNumber = int.Parse(source2.Replace("$", string.Empty));
          return this.GetR1C1Row(result, source1.Contains<char>('$'), rowsToShift) + ":" + this.GetR1C1Row(rowNumber, source2.Contains<char>('$'), rowsToShift);
        }
        int numberFromLetter1 = XLHelper.GetColumnNumberFromLetter(source1.Replace("$", string.Empty));
        int numberFromLetter2 = XLHelper.GetColumnNumberFromLetter(source2.Replace("$", string.Empty));
        return this.GetR1C1Column(numberFromLetter1, source1.Contains<char>('$'), columnsToShift) + ":" + this.GetR1C1Column(numberFromLetter2, source2.Contains<char>('$'), columnsToShift);
      }
      XLAddress xlAddress = XLAddress.Create(this._worksheet, a1Address);
      return this.GetR1C1Row(xlAddress.RowNumber, xlAddress.FixedRow, rowsToShift) + this.GetR1C1Column(xlAddress.ColumnNumber, xlAddress.FixedColumn, columnsToShift);
    }

    private string GetR1C1Row(int rowNumber, bool fixedRow, int rowsToShift)
    {
      rowNumber += rowsToShift;
      int num = rowNumber - this.Address.RowNumber;
      return num != 0 || fixedRow ? (fixedRow ? string.Format("R{0}", (object) rowNumber) : string.Format("R[{0}]", (object) num)) : "R";
    }

    private string GetR1C1Column(int columnNumber, bool fixedColumn, int columnsToShift)
    {
      columnNumber += columnsToShift;
      int num = columnNumber - this.Address.ColumnNumber;
      return num != 0 || fixedColumn ? (fixedColumn ? string.Format("C{0}", (object) columnNumber) : string.Format("C[{0}]", (object) num)) : "C";
    }

    internal void CopyValues(XLCell source)
    {
      this._cellValue = source._cellValue;
      this._dataType = source._dataType;
      this.FormulaR1C1 = source.FormulaR1C1;
      this._richText = source._richText == null ? (XLRichText) null : new XLRichText((XLFormattedText<IXLRichText>) source._richText, (IXLFontBase) source.Style.Font);
      this._comment = source._comment == null ? (XLComment) null : new XLComment(this, (XLFormattedText<IXLComment>) source._comment, (IXLFontBase) source.Style.Font);
      if (source._hyperlink == null)
        return;
      this.SettingHyperlink = true;
      this.Hyperlink = new XLHyperlink(source.Hyperlink);
      this.SettingHyperlink = false;
    }

    private IXLCell GetTargetCell(string target, XLWorksheet defaultWorksheet)
    {
      string[] strArray = target.Split('!');
      if (strArray.Length == 1)
        return (IXLCell) defaultWorksheet.Cell(target);
      string name = strArray[0];
      if (name.StartsWith("'"))
        name = name.Substring(1, name.Length - 2);
      return defaultWorksheet.Workbook.Worksheet(name).Cell(strArray[1]);
    }

    public IXLCell CopyFrom(XLCell otherCell, bool copyDataValidations)
    {
      XLCell xlCell = otherCell;
      this.CopyValues(otherCell);
      this.SetStyle(xlCell._style ?? xlCell.Worksheet.Workbook.GetStyleById(xlCell._styleCacheId));
      foreach (IXLConditionalFormat conditionalFormat1 in otherCell.Worksheet.ConditionalFormats.Where<IXLConditionalFormat>((Func<IXLConditionalFormat, bool>) (c => c.Range.Contains((IXLCell) otherCell))).ToList<IXLConditionalFormat>())
      {
        XLConditionalFormat conditionalFormat2 = new XLConditionalFormat(conditionalFormat1 as XLConditionalFormat)
        {
          Range = (IXLRange) this.AsRange()
        };
        List<XLFormula> list = conditionalFormat2.Values.Values.ToList<XLFormula>();
        conditionalFormat2.Values.Clear();
        foreach (XLFormula xlFormula in list)
        {
          string formulaA1 = xlFormula.Value;
          if (xlFormula.IsFormula)
            formulaA1 = this.GetFormulaA1(otherCell.GetFormulaR1C1(formulaA1));
          conditionalFormat2.Values.Add(new XLFormula()
          {
            _value = formulaA1,
            IsFormula = xlFormula.IsFormula
          });
        }
        this._worksheet.ConditionalFormats.Add((IXLConditionalFormat) conditionalFormat2);
      }
      if (copyDataValidations)
      {
        bool eventTrackingEnabled = this.Worksheet.EventTrackingEnabled;
        this.Worksheet.EventTrackingEnabled = false;
        if (otherCell.HasDataValidation)
          this.CopyDataValidation(otherCell, otherCell.DataValidation);
        else if (this.HasDataValidation)
        {
          using (XLRange xlRange = this.AsRange())
            this.Worksheet.DataValidations.Delete((IXLRange) xlRange);
        }
        this.Worksheet.EventTrackingEnabled = eventTrackingEnabled;
      }
      return (IXLCell) this;
    }

    internal void CopyDataValidation(XLCell otherCell, XLDataValidation otherDv)
    {
      XLDataValidation dataValidation = this.DataValidation;
      dataValidation.CopyFrom((IXLDataValidation) otherDv);
      dataValidation.Value = this.GetFormulaA1(otherCell.GetFormulaR1C1(otherDv.Value));
      dataValidation.MinValue = this.GetFormulaA1(otherCell.GetFormulaR1C1(otherDv.MinValue));
      dataValidation.MaxValue = this.GetFormulaA1(otherCell.GetFormulaR1C1(otherDv.MaxValue));
    }

    internal void ShiftFormulaRows(XLRange shiftedRange, int rowsShifted)
    {
      this._formulaA1 = XLCell.ShiftFormulaRows(this.FormulaA1, this.Worksheet, shiftedRange, rowsShifted);
    }

    internal static string ShiftFormulaRows(string formulaA1, XLWorksheet worksheetInAction, XLRange shiftedRange, int rowsShifted)
    {
      if (XLHelper.IsNullOrWhiteSpace(formulaA1))
        return string.Empty;
      string input = formulaA1;
      Regex a1SimpleRegex = XLCell.A1SimpleRegex;
      StringBuilder stringBuilder = new StringBuilder();
      int startIndex = 0;
      string name = shiftedRange.Worksheet.Name;
      foreach (Match match in a1SimpleRegex.Matches(input).Cast<Match>())
      {
        string source = match.Value;
        int index = match.Index;
        if (input.Substring(0, index).CharCount('"') % 2 == 0)
        {
          stringBuilder.Append(input.Substring(startIndex, index - startIndex));
          bool flag = false;
          string str1;
          if (source.Contains<char>('!'))
          {
            str1 = source.Substring(0, source.IndexOf('!'));
            if ((int) str1[0] == 39)
              str1 = str1.Substring(1, str1.Length - 2);
            flag = true;
          }
          else
            str1 = worksheetInAction.Name;
          if (string.Compare(str1, name, true) == 0)
          {
            string str2 = source.Substring(source.IndexOf('!') + 1);
            if (!XLCell.A1ColumnRegex.IsMatch(str2))
            {
              IXLRange xlRange = worksheetInAction.Workbook.Worksheet(str1).Range(str2);
              if (shiftedRange.RangeAddress.FirstAddress.RowNumber <= xlRange.RangeAddress.LastAddress.RowNumber && shiftedRange.RangeAddress.FirstAddress.ColumnNumber <= xlRange.RangeAddress.FirstAddress.ColumnNumber && shiftedRange.RangeAddress.LastAddress.ColumnNumber >= xlRange.RangeAddress.LastAddress.ColumnNumber)
              {
                if (XLCell.A1RowRegex.IsMatch(str2))
                {
                  string[] strArray = str2.Split(':');
                  string s1 = strArray[0];
                  string s2 = strArray[1];
                  string str3 = (int) s1[0] != 36 ? (int.Parse(s1) + rowsShifted).ToInvariantString() : "$" + (int.Parse(s1.Substring(1)) + rowsShifted).ToInvariantString();
                  string str4 = (int) s2[0] != 36 ? (int.Parse(s2) + rowsShifted).ToInvariantString() : "$" + (int.Parse(s2.Substring(1)) + rowsShifted).ToInvariantString();
                  stringBuilder.Append(flag ? string.Format("'{0}'!{1}:{2}", (object) str1, (object) str3, (object) str4) : string.Format("{0}:{1}", (object) str3, (object) str4));
                }
                else if (shiftedRange.RangeAddress.FirstAddress.RowNumber <= xlRange.RangeAddress.FirstAddress.RowNumber)
                {
                  if (str2.Contains<char>(':'))
                  {
                    if (flag)
                      stringBuilder.Append(string.Format("'{0}'!{1}:{2}", (object) str1, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber + rowsShifted, xlRange.RangeAddress.FirstAddress.ColumnLetter, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn), (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber + rowsShifted, xlRange.RangeAddress.LastAddress.ColumnLetter, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
                    else
                      stringBuilder.Append(string.Format("{0}:{1}", (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber + rowsShifted, xlRange.RangeAddress.FirstAddress.ColumnLetter, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn), (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber + rowsShifted, xlRange.RangeAddress.LastAddress.ColumnLetter, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
                  }
                  else if (flag)
                    stringBuilder.Append(string.Format("'{0}'!{1}", (object) str1, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber + rowsShifted, xlRange.RangeAddress.FirstAddress.ColumnLetter, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn)));
                  else
                    stringBuilder.Append(string.Format("{0}", (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber + rowsShifted, xlRange.RangeAddress.FirstAddress.ColumnLetter, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn)));
                }
                else if (flag)
                  stringBuilder.Append(string.Format("'{0}'!{1}:{2}", (object) str1, (object) xlRange.RangeAddress.FirstAddress, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber + rowsShifted, xlRange.RangeAddress.LastAddress.ColumnLetter, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
                else
                  stringBuilder.Append(string.Format("{0}:{1}", (object) xlRange.RangeAddress.FirstAddress, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber + rowsShifted, xlRange.RangeAddress.LastAddress.ColumnLetter, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
              }
              else
                stringBuilder.Append(source);
            }
            else
              stringBuilder.Append(source);
          }
          else
            stringBuilder.Append(source);
        }
        else
          stringBuilder.Append(input.Substring(startIndex, index - startIndex + source.Length));
        startIndex = index + source.Length;
      }
      if (startIndex < input.Length)
        stringBuilder.Append(input.Substring(startIndex));
      return stringBuilder.ToString();
    }

    internal void ShiftFormulaColumns(XLRange shiftedRange, int columnsShifted)
    {
      this._formulaA1 = XLCell.ShiftFormulaColumns(this.FormulaA1, this.Worksheet, shiftedRange, columnsShifted);
    }

    internal static string ShiftFormulaColumns(string formulaA1, XLWorksheet worksheetInAction, XLRange shiftedRange, int columnsShifted)
    {
      if (XLHelper.IsNullOrWhiteSpace(formulaA1))
        return string.Empty;
      string input = formulaA1;
      Regex a1SimpleRegex = XLCell.A1SimpleRegex;
      StringBuilder stringBuilder = new StringBuilder();
      int startIndex = 0;
      foreach (Match match in a1SimpleRegex.Matches(input).Cast<Match>())
      {
        string source = match.Value;
        int index = match.Index;
        if (input.Substring(0, index).CharCount('"') % 2 == 0)
        {
          stringBuilder.Append(input.Substring(startIndex, index - startIndex));
          bool flag = false;
          string str1;
          if (source.Contains<char>('!'))
          {
            str1 = source.Substring(0, source.IndexOf('!'));
            if ((int) str1[0] == 39)
              str1 = str1.Substring(1, str1.Length - 2);
            flag = true;
          }
          else
            str1 = worksheetInAction.Name;
          if (string.Compare(str1, shiftedRange.Worksheet.Name, true) == 0)
          {
            string str2 = source.Substring(source.IndexOf('!') + 1);
            if (!XLCell.A1RowRegex.IsMatch(str2))
            {
              IXLRange xlRange = worksheetInAction.Workbook.Worksheet(str1).Range(str2);
              if (shiftedRange.RangeAddress.FirstAddress.ColumnNumber <= xlRange.RangeAddress.LastAddress.ColumnNumber && shiftedRange.RangeAddress.FirstAddress.RowNumber <= xlRange.RangeAddress.FirstAddress.RowNumber && shiftedRange.RangeAddress.LastAddress.RowNumber >= xlRange.RangeAddress.LastAddress.RowNumber)
              {
                if (XLCell.A1ColumnRegex.IsMatch(str2))
                {
                  string[] strArray = str2.Split(':');
                  string columnLetter1 = strArray[0];
                  string columnLetter2 = strArray[1];
                  string str3 = (int) columnLetter1[0] != 36 ? XLHelper.GetColumnLetterFromNumber(XLHelper.GetColumnNumberFromLetter(columnLetter1) + columnsShifted) : "$" + XLHelper.GetColumnLetterFromNumber(XLHelper.GetColumnNumberFromLetter(columnLetter1.Substring(1)) + columnsShifted);
                  string str4 = (int) columnLetter2[0] != 36 ? XLHelper.GetColumnLetterFromNumber(XLHelper.GetColumnNumberFromLetter(columnLetter2) + columnsShifted) : "$" + XLHelper.GetColumnLetterFromNumber(XLHelper.GetColumnNumberFromLetter(columnLetter2.Substring(1)) + columnsShifted);
                  stringBuilder.Append(flag ? string.Format("'{0}'!{1}:{2}", (object) str1, (object) str3, (object) str4) : string.Format("{0}:{1}", (object) str3, (object) str4));
                }
                else if (shiftedRange.RangeAddress.FirstAddress.ColumnNumber <= xlRange.RangeAddress.FirstAddress.ColumnNumber)
                {
                  if (str2.Contains<char>(':'))
                  {
                    if (flag)
                      stringBuilder.Append(string.Format("'{0}'!{1}:{2}", (object) str1, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber, xlRange.RangeAddress.FirstAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn), (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber, xlRange.RangeAddress.LastAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
                    else
                      stringBuilder.Append(string.Format("{0}:{1}", (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber, xlRange.RangeAddress.FirstAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn), (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber, xlRange.RangeAddress.LastAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
                  }
                  else if (flag)
                    stringBuilder.Append(string.Format("'{0}'!{1}", (object) str1, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber, xlRange.RangeAddress.FirstAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn)));
                  else
                    stringBuilder.Append(string.Format("{0}", (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.FirstAddress.RowNumber, xlRange.RangeAddress.FirstAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.FirstAddress.FixedRow, xlRange.RangeAddress.FirstAddress.FixedColumn)));
                }
                else if (flag)
                  stringBuilder.Append(string.Format("'{0}'!{1}:{2}", (object) str1, (object) xlRange.RangeAddress.FirstAddress, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber, xlRange.RangeAddress.LastAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
                else
                  stringBuilder.Append(string.Format("{0}:{1}", (object) xlRange.RangeAddress.FirstAddress, (object) new XLAddress(worksheetInAction, xlRange.RangeAddress.LastAddress.RowNumber, xlRange.RangeAddress.LastAddress.ColumnNumber + columnsShifted, xlRange.RangeAddress.LastAddress.FixedRow, xlRange.RangeAddress.LastAddress.FixedColumn)));
              }
              else
                stringBuilder.Append(source);
            }
            else
              stringBuilder.Append(source);
          }
          else
            stringBuilder.Append(source);
        }
        else
          stringBuilder.Append(input.Substring(startIndex, index - startIndex + source.Length));
        startIndex = index + source.Length;
      }
      if (startIndex < input.Length)
        stringBuilder.Append(input.Substring(startIndex));
      return stringBuilder.ToString();
    }

    private XLCell CellShift(int rowsToShift, int columnsToShift)
    {
      return this.Worksheet.Cell(this.Address.RowNumber + rowsToShift, this.Address.ColumnNumber + columnsToShift);
    }

    private static string GetFieldName(object[] customAttributes)
    {
      object obj = ((IEnumerable<object>) customAttributes).FirstOrDefault<object>((Func<object, bool>) (a => a is DisplayAttribute));
      if (obj == null)
        return (string) null;
      return (obj as DisplayAttribute).Name;
    }

    IXLCell IXLCell.CellAbove()
    {
      return (IXLCell) this.CellAbove();
    }

    IXLCell IXLCell.CellAbove(int step)
    {
      return (IXLCell) this.CellAbove(step);
    }

    public XLCell CellAbove()
    {
      return this.CellAbove(1);
    }

    public XLCell CellAbove(int step)
    {
      return this.CellShift(step * -1, 0);
    }

    IXLCell IXLCell.CellBelow()
    {
      return (IXLCell) this.CellBelow();
    }

    IXLCell IXLCell.CellBelow(int step)
    {
      return (IXLCell) this.CellBelow(step);
    }

    public XLCell CellBelow()
    {
      return this.CellBelow(1);
    }

    public XLCell CellBelow(int step)
    {
      return this.CellShift(step, 0);
    }

    IXLCell IXLCell.CellLeft()
    {
      return (IXLCell) this.CellLeft();
    }

    IXLCell IXLCell.CellLeft(int step)
    {
      return (IXLCell) this.CellLeft(step);
    }

    public XLCell CellLeft()
    {
      return this.CellLeft(1);
    }

    public XLCell CellLeft(int step)
    {
      return this.CellShift(0, step * -1);
    }

    IXLCell IXLCell.CellRight()
    {
      return (IXLCell) this.CellRight();
    }

    IXLCell IXLCell.CellRight(int step)
    {
      return (IXLCell) this.CellRight(step);
    }

    public XLCell CellRight()
    {
      return this.CellRight(1);
    }

    public XLCell CellRight(int step)
    {
      return this.CellShift(0, step);
    }

    public bool HasFormula
    {
      get
      {
        return !XLHelper.IsNullOrWhiteSpace(this.FormulaA1);
      }
    }

    public IXLRangeAddress FormulaReference { get; set; }

    private delegate bool Func<T>(string input, out T output);

    private enum FormulaConversionType
    {
      A1ToR1C1,
      R1C1ToA1,
    }
  }
}
