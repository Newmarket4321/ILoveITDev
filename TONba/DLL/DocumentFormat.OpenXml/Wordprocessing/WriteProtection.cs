// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.WriteProtection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class WriteProtection : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[17]
    {
      "recommended",
      "cryptProviderType",
      "cryptAlgorithmClass",
      "cryptAlgorithmType",
      "cryptAlgorithmSid",
      "cryptSpinCount",
      "cryptProvider",
      "algIdExt",
      "algIdExtSource",
      "cryptProviderTypeExt",
      "cryptProviderTypeExtSource",
      "hash",
      "salt",
      "algorithmName",
      "hashValue",
      "saltValue",
      "spinCount"
    };
    private static byte[] attributeNamespaceIds = new byte[17]
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
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "writeProtection";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12103;

    public override string LocalName
    {
      get
      {
        return "writeProtection";
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
        return 12103;
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
        return WriteProtection.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WriteProtection.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "recommended")]
    public OnOffValue Recommended
    {
      get
      {
        return (OnOffValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cryptProviderType")]
    public EnumValue<CryptProviderValues> CryptographicProviderType
    {
      get
      {
        return (EnumValue<CryptProviderValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cryptAlgorithmClass")]
    public EnumValue<CryptAlgorithmClassValues> CryptographicAlgorithmClass
    {
      get
      {
        return (EnumValue<CryptAlgorithmClassValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cryptAlgorithmType")]
    public EnumValue<CryptAlgorithmValues> CryptographicAlgorithmType
    {
      get
      {
        return (EnumValue<CryptAlgorithmValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cryptAlgorithmSid")]
    public Int32Value CryptographicAlgorithmSid
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cryptSpinCount")]
    public UInt32Value CryptographicSpinCount
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

    [SchemaAttr(23, "cryptProvider")]
    public StringValue CryptographicProvider
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

    [SchemaAttr(23, "algIdExt")]
    public HexBinaryValue AlgorithmIdExtensibility
    {
      get
      {
        return (HexBinaryValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "algIdExtSource")]
    public StringValue AlgorithmIdExtensibilitySource
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

    [SchemaAttr(23, "cryptProviderTypeExt")]
    public HexBinaryValue CryptographicProviderTypeExtensibility
    {
      get
      {
        return (HexBinaryValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cryptProviderTypeExtSource")]
    public StringValue CryptographicProviderTypeExtSource
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hash")]
    public Base64BinaryValue Hash
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "salt")]
    public Base64BinaryValue Salt
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "algorithmName")]
    public StringValue AlgorithmName
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

    [SchemaAttr(23, "hashValue")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public Base64BinaryValue HashValue
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

    [SchemaAttr(23, "saltValue")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public Base64BinaryValue SaltValue
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "spinCount")]
    public Int32Value SpinCount
    {
      get
      {
        return (Int32Value) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "recommended" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "cryptProviderType" == name)
        return (OpenXmlSimpleType) new EnumValue<CryptProviderValues>();
      if (23 == (int) namespaceId && "cryptAlgorithmClass" == name)
        return (OpenXmlSimpleType) new EnumValue<CryptAlgorithmClassValues>();
      if (23 == (int) namespaceId && "cryptAlgorithmType" == name)
        return (OpenXmlSimpleType) new EnumValue<CryptAlgorithmValues>();
      if (23 == (int) namespaceId && "cryptAlgorithmSid" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "cryptSpinCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (23 == (int) namespaceId && "cryptProvider" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "algIdExt" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "algIdExtSource" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "cryptProviderTypeExt" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "cryptProviderTypeExtSource" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "hash" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if (23 == (int) namespaceId && "salt" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if (23 == (int) namespaceId && "algorithmName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "hashValue" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if (23 == (int) namespaceId && "saltValue" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if (23 == (int) namespaceId && "spinCount" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WriteProtection>(deep);
    }
  }
}
