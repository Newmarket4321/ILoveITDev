// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Legend
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (LegendPosition))]
  [ChildElementInfo(typeof (LegendEntry))]
  [ChildElementInfo(typeof (Overlay))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (Layout))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TextProperties))]
  public class Legend : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "legendPos",
      "legendEntry",
      "layout",
      "overlay",
      "spPr",
      "txPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "legend";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10485;

    public override string LocalName
    {
      get
      {
        return "legend";
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
        return 10485;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Legend()
    {
    }

    public Legend(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Legend(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Legend(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "legendPos" == name)
        return (OpenXmlElement) new LegendPosition();
      if (11 == (int) namespaceId && "legendEntry" == name)
        return (OpenXmlElement) new LegendEntry();
      if (11 == (int) namespaceId && "layout" == name)
        return (OpenXmlElement) new Layout();
      if (11 == (int) namespaceId && "overlay" == name)
        return (OpenXmlElement) new Overlay();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "txPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Legend.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Legend.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LegendPosition LegendPosition
    {
      get
      {
        return this.GetElement<LegendPosition>(0);
      }
      set
      {
        this.SetElement<LegendPosition>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Legend>(deep);
    }
  }
}
