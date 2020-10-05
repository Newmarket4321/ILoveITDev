// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLAddress
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClosedXML.Excel
{
  internal class XLAddress : IXLAddress, IEqualityComparer<IXLAddress>, IEquatable<IXLAddress>
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool _fixedRow;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool _fixedColumn;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string _columnLetter;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int _rowNumber;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int _columnNumber;
    private string _trimmedAddress;

    public static XLAddress Create(string cellAddressString)
    {
      return XLAddress.Create((XLWorksheet) null, cellAddressString);
    }

    public static XLAddress Create(XLAddress cellAddress)
    {
      return new XLAddress(cellAddress.Worksheet, cellAddress.RowNumber, cellAddress.ColumnNumber, cellAddress.FixedRow, cellAddress.FixedColumn);
    }

    public static XLAddress Create(XLWorksheet worksheet, string cellAddressString)
    {
      bool fixedColumn = (int) cellAddressString[0] == 36;
      int startIndex = !fixedColumn ? 0 : 1;
      int index = startIndex;
      while ((int) cellAddressString[index] > 57)
        ++index;
      bool fixedRow = (int) cellAddressString[index] == 36;
      string columnLetter;
      int rowNumber;
      if (fixedRow)
      {
        columnLetter = !fixedColumn ? cellAddressString.Substring(startIndex, index) : cellAddressString.Substring(startIndex, index - 1);
        rowNumber = int.Parse(cellAddressString.Substring(index + 1), (IFormatProvider) XLHelper.NumberFormatForParse);
      }
      else
      {
        columnLetter = !fixedColumn ? cellAddressString.Substring(startIndex, index) : cellAddressString.Substring(startIndex, index - 1);
        rowNumber = int.Parse(cellAddressString.Substring(index), (IFormatProvider) XLHelper.NumberFormatForParse);
      }
      return new XLAddress(worksheet, rowNumber, columnLetter, fixedRow, fixedColumn);
    }

    public XLAddress(int rowNumber, string columnLetter, bool fixedRow, bool fixedColumn)
      : this((XLWorksheet) null, rowNumber, columnLetter, fixedRow, fixedColumn)
    {
    }

    public XLAddress(XLWorksheet worksheet, int rowNumber, string columnLetter, bool fixedRow, bool fixedColumn)
      : this(worksheet, rowNumber, XLHelper.GetColumnNumberFromLetter(columnLetter), fixedRow, fixedColumn)
    {
      this._columnLetter = columnLetter;
    }

    public XLAddress(int rowNumber, int columnNumber, bool fixedRow, bool fixedColumn)
      : this((XLWorksheet) null, rowNumber, columnNumber, fixedRow, fixedColumn)
    {
    }

    public XLAddress(XLWorksheet worksheet, int rowNumber, int columnNumber, bool fixedRow, bool fixedColumn)
    {
      this.Worksheet = worksheet;
      this._rowNumber = rowNumber;
      this._columnNumber = columnNumber;
      this._columnLetter = (string) null;
      this._fixedColumn = fixedColumn;
      this._fixedRow = fixedRow;
    }

    public XLWorksheet Worksheet { get; internal set; }

    IXLWorksheet IXLAddress.Worksheet
    {
      [DebuggerStepThrough] get
      {
        return (IXLWorksheet) this.Worksheet;
      }
    }

    public bool HasWorksheet
    {
      [DebuggerStepThrough] get
      {
        return this.Worksheet != null;
      }
    }

    public bool FixedRow
    {
      get
      {
        return this._fixedRow;
      }
      set
      {
        this._fixedRow = value;
      }
    }

    public bool FixedColumn
    {
      get
      {
        return this._fixedColumn;
      }
      set
      {
        this._fixedColumn = value;
      }
    }

    public int RowNumber
    {
      get
      {
        return this._rowNumber;
      }
    }

    public int ColumnNumber
    {
      get
      {
        return this._columnNumber;
      }
    }

    public string ColumnLetter
    {
      get
      {
        return this._columnLetter ?? (this._columnLetter = XLHelper.GetColumnLetterFromNumber(this._columnNumber));
      }
    }

    public override string ToString()
    {
      string str = this.ColumnLetter;
      if (this._fixedColumn)
        str = "$" + str;
      if (this._fixedRow)
        str += "$";
      return str + this._rowNumber.ToInvariantString();
    }

    public string ToString(XLReferenceStyle referenceStyle)
    {
      if (referenceStyle == XLReferenceStyle.A1)
        return this.ColumnLetter + this._rowNumber.ToInvariantString();
      if (referenceStyle == XLReferenceStyle.R1C1)
        return string.Format("R{0}C{1}", (object) this._rowNumber.ToInvariantString(), (object) this.ColumnNumber);
      if (this.HasWorksheet && this.Worksheet.Workbook.ReferenceStyle == XLReferenceStyle.R1C1)
        return string.Format("R{0}C{1}", (object) this._rowNumber.ToInvariantString(), (object) this.ColumnNumber);
      return this.ColumnLetter + this._rowNumber.ToInvariantString();
    }

    public string GetTrimmedAddress()
    {
      return this._trimmedAddress ?? (this._trimmedAddress = this.ColumnLetter + this._rowNumber.ToInvariantString());
    }

    public static XLAddress operator +(XLAddress left, XLAddress right)
    {
      return new XLAddress(left.Worksheet, left.RowNumber + right.RowNumber, left.ColumnNumber + right.ColumnNumber, left._fixedRow, left._fixedColumn);
    }

    public static XLAddress operator -(XLAddress left, XLAddress right)
    {
      return new XLAddress(left.Worksheet, left.RowNumber - right.RowNumber, left.ColumnNumber - right.ColumnNumber, left._fixedRow, left._fixedColumn);
    }

    public static XLAddress operator +(XLAddress left, int right)
    {
      return new XLAddress(left.Worksheet, left.RowNumber + right, left.ColumnNumber + right, left._fixedRow, left._fixedColumn);
    }

    public static XLAddress operator -(XLAddress left, int right)
    {
      return new XLAddress(left.Worksheet, left.RowNumber - right, left.ColumnNumber - right, left._fixedRow, left._fixedColumn);
    }

    public static bool operator ==(XLAddress left, XLAddress right)
    {
      if (object.ReferenceEquals((object) left, (object) right))
        return true;
      if (!object.ReferenceEquals((object) left, (object) null))
        return left.Equals((IXLAddress) right);
      return false;
    }

    public static bool operator !=(XLAddress left, XLAddress right)
    {
      return !(left == right);
    }

    public bool Equals(IXLAddress x, IXLAddress y)
    {
      return x == y;
    }

    public int GetHashCode(IXLAddress obj)
    {
      return obj.GetHashCode();
    }

    public bool Equals(object x, object y)
    {
      return x == y;
    }

    public int GetHashCode(object obj)
    {
      return obj.GetHashCode();
    }

    public override int GetHashCode()
    {
      return this._rowNumber ^ this._columnNumber;
    }

    public bool Equals(IXLAddress other)
    {
      XLAddress xlAddress = other as XLAddress;
      if (object.ReferenceEquals((object) xlAddress, (object) null) || this._rowNumber != xlAddress._rowNumber)
        return false;
      return this._columnNumber == xlAddress._columnNumber;
    }

    public override bool Equals(object other)
    {
      return this.Equals((IXLAddress) other);
    }

    public string ToStringRelative()
    {
      return this.ToStringRelative(false);
    }

    public string ToStringFixed()
    {
      return this.ToStringFixed(XLReferenceStyle.Default);
    }

    public string ToStringRelative(bool includeSheet)
    {
      if (includeSheet)
        return string.Format("'{0}'!{1}", (object) this.Worksheet.Name, (object) this.GetTrimmedAddress());
      return this.GetTrimmedAddress();
    }

    public string ToStringFixed(XLReferenceStyle referenceStyle)
    {
      return this.ToStringFixed(referenceStyle, false);
    }

    public string ToStringFixed(XLReferenceStyle referenceStyle, bool includeSheet)
    {
      string str;
      switch (referenceStyle)
      {
        case XLReferenceStyle.R1C1:
          str = string.Format("R{0}C{1}", (object) this._rowNumber.ToInvariantString(), (object) this.ColumnNumber);
          break;
        case XLReferenceStyle.A1:
          str = string.Format("${0}${1}", (object) this.ColumnLetter, (object) this._rowNumber.ToInvariantString());
          break;
        default:
          str = !this.HasWorksheet || this.Worksheet.Workbook.ReferenceStyle != XLReferenceStyle.R1C1 ? string.Format("${0}${1}", (object) this.ColumnLetter, (object) this._rowNumber.ToInvariantString()) : string.Format("R{0}C{1}", (object) this._rowNumber.ToInvariantString(), (object) this.ColumnNumber);
          break;
      }
      if (includeSheet)
        return string.Format("'{0}'!{1}", (object) this.Worksheet.Name, (object) str);
      return str;
    }

    public string UniqueId
    {
      get
      {
        return this.RowNumber.ToString("0000000") + this.ColumnNumber.ToString("00000");
      }
    }
  }
}
