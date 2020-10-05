// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.BevelType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class BevelType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "w",
      "h",
      "prst"
    };
    private static byte[] attributeNamespaceIds = new byte[3];

    internal override string[] AttributeTagNames
    {
      get
      {
        return BevelType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BevelType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "w")]
    public Int64Value Width
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

    [SchemaAttr(0, "h")]
    public Int64Value Height
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

    [SchemaAttr(0, "prst")]
    public EnumValue<BevelPresetValues> Preset
    {
      get
      {
        return (EnumValue<BevelPresetValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "w" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "h" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "prst" == name)
        return (OpenXmlSimpleType) new EnumValue<BevelPresetValues>();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}
