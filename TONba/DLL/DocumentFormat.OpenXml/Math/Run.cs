// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Run
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (DayShort))]
  [ChildElementInfo(typeof (PageNumber))]
  [ChildElementInfo(typeof (RunProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.RunProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.Break))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.Text))]
  [ChildElementInfo(typeof (DeletedText))]
  [ChildElementInfo(typeof (FieldCode))]
  [ChildElementInfo(typeof (DeletedFieldCode))]
  [ChildElementInfo(typeof (NoBreakHyphen))]
  [ChildElementInfo(typeof (SoftHyphen))]
  [ChildElementInfo(typeof (MonthShort))]
  [ChildElementInfo(typeof (YearShort))]
  [ChildElementInfo(typeof (DayLong))]
  [ChildElementInfo(typeof (MonthLong))]
  [ChildElementInfo(typeof (YearLong))]
  [ChildElementInfo(typeof (AnnotationReferenceMark))]
  [ChildElementInfo(typeof (FootnoteReferenceMark))]
  [ChildElementInfo(typeof (EndnoteReferenceMark))]
  [ChildElementInfo(typeof (SeparatorMark))]
  [ChildElementInfo(typeof (ContinuationSeparatorMark))]
  [ChildElementInfo(typeof (SymbolChar))]
  [ChildElementInfo(typeof (PositionalTab))]
  [ChildElementInfo(typeof (Drawing))]
  [ChildElementInfo(typeof (CommentReference))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (FieldChar))]
  [ChildElementInfo(typeof (Ruby))]
  [ChildElementInfo(typeof (FootnoteReference))]
  [ChildElementInfo(typeof (EndnoteReference))]
  [ChildElementInfo(typeof (EmbeddedObject))]
  [ChildElementInfo(typeof (TabChar))]
  [ChildElementInfo(typeof (CarriageReturn))]
  [ChildElementInfo(typeof (LastRenderedPageBreak))]
  [ChildElementInfo(typeof (Text))]
  public class Run : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[35]
    {
      "rPr",
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
      "lastRenderedPageBreak",
      "t"
    };
    private static readonly byte[] eleNamespaceIds = new byte[35]
    {
      (byte) 21,
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
      (byte) 23,
      (byte) 21
    };
    private const string tagName = "r";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10907;

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
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10907;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
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
      if (21 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.RunProperties();
      if (23 == (int) namespaceId && "br" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.Break();
      if (23 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.Text();
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
      if (21 == (int) namespaceId && "t" == name)
        return (OpenXmlElement) new Text();
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

    public RunProperties MathRunProperties
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

    public DocumentFormat.OpenXml.Wordprocessing.RunProperties RunProperties
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(1);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Run>(deep);
    }
  }
}
