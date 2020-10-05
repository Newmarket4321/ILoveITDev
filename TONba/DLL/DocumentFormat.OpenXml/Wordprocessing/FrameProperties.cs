// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.FrameProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class FrameProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[15]
    {
      "dropCap",
      "lines",
      "w",
      "h",
      "vSpace",
      "hSpace",
      "wrap",
      "hAnchor",
      "vAnchor",
      "x",
      "xAlign",
      "y",
      "yAlign",
      "hRule",
      "anchorLock"
    };
    private static byte[] attributeNamespaceIds = new byte[15]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "framePr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11560;

    public override string LocalName
    {
      get
      {
        return "framePr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11560;
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
        return FrameProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FrameProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "dropCap")]
    public EnumValue<DropCapLocationValues> DropCap
    {
      get
      {
        return (EnumValue<DropCapLocationValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "lines")]
    public Int32Value Lines
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

    [SchemaAttr(23, "w")]
    public StringValue Width
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

    [SchemaAttr(23, "h")]
    public UInt32Value Height
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

    [SchemaAttr(23, "vSpace")]
    public StringValue VerticalSpace
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

    [SchemaAttr(23, "hSpace")]
    public StringValue HorizontalSpace
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

    [SchemaAttr(23, "wrap")]
    public EnumValue<TextWrappingValues> Wrap
    {
      get
      {
        return (EnumValue<TextWrappingValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hAnchor")]
    public EnumValue<HorizontalAnchorValues> HorizontalPosition
    {
      get
      {
        return (EnumValue<HorizontalAnchorValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "vAnchor")]
    public EnumValue<VerticalAnchorValues> VerticalPosition
    {
      get
      {
        return (EnumValue<VerticalAnchorValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "x")]
    public StringValue X
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

    [SchemaAttr(23, "xAlign")]
    public EnumValue<HorizontalAlignmentValues> XAlign
    {
      get
      {
        return (EnumValue<HorizontalAlignmentValues>) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "y")]
    public StringValue Y
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

    [SchemaAttr(23, "yAlign")]
    public EnumValue<VerticalAlignmentValues> YAlign
    {
      get
      {
        return (EnumValue<VerticalAlignmentValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hRule")]
    public EnumValue<HeightRuleValues> HeightType
    {
      get
      {
        return (EnumValue<HeightRuleValues>) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "anchorLock")]
    public OnOffValue AnchorLock
    {
      get
      {
        return (OnOffValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "dropCap" == name)
        return (OpenXmlSimpleType) new EnumValue<DropCapLocationValues>();
      if (23 == (int) namespaceId && "lines" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "w" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "h" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (23 == (int) namespaceId && "vSpace" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "hSpace" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "wrap" == name)
        return (OpenXmlSimpleType) new EnumValue<TextWrappingValues>();
      if (23 == (int) namespaceId && "hAnchor" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalAnchorValues>();
      if (23 == (int) namespaceId && "vAnchor" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalAnchorValues>();
      if (23 == (int) namespaceId && "x" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "xAlign" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalAlignmentValues>();
      if (23 == (int) namespaceId && "y" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "yAlign" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalAlignmentValues>();
      if (23 == (int) namespaceId && "hRule" == name)
        return (OpenXmlSimpleType) new EnumValue<HeightRuleValues>();
      if (23 == (int) namespaceId && "anchorLock" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FrameProperties>(deep);
    }
  }
}
