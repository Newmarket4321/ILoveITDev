// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.LineEndPropertiesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class LineEndPropertiesType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "type",
      "w",
      "len"
    };
    private static byte[] attributeNamespaceIds = new byte[3];

    internal override string[] AttributeTagNames
    {
      get
      {
        return LineEndPropertiesType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LineEndPropertiesType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<LineEndValues> Type
    {
      get
      {
        return (EnumValue<LineEndValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "w")]
    public EnumValue<LineEndWidthValues> Width
    {
      get
      {
        return (EnumValue<LineEndWidthValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "len")]
    public EnumValue<LineEndLengthValues> Length
    {
      get
      {
        return (EnumValue<LineEndLengthValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<LineEndValues>();
      if ((int) namespaceId == 0 && "w" == name)
        return (OpenXmlSimpleType) new EnumValue<LineEndWidthValues>();
      if ((int) namespaceId == 0 && "len" == name)
        return (OpenXmlSimpleType) new EnumValue<LineEndLengthValues>();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
