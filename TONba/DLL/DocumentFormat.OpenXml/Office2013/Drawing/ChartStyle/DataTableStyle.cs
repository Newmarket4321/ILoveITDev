// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class DataTableStyle : StyleEntry
  {
    private const string tagName = "dataTable";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13290;

    public override string LocalName
    {
      get
      {
        return "dataTable";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13290;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public DataTableStyle()
    {
    }

    public DataTableStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataTableStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataTableStyle(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataTableStyle>(deep);
    }
  }
}
