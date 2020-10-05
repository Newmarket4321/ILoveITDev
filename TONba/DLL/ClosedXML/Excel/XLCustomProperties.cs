// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCustomProperties
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLCustomProperties : IXLCustomProperties, IEnumerable<IXLCustomProperty>, IEnumerable
  {
    private Dictionary<string, IXLCustomProperty> customProperties = new Dictionary<string, IXLCustomProperty>();
    private XLWorkbook workbook;

    public XLCustomProperties(XLWorkbook workbook)
    {
      this.workbook = workbook;
    }

    public void Add(IXLCustomProperty customProperty)
    {
      this.customProperties.Add(customProperty.Name, customProperty);
    }

    public void Add<T>(string name, T value)
    {
      this.Add((IXLCustomProperty) new XLCustomProperty(this.workbook)
      {
        Name = name,
        Value = (object) value
      });
    }

    public void Delete(string name)
    {
      this.customProperties.Remove(name);
    }

    public IXLCustomProperty CustomProperty(string name)
    {
      return this.customProperties[name];
    }

    public IEnumerator<IXLCustomProperty> GetEnumerator()
    {
      return (IEnumerator<IXLCustomProperty>) this.customProperties.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}
