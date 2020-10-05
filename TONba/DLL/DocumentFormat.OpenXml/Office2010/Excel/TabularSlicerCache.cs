// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCache
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TabularSlicerCacheItems), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class TabularSlicerCache : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "pivotCacheId",
      "sortOrder",
      "customListSort",
      "showMissing",
      "crossFilter"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[2]
    {
      "items",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "tabular";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13061;

    public override string LocalName
    {
      get
      {
        return "tabular";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13061;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return TabularSlicerCache.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TabularSlicerCache.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
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

    [SchemaAttr(0, "sortOrder")]
    public EnumValue<TabularSlicerCacheSortOrderValues> SortOrder
    {
      get
      {
        return (EnumValue<TabularSlicerCacheSortOrderValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
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

    [SchemaAttr(0, "showMissing")]
    public BooleanValue ShowMissing
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "crossFilter")]
    public EnumValue<SlicerCacheCrossFilterValues> CrossFilter
    {
      get
      {
        return (EnumValue<SlicerCacheCrossFilterValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public TabularSlicerCache()
    {
    }

    public TabularSlicerCache(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TabularSlicerCache(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TabularSlicerCache(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "items" == name)
        return (OpenXmlElement) new TabularSlicerCacheItems();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TabularSlicerCache.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TabularSlicerCache.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TabularSlicerCacheItems TabularSlicerCacheItems
    {
      get
      {
        return this.GetElement<TabularSlicerCacheItems>(0);
      }
      set
      {
        this.SetElement<TabularSlicerCacheItems>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "pivotCacheId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sortOrder" == name)
        return (OpenXmlSimpleType) new EnumValue<TabularSlicerCacheSortOrderValues>();
      if ((int) namespaceId == 0 && "customListSort" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showMissing" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "crossFilter" == name)
        return (OpenXmlSimpleType) new EnumValue<SlicerCacheCrossFilterValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TabularSlicerCache>(deep);
    }
  }
}
