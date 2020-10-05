// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RubyProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RubyAlign))]
  [ChildElementInfo(typeof (PhoneticGuideTextFontSize))]
  [ChildElementInfo(typeof (PhoneticGuideRaise))]
  [ChildElementInfo(typeof (PhoneticGuideBaseTextSize))]
  [ChildElementInfo(typeof (LanguageId))]
  [ChildElementInfo(typeof (Dirty))]
  public class RubyProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "rubyAlign",
      "hps",
      "hpsRaise",
      "hpsBaseText",
      "lid",
      "dirty"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "rubyPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11821;

    public override string LocalName
    {
      get
      {
        return "rubyPr";
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
        return 11821;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RubyProperties()
    {
    }

    public RubyProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RubyProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RubyProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rubyAlign" == name)
        return (OpenXmlElement) new RubyAlign();
      if (23 == (int) namespaceId && "hps" == name)
        return (OpenXmlElement) new PhoneticGuideTextFontSize();
      if (23 == (int) namespaceId && "hpsRaise" == name)
        return (OpenXmlElement) new PhoneticGuideRaise();
      if (23 == (int) namespaceId && "hpsBaseText" == name)
        return (OpenXmlElement) new PhoneticGuideBaseTextSize();
      if (23 == (int) namespaceId && "lid" == name)
        return (OpenXmlElement) new LanguageId();
      if (23 == (int) namespaceId && "dirty" == name)
        return (OpenXmlElement) new Dirty();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RubyProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RubyProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RubyAlign RubyAlign
    {
      get
      {
        return this.GetElement<RubyAlign>(0);
      }
      set
      {
        this.SetElement<RubyAlign>(0, value);
      }
    }

    public PhoneticGuideTextFontSize PhoneticGuideTextFontSize
    {
      get
      {
        return this.GetElement<PhoneticGuideTextFontSize>(1);
      }
      set
      {
        this.SetElement<PhoneticGuideTextFontSize>(1, value);
      }
    }

    public PhoneticGuideRaise PhoneticGuideRaise
    {
      get
      {
        return this.GetElement<PhoneticGuideRaise>(2);
      }
      set
      {
        this.SetElement<PhoneticGuideRaise>(2, value);
      }
    }

    public PhoneticGuideBaseTextSize PhoneticGuideBaseTextSize
    {
      get
      {
        return this.GetElement<PhoneticGuideBaseTextSize>(3);
      }
      set
      {
        this.SetElement<PhoneticGuideBaseTextSize>(3, value);
      }
    }

    public LanguageId LanguageId
    {
      get
      {
        return this.GetElement<LanguageId>(4);
      }
      set
      {
        this.SetElement<LanguageId>(4, value);
      }
    }

    public Dirty Dirty
    {
      get
      {
        return this.GetElement<Dirty>(5);
      }
      set
      {
        this.SetElement<Dirty>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RubyProperties>(deep);
    }
  }
}
