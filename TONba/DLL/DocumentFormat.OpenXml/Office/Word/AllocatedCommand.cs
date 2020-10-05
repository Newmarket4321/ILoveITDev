// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.AllocatedCommand
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  public class AllocatedCommand : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "argValue",
      "fciBasedOn",
      "fciIndexBasedOn",
      "acdName"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "acd";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12618;

    public override string LocalName
    {
      get
      {
        return "acd";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12618;
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
        return AllocatedCommand.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AllocatedCommand.attributeNamespaceIds;
      }
    }

    [SchemaAttr(33, "argValue")]
    public StringValue ArgumentValue
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

    [SchemaAttr(33, "fciBasedOn")]
    public StringValue CommandBasedOn
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

    [SchemaAttr(33, "fciIndexBasedOn")]
    public HexBinaryValue CommandIndexBasedOn
    {
      get
      {
        return (HexBinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(33, "acdName")]
    public StringValue AcceleratorName
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "argValue" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (33 == (int) namespaceId && "fciBasedOn" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (33 == (int) namespaceId && "fciIndexBasedOn" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "acdName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AllocatedCommand>(deep);
    }
  }
}
