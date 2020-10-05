// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Extent))]
  [ChildElementInfo(typeof (EffectExtent))]
  [ChildElementInfo(typeof (DocProperties))]
  [ChildElementInfo(typeof (NonVisualGraphicFrameDrawingProperties))]
  [ChildElementInfo(typeof (Graphic))]
  public class Inline : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "distT",
      "distB",
      "distL",
      "distR",
      "anchorId",
      "editId"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 51,
      (byte) 51
    };
    private static readonly string[] eleTagNames = new string[5]
    {
      "extent",
      "effectExtent",
      "docPr",
      "cNvGraphicFramePr",
      "graphic"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 16,
      (byte) 10
    };
    private const string tagName = "inline";
    private const byte tagNsId = 16;
    internal const int ElementTypeIdConst = 10765;

    public override string LocalName
    {
      get
      {
        return "inline";
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
        return 10765;
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
        return Inline.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Inline.attributeNamespaceIds;
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

    [SchemaAttr(51, "anchorId")]
    public HexBinaryValue AnchorId
    {
      get
      {
        return (HexBinaryValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(51, "editId")]
    public HexBinaryValue EditId
    {
      get
      {
        return (HexBinaryValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public Inline()
    {
    }

    public Inline(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Inline(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Inline(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (16 == (int) namespaceId && "extent" == name)
        return (OpenXmlElement) new Extent();
      if (16 == (int) namespaceId && "effectExtent" == name)
        return (OpenXmlElement) new EffectExtent();
      if (16 == (int) namespaceId && "docPr" == name)
        return (OpenXmlElement) new DocProperties();
      if (16 == (int) namespaceId && "cNvGraphicFramePr" == name)
        return (OpenXmlElement) new NonVisualGraphicFrameDrawingProperties();
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Inline.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Inline.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Extent Extent
    {
      get
      {
        return this.GetElement<Extent>(0);
      }
      set
      {
        this.SetElement<Extent>(0, value);
      }
    }

    public EffectExtent EffectExtent
    {
      get
      {
        return this.GetElement<EffectExtent>(1);
      }
      set
      {
        this.SetElement<EffectExtent>(1, value);
      }
    }

    public DocProperties DocProperties
    {
      get
      {
        return this.GetElement<DocProperties>(2);
      }
      set
      {
        this.SetElement<DocProperties>(2, value);
      }
    }

    public NonVisualGraphicFrameDrawingProperties NonVisualGraphicFrameDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualGraphicFrameDrawingProperties>(3);
      }
      set
      {
        this.SetElement<NonVisualGraphicFrameDrawingProperties>(3, value);
      }
    }

    public Graphic Graphic
    {
      get
      {
        return this.GetElement<Graphic>(4);
      }
      set
      {
        this.SetElement<Graphic>(4, value);
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
      if (51 == (int) namespaceId && "anchorId" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (51 == (int) namespaceId && "editId" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Inline>(deep);
    }
  }
}
