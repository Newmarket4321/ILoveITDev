// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TableCellBorders))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (NoWrap))]
  [ChildElementInfo(typeof (TableCellMargin))]
  [ChildElementInfo(typeof (TableCellVerticalAlignment))]
  public class TableStyleConditionalFormattingTableCellProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "tcBorders",
      "shd",
      "noWrap",
      "tcMar",
      "vAlign"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tcPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11939;

    public override string LocalName
    {
      get
      {
        return "tcPr";
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
        return 11939;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableStyleConditionalFormattingTableCellProperties()
    {
    }

    public TableStyleConditionalFormattingTableCellProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableStyleConditionalFormattingTableCellProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableStyleConditionalFormattingTableCellProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "tcBorders" == name)
        return (OpenXmlElement) new TableCellBorders();
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "noWrap" == name)
        return (OpenXmlElement) new NoWrap();
      if (23 == (int) namespaceId && "tcMar" == name)
        return (OpenXmlElement) new TableCellMargin();
      if (23 == (int) namespaceId && "vAlign" == name)
        return (OpenXmlElement) new TableCellVerticalAlignment();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableStyleConditionalFormattingTableCellProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableStyleConditionalFormattingTableCellProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableCellBorders TableCellBorders
    {
      get
      {
        return this.GetElement<TableCellBorders>(0);
      }
      set
      {
        this.SetElement<TableCellBorders>(0, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(1);
      }
      set
      {
        this.SetElement<Shading>(1, value);
      }
    }

    public NoWrap NoWrap
    {
      get
      {
        return this.GetElement<NoWrap>(2);
      }
      set
      {
        this.SetElement<NoWrap>(2, value);
      }
    }

    public TableCellMargin TableCellMargin
    {
      get
      {
        return this.GetElement<TableCellMargin>(3);
      }
      set
      {
        this.SetElement<TableCellMargin>(3, value);
      }
    }

    public TableCellVerticalAlignment TableCellVerticalAlignment
    {
      get
      {
        return this.GetElement<TableCellVerticalAlignment>(4);
      }
      set
      {
        this.SetElement<TableCellVerticalAlignment>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableStyleConditionalFormattingTableCellProperties>(deep);
    }
  }
}
