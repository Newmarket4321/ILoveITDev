// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TextParagraphPropertiesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (BulletSizePoints))]
  [ChildElementInfo(typeof (BulletFont))]
  [ChildElementInfo(typeof (BulletFontText))]
  [ChildElementInfo(typeof (BulletSizePercentage))]
  [ChildElementInfo(typeof (LineSpacing))]
  [ChildElementInfo(typeof (SpaceBefore))]
  [ChildElementInfo(typeof (SpaceAfter))]
  [ChildElementInfo(typeof (BulletColorText))]
  [ChildElementInfo(typeof (BulletColor))]
  [ChildElementInfo(typeof (BulletSizeText))]
  [ChildElementInfo(typeof (PictureBullet))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AutoNumberedBullet))]
  [ChildElementInfo(typeof (CharacterBullet))]
  [ChildElementInfo(typeof (NoBullet))]
  [ChildElementInfo(typeof (TabStopList))]
  [ChildElementInfo(typeof (DefaultRunProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  public abstract class TextParagraphPropertiesType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[11]
    {
      "marL",
      "marR",
      "lvl",
      "indent",
      "algn",
      "defTabSz",
      "rtl",
      "eaLnBrk",
      "fontAlgn",
      "latinLnBrk",
      "hangingPunct"
    };
    private static byte[] attributeNamespaceIds = new byte[11];
    private static readonly string[] eleTagNames = new string[17]
    {
      "lnSpc",
      "spcBef",
      "spcAft",
      "buClrTx",
      "buClr",
      "buSzTx",
      "buSzPct",
      "buSzPts",
      "buFontTx",
      "buFont",
      "buNone",
      "buAutoNum",
      "buChar",
      "buBlip",
      "tabLst",
      "defRPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[17]
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
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return TextParagraphPropertiesType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextParagraphPropertiesType.attributeNamespaceIds;
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

    [SchemaAttr(0, "lvl")]
    public Int32Value Level
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

    [SchemaAttr(0, "indent")]
    public Int32Value Indent
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

    [SchemaAttr(0, "algn")]
    public EnumValue<TextAlignmentTypeValues> Alignment
    {
      get
      {
        return (EnumValue<TextAlignmentTypeValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "defTabSz")]
    public Int32Value DefaultTabSize
    {
      get
      {
        return (Int32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rtl")]
    public BooleanValue RightToLeft
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

    [SchemaAttr(0, "eaLnBrk")]
    public BooleanValue EastAsianLineBreak
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fontAlgn")]
    public EnumValue<TextFontAlignmentValues> FontAlignment
    {
      get
      {
        return (EnumValue<TextFontAlignmentValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "latinLnBrk")]
    public BooleanValue LatinLineBreak
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hangingPunct")]
    public BooleanValue Height
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "lnSpc" == name)
        return (OpenXmlElement) new LineSpacing();
      if (10 == (int) namespaceId && "spcBef" == name)
        return (OpenXmlElement) new SpaceBefore();
      if (10 == (int) namespaceId && "spcAft" == name)
        return (OpenXmlElement) new SpaceAfter();
      if (10 == (int) namespaceId && "buClrTx" == name)
        return (OpenXmlElement) new BulletColorText();
      if (10 == (int) namespaceId && "buClr" == name)
        return (OpenXmlElement) new BulletColor();
      if (10 == (int) namespaceId && "buSzTx" == name)
        return (OpenXmlElement) new BulletSizeText();
      if (10 == (int) namespaceId && "buSzPct" == name)
        return (OpenXmlElement) new BulletSizePercentage();
      if (10 == (int) namespaceId && "buSzPts" == name)
        return (OpenXmlElement) new BulletSizePoints();
      if (10 == (int) namespaceId && "buFontTx" == name)
        return (OpenXmlElement) new BulletFontText();
      if (10 == (int) namespaceId && "buFont" == name)
        return (OpenXmlElement) new BulletFont();
      if (10 == (int) namespaceId && "buNone" == name)
        return (OpenXmlElement) new NoBullet();
      if (10 == (int) namespaceId && "buAutoNum" == name)
        return (OpenXmlElement) new AutoNumberedBullet();
      if (10 == (int) namespaceId && "buChar" == name)
        return (OpenXmlElement) new CharacterBullet();
      if (10 == (int) namespaceId && "buBlip" == name)
        return (OpenXmlElement) new PictureBullet();
      if (10 == (int) namespaceId && "tabLst" == name)
        return (OpenXmlElement) new TabStopList();
      if (10 == (int) namespaceId && "defRPr" == name)
        return (OpenXmlElement) new DefaultRunProperties();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextParagraphPropertiesType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextParagraphPropertiesType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LineSpacing LineSpacing
    {
      get
      {
        return this.GetElement<LineSpacing>(0);
      }
      set
      {
        this.SetElement<LineSpacing>(0, value);
      }
    }

    public SpaceBefore SpaceBefore
    {
      get
      {
        return this.GetElement<SpaceBefore>(1);
      }
      set
      {
        this.SetElement<SpaceBefore>(1, value);
      }
    }

    public SpaceAfter SpaceAfter
    {
      get
      {
        return this.GetElement<SpaceAfter>(2);
      }
      set
      {
        this.SetElement<SpaceAfter>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "marL" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "marR" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "lvl" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "indent" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<TextAlignmentTypeValues>();
      if ((int) namespaceId == 0 && "defTabSz" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "rtl" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "eaLnBrk" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fontAlgn" == name)
        return (OpenXmlSimpleType) new EnumValue<TextFontAlignmentValues>();
      if ((int) namespaceId == 0 && "latinLnBrk" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hangingPunct" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected TextParagraphPropertiesType()
    {
    }

    protected TextParagraphPropertiesType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TextParagraphPropertiesType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TextParagraphPropertiesType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
