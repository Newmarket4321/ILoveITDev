// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
  [ChildElementInfo(typeof (ArtisticCement), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ArtisticPaintStrokes), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticBlur), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticChalkSketch), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticCrisscrossEtching), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticCutout), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticFilmGrain), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticGlass), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticGlowDiffused), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticGlowEdges), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticLightScreen), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticLineDrawing), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticMarker), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticMosaicBubbles), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticTexturizer), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ArtisticPastelsSmooth), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticPencilGrayscale), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticPencilSketch), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticPhotocopy), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticPlasticWrap), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticPaintBrush), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ArtisticWatercolorSponge), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackgroundRemoval), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BrightnessContrast), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ColorTemperature), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Saturation), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SharpenSoften), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class ImageEffect : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "visible"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[27]
    {
      "artisticBlur",
      "artisticCement",
      "artisticChalkSketch",
      "artisticCrisscrossEtching",
      "artisticCutout",
      "artisticFilmGrain",
      "artisticGlass",
      "artisticGlowDiffused",
      "artisticGlowEdges",
      "artisticLightScreen",
      "artisticLineDrawing",
      "artisticMarker",
      "artisticMosiaicBubbles",
      "artisticPaintStrokes",
      "artisticPaintBrush",
      "artisticPastelsSmooth",
      "artisticPencilGrayscale",
      "artisticPencilSketch",
      "artisticPhotocopy",
      "artisticPlasticWrap",
      "artisticTexturizer",
      "artisticWatercolorSponge",
      "backgroundRemoval",
      "brightnessContrast",
      "colorTemperature",
      "saturation",
      "sharpenSoften"
    };
    private static readonly byte[] eleNamespaceIds = new byte[27]
    {
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48,
      (byte) 48
    };
    private const string tagName = "imgEffect";
    private const byte tagNsId = 48;
    internal const int ElementTypeIdConst = 12825;

    public override string LocalName
    {
      get
      {
        return "imgEffect";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 48;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12825;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ImageEffect.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ImageEffect.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
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

    public ImageEffect()
    {
    }

    public ImageEffect(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ImageEffect(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ImageEffect(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (48 == (int) namespaceId && "artisticBlur" == name)
        return (OpenXmlElement) new ArtisticBlur();
      if (48 == (int) namespaceId && "artisticCement" == name)
        return (OpenXmlElement) new ArtisticCement();
      if (48 == (int) namespaceId && "artisticChalkSketch" == name)
        return (OpenXmlElement) new ArtisticChalkSketch();
      if (48 == (int) namespaceId && "artisticCrisscrossEtching" == name)
        return (OpenXmlElement) new ArtisticCrisscrossEtching();
      if (48 == (int) namespaceId && "artisticCutout" == name)
        return (OpenXmlElement) new ArtisticCutout();
      if (48 == (int) namespaceId && "artisticFilmGrain" == name)
        return (OpenXmlElement) new ArtisticFilmGrain();
      if (48 == (int) namespaceId && "artisticGlass" == name)
        return (OpenXmlElement) new ArtisticGlass();
      if (48 == (int) namespaceId && "artisticGlowDiffused" == name)
        return (OpenXmlElement) new ArtisticGlowDiffused();
      if (48 == (int) namespaceId && "artisticGlowEdges" == name)
        return (OpenXmlElement) new ArtisticGlowEdges();
      if (48 == (int) namespaceId && "artisticLightScreen" == name)
        return (OpenXmlElement) new ArtisticLightScreen();
      if (48 == (int) namespaceId && "artisticLineDrawing" == name)
        return (OpenXmlElement) new ArtisticLineDrawing();
      if (48 == (int) namespaceId && "artisticMarker" == name)
        return (OpenXmlElement) new ArtisticMarker();
      if (48 == (int) namespaceId && "artisticMosiaicBubbles" == name)
        return (OpenXmlElement) new ArtisticMosaicBubbles();
      if (48 == (int) namespaceId && "artisticPaintStrokes" == name)
        return (OpenXmlElement) new ArtisticPaintStrokes();
      if (48 == (int) namespaceId && "artisticPaintBrush" == name)
        return (OpenXmlElement) new ArtisticPaintBrush();
      if (48 == (int) namespaceId && "artisticPastelsSmooth" == name)
        return (OpenXmlElement) new ArtisticPastelsSmooth();
      if (48 == (int) namespaceId && "artisticPencilGrayscale" == name)
        return (OpenXmlElement) new ArtisticPencilGrayscale();
      if (48 == (int) namespaceId && "artisticPencilSketch" == name)
        return (OpenXmlElement) new ArtisticPencilSketch();
      if (48 == (int) namespaceId && "artisticPhotocopy" == name)
        return (OpenXmlElement) new ArtisticPhotocopy();
      if (48 == (int) namespaceId && "artisticPlasticWrap" == name)
        return (OpenXmlElement) new ArtisticPlasticWrap();
      if (48 == (int) namespaceId && "artisticTexturizer" == name)
        return (OpenXmlElement) new ArtisticTexturizer();
      if (48 == (int) namespaceId && "artisticWatercolorSponge" == name)
        return (OpenXmlElement) new ArtisticWatercolorSponge();
      if (48 == (int) namespaceId && "backgroundRemoval" == name)
        return (OpenXmlElement) new BackgroundRemoval();
      if (48 == (int) namespaceId && "brightnessContrast" == name)
        return (OpenXmlElement) new BrightnessContrast();
      if (48 == (int) namespaceId && "colorTemperature" == name)
        return (OpenXmlElement) new ColorTemperature();
      if (48 == (int) namespaceId && "saturation" == name)
        return (OpenXmlElement) new Saturation();
      if (48 == (int) namespaceId && "sharpenSoften" == name)
        return (OpenXmlElement) new SharpenSoften();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ImageEffect.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ImageEffect.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public ArtisticBlur ArtisticBlur
    {
      get
      {
        return this.GetElement<ArtisticBlur>(0);
      }
      set
      {
        this.SetElement<ArtisticBlur>(0, value);
      }
    }

    public ArtisticCement ArtisticCement
    {
      get
      {
        return this.GetElement<ArtisticCement>(1);
      }
      set
      {
        this.SetElement<ArtisticCement>(1, value);
      }
    }

    public ArtisticChalkSketch ArtisticChalkSketch
    {
      get
      {
        return this.GetElement<ArtisticChalkSketch>(2);
      }
      set
      {
        this.SetElement<ArtisticChalkSketch>(2, value);
      }
    }

    public ArtisticCrisscrossEtching ArtisticCrisscrossEtching
    {
      get
      {
        return this.GetElement<ArtisticCrisscrossEtching>(3);
      }
      set
      {
        this.SetElement<ArtisticCrisscrossEtching>(3, value);
      }
    }

    public ArtisticCutout ArtisticCutout
    {
      get
      {
        return this.GetElement<ArtisticCutout>(4);
      }
      set
      {
        this.SetElement<ArtisticCutout>(4, value);
      }
    }

    public ArtisticFilmGrain ArtisticFilmGrain
    {
      get
      {
        return this.GetElement<ArtisticFilmGrain>(5);
      }
      set
      {
        this.SetElement<ArtisticFilmGrain>(5, value);
      }
    }

    public ArtisticGlass ArtisticGlass
    {
      get
      {
        return this.GetElement<ArtisticGlass>(6);
      }
      set
      {
        this.SetElement<ArtisticGlass>(6, value);
      }
    }

    public ArtisticGlowDiffused ArtisticGlowDiffused
    {
      get
      {
        return this.GetElement<ArtisticGlowDiffused>(7);
      }
      set
      {
        this.SetElement<ArtisticGlowDiffused>(7, value);
      }
    }

    public ArtisticGlowEdges ArtisticGlowEdges
    {
      get
      {
        return this.GetElement<ArtisticGlowEdges>(8);
      }
      set
      {
        this.SetElement<ArtisticGlowEdges>(8, value);
      }
    }

    public ArtisticLightScreen ArtisticLightScreen
    {
      get
      {
        return this.GetElement<ArtisticLightScreen>(9);
      }
      set
      {
        this.SetElement<ArtisticLightScreen>(9, value);
      }
    }

    public ArtisticLineDrawing ArtisticLineDrawing
    {
      get
      {
        return this.GetElement<ArtisticLineDrawing>(10);
      }
      set
      {
        this.SetElement<ArtisticLineDrawing>(10, value);
      }
    }

    public ArtisticMarker ArtisticMarker
    {
      get
      {
        return this.GetElement<ArtisticMarker>(11);
      }
      set
      {
        this.SetElement<ArtisticMarker>(11, value);
      }
    }

    public ArtisticMosaicBubbles ArtisticMosaicBubbles
    {
      get
      {
        return this.GetElement<ArtisticMosaicBubbles>(12);
      }
      set
      {
        this.SetElement<ArtisticMosaicBubbles>(12, value);
      }
    }

    public ArtisticPaintStrokes ArtisticPaintStrokes
    {
      get
      {
        return this.GetElement<ArtisticPaintStrokes>(13);
      }
      set
      {
        this.SetElement<ArtisticPaintStrokes>(13, value);
      }
    }

    public ArtisticPaintBrush ArtisticPaintBrush
    {
      get
      {
        return this.GetElement<ArtisticPaintBrush>(14);
      }
      set
      {
        this.SetElement<ArtisticPaintBrush>(14, value);
      }
    }

    public ArtisticPastelsSmooth ArtisticPastelsSmooth
    {
      get
      {
        return this.GetElement<ArtisticPastelsSmooth>(15);
      }
      set
      {
        this.SetElement<ArtisticPastelsSmooth>(15, value);
      }
    }

    public ArtisticPencilGrayscale ArtisticPencilGrayscale
    {
      get
      {
        return this.GetElement<ArtisticPencilGrayscale>(16);
      }
      set
      {
        this.SetElement<ArtisticPencilGrayscale>(16, value);
      }
    }

    public ArtisticPencilSketch ArtisticPencilSketch
    {
      get
      {
        return this.GetElement<ArtisticPencilSketch>(17);
      }
      set
      {
        this.SetElement<ArtisticPencilSketch>(17, value);
      }
    }

    public ArtisticPhotocopy ArtisticPhotocopy
    {
      get
      {
        return this.GetElement<ArtisticPhotocopy>(18);
      }
      set
      {
        this.SetElement<ArtisticPhotocopy>(18, value);
      }
    }

    public ArtisticPlasticWrap ArtisticPlasticWrap
    {
      get
      {
        return this.GetElement<ArtisticPlasticWrap>(19);
      }
      set
      {
        this.SetElement<ArtisticPlasticWrap>(19, value);
      }
    }

    public ArtisticTexturizer ArtisticTexturizer
    {
      get
      {
        return this.GetElement<ArtisticTexturizer>(20);
      }
      set
      {
        this.SetElement<ArtisticTexturizer>(20, value);
      }
    }

    public ArtisticWatercolorSponge ArtisticWatercolorSponge
    {
      get
      {
        return this.GetElement<ArtisticWatercolorSponge>(21);
      }
      set
      {
        this.SetElement<ArtisticWatercolorSponge>(21, value);
      }
    }

    public BackgroundRemoval BackgroundRemoval
    {
      get
      {
        return this.GetElement<BackgroundRemoval>(22);
      }
      set
      {
        this.SetElement<BackgroundRemoval>(22, value);
      }
    }

    public BrightnessContrast BrightnessContrast
    {
      get
      {
        return this.GetElement<BrightnessContrast>(23);
      }
      set
      {
        this.SetElement<BrightnessContrast>(23, value);
      }
    }

    public ColorTemperature ColorTemperature
    {
      get
      {
        return this.GetElement<ColorTemperature>(24);
      }
      set
      {
        this.SetElement<ColorTemperature>(24, value);
      }
    }

    public Saturation Saturation
    {
      get
      {
        return this.GetElement<Saturation>(25);
      }
      set
      {
        this.SetElement<Saturation>(25, value);
      }
    }

    public SharpenSoften SharpenSoften
    {
      get
      {
        return this.GetElement<SharpenSoften>(26);
      }
      set
      {
        this.SetElement<SharpenSoften>(26, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "visible" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ImageEffect>(deep);
    }
  }
}
