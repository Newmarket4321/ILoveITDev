// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.PivotTableReferences
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotTableReference), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotTableReferences : OpenXmlCompositeElement
  {
    private const string tagName = "pivotTableReferences";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13359;

    public override string LocalName
    {
      get
      {
        return "pivotTableReferences";
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
        return 13359;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public PivotTableReferences()
    {
    }

    public PivotTableReferences(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotTableReferences(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotTableReferences(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "pivotTableReference" == name)
        return (OpenXmlElement) new PivotTableReference();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotTableReferences>(deep);
    }
  }
}
