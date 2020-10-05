﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ValueAxis
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (MinorGridlines))]
  [ChildElementInfo(typeof (AxisId))]
  [ChildElementInfo(typeof (Scaling))]
  [ChildElementInfo(typeof (Delete))]
  [ChildElementInfo(typeof (AxisPosition))]
  [ChildElementInfo(typeof (MajorGridlines))]
  [ChildElementInfo(typeof (CrossingAxis))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (MajorTickMark))]
  [ChildElementInfo(typeof (MinorTickMark))]
  [ChildElementInfo(typeof (TickLabelPosition))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (TextProperties))]
  [ChildElementInfo(typeof (Title))]
  [ChildElementInfo(typeof (Crosses))]
  [ChildElementInfo(typeof (CrossesAt))]
  [ChildElementInfo(typeof (CrossBetween))]
  [ChildElementInfo(typeof (MajorUnit))]
  [ChildElementInfo(typeof (MinorUnit))]
  [ChildElementInfo(typeof (DisplayUnits))]
  [ChildElementInfo(typeof (ValAxExtensionList))]
  public class ValueAxis : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[21]
    {
      "axId",
      "scaling",
      "delete",
      "axPos",
      "majorGridlines",
      "minorGridlines",
      "title",
      "numFmt",
      "majorTickMark",
      "minorTickMark",
      "tickLblPos",
      "spPr",
      "txPr",
      "crossAx",
      "crosses",
      "crossesAt",
      "crossBetween",
      "majorUnit",
      "minorUnit",
      "dispUnits",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[21]
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
    private const string tagName = "valAx";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10525;

    public override string LocalName
    {
      get
      {
        return "valAx";
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
        return 10525;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ValueAxis()
    {
    }

    public ValueAxis(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ValueAxis(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ValueAxis(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "scaling" == name)
        return (OpenXmlElement) new Scaling();
      if (11 == (int) namespaceId && "delete" == name)
        return (OpenXmlElement) new Delete();
      if (11 == (int) namespaceId && "axPos" == name)
        return (OpenXmlElement) new AxisPosition();
      if (11 == (int) namespaceId && "majorGridlines" == name)
        return (OpenXmlElement) new MajorGridlines();
      if (11 == (int) namespaceId && "minorGridlines" == name)
        return (OpenXmlElement) new MinorGridlines();
      if (11 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new Title();
      if (11 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlElement) new NumberingFormat();
      if (11 == (int) namespaceId && "majorTickMark" == name)
        return (OpenXmlElement) new MajorTickMark();
      if (11 == (int) namespaceId && "minorTickMark" == name)
        return (OpenXmlElement) new MinorTickMark();
      if (11 == (int) namespaceId && "tickLblPos" == name)
        return (OpenXmlElement) new TickLabelPosition();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "txPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (11 == (int) namespaceId && "crossAx" == name)
        return (OpenXmlElement) new CrossingAxis();
      if (11 == (int) namespaceId && "crosses" == name)
        return (OpenXmlElement) new Crosses();
      if (11 == (int) namespaceId && "crossesAt" == name)
        return (OpenXmlElement) new CrossesAt();
      if (11 == (int) namespaceId && "crossBetween" == name)
        return (OpenXmlElement) new CrossBetween();
      if (11 == (int) namespaceId && "majorUnit" == name)
        return (OpenXmlElement) new MajorUnit();
      if (11 == (int) namespaceId && "minorUnit" == name)
        return (OpenXmlElement) new MinorUnit();
      if (11 == (int) namespaceId && "dispUnits" == name)
        return (OpenXmlElement) new DisplayUnits();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ValAxExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ValueAxis.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ValueAxis.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AxisId AxisId
    {
      get
      {
        return this.GetElement<AxisId>(0);
      }
      set
      {
        this.SetElement<AxisId>(0, value);
      }
    }

    public Scaling Scaling
    {
      get
      {
        return this.GetElement<Scaling>(1);
      }
      set
      {
        this.SetElement<Scaling>(1, value);
      }
    }

    public Delete Delete
    {
      get
      {
        return this.GetElement<Delete>(2);
      }
      set
      {
        this.SetElement<Delete>(2, value);
      }
    }

    public AxisPosition AxisPosition
    {
      get
      {
        return this.GetElement<AxisPosition>(3);
      }
      set
      {
        this.SetElement<AxisPosition>(3, value);
      }
    }

    public MajorGridlines MajorGridlines
    {
      get
      {
        return this.GetElement<MajorGridlines>(4);
      }
      set
      {
        this.SetElement<MajorGridlines>(4, value);
      }
    }

    public MinorGridlines MinorGridlines
    {
      get
      {
        return this.GetElement<MinorGridlines>(5);
      }
      set
      {
        this.SetElement<MinorGridlines>(5, value);
      }
    }

    public Title Title
    {
      get
      {
        return this.GetElement<Title>(6);
      }
      set
      {
        this.SetElement<Title>(6, value);
      }
    }

    public NumberingFormat NumberingFormat
    {
      get
      {
        return this.GetElement<NumberingFormat>(7);
      }
      set
      {
        this.SetElement<NumberingFormat>(7, value);
      }
    }

    public MajorTickMark MajorTickMark
    {
      get
      {
        return this.GetElement<MajorTickMark>(8);
      }
      set
      {
        this.SetElement<MajorTickMark>(8, value);
      }
    }

    public MinorTickMark MinorTickMark
    {
      get
      {
        return this.GetElement<MinorTickMark>(9);
      }
      set
      {
        this.SetElement<MinorTickMark>(9, value);
      }
    }

    public TickLabelPosition TickLabelPosition
    {
      get
      {
        return this.GetElement<TickLabelPosition>(10);
      }
      set
      {
        this.SetElement<TickLabelPosition>(10, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(11);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(11, value);
      }
    }

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(12);
      }
      set
      {
        this.SetElement<TextProperties>(12, value);
      }
    }

    public CrossingAxis CrossingAxis
    {
      get
      {
        return this.GetElement<CrossingAxis>(13);
      }
      set
      {
        this.SetElement<CrossingAxis>(13, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ValueAxis>(deep);
    }
  }
}
