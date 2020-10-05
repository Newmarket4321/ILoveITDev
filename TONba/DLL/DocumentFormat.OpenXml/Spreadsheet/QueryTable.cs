// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.QueryTable
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (QueryTableExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (QueryTableRefresh))]
  public class QueryTable : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[22]
    {
      "name",
      "headers",
      "rowNumbers",
      "disableRefresh",
      "backgroundRefresh",
      "firstBackgroundRefresh",
      "refreshOnLoad",
      "growShrinkType",
      "fillFormulas",
      "removeDataOnSave",
      "disableEdit",
      "preserveFormatting",
      "adjustColumnWidth",
      "intermediate",
      "connectionId",
      "autoFormatId",
      "applyNumberFormats",
      "applyBorderFormats",
      "applyFontFormats",
      "applyPatternFormats",
      "applyAlignmentFormats",
      "applyWidthHeightFormats"
    };
    private static byte[] attributeNamespaceIds = new byte[22];
    private static readonly string[] eleTagNames = new string[2]
    {
      "queryTableRefresh",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "queryTable";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11100;

    public override string LocalName
    {
      get
      {
        return "queryTable";
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
        return 11100;
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
        return QueryTable.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return QueryTable.attributeNamespaceIds;
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

    [SchemaAttr(0, "headers")]
    public BooleanValue Headers
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

    [SchemaAttr(0, "rowNumbers")]
    public BooleanValue RowNumbers
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

    [SchemaAttr(0, "disableRefresh")]
    public BooleanValue DisableRefresh
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

    [SchemaAttr(0, "backgroundRefresh")]
    public BooleanValue BackgroundRefresh
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

    [SchemaAttr(0, "firstBackgroundRefresh")]
    public BooleanValue FirstBackgroundRefresh
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

    [SchemaAttr(0, "refreshOnLoad")]
    public BooleanValue RefreshOnLoad
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

    [SchemaAttr(0, "growShrinkType")]
    public EnumValue<GrowShrinkValues> GrowShrinkType
    {
      get
      {
        return (EnumValue<GrowShrinkValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fillFormulas")]
    public BooleanValue FillFormulas
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

    [SchemaAttr(0, "removeDataOnSave")]
    public BooleanValue RemoveDataOnSave
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

    [SchemaAttr(0, "disableEdit")]
    public BooleanValue DisableEdit
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

    [SchemaAttr(0, "preserveFormatting")]
    public BooleanValue PreserveFormatting
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

    [SchemaAttr(0, "adjustColumnWidth")]
    public BooleanValue AdjustColumnWidth
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

    [SchemaAttr(0, "intermediate")]
    public BooleanValue Intermediate
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

    [SchemaAttr(0, "connectionId")]
    public UInt32Value ConnectionId
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

    [SchemaAttr(0, "autoFormatId")]
    public UInt32Value AutoFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "applyNumberFormats")]
    public BooleanValue ApplyNumberFormats
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

    [SchemaAttr(0, "applyBorderFormats")]
    public BooleanValue ApplyBorderFormats
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

    [SchemaAttr(0, "applyFontFormats")]
    public BooleanValue ApplyFontFormats
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

    [SchemaAttr(0, "applyPatternFormats")]
    public BooleanValue ApplyPatternFormats
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

    [SchemaAttr(0, "applyAlignmentFormats")]
    public BooleanValue ApplyAlignmentFormats
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

    [SchemaAttr(0, "applyWidthHeightFormats")]
    public BooleanValue ApplyWidthHeightFormats
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

    internal QueryTable(QueryTablePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(QueryTablePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public QueryTablePart QueryTablePart
    {
      get
      {
        return this.OpenXmlPart as QueryTablePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public QueryTable(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public QueryTable(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public QueryTable(string outerXml)
      : base(outerXml)
    {
    }

    public QueryTable()
    {
    }

    public void Save(QueryTablePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "queryTableRefresh" == name)
        return (OpenXmlElement) new QueryTableRefresh();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new QueryTableExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return QueryTable.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return QueryTable.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public QueryTableRefresh QueryTableRefresh
    {
      get
      {
        return this.GetElement<QueryTableRefresh>(0);
      }
      set
      {
        this.SetElement<QueryTableRefresh>(0, value);
      }
    }

    public QueryTableExtensionList QueryTableExtensionList
    {
      get
      {
        return this.GetElement<QueryTableExtensionList>(1);
      }
      set
      {
        this.SetElement<QueryTableExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "headers" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rowNumbers" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "disableRefresh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "backgroundRefresh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "firstBackgroundRefresh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "refreshOnLoad" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "growShrinkType" == name)
        return (OpenXmlSimpleType) new EnumValue<GrowShrinkValues>();
      if ((int) namespaceId == 0 && "fillFormulas" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "removeDataOnSave" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "disableEdit" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "preserveFormatting" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "adjustColumnWidth" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "intermediate" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "connectionId" == name)
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
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<QueryTable>(deep);
    }
  }
}
