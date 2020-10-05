// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class HeaderFooterReferenceType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "type",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 19
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return HeaderFooterReferenceType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return HeaderFooterReferenceType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "type")]
    public EnumValue<HeaderFooterValues> Type
    {
      get
      {
        return (EnumValue<HeaderFooterValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<HeaderFooterValues>();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
