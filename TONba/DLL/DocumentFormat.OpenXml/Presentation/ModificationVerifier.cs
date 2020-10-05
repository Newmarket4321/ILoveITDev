// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ModificationVerifier
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public class ModificationVerifier : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[16]
    {
      "cryptProviderType",
      "cryptAlgorithmClass",
      "cryptAlgorithmType",
      "cryptAlgorithmSid",
      "spinCount",
      "saltData",
      "hashData",
      "cryptProvider",
      "algIdExt",
      "algIdExtSource",
      "cryptProviderTypeExt",
      "cryptProviderTypeExtSource",
      "algorithmName",
      "hashValue",
      "saltValue",
      "spinValue"
    };
    private static byte[] attributeNamespaceIds = new byte[16];
    private const string tagName = "modifyVerifier";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12423;

    public override string LocalName
    {
      get
      {
        return "modifyVerifier";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12423;
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
        return ModificationVerifier.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ModificationVerifier.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "cryptProviderType")]
    public EnumValue<CryptProviderValues> CryptographicProviderType
    {
      get
      {
        return (EnumValue<CryptProviderValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cryptAlgorithmClass")]
    public EnumValue<CryptAlgorithmClassValues> CryptographicAlgorithmClass
    {
      get
      {
        return (EnumValue<CryptAlgorithmClassValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cryptAlgorithmType")]
    public EnumValue<CryptAlgorithmValues> CryptographicAlgorithmType
    {
      get
      {
        return (EnumValue<CryptAlgorithmValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cryptAlgorithmSid")]
    public UInt32Value CryptographicAlgorithmSid
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

    [SchemaAttr(0, "spinCount")]
    public UInt32Value SpinCount
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "saltData")]
    public Base64BinaryValue SaltData
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hashData")]
    public StringValue HashData
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

    [SchemaAttr(0, "cryptProvider")]
    public StringValue CryptographicProvider
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

    [SchemaAttr(0, "algIdExt")]
    public UInt32Value ExtendedCryptographicAlgorithm
    {
      get
      {
        return (UInt32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "algIdExtSource")]
    public StringValue ExtendedCryptographicAlgorithmSource
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

    [SchemaAttr(0, "cryptProviderTypeExt")]
    public UInt32Value CryptographicProviderTypeExtensibility
    {
      get
      {
        return (UInt32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cryptProviderTypeExtSource")]
    public StringValue CryptographicProviderTypeExtensibilitySource
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

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(0, "algorithmName")]
    public StringValue AlgorithmName
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

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(0, "hashValue")]
    public Base64BinaryValue HashValue
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "saltValue")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public Base64BinaryValue SaltValue
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(0, "spinValue")]
    public UInt32Value SpinValue
    {
      get
      {
        return (UInt32Value) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "cryptProviderType" == name)
        return (OpenXmlSimpleType) new EnumValue<CryptProviderValues>();
      if ((int) namespaceId == 0 && "cryptAlgorithmClass" == name)
        return (OpenXmlSimpleType) new EnumValue<CryptAlgorithmClassValues>();
      if ((int) namespaceId == 0 && "cryptAlgorithmType" == name)
        return (OpenXmlSimpleType) new EnumValue<CryptAlgorithmValues>();
      if ((int) namespaceId == 0 && "cryptAlgorithmSid" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "spinCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "saltData" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if ((int) namespaceId == 0 && "hashData" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cryptProvider" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "algIdExt" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "algIdExtSource" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cryptProviderTypeExt" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "cryptProviderTypeExtSource" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "algorithmName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hashValue" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if ((int) namespaceId == 0 && "saltValue" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if ((int) namespaceId == 0 && "spinValue" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ModificationVerifier>(deep);
    }
  }
}
