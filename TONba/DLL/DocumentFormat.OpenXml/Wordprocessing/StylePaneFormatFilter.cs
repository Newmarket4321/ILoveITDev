// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class StylePaneFormatFilter : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[16]
    {
      "val",
      "allStyles",
      "customStyles",
      "latentStyles",
      "stylesInUse",
      "headingStyles",
      "numberingStyles",
      "tableStyles",
      "directFormattingOnRuns",
      "directFormattingOnParagraphs",
      "directFormattingOnNumbering",
      "directFormattingOnTables",
      "clearFormatting",
      "top3HeadingStyles",
      "visibleStyles",
      "alternateStyleNames"
    };
    private static byte[] attributeNamespaceIds = new byte[16]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "stylePaneFormatFilter";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12129;

    public override string LocalName
    {
      get
      {
        return "stylePaneFormatFilter";
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
        return 12129;
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
        return StylePaneFormatFilter.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StylePaneFormatFilter.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public HexBinaryValue Val
    {
      get
      {
        return (HexBinaryValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "allStyles")]
    public OnOffValue AllStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "customStyles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue CustomStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "latentStyles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue LatentStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "stylesInUse")]
    public OnOffValue StylesInUse
    {
      get
      {
        return (OnOffValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "headingStyles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue HeadingStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "numberingStyles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue NumberingStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tableStyles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue TableStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "directFormattingOnRuns")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue DirectFormattingOnRuns
    {
      get
      {
        return (OnOffValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "directFormattingOnParagraphs")]
    public OnOffValue DirectFormattingOnParagraphs
    {
      get
      {
        return (OnOffValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "directFormattingOnNumbering")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue DirectFormattingOnNumbering
    {
      get
      {
        return (OnOffValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "directFormattingOnTables")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue DirectFormattingOnTables
    {
      get
      {
        return (OnOffValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "clearFormatting")]
    public OnOffValue ClearFormatting
    {
      get
      {
        return (OnOffValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "top3HeadingStyles")]
    public OnOffValue Top3HeadingStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "visibleStyles")]
    public OnOffValue VisibleStyles
    {
      get
      {
        return (OnOffValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "alternateStyleNames")]
    public OnOffValue AlternateStyleNames
    {
      get
      {
        return (OnOffValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "allStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "customStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "latentStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "stylesInUse" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "headingStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "numberingStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "tableStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "directFormattingOnRuns" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "directFormattingOnParagraphs" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "directFormattingOnNumbering" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "directFormattingOnTables" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "clearFormatting" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "top3HeadingStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "visibleStyles" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "alternateStyleNames" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StylePaneFormatFilter>(deep);
    }
  }
}
