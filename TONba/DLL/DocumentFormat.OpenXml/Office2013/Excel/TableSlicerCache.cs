// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.TableSlicerCache
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class TableSlicerCache : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "tableId",
      "column",
      "sortOrder",
      "customListSort",
      "crossFilter"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 71
    };
    private const string tagName = "tableSlicerCache";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13382;

    public override string LocalName
    {
      get
      {
        return "tableSlicerCache";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13382;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return TableSlicerCache.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableSlicerCache.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "tableId")]
    public UInt32Value TableId
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

    [SchemaAttr(0, "column")]
    public UInt32Value Column
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sortOrder")]
    public EnumValue<TabularSlicerCacheSortOrderValues> SortOrder
    {
      get
      {
        return (EnumValue<TabularSlicerCacheSortOrderValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
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

    public TableSlicerCache()
    {
    }

    public TableSlicerCache(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableSlicerCache(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableSlicerCache(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableSlicerCache.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableSlicerCache.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "tableId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "column" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sortOrder" == name)
        return (OpenXmlSimpleType) new EnumValue<TabularSlicerCacheSortOrderValues>();
      if ((int) namespaceId == 0 && "customListSort" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "crossFilter" == name)
        return (OpenXmlSimpleType) new EnumValue<SlicerCacheCrossFilterValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableSlicerCache>(deep);
    }
  }
}
