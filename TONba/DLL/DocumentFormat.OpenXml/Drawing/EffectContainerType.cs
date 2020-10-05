// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.EffectContainerType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (AlphaReplace))]
  [ChildElementInfo(typeof (EffectContainer))]
  [ChildElementInfo(typeof (Effect))]
  [ChildElementInfo(typeof (AlphaBiLevel))]
  [ChildElementInfo(typeof (AlphaCeiling))]
  [ChildElementInfo(typeof (AlphaFloor))]
  [ChildElementInfo(typeof (AlphaInverse))]
  [ChildElementInfo(typeof (AlphaModulationEffect))]
  [ChildElementInfo(typeof (AlphaModulationFixed))]
  [ChildElementInfo(typeof (AlphaOutset))]
  [ChildElementInfo(typeof (BiLevel))]
  [ChildElementInfo(typeof (Blend))]
  [ChildElementInfo(typeof (Blur))]
  [ChildElementInfo(typeof (ColorChange))]
  [ChildElementInfo(typeof (ColorReplacement))]
  [ChildElementInfo(typeof (Duotone))]
  [ChildElementInfo(typeof (Fill))]
  [ChildElementInfo(typeof (FillOverlay))]
  [ChildElementInfo(typeof (Glow))]
  [ChildElementInfo(typeof (Grayscale))]
  [ChildElementInfo(typeof (Hsl))]
  [ChildElementInfo(typeof (InnerShadow))]
  [ChildElementInfo(typeof (LuminanceEffect))]
  [ChildElementInfo(typeof (OuterShadow))]
  [ChildElementInfo(typeof (PresetShadow))]
  [ChildElementInfo(typeof (Reflection))]
  [ChildElementInfo(typeof (RelativeOffset))]
  [ChildElementInfo(typeof (SoftEdge))]
  [ChildElementInfo(typeof (TintEffect))]
  [ChildElementInfo(typeof (TransformEffect))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class EffectContainerType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "type",
      "name"
    };
    private static byte[] attributeNamespaceIds = new byte[2];

    internal override string[] AttributeTagNames
    {
      get
      {
        return EffectContainerType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EffectContainerType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<EffectContainerValues> Type
    {
      get
      {
        return (EnumValue<EffectContainerValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "cont" == name)
        return (OpenXmlElement) new EffectContainer();
      if (10 == (int) namespaceId && "effect" == name)
        return (OpenXmlElement) new Effect();
      if (10 == (int) namespaceId && "alphaBiLevel" == name)
        return (OpenXmlElement) new AlphaBiLevel();
      if (10 == (int) namespaceId && "alphaCeiling" == name)
        return (OpenXmlElement) new AlphaCeiling();
      if (10 == (int) namespaceId && "alphaFloor" == name)
        return (OpenXmlElement) new AlphaFloor();
      if (10 == (int) namespaceId && "alphaInv" == name)
        return (OpenXmlElement) new AlphaInverse();
      if (10 == (int) namespaceId && "alphaMod" == name)
        return (OpenXmlElement) new AlphaModulationEffect();
      if (10 == (int) namespaceId && "alphaModFix" == name)
        return (OpenXmlElement) new AlphaModulationFixed();
      if (10 == (int) namespaceId && "alphaOutset" == name)
        return (OpenXmlElement) new AlphaOutset();
      if (10 == (int) namespaceId && "alphaRepl" == name)
        return (OpenXmlElement) new AlphaReplace();
      if (10 == (int) namespaceId && "biLevel" == name)
        return (OpenXmlElement) new BiLevel();
      if (10 == (int) namespaceId && "blend" == name)
        return (OpenXmlElement) new Blend();
      if (10 == (int) namespaceId && "blur" == name)
        return (OpenXmlElement) new Blur();
      if (10 == (int) namespaceId && "clrChange" == name)
        return (OpenXmlElement) new ColorChange();
      if (10 == (int) namespaceId && "clrRepl" == name)
        return (OpenXmlElement) new ColorReplacement();
      if (10 == (int) namespaceId && "duotone" == name)
        return (OpenXmlElement) new Duotone();
      if (10 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new Fill();
      if (10 == (int) namespaceId && "fillOverlay" == name)
        return (OpenXmlElement) new FillOverlay();
      if (10 == (int) namespaceId && "glow" == name)
        return (OpenXmlElement) new Glow();
      if (10 == (int) namespaceId && "grayscl" == name)
        return (OpenXmlElement) new Grayscale();
      if (10 == (int) namespaceId && "hsl" == name)
        return (OpenXmlElement) new Hsl();
      if (10 == (int) namespaceId && "innerShdw" == name)
        return (OpenXmlElement) new InnerShadow();
      if (10 == (int) namespaceId && "lum" == name)
        return (OpenXmlElement) new LuminanceEffect();
      if (10 == (int) namespaceId && "outerShdw" == name)
        return (OpenXmlElement) new OuterShadow();
      if (10 == (int) namespaceId && "prstShdw" == name)
        return (OpenXmlElement) new PresetShadow();
      if (10 == (int) namespaceId && "reflection" == name)
        return (OpenXmlElement) new Reflection();
      if (10 == (int) namespaceId && "relOff" == name)
        return (OpenXmlElement) new RelativeOffset();
      if (10 == (int) namespaceId && "softEdge" == name)
        return (OpenXmlElement) new SoftEdge();
      if (10 == (int) namespaceId && "tint" == name)
        return (OpenXmlElement) new TintEffect();
      if (10 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new TransformEffect();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<EffectContainerValues>();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected EffectContainerType()
    {
    }

    protected EffectContainerType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected EffectContainerType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected EffectContainerType(string outerXml)
      : base(outerXml)
    {
    }
  }
}
