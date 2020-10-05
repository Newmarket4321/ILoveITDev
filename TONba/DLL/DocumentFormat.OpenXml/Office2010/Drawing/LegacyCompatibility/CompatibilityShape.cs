// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility.CompatibilityShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class CompatibilityShape : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "spid"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "compatSp";
    private const byte tagNsId = 63;
    internal const int ElementTypeIdConst = 13208;

    public override string LocalName
    {
      get
      {
        return "compatSp";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 63;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13208;
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
        return CompatibilityShape.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CompatibilityShape.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "spid" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CompatibilityShape>(deep);
    }
  }
}
