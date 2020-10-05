// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Chart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (AutoTitleDeleted))]
  [ChildElementInfo(typeof (Title))]
  [ChildElementInfo(typeof (PivotFormats))]
  [ChildElementInfo(typeof (View3D))]
  [ChildElementInfo(typeof (Floor))]
  [ChildElementInfo(typeof (SideWall))]
  [ChildElementInfo(typeof (BackWall))]
  [ChildElementInfo(typeof (PlotArea))]
  [ChildElementInfo(typeof (Legend))]
  [ChildElementInfo(typeof (PlotVisibleOnly))]
  [ChildElementInfo(typeof (DisplayBlanksAs))]
  [ChildElementInfo(typeof (ShowDataLabelsOverMaximum))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class Chart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[13]
    {
      "title",
      "autoTitleDeleted",
      "pivotFmts",
      "view3D",
      "floor",
      "sideWall",
      "backWall",
      "plotArea",
      "legend",
      "plotVisOnly",
      "dispBlanksAs",
      "showDLblsOverMax",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[13]
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
      (byte) 11
    };
    private const string tagName = "chart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10646;

    public override string LocalName
    {
      get
      {
        return "chart";
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
        return 10646;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Chart()
    {
    }

    public Chart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Chart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Chart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new Title();
      if (11 == (int) namespaceId && "autoTitleDeleted" == name)
        return (OpenXmlElement) new AutoTitleDeleted();
      if (11 == (int) namespaceId && "pivotFmts" == name)
        return (OpenXmlElement) new PivotFormats();
      if (11 == (int) namespaceId && "view3D" == name)
        return (OpenXmlElement) new View3D();
      if (11 == (int) namespaceId && "floor" == name)
        return (OpenXmlElement) new Floor();
      if (11 == (int) namespaceId && "sideWall" == name)
        return (OpenXmlElement) new SideWall();
      if (11 == (int) namespaceId && "backWall" == name)
        return (OpenXmlElement) new BackWall();
      if (11 == (int) namespaceId && "plotArea" == name)
        return (OpenXmlElement) new PlotArea();
      if (11 == (int) namespaceId && "legend" == name)
        return (OpenXmlElement) new Legend();
      if (11 == (int) namespaceId && "plotVisOnly" == name)
        return (OpenXmlElement) new PlotVisibleOnly();
      if (11 == (int) namespaceId && "dispBlanksAs" == name)
        return (OpenXmlElement) new DisplayBlanksAs();
      if (11 == (int) namespaceId && "showDLblsOverMax" == name)
        return (OpenXmlElement) new ShowDataLabelsOverMaximum();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Chart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Chart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Title Title
    {
      get
      {
        return this.GetElement<Title>(0);
      }
      set
      {
        this.SetElement<Title>(0, value);
      }
    }

    public AutoTitleDeleted AutoTitleDeleted
    {
      get
      {
        return this.GetElement<AutoTitleDeleted>(1);
      }
      set
      {
        this.SetElement<AutoTitleDeleted>(1, value);
      }
    }

    public PivotFormats PivotFormats
    {
      get
      {
        return this.GetElement<PivotFormats>(2);
      }
      set
      {
        this.SetElement<PivotFormats>(2, value);
      }
    }

    public View3D View3D
    {
      get
      {
        return this.GetElement<View3D>(3);
      }
      set
      {
        this.SetElement<View3D>(3, value);
      }
    }

    public Floor Floor
    {
      get
      {
        return this.GetElement<Floor>(4);
      }
      set
      {
        this.SetElement<Floor>(4, value);
      }
    }

    public SideWall SideWall
    {
      get
      {
        return this.GetElement<SideWall>(5);
      }
      set
      {
        this.SetElement<SideWall>(5, value);
      }
    }

    public BackWall BackWall
    {
      get
      {
        return this.GetElement<BackWall>(6);
      }
      set
      {
        this.SetElement<BackWall>(6, value);
      }
    }

    public PlotArea PlotArea
    {
      get
      {
        return this.GetElement<PlotArea>(7);
      }
      set
      {
        this.SetElement<PlotArea>(7, value);
      }
    }

    public Legend Legend
    {
      get
      {
        return this.GetElement<Legend>(8);
      }
      set
      {
        this.SetElement<Legend>(8, value);
      }
    }

    public PlotVisibleOnly PlotVisibleOnly
    {
      get
      {
        return this.GetElement<PlotVisibleOnly>(9);
      }
      set
      {
        this.SetElement<PlotVisibleOnly>(9, value);
      }
    }

    public DisplayBlanksAs DisplayBlanksAs
    {
      get
      {
        return this.GetElement<DisplayBlanksAs>(10);
      }
      set
      {
        this.SetElement<DisplayBlanksAs>(10, value);
      }
    }

    public ShowDataLabelsOverMaximum ShowDataLabelsOverMaximum
    {
      get
      {
        return this.GetElement<ShowDataLabelsOverMaximum>(11);
      }
      set
      {
        this.SetElement<ShowDataLabelsOverMaximum>(11, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(12);
      }
      set
      {
        this.SetElement<ExtensionList>(12, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Chart>(deep);
    }
  }
}
