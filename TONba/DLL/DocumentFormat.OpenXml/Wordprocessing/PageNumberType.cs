// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PageNumberType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class PageNumberType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "fmt",
      "start",
      "chapStyle",
      "chapSep"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "pgNumType";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11744;

    public override string LocalName
    {
      get
      {
        return "pgNumType";
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
        return 11744;
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
        return PageNumberType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PageNumberType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "fmt")]
    public EnumValue<NumberFormatValues> Format
    {
      get
      {
        return (EnumValue<NumberFormatValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "start")]
    public Int32Value Start
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

    [SchemaAttr(23, "chapStyle")]
    public ByteValue ChapterStyle
    {
      get
      {
        return (ByteValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "chapSep")]
    public EnumValue<ChapterSeparatorValues> ChapterSeparator
    {
      get
      {
        return (EnumValue<ChapterSeparatorValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "fmt" == name)
        return (OpenXmlSimpleType) new EnumValue<NumberFormatValues>();
      if (23 == (int) namespaceId && "start" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "chapStyle" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if (23 == (int) namespaceId && "chapSep" == name)
        return (OpenXmlSimpleType) new EnumValue<ChapterSeparatorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PageNumberType>(deep);
    }
  }
}
