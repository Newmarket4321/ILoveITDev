// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ChartSheetProtection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class ChartSheetProtection : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "password",
      "algorithmName",
      "hashValue",
      "saltValue",
      "spinCount",
      "content",
      "objects"
    };
    private static byte[] attributeNamespaceIds = new byte[7];
    private const string tagName = "sheetProtection";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11390;

    public override string LocalName
    {
      get
      {
        return "sheetProtection";
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
        return 11390;
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
        return ChartSheetProtection.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ChartSheetProtection.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "password")]
    public HexBinaryValue Password
    {
      get
      {
        return (HexBinaryValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "algorithmName")]
    public StringValue AlgorithmName
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

    [SchemaAttr(0, "hashValue")]
    public Base64BinaryValue HashValue
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "saltValue")]
    public Base64BinaryValue SaltValue
    {
      get
      {
        return (Base64BinaryValue) this.Attributes[3];
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

    [SchemaAttr(0, "content")]
    public BooleanValue Content
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "objects")]
    public BooleanValue Objects
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "password" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if ((int) namespaceId == 0 && "algorithmName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hashValue" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if ((int) namespaceId == 0 && "saltValue" == name)
        return (OpenXmlSimpleType) new Base64BinaryValue();
      if ((int) namespaceId == 0 && "spinCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "content" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "objects" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ChartSheetProtection>(deep);
    }
  }
}
