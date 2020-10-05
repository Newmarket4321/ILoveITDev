// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCustomProperty
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLCustomProperty : IXLCustomProperty
  {
    private readonly XLWorkbook _workbook;
    private string name;

    public XLCustomProperty(XLWorkbook workbook)
    {
      this._workbook = workbook;
    }

    public string Name
    {
      get
      {
        return this.name;
      }
      set
      {
        if (this._workbook.CustomProperties.Any<IXLCustomProperty>((Func<IXLCustomProperty, bool>) (t => t.Name == value)))
          throw new ArgumentException(string.Format("This workbook already contains a custom property named '{0}'", (object) value));
        this.name = value;
      }
    }

    public XLCustomPropertyType Type
    {
      get
      {
        if (this.Value is DateTime)
          return XLCustomPropertyType.Date;
        if (this.Value is bool)
          return XLCustomPropertyType.Boolean;
        double result;
        return double.TryParse(this.Value.ToString(), out result) ? XLCustomPropertyType.Number : XLCustomPropertyType.Text;
      }
    }

    public object Value { get; set; }

    public T GetValue<T>()
    {
      return (T) Convert.ChangeType(this.Value, typeof (T));
    }
  }
}
