// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TableJustification))]
  [ChildElementInfo(typeof (TableCellMarginDefault))]
  [ChildElementInfo(typeof (TableCellSpacing))]
  [ChildElementInfo(typeof (TableIndentation))]
  [ChildElementInfo(typeof (TableBorders))]
  [ChildElementInfo(typeof (Shading))]
  [GeneratedCode("DomGen", "2.0")]
  public class TableStyleConditionalFormattingTableProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "jc",
      "tblCellSpacing",
      "tblInd",
      "tblBorders",
      "shd",
      "tblCellMar"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tblPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11937;

    public override string LocalName
    {
      get
      {
        return "tblPr";
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
        return 11937;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableStyleConditionalFormattingTableProperties()
    {
    }

    public TableStyleConditionalFormattingTableProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableStyleConditionalFormattingTableProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableStyleConditionalFormattingTableProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "jc" == name)
        return (OpenXmlElement) new TableJustification();
      if (23 == (int) namespaceId && "tblCellSpacing" == name)
        return (OpenXmlElement) new TableCellSpacing();
      if (23 == (int) namespaceId && "tblInd" == name)
        return (OpenXmlElement) new TableIndentation();
      if (23 == (int) namespaceId && "tblBorders" == name)
        return (OpenXmlElement) new TableBorders();
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "tblCellMar" == name)
        return (OpenXmlElement) new TableCellMarginDefault();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableStyleConditionalFormattingTableProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableStyleConditionalFormattingTableProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableJustification TableJustification
    {
      get
      {
        return this.GetElement<TableJustification>(0);
      }
      set
      {
        this.SetElement<TableJustification>(0, value);
      }
    }

    public TableCellSpacing TableCellSpacing
    {
      get
      {
        return this.GetElement<TableCellSpacing>(1);
      }
      set
      {
        this.SetElement<TableCellSpacing>(1, value);
      }
    }

    public TableIndentation TableIndentation
    {
      get
      {
        return this.GetElement<TableIndentation>(2);
      }
      set
      {
        this.SetElement<TableIndentation>(2, value);
      }
    }

    public TableBorders TableBorders
    {
      get
      {
        return this.GetElement<TableBorders>(3);
      }
      set
      {
        this.SetElement<TableBorders>(3, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(4);
      }
      set
      {
        this.SetElement<Shading>(4, value);
      }
    }

    public TableCellMarginDefault TableCellMarginDefault
    {
      get
      {
        return this.GetElement<TableCellMarginDefault>(5);
      }
      set
      {
        this.SetElement<TableCellMarginDefault>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableStyleConditionalFormattingTableProperties>(deep);
    }
  }
}
