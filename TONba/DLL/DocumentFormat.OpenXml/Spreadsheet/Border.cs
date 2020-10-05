// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Border
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (BottomBorder))]
  [ChildElementInfo(typeof (DiagonalBorder))]
  [ChildElementInfo(typeof (VerticalBorder))]
  [ChildElementInfo(typeof (TopBorder))]
  [ChildElementInfo(typeof (RightBorder))]
  [ChildElementInfo(typeof (EndBorder), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (LeftBorder))]
  [ChildElementInfo(typeof (HorizontalBorder))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StartBorder), FileFormatVersions.Office2010)]
  public class Border : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "diagonalUp",
      "diagonalDown",
      "outline"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[9]
    {
      "start",
      "end",
      "left",
      "right",
      "top",
      "bottom",
      "diagonal",
      "vertical",
      "horizontal"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "border";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11319;

    public override string LocalName
    {
      get
      {
        return "border";
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
        return 11319;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Border.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Border.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "diagonalUp")]
    public BooleanValue DiagonalUp
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "diagonalDown")]
    public BooleanValue DiagonalDown
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Border()
    {
    }

    public Border(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Border(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Border(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "start" == name)
        return (OpenXmlElement) new StartBorder();
      if (22 == (int) namespaceId && "end" == name)
        return (OpenXmlElement) new EndBorder();
      if (22 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftBorder();
      if (22 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightBorder();
      if (22 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopBorder();
      if (22 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomBorder();
      if (22 == (int) namespaceId && "diagonal" == name)
        return (OpenXmlElement) new DiagonalBorder();
      if (22 == (int) namespaceId && "vertical" == name)
        return (OpenXmlElement) new VerticalBorder();
      if (22 == (int) namespaceId && "horizontal" == name)
        return (OpenXmlElement) new HorizontalBorder();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Border.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Border.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public StartBorder StartBorder
    {
      get
      {
        return this.GetElement<StartBorder>(0);
      }
      set
      {
        this.SetElement<StartBorder>(0, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public EndBorder EndBorder
    {
      get
      {
        return this.GetElement<EndBorder>(1);
      }
      set
      {
        this.SetElement<EndBorder>(1, value);
      }
    }

    public LeftBorder LeftBorder
    {
      get
      {
        return this.GetElement<LeftBorder>(2);
      }
      set
      {
        this.SetElement<LeftBorder>(2, value);
      }
    }

    public RightBorder RightBorder
    {
      get
      {
        return this.GetElement<RightBorder>(3);
      }
      set
      {
        this.SetElement<RightBorder>(3, value);
      }
    }

    public TopBorder TopBorder
    {
      get
      {
        return this.GetElement<TopBorder>(4);
      }
      set
      {
        this.SetElement<TopBorder>(4, value);
      }
    }

    public BottomBorder BottomBorder
    {
      get
      {
        return this.GetElement<BottomBorder>(5);
      }
      set
      {
        this.SetElement<BottomBorder>(5, value);
      }
    }

    public DiagonalBorder DiagonalBorder
    {
      get
      {
        return this.GetElement<DiagonalBorder>(6);
      }
      set
      {
        this.SetElement<DiagonalBorder>(6, value);
      }
    }

    public VerticalBorder VerticalBorder
    {
      get
      {
        return this.GetElement<VerticalBorder>(7);
      }
      set
      {
        this.SetElement<VerticalBorder>(7, value);
      }
    }

    public HorizontalBorder HorizontalBorder
    {
      get
      {
        return this.GetElement<HorizontalBorder>(8);
      }
      set
      {
        this.SetElement<HorizontalBorder>(8, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "diagonalUp" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "diagonalDown" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "outline" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Border>(deep);
    }
  }
}
