// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.WebPublishing
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class WebPublishing : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "css",
      "thicket",
      "longFileNames",
      "vml",
      "allowPng",
      "targetScreenSize",
      "dpi",
      "codePage",
      "characterSet"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private const string tagName = "webPublishing";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11532;

    public override string LocalName
    {
      get
      {
        return "webPublishing";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11532;
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
        return WebPublishing.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WebPublishing.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "css")]
    public BooleanValue UseCss
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "thicket")]
    public BooleanValue Thicket
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

    [SchemaAttr(0, "longFileNames")]
    public BooleanValue LongFileNames
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "vml")]
    public BooleanValue UseVml
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "allowPng")]
    public BooleanValue AllowPng
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

    [SchemaAttr(0, "targetScreenSize")]
    public EnumValue<TargetScreenSizeValues> TargetScreenSize
    {
      get
      {
        return (EnumValue<TargetScreenSizeValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dpi")]
    public UInt32Value Dpi
    {
      get
      {
        return (UInt32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "codePage")]
    public UInt32Value CodePage
    {
      get
      {
        return (UInt32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "characterSet")]
    public StringValue CharacterSet
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "css" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "thicket" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "longFileNames" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "vml" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "allowPng" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "targetScreenSize" == name)
        return (OpenXmlSimpleType) new EnumValue<TargetScreenSizeValues>();
      if ((int) namespaceId == 0 && "dpi" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "codePage" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "characterSet" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebPublishing>(deep);
    }
  }
}
