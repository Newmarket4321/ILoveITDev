// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Run
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (AnnotationReferenceMark))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FootnoteReferenceMark))]
  [ChildElementInfo(typeof (EndnoteReferenceMark))]
  [ChildElementInfo(typeof (LastRenderedPageBreak))]
  [ChildElementInfo(typeof (Break))]
  [ChildElementInfo(typeof (Text))]
  [ChildElementInfo(typeof (DeletedText))]
  [ChildElementInfo(typeof (FieldCode))]
  [ChildElementInfo(typeof (DeletedFieldCode))]
  [ChildElementInfo(typeof (NoBreakHyphen))]
  [ChildElementInfo(typeof (SoftHyphen))]
  [ChildElementInfo(typeof (DayShort))]
  [ChildElementInfo(typeof (MonthShort))]
  [ChildElementInfo(typeof (YearShort))]
  [ChildElementInfo(typeof (DayLong))]
  [ChildElementInfo(typeof (MonthLong))]
  [ChildElementInfo(typeof (YearLong))]
  [ChildElementInfo(typeof (EmbeddedObject))]
  [ChildElementInfo(typeof (PositionalTab))]
  [ChildElementInfo(typeof (SeparatorMark))]
  [ChildElementInfo(typeof (ContinuationSeparatorMark))]
  [ChildElementInfo(typeof (SymbolChar))]
  [ChildElementInfo(typeof (PageNumber))]
  [ChildElementInfo(typeof (CarriageReturn))]
  [ChildElementInfo(typeof (TabChar))]
  [ChildElementInfo(typeof (RunProperties))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (FieldChar))]
  [ChildElementInfo(typeof (Ruby))]
  [ChildElementInfo(typeof (FootnoteReference))]
  [ChildElementInfo(typeof (EndnoteReference))]
  [ChildElementInfo(typeof (CommentReference))]
  [ChildElementInfo(typeof (Drawing))]
  public class Run : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "rsidRPr",
      "rsidDel",
      "rsidR"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[33]
    {
      "rPr",
      "br",
      "t",
      "delText",
      "instrText",
      "delInstrText",
      "noBreakHyphen",
      "softHyphen",
      "dayShort",
      "monthShort",
      "yearShort",
      "dayLong",
      "monthLong",
      "yearLong",
      "annotationRef",
      "footnoteRef",
      "endnoteRef",
      "separator",
      "continuationSeparator",
      "sym",
      "pgNum",
      "cr",
      "tab",
      "object",
      "pict",
      "fldChar",
      "ruby",
      "footnoteReference",
      "endnoteReference",
      "commentReference",
      "drawing",
      "ptab",
      "lastRenderedPageBreak"
    };
    private static readonly byte[] eleNamespaceIds = new byte[33]
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
    private const string tagName = "r";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11668;

    public override string LocalName
    {
      get
      {
        return "r";
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
        return 11668;
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
        return Run.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Run.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "rsidRPr")]
    public HexBinaryValue RsidRunProperties
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
    public HexBinaryValue RsidRunDeletion
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
    public HexBinaryValue RsidRunAddition
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

    public Run()
    {
    }

    public Run(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Run(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Run(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      if (23 == (int) namespaceId && "br" == name)
        return (OpenXmlElement) new Break();
      if (23 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new Text();
      if (23 == (int) namespaceId && "delText" == name)
        return (OpenXmlElement) new DeletedText();
      if (23 == (int) namespaceId && "instrText" == name)
        return (OpenXmlElement) new FieldCode();
      if (23 == (int) namespaceId && "delInstrText" == name)
        return (OpenXmlElement) new DeletedFieldCode();
      if (23 == (int) namespaceId && "noBreakHyphen" == name)
        return (OpenXmlElement) new NoBreakHyphen();
      if (23 == (int) namespaceId && "softHyphen" == name)
        return (OpenXmlElement) new SoftHyphen();
      if (23 == (int) namespaceId && "dayShort" == name)
        return (OpenXmlElement) new DayShort();
      if (23 == (int) namespaceId && "monthShort" == name)
        return (OpenXmlElement) new MonthShort();
      if (23 == (int) namespaceId && "yearShort" == name)
        return (OpenXmlElement) new YearShort();
      if (23 == (int) namespaceId && "dayLong" == name)
        return (OpenXmlElement) new DayLong();
      if (23 == (int) namespaceId && "monthLong" == name)
        return (OpenXmlElement) new MonthLong();
      if (23 == (int) namespaceId && "yearLong" == name)
        return (OpenXmlElement) new YearLong();
      if (23 == (int) namespaceId && "annotationRef" == name)
        return (OpenXmlElement) new AnnotationReferenceMark();
      if (23 == (int) namespaceId && "footnoteRef" == name)
        return (OpenXmlElement) new FootnoteReferenceMark();
      if (23 == (int) namespaceId && "endnoteRef" == name)
        return (OpenXmlElement) new EndnoteReferenceMark();
      if (23 == (int) namespaceId && "separator" == name)
        return (OpenXmlElement) new SeparatorMark();
      if (23 == (int) namespaceId && "continuationSeparator" == name)
        return (OpenXmlElement) new ContinuationSeparatorMark();
      if (23 == (int) namespaceId && "sym" == name)
        return (OpenXmlElement) new SymbolChar();
      if (23 == (int) namespaceId && "pgNum" == name)
        return (OpenXmlElement) new PageNumber();
      if (23 == (int) namespaceId && "cr" == name)
        return (OpenXmlElement) new CarriageReturn();
      if (23 == (int) namespaceId && "tab" == name)
        return (OpenXmlElement) new TabChar();
      if (23 == (int) namespaceId && "object" == name)
        return (OpenXmlElement) new EmbeddedObject();
      if (23 == (int) namespaceId && "pict" == name)
        return (OpenXmlElement) new Picture();
      if (23 == (int) namespaceId && "fldChar" == name)
        return (OpenXmlElement) new FieldChar();
      if (23 == (int) namespaceId && "ruby" == name)
        return (OpenXmlElement) new Ruby();
      if (23 == (int) namespaceId && "footnoteReference" == name)
        return (OpenXmlElement) new FootnoteReference();
      if (23 == (int) namespaceId && "endnoteReference" == name)
        return (OpenXmlElement) new EndnoteReference();
      if (23 == (int) namespaceId && "commentReference" == name)
        return (OpenXmlElement) new CommentReference();
      if (23 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new Drawing();
      if (23 == (int) namespaceId && "ptab" == name)
        return (OpenXmlElement) new PositionalTab();
      if (23 == (int) namespaceId && "lastRenderedPageBreak" == name)
        return (OpenXmlElement) new LastRenderedPageBreak();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Run.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Run.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunProperties RunProperties
    {
      get
      {
        return this.GetElement<RunProperties>(0);
      }
      set
      {
        this.SetElement<RunProperties>(0, value);
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
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Run>(deep);
    }
  }
}
