// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Hidden))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CantSplit))]
  [ChildElementInfo(typeof (TableHeader))]
  [ChildElementInfo(typeof (TableCellSpacing))]
  [ChildElementInfo(typeof (TableJustification))]
  public class TableStyleConditionalFormattingTableRowProperties : OpenXmlCompositeElement
  {
    private const string tagName = "trPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11938;

    public override string LocalName
    {
      get
      {
        return "trPr";
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
        return 11938;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableStyleConditionalFormattingTableRowProperties()
    {
    }

    public TableStyleConditionalFormattingTableRowProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableStyleConditionalFormattingTableRowProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableStyleConditionalFormattingTableRowProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "hidden" == name)
        return (OpenXmlElement) new Hidden();
      if (23 == (int) namespaceId && "cantSplit" == name)
        return (OpenXmlElement) new CantSplit();
      if (23 == (int) namespaceId && "tblHeader" == name)
        return (OpenXmlElement) new TableHeader();
      if (23 == (int) namespaceId && "tblCellSpacing" == name)
        return (OpenXmlElement) new TableCellSpacing();
      if (23 == (int) namespaceId && "jc" == name)
        return (OpenXmlElement) new TableJustification();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableStyleConditionalFormattingTableRowProperties>(deep);
    }
  }
}
