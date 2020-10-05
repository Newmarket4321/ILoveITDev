// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ExtendedProperties.Properties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
  [ChildElementInfo(typeof (HiddenSlides))]
  [ChildElementInfo(typeof (HeadingPairs))]
  [ChildElementInfo(typeof (TitlesOfParts))]
  [ChildElementInfo(typeof (TotalTime))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Template))]
  [ChildElementInfo(typeof (Manager))]
  [ChildElementInfo(typeof (Company))]
  [ChildElementInfo(typeof (Pages))]
  [ChildElementInfo(typeof (Words))]
  [ChildElementInfo(typeof (Characters))]
  [ChildElementInfo(typeof (PresentationFormat))]
  [ChildElementInfo(typeof (Lines))]
  [ChildElementInfo(typeof (Paragraphs))]
  [ChildElementInfo(typeof (Slides))]
  [ChildElementInfo(typeof (Notes))]
  [ChildElementInfo(typeof (MultimediaClips))]
  [ChildElementInfo(typeof (ScaleCrop))]
  [ChildElementInfo(typeof (LinksUpToDate))]
  [ChildElementInfo(typeof (CharactersWithSpaces))]
  [ChildElementInfo(typeof (SharedDocument))]
  [ChildElementInfo(typeof (HyperlinkBase))]
  [ChildElementInfo(typeof (HyperlinkList))]
  [ChildElementInfo(typeof (HyperlinksChanged))]
  [ChildElementInfo(typeof (DigitalSignature))]
  [ChildElementInfo(typeof (Application))]
  [ChildElementInfo(typeof (ApplicationVersion))]
  [ChildElementInfo(typeof (DocumentSecurity))]
  public class Properties : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[27]
    {
      nameof (Template),
      nameof (Manager),
      nameof (Company),
      nameof (Pages),
      nameof (Words),
      nameof (Characters),
      nameof (PresentationFormat),
      nameof (Lines),
      nameof (Paragraphs),
      nameof (Slides),
      nameof (Notes),
      nameof (TotalTime),
      nameof (HiddenSlides),
      "MMClips",
      nameof (ScaleCrop),
      nameof (HeadingPairs),
      nameof (TitlesOfParts),
      nameof (LinksUpToDate),
      nameof (CharactersWithSpaces),
      "SharedDoc",
      nameof (HyperlinkBase),
      "HLinks",
      nameof (HyperlinksChanged),
      "DigSig",
      nameof (Application),
      "AppVersion",
      "DocSecurity"
    };
    private static readonly byte[] eleNamespaceIds = new byte[27]
    {
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3
    };
    private const string tagName = "Properties";
    private const byte tagNsId = 3;
    internal const int ElementTypeIdConst = 11064;

    public override string LocalName
    {
      get
      {
        return nameof (Properties);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 3;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11064;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Properties(ExtendedFilePropertiesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ExtendedFilePropertiesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
    {
      get
      {
        return this.OpenXmlPart as ExtendedFilePropertiesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Properties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Properties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Properties(string outerXml)
      : base(outerXml)
    {
    }

    public Properties()
    {
    }

    public void Save(ExtendedFilePropertiesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (3 == (int) namespaceId && "Template" == name)
        return (OpenXmlElement) new Template();
      if (3 == (int) namespaceId && "Manager" == name)
        return (OpenXmlElement) new Manager();
      if (3 == (int) namespaceId && "Company" == name)
        return (OpenXmlElement) new Company();
      if (3 == (int) namespaceId && "Pages" == name)
        return (OpenXmlElement) new Pages();
      if (3 == (int) namespaceId && "Words" == name)
        return (OpenXmlElement) new Words();
      if (3 == (int) namespaceId && "Characters" == name)
        return (OpenXmlElement) new Characters();
      if (3 == (int) namespaceId && "PresentationFormat" == name)
        return (OpenXmlElement) new PresentationFormat();
      if (3 == (int) namespaceId && "Lines" == name)
        return (OpenXmlElement) new Lines();
      if (3 == (int) namespaceId && "Paragraphs" == name)
        return (OpenXmlElement) new Paragraphs();
      if (3 == (int) namespaceId && "Slides" == name)
        return (OpenXmlElement) new Slides();
      if (3 == (int) namespaceId && "Notes" == name)
        return (OpenXmlElement) new Notes();
      if (3 == (int) namespaceId && "TotalTime" == name)
        return (OpenXmlElement) new TotalTime();
      if (3 == (int) namespaceId && "HiddenSlides" == name)
        return (OpenXmlElement) new HiddenSlides();
      if (3 == (int) namespaceId && "MMClips" == name)
        return (OpenXmlElement) new MultimediaClips();
      if (3 == (int) namespaceId && "ScaleCrop" == name)
        return (OpenXmlElement) new ScaleCrop();
      if (3 == (int) namespaceId && "HeadingPairs" == name)
        return (OpenXmlElement) new HeadingPairs();
      if (3 == (int) namespaceId && "TitlesOfParts" == name)
        return (OpenXmlElement) new TitlesOfParts();
      if (3 == (int) namespaceId && "LinksUpToDate" == name)
        return (OpenXmlElement) new LinksUpToDate();
      if (3 == (int) namespaceId && "CharactersWithSpaces" == name)
        return (OpenXmlElement) new CharactersWithSpaces();
      if (3 == (int) namespaceId && "SharedDoc" == name)
        return (OpenXmlElement) new SharedDocument();
      if (3 == (int) namespaceId && "HyperlinkBase" == name)
        return (OpenXmlElement) new HyperlinkBase();
      if (3 == (int) namespaceId && "HLinks" == name)
        return (OpenXmlElement) new HyperlinkList();
      if (3 == (int) namespaceId && "HyperlinksChanged" == name)
        return (OpenXmlElement) new HyperlinksChanged();
      if (3 == (int) namespaceId && "DigSig" == name)
        return (OpenXmlElement) new DigitalSignature();
      if (3 == (int) namespaceId && "Application" == name)
        return (OpenXmlElement) new Application();
      if (3 == (int) namespaceId && "AppVersion" == name)
        return (OpenXmlElement) new ApplicationVersion();
      if (3 == (int) namespaceId && "DocSecurity" == name)
        return (OpenXmlElement) new DocumentSecurity();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Properties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Properties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public Template Template
    {
      get
      {
        return this.GetElement<Template>(0);
      }
      set
      {
        this.SetElement<Template>(0, value);
      }
    }

    public Manager Manager
    {
      get
      {
        return this.GetElement<Manager>(1);
      }
      set
      {
        this.SetElement<Manager>(1, value);
      }
    }

    public Company Company
    {
      get
      {
        return this.GetElement<Company>(2);
      }
      set
      {
        this.SetElement<Company>(2, value);
      }
    }

    public Pages Pages
    {
      get
      {
        return this.GetElement<Pages>(3);
      }
      set
      {
        this.SetElement<Pages>(3, value);
      }
    }

    public Words Words
    {
      get
      {
        return this.GetElement<Words>(4);
      }
      set
      {
        this.SetElement<Words>(4, value);
      }
    }

    public Characters Characters
    {
      get
      {
        return this.GetElement<Characters>(5);
      }
      set
      {
        this.SetElement<Characters>(5, value);
      }
    }

    public PresentationFormat PresentationFormat
    {
      get
      {
        return this.GetElement<PresentationFormat>(6);
      }
      set
      {
        this.SetElement<PresentationFormat>(6, value);
      }
    }

    public Lines Lines
    {
      get
      {
        return this.GetElement<Lines>(7);
      }
      set
      {
        this.SetElement<Lines>(7, value);
      }
    }

    public Paragraphs Paragraphs
    {
      get
      {
        return this.GetElement<Paragraphs>(8);
      }
      set
      {
        this.SetElement<Paragraphs>(8, value);
      }
    }

    public Slides Slides
    {
      get
      {
        return this.GetElement<Slides>(9);
      }
      set
      {
        this.SetElement<Slides>(9, value);
      }
    }

    public Notes Notes
    {
      get
      {
        return this.GetElement<Notes>(10);
      }
      set
      {
        this.SetElement<Notes>(10, value);
      }
    }

    public TotalTime TotalTime
    {
      get
      {
        return this.GetElement<TotalTime>(11);
      }
      set
      {
        this.SetElement<TotalTime>(11, value);
      }
    }

    public HiddenSlides HiddenSlides
    {
      get
      {
        return this.GetElement<HiddenSlides>(12);
      }
      set
      {
        this.SetElement<HiddenSlides>(12, value);
      }
    }

    public MultimediaClips MultimediaClips
    {
      get
      {
        return this.GetElement<MultimediaClips>(13);
      }
      set
      {
        this.SetElement<MultimediaClips>(13, value);
      }
    }

    public ScaleCrop ScaleCrop
    {
      get
      {
        return this.GetElement<ScaleCrop>(14);
      }
      set
      {
        this.SetElement<ScaleCrop>(14, value);
      }
    }

    public HeadingPairs HeadingPairs
    {
      get
      {
        return this.GetElement<HeadingPairs>(15);
      }
      set
      {
        this.SetElement<HeadingPairs>(15, value);
      }
    }

    public TitlesOfParts TitlesOfParts
    {
      get
      {
        return this.GetElement<TitlesOfParts>(16);
      }
      set
      {
        this.SetElement<TitlesOfParts>(16, value);
      }
    }

    public LinksUpToDate LinksUpToDate
    {
      get
      {
        return this.GetElement<LinksUpToDate>(17);
      }
      set
      {
        this.SetElement<LinksUpToDate>(17, value);
      }
    }

    public CharactersWithSpaces CharactersWithSpaces
    {
      get
      {
        return this.GetElement<CharactersWithSpaces>(18);
      }
      set
      {
        this.SetElement<CharactersWithSpaces>(18, value);
      }
    }

    public SharedDocument SharedDocument
    {
      get
      {
        return this.GetElement<SharedDocument>(19);
      }
      set
      {
        this.SetElement<SharedDocument>(19, value);
      }
    }

    public HyperlinkBase HyperlinkBase
    {
      get
      {
        return this.GetElement<HyperlinkBase>(20);
      }
      set
      {
        this.SetElement<HyperlinkBase>(20, value);
      }
    }

    public HyperlinkList HyperlinkList
    {
      get
      {
        return this.GetElement<HyperlinkList>(21);
      }
      set
      {
        this.SetElement<HyperlinkList>(21, value);
      }
    }

    public HyperlinksChanged HyperlinksChanged
    {
      get
      {
        return this.GetElement<HyperlinksChanged>(22);
      }
      set
      {
        this.SetElement<HyperlinksChanged>(22, value);
      }
    }

    public DigitalSignature DigitalSignature
    {
      get
      {
        return this.GetElement<DigitalSignature>(23);
      }
      set
      {
        this.SetElement<DigitalSignature>(23, value);
      }
    }

    public Application Application
    {
      get
      {
        return this.GetElement<Application>(24);
      }
      set
      {
        this.SetElement<Application>(24, value);
      }
    }

    public ApplicationVersion ApplicationVersion
    {
      get
      {
        return this.GetElement<ApplicationVersion>(25);
      }
      set
      {
        this.SetElement<ApplicationVersion>(25, value);
      }
    }

    public DocumentSecurity DocumentSecurity
    {
      get
      {
        return this.GetElement<DocumentSecurity>(26);
      }
      set
      {
        this.SetElement<DocumentSecurity>(26, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Properties>(deep);
    }
  }
}
