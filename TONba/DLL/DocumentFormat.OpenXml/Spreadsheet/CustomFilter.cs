// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CustomFilter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class CustomFilter : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "operator",
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "customFilter";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11118;

    public override string LocalName
    {
      get
      {
        return "customFilter";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11118;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return CustomFilter.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CustomFilter.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "operator")]
    public EnumValue<FilterOperatorValues> Operator
    {
      get
      {
        return (EnumValue<FilterOperatorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "val")]
    public StringValue Val
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "operator" == name)
        return (OpenXmlSimpleType) new EnumValue<FilterOperatorValues>();
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomFilter>(deep);
    }
  }
}
