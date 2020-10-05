// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DatabaseProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class DatabaseProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "connection",
      "command",
      "serverCommand",
      "commandType"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "dbPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11440;

    public override string LocalName
    {
      get
      {
        return "dbPr";
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
        return 11440;
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
        return DatabaseProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DatabaseProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "connection")]
    public StringValue Connection
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

    [SchemaAttr(0, "command")]
    public StringValue Command
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

    [SchemaAttr(0, "serverCommand")]
    public StringValue ServerCommand
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "commandType")]
    public UInt32Value CommandType
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "connection" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "command" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "serverCommand" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "commandType" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DatabaseProperties>(deep);
    }
  }
}
