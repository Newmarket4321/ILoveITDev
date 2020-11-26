﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [ChildElementInfo(typeof (SaturationModulation))]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Tint))]
  [ChildElementInfo(typeof (Shade))]
  [ChildElementInfo(typeof (Complement))]
  [ChildElementInfo(typeof (Inverse))]
  [ChildElementInfo(typeof (Gray))]
  [ChildElementInfo(typeof (Alpha))]
  [ChildElementInfo(typeof (AlphaOffset))]
  [ChildElementInfo(typeof (AlphaModulation))]
  [ChildElementInfo(typeof (Hue))]
  [ChildElementInfo(typeof (HueOffset))]
  [ChildElementInfo(typeof (HueModulation))]
  [ChildElementInfo(typeof (Saturation))]
  [ChildElementInfo(typeof (SaturationOffset))]
  [ChildElementInfo(typeof (Luminance))]
  [ChildElementInfo(typeof (LuminanceOffset))]
  [ChildElementInfo(typeof (LuminanceModulation))]
  [ChildElementInfo(typeof (Red))]
  [ChildElementInfo(typeof (RedOffset))]
  [ChildElementInfo(typeof (RedModulation))]
  [ChildElementInfo(typeof (Green))]
  [ChildElementInfo(typeof (GreenOffset))]
  [ChildElementInfo(typeof (GreenModulation))]
  [ChildElementInfo(typeof (Blue))]
  [ChildElementInfo(typeof (BlueOffset))]
  [ChildElementInfo(typeof (BlueModulation))]
  [ChildElementInfo(typeof (Gamma))]
  [ChildElementInfo(typeof (InverseGamma))]
  [GeneratedCode("DomGen", "2.0")]
  public class StyleColor : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "styleClr";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13260;

    public override string LocalName
    {
      get
      {
        return "styleClr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13260;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return StyleColor.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StyleColor.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "val")]
    public StringValue Val
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

    public StyleColor()
    {
    }

    public StyleColor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StyleColor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StyleColor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tint" == name)
        return (OpenXmlElement) new Tint();
      if (10 == (int) namespaceId && "shade" == name)
        return (OpenXmlElement) new Shade();
      if (10 == (int) namespaceId && "comp" == name)
        return (OpenXmlElement) new Complement();
      if (10 == (int) namespaceId && "inv" == name)
        return (OpenXmlElement) new Inverse();
      if (10 == (int) namespaceId && "gray" == name)
        return (OpenXmlElement) new Gray();
      if (10 == (int) namespaceId && "alpha" == name)
        return (OpenXmlElement) new Alpha();
      if (10 == (int) namespaceId && "alphaOff" == name)
        return (OpenXmlElement) new AlphaOffset();
      if (10 == (int) namespaceId && "alphaMod" == name)
        return (OpenXmlElement) new AlphaModulation();
      if (10 == (int) namespaceId && "hue" == name)
        return (OpenXmlElement) new Hue();
      if (10 == (int) namespaceId && "hueOff" == name)
        return (OpenXmlElement) new HueOffset();
      if (10 == (int) namespaceId && "hueMod" == name)
        return (OpenXmlElement) new HueModulation();
      if (10 == (int) namespaceId && "sat" == name)
        return (OpenXmlElement) new Saturation();
      if (10 == (int) namespaceId && "satOff" == name)
        return (OpenXmlElement) new SaturationOffset();
      if (10 == (int) namespaceId && "satMod" == name)
        return (OpenXmlElement) new SaturationModulation();
      if (10 == (int) namespaceId && "lum" == name)
        return (OpenXmlElement) new Luminance();
      if (10 == (int) namespaceId && "lumOff" == name)
        return (OpenXmlElement) new LuminanceOffset();
      if (10 == (int) namespaceId && "lumMod" == name)
        return (OpenXmlElement) new LuminanceModulation();
      if (10 == (int) namespaceId && "red" == name)
        return (OpenXmlElement) new Red();
      if (10 == (int) namespaceId && "redOff" == name)
        return (OpenXmlElement) new RedOffset();
      if (10 == (int) namespaceId && "redMod" == name)
        return (OpenXmlElement) new RedModulation();
      if (10 == (int) namespaceId && "green" == name)
        return (OpenXmlElement) new Green();
      if (10 == (int) namespaceId && "greenOff" == name)
        return (OpenXmlElement) new GreenOffset();
      if (10 == (int) namespaceId && "greenMod" == name)
        return (OpenXmlElement) new GreenModulation();
      if (10 == (int) namespaceId && "blue" == name)
        return (OpenXmlElement) new Blue();
      if (10 == (int) namespaceId && "blueOff" == name)
        return (OpenXmlElement) new BlueOffset();
      if (10 == (int) namespaceId && "blueMod" == name)
        return (OpenXmlElement) new BlueModulation();
      if (10 == (int) namespaceId && "gamma" == name)
        return (OpenXmlElement) new Gamma();
      if (10 == (int) namespaceId && "invGamma" == name)
        return (OpenXmlElement) new InverseGamma();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StyleColor>(deep);
    }
  }
}