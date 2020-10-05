// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ColorMostRecentlyUsed
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.HslColor))]
  [ChildElementInfo(typeof (PresetColor))]
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (SchemeColor))]
  public class ColorMostRecentlyUsed : OpenXmlCompositeElement
  {
    private const string tagName = "clrMru";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12430;

    public override string LocalName
    {
      get
      {
        return "clrMru";
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
        return 12430;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ColorMostRecentlyUsed()
    {
    }

    public ColorMostRecentlyUsed(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorMostRecentlyUsed(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorMostRecentlyUsed(string outerXml)
      : base(outerXml)
    {
    }

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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorMostRecentlyUsed>(deep);
    }
  }
}
