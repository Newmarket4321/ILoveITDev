// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotCacheDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (CalculatedMembers))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CacheSource))]
  [ChildElementInfo(typeof (CacheFields))]
  [ChildElementInfo(typeof (CacheHierarchies))]
  [ChildElementInfo(typeof (Kpis))]
  [ChildElementInfo(typeof (TupleCache))]
  [ChildElementInfo(typeof (CalculatedItems))]
  [ChildElementInfo(typeof (Dimensions))]
  [ChildElementInfo(typeof (MeasureGroups))]
  [ChildElementInfo(typeof (Maps))]
  [ChildElementInfo(typeof (PivotCacheDefinitionExtensionList))]
  public class PivotCacheDefinition : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[19]
    {
      "id",
      "invalid",
      "saveData",
      "refreshOnLoad",
      "optimizeMemory",
      "enableRefresh",
      "refreshedBy",
      "refreshedDateIso",
      "refreshedDate",
      "backgroundQuery",
      "missingItemsLimit",
      "createdVersion",
      "refreshedVersion",
      "minRefreshableVersion",
      "recordCount",
      "upgradeOnRefresh",
      "tupleCache",
      "supportSubquery",
      "supportAdvancedDrill"
    };
    private static byte[] attributeNamespaceIds = new byte[19]
    {
      (byte) 19,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[11]
    {
      "cacheSource",
      "cacheFields",
      "cacheHierarchies",
      "kpis",
      "tupleCache",
      "calculatedItems",
      "calculatedMembers",
      "dimensions",
      "measureGroups",
      "maps",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "pivotCacheDefinition";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11097;

    public override string LocalName
    {
      get
      {
        return "pivotCacheDefinition";
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
        return 11097;
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
        return PivotCacheDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotCacheDefinition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "invalid")]
    public BooleanValue Invalid
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

    [SchemaAttr(0, "saveData")]
    public BooleanValue SaveData
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

    [SchemaAttr(0, "refreshOnLoad")]
    public BooleanValue RefreshOnLoad
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

    [SchemaAttr(0, "optimizeMemory")]
    public BooleanValue OptimizeMemory
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "enableRefresh")]
    public BooleanValue EnableRefresh
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refreshedBy")]
    public StringValue RefreshedBy
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refreshedDateIso")]
    public DateTimeValue LastRefreshedDateIso
    {
      get
      {
        return (DateTimeValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refreshedDate")]
    public DoubleValue RefreshedDate
    {
      get
      {
        return (DoubleValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "backgroundQuery")]
    public BooleanValue BackgroundQuery
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "missingItemsLimit")]
    public UInt32Value MissingItemsLimit
    {
      get
      {
        return (UInt32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "createdVersion")]
    public ByteValue CreatedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refreshedVersion")]
    public ByteValue RefreshedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minRefreshableVersion")]
    public ByteValue MinRefreshableVersion
    {
      get
      {
        return (ByteValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "recordCount")]
    public UInt32Value RecordCount
    {
      get
      {
        return (UInt32Value) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "upgradeOnRefresh")]
    public BooleanValue UpgradeOnRefresh
    {
      get
      {
        return (BooleanValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tupleCache")]
    public BooleanValue IsTupleCache
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "supportSubquery")]
    public BooleanValue SupportSubquery
    {
      get
      {
        return (BooleanValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "supportAdvancedDrill")]
    public BooleanValue SupportAdvancedDrill
    {
      get
      {
        return (BooleanValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    internal PivotCacheDefinition(PivotTableCacheDefinitionPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(PivotTableCacheDefinitionPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public PivotTableCacheDefinitionPart PivotTableCacheDefinitionPart
    {
      get
      {
        return this.OpenXmlPart as PivotTableCacheDefinitionPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public PivotCacheDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotCacheDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotCacheDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public PivotCacheDefinition()
    {
    }

    public void Save(PivotTableCacheDefinitionPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "cacheSource" == name)
        return (OpenXmlElement) new CacheSource();
      if (22 == (int) namespaceId && "cacheFields" == name)
        return (OpenXmlElement) new CacheFields();
      if (22 == (int) namespaceId && "cacheHierarchies" == name)
        return (OpenXmlElement) new CacheHierarchies();
      if (22 == (int) namespaceId && "kpis" == name)
        return (OpenXmlElement) new Kpis();
      if (22 == (int) namespaceId && "tupleCache" == name)
        return (OpenXmlElement) new TupleCache();
      if (22 == (int) namespaceId && "calculatedItems" == name)
        return (OpenXmlElement) new CalculatedItems();
      if (22 == (int) namespaceId && "calculatedMembers" == name)
        return (OpenXmlElement) new CalculatedMembers();
      if (22 == (int) namespaceId && "dimensions" == name)
        return (OpenXmlElement) new Dimensions();
      if (22 == (int) namespaceId && "measureGroups" == name)
        return (OpenXmlElement) new MeasureGroups();
      if (22 == (int) namespaceId && "maps" == name)
        return (OpenXmlElement) new Maps();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PivotCacheDefinitionExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotCacheDefinition.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotCacheDefinition.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CacheSource CacheSource
    {
      get
      {
        return this.GetElement<CacheSource>(0);
      }
      set
      {
        this.SetElement<CacheSource>(0, value);
      }
    }

    public CacheFields CacheFields
    {
      get
      {
        return this.GetElement<CacheFields>(1);
      }
      set
      {
        this.SetElement<CacheFields>(1, value);
      }
    }

    public CacheHierarchies CacheHierarchies
    {
      get
      {
        return this.GetElement<CacheHierarchies>(2);
      }
      set
      {
        this.SetElement<CacheHierarchies>(2, value);
      }
    }

    public Kpis Kpis
    {
      get
      {
        return this.GetElement<Kpis>(3);
      }
      set
      {
        this.SetElement<Kpis>(3, value);
      }
    }

    public TupleCache TupleCache
    {
      get
      {
        return this.GetElement<TupleCache>(4);
      }
      set
      {
        this.SetElement<TupleCache>(4, value);
      }
    }

    public CalculatedItems CalculatedItems
    {
      get
      {
        return this.GetElement<CalculatedItems>(5);
      }
      set
      {
        this.SetElement<CalculatedItems>(5, value);
      }
    }

    public CalculatedMembers CalculatedMembers
    {
      get
      {
        return this.GetElement<CalculatedMembers>(6);
      }
      set
      {
        this.SetElement<CalculatedMembers>(6, value);
      }
    }

    public Dimensions Dimensions
    {
      get
      {
        return this.GetElement<Dimensions>(7);
      }
      set
      {
        this.SetElement<Dimensions>(7, value);
      }
    }

    public MeasureGroups MeasureGroups
    {
      get
      {
        return this.GetElement<MeasureGroups>(8);
      }
      set
      {
        this.SetElement<MeasureGroups>(8, value);
      }
    }

    public Maps Maps
    {
      get
      {
        return this.GetElement<Maps>(9);
      }
      set
      {
        this.SetElement<Maps>(9, value);
      }
    }

    public PivotCacheDefinitionExtensionList PivotCacheDefinitionExtensionList
    {
      get
      {
        return this.GetElement<PivotCacheDefinitionExtensionList>(10);
      }
      set
      {
        this.SetElement<PivotCacheDefinitionExtensionList>(10, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "invalid" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "saveData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "refreshOnLoad" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "optimizeMemory" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "enableRefresh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "refreshedBy" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "refreshedDateIso" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "refreshedDate" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "backgroundQuery" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "missingItemsLimit" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "createdVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "refreshedVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "minRefreshableVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "recordCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "upgradeOnRefresh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "tupleCache" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "supportSubquery" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "supportAdvancedDrill" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotCacheDefinition>(deep);
    }
  }
}
