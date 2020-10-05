// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.RelationshipIds
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  public class RelationshipIds : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "dm",
      "lo",
      "qs",
      "cs"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 19,
      (byte) 19,
      (byte) 19,
      (byte) 19
    };
    private const string tagName = "relIds";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10689;

    public override string LocalName
    {
      get
      {
        return "relIds";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10689;
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
        return RelationshipIds.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RelationshipIds.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "dm")]
    public StringValue DataPart
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

    [SchemaAttr(19, "lo")]
    public StringValue LayoutPart
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

    [SchemaAttr(19, "qs")]
    public StringValue StylePart
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

    [SchemaAttr(19, "cs")]
    public StringValue ColorPart
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "dm" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "lo" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "qs" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "cs" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RelationshipIds>(deep);
    }
  }
}
