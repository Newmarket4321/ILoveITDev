// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SlideLayout
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (SlideLayoutExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonSlideData))]
  [ChildElementInfo(typeof (ColorMapOverride))]
  [ChildElementInfo(typeof (Transition))]
  [ChildElementInfo(typeof (Timing))]
  [ChildElementInfo(typeof (HeaderFooter))]
  public class SlideLayout : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "showMasterSp",
      "showMasterPhAnim",
      "matchingName",
      "type",
      "preserve",
      "userDrawn"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private static readonly string[] eleTagNames = new string[6]
    {
      "cSld",
      "clrMapOvr",
      "transition",
      "timing",
      "hf",
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
    private const string tagName = "sldLayout";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12239;

    public override string LocalName
    {
      get
      {
        return "sldLayout";
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
        return 12239;
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
        return SlideLayout.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlideLayout.attributeNamespaceIds;
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

    [SchemaAttr(0, "matchingName")]
    public StringValue MatchingName
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<SlideLayoutValues> Type
    {
      get
      {
        return (EnumValue<SlideLayoutValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "preserve")]
    public BooleanValue Preserve
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

    [SchemaAttr(0, "userDrawn")]
    public BooleanValue UserDrawn
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

    internal SlideLayout(SlideLayoutPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlideLayoutPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlideLayoutPart SlideLayoutPart
    {
      get
      {
        return this.OpenXmlPart as SlideLayoutPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public SlideLayout(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlideLayout(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlideLayout(string outerXml)
      : base(outerXml)
    {
    }

    public SlideLayout()
    {
    }

    public void Save(SlideLayoutPart openXmlPart)
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
      if (24 == (int) namespaceId && "hf" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new SlideLayoutExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SlideLayout.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SlideLayout.eleNamespaceIds;
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

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(4);
      }
      set
      {
        this.SetElement<HeaderFooter>(4, value);
      }
    }

    public SlideLayoutExtensionList SlideLayoutExtensionList
    {
      get
      {
        return this.GetElement<SlideLayoutExtensionList>(5);
      }
      set
      {
        this.SetElement<SlideLayoutExtensionList>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "showMasterSp" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showMasterPhAnim" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "matchingName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<SlideLayoutValues>();
      if ((int) namespaceId == 0 && "preserve" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "userDrawn" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlideLayout>(deep);
    }
  }
}
