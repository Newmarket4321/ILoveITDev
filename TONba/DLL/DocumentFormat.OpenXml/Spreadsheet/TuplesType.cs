// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TuplesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Tuple))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class TuplesType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "c"
    };
    private static byte[] attributeNamespaceIds = new byte[1];

    internal override string[] AttributeTagNames
    {
      get
      {
        return TuplesType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TuplesType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "c")]
    public UInt32Value MemberNameCount
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
      if (22 == (int) namespaceId && "tpl" == name)
        return (OpenXmlElement) new Tuple();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "c" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    protected TuplesType()
    {
    }

    protected TuplesType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TuplesType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TuplesType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
