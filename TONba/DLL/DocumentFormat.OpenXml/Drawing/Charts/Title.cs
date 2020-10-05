// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Title
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (Layout))]
  [ChildElementInfo(typeof (ChartText))]
  [ChildElementInfo(typeof (Overlay))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (TextProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class Title : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "tx",
      "layout",
      "overlay",
      "spPr",
      "txPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "title";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10385;

    public override string LocalName
    {
      get
      {
        return "title";
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
        return 10385;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Title()
    {
    }

    public Title(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Title(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Title(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "tx" == name)
        return (OpenXmlElement) new ChartText();
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
        return Title.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Title.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ChartText ChartText
    {
      get
      {
        return this.GetElement<ChartText>(0);
      }
      set
      {
        this.SetElement<ChartText>(0, value);
      }
    }

    public Layout Layout
    {
      get
      {
        return this.GetElement<Layout>(1);
      }
      set
      {
        this.SetElement<Layout>(1, value);
      }
    }

    public Overlay Overlay
    {
      get
      {
        return this.GetElement<Overlay>(2);
      }
      set
      {
        this.SetElement<Overlay>(2, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(3);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(3, value);
      }
    }

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(4);
      }
      set
      {
        this.SetElement<TextProperties>(4, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(5);
      }
      set
      {
        this.SetElement<ExtensionList>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Title>(deep);
    }
  }
}
