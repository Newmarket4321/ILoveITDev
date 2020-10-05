// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.PresentationProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (PresentationPropertiesExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HtmlPublishProperties), FileFormatVersions.Office2007)]
  [ChildElementInfo(typeof (WebProperties), FileFormatVersions.Office2007)]
  [ChildElementInfo(typeof (PrintingProperties))]
  [ChildElementInfo(typeof (ShowProperties))]
  [ChildElementInfo(typeof (ColorMostRecentlyUsed))]
  public class PresentationProperties : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "htmlPubPr",
      "webPr",
      "prnPr",
      "showPr",
      "clrMru",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "presentationPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12237;

    public override string LocalName
    {
      get
      {
        return "presentationPr";
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
        return 12237;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal PresentationProperties(PresentationPropertiesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(PresentationPropertiesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public PresentationPropertiesPart PresentationPropertiesPart
    {
      get
      {
        return this.OpenXmlPart as PresentationPropertiesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public PresentationProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PresentationProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PresentationProperties(string outerXml)
      : base(outerXml)
    {
    }

    public PresentationProperties()
    {
    }

    public void Save(PresentationPropertiesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "htmlPubPr" == name)
        return (OpenXmlElement) new HtmlPublishProperties();
      if (24 == (int) namespaceId && "webPr" == name)
        return (OpenXmlElement) new WebProperties();
      if (24 == (int) namespaceId && "prnPr" == name)
        return (OpenXmlElement) new PrintingProperties();
      if (24 == (int) namespaceId && "showPr" == name)
        return (OpenXmlElement) new ShowProperties();
      if (24 == (int) namespaceId && "clrMru" == name)
        return (OpenXmlElement) new ColorMostRecentlyUsed();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PresentationPropertiesExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PresentationProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PresentationProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2007)]
    public HtmlPublishProperties HtmlPublishProperties
    {
      get
      {
        return this.GetElement<HtmlPublishProperties>(0);
      }
      set
      {
        this.SetElement<HtmlPublishProperties>(0, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2007)]
    public WebProperties WebProperties
    {
      get
      {
        return this.GetElement<WebProperties>(1);
      }
      set
      {
        this.SetElement<WebProperties>(1, value);
      }
    }

    public PrintingProperties PrintingProperties
    {
      get
      {
        return this.GetElement<PrintingProperties>(2);
      }
      set
      {
        this.SetElement<PrintingProperties>(2, value);
      }
    }

    public ShowProperties ShowProperties
    {
      get
      {
        return this.GetElement<ShowProperties>(3);
      }
      set
      {
        this.SetElement<ShowProperties>(3, value);
      }
    }

    public ColorMostRecentlyUsed ColorMostRecentlyUsed
    {
      get
      {
        return this.GetElement<ColorMostRecentlyUsed>(4);
      }
      set
      {
        this.SetElement<ColorMostRecentlyUsed>(4, value);
      }
    }

    public PresentationPropertiesExtensionList PresentationPropertiesExtensionList
    {
      get
      {
        return this.GetElement<PresentationPropertiesExtensionList>(5);
      }
      set
      {
        this.SetElement<PresentationPropertiesExtensionList>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PresentationProperties>(deep);
    }
  }
}
