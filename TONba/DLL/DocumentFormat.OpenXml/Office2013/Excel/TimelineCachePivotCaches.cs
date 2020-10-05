// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotCaches
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class TimelineCachePivotCaches : OpenXmlPivotCachesElement
  {
    private const string tagName = "timelineCachePivotCaches";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13364;

    public override string LocalName
    {
      get
      {
        return "timelineCachePivotCaches";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13364;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public TimelineCachePivotCaches()
    {
    }

    public TimelineCachePivotCaches(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimelineCachePivotCaches(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimelineCachePivotCaches(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimelineCachePivotCaches>(deep);
    }
  }
}
