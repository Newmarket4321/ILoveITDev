// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (GridSpan))]
  [ChildElementInfo(typeof (ConditionalFormatStyle))]
  [ChildElementInfo(typeof (TableCellWidth))]
  [ChildElementInfo(typeof (TextDirection))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (VerticalMerge))]
  [ChildElementInfo(typeof (TableCellBorders))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (NoWrap))]
  [ChildElementInfo(typeof (TableCellMargin))]
  [ChildElementInfo(typeof (HorizontalMerge))]
  [ChildElementInfo(typeof (TableCellFitText))]
  [ChildElementInfo(typeof (TableCellVerticalAlignment))]
  [ChildElementInfo(typeof (HideMark))]
  [ChildElementInfo(typeof (CellInsertion))]
  [ChildElementInfo(typeof (CellDeletion))]
  [ChildElementInfo(typeof (CellMerge))]
  public class PreviousTableCellProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      "cnfStyle",
      "tcW",
      "gridSpan",
      "hMerge",
      "vMerge",
      "tcBorders",
      "shd",
      "noWrap",
      "tcMar",
      "textDirection",
      "tcFitText",
      "vAlign",
      "hideMark",
      "cellIns",
      "cellDel",
      "cellMerge"
    };
    private static readonly byte[] eleNamespaceIds = new byte[16]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tcPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11768;

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
        return 11768;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PreviousTableCellProperties()
    {
    }

    public PreviousTableCellProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PreviousTableCellProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PreviousTableCellProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "cnfStyle" == name)
        return (OpenXmlElement) new ConditionalFormatStyle();
      if (23 == (int) namespaceId && "tcW" == name)
        return (OpenXmlElement) new TableCellWidth();
      if (23 == (int) namespaceId && "gridSpan" == name)
        return (OpenXmlElement) new GridSpan();
      if (23 == (int) namespaceId && "hMerge" == name)
        return (OpenXmlElement) new HorizontalMerge();
      if (23 == (int) namespaceId && "vMerge" == name)
        return (OpenXmlElement) new VerticalMerge();
      if (23 == (int) namespaceId && "tcBorders" == name)
        return (OpenXmlElement) new TableCellBorders();
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "noWrap" == name)
        return (OpenXmlElement) new NoWrap();
      if (23 == (int) namespaceId && "tcMar" == name)
        return (OpenXmlElement) new TableCellMargin();
      if (23 == (int) namespaceId && "textDirection" == name)
        return (OpenXmlElement) new TextDirection();
      if (23 == (int) namespaceId && "tcFitText" == name)
        return (OpenXmlElement) new TableCellFitText();
      if (23 == (int) namespaceId && "vAlign" == name)
        return (OpenXmlElement) new TableCellVerticalAlignment();
      if (23 == (int) namespaceId && "hideMark" == name)
        return (OpenXmlElement) new HideMark();
      if (23 == (int) namespaceId && "cellIns" == name)
        return (OpenXmlElement) new CellInsertion();
      if (23 == (int) namespaceId && "cellDel" == name)
        return (OpenXmlElement) new CellDeletion();
      if (23 == (int) namespaceId && "cellMerge" == name)
        return (OpenXmlElement) new CellMerge();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PreviousTableCellProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PreviousTableCellProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ConditionalFormatStyle ConditionalFormatStyle
    {
      get
      {
        return this.GetElement<ConditionalFormatStyle>(0);
      }
      set
      {
        this.SetElement<ConditionalFormatStyle>(0, value);
      }
    }

    public TableCellWidth TableCellWidth
    {
      get
      {
        return this.GetElement<TableCellWidth>(1);
      }
      set
      {
        this.SetElement<TableCellWidth>(1, value);
      }
    }

    public GridSpan GridSpan
    {
      get
      {
        return this.GetElement<GridSpan>(2);
      }
      set
      {
        this.SetElement<GridSpan>(2, value);
      }
    }

    public HorizontalMerge HorizontalMerge
    {
      get
      {
        return this.GetElement<HorizontalMerge>(3);
      }
      set
      {
        this.SetElement<HorizontalMerge>(3, value);
      }
    }

    public VerticalMerge VerticalMerge
    {
      get
      {
        return this.GetElement<VerticalMerge>(4);
      }
      set
      {
        this.SetElement<VerticalMerge>(4, value);
      }
    }

    public TableCellBorders TableCellBorders
    {
      get
      {
        return this.GetElement<TableCellBorders>(5);
      }
      set
      {
        this.SetElement<TableCellBorders>(5, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(6);
      }
      set
      {
        this.SetElement<Shading>(6, value);
      }
    }

    public NoWrap NoWrap
    {
      get
      {
        return this.GetElement<NoWrap>(7);
      }
      set
      {
        this.SetElement<NoWrap>(7, value);
      }
    }

    public TableCellMargin TableCellMargin
    {
      get
      {
        return this.GetElement<TableCellMargin>(8);
      }
      set
      {
        this.SetElement<TableCellMargin>(8, value);
      }
    }

    public TextDirection TextDirection
    {
      get
      {
        return this.GetElement<TextDirection>(9);
      }
      set
      {
        this.SetElement<TextDirection>(9, value);
      }
    }

    public TableCellFitText TableCellFitText
    {
      get
      {
        return this.GetElement<TableCellFitText>(10);
      }
      set
      {
        this.SetElement<TableCellFitText>(10, value);
      }
    }

    public TableCellVerticalAlignment TableCellVerticalAlignment
    {
      get
      {
        return this.GetElement<TableCellVerticalAlignment>(11);
      }
      set
      {
        this.SetElement<TableCellVerticalAlignment>(11, value);
      }
    }

    public HideMark HideMark
    {
      get
      {
        return this.GetElement<HideMark>(12);
      }
      set
      {
        this.SetElement<HideMark>(12, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PreviousTableCellProperties>(deep);
    }
  }
}
