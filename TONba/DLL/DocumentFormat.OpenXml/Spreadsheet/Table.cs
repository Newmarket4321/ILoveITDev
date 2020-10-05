// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Table
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (SortState))]
  [ChildElementInfo(typeof (AutoFilter))]
  [ChildElementInfo(typeof (TableExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TableStyleInfo))]
  [ChildElementInfo(typeof (TableColumns))]
  public class Table : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[22]
    {
      "id",
      "name",
      "displayName",
      "comment",
      "ref",
      "tableType",
      "headerRowCount",
      "insertRow",
      "insertRowShift",
      "totalsRowCount",
      "totalsRowShown",
      "published",
      "headerRowDxfId",
      "dataDxfId",
      "totalsRowDxfId",
      "headerRowBorderDxfId",
      "tableBorderDxfId",
      "totalsRowBorderDxfId",
      "headerRowCellStyle",
      "dataCellStyle",
      "totalsRowCellStyle",
      "connectionId"
    };
    private static byte[] attributeNamespaceIds = new byte[22];
    private static readonly string[] eleTagNames = new string[5]
    {
      "autoFilter",
      "sortState",
      "tableColumns",
      "tableStyleInfo",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "table";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11112;

    public override string LocalName
    {
      get
      {
        return "table";
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
        return 11112;
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
        return Table.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Table.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public UInt32Value Id
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

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "displayName")]
    public StringValue DisplayName
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "comment")]
    public StringValue Comment
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

    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tableType")]
    public EnumValue<TableValues> TableType
    {
      get
      {
        return (EnumValue<TableValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "headerRowCount")]
    public UInt32Value HeaderRowCount
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

    [SchemaAttr(0, "insertRow")]
    public BooleanValue InsertRow
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

    [SchemaAttr(0, "insertRowShift")]
    public BooleanValue InsertRowShift
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

    [SchemaAttr(0, "totalsRowCount")]
    public UInt32Value TotalsRowCount
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

    [SchemaAttr(0, "totalsRowShown")]
    public BooleanValue TotalsRowShown
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

    [SchemaAttr(0, "published")]
    public BooleanValue Published
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

    [SchemaAttr(0, "headerRowDxfId")]
    public UInt32Value HeaderRowFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dataDxfId")]
    public UInt32Value DataFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "totalsRowDxfId")]
    public UInt32Value TotalsRowFormatId
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

    [SchemaAttr(0, "headerRowBorderDxfId")]
    public UInt32Value HeaderRowBorderFormatId
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

    [SchemaAttr(0, "tableBorderDxfId")]
    public UInt32Value BorderFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "totalsRowBorderDxfId")]
    public UInt32Value TotalsRowBorderFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "headerRowCellStyle")]
    public StringValue HeaderRowCellStyle
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

    [SchemaAttr(0, "dataCellStyle")]
    public StringValue DataCellStyle
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

    [SchemaAttr(0, "totalsRowCellStyle")]
    public StringValue TotalsRowCellStyle
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

    [SchemaAttr(0, "connectionId")]
    public UInt32Value ConnectionId
    {
      get
      {
        return (UInt32Value) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    internal Table(TableDefinitionPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(TableDefinitionPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public TableDefinitionPart TableDefinitionPart
    {
      get
      {
        return this.OpenXmlPart as TableDefinitionPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Table(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Table(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Table(string outerXml)
      : base(outerXml)
    {
    }

    public Table()
    {
    }

    public void Save(TableDefinitionPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "autoFilter" == name)
        return (OpenXmlElement) new AutoFilter();
      if (22 == (int) namespaceId && "sortState" == name)
        return (OpenXmlElement) new SortState();
      if (22 == (int) namespaceId && "tableColumns" == name)
        return (OpenXmlElement) new TableColumns();
      if (22 == (int) namespaceId && "tableStyleInfo" == name)
        return (OpenXmlElement) new TableStyleInfo();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new TableExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Table.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Table.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AutoFilter AutoFilter
    {
      get
      {
        return this.GetElement<AutoFilter>(0);
      }
      set
      {
        this.SetElement<AutoFilter>(0, value);
      }
    }

    public SortState SortState
    {
      get
      {
        return this.GetElement<SortState>(1);
      }
      set
      {
        this.SetElement<SortState>(1, value);
      }
    }

    public TableColumns TableColumns
    {
      get
      {
        return this.GetElement<TableColumns>(2);
      }
      set
      {
        this.SetElement<TableColumns>(2, value);
      }
    }

    public TableStyleInfo TableStyleInfo
    {
      get
      {
        return this.GetElement<TableStyleInfo>(3);
      }
      set
      {
        this.SetElement<TableStyleInfo>(3, value);
      }
    }

    public TableExtensionList TableExtensionList
    {
      get
      {
        return this.GetElement<TableExtensionList>(4);
      }
      set
      {
        this.SetElement<TableExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "displayName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "comment" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tableType" == name)
        return (OpenXmlSimpleType) new EnumValue<TableValues>();
      if ((int) namespaceId == 0 && "headerRowCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "insertRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "insertRowShift" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "totalsRowCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "totalsRowShown" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "published" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "headerRowDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "dataDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "totalsRowDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "headerRowBorderDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "tableBorderDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "totalsRowBorderDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "headerRowCellStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "dataCellStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "totalsRowCellStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "connectionId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Table>(deep);
    }
  }
}
