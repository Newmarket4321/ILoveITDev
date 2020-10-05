// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheLevelData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (OlapSlicerCacheRanges), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class OlapSlicerCacheLevelData : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "uniqueName",
      "sourceCaption",
      "count",
      "sortOrder",
      "crossFilter"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[1]
    {
      "ranges"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 53
    };
    private const string tagName = "level";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13067;

    public override string LocalName
    {
      get
      {
        return "level";
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
        return 13067;
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
        return OlapSlicerCacheLevelData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OlapSlicerCacheLevelData.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sourceCaption")]
    public StringValue SourceCaption
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sortOrder")]
    public EnumValue<OlapSlicerCacheSortOrderValues> SortOrder
    {
      get
      {
        return (EnumValue<OlapSlicerCacheSortOrderValues>) this.Attributes[3];
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

    public OlapSlicerCacheLevelData()
    {
    }

    public OlapSlicerCacheLevelData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OlapSlicerCacheLevelData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OlapSlicerCacheLevelData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "ranges" == name)
        return (OpenXmlElement) new OlapSlicerCacheRanges();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OlapSlicerCacheLevelData.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OlapSlicerCacheLevelData.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OlapSlicerCacheRanges OlapSlicerCacheRanges
    {
      get
      {
        return this.GetElement<OlapSlicerCacheRanges>(0);
      }
      set
      {
        this.SetElement<OlapSlicerCacheRanges>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sourceCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sortOrder" == name)
        return (OpenXmlSimpleType) new EnumValue<OlapSlicerCacheSortOrderValues>();
      if ((int) namespaceId == 0 && "crossFilter" == name)
        return (OpenXmlSimpleType) new EnumValue<SlicerCacheCrossFilterValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OlapSlicerCacheLevelData>(deep);
    }
  }
}
