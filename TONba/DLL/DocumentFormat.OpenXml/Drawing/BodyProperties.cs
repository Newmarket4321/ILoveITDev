// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.BodyProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Scene3DType))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PresetTextWrap))]
  [ChildElementInfo(typeof (NoAutoFit))]
  [ChildElementInfo(typeof (NormalAutoFit))]
  [ChildElementInfo(typeof (ShapeAutoFit))]
  [ChildElementInfo(typeof (Shape3DType))]
  [ChildElementInfo(typeof (FlatText))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class BodyProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[19]
    {
      "rot",
      "spcFirstLastPara",
      "vertOverflow",
      "horzOverflow",
      "vert",
      "wrap",
      "lIns",
      "tIns",
      "rIns",
      "bIns",
      "numCol",
      "spcCol",
      "rtlCol",
      "fromWordArt",
      "anchor",
      "anchorCtr",
      "forceAA",
      "upright",
      "compatLnSpc"
    };
    private static byte[] attributeNamespaceIds = new byte[19];
    private static readonly string[] eleTagNames = new string[8]
    {
      "prstTxWarp",
      "noAutofit",
      "normAutofit",
      "spAutoFit",
      "scene3d",
      "sp3d",
      "flatTx",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "bodyPr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10237;

    public override string LocalName
    {
      get
      {
        return "bodyPr";
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
        return 10237;
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
        return BodyProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BodyProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
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

    [SchemaAttr(0, "spcFirstLastPara")]
    public BooleanValue UseParagraphSpacing
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

    [SchemaAttr(0, "vertOverflow")]
    public EnumValue<TextVerticalOverflowValues> VerticalOverflow
    {
      get
      {
        return (EnumValue<TextVerticalOverflowValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "horzOverflow")]
    public EnumValue<TextHorizontalOverflowValues> HorizontalOverflow
    {
      get
      {
        return (EnumValue<TextHorizontalOverflowValues>) this.Attributes[3];
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

    [SchemaAttr(0, "wrap")]
    public EnumValue<TextWrappingValues> Wrap
    {
      get
      {
        return (EnumValue<TextWrappingValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lIns")]
    public Int32Value LeftInset
    {
      get
      {
        return (Int32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tIns")]
    public Int32Value TopInset
    {
      get
      {
        return (Int32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rIns")]
    public Int32Value RightInset
    {
      get
      {
        return (Int32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bIns")]
    public Int32Value BottomInset
    {
      get
      {
        return (Int32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "numCol")]
    public Int32Value ColumnCount
    {
      get
      {
        return (Int32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "spcCol")]
    public Int32Value ColumnSpacing
    {
      get
      {
        return (Int32Value) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rtlCol")]
    public BooleanValue RightToLeftColumns
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fromWordArt")]
    public BooleanValue FromWordArt
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "anchor")]
    public EnumValue<TextAnchoringTypeValues> Anchor
    {
      get
      {
        return (EnumValue<TextAnchoringTypeValues>) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "anchorCtr")]
    public BooleanValue AnchorCenter
    {
      get
      {
        return (BooleanValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "forceAA")]
    public BooleanValue ForceAntiAlias
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "upright")]
    public BooleanValue UpRight
    {
      get
      {
        return (BooleanValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "compatLnSpc")]
    public BooleanValue CompatibleLineSpacing
    {
      get
      {
        return (BooleanValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    public BodyProperties()
    {
    }

    public BodyProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BodyProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BodyProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "prstTxWarp" == name)
        return (OpenXmlElement) new PresetTextWrap();
      if (10 == (int) namespaceId && "noAutofit" == name)
        return (OpenXmlElement) new NoAutoFit();
      if (10 == (int) namespaceId && "normAutofit" == name)
        return (OpenXmlElement) new NormalAutoFit();
      if (10 == (int) namespaceId && "spAutoFit" == name)
        return (OpenXmlElement) new ShapeAutoFit();
      if (10 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3DType();
      if (10 == (int) namespaceId && "sp3d" == name)
        return (OpenXmlElement) new Shape3DType();
      if (10 == (int) namespaceId && "flatTx" == name)
        return (OpenXmlElement) new FlatText();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BodyProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BodyProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PresetTextWrap PresetTextWrap
    {
      get
      {
        return this.GetElement<PresetTextWrap>(0);
      }
      set
      {
        this.SetElement<PresetTextWrap>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rot" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "spcFirstLastPara" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "vertOverflow" == name)
        return (OpenXmlSimpleType) new EnumValue<TextVerticalOverflowValues>();
      if ((int) namespaceId == 0 && "horzOverflow" == name)
        return (OpenXmlSimpleType) new EnumValue<TextHorizontalOverflowValues>();
      if ((int) namespaceId == 0 && "vert" == name)
        return (OpenXmlSimpleType) new EnumValue<TextVerticalValues>();
      if ((int) namespaceId == 0 && "wrap" == name)
        return (OpenXmlSimpleType) new EnumValue<TextWrappingValues>();
      if ((int) namespaceId == 0 && "lIns" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "tIns" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "rIns" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "bIns" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "numCol" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "spcCol" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "rtlCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fromWordArt" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "anchor" == name)
        return (OpenXmlSimpleType) new EnumValue<TextAnchoringTypeValues>();
      if ((int) namespaceId == 0 && "anchorCtr" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "forceAA" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "upright" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "compatLnSpc" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BodyProperties>(deep);
    }
  }
}
