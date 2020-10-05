// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.CellMerge
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class CellMerge : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "vMerge",
      "vMergeOrig",
      "author",
      "date",
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
    private const string tagName = "cellMerge";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11539;

    public override string LocalName
    {
      get
      {
        return "cellMerge";
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
        return 11539;
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
        return CellMerge.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CellMerge.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "vMerge")]
    public EnumValue<VerticalMergeRevisionValues> VerticalMerge
    {
      get
      {
        return (EnumValue<VerticalMergeRevisionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "vMergeOrig")]
    public EnumValue<VerticalMergeRevisionValues> VerticalMergeOriginal
    {
      get
      {
        return (EnumValue<VerticalMergeRevisionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "author")]
    public StringValue Author
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

    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
      get
      {
        return (DateTimeValue) this.Attributes[3];
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
      if (23 == (int) namespaceId && "vMerge" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalMergeRevisionValues>();
      if (23 == (int) namespaceId && "vMergeOrig" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalMergeRevisionValues>();
      if (23 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CellMerge>(deep);
    }
  }
}
