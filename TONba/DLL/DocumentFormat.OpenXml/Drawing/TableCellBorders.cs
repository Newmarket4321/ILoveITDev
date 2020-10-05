// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableCellBorders
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TopBorder))]
  [ChildElementInfo(typeof (InsideHorizontalBorder))]
  [ChildElementInfo(typeof (LeftBorder))]
  [ChildElementInfo(typeof (RightBorder))]
  [ChildElementInfo(typeof (BottomBorder))]
  [ChildElementInfo(typeof (TopLeftToBottomRightBorder))]
  [ChildElementInfo(typeof (InsideVerticalBorder))]
  [ChildElementInfo(typeof (TopRightToBottomLeftBorder))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class TableCellBorders : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "left",
      "right",
      "top",
      "bottom",
      "insideH",
      "insideV",
      "tl2br",
      "tr2bl",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "tcBdr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10271;

    public override string LocalName
    {
      get
      {
        return "tcBdr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10271;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableCellBorders()
    {
    }

    public TableCellBorders(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCellBorders(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCellBorders(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftBorder();
      if (10 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightBorder();
      if (10 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopBorder();
      if (10 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomBorder();
      if (10 == (int) namespaceId && "insideH" == name)
        return (OpenXmlElement) new InsideHorizontalBorder();
      if (10 == (int) namespaceId && "insideV" == name)
        return (OpenXmlElement) new InsideVerticalBorder();
      if (10 == (int) namespaceId && "tl2br" == name)
        return (OpenXmlElement) new TopLeftToBottomRightBorder();
      if (10 == (int) namespaceId && "tr2bl" == name)
        return (OpenXmlElement) new TopRightToBottomLeftBorder();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableCellBorders.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableCellBorders.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LeftBorder LeftBorder
    {
      get
      {
        return this.GetElement<LeftBorder>(0);
      }
      set
      {
        this.SetElement<LeftBorder>(0, value);
      }
    }

    public RightBorder RightBorder
    {
      get
      {
        return this.GetElement<RightBorder>(1);
      }
      set
      {
        this.SetElement<RightBorder>(1, value);
      }
    }

    public TopBorder TopBorder
    {
      get
      {
        return this.GetElement<TopBorder>(2);
      }
      set
      {
        this.SetElement<TopBorder>(2, value);
      }
    }

    public BottomBorder BottomBorder
    {
      get
      {
        return this.GetElement<BottomBorder>(3);
      }
      set
      {
        this.SetElement<BottomBorder>(3, value);
      }
    }

    public InsideHorizontalBorder InsideHorizontalBorder
    {
      get
      {
        return this.GetElement<InsideHorizontalBorder>(4);
      }
      set
      {
        this.SetElement<InsideHorizontalBorder>(4, value);
      }
    }

    public InsideVerticalBorder InsideVerticalBorder
    {
      get
      {
        return this.GetElement<InsideVerticalBorder>(5);
      }
      set
      {
        this.SetElement<InsideVerticalBorder>(5, value);
      }
    }

    public TopLeftToBottomRightBorder TopLeftToBottomRightBorder
    {
      get
      {
        return this.GetElement<TopLeftToBottomRightBorder>(6);
      }
      set
      {
        this.SetElement<TopLeftToBottomRightBorder>(6, value);
      }
    }

    public TopRightToBottomLeftBorder TopRightToBottomLeftBorder
    {
      get
      {
        return this.GetElement<TopRightToBottomLeftBorder>(7);
      }
      set
      {
        this.SetElement<TopRightToBottomLeftBorder>(7, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(8);
      }
      set
      {
        this.SetElement<ExtensionList>(8, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCellBorders>(deep);
    }
  }
}
