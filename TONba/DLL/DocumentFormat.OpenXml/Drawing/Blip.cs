﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Blip
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Blur))]
  [ChildElementInfo(typeof (LuminanceEffect))]
  [ChildElementInfo(typeof (TintEffect))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AlphaBiLevel))]
  [ChildElementInfo(typeof (AlphaCeiling))]
  [ChildElementInfo(typeof (AlphaFloor))]
  [ChildElementInfo(typeof (AlphaInverse))]
  [ChildElementInfo(typeof (AlphaModulationEffect))]
  [ChildElementInfo(typeof (AlphaModulationFixed))]
  [ChildElementInfo(typeof (AlphaReplace))]
  [ChildElementInfo(typeof (BiLevel))]
  [ChildElementInfo(typeof (ColorChange))]
  [ChildElementInfo(typeof (ColorReplacement))]
  [ChildElementInfo(typeof (Duotone))]
  [ChildElementInfo(typeof (FillOverlay))]
  [ChildElementInfo(typeof (Grayscale))]
  [ChildElementInfo(typeof (Hsl))]
  [ChildElementInfo(typeof (BlipExtensionList))]
  public class Blip : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "embed",
      "link",
      "cstate"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 19,
      (byte) 19,
      (byte) 0
    };
    private const string tagName = "blip";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10121;

    public override string LocalName
    {
      get
      {
        return "blip";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10121;
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
        return Blip.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Blip.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "embed")]
    public StringValue Embed
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "link")]
    public StringValue Link
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

    [SchemaAttr(0, "cstate")]
    public EnumValue<BlipCompressionValues> CompressionState
    {
      get
      {
        return (EnumValue<BlipCompressionValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Blip()
    {
    }

    public Blip(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Blip(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Blip(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
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
      if (10 == (int) namespaceId && "alphaRepl" == name)
        return (OpenXmlElement) new AlphaReplace();
      if (10 == (int) namespaceId && "biLevel" == name)
        return (OpenXmlElement) new BiLevel();
      if (10 == (int) namespaceId && "blur" == name)
        return (OpenXmlElement) new Blur();
      if (10 == (int) namespaceId && "clrChange" == name)
        return (OpenXmlElement) new ColorChange();
      if (10 == (int) namespaceId && "clrRepl" == name)
        return (OpenXmlElement) new ColorReplacement();
      if (10 == (int) namespaceId && "duotone" == name)
        return (OpenXmlElement) new Duotone();
      if (10 == (int) namespaceId && "fillOverlay" == name)
        return (OpenXmlElement) new FillOverlay();
      if (10 == (int) namespaceId && "grayscl" == name)
        return (OpenXmlElement) new Grayscale();
      if (10 == (int) namespaceId && "hsl" == name)
        return (OpenXmlElement) new Hsl();
      if (10 == (int) namespaceId && "lum" == name)
        return (OpenXmlElement) new LuminanceEffect();
      if (10 == (int) namespaceId && "tint" == name)
        return (OpenXmlElement) new TintEffect();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new BlipExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "embed" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "link" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cstate" == name)
        return (OpenXmlSimpleType) new EnumValue<BlipCompressionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Blip>(deep);
    }
  }
}
