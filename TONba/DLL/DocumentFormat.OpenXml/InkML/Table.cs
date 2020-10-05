// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Table
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  public class Table : OpenXmlLeafTextElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "id",
      "apply",
      "interpolation"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "table";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12716;

    public override string LocalName
    {
      get
      {
        return "table";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12716;
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
        return Table.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Table.attributeNamespaceIds;
      }
    }

    [SchemaAttr(1, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "apply")]
    public EnumValue<TableApplyValues> Apply
    {
      get
      {
        return (EnumValue<TableApplyValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "interpolation")]
    public EnumValue<TableInterpolationValues> Interpolation
    {
      get
      {
        return (EnumValue<TableInterpolationValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Table()
    {
    }

    public Table(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "apply" == name)
        return (OpenXmlSimpleType) new EnumValue<TableApplyValues>();
      if ((int) namespaceId == 0 && "interpolation" == name)
        return (OpenXmlSimpleType) new EnumValue<TableInterpolationValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Table>(deep);
    }
  }
}
