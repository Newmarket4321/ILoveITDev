// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PivotFormat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (DataLabel))]
  [ChildElementInfo(typeof (Marker))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (ShapeProperties))]
  public class PivotFormat : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "idx",
      "spPr",
      "marker",
      "dLbl",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "pivotFmt";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10475;

    public override string LocalName
    {
      get
      {
        return "pivotFmt";
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
        return 10475;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotFormat()
    {
    }

    public PivotFormat(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotFormat(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotFormat(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "idx" == name)
        return (OpenXmlElement) new Index();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (11 == (int) namespaceId && "marker" == name)
        return (OpenXmlElement) new Marker();
      if (11 == (int) namespaceId && "dLbl" == name)
        return (OpenXmlElement) new DataLabel();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotFormat.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotFormat.eleNamespaceIds;
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

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(1);
      }
      set
      {
        this.SetElement<ShapeProperties>(1, value);
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

    public DataLabel DataLabel
    {
      get
      {
        return this.GetElement<DataLabel>(3);
      }
      set
      {
        this.SetElement<DataLabel>(3, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotFormat>(deep);
    }
  }
}
