// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.ImageData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml
{
  [GeneratedCode("DomGen", "2.0")]
  public class ImageData : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[19]
    {
      "id",
      "chromakey",
      "cropleft",
      "croptop",
      "cropright",
      "cropbottom",
      "gain",
      "blacklevel",
      "gamma",
      "grayscale",
      "bilevel",
      "embosscolor",
      "recolortarget",
      "title",
      "detectmouseclick",
      "relid",
      "id",
      "pict",
      "href"
    };
    private static byte[] attributeNamespaceIds = new byte[19]
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
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 19,
      (byte) 19,
      (byte) 19
    };
    private const string tagName = "imagedata";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12585;

    public override string LocalName
    {
      get
      {
        return "imagedata";
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
        return 12585;
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
        return ImageData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ImageData.attributeNamespaceIds;
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

    [SchemaAttr(0, "chromakey")]
    public StringValue ChromAKey
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

    [SchemaAttr(0, "cropleft")]
    public StringValue CropLeft
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

    [SchemaAttr(0, "croptop")]
    public StringValue CropTop
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

    [SchemaAttr(0, "cropright")]
    public StringValue CropRight
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

    [SchemaAttr(0, "cropbottom")]
    public StringValue CropBottom
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

    [SchemaAttr(0, "gain")]
    public StringValue Gain
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

    [SchemaAttr(0, "blacklevel")]
    public StringValue BlackLevel
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

    [SchemaAttr(0, "gamma")]
    public StringValue Gamma
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

    [SchemaAttr(0, "grayscale")]
    public TrueFalseValue Grayscale
    {
      get
      {
        return (TrueFalseValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bilevel")]
    public TrueFalseValue BiLevel
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

    [SchemaAttr(0, "embosscolor")]
    public StringValue EmbossColor
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

    [SchemaAttr(0, "recolortarget")]
    public StringValue RecolorTarget
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "title")]
    public StringValue Title
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "detectmouseclick")]
    public TrueFalseValue DetectMouseClick
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

    [SchemaAttr(27, "relid")]
    public StringValue RelId
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "pict")]
    public StringValue Picture
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "href")]
    public StringValue RelHref
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "chromakey" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cropleft" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "croptop" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cropright" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cropbottom" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "gain" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "blacklevel" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "gamma" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "grayscale" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "bilevel" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "embosscolor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "recolortarget" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "detectmouseclick" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "relid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "pict" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "href" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ImageData>(deep);
    }
  }
}
