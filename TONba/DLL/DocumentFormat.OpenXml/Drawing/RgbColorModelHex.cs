﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.RgbColorModelHex
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (RedOffset))]
  [ChildElementInfo(typeof (Green))]
  [ChildElementInfo(typeof (Blue))]
  [ChildElementInfo(typeof (BlueOffset))]
  [ChildElementInfo(typeof (BlueModulation))]
  [ChildElementInfo(typeof (Gamma))]
  [ChildElementInfo(typeof (InverseGamma))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GreenOffset))]
  [ChildElementInfo(typeof (GreenModulation))]
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
  [ChildElementInfo(typeof (SaturationModulation))]
  [ChildElementInfo(typeof (Luminance))]
  [ChildElementInfo(typeof (LuminanceOffset))]
  [ChildElementInfo(typeof (LuminanceModulation))]
  [ChildElementInfo(typeof (Red))]
  [ChildElementInfo(typeof (Tint))]
  [ChildElementInfo(typeof (RedModulation))]
  public class RgbColorModelHex : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "val",
      "legacySpreadsheetColorIndex"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 0,
      (byte) 48
    };
    private const string tagName = "srgbClr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10036;

    public override string LocalName
    {
      get
      {
        return "srgbClr";
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
        return 10036;
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
        return RgbColorModelHex.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RgbColorModelHex.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "val")]
    public HexBinaryValue Val
    {
      get
      {
        return (HexBinaryValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(48, "legacySpreadsheetColorIndex")]
    public Int32Value LegacySpreadsheetColorIndex
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public RgbColorModelHex()
    {
    }

    public RgbColorModelHex(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RgbColorModelHex(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RgbColorModelHex(string outerXml)
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
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (48 == (int) namespaceId && "legacySpreadsheetColorIndex" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RgbColorModelHex>(deep);
    }
  }
}
