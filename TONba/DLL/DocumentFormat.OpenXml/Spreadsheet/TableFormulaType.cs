// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TableFormulaType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class TableFormulaType : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "array",
      "space"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 0,
      (byte) 1
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return TableFormulaType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableFormulaType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "array")]
    public BooleanValue Array
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(1, "space")]
    public EnumValue<SpaceProcessingModeValues> Space
    {
      get
      {
        return (EnumValue<SpaceProcessingModeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "array" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if (1 == (int) namespaceId && "space" == name)
        return (OpenXmlSimpleType) new EnumValue<SpaceProcessingModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    protected TableFormulaType()
    {
    }

    protected TableFormulaType(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }
  }
}
