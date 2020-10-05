// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PivotFormats
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (PivotFormat))]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotFormats : OpenXmlCompositeElement
  {
    private const string tagName = "pivotFmts";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10479;

    public override string LocalName
    {
      get
      {
        return "pivotFmts";
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
        return 10479;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotFormats()
    {
    }

    public PivotFormats(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotFormats(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotFormats(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "pivotFmt" == name)
        return (OpenXmlElement) new PivotFormat();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotFormats>(deep);
    }
  }
}
