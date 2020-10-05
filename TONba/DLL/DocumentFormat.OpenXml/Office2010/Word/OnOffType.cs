// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.OnOffType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class OnOffType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 52
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return OnOffType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OnOffType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "val")]
    public EnumValue<OnOffValues> Val
    {
      get
      {
        return (EnumValue<OnOffValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<OnOffValues>();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
