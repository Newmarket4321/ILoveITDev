// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TableWidth))]
  [ChildElementInfo(typeof (TableJustification))]
  [ChildElementInfo(typeof (TableCellSpacing))]
  [ChildElementInfo(typeof (TableIndentation))]
  [ChildElementInfo(typeof (TableBorders))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (TableLayout))]
  [ChildElementInfo(typeof (TableCellMarginDefault))]
  [ChildElementInfo(typeof (TableLook))]
  [ChildElementInfo(typeof (TablePropertyExceptionsChange))]
  public class TablePropertyExceptions : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[10]
    {
      "tblW",
      "jc",
      "tblCellSpacing",
      "tblInd",
      "tblBorders",
      "shd",
      "tblLayout",
      "tblCellMar",
      "tblLook",
      "tblPrExChange"
    };
    private static readonly byte[] eleNamespaceIds = new byte[10]
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
      (byte) 23
    };
    private const string tagName = "tblPrEx";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12070;

    public override string LocalName
    {
      get
      {
        return "tblPrEx";
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
        return 12070;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TablePropertyExceptions()
    {
    }

    public TablePropertyExceptions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TablePropertyExceptions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TablePropertyExceptions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
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
      if (23 == (int) namespaceId && "tblPrExChange" == name)
        return (OpenXmlElement) new TablePropertyExceptionsChange();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TablePropertyExceptions.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TablePropertyExceptions.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableWidth TableWidth
    {
      get
      {
        return this.GetElement<TableWidth>(0);
      }
      set
      {
        this.SetElement<TableWidth>(0, value);
      }
    }

    public TableJustification TableJustification
    {
      get
      {
        return this.GetElement<TableJustification>(1);
      }
      set
      {
        this.SetElement<TableJustification>(1, value);
      }
    }

    public TableCellSpacing TableCellSpacing
    {
      get
      {
        return this.GetElement<TableCellSpacing>(2);
      }
      set
      {
        this.SetElement<TableCellSpacing>(2, value);
      }
    }

    public TableIndentation TableIndentation
    {
      get
      {
        return this.GetElement<TableIndentation>(3);
      }
      set
      {
        this.SetElement<TableIndentation>(3, value);
      }
    }

    public TableBorders TableBorders
    {
      get
      {
        return this.GetElement<TableBorders>(4);
      }
      set
      {
        this.SetElement<TableBorders>(4, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(5);
      }
      set
      {
        this.SetElement<Shading>(5, value);
      }
    }

    public TableLayout TableLayout
    {
      get
      {
        return this.GetElement<TableLayout>(6);
      }
      set
      {
        this.SetElement<TableLayout>(6, value);
      }
    }

    public TableCellMarginDefault TableCellMarginDefault
    {
      get
      {
        return this.GetElement<TableCellMarginDefault>(7);
      }
      set
      {
        this.SetElement<TableCellMarginDefault>(7, value);
      }
    }

    public TableLook TableLook
    {
      get
      {
        return this.GetElement<TableLook>(8);
      }
      set
      {
        this.SetElement<TableLook>(8, value);
      }
    }

    public TablePropertyExceptionsChange TablePropertyExceptionsChange
    {
      get
      {
        return this.GetElement<TablePropertyExceptionsChange>(9);
      }
      set
      {
        this.SetElement<TablePropertyExceptionsChange>(9, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TablePropertyExceptions>(deep);
    }
  }
}
