// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Paragraph
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TextMath), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (EndParagraphRunProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Field))]
  [ChildElementInfo(typeof (ParagraphProperties))]
  [ChildElementInfo(typeof (Run))]
  [ChildElementInfo(typeof (Break))]
  public class Paragraph : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "pPr",
      "r",
      "br",
      "fld",
      "m",
      "endParaRPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 48,
      (byte) 10
    };
    private const string tagName = "p";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10301;

    public override string LocalName
    {
      get
      {
        return "p";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10301;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Paragraph()
    {
    }

    public Paragraph(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Paragraph(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Paragraph(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "pPr" == name)
        return (OpenXmlElement) new ParagraphProperties();
      if (10 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new Run();
      if (10 == (int) namespaceId && "br" == name)
        return (OpenXmlElement) new Break();
      if (10 == (int) namespaceId && "fld" == name)
        return (OpenXmlElement) new Field();
      if (48 == (int) namespaceId && "m" == name)
        return (OpenXmlElement) new TextMath();
      if (10 == (int) namespaceId && "endParaRPr" == name)
        return (OpenXmlElement) new EndParagraphRunProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Paragraph.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Paragraph.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ParagraphProperties ParagraphProperties
    {
      get
      {
        return this.GetElement<ParagraphProperties>(0);
      }
      set
      {
        this.SetElement<ParagraphProperties>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Paragraph>(deep);
    }
  }
}
