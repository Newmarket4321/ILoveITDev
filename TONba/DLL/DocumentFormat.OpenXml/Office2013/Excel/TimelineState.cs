// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.TimelineState
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (SelectionTimelineRange), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MovingPeriodState), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BoundsTimelineRange), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  public class TimelineState : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "singleRangeFilterState",
      "minimalRefreshVersion",
      "lastRefreshVersion",
      "pivotCacheId",
      "filterType",
      "filterId",
      "filterTabId",
      "filterPivotName"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private static readonly string[] eleTagNames = new string[4]
    {
      "selection",
      "bounds",
      "movingPeriodState",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 71,
      (byte) 71,
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "state";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13429;

    public override string LocalName
    {
      get
      {
        return "state";
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
        return 13429;
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
        return TimelineState.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TimelineState.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "singleRangeFilterState")]
    public BooleanValue SingleRangeFilterState
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minimalRefreshVersion")]
    public UInt32Value MinimalRefreshVersion
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

    [SchemaAttr(0, "lastRefreshVersion")]
    public UInt32Value LastRefreshVersion
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

    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filterType")]
    public EnumValue<PivotFilterValues> FilterType
    {
      get
      {
        return (EnumValue<PivotFilterValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filterId")]
    public UInt32Value FilterId
    {
      get
      {
        return (UInt32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filterTabId")]
    public UInt32Value FilterTabId
    {
      get
      {
        return (UInt32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filterPivotName")]
    public StringValue FilterPivotName
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    public TimelineState()
    {
    }

    public TimelineState(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimelineState(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimelineState(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "selection" == name)
        return (OpenXmlElement) new SelectionTimelineRange();
      if (71 == (int) namespaceId && "bounds" == name)
        return (OpenXmlElement) new BoundsTimelineRange();
      if (71 == (int) namespaceId && "movingPeriodState" == name)
        return (OpenXmlElement) new MovingPeriodState();
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TimelineState.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TimelineState.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SelectionTimelineRange SelectionTimelineRange
    {
      get
      {
        return this.GetElement<SelectionTimelineRange>(0);
      }
      set
      {
        this.SetElement<SelectionTimelineRange>(0, value);
      }
    }

    public BoundsTimelineRange BoundsTimelineRange
    {
      get
      {
        return this.GetElement<BoundsTimelineRange>(1);
      }
      set
      {
        this.SetElement<BoundsTimelineRange>(1, value);
      }
    }

    public MovingPeriodState MovingPeriodState
    {
      get
      {
        return this.GetElement<MovingPeriodState>(2);
      }
      set
      {
        this.SetElement<MovingPeriodState>(2, value);
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "singleRangeFilterState" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "minimalRefreshVersion" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "lastRefreshVersion" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "pivotCacheId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "filterType" == name)
        return (OpenXmlSimpleType) new EnumValue<PivotFilterValues>();
      if ((int) namespaceId == 0 && "filterId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "filterTabId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "filterPivotName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimelineState>(deep);
    }
  }
}
