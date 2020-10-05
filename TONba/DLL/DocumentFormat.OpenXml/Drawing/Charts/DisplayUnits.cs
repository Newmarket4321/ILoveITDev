// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (CustomDisplayUnit))]
  [ChildElementInfo(typeof (BuiltInUnit))]
  [ChildElementInfo(typeof (DisplayUnitsLabel))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class DisplayUnits : OpenXmlCompositeElement
  {
    private const string tagName = "dispUnits";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10637;

    public override string LocalName
    {
      get
      {
        return "dispUnits";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10637;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DisplayUnits()
    {
    }

    public DisplayUnits(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DisplayUnits(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DisplayUnits(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "custUnit" == name)
        return (OpenXmlElement) new CustomDisplayUnit();
      if (11 == (int) namespaceId && "builtInUnit" == name)
        return (OpenXmlElement) new BuiltInUnit();
      if (11 == (int) namespaceId && "dispUnitsLbl" == name)
        return (OpenXmlElement) new DisplayUnitsLabel();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DisplayUnits>(deep);
    }
  }
}
