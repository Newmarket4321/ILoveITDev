// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Ink.ContextLinkType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Ink
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class ContextLinkType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "direction",
      "ref"
    };
    private static byte[] attributeNamespaceIds = new byte[2];

    internal override string[] AttributeTagNames
    {
      get
      {
        return ContextLinkType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContextLinkType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "direction")]
    public EnumValue<LinkDirectionValues> Direction
    {
      get
      {
        return (EnumValue<LinkDirectionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ref")]
    public StringValue Reference
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
      if ((int) namespaceId == 0 && "direction" == name)
        return (OpenXmlSimpleType) new EnumValue<LinkDirectionValues>();
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
