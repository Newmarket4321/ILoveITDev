// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Point2DType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class Point2DType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "x",
      "y"
    };
    private static byte[] attributeNamespaceIds = new byte[2];

    internal override string[] AttributeTagNames
    {
      get
      {
        return Point2DType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Point2DType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "x")]
    public Int64Value X
    {
      get
      {
        return (Int64Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "y")]
    public Int64Value Y
    {
      get
      {
        return (Int64Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "x" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "y" == name)
        return (OpenXmlSimpleType) new Int64Value();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
