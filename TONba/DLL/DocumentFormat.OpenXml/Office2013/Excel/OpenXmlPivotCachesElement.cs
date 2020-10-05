// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.OpenXmlPivotCachesElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (PivotCache))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class OpenXmlPivotCachesElement : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "pivotCache" == name)
        return (OpenXmlElement) new PivotCache();
      return (OpenXmlElement) null;
    }

    protected OpenXmlPivotCachesElement()
    {
    }

    protected OpenXmlPivotCachesElement(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected OpenXmlPivotCachesElement(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected OpenXmlPivotCachesElement(string outerXml)
      : base(outerXml)
    {
    }
  }
}
