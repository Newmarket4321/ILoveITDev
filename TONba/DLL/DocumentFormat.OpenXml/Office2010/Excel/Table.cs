// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.Table
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class Table : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "altText",
      "altTextSummary"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "table";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12979;

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
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12979;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
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

    [SchemaAttr(0, "altText")]
    public StringValue AltText
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

    [SchemaAttr(0, "altTextSummary")]
    public StringValue AltTextSummary
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
      if ((int) namespaceId == 0 && "altText" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "altTextSummary" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Table>(deep);
    }
  }
}
