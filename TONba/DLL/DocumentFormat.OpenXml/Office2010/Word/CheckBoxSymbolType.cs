// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class CheckBoxSymbolType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "font",
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 52,
      (byte) 52
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return CheckBoxSymbolType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CheckBoxSymbolType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "font")]
    public StringValue Font
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

    [SchemaAttr(52, "val")]
    public HexBinaryValue Val
    {
      get
      {
        return (HexBinaryValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "font" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (52 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
