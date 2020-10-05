// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class TableWidthDxaNilType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "w",
      "type"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return TableWidthDxaNilType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableWidthDxaNilType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "w")]
    public Int16Value Width
    {
      get
      {
        return (Int16Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "type")]
    public EnumValue<TableWidthValues> Type
    {
      get
      {
        return (EnumValue<TableWidthValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "w" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<TableWidthValues>();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
