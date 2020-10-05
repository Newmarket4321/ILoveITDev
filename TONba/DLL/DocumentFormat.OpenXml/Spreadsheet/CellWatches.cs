// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CellWatches
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (CellWatch))]
  [GeneratedCode("DomGen", "2.0")]
  public class CellWatches : OpenXmlCompositeElement
  {
    private const string tagName = "cellWatches";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11500;

    public override string LocalName
    {
      get
      {
        return "cellWatches";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11500;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CellWatches()
    {
    }

    public CellWatches(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CellWatches(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CellWatches(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "cellWatch" == name)
        return (OpenXmlElement) new CellWatch();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CellWatches>(deep);
    }
  }
}
