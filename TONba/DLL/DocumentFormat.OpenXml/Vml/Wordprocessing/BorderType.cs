// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class BorderType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "type",
      "width",
      "shadow"
    };
    private static byte[] attributeNamespaceIds = new byte[3];

    internal override string[] AttributeTagNames
    {
      get
      {
        return BorderType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BorderType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<BorderValues> Type
    {
      get
      {
        return (EnumValue<BorderValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "width")]
    public IntegerValue Width
    {
      get
      {
        return (IntegerValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "shadow")]
    public TrueFalseValue Shadow
    {
      get
      {
        return (TrueFalseValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<BorderValues>();
      if ((int) namespaceId == 0 && "width" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "shadow" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
