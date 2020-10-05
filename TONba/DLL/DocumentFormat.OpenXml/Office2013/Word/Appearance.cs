// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.Appearance
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Appearance : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 69
    };
    private const string tagName = "appearance";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13337;

    public override string LocalName
    {
      get
      {
        return "appearance";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13337;
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
        return Appearance.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Appearance.attributeNamespaceIds;
      }
    }

    [SchemaAttr(69, "val")]
    public EnumValue<SdtAppearance> Val
    {
      get
      {
        return (EnumValue<SdtAppearance>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<SdtAppearance>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Appearance>(deep);
    }
  }
}
