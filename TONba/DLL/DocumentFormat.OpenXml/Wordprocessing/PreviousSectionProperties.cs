// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PreviousSectionProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (FormProtection))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PageNumberType))]
  [ChildElementInfo(typeof (FootnoteProperties))]
  [ChildElementInfo(typeof (EndnoteProperties))]
  [ChildElementInfo(typeof (SectionType))]
  [ChildElementInfo(typeof (PageSize))]
  [ChildElementInfo(typeof (PageMargin))]
  [ChildElementInfo(typeof (PaperSource))]
  [ChildElementInfo(typeof (PageBorders))]
  [ChildElementInfo(typeof (LineNumberType))]
  [ChildElementInfo(typeof (TextDirection))]
  [ChildElementInfo(typeof (FootnoteColumns), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (VerticalTextAlignmentOnPage))]
  [ChildElementInfo(typeof (NoEndnote))]
  [ChildElementInfo(typeof (TitlePage))]
  [ChildElementInfo(typeof (Columns))]
  [ChildElementInfo(typeof (BiDi))]
  [ChildElementInfo(typeof (GutterOnRight))]
  [ChildElementInfo(typeof (DocGrid))]
  [ChildElementInfo(typeof (PrinterSettingsReference))]
  public class PreviousSectionProperties : OpenXmlCompositeElement
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
    private static readonly string[] eleTagNames = new string[20]
    {
      "footnotePr",
      "endnotePr",
      "type",
      "pgSz",
      "pgMar",
      "paperSrc",
      "pgBorders",
      "lnNumType",
      "pgNumType",
      "cols",
      "formProt",
      "vAlign",
      "noEndnote",
      "titlePg",
      "textDirection",
      "bidi",
      "rtlGutter",
      "docGrid",
      "printerSettings",
      "footnoteColumns"
    };
    private static readonly byte[] eleNamespaceIds = new byte[20]
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
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 69
    };
    private const string tagName = "sectPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11771;

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
        return 11771;
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
        return PreviousSectionProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PreviousSectionProperties.attributeNamespaceIds;
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

    public PreviousSectionProperties()
    {
    }

    public PreviousSectionProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PreviousSectionProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PreviousSectionProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
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
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PreviousSectionProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PreviousSectionProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FootnoteProperties FootnoteProperties
    {
      get
      {
        return this.GetElement<FootnoteProperties>(0);
      }
      set
      {
        this.SetElement<FootnoteProperties>(0, value);
      }
    }

    public EndnoteProperties EndnoteProperties
    {
      get
      {
        return this.GetElement<EndnoteProperties>(1);
      }
      set
      {
        this.SetElement<EndnoteProperties>(1, value);
      }
    }

    public SectionType SectionType
    {
      get
      {
        return this.GetElement<SectionType>(2);
      }
      set
      {
        this.SetElement<SectionType>(2, value);
      }
    }

    public PageSize PageSize
    {
      get
      {
        return this.GetElement<PageSize>(3);
      }
      set
      {
        this.SetElement<PageSize>(3, value);
      }
    }

    public PageMargin PageMargin
    {
      get
      {
        return this.GetElement<PageMargin>(4);
      }
      set
      {
        this.SetElement<PageMargin>(4, value);
      }
    }

    public PaperSource PaperSource
    {
      get
      {
        return this.GetElement<PaperSource>(5);
      }
      set
      {
        this.SetElement<PaperSource>(5, value);
      }
    }

    public PageBorders PageBorders
    {
      get
      {
        return this.GetElement<PageBorders>(6);
      }
      set
      {
        this.SetElement<PageBorders>(6, value);
      }
    }

    public LineNumberType LineNumberType
    {
      get
      {
        return this.GetElement<LineNumberType>(7);
      }
      set
      {
        this.SetElement<LineNumberType>(7, value);
      }
    }

    public PageNumberType PageNumberType
    {
      get
      {
        return this.GetElement<PageNumberType>(8);
      }
      set
      {
        this.SetElement<PageNumberType>(8, value);
      }
    }

    public Columns Columns
    {
      get
      {
        return this.GetElement<Columns>(9);
      }
      set
      {
        this.SetElement<Columns>(9, value);
      }
    }

    public FormProtection FormProtection
    {
      get
      {
        return this.GetElement<FormProtection>(10);
      }
      set
      {
        this.SetElement<FormProtection>(10, value);
      }
    }

    public VerticalTextAlignmentOnPage VerticalTextAlignmentOnPage
    {
      get
      {
        return this.GetElement<VerticalTextAlignmentOnPage>(11);
      }
      set
      {
        this.SetElement<VerticalTextAlignmentOnPage>(11, value);
      }
    }

    public NoEndnote NoEndnote
    {
      get
      {
        return this.GetElement<NoEndnote>(12);
      }
      set
      {
        this.SetElement<NoEndnote>(12, value);
      }
    }

    public TitlePage TitlePage
    {
      get
      {
        return this.GetElement<TitlePage>(13);
      }
      set
      {
        this.SetElement<TitlePage>(13, value);
      }
    }

    public TextDirection TextDirection
    {
      get
      {
        return this.GetElement<TextDirection>(14);
      }
      set
      {
        this.SetElement<TextDirection>(14, value);
      }
    }

    public BiDi BiDi
    {
      get
      {
        return this.GetElement<BiDi>(15);
      }
      set
      {
        this.SetElement<BiDi>(15, value);
      }
    }

    public GutterOnRight GutterOnRight
    {
      get
      {
        return this.GetElement<GutterOnRight>(16);
      }
      set
      {
        this.SetElement<GutterOnRight>(16, value);
      }
    }

    public DocGrid DocGrid
    {
      get
      {
        return this.GetElement<DocGrid>(17);
      }
      set
      {
        this.SetElement<DocGrid>(17, value);
      }
    }

    public PrinterSettingsReference PrinterSettingsReference
    {
      get
      {
        return this.GetElement<PrinterSettingsReference>(18);
      }
      set
      {
        this.SetElement<PrinterSettingsReference>(18, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public FootnoteColumns FootnoteColumns
    {
      get
      {
        return this.GetElement<FootnoteColumns>(19);
      }
      set
      {
        this.SetElement<FootnoteColumns>(19, value);
      }
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
      return (OpenXmlElement) this.CloneImp<PreviousSectionProperties>(deep);
    }
  }
}
