// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Color2Type
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (HslColor))]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (PresetColor))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class Color2Type : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "scrgbClr",
      "srgbClr",
      "hslClr",
      "sysClr",
      "prstClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "scrgbClr" == name)
        return (OpenXmlElement) new RgbColorModelPercentage();
      if (10 == (int) namespaceId && "srgbClr" == name)
        return (OpenXmlElement) new RgbColorModelHex();
      if (10 == (int) namespaceId && "hslClr" == name)
        return (OpenXmlElement) new HslColor();
      if (10 == (int) namespaceId && "sysClr" == name)
        return (OpenXmlElement) new SystemColor();
      if (10 == (int) namespaceId && "prstClr" == name)
        return (OpenXmlElement) new PresetColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Color2Type.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Color2Type.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public RgbColorModelPercentage RgbColorModelPercentage
    {
      get
      {
        return this.GetElement<RgbColorModelPercentage>(0);
      }
      set
      {
        this.SetElement<RgbColorModelPercentage>(0, value);
      }
    }

    public RgbColorModelHex RgbColorModelHex
    {
      get
      {
        return this.GetElement<RgbColorModelHex>(1);
      }
      set
      {
        this.SetElement<RgbColorModelHex>(1, value);
      }
    }

    public HslColor HslColor
    {
      get
      {
        return this.GetElement<HslColor>(2);
      }
      set
      {
        this.SetElement<HslColor>(2, value);
      }
    }

    public SystemColor SystemColor
    {
      get
      {
        return this.GetElement<SystemColor>(3);
      }
      set
      {
        this.SetElement<SystemColor>(3, value);
      }
    }

    public PresetColor PresetColor
    {
      get
      {
        return this.GetElement<PresetColor>(4);
      }
      set
      {
        this.SetElement<PresetColor>(4, value);
      }
    }

    protected Color2Type()
    {
    }

    protected Color2Type(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected Color2Type(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected Color2Type(string outerXml)
      : base(outerXml)
    {
    }
  }
}
