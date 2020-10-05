// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.PivotEdits
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PivotEdit), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class PivotEdits : OpenXmlCompositeElement
  {
    private const string tagName = "pivotEdits";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13037;

    public override string LocalName
    {
      get
      {
        return "pivotEdits";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13037;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotEdits()
    {
    }

    public PivotEdits(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotEdits(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotEdits(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "pivotEdit" == name)
        return (OpenXmlElement) new PivotEdit();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotEdits>(deep);
    }
  }
}
