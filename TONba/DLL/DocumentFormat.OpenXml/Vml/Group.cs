// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Group
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [ChildElementInfo(typeof (Diagram))]
  [ChildElementInfo(typeof (Rectangle))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Shapetype))]
  [ChildElementInfo(typeof (Arc))]
  [ChildElementInfo(typeof (Curve))]
  [ChildElementInfo(typeof (ImageFile))]
  [ChildElementInfo(typeof (Line))]
  [ChildElementInfo(typeof (Oval))]
  [ChildElementInfo(typeof (PolyLine))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (RoundRectangle))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (Lock))]
  [ChildElementInfo(typeof (ClipPath))]
  [ChildElementInfo(typeof (TextWrap))]
  [ChildElementInfo(typeof (AnchorLock))]
  [ChildElementInfo(typeof (ClientData))]
  public class Group : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[33]
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
      "dgmlayout",
      "dgmnodekind",
      "dgmlayoutmru",
      "insetmode",
      "editas",
      "tableproperties",
      "tablelimits"
    };
    private static byte[] attributeNamespaceIds = new byte[33]
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
      (byte) 0,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "group";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12588;

    public override string LocalName
    {
      get
      {
        return "group";
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
        return 12588;
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
        return Group.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Group.attributeNamespaceIds;
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

    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
      get
      {
        return (IntegerValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
      get
      {
        return (IntegerValue) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
      get
      {
        return (IntegerValue) this.Attributes[28];
      }
      set
      {
        this.Attributes[28] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "insetmode")]
    public EnumValue<InsetMarginValues> InsetMode
    {
      get
      {
        return (EnumValue<InsetMarginValues>) this.Attributes[29];
      }
      set
      {
        this.Attributes[29] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "editas")]
    public EnumValue<EditAsValues> EditAs
    {
      get
      {
        return (EnumValue<EditAsValues>) this.Attributes[30];
      }
      set
      {
        this.Attributes[30] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "tableproperties")]
    public StringValue TableProperties
    {
      get
      {
        return (StringValue) this.Attributes[31];
      }
      set
      {
        this.Attributes[31] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "tablelimits")]
    public StringValue TableLimits
    {
      get
      {
        return (StringValue) this.Attributes[32];
      }
      set
      {
        this.Attributes[32] = (OpenXmlSimpleType) value;
      }
    }

    public Group()
    {
    }

    public Group(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Group(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Group(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new Group();
      if (26 == (int) namespaceId && "shape" == name)
        return (OpenXmlElement) new Shape();
      if (26 == (int) namespaceId && "shapetype" == name)
        return (OpenXmlElement) new Shapetype();
      if (26 == (int) namespaceId && "arc" == name)
        return (OpenXmlElement) new Arc();
      if (26 == (int) namespaceId && "curve" == name)
        return (OpenXmlElement) new Curve();
      if (26 == (int) namespaceId && "image" == name)
        return (OpenXmlElement) new ImageFile();
      if (26 == (int) namespaceId && "line" == name)
        return (OpenXmlElement) new Line();
      if (26 == (int) namespaceId && "oval" == name)
        return (OpenXmlElement) new Oval();
      if (26 == (int) namespaceId && "polyline" == name)
        return (OpenXmlElement) new PolyLine();
      if (26 == (int) namespaceId && "rect" == name)
        return (OpenXmlElement) new Rectangle();
      if (26 == (int) namespaceId && "roundrect" == name)
        return (OpenXmlElement) new RoundRectangle();
      if (27 == (int) namespaceId && "diagram" == name)
        return (OpenXmlElement) new Diagram();
      if (27 == (int) namespaceId && "lock" == name)
        return (OpenXmlElement) new Lock();
      if (27 == (int) namespaceId && "clippath" == name)
        return (OpenXmlElement) new ClipPath();
      if (28 == (int) namespaceId && "wrap" == name)
        return (OpenXmlElement) new TextWrap();
      if (28 == (int) namespaceId && "anchorlock" == name)
        return (OpenXmlElement) new AnchorLock();
      if (29 == (int) namespaceId && "ClientData" == name)
        return (OpenXmlElement) new ClientData();
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
      if (27 == (int) namespaceId && "dgmlayout" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "dgmnodekind" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "dgmlayoutmru" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (27 == (int) namespaceId && "insetmode" == name)
        return (OpenXmlSimpleType) new EnumValue<InsetMarginValues>();
      if ((int) namespaceId == 0 && "editas" == name)
        return (OpenXmlSimpleType) new EnumValue<EditAsValues>();
      if (27 == (int) namespaceId && "tableproperties" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "tablelimits" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Group>(deep);
    }
  }
}
