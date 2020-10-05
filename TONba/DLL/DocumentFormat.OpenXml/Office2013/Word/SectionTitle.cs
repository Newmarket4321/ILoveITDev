// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.SectionTitle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class SectionTitle : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "sectionTitle";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13351;

    public override string LocalName
    {
      get
      {
        return "sectionTitle";
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
        return 13351;
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
        return SectionTitle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SectionTitle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public StringValue Val
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
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SectionTitle>(deep);
    }
  }
}
