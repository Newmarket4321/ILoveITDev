// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SlideMaster
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Transition))]
  [ChildElementInfo(typeof (SlideMasterExtensionList))]
  [ChildElementInfo(typeof (CommonSlideData))]
  [ChildElementInfo(typeof (ColorMap))]
  [ChildElementInfo(typeof (SlideLayoutIdList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Timing))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (TextStyles))]
  public class SlideMaster : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "preserve"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[8]
    {
      "cSld",
      "clrMap",
      "sldLayoutIdLst",
      "transition",
      "timing",
      "hf",
      "txStyles",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "sldMaster";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12240;

    public override string LocalName
    {
      get
      {
        return "sldMaster";
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
        return 12240;
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
        return SlideMaster.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlideMaster.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "preserve")]
    public BooleanValue Preserve
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal SlideMaster(SlideMasterPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlideMasterPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlideMasterPart SlideMasterPart
    {
      get
      {
        return this.OpenXmlPart as SlideMasterPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public SlideMaster(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlideMaster(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlideMaster(string outerXml)
      : base(outerXml)
    {
    }

    public SlideMaster()
    {
    }

    public void Save(SlideMasterPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cSld" == name)
        return (OpenXmlElement) new CommonSlideData();
      if (24 == (int) namespaceId && "clrMap" == name)
        return (OpenXmlElement) new ColorMap();
      if (24 == (int) namespaceId && "sldLayoutIdLst" == name)
        return (OpenXmlElement) new SlideLayoutIdList();
      if (24 == (int) namespaceId && "transition" == name)
        return (OpenXmlElement) new Transition();
      if (24 == (int) namespaceId && "timing" == name)
        return (OpenXmlElement) new Timing();
      if (24 == (int) namespaceId && "hf" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (24 == (int) namespaceId && "txStyles" == name)
        return (OpenXmlElement) new TextStyles();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new SlideMasterExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SlideMaster.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SlideMaster.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonSlideData CommonSlideData
    {
      get
      {
        return this.GetElement<CommonSlideData>(0);
      }
      set
      {
        this.SetElement<CommonSlideData>(0, value);
      }
    }

    public ColorMap ColorMap
    {
      get
      {
        return this.GetElement<ColorMap>(1);
      }
      set
      {
        this.SetElement<ColorMap>(1, value);
      }
    }

    public SlideLayoutIdList SlideLayoutIdList
    {
      get
      {
        return this.GetElement<SlideLayoutIdList>(2);
      }
      set
      {
        this.SetElement<SlideLayoutIdList>(2, value);
      }
    }

    public Transition Transition
    {
      get
      {
        return this.GetElement<Transition>(3);
      }
      set
      {
        this.SetElement<Transition>(3, value);
      }
    }

    public Timing Timing
    {
      get
      {
        return this.GetElement<Timing>(4);
      }
      set
      {
        this.SetElement<Timing>(4, value);
      }
    }

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(5);
      }
      set
      {
        this.SetElement<HeaderFooter>(5, value);
      }
    }

    public TextStyles TextStyles
    {
      get
      {
        return this.GetElement<TextStyles>(6);
      }
      set
      {
        this.SetElement<TextStyles>(6, value);
      }
    }

    public SlideMasterExtensionList SlideMasterExtensionList
    {
      get
      {
        return this.GetElement<SlideMasterExtensionList>(7);
      }
      set
      {
        this.SetElement<SlideMasterExtensionList>(7, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "preserve" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlideMaster>(deep);
    }
  }
}
