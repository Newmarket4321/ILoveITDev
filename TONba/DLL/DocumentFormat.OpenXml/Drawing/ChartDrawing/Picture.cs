// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualPictureProperties))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (Style))]
  public class Picture : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "macro",
      "fPublished"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[4]
    {
      "nvPicPr",
      "blipFill",
      "spPr",
      "style"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12
    };
    private const string tagName = "pic";
    private const byte tagNsId = 12;
    internal const int ElementTypeIdConst = 10658;

    public override string LocalName
    {
      get
      {
        return "pic";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 12;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10658;
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
        return Picture.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Picture.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "macro")]
    public StringValue Macro
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

    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
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

    public Picture()
    {
    }

    public Picture(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Picture(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Picture(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (12 == (int) namespaceId && "nvPicPr" == name)
        return (OpenXmlElement) new NonVisualPictureProperties();
      if (12 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (12 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (12 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new Style();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Picture.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Picture.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualPictureProperties NonVisualPictureProperties
    {
      get
      {
        return this.GetElement<NonVisualPictureProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualPictureProperties>(0, value);
      }
    }

    public BlipFill BlipFill
    {
      get
      {
        return this.GetElement<BlipFill>(1);
      }
      set
      {
        this.SetElement<BlipFill>(1, value);
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(2);
      }
      set
      {
        this.SetElement<ShapeProperties>(2, value);
      }
    }

    public Style Style
    {
      get
      {
        return this.GetElement<Style>(3);
      }
      set
      {
        this.SetElement<Style>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "macro" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fPublished" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Picture>(deep);
    }
  }
}
