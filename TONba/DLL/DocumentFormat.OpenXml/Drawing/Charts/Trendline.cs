// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Trendline
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (TrendlineName))]
  [ChildElementInfo(typeof (TrendlineType))]
  [ChildElementInfo(typeof (PolynomialOrder))]
  [ChildElementInfo(typeof (Period))]
  [ChildElementInfo(typeof (Forward))]
  [ChildElementInfo(typeof (Backward))]
  [ChildElementInfo(typeof (Intercept))]
  [ChildElementInfo(typeof (DisplayRSquaredValue))]
  [ChildElementInfo(typeof (DisplayEquation))]
  [ChildElementInfo(typeof (TrendlineLabel))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class Trendline : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[12]
    {
      "name",
      "spPr",
      "trendlineType",
      "order",
      "period",
      "forward",
      "backward",
      "intercept",
      "dispRSqr",
      "dispEq",
      "trendlineLbl",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[12]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
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
    private const string tagName = "trendline";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10581;

    public override string LocalName
    {
      get
      {
        return "trendline";
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
        return 10581;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Trendline()
    {
    }

    public Trendline(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Trendline(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Trendline(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new TrendlineName();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "trendlineType" == name)
        return (OpenXmlElement) new TrendlineType();
      if (11 == (int) namespaceId && "order" == name)
        return (OpenXmlElement) new PolynomialOrder();
      if (11 == (int) namespaceId && "period" == name)
        return (OpenXmlElement) new Period();
      if (11 == (int) namespaceId && "forward" == name)
        return (OpenXmlElement) new Forward();
      if (11 == (int) namespaceId && "backward" == name)
        return (OpenXmlElement) new Backward();
      if (11 == (int) namespaceId && "intercept" == name)
        return (OpenXmlElement) new Intercept();
      if (11 == (int) namespaceId && "dispRSqr" == name)
        return (OpenXmlElement) new DisplayRSquaredValue();
      if (11 == (int) namespaceId && "dispEq" == name)
        return (OpenXmlElement) new DisplayEquation();
      if (11 == (int) namespaceId && "trendlineLbl" == name)
        return (OpenXmlElement) new TrendlineLabel();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Trendline.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Trendline.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TrendlineName TrendlineName
    {
      get
      {
        return this.GetElement<TrendlineName>(0);
      }
      set
      {
        this.SetElement<TrendlineName>(0, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(1);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(1, value);
      }
    }

    public TrendlineType TrendlineType
    {
      get
      {
        return this.GetElement<TrendlineType>(2);
      }
      set
      {
        this.SetElement<TrendlineType>(2, value);
      }
    }

    public PolynomialOrder PolynomialOrder
    {
      get
      {
        return this.GetElement<PolynomialOrder>(3);
      }
      set
      {
        this.SetElement<PolynomialOrder>(3, value);
      }
    }

    public Period Period
    {
      get
      {
        return this.GetElement<Period>(4);
      }
      set
      {
        this.SetElement<Period>(4, value);
      }
    }

    public Forward Forward
    {
      get
      {
        return this.GetElement<Forward>(5);
      }
      set
      {
        this.SetElement<Forward>(5, value);
      }
    }

    public Backward Backward
    {
      get
      {
        return this.GetElement<Backward>(6);
      }
      set
      {
        this.SetElement<Backward>(6, value);
      }
    }

    public Intercept Intercept
    {
      get
      {
        return this.GetElement<Intercept>(7);
      }
      set
      {
        this.SetElement<Intercept>(7, value);
      }
    }

    public DisplayRSquaredValue DisplayRSquaredValue
    {
      get
      {
        return this.GetElement<DisplayRSquaredValue>(8);
      }
      set
      {
        this.SetElement<DisplayRSquaredValue>(8, value);
      }
    }

    public DisplayEquation DisplayEquation
    {
      get
      {
        return this.GetElement<DisplayEquation>(9);
      }
      set
      {
        this.SetElement<DisplayEquation>(9, value);
      }
    }

    public TrendlineLabel TrendlineLabel
    {
      get
      {
        return this.GetElement<TrendlineLabel>(10);
      }
      set
      {
        this.SetElement<TrendlineLabel>(10, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(11);
      }
      set
      {
        this.SetElement<ExtensionList>(11, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Trendline>(deep);
    }
  }
}
