// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.OleItems
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.OleItem), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OleItem))]
  public class OleItems : OpenXmlCompositeElement
  {
    private const string tagName = "oleItems";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11341;

    public override string LocalName
    {
      get
      {
        return "oleItems";
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
        return 11341;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public OleItems()
    {
    }

    public OleItems(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OleItems(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OleItems(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "oleItem" == name)
        return (OpenXmlElement) new OleItem();
      if (53 == (int) namespaceId && "oleItem" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.OleItem();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OleItems>(deep);
    }
  }
}
