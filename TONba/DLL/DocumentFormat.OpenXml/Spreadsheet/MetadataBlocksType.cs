// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.MetadataBlocksType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MetadataBlock))]
  public abstract class MetadataBlocksType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[1];

    internal override string[] AttributeTagNames
    {
      get
      {
        return MetadataBlocksType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MetadataBlocksType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "bk" == name)
        return (OpenXmlElement) new MetadataBlock();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    protected MetadataBlocksType()
    {
    }

    protected MetadataBlocksType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected MetadataBlocksType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected MetadataBlocksType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
