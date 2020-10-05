// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.PivotCaches
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotCaches : OpenXmlPivotCachesElement
  {
    private const string tagName = "pivotCaches";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13358;

    public override string LocalName
    {
      get
      {
        return "pivotCaches";
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
        return 13358;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public PivotCaches()
    {
    }

    public PivotCaches(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotCaches(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotCaches(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotCaches>(deep);
    }
  }
}
