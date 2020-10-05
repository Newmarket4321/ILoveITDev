// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GridColumn))]
  public class PreviousTableGrid : OpenXmlCompositeElement
  {
    private const string tagName = "tblGrid";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12080;

    public override string LocalName
    {
      get
      {
        return "tblGrid";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12080;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PreviousTableGrid()
    {
    }

    public PreviousTableGrid(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PreviousTableGrid(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PreviousTableGrid(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "gridCol" == name)
        return (OpenXmlElement) new GridColumn();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PreviousTableGrid>(deep);
    }
  }
}
