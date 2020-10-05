// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (Layout))]
  [ChildElementInfo(typeof (TextProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ChartText))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  public class DisplayUnitsLabel : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "layout",
      "tx",
      "spPr",
      "txPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "dispUnitsLbl";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10470;

    public override string LocalName
    {
      get
      {
        return "dispUnitsLbl";
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
        return 10470;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DisplayUnitsLabel()
    {
    }

    public DisplayUnitsLabel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DisplayUnitsLabel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DisplayUnitsLabel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "layout" == name)
        return (OpenXmlElement) new Layout();
      if (11 == (int) namespaceId && "tx" == name)
        return (OpenXmlElement) new ChartText();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "txPr" == name)
        return (OpenXmlElement) new TextProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DisplayUnitsLabel.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DisplayUnitsLabel.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Layout Layout
    {
      get
      {
        return this.GetElement<Layout>(0);
      }
      set
      {
        this.SetElement<Layout>(0, value);
      }
    }

    public ChartText ChartText
    {
      get
      {
        return this.GetElement<ChartText>(1);
      }
      set
      {
        this.SetElement<ChartText>(1, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(2);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(2, value);
      }
    }

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(3);
      }
      set
      {
        this.SetElement<TextProperties>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DisplayUnitsLabel>(deep);
    }
  }
}
