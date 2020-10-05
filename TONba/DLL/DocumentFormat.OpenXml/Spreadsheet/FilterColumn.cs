// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.FilterColumn
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CustomFilters))]
  [ChildElementInfo(typeof (Filters))]
  [ChildElementInfo(typeof (Top10))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.CustomFilters), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ColorFilter))]
  [ChildElementInfo(typeof (DynamicFilter))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.IconFilter), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (IconFilter))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class FilterColumn : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "colId",
      "hiddenButton",
      "showButton"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[9]
    {
      "filters",
      "top10",
      "customFilters",
      "customFilters",
      "dynamicFilter",
      "colorFilter",
      "iconFilter",
      "iconFilter",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 22,
      (byte) 22,
      (byte) 53,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 53,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "filterColumn";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11115;

    public override string LocalName
    {
      get
      {
        return "filterColumn";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11115;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return FilterColumn.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FilterColumn.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "colId")]
    public UInt32Value ColumnId
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hiddenButton")]
    public BooleanValue HiddenButton
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showButton")]
    public BooleanValue ShowButton
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public FilterColumn()
    {
    }

    public FilterColumn(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FilterColumn(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FilterColumn(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "filters" == name)
        return (OpenXmlElement) new Filters();
      if (22 == (int) namespaceId && "top10" == name)
        return (OpenXmlElement) new Top10();
      if (53 == (int) namespaceId && "customFilters" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.CustomFilters();
      if (22 == (int) namespaceId && "customFilters" == name)
        return (OpenXmlElement) new CustomFilters();
      if (22 == (int) namespaceId && "dynamicFilter" == name)
        return (OpenXmlElement) new DynamicFilter();
      if (22 == (int) namespaceId && "colorFilter" == name)
        return (OpenXmlElement) new ColorFilter();
      if (53 == (int) namespaceId && "iconFilter" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.IconFilter();
      if (22 == (int) namespaceId && "iconFilter" == name)
        return (OpenXmlElement) new IconFilter();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FilterColumn.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FilterColumn.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public Filters Filters
    {
      get
      {
        return this.GetElement<Filters>(0);
      }
      set
      {
        this.SetElement<Filters>(0, value);
      }
    }

    public Top10 Top10
    {
      get
      {
        return this.GetElement<Top10>(1);
      }
      set
      {
        this.SetElement<Top10>(1, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Excel.CustomFilters CustomFilters14
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Excel.CustomFilters>(2);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Excel.CustomFilters>(2, value);
      }
    }

    public CustomFilters CustomFilters
    {
      get
      {
        return this.GetElement<CustomFilters>(3);
      }
      set
      {
        this.SetElement<CustomFilters>(3, value);
      }
    }

    public DynamicFilter DynamicFilter
    {
      get
      {
        return this.GetElement<DynamicFilter>(4);
      }
      set
      {
        this.SetElement<DynamicFilter>(4, value);
      }
    }

    public ColorFilter ColorFilter
    {
      get
      {
        return this.GetElement<ColorFilter>(5);
      }
      set
      {
        this.SetElement<ColorFilter>(5, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Excel.IconFilter IconFilter14
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Excel.IconFilter>(6);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Excel.IconFilter>(6, value);
      }
    }

    public IconFilter IconFilter
    {
      get
      {
        return this.GetElement<IconFilter>(7);
      }
      set
      {
        this.SetElement<IconFilter>(7, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(8);
      }
      set
      {
        this.SetElement<ExtensionList>(8, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "colId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "hiddenButton" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showButton" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FilterColumn>(deep);
    }
  }
}
