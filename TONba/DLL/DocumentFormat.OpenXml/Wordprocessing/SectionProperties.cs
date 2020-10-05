// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SectionProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (PageNumberType))]
  [ChildElementInfo(typeof (Columns))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FooterReference))]
  [ChildElementInfo(typeof (FootnoteProperties))]
  [ChildElementInfo(typeof (EndnoteProperties))]
  [ChildElementInfo(typeof (SectionType))]
  [ChildElementInfo(typeof (PageSize))]
  [ChildElementInfo(typeof (PageMargin))]
  [ChildElementInfo(typeof (PaperSource))]
  [ChildElementInfo(typeof (PageBorders))]
  [ChildElementInfo(typeof (LineNumberType))]
  [ChildElementInfo(typeof (TextDirection))]
  [ChildElementInfo(typeof (SectionPropertiesChange))]
  [ChildElementInfo(typeof (FormProtection))]
  [ChildElementInfo(typeof (VerticalTextAlignmentOnPage))]
  [ChildElementInfo(typeof (NoEndnote))]
  [ChildElementInfo(typeof (TitlePage))]
  [ChildElementInfo(typeof (HeaderReference))]
  [ChildElementInfo(typeof (BiDi))]
  [ChildElementInfo(typeof (GutterOnRight))]
  [ChildElementInfo(typeof (DocGrid))]
  [ChildElementInfo(typeof (PrinterSettingsReference))]
  [ChildElementInfo(typeof (FootnoteColumns), FileFormatVersions.Office2013)]
  public class SectionProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "rsidRPr",
      "rsidDel",
      "rsidR",
      "rsidSect"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "sectPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11786;

    public override string LocalName
    {
      get
      {
        return "sectPr";
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
        return 11786;
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
        return SectionProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SectionProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "rsidRPr")]
    public HexBinaryValue RsidRPr
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

    [SchemaAttr(23, "rsidDel")]
    public HexBinaryValue RsidDel
    {
      get
      {
        return (HexBinaryValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "rsidR")]
    public HexBinaryValue RsidR
    {
      get
      {
        return (HexBinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "rsidSect")]
    public HexBinaryValue RsidSect
    {
      get
      {
        return (HexBinaryValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public SectionProperties()
    {
    }

    public SectionProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SectionProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SectionProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "headerReference" == name)
        return (OpenXmlElement) new HeaderReference();
      if (23 == (int) namespaceId && "footerReference" == name)
        return (OpenXmlElement) new FooterReference();
      if (23 == (int) namespaceId && "footnotePr" == name)
        return (OpenXmlElement) new FootnoteProperties();
      if (23 == (int) namespaceId && "endnotePr" == name)
        return (OpenXmlElement) new EndnoteProperties();
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlElement) new SectionType();
      if (23 == (int) namespaceId && "pgSz" == name)
        return (OpenXmlElement) new PageSize();
      if (23 == (int) namespaceId && "pgMar" == name)
        return (OpenXmlElement) new PageMargin();
      if (23 == (int) namespaceId && "paperSrc" == name)
        return (OpenXmlElement) new PaperSource();
      if (23 == (int) namespaceId && "pgBorders" == name)
        return (OpenXmlElement) new PageBorders();
      if (23 == (int) namespaceId && "lnNumType" == name)
        return (OpenXmlElement) new LineNumberType();
      if (23 == (int) namespaceId && "pgNumType" == name)
        return (OpenXmlElement) new PageNumberType();
      if (23 == (int) namespaceId && "cols" == name)
        return (OpenXmlElement) new Columns();
      if (23 == (int) namespaceId && "formProt" == name)
        return (OpenXmlElement) new FormProtection();
      if (23 == (int) namespaceId && "vAlign" == name)
        return (OpenXmlElement) new VerticalTextAlignmentOnPage();
      if (23 == (int) namespaceId && "noEndnote" == name)
        return (OpenXmlElement) new NoEndnote();
      if (23 == (int) namespaceId && "titlePg" == name)
        return (OpenXmlElement) new TitlePage();
      if (23 == (int) namespaceId && "textDirection" == name)
        return (OpenXmlElement) new TextDirection();
      if (23 == (int) namespaceId && "bidi" == name)
        return (OpenXmlElement) new BiDi();
      if (23 == (int) namespaceId && "rtlGutter" == name)
        return (OpenXmlElement) new GutterOnRight();
      if (23 == (int) namespaceId && "docGrid" == name)
        return (OpenXmlElement) new DocGrid();
      if (23 == (int) namespaceId && "printerSettings" == name)
        return (OpenXmlElement) new PrinterSettingsReference();
      if (69 == (int) namespaceId && "footnoteColumns" == name)
        return (OpenXmlElement) new FootnoteColumns();
      if (23 == (int) namespaceId && "sectPrChange" == name)
        return (OpenXmlElement) new SectionPropertiesChange();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rsidRPr" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "rsidDel" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "rsidR" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "rsidSect" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SectionProperties>(deep);
    }
  }
}
