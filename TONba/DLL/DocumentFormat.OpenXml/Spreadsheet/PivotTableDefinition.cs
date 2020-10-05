// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Formats))]
  [ChildElementInfo(typeof (PivotTableDefinitionExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ChartFormats))]
  [ChildElementInfo(typeof (PivotHierarchies))]
  [ChildElementInfo(typeof (ColumnHierarchiesUsage))]
  [ChildElementInfo(typeof (PivotFields))]
  [ChildElementInfo(typeof (RowFields))]
  [ChildElementInfo(typeof (RowItems))]
  [ChildElementInfo(typeof (ColumnFields))]
  [ChildElementInfo(typeof (ColumnItems))]
  [ChildElementInfo(typeof (PageFields))]
  [ChildElementInfo(typeof (DataFields))]
  [ChildElementInfo(typeof (ConditionalFormats))]
  [ChildElementInfo(typeof (Location))]
  [ChildElementInfo(typeof (PivotTableStyle))]
  [ChildElementInfo(typeof (PivotFilters))]
  [ChildElementInfo(typeof (RowHierarchiesUsage))]
  public class PivotTableDefinition : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[68]
    {
      "name",
      "cacheId",
      "dataOnRows",
      "dataPosition",
      "autoFormatId",
      "applyNumberFormats",
      "applyBorderFormats",
      "applyFontFormats",
      "applyPatternFormats",
      "applyAlignmentFormats",
      "applyWidthHeightFormats",
      "dataCaption",
      "grandTotalCaption",
      "errorCaption",
      "showError",
      "missingCaption",
      "showMissing",
      "pageStyle",
      "pivotTableStyle",
      "vacatedStyle",
      "tag",
      "updatedVersion",
      "minRefreshableVersion",
      "asteriskTotals",
      "showItems",
      "editData",
      "disableFieldList",
      "showCalcMbrs",
      "visualTotals",
      "showMultipleLabel",
      "showDataDropDown",
      "showDrill",
      "printDrill",
      "showMemberPropertyTips",
      "showDataTips",
      "enableWizard",
      "enableDrill",
      "enableFieldProperties",
      "preserveFormatting",
      "useAutoFormatting",
      "pageWrap",
      "pageOverThenDown",
      "subtotalHiddenItems",
      "rowGrandTotals",
      "colGrandTotals",
      "fieldPrintTitles",
      "itemPrintTitles",
      "mergeItem",
      "showDropZones",
      "createdVersion",
      "indent",
      "showEmptyRow",
      "showEmptyCol",
      "showHeaders",
      "compact",
      "outline",
      "outlineData",
      "compactData",
      "published",
      "gridDropZones",
      "immersive",
      "multipleFieldFilters",
      "chartFormat",
      "rowHeaderCaption",
      "colHeaderCaption",
      "fieldListSortAscending",
      "mdxSubqueries",
      "customListSort"
    };
    private static byte[] attributeNamespaceIds = new byte[68];
    private static readonly string[] eleTagNames = new string[17]
    {
      "location",
      "pivotFields",
      "rowFields",
      "rowItems",
      "colFields",
      "colItems",
      "pageFields",
      "dataFields",
      "formats",
      "conditionalFormats",
      "chartFormats",
      "pivotHierarchies",
      "pivotTableStyleInfo",
      "filters",
      "rowHierarchiesUsage",
      "colHierarchiesUsage",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[17]
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
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "pivotTableDefinition";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11099;

    public override string LocalName
    {
      get
      {
        return "pivotTableDefinition";
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
        return 11099;
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
        return PivotTableDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotTableDefinition.attributeNamespaceIds;
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

    [SchemaAttr(0, "cacheId")]
    public UInt32Value CacheId
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

    [SchemaAttr(0, "dataOnRows")]
    public BooleanValue DataOnRows
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

    [SchemaAttr(0, "dataPosition")]
    public UInt32Value DataPosition
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

    [SchemaAttr(0, "autoFormatId")]
    public UInt32Value AutoFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "applyNumberFormats")]
    public BooleanValue ApplyNumberFormats
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

    [SchemaAttr(0, "applyBorderFormats")]
    public BooleanValue ApplyBorderFormats
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "applyFontFormats")]
    public BooleanValue ApplyFontFormats
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

    [SchemaAttr(0, "applyPatternFormats")]
    public BooleanValue ApplyPatternFormats
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

    [SchemaAttr(0, "applyAlignmentFormats")]
    public BooleanValue ApplyAlignmentFormats
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

    [SchemaAttr(0, "applyWidthHeightFormats")]
    public BooleanValue ApplyWidthHeightFormats
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

    [SchemaAttr(0, "dataCaption")]
    public StringValue DataCaption
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "grandTotalCaption")]
    public StringValue GrandTotalCaption
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "errorCaption")]
    public StringValue ErrorCaption
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showError")]
    public BooleanValue ShowError
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

    [SchemaAttr(0, "missingCaption")]
    public StringValue MissingCaption
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showMissing")]
    public BooleanValue ShowMissing
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

    [SchemaAttr(0, "pageStyle")]
    public StringValue PageStyle
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pivotTableStyle")]
    public StringValue PivotTableStyleName
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "vacatedStyle")]
    public StringValue VacatedStyle
    {
      get
      {
        return (StringValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
      get
      {
        return (StringValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "updatedVersion")]
    public ByteValue UpdatedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minRefreshableVersion")]
    public ByteValue MinRefreshableVersion
    {
      get
      {
        return (ByteValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "asteriskTotals")]
    public BooleanValue AsteriskTotals
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

    [SchemaAttr(0, "showItems")]
    public BooleanValue ShowItems
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

    [SchemaAttr(0, "editData")]
    public BooleanValue EditData
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

    [SchemaAttr(0, "disableFieldList")]
    public BooleanValue DisableFieldList
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

    [SchemaAttr(0, "showCalcMbrs")]
    public BooleanValue ShowCalculatedMembers
    {
      get
      {
        return (BooleanValue) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "visualTotals")]
    public BooleanValue VisualTotals
    {
      get
      {
        return (BooleanValue) this.Attributes[28];
      }
      set
      {
        this.Attributes[28] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showMultipleLabel")]
    public BooleanValue ShowMultipleLabel
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

    [SchemaAttr(0, "showDataDropDown")]
    public BooleanValue ShowDataDropDown
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

    [SchemaAttr(0, "showDrill")]
    public BooleanValue ShowDrill
    {
      get
      {
        return (BooleanValue) this.Attributes[31];
      }
      set
      {
        this.Attributes[31] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "printDrill")]
    public BooleanValue PrintDrill
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

    [SchemaAttr(0, "showMemberPropertyTips")]
    public BooleanValue ShowMemberPropertyTips
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

    [SchemaAttr(0, "showDataTips")]
    public BooleanValue ShowDataTips
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

    [SchemaAttr(0, "enableWizard")]
    public BooleanValue EnableWizard
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

    [SchemaAttr(0, "enableDrill")]
    public BooleanValue EnableDrill
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

    [SchemaAttr(0, "enableFieldProperties")]
    public BooleanValue EnableFieldProperties
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

    [SchemaAttr(0, "preserveFormatting")]
    public BooleanValue PreserveFormatting
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

    [SchemaAttr(0, "useAutoFormatting")]
    public BooleanValue UseAutoFormatting
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

    [SchemaAttr(0, "pageWrap")]
    public UInt32Value PageWrap
    {
      get
      {
        return (UInt32Value) this.Attributes[40];
      }
      set
      {
        this.Attributes[40] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pageOverThenDown")]
    public BooleanValue PageOverThenDown
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

    [SchemaAttr(0, "subtotalHiddenItems")]
    public BooleanValue SubtotalHiddenItems
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

    [SchemaAttr(0, "rowGrandTotals")]
    public BooleanValue RowGrandTotals
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

    [SchemaAttr(0, "colGrandTotals")]
    public BooleanValue ColumnGrandTotals
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

    [SchemaAttr(0, "fieldPrintTitles")]
    public BooleanValue FieldPrintTitles
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

    [SchemaAttr(0, "itemPrintTitles")]
    public BooleanValue ItemPrintTitles
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

    [SchemaAttr(0, "mergeItem")]
    public BooleanValue MergeItem
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

    [SchemaAttr(0, "showDropZones")]
    public BooleanValue ShowDropZones
    {
      get
      {
        return (BooleanValue) this.Attributes[48];
      }
      set
      {
        this.Attributes[48] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "createdVersion")]
    public ByteValue CreatedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[49];
      }
      set
      {
        this.Attributes[49] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "indent")]
    public UInt32Value Indent
    {
      get
      {
        return (UInt32Value) this.Attributes[50];
      }
      set
      {
        this.Attributes[50] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showEmptyRow")]
    public BooleanValue ShowEmptyRow
    {
      get
      {
        return (BooleanValue) this.Attributes[51];
      }
      set
      {
        this.Attributes[51] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showEmptyCol")]
    public BooleanValue ShowEmptyColumn
    {
      get
      {
        return (BooleanValue) this.Attributes[52];
      }
      set
      {
        this.Attributes[52] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showHeaders")]
    public BooleanValue ShowHeaders
    {
      get
      {
        return (BooleanValue) this.Attributes[53];
      }
      set
      {
        this.Attributes[53] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "compact")]
    public BooleanValue Compact
    {
      get
      {
        return (BooleanValue) this.Attributes[54];
      }
      set
      {
        this.Attributes[54] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
    {
      get
      {
        return (BooleanValue) this.Attributes[55];
      }
      set
      {
        this.Attributes[55] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outlineData")]
    public BooleanValue OutlineData
    {
      get
      {
        return (BooleanValue) this.Attributes[56];
      }
      set
      {
        this.Attributes[56] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "compactData")]
    public BooleanValue CompactData
    {
      get
      {
        return (BooleanValue) this.Attributes[57];
      }
      set
      {
        this.Attributes[57] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "published")]
    public BooleanValue Published
    {
      get
      {
        return (BooleanValue) this.Attributes[58];
      }
      set
      {
        this.Attributes[58] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "gridDropZones")]
    public BooleanValue GridDropZones
    {
      get
      {
        return (BooleanValue) this.Attributes[59];
      }
      set
      {
        this.Attributes[59] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "immersive")]
    public BooleanValue StopImmersiveUi
    {
      get
      {
        return (BooleanValue) this.Attributes[60];
      }
      set
      {
        this.Attributes[60] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "multipleFieldFilters")]
    public BooleanValue MultipleFieldFilters
    {
      get
      {
        return (BooleanValue) this.Attributes[61];
      }
      set
      {
        this.Attributes[61] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "chartFormat")]
    public UInt32Value ChartFormat
    {
      get
      {
        return (UInt32Value) this.Attributes[62];
      }
      set
      {
        this.Attributes[62] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rowHeaderCaption")]
    public StringValue RowHeaderCaption
    {
      get
      {
        return (StringValue) this.Attributes[63];
      }
      set
      {
        this.Attributes[63] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "colHeaderCaption")]
    public StringValue ColumnHeaderCaption
    {
      get
      {
        return (StringValue) this.Attributes[64];
      }
      set
      {
        this.Attributes[64] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fieldListSortAscending")]
    public BooleanValue FieldListSortAscending
    {
      get
      {
        return (BooleanValue) this.Attributes[65];
      }
      set
      {
        this.Attributes[65] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "mdxSubqueries")]
    public BooleanValue MdxSubqueries
    {
      get
      {
        return (BooleanValue) this.Attributes[66];
      }
      set
      {
        this.Attributes[66] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
    {
      get
      {
        return (BooleanValue) this.Attributes[67];
      }
      set
      {
        this.Attributes[67] = (OpenXmlSimpleType) value;
      }
    }

    internal PivotTableDefinition(PivotTablePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(PivotTablePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public PivotTablePart PivotTablePart
    {
      get
      {
        return this.OpenXmlPart as PivotTablePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public PivotTableDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotTableDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotTableDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public PivotTableDefinition()
    {
    }

    public void Save(PivotTablePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "location" == name)
        return (OpenXmlElement) new Location();
      if (22 == (int) namespaceId && "pivotFields" == name)
        return (OpenXmlElement) new PivotFields();
      if (22 == (int) namespaceId && "rowFields" == name)
        return (OpenXmlElement) new RowFields();
      if (22 == (int) namespaceId && "rowItems" == name)
        return (OpenXmlElement) new RowItems();
      if (22 == (int) namespaceId && "colFields" == name)
        return (OpenXmlElement) new ColumnFields();
      if (22 == (int) namespaceId && "colItems" == name)
        return (OpenXmlElement) new ColumnItems();
      if (22 == (int) namespaceId && "pageFields" == name)
        return (OpenXmlElement) new PageFields();
      if (22 == (int) namespaceId && "dataFields" == name)
        return (OpenXmlElement) new DataFields();
      if (22 == (int) namespaceId && "formats" == name)
        return (OpenXmlElement) new Formats();
      if (22 == (int) namespaceId && "conditionalFormats" == name)
        return (OpenXmlElement) new ConditionalFormats();
      if (22 == (int) namespaceId && "chartFormats" == name)
        return (OpenXmlElement) new ChartFormats();
      if (22 == (int) namespaceId && "pivotHierarchies" == name)
        return (OpenXmlElement) new PivotHierarchies();
      if (22 == (int) namespaceId && "pivotTableStyleInfo" == name)
        return (OpenXmlElement) new PivotTableStyle();
      if (22 == (int) namespaceId && "filters" == name)
        return (OpenXmlElement) new PivotFilters();
      if (22 == (int) namespaceId && "rowHierarchiesUsage" == name)
        return (OpenXmlElement) new RowHierarchiesUsage();
      if (22 == (int) namespaceId && "colHierarchiesUsage" == name)
        return (OpenXmlElement) new ColumnHierarchiesUsage();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PivotTableDefinitionExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotTableDefinition.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotTableDefinition.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Location Location
    {
      get
      {
        return this.GetElement<Location>(0);
      }
      set
      {
        this.SetElement<Location>(0, value);
      }
    }

    public PivotFields PivotFields
    {
      get
      {
        return this.GetElement<PivotFields>(1);
      }
      set
      {
        this.SetElement<PivotFields>(1, value);
      }
    }

    public RowFields RowFields
    {
      get
      {
        return this.GetElement<RowFields>(2);
      }
      set
      {
        this.SetElement<RowFields>(2, value);
      }
    }

    public RowItems RowItems
    {
      get
      {
        return this.GetElement<RowItems>(3);
      }
      set
      {
        this.SetElement<RowItems>(3, value);
      }
    }

    public ColumnFields ColumnFields
    {
      get
      {
        return this.GetElement<ColumnFields>(4);
      }
      set
      {
        this.SetElement<ColumnFields>(4, value);
      }
    }

    public ColumnItems ColumnItems
    {
      get
      {
        return this.GetElement<ColumnItems>(5);
      }
      set
      {
        this.SetElement<ColumnItems>(5, value);
      }
    }

    public PageFields PageFields
    {
      get
      {
        return this.GetElement<PageFields>(6);
      }
      set
      {
        this.SetElement<PageFields>(6, value);
      }
    }

    public DataFields DataFields
    {
      get
      {
        return this.GetElement<DataFields>(7);
      }
      set
      {
        this.SetElement<DataFields>(7, value);
      }
    }

    public Formats Formats
    {
      get
      {
        return this.GetElement<Formats>(8);
      }
      set
      {
        this.SetElement<Formats>(8, value);
      }
    }

    public ConditionalFormats ConditionalFormats
    {
      get
      {
        return this.GetElement<ConditionalFormats>(9);
      }
      set
      {
        this.SetElement<ConditionalFormats>(9, value);
      }
    }

    public ChartFormats ChartFormats
    {
      get
      {
        return this.GetElement<ChartFormats>(10);
      }
      set
      {
        this.SetElement<ChartFormats>(10, value);
      }
    }

    public PivotHierarchies PivotHierarchies
    {
      get
      {
        return this.GetElement<PivotHierarchies>(11);
      }
      set
      {
        this.SetElement<PivotHierarchies>(11, value);
      }
    }

    public PivotTableStyle PivotTableStyle
    {
      get
      {
        return this.GetElement<PivotTableStyle>(12);
      }
      set
      {
        this.SetElement<PivotTableStyle>(12, value);
      }
    }

    public PivotFilters PivotFilters
    {
      get
      {
        return this.GetElement<PivotFilters>(13);
      }
      set
      {
        this.SetElement<PivotFilters>(13, value);
      }
    }

    public RowHierarchiesUsage RowHierarchiesUsage
    {
      get
      {
        return this.GetElement<RowHierarchiesUsage>(14);
      }
      set
      {
        this.SetElement<RowHierarchiesUsage>(14, value);
      }
    }

    public ColumnHierarchiesUsage ColumnHierarchiesUsage
    {
      get
      {
        return this.GetElement<ColumnHierarchiesUsage>(15);
      }
      set
      {
        this.SetElement<ColumnHierarchiesUsage>(15, value);
      }
    }

    public PivotTableDefinitionExtensionList PivotTableDefinitionExtensionList
    {
      get
      {
        return this.GetElement<PivotTableDefinitionExtensionList>(16);
      }
      set
      {
        this.SetElement<PivotTableDefinitionExtensionList>(16, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cacheId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "dataOnRows" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dataPosition" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "autoFormatId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "applyNumberFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyBorderFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyFontFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyPatternFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyAlignmentFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyWidthHeightFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dataCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "grandTotalCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "errorCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "showError" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "missingCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "showMissing" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pageStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "pivotTableStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "vacatedStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tag" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "updatedVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "minRefreshableVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "asteriskTotals" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showItems" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "editData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "disableFieldList" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showCalcMbrs" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "visualTotals" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showMultipleLabel" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showDataDropDown" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showDrill" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "printDrill" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showMemberPropertyTips" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showDataTips" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "enableWizard" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "enableDrill" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "enableFieldProperties" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "preserveFormatting" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "useAutoFormatting" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pageWrap" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "pageOverThenDown" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "subtotalHiddenItems" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rowGrandTotals" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "colGrandTotals" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fieldPrintTitles" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "itemPrintTitles" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "mergeItem" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showDropZones" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "createdVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "indent" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "showEmptyRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showEmptyCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showHeaders" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "compact" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "outline" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "outlineData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "compactData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "published" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "gridDropZones" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "immersive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "multipleFieldFilters" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "chartFormat" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "rowHeaderCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "colHeaderCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fieldListSortAscending" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "mdxSubqueries" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "customListSort" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotTableDefinition>(deep);
    }
  }
}
