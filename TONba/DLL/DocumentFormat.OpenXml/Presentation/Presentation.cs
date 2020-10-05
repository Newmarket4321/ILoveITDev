// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Presentation
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (EmbeddedFontList))]
  [ChildElementInfo(typeof (CustomerDataList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SlideMasterIdList))]
  [ChildElementInfo(typeof (NotesMasterIdList))]
  [ChildElementInfo(typeof (HandoutMasterIdList))]
  [ChildElementInfo(typeof (SlideIdList))]
  [ChildElementInfo(typeof (SlideSize))]
  [ChildElementInfo(typeof (NotesSize))]
  [ChildElementInfo(typeof (CustomShowList))]
  [ChildElementInfo(typeof (PhotoAlbum))]
  [ChildElementInfo(typeof (Kinsoku))]
  [ChildElementInfo(typeof (DefaultTextStyle))]
  [ChildElementInfo(typeof (ModificationVerifier))]
  [ChildElementInfo(typeof (PresentationExtensionList))]
  public class Presentation : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "serverZoom",
      "firstSlideNum",
      "showSpecialPlsOnTitleSld",
      "rtl",
      "removePersonalInfoOnSave",
      "compatMode",
      "strictFirstAndLastChars",
      "embedTrueTypeFonts",
      "saveSubsetFonts",
      "autoCompressPictures",
      "bookmarkIdSeed",
      "conformance"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private static readonly string[] eleTagNames = new string[14]
    {
      "sldMasterIdLst",
      "notesMasterIdLst",
      "handoutMasterIdLst",
      "sldIdLst",
      "sldSz",
      "notesSz",
      "embeddedFontLst",
      "custShowLst",
      "photoAlbum",
      "custDataLst",
      "kinsoku",
      "defaultTextStyle",
      "modifyVerifier",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[14]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "presentation";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12236;

    public override string LocalName
    {
      get
      {
        return "presentation";
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
        return 12236;
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
        return DocumentFormat.OpenXml.Presentation.Presentation.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Presentation.Presentation.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "serverZoom")]
    public Int32Value ServerZoom
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "firstSlideNum")]
    public Int32Value FirstSlideNum
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showSpecialPlsOnTitleSld")]
    public BooleanValue ShowSpecialPlaceholderOnTitleSlide
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rtl")]
    public BooleanValue RightToLeft
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "removePersonalInfoOnSave")]
    public BooleanValue RemovePersonalInfoOnSave
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "compatMode")]
    public BooleanValue CompatibilityMode
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "strictFirstAndLastChars")]
    public BooleanValue StrictFirstAndLastChars
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "embedTrueTypeFonts")]
    public BooleanValue EmbedTrueTypeFonts
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "saveSubsetFonts")]
    public BooleanValue SaveSubsetFonts
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoCompressPictures")]
    public BooleanValue AutoCompressPictures
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bookmarkIdSeed")]
    public UInt32Value BookmarkIdSeed
    {
      get
      {
        return (UInt32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "conformance")]
    public EnumValue<ConformanceClassValues> Conformance
    {
      get
      {
        return (EnumValue<ConformanceClassValues>) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    internal Presentation(PresentationPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(PresentationPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public PresentationPart PresentationPart
    {
      get
      {
        return this.OpenXmlPart as PresentationPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Presentation(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Presentation(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Presentation(string outerXml)
      : base(outerXml)
    {
    }

    public Presentation()
    {
    }

    public void Save(PresentationPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "sldMasterIdLst" == name)
        return (OpenXmlElement) new SlideMasterIdList();
      if (24 == (int) namespaceId && "notesMasterIdLst" == name)
        return (OpenXmlElement) new NotesMasterIdList();
      if (24 == (int) namespaceId && "handoutMasterIdLst" == name)
        return (OpenXmlElement) new HandoutMasterIdList();
      if (24 == (int) namespaceId && "sldIdLst" == name)
        return (OpenXmlElement) new SlideIdList();
      if (24 == (int) namespaceId && "sldSz" == name)
        return (OpenXmlElement) new SlideSize();
      if (24 == (int) namespaceId && "notesSz" == name)
        return (OpenXmlElement) new NotesSize();
      if (24 == (int) namespaceId && "embeddedFontLst" == name)
        return (OpenXmlElement) new EmbeddedFontList();
      if (24 == (int) namespaceId && "custShowLst" == name)
        return (OpenXmlElement) new CustomShowList();
      if (24 == (int) namespaceId && "photoAlbum" == name)
        return (OpenXmlElement) new PhotoAlbum();
      if (24 == (int) namespaceId && "custDataLst" == name)
        return (OpenXmlElement) new CustomerDataList();
      if (24 == (int) namespaceId && "kinsoku" == name)
        return (OpenXmlElement) new Kinsoku();
      if (24 == (int) namespaceId && "defaultTextStyle" == name)
        return (OpenXmlElement) new DefaultTextStyle();
      if (24 == (int) namespaceId && "modifyVerifier" == name)
        return (OpenXmlElement) new ModificationVerifier();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PresentationExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Presentation.Presentation.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Presentation.Presentation.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SlideMasterIdList SlideMasterIdList
    {
      get
      {
        return this.GetElement<SlideMasterIdList>(0);
      }
      set
      {
        this.SetElement<SlideMasterIdList>(0, value);
      }
    }

    public NotesMasterIdList NotesMasterIdList
    {
      get
      {
        return this.GetElement<NotesMasterIdList>(1);
      }
      set
      {
        this.SetElement<NotesMasterIdList>(1, value);
      }
    }

    public HandoutMasterIdList HandoutMasterIdList
    {
      get
      {
        return this.GetElement<HandoutMasterIdList>(2);
      }
      set
      {
        this.SetElement<HandoutMasterIdList>(2, value);
      }
    }

    public SlideIdList SlideIdList
    {
      get
      {
        return this.GetElement<SlideIdList>(3);
      }
      set
      {
        this.SetElement<SlideIdList>(3, value);
      }
    }

    public SlideSize SlideSize
    {
      get
      {
        return this.GetElement<SlideSize>(4);
      }
      set
      {
        this.SetElement<SlideSize>(4, value);
      }
    }

    public NotesSize NotesSize
    {
      get
      {
        return this.GetElement<NotesSize>(5);
      }
      set
      {
        this.SetElement<NotesSize>(5, value);
      }
    }

    public EmbeddedFontList EmbeddedFontList
    {
      get
      {
        return this.GetElement<EmbeddedFontList>(6);
      }
      set
      {
        this.SetElement<EmbeddedFontList>(6, value);
      }
    }

    public CustomShowList CustomShowList
    {
      get
      {
        return this.GetElement<CustomShowList>(7);
      }
      set
      {
        this.SetElement<CustomShowList>(7, value);
      }
    }

    public PhotoAlbum PhotoAlbum
    {
      get
      {
        return this.GetElement<PhotoAlbum>(8);
      }
      set
      {
        this.SetElement<PhotoAlbum>(8, value);
      }
    }

    public CustomerDataList CustomerDataList
    {
      get
      {
        return this.GetElement<CustomerDataList>(9);
      }
      set
      {
        this.SetElement<CustomerDataList>(9, value);
      }
    }

    public Kinsoku Kinsoku
    {
      get
      {
        return this.GetElement<Kinsoku>(10);
      }
      set
      {
        this.SetElement<Kinsoku>(10, value);
      }
    }

    public DefaultTextStyle DefaultTextStyle
    {
      get
      {
        return this.GetElement<DefaultTextStyle>(11);
      }
      set
      {
        this.SetElement<DefaultTextStyle>(11, value);
      }
    }

    public ModificationVerifier ModificationVerifier
    {
      get
      {
        return this.GetElement<ModificationVerifier>(12);
      }
      set
      {
        this.SetElement<ModificationVerifier>(12, value);
      }
    }

    public PresentationExtensionList PresentationExtensionList
    {
      get
      {
        return this.GetElement<PresentationExtensionList>(13);
      }
      set
      {
        this.SetElement<PresentationExtensionList>(13, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "serverZoom" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "firstSlideNum" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "showSpecialPlsOnTitleSld" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rtl" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "removePersonalInfoOnSave" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "compatMode" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "strictFirstAndLastChars" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "embedTrueTypeFonts" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "saveSubsetFonts" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoCompressPictures" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "bookmarkIdSeed" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "conformance" == name)
        return (OpenXmlSimpleType) new EnumValue<ConformanceClassValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Presentation.Presentation>(deep);
    }
  }
}
