// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class ArtisticCement : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "trans",
      "crackSpacing"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "artisticCement";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12799;

    public override string LocalName
    {
      get
      {
        return "artisticCement";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 48;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12799;
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
        return ArtisticCement.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ArtisticCement.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "crackSpacing")]
    public Int32Value CrackSpacing
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "trans" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "crackSpacing" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ArtisticCement>(deep);
    }
  }
}
