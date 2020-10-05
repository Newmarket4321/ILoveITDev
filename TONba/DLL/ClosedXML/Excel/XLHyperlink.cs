// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLHyperlink
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Linq;

namespace ClosedXML.Excel
{
  public class XLHyperlink
  {
    private Uri _externalAddress;
    private string _internalAddress;

    internal XLHyperlink()
    {
    }

    internal XLHyperlink(XLHyperlink hyperlink)
    {
      this._externalAddress = hyperlink._externalAddress;
      this._internalAddress = hyperlink._internalAddress;
      this.Tooltip = hyperlink.Tooltip;
      this.IsExternal = hyperlink.IsExternal;
    }

    internal void SetValues(string address, string tooltip)
    {
      this.Tooltip = tooltip;
      if ((int) address[0] == 46)
      {
        this._externalAddress = new Uri(address, UriKind.Relative);
        this.IsExternal = true;
      }
      else
      {
        Uri result;
        if (Uri.TryCreate(address, UriKind.Absolute, out result))
        {
          this._externalAddress = result;
          this.IsExternal = true;
        }
        else
        {
          this._internalAddress = address;
          this.IsExternal = false;
        }
      }
    }

    internal void SetValues(Uri uri, string tooltip)
    {
      this.Tooltip = tooltip;
      this._externalAddress = uri;
      this.IsExternal = true;
    }

    internal void SetValues(IXLCell cell, string tooltip)
    {
      this.Tooltip = tooltip;
      this._internalAddress = cell.Address.ToString();
      this.IsExternal = false;
    }

    internal void SetValues(IXLRangeBase range, string tooltip)
    {
      this.Tooltip = tooltip;
      this._internalAddress = range.RangeAddress.ToString();
      this.IsExternal = false;
    }

    internal XLWorksheet Worksheet { get; set; }

    public XLHyperlink(string address)
    {
      this.SetValues(address, string.Empty);
    }

    public XLHyperlink(string address, string tooltip)
    {
      this.SetValues(address, tooltip);
    }

    public XLHyperlink(IXLCell cell)
    {
      this.SetValues(cell, string.Empty);
    }

    public XLHyperlink(IXLCell cell, string tooltip)
    {
      this.SetValues(cell, tooltip);
    }

    public XLHyperlink(IXLRangeBase range)
    {
      this.SetValues(range, string.Empty);
    }

    public XLHyperlink(IXLRangeBase range, string tooltip)
    {
      this.SetValues(range, tooltip);
    }

    public XLHyperlink(Uri uri)
    {
      this.SetValues(uri, string.Empty);
    }

    public XLHyperlink(Uri uri, string tooltip)
    {
      this.SetValues(uri, tooltip);
    }

    public bool IsExternal { get; set; }

    public Uri ExternalAddress
    {
      get
      {
        if (!this.IsExternal)
          return (Uri) null;
        return this._externalAddress;
      }
      set
      {
        this._externalAddress = value;
        this.IsExternal = true;
      }
    }

    public IXLCell Cell { get; internal set; }

    public string InternalAddress
    {
      get
      {
        if (this.IsExternal)
          return (string) null;
        if (!this._internalAddress.Contains<char>('!'))
          return string.Format("'{0}'!{1}", (object) this.Worksheet.Name, (object) this._internalAddress);
        if ((int) this._internalAddress[0] == 39)
          return this._internalAddress;
        return string.Format("'{0}'!{1}", (object) this._internalAddress.Substring(0, this._internalAddress.IndexOf('!')), (object) this._internalAddress.Substring(this._internalAddress.IndexOf('!') + 1));
      }
      set
      {
        this._internalAddress = value;
        this.IsExternal = false;
      }
    }

    public string Tooltip { get; set; }

    public void Delete()
    {
      if (this.Cell == null)
        return;
      this.Worksheet.Hyperlinks.Delete(this.Cell.Address);
      if (this.Cell.Style.Font.FontColor.Equals(XLColor.FromTheme(XLThemeColor.Hyperlink)))
        this.Cell.Style.Font.FontColor = this.Worksheet.Style.Font.FontColor;
      this.Cell.Style.Font.Underline = this.Worksheet.Style.Font.Underline;
    }
  }
}
