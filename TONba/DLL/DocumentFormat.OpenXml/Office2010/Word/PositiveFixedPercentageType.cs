// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.PositiveFixedPercentageType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class PositiveFixedPercentageType : OpenXmlLeafElement
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
        return PositiveFixedPercentageType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PositiveFixedPercentageType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "val")]
    public Int32Value Val
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
