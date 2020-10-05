// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PositionalTab
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class PositionalTab : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "alignment",
      "relativeTo",
      "leader"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "ptab";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11620;

    public override string LocalName
    {
      get
      {
        return "ptab";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11620;
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
        return PositionalTab.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PositionalTab.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "alignment")]
    public EnumValue<AbsolutePositionTabAlignmentValues> Alignment
    {
      get
      {
        return (EnumValue<AbsolutePositionTabAlignmentValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "relativeTo")]
    public EnumValue<AbsolutePositionTabPositioningBaseValues> RelativeTo
    {
      get
      {
        return (EnumValue<AbsolutePositionTabPositioningBaseValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "leader")]
    public EnumValue<AbsolutePositionTabLeaderCharValues> Leader
    {
      get
      {
        return (EnumValue<AbsolutePositionTabLeaderCharValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "alignment" == name)
        return (OpenXmlSimpleType) new EnumValue<AbsolutePositionTabAlignmentValues>();
      if (23 == (int) namespaceId && "relativeTo" == name)
        return (OpenXmlSimpleType) new EnumValue<AbsolutePositionTabPositioningBaseValues>();
      if (23 == (int) namespaceId && "leader" == name)
        return (OpenXmlSimpleType) new EnumValue<AbsolutePositionTabLeaderCharValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PositionalTab>(deep);
    }
  }
}
