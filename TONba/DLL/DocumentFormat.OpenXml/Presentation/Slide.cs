﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Slide
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Transition))]
  [ChildElementInfo(typeof (SlideExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonSlideData))]
  [ChildElementInfo(typeof (Timing))]
  [ChildElementInfo(typeof (ColorMapOverride))]
  public class Slide : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "showMasterSp",
      "showMasterPhAnim",
      "show"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[5]
    {
      "cSld",
      "clrMapOvr",
      "transition",
      "timing",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "sld";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12238;

    public override string LocalName
    {
      get
      {
        return "sld";
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
        return 12238;
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
        return Slide.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Slide.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "showMasterSp")]
    public BooleanValue ShowMasterShapes
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

    [SchemaAttr(0, "showMasterPhAnim")]
    public BooleanValue ShowMasterPlaceholderAnimations
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "show")]
    public BooleanValue Show
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

    internal Slide(SlidePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlidePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlidePart SlidePart
    {
      get
      {
        return this.OpenXmlPart as SlidePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Slide(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Slide(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Slide(string outerXml)
      : base(outerXml)
    {
    }

    public Slide()
    {
    }

    public void Save(SlidePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cSld" == name)
        return (OpenXmlElement) new CommonSlideData();
      if (24 == (int) namespaceId && "clrMapOvr" == name)
        return (OpenXmlElement) new ColorMapOverride();
      if (24 == (int) namespaceId && "transition" == name)
        return (OpenXmlElement) new Transition();
      if (24 == (int) namespaceId && "timing" == name)
        return (OpenXmlElement) new Timing();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new SlideExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Slide.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Slide.eleNamespaceIds;
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

    public ColorMapOverride ColorMapOverride
    {
      get
      {
        return this.GetElement<ColorMapOverride>(1);
      }
      set
      {
        this.SetElement<ColorMapOverride>(1, value);
      }
    }

    public Transition Transition
    {
      get
      {
        return this.GetElement<Transition>(2);
      }
      set
      {
        this.SetElement<Transition>(2, value);
      }
    }

    public Timing Timing
    {
      get
      {
        return this.GetElement<Timing>(3);
      }
      set
      {
        this.SetElement<Timing>(3, value);
      }
    }

    public SlideExtensionList SlideExtensionList
    {
      get
      {
        return this.GetElement<SlideExtensionList>(4);
      }
      set
      {
        this.SetElement<SlideExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "showMasterSp" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showMasterPhAnim" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "show" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Slide>(deep);
    }
  }
}
