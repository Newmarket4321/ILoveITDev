// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.BubbleChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (BubbleChartSeries))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (BubbleScale))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (Bubble3D))]
  [ChildElementInfo(typeof (SizeRepresents))]
  [ChildElementInfo(typeof (BubbleChartExtensionList))]
  [ChildElementInfo(typeof (ShowNegativeBubbles))]
  [ChildElementInfo(typeof (AxisId))]
  public class BubbleChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "varyColors",
      "ser",
      "dLbls",
      "bubble3D",
      "bubbleScale",
      "showNegBubbles",
      "sizeRepresents",
      "axId",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "bubbleChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10524;

    public override string LocalName
    {
      get
      {
        return "bubbleChart";
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
        return 10524;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BubbleChart()
    {
    }

    public BubbleChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BubbleChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BubbleChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new BubbleChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "bubble3D" == name)
        return (OpenXmlElement) new Bubble3D();
      if (11 == (int) namespaceId && "bubbleScale" == name)
        return (OpenXmlElement) new BubbleScale();
      if (11 == (int) namespaceId && "showNegBubbles" == name)
        return (OpenXmlElement) new ShowNegativeBubbles();
      if (11 == (int) namespaceId && "sizeRepresents" == name)
        return (OpenXmlElement) new SizeRepresents();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new BubbleChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BubbleChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BubbleChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public VaryColors VaryColors
    {
      get
      {
        return this.GetElement<VaryColors>(0);
      }
      set
      {
        this.SetElement<VaryColors>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BubbleChart>(deep);
    }
  }
}
