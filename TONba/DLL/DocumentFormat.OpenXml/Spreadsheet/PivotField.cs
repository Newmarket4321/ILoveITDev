// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotField
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Items))]
  [ChildElementInfo(typeof (AutoSortScope))]
  [ChildElementInfo(typeof (PivotFieldExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotField : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[48]
    {
      "name",
      "axis",
      "dataField",
      "subtotalCaption",
      "showDropDowns",
      "hiddenLevel",
      "uniqueMemberProperty",
      "compact",
      "allDrilled",
      "numFmtId",
      "outline",
      "subtotalTop",
      "dragToRow",
      "dragToCol",
      "multipleItemSelectionAllowed",
      "dragToPage",
      "dragToData",
      "dragOff",
      "showAll",
      "insertBlankRow",
      "serverField",
      "insertPageBreak",
      "autoShow",
      "topAutoShow",
      "hideNewItems",
      "measureFilter",
      "includeNewItemsInFilter",
      "itemPageCount",
      "sortType",
      "dataSourceSort",
      "nonAutoSortDefault",
      "rankBy",
      "defaultSubtotal",
      "sumSubtotal",
      "countASubtotal",
      "avgSubtotal",
      "maxSubtotal",
      "minSubtotal",
      "productSubtotal",
      "countSubtotal",
      "stdDevSubtotal",
      "stdDevPSubtotal",
      "varSubtotal",
      "varPSubtotal",
      "showPropCell",
      "showPropTip",
      "showPropAsCaption",
      "defaultAttributeDrillState"
    };
    private static byte[] attributeNamespaceIds = new byte[48];
    private static readonly string[] eleTagNames = new string[3]
    {
      "items",
      "autoSortScope",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "pivotField";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11168;

    public override string LocalName
    {
      get
      {
        return "pivotField";
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
        return 11168;
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
        return PivotField.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotField.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "axis")]
    public EnumValue<PivotTableAxisValues> Axis
    {
      get
      {
        return (EnumValue<PivotTableAxisValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dataField")]
    public BooleanValue DataField
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

    [SchemaAttr(0, "subtotalCaption")]
    public StringValue SubtotalCaption
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showDropDowns")]
    public BooleanValue ShowDropDowns
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

    [SchemaAttr(0, "hiddenLevel")]
    public BooleanValue HiddenLevel
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

    [SchemaAttr(0, "uniqueMemberProperty")]
    public StringValue UniqueMemberProperty
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

    [SchemaAttr(0, "compact")]
    public BooleanValue Compact
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "allDrilled")]
    public BooleanValue AllDrilled
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "numFmtId")]
    public UInt32Value NumberFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "subtotalTop")]
    public BooleanValue SubtotalTop
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dragToRow")]
    public BooleanValue DragToRow
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dragToCol")]
    public BooleanValue DragToColumn
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "multipleItemSelectionAllowed")]
    public BooleanValue MultipleItemSelectionAllowed
    {
      get
      {
        return (BooleanValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dragToPage")]
    public BooleanValue DragToPage
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

    [SchemaAttr(0, "dragToData")]
    public BooleanValue DragToData
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

    [SchemaAttr(0, "dragOff")]
    public BooleanValue DragOff
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

    [SchemaAttr(0, "showAll")]
    public BooleanValue ShowAll
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

    [SchemaAttr(0, "insertBlankRow")]
    public BooleanValue InsertBlankRow
    {
      get
      {
        return (BooleanValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "serverField")]
    public BooleanValue ServerField
    {
      get
      {
        return (BooleanValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insertPageBreak")]
    public BooleanValue InsertPageBreak
    {
      get
      {
        return (BooleanValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoShow")]
    public BooleanValue AutoShow
    {
      get
      {
        return (BooleanValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "topAutoShow")]
    public BooleanValue TopAutoShow
    {
      get
      {
        return (BooleanValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hideNewItems")]
    public BooleanValue HideNewItems
    {
      get
      {
        return (BooleanValue) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "measureFilter")]
    public BooleanValue MeasureFilter
    {
      get
      {
        return (BooleanValue) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "includeNewItemsInFilter")]
    public BooleanValue IncludeNewItemsInFilter
    {
      get
      {
        return (BooleanValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "itemPageCount")]
    public UInt32Value ItemPageCount
    {
      get
      {
        return (UInt32Value) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sortType")]
    public EnumValue<FieldSortValues> SortType
    {
      get
      {
        return (EnumValue<FieldSortValues>) this.Attributes[28];
      }
      set
      {
        this.Attributes[28] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dataSourceSort")]
    public BooleanValue DataSourceSort
    {
      get
      {
        return (BooleanValue) this.Attributes[29];
      }
      set
      {
        this.Attributes[29] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "nonAutoSortDefault")]
    public BooleanValue NonAutoSortDefault
    {
      get
      {
        return (BooleanValue) this.Attributes[30];
      }
      set
      {
        this.Attributes[30] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rankBy")]
    public UInt32Value RankBy
    {
      get
      {
        return (UInt32Value) this.Attributes[31];
      }
      set
      {
        this.Attributes[31] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "defaultSubtotal")]
    public BooleanValue DefaultSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[32];
      }
      set
      {
        this.Attributes[32] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sumSubtotal")]
    public BooleanValue SumSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[33];
      }
      set
      {
        this.Attributes[33] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "countASubtotal")]
    public BooleanValue CountASubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[34];
      }
      set
      {
        this.Attributes[34] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "avgSubtotal")]
    public BooleanValue AverageSubTotal
    {
      get
      {
        return (BooleanValue) this.Attributes[35];
      }
      set
      {
        this.Attributes[35] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "maxSubtotal")]
    public BooleanValue MaxSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[36];
      }
      set
      {
        this.Attributes[36] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minSubtotal")]
    public BooleanValue MinSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[37];
      }
      set
      {
        this.Attributes[37] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "productSubtotal")]
    public BooleanValue ApplyProductInSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[38];
      }
      set
      {
        this.Attributes[38] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "countSubtotal")]
    public BooleanValue CountSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[39];
      }
      set
      {
        this.Attributes[39] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stdDevSubtotal")]
    public BooleanValue ApplyStandardDeviationInSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[40];
      }
      set
      {
        this.Attributes[40] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stdDevPSubtotal")]
    public BooleanValue ApplyStandardDeviationPInSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[41];
      }
      set
      {
        this.Attributes[41] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "varSubtotal")]
    public BooleanValue ApplyVarianceInSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[42];
      }
      set
      {
        this.Attributes[42] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "varPSubtotal")]
    public BooleanValue ApplyVariancePInSubtotal
    {
      get
      {
        return (BooleanValue) this.Attributes[43];
      }
      set
      {
        this.Attributes[43] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showPropCell")]
    public BooleanValue ShowPropCell
    {
      get
      {
        return (BooleanValue) this.Attributes[44];
      }
      set
      {
        this.Attributes[44] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showPropTip")]
    public BooleanValue ShowPropertyTooltip
    {
      get
      {
        return (BooleanValue) this.Attributes[45];
      }
      set
      {
        this.Attributes[45] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showPropAsCaption")]
    public BooleanValue ShowPropAsCaption
    {
      get
      {
        return (BooleanValue) this.Attributes[46];
      }
      set
      {
        this.Attributes[46] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "defaultAttributeDrillState")]
    public BooleanValue DefaultAttributeDrillState
    {
      get
      {
        return (BooleanValue) this.Attributes[47];
      }
      set
      {
        this.Attributes[47] = (OpenXmlSimpleType) value;
      }
    }

    public PivotField()
    {
    }

    public PivotField(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotField(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotField(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "items" == name)
        return (OpenXmlElement) new Items();
      if (22 == (int) namespaceId && "autoSortScope" == name)
        return (OpenXmlElement) new AutoSortScope();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PivotFieldExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotField.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotField.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Items Items
    {
      get
      {
        return this.GetElement<Items>(0);
      }
      set
      {
        this.SetElement<Items>(0, value);
      }
    }

    public AutoSortScope AutoSortScope
    {
      get
      {
        return this.GetElement<AutoSortScope>(1);
      }
      set
      {
        this.SetElement<AutoSortScope>(1, value);
      }
    }

    public PivotFieldExtensionList PivotFieldExtensionList
    {
      get
      {
        return this.GetElement<PivotFieldExtensionList>(2);
      }
      set
      {
        this.SetElement<PivotFieldExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "axis" == name)
        return (OpenXmlSimpleType) new EnumValue<PivotTableAxisValues>();
      if ((int) namespaceId == 0 && "dataField" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "subtotalCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "showDropDowns" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hiddenLevel" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "uniqueMemberProperty" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "compact" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "allDrilled" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "numFmtId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "outline" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "subtotalTop" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "multipleItemSelectionAllowed" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToPage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragOff" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showAll" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "insertBlankRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "serverField" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "insertPageBreak" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoShow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "topAutoShow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hideNewItems" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "measureFilter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "includeNewItemsInFilter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "itemPageCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "sortType" == name)
        return (OpenXmlSimpleType) new EnumValue<FieldSortValues>();
      if ((int) namespaceId == 0 && "dataSourceSort" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "nonAutoSortDefault" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rankBy" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "defaultSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sumSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "countASubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "avgSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "maxSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "minSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "productSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "countSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "stdDevSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "stdDevPSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "varSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "varPSubtotal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showPropCell" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showPropTip" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showPropAsCaption" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "defaultAttributeDrillState" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotField>(deep);
    }
  }
}
