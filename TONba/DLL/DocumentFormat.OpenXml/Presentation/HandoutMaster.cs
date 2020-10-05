// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.HandoutMaster
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (HeaderFooter))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonSlideData))]
  [ChildElementInfo(typeof (ColorMap))]
  [ChildElementInfo(typeof (HandoutMasterExtensionList))]
  public class HandoutMaster : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "cSld",
      "clrMap",
      "hf",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "handoutMaster";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12241;

    public override string LocalName
    {
      get
      {
        return "handoutMaster";
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
        return 12241;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal HandoutMaster(HandoutMasterPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(HandoutMasterPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public HandoutMasterPart HandoutMasterPart
    {
      get
      {
        return this.OpenXmlPart as HandoutMasterPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public HandoutMaster(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HandoutMaster(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HandoutMaster(string outerXml)
      : base(outerXml)
    {
    }

    public HandoutMaster()
    {
    }

    public void Save(HandoutMasterPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cSld" == name)
        return (OpenXmlElement) new CommonSlideData();
      if (24 == (int) namespaceId && "clrMap" == name)
        return (OpenXmlElement) new ColorMap();
      if (24 == (int) namespaceId && "hf" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new HandoutMasterExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return HandoutMaster.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return HandoutMaster.eleNamespaceIds;
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

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(2);
      }
      set
      {
        this.SetElement<HeaderFooter>(2, value);
      }
    }

    public HandoutMasterExtensionList HandoutMasterExtensionList
    {
      get
      {
        return this.GetElement<HandoutMasterExtensionList>(3);
      }
      set
      {
        this.SetElement<HandoutMasterExtensionList>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HandoutMaster>(deep);
    }
  }
}
