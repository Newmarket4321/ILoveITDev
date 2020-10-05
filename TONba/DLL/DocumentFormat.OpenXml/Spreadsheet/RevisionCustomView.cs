// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RevisionCustomView
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class RevisionCustomView : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "guid",
      "action"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "rcv";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11221;

    public override string LocalName
    {
      get
      {
        return "rcv";
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
        return 11221;
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
        return RevisionCustomView.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RevisionCustomView.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "guid")]
    public StringValue Guid
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

    [SchemaAttr(0, "action")]
    public EnumValue<RevisionActionValues> Action
    {
      get
      {
        return (EnumValue<RevisionActionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "guid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "action" == name)
        return (OpenXmlSimpleType) new EnumValue<RevisionActionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RevisionCustomView>(deep);
    }
  }
}
