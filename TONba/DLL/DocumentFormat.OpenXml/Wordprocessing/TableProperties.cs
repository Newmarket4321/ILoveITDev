// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TableBorders))]
  [ChildElementInfo(typeof (TableLayout))]
  [ChildElementInfo(typeof (TableCellMarginDefault))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (TableStyle))]
  [ChildElementInfo(typeof (TablePositionProperties))]
  [ChildElementInfo(typeof (TableOverlap))]
  [ChildElementInfo(typeof (BiDiVisual))]
  [ChildElementInfo(typeof (TableWidth))]
  [ChildElementInfo(typeof (TableJustification))]
  [ChildElementInfo(typeof (TableCellSpacing))]
  [ChildElementInfo(typeof (TableIndentation))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TableLook))]
  [ChildElementInfo(typeof (TableCaption), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (TableDescription), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (TablePropertiesChange))]
  public class TableProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      "tblStyle",
      "tblpPr",
      "tblOverlap",
      "bidiVisual",
      "tblW",
      "jc",
      "tblCellSpacing",
      "tblInd",
      "tblBorders",
      "shd",
      "tblLayout",
      "tblCellMar",
      "tblLook",
      "tblCaption",
      "tblDescription",
      "tblPrChange"
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
    private const string tagName = "tblPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11850;

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
        return 11850;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableProperties()
    {
    }

    public TableProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "tblStyle" == name)
        return (OpenXmlElement) new TableStyle();
      if (23 == (int) namespaceId && "tblpPr" == name)
        return (OpenXmlElement) new TablePositionProperties();
      if (23 == (int) namespaceId && "tblOverlap" == name)
        return (OpenXmlElement) new TableOverlap();
      if (23 == (int) namespaceId && "bidiVisual" == name)
        return (OpenXmlElement) new BiDiVisual();
      if (23 == (int) namespaceId && "tblW" == name)
        return (OpenXmlElement) new TableWidth();
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
      if (23 == (int) namespaceId && "tblLayout" == name)
        return (OpenXmlElement) new TableLayout();
      if (23 == (int) namespaceId && "tblCellMar" == name)
        return (OpenXmlElement) new TableCellMarginDefault();
      if (23 == (int) namespaceId && "tblLook" == name)
        return (OpenXmlElement) new TableLook();
      if (23 == (int) namespaceId && "tblCaption" == name)
        return (OpenXmlElement) new TableCaption();
      if (23 == (int) namespaceId && "tblDescription" == name)
        return (OpenXmlElement) new TableDescription();
      if (23 == (int) namespaceId && "tblPrChange" == name)
        return (OpenXmlElement) new TablePropertiesChange();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableStyle TableStyle
    {
      get
      {
        return this.GetElement<TableStyle>(0);
      }
      set
      {
        this.SetElement<TableStyle>(0, value);
      }
    }

    public TablePositionProperties TablePositionProperties
    {
      get
      {
        return this.GetElement<TablePositionProperties>(1);
      }
      set
      {
        this.SetElement<TablePositionProperties>(1, value);
      }
    }

    public TableOverlap TableOverlap
    {
      get
      {
        return this.GetElement<TableOverlap>(2);
      }
      set
      {
        this.SetElement<TableOverlap>(2, value);
      }
    }

    public BiDiVisual BiDiVisual
    {
      get
      {
        return this.GetElement<BiDiVisual>(3);
      }
      set
      {
        this.SetElement<BiDiVisual>(3, value);
      }
    }

    public TableWidth TableWidth
    {
      get
      {
        return this.GetElement<TableWidth>(4);
      }
      set
      {
        this.SetElement<TableWidth>(4, value);
      }
    }

    public TableJustification TableJustification
    {
      get
      {
        return this.GetElement<TableJustification>(5);
      }
      set
      {
        this.SetElement<TableJustification>(5, value);
      }
    }

    public TableCellSpacing TableCellSpacing
    {
      get
      {
        return this.GetElement<TableCellSpacing>(6);
      }
      set
      {
        this.SetElement<TableCellSpacing>(6, value);
      }
    }

    public TableIndentation TableIndentation
    {
      get
      {
        return this.GetElement<TableIndentation>(7);
      }
      set
      {
        this.SetElement<TableIndentation>(7, value);
      }
    }

    public TableBorders TableBorders
    {
      get
      {
        return this.GetElement<TableBorders>(8);
      }
      set
      {
        this.SetElement<TableBorders>(8, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(9);
      }
      set
      {
        this.SetElement<Shading>(9, value);
      }
    }

    public TableLayout TableLayout
    {
      get
      {
        return this.GetElement<TableLayout>(10);
      }
      set
      {
        this.SetElement<TableLayout>(10, value);
      }
    }

    public TableCellMarginDefault TableCellMarginDefault
    {
      get
      {
        return this.GetElement<TableCellMarginDefault>(11);
      }
      set
      {
        this.SetElement<TableCellMarginDefault>(11, value);
      }
    }

    public TableLook TableLook
    {
      get
      {
        return this.GetElement<TableLook>(12);
      }
      set
      {
        this.SetElement<TableLook>(12, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public TableCaption TableCaption
    {
      get
      {
        return this.GetElement<TableCaption>(13);
      }
      set
      {
        this.SetElement<TableCaption>(13, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public TableDescription TableDescription
    {
      get
      {
        return this.GetElement<TableDescription>(14);
      }
      set
      {
        this.SetElement<TableDescription>(14, value);
      }
    }

    public TablePropertiesChange TablePropertiesChange
    {
      get
      {
        return this.GetElement<TablePropertiesChange>(15);
      }
      set
      {
        this.SetElement<TablePropertiesChange>(15, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableProperties>(deep);
    }
  }
}
