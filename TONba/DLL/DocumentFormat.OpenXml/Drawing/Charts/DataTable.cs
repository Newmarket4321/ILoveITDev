// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DataTable
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ShowOutlineBorder))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ShowHorizontalBorder))]
  [ChildElementInfo(typeof (ShowVerticalBorder))]
  [ChildElementInfo(typeof (ShowKeys))]
  [ChildElementInfo(typeof (TextProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class DataTable : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "showHorzBorder",
      "showVertBorder",
      "showOutline",
      "showKeys",
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
    private const string tagName = "dTable";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10529;

    public override string LocalName
    {
      get
      {
        return "dTable";
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
        return 10529;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataTable()
    {
    }

    public DataTable(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataTable(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataTable(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "showHorzBorder" == name)
        return (OpenXmlElement) new ShowHorizontalBorder();
      if (11 == (int) namespaceId && "showVertBorder" == name)
        return (OpenXmlElement) new ShowVerticalBorder();
      if (11 == (int) namespaceId && "showOutline" == name)
        return (OpenXmlElement) new ShowOutlineBorder();
      if (11 == (int) namespaceId && "showKeys" == name)
        return (OpenXmlElement) new ShowKeys();
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
        return DataTable.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataTable.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ShowHorizontalBorder ShowHorizontalBorder
    {
      get
      {
        return this.GetElement<ShowHorizontalBorder>(0);
      }
      set
      {
        this.SetElement<ShowHorizontalBorder>(0, value);
      }
    }

    public ShowVerticalBorder ShowVerticalBorder
    {
      get
      {
        return this.GetElement<ShowVerticalBorder>(1);
      }
      set
      {
        this.SetElement<ShowVerticalBorder>(1, value);
      }
    }

    public ShowOutlineBorder ShowOutlineBorder
    {
      get
      {
        return this.GetElement<ShowOutlineBorder>(2);
      }
      set
      {
        this.SetElement<ShowOutlineBorder>(2, value);
      }
    }

    public ShowKeys ShowKeys
    {
      get
      {
        return this.GetElement<ShowKeys>(3);
      }
      set
      {
        this.SetElement<ShowKeys>(3, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(4);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(4, value);
      }
    }

    public TextProperties TextProperties
    {
      get
      {
        return this.GetElement<TextProperties>(5);
      }
      set
      {
        this.SetElement<TextProperties>(5, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(6);
      }
      set
      {
        this.SetElement<ExtensionList>(6, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataTable>(deep);
    }
  }
}
