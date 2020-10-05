// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.BookmarkStart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class BookmarkStart : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "name",
      "colFirst",
      "colLast",
      "displacedByCustomXml",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "bookmarkStart";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11540;

    public override string LocalName
    {
      get
      {
        return "bookmarkStart";
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
        return 11540;
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
        return BookmarkStart.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BookmarkStart.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "name")]
    public StringValue Name
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

    [SchemaAttr(23, "colFirst")]
    public Int32Value ColumnFirst
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

    [SchemaAttr(23, "colLast")]
    public Int32Value ColumnLast
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "displacedByCustomXml")]
    public EnumValue<DisplacedByCustomXmlValues> DisplacedByCustomXml
    {
      get
      {
        return (EnumValue<DisplacedByCustomXmlValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "colFirst" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "colLast" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "displacedByCustomXml" == name)
        return (OpenXmlSimpleType) new EnumValue<DisplacedByCustomXmlValues>();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BookmarkStart>(deep);
    }
  }
}
