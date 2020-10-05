﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Color3Type
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PresetColor), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (RgbColorModelPercentage), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.HslColor), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SystemColor), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SchemeColor))]
  public abstract class Color3Type : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "scrgbClr",
      "srgbClr",
      "hslClr",
      "sysClr",
      "schemeClr",
      "prstClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 10,
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
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.HslColor();
      if (10 == (int) namespaceId && "sysClr" == name)
        return (OpenXmlElement) new SystemColor();
      if (10 == (int) namespaceId && "schemeClr" == name)
        return (OpenXmlElement) new SchemeColor();
      if (10 == (int) namespaceId && "prstClr" == name)
        return (OpenXmlElement) new PresetColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Color3Type.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Color3Type.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
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

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public DocumentFormat.OpenXml.Drawing.HslColor HslColor
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Drawing.HslColor>(2);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Drawing.HslColor>(2, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
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

    public SchemeColor SchemeColor
    {
      get
      {
        return this.GetElement<SchemeColor>(4);
      }
      set
      {
        this.SetElement<SchemeColor>(4, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public PresetColor PresetColor
    {
      get
      {
        return this.GetElement<PresetColor>(5);
      }
      set
      {
        this.SetElement<PresetColor>(5, value);
      }
    }

    protected Color3Type()
    {
    }

    protected Color3Type(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected Color3Type(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected Color3Type(string outerXml)
      : base(outerXml)
    {
    }
  }
}
