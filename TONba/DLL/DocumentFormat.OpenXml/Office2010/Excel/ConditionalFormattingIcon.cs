// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingIcon
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class ConditionalFormattingIcon : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "iconSet",
      "iconId"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "cfIcon";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13030;

    public override string LocalName
    {
      get
      {
        return "cfIcon";
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
        return 13030;
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
        return ConditionalFormattingIcon.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ConditionalFormattingIcon.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "iconSet")]
    public EnumValue<IconSetTypeValues> IconSet
    {
      get
      {
        return (EnumValue<IconSetTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "iconId")]
    public UInt32Value IconId
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "iconSet" == name)
        return (OpenXmlSimpleType) new EnumValue<IconSetTypeValues>();
      if ((int) namespaceId == 0 && "iconId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConditionalFormattingIcon>(deep);
    }
  }
}
