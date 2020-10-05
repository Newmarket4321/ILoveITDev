// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.EmbeddedFont
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Font))]
  [ChildElementInfo(typeof (BoldFont))]
  [ChildElementInfo(typeof (BoldItalicFont))]
  [ChildElementInfo(typeof (RegularFont))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ItalicFont))]
  public class EmbeddedFont : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "font",
      "regular",
      "bold",
      "italic",
      "boldItalic"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "embeddedFont";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12320;

    public override string LocalName
    {
      get
      {
        return "embeddedFont";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12320;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public EmbeddedFont()
    {
    }

    public EmbeddedFont(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EmbeddedFont(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EmbeddedFont(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "font" == name)
        return (OpenXmlElement) new Font();
      if (24 == (int) namespaceId && "regular" == name)
        return (OpenXmlElement) new RegularFont();
      if (24 == (int) namespaceId && "bold" == name)
        return (OpenXmlElement) new BoldFont();
      if (24 == (int) namespaceId && "italic" == name)
        return (OpenXmlElement) new ItalicFont();
      if (24 == (int) namespaceId && "boldItalic" == name)
        return (OpenXmlElement) new BoldItalicFont();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return EmbeddedFont.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return EmbeddedFont.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Font Font
    {
      get
      {
        return this.GetElement<Font>(0);
      }
      set
      {
        this.SetElement<Font>(0, value);
      }
    }

    public RegularFont RegularFont
    {
      get
      {
        return this.GetElement<RegularFont>(1);
      }
      set
      {
        this.SetElement<RegularFont>(1, value);
      }
    }

    public BoldFont BoldFont
    {
      get
      {
        return this.GetElement<BoldFont>(2);
      }
      set
      {
        this.SetElement<BoldFont>(2, value);
      }
    }

    public ItalicFont ItalicFont
    {
      get
      {
        return this.GetElement<ItalicFont>(3);
      }
      set
      {
        this.SetElement<ItalicFont>(3, value);
      }
    }

    public BoldItalicFont BoldItalicFont
    {
      get
      {
        return this.GetElement<BoldItalicFont>(4);
      }
      set
      {
        this.SetElement<BoldItalicFont>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EmbeddedFont>(deep);
    }
  }
}
