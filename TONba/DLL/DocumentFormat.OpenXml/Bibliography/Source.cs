// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.Source
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [ChildElementInfo(typeof (Department))]
  [ChildElementInfo(typeof (Pages))]
  [ChildElementInfo(typeof (AbbreviatedCaseNumber))]
  [ChildElementInfo(typeof (AlbumTitle))]
  [ChildElementInfo(typeof (AuthorList))]
  [ChildElementInfo(typeof (BookTitle))]
  [ChildElementInfo(typeof (Broadcaster))]
  [ChildElementInfo(typeof (BroadcastTitle))]
  [ChildElementInfo(typeof (CaseNumber))]
  [ChildElementInfo(typeof (ChapterNumber))]
  [ChildElementInfo(typeof (City))]
  [ChildElementInfo(typeof (Comments))]
  [ChildElementInfo(typeof (ConferenceName))]
  [ChildElementInfo(typeof (CountryRegion))]
  [ChildElementInfo(typeof (Court))]
  [ChildElementInfo(typeof (Day))]
  [ChildElementInfo(typeof (DayAccessed))]
  [ChildElementInfo(typeof (Reporter))]
  [ChildElementInfo(typeof (Distributor))]
  [ChildElementInfo(typeof (Edition))]
  [ChildElementInfo(typeof (GuidString))]
  [ChildElementInfo(typeof (Institution))]
  [ChildElementInfo(typeof (InternetSiteTitle))]
  [ChildElementInfo(typeof (Issue))]
  [ChildElementInfo(typeof (JournalName))]
  [ChildElementInfo(typeof (LcId))]
  [ChildElementInfo(typeof (Medium))]
  [ChildElementInfo(typeof (Month))]
  [ChildElementInfo(typeof (MonthAccessed))]
  [ChildElementInfo(typeof (NumberVolumes))]
  [ChildElementInfo(typeof (Theater))]
  [ChildElementInfo(typeof (Tag))]
  [ChildElementInfo(typeof (PeriodicalTitle))]
  [ChildElementInfo(typeof (ProductionCompany))]
  [ChildElementInfo(typeof (PublicationTitle))]
  [ChildElementInfo(typeof (Publisher))]
  [ChildElementInfo(typeof (RecordingNumber))]
  [ChildElementInfo(typeof (ReferenceOrder))]
  [ChildElementInfo(typeof (PatentType))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ShortTitle))]
  [ChildElementInfo(typeof (StandardNumber))]
  [ChildElementInfo(typeof (StateProvince))]
  [ChildElementInfo(typeof (Station))]
  [ChildElementInfo(typeof (PatentNumber))]
  [ChildElementInfo(typeof (ThesisType))]
  [ChildElementInfo(typeof (Title))]
  [ChildElementInfo(typeof (SourceType))]
  [ChildElementInfo(typeof (UrlString))]
  [ChildElementInfo(typeof (Version))]
  [ChildElementInfo(typeof (Volume))]
  [ChildElementInfo(typeof (Year))]
  [ChildElementInfo(typeof (YearAccessed))]
  public class Source : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[52]
    {
      nameof (AbbreviatedCaseNumber),
      nameof (AlbumTitle),
      "Author",
      nameof (BookTitle),
      nameof (Broadcaster),
      nameof (BroadcastTitle),
      nameof (CaseNumber),
      nameof (ChapterNumber),
      nameof (City),
      nameof (Comments),
      nameof (ConferenceName),
      nameof (CountryRegion),
      nameof (Court),
      nameof (Day),
      nameof (DayAccessed),
      nameof (Department),
      nameof (Distributor),
      nameof (Edition),
      "Guid",
      nameof (Institution),
      nameof (InternetSiteTitle),
      nameof (Issue),
      nameof (JournalName),
      "LCID",
      nameof (Medium),
      nameof (Month),
      nameof (MonthAccessed),
      nameof (NumberVolumes),
      nameof (Pages),
      nameof (PatentNumber),
      nameof (PeriodicalTitle),
      nameof (ProductionCompany),
      nameof (PublicationTitle),
      nameof (Publisher),
      nameof (RecordingNumber),
      "RefOrder",
      nameof (Reporter),
      nameof (SourceType),
      nameof (ShortTitle),
      nameof (StandardNumber),
      nameof (StateProvince),
      nameof (Station),
      nameof (Tag),
      nameof (Theater),
      nameof (ThesisType),
      nameof (Title),
      "Type",
      "URL",
      nameof (Version),
      nameof (Volume),
      nameof (Year),
      nameof (YearAccessed)
    };
    private static readonly byte[] eleNamespaceIds = new byte[52]
    {
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9,
      (byte) 9
    };
    private const string tagName = "Source";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10899;

    public override string LocalName
    {
      get
      {
        return nameof (Source);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10899;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Source()
    {
    }

    public Source(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Source(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Source(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "AbbreviatedCaseNumber" == name)
        return (OpenXmlElement) new AbbreviatedCaseNumber();
      if (9 == (int) namespaceId && "AlbumTitle" == name)
        return (OpenXmlElement) new AlbumTitle();
      if (9 == (int) namespaceId && "Author" == name)
        return (OpenXmlElement) new AuthorList();
      if (9 == (int) namespaceId && "BookTitle" == name)
        return (OpenXmlElement) new BookTitle();
      if (9 == (int) namespaceId && "Broadcaster" == name)
        return (OpenXmlElement) new Broadcaster();
      if (9 == (int) namespaceId && "BroadcastTitle" == name)
        return (OpenXmlElement) new BroadcastTitle();
      if (9 == (int) namespaceId && "CaseNumber" == name)
        return (OpenXmlElement) new CaseNumber();
      if (9 == (int) namespaceId && "ChapterNumber" == name)
        return (OpenXmlElement) new ChapterNumber();
      if (9 == (int) namespaceId && "City" == name)
        return (OpenXmlElement) new City();
      if (9 == (int) namespaceId && "Comments" == name)
        return (OpenXmlElement) new Comments();
      if (9 == (int) namespaceId && "ConferenceName" == name)
        return (OpenXmlElement) new ConferenceName();
      if (9 == (int) namespaceId && "CountryRegion" == name)
        return (OpenXmlElement) new CountryRegion();
      if (9 == (int) namespaceId && "Court" == name)
        return (OpenXmlElement) new Court();
      if (9 == (int) namespaceId && "Day" == name)
        return (OpenXmlElement) new Day();
      if (9 == (int) namespaceId && "DayAccessed" == name)
        return (OpenXmlElement) new DayAccessed();
      if (9 == (int) namespaceId && "Department" == name)
        return (OpenXmlElement) new Department();
      if (9 == (int) namespaceId && "Distributor" == name)
        return (OpenXmlElement) new Distributor();
      if (9 == (int) namespaceId && "Edition" == name)
        return (OpenXmlElement) new Edition();
      if (9 == (int) namespaceId && "Guid" == name)
        return (OpenXmlElement) new GuidString();
      if (9 == (int) namespaceId && "Institution" == name)
        return (OpenXmlElement) new Institution();
      if (9 == (int) namespaceId && "InternetSiteTitle" == name)
        return (OpenXmlElement) new InternetSiteTitle();
      if (9 == (int) namespaceId && "Issue" == name)
        return (OpenXmlElement) new Issue();
      if (9 == (int) namespaceId && "JournalName" == name)
        return (OpenXmlElement) new JournalName();
      if (9 == (int) namespaceId && "LCID" == name)
        return (OpenXmlElement) new LcId();
      if (9 == (int) namespaceId && "Medium" == name)
        return (OpenXmlElement) new Medium();
      if (9 == (int) namespaceId && "Month" == name)
        return (OpenXmlElement) new Month();
      if (9 == (int) namespaceId && "MonthAccessed" == name)
        return (OpenXmlElement) new MonthAccessed();
      if (9 == (int) namespaceId && "NumberVolumes" == name)
        return (OpenXmlElement) new NumberVolumes();
      if (9 == (int) namespaceId && "Pages" == name)
        return (OpenXmlElement) new Pages();
      if (9 == (int) namespaceId && "PatentNumber" == name)
        return (OpenXmlElement) new PatentNumber();
      if (9 == (int) namespaceId && "PeriodicalTitle" == name)
        return (OpenXmlElement) new PeriodicalTitle();
      if (9 == (int) namespaceId && "ProductionCompany" == name)
        return (OpenXmlElement) new ProductionCompany();
      if (9 == (int) namespaceId && "PublicationTitle" == name)
        return (OpenXmlElement) new PublicationTitle();
      if (9 == (int) namespaceId && "Publisher" == name)
        return (OpenXmlElement) new Publisher();
      if (9 == (int) namespaceId && "RecordingNumber" == name)
        return (OpenXmlElement) new RecordingNumber();
      if (9 == (int) namespaceId && "RefOrder" == name)
        return (OpenXmlElement) new ReferenceOrder();
      if (9 == (int) namespaceId && "Reporter" == name)
        return (OpenXmlElement) new Reporter();
      if (9 == (int) namespaceId && "SourceType" == name)
        return (OpenXmlElement) new SourceType();
      if (9 == (int) namespaceId && "ShortTitle" == name)
        return (OpenXmlElement) new ShortTitle();
      if (9 == (int) namespaceId && "StandardNumber" == name)
        return (OpenXmlElement) new StandardNumber();
      if (9 == (int) namespaceId && "StateProvince" == name)
        return (OpenXmlElement) new StateProvince();
      if (9 == (int) namespaceId && "Station" == name)
        return (OpenXmlElement) new Station();
      if (9 == (int) namespaceId && "Tag" == name)
        return (OpenXmlElement) new Tag();
      if (9 == (int) namespaceId && "Theater" == name)
        return (OpenXmlElement) new Theater();
      if (9 == (int) namespaceId && "ThesisType" == name)
        return (OpenXmlElement) new ThesisType();
      if (9 == (int) namespaceId && "Title" == name)
        return (OpenXmlElement) new Title();
      if (9 == (int) namespaceId && "Type" == name)
        return (OpenXmlElement) new PatentType();
      if (9 == (int) namespaceId && "URL" == name)
        return (OpenXmlElement) new UrlString();
      if (9 == (int) namespaceId && "Version" == name)
        return (OpenXmlElement) new Version();
      if (9 == (int) namespaceId && "Volume" == name)
        return (OpenXmlElement) new Volume();
      if (9 == (int) namespaceId && "Year" == name)
        return (OpenXmlElement) new Year();
      if (9 == (int) namespaceId && "YearAccessed" == name)
        return (OpenXmlElement) new YearAccessed();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Source.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Source.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public AbbreviatedCaseNumber AbbreviatedCaseNumber
    {
      get
      {
        return this.GetElement<AbbreviatedCaseNumber>(0);
      }
      set
      {
        this.SetElement<AbbreviatedCaseNumber>(0, value);
      }
    }

    public AlbumTitle AlbumTitle
    {
      get
      {
        return this.GetElement<AlbumTitle>(1);
      }
      set
      {
        this.SetElement<AlbumTitle>(1, value);
      }
    }

    public AuthorList AuthorList
    {
      get
      {
        return this.GetElement<AuthorList>(2);
      }
      set
      {
        this.SetElement<AuthorList>(2, value);
      }
    }

    public BookTitle BookTitle
    {
      get
      {
        return this.GetElement<BookTitle>(3);
      }
      set
      {
        this.SetElement<BookTitle>(3, value);
      }
    }

    public Broadcaster Broadcaster
    {
      get
      {
        return this.GetElement<Broadcaster>(4);
      }
      set
      {
        this.SetElement<Broadcaster>(4, value);
      }
    }

    public BroadcastTitle BroadcastTitle
    {
      get
      {
        return this.GetElement<BroadcastTitle>(5);
      }
      set
      {
        this.SetElement<BroadcastTitle>(5, value);
      }
    }

    public CaseNumber CaseNumber
    {
      get
      {
        return this.GetElement<CaseNumber>(6);
      }
      set
      {
        this.SetElement<CaseNumber>(6, value);
      }
    }

    public ChapterNumber ChapterNumber
    {
      get
      {
        return this.GetElement<ChapterNumber>(7);
      }
      set
      {
        this.SetElement<ChapterNumber>(7, value);
      }
    }

    public City City
    {
      get
      {
        return this.GetElement<City>(8);
      }
      set
      {
        this.SetElement<City>(8, value);
      }
    }

    public Comments Comments
    {
      get
      {
        return this.GetElement<Comments>(9);
      }
      set
      {
        this.SetElement<Comments>(9, value);
      }
    }

    public ConferenceName ConferenceName
    {
      get
      {
        return this.GetElement<ConferenceName>(10);
      }
      set
      {
        this.SetElement<ConferenceName>(10, value);
      }
    }

    public CountryRegion CountryRegion
    {
      get
      {
        return this.GetElement<CountryRegion>(11);
      }
      set
      {
        this.SetElement<CountryRegion>(11, value);
      }
    }

    public Court Court
    {
      get
      {
        return this.GetElement<Court>(12);
      }
      set
      {
        this.SetElement<Court>(12, value);
      }
    }

    public Day Day
    {
      get
      {
        return this.GetElement<Day>(13);
      }
      set
      {
        this.SetElement<Day>(13, value);
      }
    }

    public DayAccessed DayAccessed
    {
      get
      {
        return this.GetElement<DayAccessed>(14);
      }
      set
      {
        this.SetElement<DayAccessed>(14, value);
      }
    }

    public Department Department
    {
      get
      {
        return this.GetElement<Department>(15);
      }
      set
      {
        this.SetElement<Department>(15, value);
      }
    }

    public Distributor Distributor
    {
      get
      {
        return this.GetElement<Distributor>(16);
      }
      set
      {
        this.SetElement<Distributor>(16, value);
      }
    }

    public Edition Edition
    {
      get
      {
        return this.GetElement<Edition>(17);
      }
      set
      {
        this.SetElement<Edition>(17, value);
      }
    }

    public GuidString GuidString
    {
      get
      {
        return this.GetElement<GuidString>(18);
      }
      set
      {
        this.SetElement<GuidString>(18, value);
      }
    }

    public Institution Institution
    {
      get
      {
        return this.GetElement<Institution>(19);
      }
      set
      {
        this.SetElement<Institution>(19, value);
      }
    }

    public InternetSiteTitle InternetSiteTitle
    {
      get
      {
        return this.GetElement<InternetSiteTitle>(20);
      }
      set
      {
        this.SetElement<InternetSiteTitle>(20, value);
      }
    }

    public Issue Issue
    {
      get
      {
        return this.GetElement<Issue>(21);
      }
      set
      {
        this.SetElement<Issue>(21, value);
      }
    }

    public JournalName JournalName
    {
      get
      {
        return this.GetElement<JournalName>(22);
      }
      set
      {
        this.SetElement<JournalName>(22, value);
      }
    }

    public LcId LcId
    {
      get
      {
        return this.GetElement<LcId>(23);
      }
      set
      {
        this.SetElement<LcId>(23, value);
      }
    }

    public Medium Medium
    {
      get
      {
        return this.GetElement<Medium>(24);
      }
      set
      {
        this.SetElement<Medium>(24, value);
      }
    }

    public Month Month
    {
      get
      {
        return this.GetElement<Month>(25);
      }
      set
      {
        this.SetElement<Month>(25, value);
      }
    }

    public MonthAccessed MonthAccessed
    {
      get
      {
        return this.GetElement<MonthAccessed>(26);
      }
      set
      {
        this.SetElement<MonthAccessed>(26, value);
      }
    }

    public NumberVolumes NumberVolumes
    {
      get
      {
        return this.GetElement<NumberVolumes>(27);
      }
      set
      {
        this.SetElement<NumberVolumes>(27, value);
      }
    }

    public Pages Pages
    {
      get
      {
        return this.GetElement<Pages>(28);
      }
      set
      {
        this.SetElement<Pages>(28, value);
      }
    }

    public PatentNumber PatentNumber
    {
      get
      {
        return this.GetElement<PatentNumber>(29);
      }
      set
      {
        this.SetElement<PatentNumber>(29, value);
      }
    }

    public PeriodicalTitle PeriodicalTitle
    {
      get
      {
        return this.GetElement<PeriodicalTitle>(30);
      }
      set
      {
        this.SetElement<PeriodicalTitle>(30, value);
      }
    }

    public ProductionCompany ProductionCompany
    {
      get
      {
        return this.GetElement<ProductionCompany>(31);
      }
      set
      {
        this.SetElement<ProductionCompany>(31, value);
      }
    }

    public PublicationTitle PublicationTitle
    {
      get
      {
        return this.GetElement<PublicationTitle>(32);
      }
      set
      {
        this.SetElement<PublicationTitle>(32, value);
      }
    }

    public Publisher Publisher
    {
      get
      {
        return this.GetElement<Publisher>(33);
      }
      set
      {
        this.SetElement<Publisher>(33, value);
      }
    }

    public RecordingNumber RecordingNumber
    {
      get
      {
        return this.GetElement<RecordingNumber>(34);
      }
      set
      {
        this.SetElement<RecordingNumber>(34, value);
      }
    }

    public ReferenceOrder ReferenceOrder
    {
      get
      {
        return this.GetElement<ReferenceOrder>(35);
      }
      set
      {
        this.SetElement<ReferenceOrder>(35, value);
      }
    }

    public Reporter Reporter
    {
      get
      {
        return this.GetElement<Reporter>(36);
      }
      set
      {
        this.SetElement<Reporter>(36, value);
      }
    }

    public SourceType SourceType
    {
      get
      {
        return this.GetElement<SourceType>(37);
      }
      set
      {
        this.SetElement<SourceType>(37, value);
      }
    }

    public ShortTitle ShortTitle
    {
      get
      {
        return this.GetElement<ShortTitle>(38);
      }
      set
      {
        this.SetElement<ShortTitle>(38, value);
      }
    }

    public StandardNumber StandardNumber
    {
      get
      {
        return this.GetElement<StandardNumber>(39);
      }
      set
      {
        this.SetElement<StandardNumber>(39, value);
      }
    }

    public StateProvince StateProvince
    {
      get
      {
        return this.GetElement<StateProvince>(40);
      }
      set
      {
        this.SetElement<StateProvince>(40, value);
      }
    }

    public Station Station
    {
      get
      {
        return this.GetElement<Station>(41);
      }
      set
      {
        this.SetElement<Station>(41, value);
      }
    }

    public Tag Tag
    {
      get
      {
        return this.GetElement<Tag>(42);
      }
      set
      {
        this.SetElement<Tag>(42, value);
      }
    }

    public Theater Theater
    {
      get
      {
        return this.GetElement<Theater>(43);
      }
      set
      {
        this.SetElement<Theater>(43, value);
      }
    }

    public ThesisType ThesisType
    {
      get
      {
        return this.GetElement<ThesisType>(44);
      }
      set
      {
        this.SetElement<ThesisType>(44, value);
      }
    }

    public Title Title
    {
      get
      {
        return this.GetElement<Title>(45);
      }
      set
      {
        this.SetElement<Title>(45, value);
      }
    }

    public PatentType PatentType
    {
      get
      {
        return this.GetElement<PatentType>(46);
      }
      set
      {
        this.SetElement<PatentType>(46, value);
      }
    }

    public UrlString UrlString
    {
      get
      {
        return this.GetElement<UrlString>(47);
      }
      set
      {
        this.SetElement<UrlString>(47, value);
      }
    }

    public Version Version
    {
      get
      {
        return this.GetElement<Version>(48);
      }
      set
      {
        this.SetElement<Version>(48, value);
      }
    }

    public Volume Volume
    {
      get
      {
        return this.GetElement<Volume>(49);
      }
      set
      {
        this.SetElement<Volume>(49, value);
      }
    }

    public Year Year
    {
      get
      {
        return this.GetElement<Year>(50);
      }
      set
      {
        this.SetElement<Year>(50, value);
      }
    }

    public YearAccessed YearAccessed
    {
      get
      {
        return this.GetElement<YearAccessed>(51);
      }
      set
      {
        this.SetElement<YearAccessed>(51, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Source>(deep);
    }
  }
}
