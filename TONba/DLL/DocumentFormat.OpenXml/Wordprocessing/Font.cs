// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Font
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (FontSignature))]
  [ChildElementInfo(typeof (EmbedRegularFont))]
  [ChildElementInfo(typeof (NotTrueType))]
  [ChildElementInfo(typeof (Pitch))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Panose1Number))]
  [ChildElementInfo(typeof (FontCharSet))]
  [ChildElementInfo(typeof (FontFamily))]
  [ChildElementInfo(typeof (AltName))]
  [ChildElementInfo(typeof (EmbedBoldFont))]
  [ChildElementInfo(typeof (EmbedItalicFont))]
  [ChildElementInfo(typeof (EmbedBoldItalicFont))]
  public class Font : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[11]
    {
      "altName",
      "panose1",
      "charset",
      "family",
      "notTrueType",
      "pitch",
      "sig",
      "embedRegular",
      "embedBold",
      "embedItalic",
      "embedBoldItalic"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
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
      (byte) 23
    };
    private const string tagName = "font";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11963;

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
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11963;
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
        return Font.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Font.attributeNamespaceIds;
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
      if (23 == (int) namespaceId && "altName" == name)
        return (OpenXmlElement) new AltName();
      if (23 == (int) namespaceId && "panose1" == name)
        return (OpenXmlElement) new Panose1Number();
      if (23 == (int) namespaceId && "charset" == name)
        return (OpenXmlElement) new FontCharSet();
      if (23 == (int) namespaceId && "family" == name)
        return (OpenXmlElement) new FontFamily();
      if (23 == (int) namespaceId && "notTrueType" == name)
        return (OpenXmlElement) new NotTrueType();
      if (23 == (int) namespaceId && "pitch" == name)
        return (OpenXmlElement) new Pitch();
      if (23 == (int) namespaceId && "sig" == name)
        return (OpenXmlElement) new FontSignature();
      if (23 == (int) namespaceId && "embedRegular" == name)
        return (OpenXmlElement) new EmbedRegularFont();
      if (23 == (int) namespaceId && "embedBold" == name)
        return (OpenXmlElement) new EmbedBoldFont();
      if (23 == (int) namespaceId && "embedItalic" == name)
        return (OpenXmlElement) new EmbedItalicFont();
      if (23 == (int) namespaceId && "embedBoldItalic" == name)
        return (OpenXmlElement) new EmbedBoldItalicFont();
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

    public AltName AltName
    {
      get
      {
        return this.GetElement<AltName>(0);
      }
      set
      {
        this.SetElement<AltName>(0, value);
      }
    }

    public Panose1Number Panose1Number
    {
      get
      {
        return this.GetElement<Panose1Number>(1);
      }
      set
      {
        this.SetElement<Panose1Number>(1, value);
      }
    }

    public FontCharSet FontCharSet
    {
      get
      {
        return this.GetElement<FontCharSet>(2);
      }
      set
      {
        this.SetElement<FontCharSet>(2, value);
      }
    }

    public FontFamily FontFamily
    {
      get
      {
        return this.GetElement<FontFamily>(3);
      }
      set
      {
        this.SetElement<FontFamily>(3, value);
      }
    }

    public NotTrueType NotTrueType
    {
      get
      {
        return this.GetElement<NotTrueType>(4);
      }
      set
      {
        this.SetElement<NotTrueType>(4, value);
      }
    }

    public Pitch Pitch
    {
      get
      {
        return this.GetElement<Pitch>(5);
      }
      set
      {
        this.SetElement<Pitch>(5, value);
      }
    }

    public FontSignature FontSignature
    {
      get
      {
        return this.GetElement<FontSignature>(6);
      }
      set
      {
        this.SetElement<FontSignature>(6, value);
      }
    }

    public EmbedRegularFont EmbedRegularFont
    {
      get
      {
        return this.GetElement<EmbedRegularFont>(7);
      }
      set
      {
        this.SetElement<EmbedRegularFont>(7, value);
      }
    }

    public EmbedBoldFont EmbedBoldFont
    {
      get
      {
        return this.GetElement<EmbedBoldFont>(8);
      }
      set
      {
        this.SetElement<EmbedBoldFont>(8, value);
      }
    }

    public EmbedItalicFont EmbedItalicFont
    {
      get
      {
        return this.GetElement<EmbedItalicFont>(9);
      }
      set
      {
        this.SetElement<EmbedItalicFont>(9, value);
      }
    }

    public EmbedBoldItalicFont EmbedBoldItalicFont
    {
      get
      {
        return this.GetElement<EmbedBoldItalicFont>(10);
      }
      set
      {
        this.SetElement<EmbedBoldItalicFont>(10, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Font>(deep);
    }
  }
}
