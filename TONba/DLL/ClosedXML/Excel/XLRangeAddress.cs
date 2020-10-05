// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeAddress
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRangeAddress : IXLRangeAddress
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private XLAddress _firstAddress;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private XLAddress _lastAddress;

    public XLRangeAddress(XLRangeAddress rangeAddress)
      : this(rangeAddress.FirstAddress, rangeAddress.LastAddress)
    {
    }

    public XLRangeAddress(XLAddress firstAddress, XLAddress lastAddress)
    {
      this.Worksheet = firstAddress.Worksheet;
      this.FirstAddress = XLAddress.Create(firstAddress);
      this.LastAddress = XLAddress.Create(lastAddress);
    }

    public XLRangeAddress(XLWorksheet worksheet, string rangeAddress)
    {
      string source = rangeAddress.Contains("!") ? rangeAddress.Substring(rangeAddress.IndexOf("!") + 1) : rangeAddress;
      string str1;
      string cellAddressString;
      if (source.Contains<char>(':'))
      {
        string[] strArray = source.Split(':');
        str1 = strArray[0];
        cellAddressString = strArray[1];
      }
      else
      {
        str1 = source;
        cellAddressString = source;
      }
      if (XLHelper.IsValidA1Address(str1))
      {
        this.FirstAddress = XLAddress.Create(worksheet, str1);
        this.LastAddress = XLAddress.Create(worksheet, cellAddressString);
      }
      else
      {
        string str2 = str1.Replace("$", string.Empty);
        string str3 = cellAddressString.Replace("$", string.Empty);
        if (char.IsDigit(str2[0]))
        {
          this.FirstAddress = XLAddress.Create(worksheet, "A" + str2);
          this.LastAddress = XLAddress.Create(worksheet, "XFD" + str3);
        }
        else
        {
          this.FirstAddress = XLAddress.Create(worksheet, str2 + "1");
          this.LastAddress = XLAddress.Create(worksheet, str3 + 1048576.ToString((IFormatProvider) CultureInfo.InvariantCulture));
        }
      }
      this.Worksheet = worksheet;
    }

    public XLWorksheet Worksheet { get; internal set; }

    public XLAddress FirstAddress
    {
      get
      {
        if (this.IsInvalid)
          throw new Exception("Range is invalid.");
        return this._firstAddress;
      }
      set
      {
        this._firstAddress = value;
      }
    }

    public XLAddress LastAddress
    {
      get
      {
        if (this.IsInvalid)
          throw new Exception("Range is an invalid state.");
        return this._lastAddress;
      }
      set
      {
        this._lastAddress = value;
      }
    }

    IXLWorksheet IXLRangeAddress.Worksheet
    {
      get
      {
        return (IXLWorksheet) this.Worksheet;
      }
    }

    IXLAddress IXLRangeAddress.FirstAddress
    {
      [DebuggerStepThrough] get
      {
        return (IXLAddress) this.FirstAddress;
      }
      set
      {
        this.FirstAddress = value as XLAddress;
      }
    }

    IXLAddress IXLRangeAddress.LastAddress
    {
      [DebuggerStepThrough] get
      {
        return (IXLAddress) this.LastAddress;
      }
      set
      {
        this.LastAddress = value as XLAddress;
      }
    }

    public bool IsInvalid { get; set; }

    public string ToStringRelative()
    {
      return this.ToStringRelative(false);
    }

    public string ToStringFixed()
    {
      return this.ToStringFixed(XLReferenceStyle.A1);
    }

    public string ToStringRelative(bool includeSheet)
    {
      if (includeSheet)
        return string.Format("'{0}'!{1}:{2}", (object) this.Worksheet.Name, (object) this._firstAddress.ToStringRelative(), (object) this._lastAddress.ToStringRelative());
      return this._firstAddress.ToStringRelative() + ":" + this._lastAddress.ToStringRelative();
    }

    public string ToStringFixed(XLReferenceStyle referenceStyle)
    {
      return this.ToStringFixed(referenceStyle, false);
    }

    public string ToStringFixed(XLReferenceStyle referenceStyle, bool includeSheet)
    {
      if (includeSheet)
        return string.Format("'{0}'!{1}:{2}", (object) this.Worksheet.Name, (object) this._firstAddress.ToStringFixed(referenceStyle), (object) this._lastAddress.ToStringFixed(referenceStyle));
      return this._firstAddress.ToStringFixed(referenceStyle) + ":" + this._lastAddress.ToStringFixed(referenceStyle);
    }

    public override string ToString()
    {
      return this._firstAddress.ToString() + ":" + (object) this._lastAddress;
    }

    public override bool Equals(object obj)
    {
      XLRangeAddress xlRangeAddress = (XLRangeAddress) obj;
      if (this.Worksheet.Equals((object) xlRangeAddress.Worksheet) && this.FirstAddress.Equals((IXLAddress) xlRangeAddress.FirstAddress))
        return this.LastAddress.Equals((IXLAddress) xlRangeAddress.LastAddress);
      return false;
    }

    public override int GetHashCode()
    {
      return this.Worksheet.GetHashCode() ^ this.FirstAddress.GetHashCode() ^ this.LastAddress.GetHashCode();
    }
  }
}
