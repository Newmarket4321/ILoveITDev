// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Transition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.PowerPoint;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (SplitTransition))]
  [ChildElementInfo(typeof (VortexTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SwitchTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BlindsTransition))]
  [ChildElementInfo(typeof (CheckerTransition))]
  [ChildElementInfo(typeof (CircleTransition))]
  [ChildElementInfo(typeof (DissolveTransition))]
  [ChildElementInfo(typeof (CombTransition))]
  [ChildElementInfo(typeof (CoverTransition))]
  [ChildElementInfo(typeof (CutTransition))]
  [ChildElementInfo(typeof (DiamondTransition))]
  [ChildElementInfo(typeof (FadeTransition))]
  [ChildElementInfo(typeof (NewsflashTransition))]
  [ChildElementInfo(typeof (PlusTransition))]
  [ChildElementInfo(typeof (PullTransition))]
  [ChildElementInfo(typeof (PushTransition))]
  [ChildElementInfo(typeof (RandomTransition))]
  [ChildElementInfo(typeof (RandomBarTransition))]
  [ChildElementInfo(typeof (StripsTransition))]
  [ChildElementInfo(typeof (WedgeTransition))]
  [ChildElementInfo(typeof (WheelTransition))]
  [ChildElementInfo(typeof (WipeTransition))]
  [ChildElementInfo(typeof (ZoomTransition))]
  [ChildElementInfo(typeof (FlashTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FlipTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RippleTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GlitterTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HoneycombTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PrismTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DoorsTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WindowTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShredTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FerrisTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FlythroughTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WarpTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GalleryTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConveyorTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PanTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RevealTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WheelReverseTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PresetTransition), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SoundAction))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  public class Transition : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "spd",
      "dur",
      "advClick",
      "advTm"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 0,
      (byte) 49,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "transition";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12368;

    public override string LocalName
    {
      get
      {
        return "transition";
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
        return 12368;
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
        return Transition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Transition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "spd")]
    public EnumValue<TransitionSpeedValues> Speed
    {
      get
      {
        return (EnumValue<TransitionSpeedValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(49, "dur")]
    public StringValue Duration
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "advClick")]
    public BooleanValue AdvanceOnClick
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

    [SchemaAttr(0, "advTm")]
    public StringValue AdvanceAfterTime
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public Transition()
    {
    }

    public Transition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Transition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Transition(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "blinds" == name)
        return (OpenXmlElement) new BlindsTransition();
      if (24 == (int) namespaceId && "checker" == name)
        return (OpenXmlElement) new CheckerTransition();
      if (24 == (int) namespaceId && "circle" == name)
        return (OpenXmlElement) new CircleTransition();
      if (24 == (int) namespaceId && "dissolve" == name)
        return (OpenXmlElement) new DissolveTransition();
      if (24 == (int) namespaceId && "comb" == name)
        return (OpenXmlElement) new CombTransition();
      if (24 == (int) namespaceId && "cover" == name)
        return (OpenXmlElement) new CoverTransition();
      if (24 == (int) namespaceId && "cut" == name)
        return (OpenXmlElement) new CutTransition();
      if (24 == (int) namespaceId && "diamond" == name)
        return (OpenXmlElement) new DiamondTransition();
      if (24 == (int) namespaceId && "fade" == name)
        return (OpenXmlElement) new FadeTransition();
      if (24 == (int) namespaceId && "newsflash" == name)
        return (OpenXmlElement) new NewsflashTransition();
      if (24 == (int) namespaceId && "plus" == name)
        return (OpenXmlElement) new PlusTransition();
      if (24 == (int) namespaceId && "pull" == name)
        return (OpenXmlElement) new PullTransition();
      if (24 == (int) namespaceId && "push" == name)
        return (OpenXmlElement) new PushTransition();
      if (24 == (int) namespaceId && "random" == name)
        return (OpenXmlElement) new RandomTransition();
      if (24 == (int) namespaceId && "randomBar" == name)
        return (OpenXmlElement) new RandomBarTransition();
      if (24 == (int) namespaceId && "split" == name)
        return (OpenXmlElement) new SplitTransition();
      if (24 == (int) namespaceId && "strips" == name)
        return (OpenXmlElement) new StripsTransition();
      if (24 == (int) namespaceId && "wedge" == name)
        return (OpenXmlElement) new WedgeTransition();
      if (24 == (int) namespaceId && "wheel" == name)
        return (OpenXmlElement) new WheelTransition();
      if (24 == (int) namespaceId && "wipe" == name)
        return (OpenXmlElement) new WipeTransition();
      if (24 == (int) namespaceId && "zoom" == name)
        return (OpenXmlElement) new ZoomTransition();
      if (49 == (int) namespaceId && "flash" == name)
        return (OpenXmlElement) new FlashTransition();
      if (49 == (int) namespaceId && "vortex" == name)
        return (OpenXmlElement) new VortexTransition();
      if (49 == (int) namespaceId && "switch" == name)
        return (OpenXmlElement) new SwitchTransition();
      if (49 == (int) namespaceId && "flip" == name)
        return (OpenXmlElement) new FlipTransition();
      if (49 == (int) namespaceId && "ripple" == name)
        return (OpenXmlElement) new RippleTransition();
      if (49 == (int) namespaceId && "glitter" == name)
        return (OpenXmlElement) new GlitterTransition();
      if (49 == (int) namespaceId && "honeycomb" == name)
        return (OpenXmlElement) new HoneycombTransition();
      if (49 == (int) namespaceId && "prism" == name)
        return (OpenXmlElement) new PrismTransition();
      if (49 == (int) namespaceId && "doors" == name)
        return (OpenXmlElement) new DoorsTransition();
      if (49 == (int) namespaceId && "window" == name)
        return (OpenXmlElement) new WindowTransition();
      if (49 == (int) namespaceId && "shred" == name)
        return (OpenXmlElement) new ShredTransition();
      if (49 == (int) namespaceId && "ferris" == name)
        return (OpenXmlElement) new FerrisTransition();
      if (49 == (int) namespaceId && "flythrough" == name)
        return (OpenXmlElement) new FlythroughTransition();
      if (49 == (int) namespaceId && "warp" == name)
        return (OpenXmlElement) new WarpTransition();
      if (49 == (int) namespaceId && "gallery" == name)
        return (OpenXmlElement) new GalleryTransition();
      if (49 == (int) namespaceId && "conveyor" == name)
        return (OpenXmlElement) new ConveyorTransition();
      if (49 == (int) namespaceId && "pan" == name)
        return (OpenXmlElement) new PanTransition();
      if (49 == (int) namespaceId && "reveal" == name)
        return (OpenXmlElement) new RevealTransition();
      if (49 == (int) namespaceId && "wheelReverse" == name)
        return (OpenXmlElement) new WheelReverseTransition();
      if (68 == (int) namespaceId && "prstTrans" == name)
        return (OpenXmlElement) new PresetTransition();
      if (24 == (int) namespaceId && "sndAc" == name)
        return (OpenXmlElement) new SoundAction();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "spd" == name)
        return (OpenXmlSimpleType) new EnumValue<TransitionSpeedValues>();
      if (49 == (int) namespaceId && "dur" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "advClick" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "advTm" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Transition>(deep);
    }
  }
}
