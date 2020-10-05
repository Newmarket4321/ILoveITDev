// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RunProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Color))]
  [ChildElementInfo(typeof (RunFont))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Bold))]
  [ChildElementInfo(typeof (Italic))]
  [ChildElementInfo(typeof (Strike))]
  [ChildElementInfo(typeof (Condense))]
  [ChildElementInfo(typeof (Extend))]
  [ChildElementInfo(typeof (Outline))]
  [ChildElementInfo(typeof (Shadow))]
  [ChildElementInfo(typeof (Underline))]
  [ChildElementInfo(typeof (VerticalTextAlignment))]
  [ChildElementInfo(typeof (FontSize))]
  [ChildElementInfo(typeof (FontFamily))]
  [ChildElementInfo(typeof (RunPropertyCharSet))]
  [ChildElementInfo(typeof (FontScheme))]
  public class RunProperties : OpenXmlCompositeElement
  {
    private const string tagName = "rPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11214;

    public override string LocalName
    {
      get
      {
        return "rPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11214;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RunProperties()
    {
    }

    public RunProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RunProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RunProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "b" == name)
        return (OpenXmlElement) new Bold();
      if (22 == (int) namespaceId && "i" == name)
        return (OpenXmlElement) new Italic();
      if (22 == (int) namespaceId && "strike" == name)
        return (OpenXmlElement) new Strike();
      if (22 == (int) namespaceId && "condense" == name)
        return (OpenXmlElement) new Condense();
      if (22 == (int) namespaceId && "extend" == name)
        return (OpenXmlElement) new Extend();
      if (22 == (int) namespaceId && "outline" == name)
        return (OpenXmlElement) new Outline();
      if (22 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new Shadow();
      if (22 == (int) namespaceId && "u" == name)
        return (OpenXmlElement) new Underline();
      if (22 == (int) namespaceId && "vertAlign" == name)
        return (OpenXmlElement) new VerticalTextAlignment();
      if (22 == (int) namespaceId && "sz" == name)
        return (OpenXmlElement) new FontSize();
      if (22 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      if (22 == (int) namespaceId && "rFont" == name)
        return (OpenXmlElement) new RunFont();
      if (22 == (int) namespaceId && "family" == name)
        return (OpenXmlElement) new FontFamily();
      if (22 == (int) namespaceId && "charset" == name)
        return (OpenXmlElement) new RunPropertyCharSet();
      if (22 == (int) namespaceId && "scheme" == name)
        return (OpenXmlElement) new FontScheme();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RunProperties>(deep);
    }
  }
}
