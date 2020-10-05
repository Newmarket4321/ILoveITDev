// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.ServerFormat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class ServerFormat : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "culture",
      "format"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "serverFormat";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13414;

    public override string LocalName
    {
      get
      {
        return "serverFormat";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13414;
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
        return ServerFormat.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ServerFormat.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "culture")]
    public StringValue Culture
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

    [SchemaAttr(0, "format")]
    public StringValue Format
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
      if ((int) namespaceId == 0 && "culture" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "format" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ServerFormat>(deep);
    }
  }
}
