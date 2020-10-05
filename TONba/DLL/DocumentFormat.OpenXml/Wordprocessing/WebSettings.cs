// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.WebSettings
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TargetScreenSize))]
  [ChildElementInfo(typeof (DoNotOrganizeInFolder))]
  [ChildElementInfo(typeof (DoNotSaveAsSingleFile))]
  [ChildElementInfo(typeof (AllowPNG))]
  [ChildElementInfo(typeof (Frameset))]
  [ChildElementInfo(typeof (Divs))]
  [ChildElementInfo(typeof (DoNotRelyOnCSS))]
  [ChildElementInfo(typeof (OptimizeForBrowser))]
  [ChildElementInfo(typeof (RelyOnVML))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (WebPageEncoding))]
  [ChildElementInfo(typeof (DoNotUseLongFileNames))]
  [ChildElementInfo(typeof (PixelsPerInch))]
  public class WebSettings : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[12]
    {
      "frameset",
      "divs",
      "encoding",
      "optimizeForBrowser",
      "relyOnVML",
      "allowPNG",
      "doNotRelyOnCSS",
      "doNotSaveAsSingleFile",
      "doNotOrganizeInFolder",
      "doNotUseLongFileNames",
      "pixelsPerInch",
      "targetScreenSz"
    };
    private static readonly byte[] eleNamespaceIds = new byte[12]
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
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "webSettings";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11761;

    public override string LocalName
    {
      get
      {
        return "webSettings";
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
        return 11761;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal WebSettings(WebSettingsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WebSettingsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WebSettingsPart WebSettingsPart
    {
      get
      {
        return this.OpenXmlPart as WebSettingsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public WebSettings(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WebSettings(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WebSettings(string outerXml)
      : base(outerXml)
    {
    }

    public WebSettings()
    {
    }

    public void Save(WebSettingsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "frameset" == name)
        return (OpenXmlElement) new Frameset();
      if (23 == (int) namespaceId && "divs" == name)
        return (OpenXmlElement) new Divs();
      if (23 == (int) namespaceId && "encoding" == name)
        return (OpenXmlElement) new WebPageEncoding();
      if (23 == (int) namespaceId && "optimizeForBrowser" == name)
        return (OpenXmlElement) new OptimizeForBrowser();
      if (23 == (int) namespaceId && "relyOnVML" == name)
        return (OpenXmlElement) new RelyOnVML();
      if (23 == (int) namespaceId && "allowPNG" == name)
        return (OpenXmlElement) new AllowPNG();
      if (23 == (int) namespaceId && "doNotRelyOnCSS" == name)
        return (OpenXmlElement) new DoNotRelyOnCSS();
      if (23 == (int) namespaceId && "doNotSaveAsSingleFile" == name)
        return (OpenXmlElement) new DoNotSaveAsSingleFile();
      if (23 == (int) namespaceId && "doNotOrganizeInFolder" == name)
        return (OpenXmlElement) new DoNotOrganizeInFolder();
      if (23 == (int) namespaceId && "doNotUseLongFileNames" == name)
        return (OpenXmlElement) new DoNotUseLongFileNames();
      if (23 == (int) namespaceId && "pixelsPerInch" == name)
        return (OpenXmlElement) new PixelsPerInch();
      if (23 == (int) namespaceId && "targetScreenSz" == name)
        return (OpenXmlElement) new TargetScreenSize();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WebSettings.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WebSettings.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Frameset Frameset
    {
      get
      {
        return this.GetElement<Frameset>(0);
      }
      set
      {
        this.SetElement<Frameset>(0, value);
      }
    }

    public Divs Divs
    {
      get
      {
        return this.GetElement<Divs>(1);
      }
      set
      {
        this.SetElement<Divs>(1, value);
      }
    }

    public WebPageEncoding WebPageEncoding
    {
      get
      {
        return this.GetElement<WebPageEncoding>(2);
      }
      set
      {
        this.SetElement<WebPageEncoding>(2, value);
      }
    }

    public OptimizeForBrowser OptimizeForBrowser
    {
      get
      {
        return this.GetElement<OptimizeForBrowser>(3);
      }
      set
      {
        this.SetElement<OptimizeForBrowser>(3, value);
      }
    }

    public RelyOnVML RelyOnVML
    {
      get
      {
        return this.GetElement<RelyOnVML>(4);
      }
      set
      {
        this.SetElement<RelyOnVML>(4, value);
      }
    }

    public AllowPNG AllowPNG
    {
      get
      {
        return this.GetElement<AllowPNG>(5);
      }
      set
      {
        this.SetElement<AllowPNG>(5, value);
      }
    }

    public DoNotRelyOnCSS DoNotRelyOnCSS
    {
      get
      {
        return this.GetElement<DoNotRelyOnCSS>(6);
      }
      set
      {
        this.SetElement<DoNotRelyOnCSS>(6, value);
      }
    }

    public DoNotSaveAsSingleFile DoNotSaveAsSingleFile
    {
      get
      {
        return this.GetElement<DoNotSaveAsSingleFile>(7);
      }
      set
      {
        this.SetElement<DoNotSaveAsSingleFile>(7, value);
      }
    }

    public DoNotOrganizeInFolder DoNotOrganizeInFolder
    {
      get
      {
        return this.GetElement<DoNotOrganizeInFolder>(8);
      }
      set
      {
        this.SetElement<DoNotOrganizeInFolder>(8, value);
      }
    }

    public DoNotUseLongFileNames DoNotUseLongFileNames
    {
      get
      {
        return this.GetElement<DoNotUseLongFileNames>(9);
      }
      set
      {
        this.SetElement<DoNotUseLongFileNames>(9, value);
      }
    }

    public PixelsPerInch PixelsPerInch
    {
      get
      {
        return this.GetElement<PixelsPerInch>(10);
      }
      set
      {
        this.SetElement<PixelsPerInch>(10, value);
      }
    }

    public TargetScreenSize TargetScreenSize
    {
      get
      {
        return this.GetElement<TargetScreenSize>(11);
      }
      set
      {
        this.SetElement<TargetScreenSize>(11, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebSettings>(deep);
    }
  }
}
