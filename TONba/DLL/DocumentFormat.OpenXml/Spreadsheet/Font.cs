// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Font
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Condense))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Bold))]
  [ChildElementInfo(typeof (Italic))]
  [ChildElementInfo(typeof (Strike))]
  [ChildElementInfo(typeof (Extend))]
  [ChildElementInfo(typeof (Outline))]
  [ChildElementInfo(typeof (Shadow))]
  [ChildElementInfo(typeof (Underline))]
  [ChildElementInfo(typeof (VerticalTextAlignment))]
  [ChildElementInfo(typeof (FontSize))]
  [ChildElementInfo(typeof (Color))]
  [ChildElementInfo(typeof (FontName))]
  [ChildElementInfo(typeof (FontFamilyNumbering))]
  [ChildElementInfo(typeof (FontCharSet))]
  [ChildElementInfo(typeof (FontScheme))]
  public class Font : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[15]
    {
      "b",
      "i",
      "strike",
      "condense",
      "extend",
      "outline",
      "shadow",
      "u",
      "vertAlign",
      "sz",
      "color",
      "name",
      "family",
      "charset",
      "scheme"
    };
    private static readonly byte[] eleNamespaceIds = new byte[15]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "font";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11317;

    public override string LocalName
    {
      get
      {
        return "font";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11317;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Font()
    {
    }

    public Font(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Font(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Font(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "b" == name)
        return (OpenXmlElement) new Bold();
      if (22 == (int) namespaceId && "i" == name)
        return (OpenXmlElement) new Italic();
      if (22 == (int) namespaceId && "strike" == name)
        return (OpenXmlElement) new Strike();
      if (22 == (int) namespaceId && "condense" == name)
        return (OpenXmlElement) new Condense();
      if (22 == (int) namespaceId && "extend" == name)
        return (OpenXmlElement) new Extend();
      if (22 == (int) namespaceId && "outline" == name)
        return (OpenXmlElement) new Outline();
      if (22 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new Shadow();
      if (22 == (int) namespaceId && "u" == name)
        return (OpenXmlElement) new Underline();
      if (22 == (int) namespaceId && "vertAlign" == name)
        return (OpenXmlElement) new VerticalTextAlignment();
      if (22 == (int) namespaceId && "sz" == name)
        return (OpenXmlElement) new FontSize();
      if (22 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      if (22 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new FontName();
      if (22 == (int) namespaceId && "family" == name)
        return (OpenXmlElement) new FontFamilyNumbering();
      if (22 == (int) namespaceId && "charset" == name)
        return (OpenXmlElement) new FontCharSet();
      if (22 == (int) namespaceId && "scheme" == name)
        return (OpenXmlElement) new FontScheme();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Font.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Font.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Bold Bold
    {
      get
      {
        return this.GetElement<Bold>(0);
      }
      set
      {
        this.SetElement<Bold>(0, value);
      }
    }

    public Italic Italic
    {
      get
      {
        return this.GetElement<Italic>(1);
      }
      set
      {
        this.SetElement<Italic>(1, value);
      }
    }

    public Strike Strike
    {
      get
      {
        return this.GetElement<Strike>(2);
      }
      set
      {
        this.SetElement<Strike>(2, value);
      }
    }

    public Condense Condense
    {
      get
      {
        return this.GetElement<Condense>(3);
      }
      set
      {
        this.SetElement<Condense>(3, value);
      }
    }

    public Extend Extend
    {
      get
      {
        return this.GetElement<Extend>(4);
      }
      set
      {
        this.SetElement<Extend>(4, value);
      }
    }

    public Outline Outline
    {
      get
      {
        return this.GetElement<Outline>(5);
      }
      set
      {
        this.SetElement<Outline>(5, value);
      }
    }

    public Shadow Shadow
    {
      get
      {
        return this.GetElement<Shadow>(6);
      }
      set
      {
        this.SetElement<Shadow>(6, value);
      }
    }

    public Underline Underline
    {
      get
      {
        return this.GetElement<Underline>(7);
      }
      set
      {
        this.SetElement<Underline>(7, value);
      }
    }

    public VerticalTextAlignment VerticalTextAlignment
    {
      get
      {
        return this.GetElement<VerticalTextAlignment>(8);
      }
      set
      {
        this.SetElement<VerticalTextAlignment>(8, value);
      }
    }

    public FontSize FontSize
    {
      get
      {
        return this.GetElement<FontSize>(9);
      }
      set
      {
        this.SetElement<FontSize>(9, value);
      }
    }

    public Color Color
    {
      get
      {
        return this.GetElement<Color>(10);
      }
      set
      {
        this.SetElement<Color>(10, value);
      }
    }

    public FontName FontName
    {
      get
      {
        return this.GetElement<FontName>(11);
      }
      set
      {
        this.SetElement<FontName>(11, value);
      }
    }

    public FontFamilyNumbering FontFamilyNumbering
    {
      get
      {
        return this.GetElement<FontFamilyNumbering>(12);
      }
      set
      {
        this.SetElement<FontFamilyNumbering>(12, value);
      }
    }

    public FontCharSet FontCharSet
    {
      get
      {
        return this.GetElement<FontCharSet>(13);
      }
      set
      {
        this.SetElement<FontCharSet>(13, value);
      }
    }

    public FontScheme FontScheme
    {
      get
      {
        return this.GetElement<FontScheme>(14);
      }
      set
      {
        this.SetElement<FontScheme>(14, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Font>(deep);
    }
  }
}
