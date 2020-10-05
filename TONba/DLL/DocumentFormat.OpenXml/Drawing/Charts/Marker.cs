// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Marker
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (Symbol))]
  [ChildElementInfo(typeof (Size))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public class Marker : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "symbol",
      "size",
      "spPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "marker";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10432;

    public override string LocalName
    {
      get
      {
        return "marker";
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
        return 10432;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Marker()
    {
    }

    public Marker(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Marker(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Marker(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "symbol" == name)
        return (OpenXmlElement) new Symbol();
      if (11 == (int) namespaceId && "size" == name)
        return (OpenXmlElement) new Size();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Marker.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Marker.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Symbol Symbol
    {
      get
      {
        return this.GetElement<Symbol>(0);
      }
      set
      {
        this.SetElement<Symbol>(0, value);
      }
    }

    public Size Size
    {
      get
      {
        return this.GetElement<Size>(1);
      }
      set
      {
        this.SetElement<Size>(1, value);
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

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Marker>(deep);
    }
  }
}
