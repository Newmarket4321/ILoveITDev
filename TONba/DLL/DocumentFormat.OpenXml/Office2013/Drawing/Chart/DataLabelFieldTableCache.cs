// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class DataLabelFieldTableCache : StringDataType
  {
    private const string tagName = "dlblFieldTableCache";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13254;

    public override string LocalName
    {
      get
      {
        return "dlblFieldTableCache";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13254;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public DataLabelFieldTableCache()
    {
    }

    public DataLabelFieldTableCache(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataLabelFieldTableCache(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataLabelFieldTableCache(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataLabelFieldTableCache>(deep);
    }
  }
}
