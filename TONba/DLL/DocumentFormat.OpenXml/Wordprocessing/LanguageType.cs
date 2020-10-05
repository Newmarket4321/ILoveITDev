// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.LanguageType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class LanguageType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "val",
      "eastAsia",
      "bidi"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return LanguageType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LanguageType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public StringValue Val
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

    [SchemaAttr(23, "eastAsia")]
    public StringValue EastAsia
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

    [SchemaAttr(23, "bidi")]
    public StringValue Bidi
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "eastAsia" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "bidi" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
