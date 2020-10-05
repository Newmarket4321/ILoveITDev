// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.XstringType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class XstringType : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "space"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 1
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return XstringType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return XstringType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(1, "space")]
    public EnumValue<SpaceProcessingModeValues> Space
    {
      get
      {
        return (EnumValue<SpaceProcessingModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "space" == name)
        return (OpenXmlSimpleType) new EnumValue<SpaceProcessingModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    protected XstringType()
    {
    }

    protected XstringType(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }
  }
}
