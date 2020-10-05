// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class NumberingFormat : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "formatCode",
      "sourceLinked"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "numFmt";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13210;

    public override string LocalName
    {
      get
      {
        return "numFmt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13210;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return NumberingFormat.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NumberingFormat.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "formatCode")]
    public StringValue FormatCode
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

    [SchemaAttr(0, "sourceLinked")]
    public BooleanValue SourceLinked
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "formatCode" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sourceLinked" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberingFormat>(deep);
    }
  }
}
