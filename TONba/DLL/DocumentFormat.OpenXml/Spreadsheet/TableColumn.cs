// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TableColumn
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (CalculatedColumnFormula))]
  [ChildElementInfo(typeof (TotalsRowFormula))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (XmlColumnProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class TableColumn : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "id",
      "uniqueName",
      "name",
      "totalsRowFunction",
      "totalsRowLabel",
      "queryTableFieldId",
      "headerRowDxfId",
      "dataDxfId",
      "totalsRowDxfId",
      "headerRowCellStyle",
      "dataCellStyle",
      "totalsRowCellStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private static readonly string[] eleTagNames = new string[4]
    {
      "calculatedColumnFormula",
      "totalsRowFormula",
      "xmlColumnPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "tableColumn";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11348;

    public override string LocalName
    {
      get
      {
        return "tableColumn";
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
        return 11348;
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
        return TableColumn.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableColumn.attributeNamespaceIds;
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

    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
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

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "totalsRowFunction")]
    public EnumValue<TotalsRowFunctionValues> TotalsRowFunction
    {
      get
      {
        return (EnumValue<TotalsRowFunctionValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "totalsRowLabel")]
    public StringValue TotalsRowLabel
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

    [SchemaAttr(0, "queryTableFieldId")]
    public UInt32Value QueryTableFieldId
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

    [SchemaAttr(0, "headerRowDxfId")]
    public UInt32Value HeaderRowDifferentialFormattingId
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

    [SchemaAttr(0, "dataDxfId")]
    public UInt32Value DataFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "totalsRowDxfId")]
    public UInt32Value TotalsRowDifferentialFormattingId
    {
      get
      {
        return (UInt32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "headerRowCellStyle")]
    public StringValue HeaderRowCellStyle
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dataCellStyle")]
    public StringValue DataCellStyle
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "totalsRowCellStyle")]
    public StringValue TotalsRowCellStyle
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

    public TableColumn()
    {
    }

    public TableColumn(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableColumn(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableColumn(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "calculatedColumnFormula" == name)
        return (OpenXmlElement) new CalculatedColumnFormula();
      if (22 == (int) namespaceId && "totalsRowFormula" == name)
        return (OpenXmlElement) new TotalsRowFormula();
      if (22 == (int) namespaceId && "xmlColumnPr" == name)
        return (OpenXmlElement) new XmlColumnProperties();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableColumn.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableColumn.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CalculatedColumnFormula CalculatedColumnFormula
    {
      get
      {
        return this.GetElement<CalculatedColumnFormula>(0);
      }
      set
      {
        this.SetElement<CalculatedColumnFormula>(0, value);
      }
    }

    public TotalsRowFormula TotalsRowFormula
    {
      get
      {
        return this.GetElement<TotalsRowFormula>(1);
      }
      set
      {
        this.SetElement<TotalsRowFormula>(1, value);
      }
    }

    public XmlColumnProperties XmlColumnProperties
    {
      get
      {
        return this.GetElement<XmlColumnProperties>(2);
      }
      set
      {
        this.SetElement<XmlColumnProperties>(2, value);
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
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "uniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "totalsRowFunction" == name)
        return (OpenXmlSimpleType) new EnumValue<TotalsRowFunctionValues>();
      if ((int) namespaceId == 0 && "totalsRowLabel" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "queryTableFieldId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "headerRowDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "dataDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "totalsRowDxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "headerRowCellStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "dataCellStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "totalsRowCellStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableColumn>(deep);
    }
  }
}
