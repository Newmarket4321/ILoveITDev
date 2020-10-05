// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Oval
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Presentation;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [ChildElementInfo(typeof (ClipPath))]
  [ChildElementInfo(typeof (Formulas))]
  [ChildElementInfo(typeof (Fill))]
  [ChildElementInfo(typeof (Stroke))]
  [ChildElementInfo(typeof (Shadow))]
  [ChildElementInfo(typeof (TextBox))]
  [ChildElementInfo(typeof (TextPath))]
  [ChildElementInfo(typeof (ImageData))]
  [ChildElementInfo(typeof (Skew))]
  [ChildElementInfo(typeof (Extrusion))]
  [ChildElementInfo(typeof (Callout))]
  [ChildElementInfo(typeof (Lock))]
  [ChildElementInfo(typeof (Path))]
  [ChildElementInfo(typeof (SignatureLine))]
  [ChildElementInfo(typeof (TextWrap))]
  [ChildElementInfo(typeof (AnchorLock))]
  [ChildElementInfo(typeof (TopBorder))]
  [ChildElementInfo(typeof (BottomBorder))]
  [ChildElementInfo(typeof (LeftBorder))]
  [ChildElementInfo(typeof (RightBorder))]
  [ChildElementInfo(typeof (ClientData))]
  [ChildElementInfo(typeof (TextData))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ShapeHandles))]
  public class Oval : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[51]
    {
      "id",
      "style",
      "href",
      "target",
      "class",
      "title",
      "alt",
      "coordsize",
      "coordorigin",
      "wrapcoords",
      "print",
      "spid",
      "oned",
      "regroupid",
      "doubleclicknotify",
      "button",
      "userhidden",
      "bullet",
      "hr",
      "hrstd",
      "hrnoshade",
      "hrpct",
      "hralign",
      "allowincell",
      "allowoverlap",
      "userdrawn",
      "bordertopcolor",
      "borderleftcolor",
      "borderbottomcolor",
      "borderrightcolor",
      "dgmlayout",
      "dgmnodekind",
      "dgmlayoutmru",
      "insetmode",
      "filled",
      "fillcolor",
      "stroked",
      "strokecolor",
      "strokeweight",
      "insetpen",
      "spt",
      "connectortype",
      "bwmode",
      "bwpure",
      "bwnormal",
      "forcedash",
      "oleicon",
      "ole",
      "preferrelative",
      "cliptowrap",
      "clip"
    };
    private static byte[] attributeNamespaceIds = new byte[51]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "oval";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12594;

    public override string LocalName
    {
      get
      {
        return "oval";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12594;
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
        return Oval.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Oval.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "style")]
    public StringValue Style
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "href")]
    public StringValue Href
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "target")]
    public StringValue Target
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "class")]
    public StringValue Class
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "title")]
    public StringValue Title
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
      get
      {
        return (TrueFalseValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
      get
      {
        return (TrueFalseValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
      get
      {
        return (IntegerValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
      get
      {
        return (TrueFalseValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
      get
      {
        return (TrueFalseValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
      get
      {
        return (TrueFalseValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
      get
      {
        return (TrueFalseValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
      get
      {
        return (TrueFalseValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
      get
      {
        return (TrueFalseValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
      get
      {
        return (TrueFalseValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
      get
      {
        return (SingleValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "hralign")]
    public EnumValue<HorizontalRuleAlignmentValues> HorizontalAlignment
    {
      get
      {
        return (EnumValue<HorizontalRuleAlignmentValues>) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
      get
      {
        return (TrueFalseValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
      get
      {
        return (TrueFalseValue) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
      get
      {
        return (TrueFalseValue) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
      get
      {
        return (StringValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
      get
      {
        return (StringValue) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
      get
      {
        return (StringValue) this.Attributes[28];
      }
      set
      {
        this.Attributes[28] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
      get
      {
        return (StringValue) this.Attributes[29];
      }
      set
      {
        this.Attributes[29] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
      get
      {
        return (IntegerValue) this.Attributes[30];
      }
      set
      {
        this.Attributes[30] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
      get
      {
        return (IntegerValue) this.Attributes[31];
      }
      set
      {
        this.Attributes[31] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
      get
      {
        return (IntegerValue) this.Attributes[32];
      }
      set
      {
        this.Attributes[32] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "insetmode")]
    public EnumValue<InsetMarginValues> InsetMode
    {
      get
      {
        return (EnumValue<InsetMarginValues>) this.Attributes[33];
      }
      set
      {
        this.Attributes[33] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
      get
      {
        return (TrueFalseValue) this.Attributes[34];
      }
      set
      {
        this.Attributes[34] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
      get
      {
        return (StringValue) this.Attributes[35];
      }
      set
      {
        this.Attributes[35] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
      get
      {
        return (TrueFalseValue) this.Attributes[36];
      }
      set
      {
        this.Attributes[36] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
      get
      {
        return (StringValue) this.Attributes[37];
      }
      set
      {
        this.Attributes[37] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
      get
      {
        return (StringValue) this.Attributes[38];
      }
      set
      {
        this.Attributes[38] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
      get
      {
        return (TrueFalseValue) this.Attributes[39];
      }
      set
      {
        this.Attributes[39] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
      get
      {
        return (Int32Value) this.Attributes[40];
      }
      set
      {
        this.Attributes[40] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "connectortype")]
    public EnumValue<ConnectorValues> ConnectorType
    {
      get
      {
        return (EnumValue<ConnectorValues>) this.Attributes[41];
      }
      set
      {
        this.Attributes[41] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bwmode")]
    public EnumValue<BlackAndWhiteModeValues> BlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackAndWhiteModeValues>) this.Attributes[42];
      }
      set
      {
        this.Attributes[42] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bwpure")]
    public EnumValue<BlackAndWhiteModeValues> PureBlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackAndWhiteModeValues>) this.Attributes[43];
      }
      set
      {
        this.Attributes[43] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "bwnormal")]
    public EnumValue<BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
      get
      {
        return (EnumValue<BlackAndWhiteModeValues>) this.Attributes[44];
      }
      set
      {
        this.Attributes[44] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
      get
      {
        return (TrueFalseValue) this.Attributes[45];
      }
      set
      {
        this.Attributes[45] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
      get
      {
        return (TrueFalseValue) this.Attributes[46];
      }
      set
      {
        this.Attributes[46] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
      get
      {
        return (TrueFalseBlankValue) this.Attributes[47];
      }
      set
      {
        this.Attributes[47] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
      get
      {
        return (TrueFalseValue) this.Attributes[48];
      }
      set
      {
        this.Attributes[48] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
      get
      {
        return (TrueFalseValue) this.Attributes[49];
      }
      set
      {
        this.Attributes[49] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
      get
      {
        return (TrueFalseValue) this.Attributes[50];
      }
      set
      {
        this.Attributes[50] = (OpenXmlSimpleType) value;
      }
    }

    public Oval()
    {
    }

    public Oval(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Oval(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Oval(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "path" == name)
        return (OpenXmlElement) new Path();
      if (26 == (int) namespaceId && "formulas" == name)
        return (OpenXmlElement) new Formulas();
      if (26 == (int) namespaceId && "handles" == name)
        return (OpenXmlElement) new ShapeHandles();
      if (26 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new Fill();
      if (26 == (int) namespaceId && "stroke" == name)
        return (OpenXmlElement) new Stroke();
      if (26 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new Shadow();
      if (26 == (int) namespaceId && "textbox" == name)
        return (OpenXmlElement) new TextBox();
      if (26 == (int) namespaceId && "textpath" == name)
        return (OpenXmlElement) new TextPath();
      if (26 == (int) namespaceId && "imagedata" == name)
        return (OpenXmlElement) new ImageData();
      if (27 == (int) namespaceId && "skew" == name)
        return (OpenXmlElement) new Skew();
      if (27 == (int) namespaceId && "extrusion" == name)
        return (OpenXmlElement) new Extrusion();
      if (27 == (int) namespaceId && "callout" == name)
        return (OpenXmlElement) new Callout();
      if (27 == (int) namespaceId && "lock" == name)
        return (OpenXmlElement) new Lock();
      if (27 == (int) namespaceId && "clippath" == name)
        return (OpenXmlElement) new ClipPath();
      if (27 == (int) namespaceId && "signatureline" == name)
        return (OpenXmlElement) new SignatureLine();
      if (28 == (int) namespaceId && "wrap" == name)
        return (OpenXmlElement) new TextWrap();
      if (28 == (int) namespaceId && "anchorlock" == name)
        return (OpenXmlElement) new AnchorLock();
      if (28 == (int) namespaceId && "bordertop" == name)
        return (OpenXmlElement) new TopBorder();
      if (28 == (int) namespaceId && "borderbottom" == name)
        return (OpenXmlElement) new BottomBorder();
      if (28 == (int) namespaceId && "borderleft" == name)
        return (OpenXmlElement) new LeftBorder();
      if (28 == (int) namespaceId && "borderright" == name)
        return (OpenXmlElement) new RightBorder();
      if (29 == (int) namespaceId && "ClientData" == name)
        return (OpenXmlElement) new ClientData();
      if (30 == (int) namespaceId && "textdata" == name)
        return (OpenXmlElement) new TextData();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "style" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "href" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "target" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "class" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "alt" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "coordsize" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "coordorigin" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "wrapcoords" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "print" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "spid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "oned" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "regroupid" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "doubleclicknotify" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "button" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "userhidden" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "bullet" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "hr" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "hrstd" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "hrnoshade" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "hrpct" == name)
        return (OpenXmlSimpleType) new SingleValue();
      if (27 == (int) namespaceId && "hralign" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalRuleAlignmentValues>();
      if (27 == (int) namespaceId && "allowincell" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "allowoverlap" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "userdrawn" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "bordertopcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "borderleftcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "borderbottomcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "borderrightcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "dgmlayout" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "dgmnodekind" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "dgmlayoutmru" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "insetmode" == name)
        return (OpenXmlSimpleType) new EnumValue<InsetMarginValues>();
      if ((int) namespaceId == 0 && "filled" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "fillcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "stroked" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "strokecolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "strokeweight" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insetpen" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "spt" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (27 == (int) namespaceId && "connectortype" == name)
        return (OpenXmlSimpleType) new EnumValue<ConnectorValues>();
      if (27 == (int) namespaceId && "bwmode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackAndWhiteModeValues>();
      if (27 == (int) namespaceId && "bwpure" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackAndWhiteModeValues>();
      if (27 == (int) namespaceId && "bwnormal" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackAndWhiteModeValues>();
      if (27 == (int) namespaceId && "forcedash" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "oleicon" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "ole" == name)
        return (OpenXmlSimpleType) new TrueFalseBlankValue();
      if (27 == (int) namespaceId && "preferrelative" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "cliptowrap" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "clip" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Oval>(deep);
    }
  }
}
