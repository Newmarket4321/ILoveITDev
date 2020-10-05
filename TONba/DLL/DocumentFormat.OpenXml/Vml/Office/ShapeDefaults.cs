// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.ShapeDefaults
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [ChildElementInfo(typeof (ColorMenu))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ImageData))]
  [ChildElementInfo(typeof (Stroke))]
  [ChildElementInfo(typeof (TextBox))]
  [ChildElementInfo(typeof (Shadow))]
  [ChildElementInfo(typeof (Fill))]
  [ChildElementInfo(typeof (Extrusion))]
  [ChildElementInfo(typeof (Callout))]
  [ChildElementInfo(typeof (Skew))]
  [ChildElementInfo(typeof (Lock))]
  [ChildElementInfo(typeof (ColorMostRecentlyUsed))]
  public class ShapeDefaults : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[10]
    {
      "ext",
      "spidmax",
      "style",
      "fill",
      "fillcolor",
      "stroke",
      "strokecolor",
      "allowincell",
      "allowoverlap",
      "insetmode"
    };
    private static byte[] attributeNamespaceIds = new byte[10]
    {
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private static readonly string[] eleTagNames = new string[11]
    {
      "fill",
      "imagedata",
      "stroke",
      "textbox",
      "shadow",
      "skew",
      "extrusion",
      "callout",
      "lock",
      "colormru",
      "colormenu"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
    {
      (byte) 26,
      (byte) 26,
      (byte) 26,
      (byte) 26,
      (byte) 26,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "shapedefaults";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12470;

    public override string LocalName
    {
      get
      {
        return "shapedefaults";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12470;
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
        return ShapeDefaults.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ShapeDefaults.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "spidmax")]
    public IntegerValue MaxShapeId
    {
      get
      {
        return (IntegerValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "style")]
    public StringValue Style
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

    [SchemaAttr(0, "fill")]
    public TrueFalseValue BeFilled
    {
      get
      {
        return (TrueFalseValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
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

    [SchemaAttr(0, "stroke")]
    public TrueFalseValue IsStroke
    {
      get
      {
        return (TrueFalseValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
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

    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
      get
      {
        return (TrueFalseValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
      get
      {
        return (TrueFalseValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "insetmode")]
    public EnumValue<InsetMarginValues> InsetMode
    {
      get
      {
        return (EnumValue<InsetMarginValues>) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    public ShapeDefaults()
    {
    }

    public ShapeDefaults(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShapeDefaults(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShapeDefaults(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new Fill();
      if (26 == (int) namespaceId && "imagedata" == name)
        return (OpenXmlElement) new ImageData();
      if (26 == (int) namespaceId && "stroke" == name)
        return (OpenXmlElement) new Stroke();
      if (26 == (int) namespaceId && "textbox" == name)
        return (OpenXmlElement) new TextBox();
      if (26 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new Shadow();
      if (27 == (int) namespaceId && "skew" == name)
        return (OpenXmlElement) new Skew();
      if (27 == (int) namespaceId && "extrusion" == name)
        return (OpenXmlElement) new Extrusion();
      if (27 == (int) namespaceId && "callout" == name)
        return (OpenXmlElement) new Callout();
      if (27 == (int) namespaceId && "lock" == name)
        return (OpenXmlElement) new Lock();
      if (27 == (int) namespaceId && "colormru" == name)
        return (OpenXmlElement) new ColorMostRecentlyUsed();
      if (27 == (int) namespaceId && "colormenu" == name)
        return (OpenXmlElement) new ColorMenu();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ShapeDefaults.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ShapeDefaults.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public Fill Fill
    {
      get
      {
        return this.GetElement<Fill>(0);
      }
      set
      {
        this.SetElement<Fill>(0, value);
      }
    }

    public ImageData ImageData
    {
      get
      {
        return this.GetElement<ImageData>(1);
      }
      set
      {
        this.SetElement<ImageData>(1, value);
      }
    }

    public Stroke Stroke
    {
      get
      {
        return this.GetElement<Stroke>(2);
      }
      set
      {
        this.SetElement<Stroke>(2, value);
      }
    }

    public TextBox TextBox
    {
      get
      {
        return this.GetElement<TextBox>(3);
      }
      set
      {
        this.SetElement<TextBox>(3, value);
      }
    }

    public Shadow Shadow
    {
      get
      {
        return this.GetElement<Shadow>(4);
      }
      set
      {
        this.SetElement<Shadow>(4, value);
      }
    }

    public Skew Skew
    {
      get
      {
        return this.GetElement<Skew>(5);
      }
      set
      {
        this.SetElement<Skew>(5, value);
      }
    }

    public Extrusion Extrusion
    {
      get
      {
        return this.GetElement<Extrusion>(6);
      }
      set
      {
        this.SetElement<Extrusion>(6, value);
      }
    }

    public Callout Callout
    {
      get
      {
        return this.GetElement<Callout>(7);
      }
      set
      {
        this.SetElement<Callout>(7, value);
      }
    }

    public Lock Lock
    {
      get
      {
        return this.GetElement<Lock>(8);
      }
      set
      {
        this.SetElement<Lock>(8, value);
      }
    }

    public ColorMostRecentlyUsed ColorMostRecentlyUsed
    {
      get
      {
        return this.GetElement<ColorMostRecentlyUsed>(9);
      }
      set
      {
        this.SetElement<ColorMostRecentlyUsed>(9, value);
      }
    }

    public ColorMenu ColorMenu
    {
      get
      {
        return this.GetElement<ColorMenu>(10);
      }
      set
      {
        this.SetElement<ColorMenu>(10, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      if ((int) namespaceId == 0 && "spidmax" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "style" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fill" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "fillcolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "stroke" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "strokecolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "allowincell" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "allowoverlap" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "insetmode" == name)
        return (OpenXmlSimpleType) new EnumValue<InsetMarginValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapeDefaults>(deep);
    }
  }
}
