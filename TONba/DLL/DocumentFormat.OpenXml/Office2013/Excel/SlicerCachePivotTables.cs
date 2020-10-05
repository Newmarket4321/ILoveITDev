// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.SlicerCachePivotTables
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SlicerCachePivotTable), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SlicerCachePivotTables : OpenXmlCompositeElement
  {
    private const string tagName = "slicerCachePivotTables";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13384;

    public override string LocalName
    {
      get
      {
        return "slicerCachePivotTables";
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
        return 13384;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public SlicerCachePivotTables()
    {
    }

    public SlicerCachePivotTables(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlicerCachePivotTables(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlicerCachePivotTables(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "pivotTable" == name)
        return (OpenXmlElement) new SlicerCachePivotTable();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerCachePivotTables>(deep);
    }
  }
}
