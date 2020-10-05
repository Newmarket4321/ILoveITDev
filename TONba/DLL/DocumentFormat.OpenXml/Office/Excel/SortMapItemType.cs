// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.SortMapItemType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class SortMapItemType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "newVal",
      "oldVal"
    };
    private static byte[] attributeNamespaceIds = new byte[2];

    internal override string[] AttributeTagNames
    {
      get
      {
        return SortMapItemType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SortMapItemType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "newVal")]
    public UInt32Value NewVal
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

    [SchemaAttr(0, "oldVal")]
    public UInt32Value OldVal
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "newVal" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "oldVal" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
