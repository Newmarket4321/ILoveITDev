// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DataPoint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (InvertIfNegative))]
  [ChildElementInfo(typeof (Marker))]
  [ChildElementInfo(typeof (Bubble3D))]
  [ChildElementInfo(typeof (Explosion))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PictureOptions))]
  public class DataPoint : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "idx",
      "invertIfNegative",
      "marker",
      "bubble3D",
      "explosion",
      "spPr",
      "pictureOptions",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "dPt";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10580;

    public override string LocalName
    {
      get
      {
        return "dPt";
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
        return 10580;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataPoint()
    {
    }

    public DataPoint(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataPoint(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataPoint(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "idx" == name)
        return (OpenXmlElement) new Index();
      if (11 == (int) namespaceId && "invertIfNegative" == name)
        return (OpenXmlElement) new InvertIfNegative();
      if (11 == (int) namespaceId && "marker" == name)
        return (OpenXmlElement) new Marker();
      if (11 == (int) namespaceId && "bubble3D" == name)
        return (OpenXmlElement) new Bubble3D();
      if (11 == (int) namespaceId && "explosion" == name)
        return (OpenXmlElement) new Explosion();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "pictureOptions" == name)
        return (OpenXmlElement) new PictureOptions();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataPoint.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataPoint.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Index Index
    {
      get
      {
        return this.GetElement<Index>(0);
      }
      set
      {
        this.SetElement<Index>(0, value);
      }
    }

    public InvertIfNegative InvertIfNegative
    {
      get
      {
        return this.GetElement<InvertIfNegative>(1);
      }
      set
      {
        this.SetElement<InvertIfNegative>(1, value);
      }
    }

    public Marker Marker
    {
      get
      {
        return this.GetElement<Marker>(2);
      }
      set
      {
        this.SetElement<Marker>(2, value);
      }
    }

    public Bubble3D Bubble3D
    {
      get
      {
        return this.GetElement<Bubble3D>(3);
      }
      set
      {
        this.SetElement<Bubble3D>(3, value);
      }
    }

    public Explosion Explosion
    {
      get
      {
        return this.GetElement<Explosion>(4);
      }
      set
      {
        this.SetElement<Explosion>(4, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(5);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(5, value);
      }
    }

    public PictureOptions PictureOptions
    {
      get
      {
        return this.GetElement<PictureOptions>(6);
      }
      set
      {
        this.SetElement<PictureOptions>(6, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(7);
      }
      set
      {
        this.SetElement<ExtensionList>(7, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataPoint>(deep);
    }
  }
}
