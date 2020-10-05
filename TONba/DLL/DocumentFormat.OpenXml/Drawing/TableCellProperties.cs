// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableCellProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Cell3DProperties))]
  [ChildElementInfo(typeof (LeftBorderLineProperties))]
  [ChildElementInfo(typeof (RightBorderLineProperties))]
  [ChildElementInfo(typeof (TopBorderLineProperties))]
  [ChildElementInfo(typeof (BottomBorderLineProperties))]
  [ChildElementInfo(typeof (TopLeftToBottomRightBorderLineProperties))]
  [ChildElementInfo(typeof (BottomLeftToTopRightBorderLineProperties))]
  [ChildElementInfo(typeof (PatternFill))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (BlipFill))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GroupFill))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class TableCellProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "marL",
      "marR",
      "marT",
      "marB",
      "vert",
      "anchor",
      "anchorCtr",
      "horzOverflow"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private static readonly string[] eleTagNames = new string[14]
    {
      "lnL",
      "lnR",
      "lnT",
      "lnB",
      "lnTlToBr",
      "lnBlToTr",
      "cell3D",
      "noFill",
      "solidFill",
      "gradFill",
      "blipFill",
      "pattFill",
      "grpFill",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[14]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
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
    private const string tagName = "tcPr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10254;

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
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10254;
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
        return TableCellProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableCellProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "marL")]
    public Int32Value LeftMargin
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "marR")]
    public Int32Value RightMargin
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "marT")]
    public Int32Value TopMargin
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "marB")]
    public Int32Value BottomMargin
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "vert")]
    public EnumValue<TextVerticalValues> Vertical
    {
      get
      {
        return (EnumValue<TextVerticalValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "anchor")]
    public EnumValue<TextAnchoringTypeValues> Anchor
    {
      get
      {
        return (EnumValue<TextAnchoringTypeValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "anchorCtr")]
    public BooleanValue AnchorCenter
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "horzOverflow")]
    public EnumValue<TextHorizontalOverflowValues> HorizontalOverflow
    {
      get
      {
        return (EnumValue<TextHorizontalOverflowValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    public TableCellProperties()
    {
    }

    public TableCellProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCellProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCellProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "lnL" == name)
        return (OpenXmlElement) new LeftBorderLineProperties();
      if (10 == (int) namespaceId && "lnR" == name)
        return (OpenXmlElement) new RightBorderLineProperties();
      if (10 == (int) namespaceId && "lnT" == name)
        return (OpenXmlElement) new TopBorderLineProperties();
      if (10 == (int) namespaceId && "lnB" == name)
        return (OpenXmlElement) new BottomBorderLineProperties();
      if (10 == (int) namespaceId && "lnTlToBr" == name)
        return (OpenXmlElement) new TopLeftToBottomRightBorderLineProperties();
      if (10 == (int) namespaceId && "lnBlToTr" == name)
        return (OpenXmlElement) new BottomLeftToTopRightBorderLineProperties();
      if (10 == (int) namespaceId && "cell3D" == name)
        return (OpenXmlElement) new Cell3DProperties();
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "grpFill" == name)
        return (OpenXmlElement) new GroupFill();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableCellProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableCellProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LeftBorderLineProperties LeftBorderLineProperties
    {
      get
      {
        return this.GetElement<LeftBorderLineProperties>(0);
      }
      set
      {
        this.SetElement<LeftBorderLineProperties>(0, value);
      }
    }

    public RightBorderLineProperties RightBorderLineProperties
    {
      get
      {
        return this.GetElement<RightBorderLineProperties>(1);
      }
      set
      {
        this.SetElement<RightBorderLineProperties>(1, value);
      }
    }

    public TopBorderLineProperties TopBorderLineProperties
    {
      get
      {
        return this.GetElement<TopBorderLineProperties>(2);
      }
      set
      {
        this.SetElement<TopBorderLineProperties>(2, value);
      }
    }

    public BottomBorderLineProperties BottomBorderLineProperties
    {
      get
      {
        return this.GetElement<BottomBorderLineProperties>(3);
      }
      set
      {
        this.SetElement<BottomBorderLineProperties>(3, value);
      }
    }

    public TopLeftToBottomRightBorderLineProperties TopLeftToBottomRightBorderLineProperties
    {
      get
      {
        return this.GetElement<TopLeftToBottomRightBorderLineProperties>(4);
      }
      set
      {
        this.SetElement<TopLeftToBottomRightBorderLineProperties>(4, value);
      }
    }

    public BottomLeftToTopRightBorderLineProperties BottomLeftToTopRightBorderLineProperties
    {
      get
      {
        return this.GetElement<BottomLeftToTopRightBorderLineProperties>(5);
      }
      set
      {
        this.SetElement<BottomLeftToTopRightBorderLineProperties>(5, value);
      }
    }

    public Cell3DProperties Cell3DProperties
    {
      get
      {
        return this.GetElement<Cell3DProperties>(6);
      }
      set
      {
        this.SetElement<Cell3DProperties>(6, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "marL" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "marR" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "marT" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "marB" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "vert" == name)
        return (OpenXmlSimpleType) new EnumValue<TextVerticalValues>();
      if ((int) namespaceId == 0 && "anchor" == name)
        return (OpenXmlSimpleType) new EnumValue<TextAnchoringTypeValues>();
      if ((int) namespaceId == 0 && "anchorCtr" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "horzOverflow" == name)
        return (OpenXmlSimpleType) new EnumValue<TextHorizontalOverflowValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCellProperties>(deep);
    }
  }
}
