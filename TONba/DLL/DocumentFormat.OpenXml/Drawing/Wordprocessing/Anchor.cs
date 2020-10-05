// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [ChildElementInfo(typeof (WrapThrough))]
  [ChildElementInfo(typeof (WrapNone))]
  [ChildElementInfo(typeof (WrapSquare))]
  [ChildElementInfo(typeof (WrapTight))]
  [ChildElementInfo(typeof (WrapTopBottom))]
  [ChildElementInfo(typeof (SimplePosition))]
  [ChildElementInfo(typeof (HorizontalPosition))]
  [ChildElementInfo(typeof (VerticalPosition))]
  [ChildElementInfo(typeof (Extent))]
  [ChildElementInfo(typeof (EffectExtent))]
  [ChildElementInfo(typeof (Graphic))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualGraphicFrameDrawingProperties))]
  [ChildElementInfo(typeof (DocProperties))]
  [ChildElementInfo(typeof (RelativeWidth), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class Anchor : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[13]
    {
      "distT",
      "distB",
      "distL",
      "distR",
      "simplePos",
      "relativeHeight",
      "behindDoc",
      "locked",
      "layoutInCell",
      "hidden",
      "allowOverlap",
      "editId",
      "anchorId"
    };
    private static byte[] attributeNamespaceIds = new byte[13]
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
      (byte) 51,
      (byte) 51
    };
    private static readonly string[] eleTagNames = new string[15]
    {
      "simplePos",
      "positionH",
      "positionV",
      "extent",
      "effectExtent",
      "wrapNone",
      "wrapSquare",
      "wrapTight",
      "wrapThrough",
      "wrapTopAndBottom",
      "docPr",
      "cNvGraphicFramePr",
      "graphic",
      "sizeRelH",
      "sizeRelV"
    };
    private static readonly byte[] eleNamespaceIds = new byte[15]
    {
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 10,
      (byte) 51,
      (byte) 51
    };
    private const string tagName = "anchor";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10766;

    public override string LocalName
    {
      get
      {
        return "anchor";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 16;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10766;
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
        return Anchor.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Anchor.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "distT")]
    public UInt32Value DistanceFromTop
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "distB")]
    public UInt32Value DistanceFromBottom
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "simplePos")]
    public BooleanValue SimplePos
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "relativeHeight")]
    public UInt32Value RelativeHeight
    {
      get
      {
        return (UInt32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "behindDoc")]
    public BooleanValue BehindDoc
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

    [SchemaAttr(0, "locked")]
    public BooleanValue Locked
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

    [SchemaAttr(0, "layoutInCell")]
    public BooleanValue LayoutInCell
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
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

    [SchemaAttr(0, "allowOverlap")]
    public BooleanValue AllowOverlap
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

    [SchemaAttr(51, "editId")]
    public HexBinaryValue EditId
    {
      get
      {
        return (HexBinaryValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(51, "anchorId")]
    public HexBinaryValue AnchorId
    {
      get
      {
        return (HexBinaryValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    public Anchor()
    {
    }

    public Anchor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Anchor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Anchor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "simplePos" == name)
        return (OpenXmlElement) new SimplePosition();
      if (16 == (int) namespaceId && "positionH" == name)
        return (OpenXmlElement) new HorizontalPosition();
      if (16 == (int) namespaceId && "positionV" == name)
        return (OpenXmlElement) new VerticalPosition();
      if (16 == (int) namespaceId && "extent" == name)
        return (OpenXmlElement) new Extent();
      if (16 == (int) namespaceId && "effectExtent" == name)
        return (OpenXmlElement) new EffectExtent();
      if (16 == (int) namespaceId && "wrapNone" == name)
        return (OpenXmlElement) new WrapNone();
      if (16 == (int) namespaceId && "wrapSquare" == name)
        return (OpenXmlElement) new WrapSquare();
      if (16 == (int) namespaceId && "wrapTight" == name)
        return (OpenXmlElement) new WrapTight();
      if (16 == (int) namespaceId && "wrapThrough" == name)
        return (OpenXmlElement) new WrapThrough();
      if (16 == (int) namespaceId && "wrapTopAndBottom" == name)
        return (OpenXmlElement) new WrapTopBottom();
      if (16 == (int) namespaceId && "docPr" == name)
        return (OpenXmlElement) new DocProperties();
      if (16 == (int) namespaceId && "cNvGraphicFramePr" == name)
        return (OpenXmlElement) new NonVisualGraphicFrameDrawingProperties();
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
      if (51 == (int) namespaceId && "sizeRelH" == name)
        return (OpenXmlElement) new RelativeWidth();
      if (51 == (int) namespaceId && "sizeRelV" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Anchor.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Anchor.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SimplePosition SimplePosition
    {
      get
      {
        return this.GetElement<SimplePosition>(0);
      }
      set
      {
        this.SetElement<SimplePosition>(0, value);
      }
    }

    public HorizontalPosition HorizontalPosition
    {
      get
      {
        return this.GetElement<HorizontalPosition>(1);
      }
      set
      {
        this.SetElement<HorizontalPosition>(1, value);
      }
    }

    public VerticalPosition VerticalPosition
    {
      get
      {
        return this.GetElement<VerticalPosition>(2);
      }
      set
      {
        this.SetElement<VerticalPosition>(2, value);
      }
    }

    public Extent Extent
    {
      get
      {
        return this.GetElement<Extent>(3);
      }
      set
      {
        this.SetElement<Extent>(3, value);
      }
    }

    public EffectExtent EffectExtent
    {
      get
      {
        return this.GetElement<EffectExtent>(4);
      }
      set
      {
        this.SetElement<EffectExtent>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "distT" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "distB" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "distL" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "distR" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "simplePos" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "relativeHeight" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "behindDoc" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "locked" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "layoutInCell" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "allowOverlap" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if (51 == (int) namespaceId && "editId" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (51 == (int) namespaceId && "anchorId" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Anchor>(deep);
    }
  }
}
