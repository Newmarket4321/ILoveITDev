// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.PivotArea
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
  [ChildElementInfo(typeof (PivotAreaReferences))]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class PivotArea : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "field",
      "type",
      "dataOnly",
      "labelOnly",
      "grandRow",
      "grandCol",
      "cacheIndex",
      "outline",
      "offset",
      "collapsedLevelsAreSubtotals",
      "axis",
      "fieldPosition"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private static readonly string[] eleTagNames = new string[2]
    {
      "references",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "pivotArea";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13044;

    public override string LocalName
    {
      get
      {
        return "pivotArea";
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
        return 13044;
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
        return PivotArea.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotArea.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "field")]
    public Int32Value Field
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<PivotAreaValues> Type
    {
      get
      {
        return (EnumValue<PivotAreaValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dataOnly")]
    public BooleanValue DataOnly
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

    [SchemaAttr(0, "labelOnly")]
    public BooleanValue LabelOnly
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

    [SchemaAttr(0, "grandRow")]
    public BooleanValue GrandRow
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

    [SchemaAttr(0, "grandCol")]
    public BooleanValue GrandColumn
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

    [SchemaAttr(0, "cacheIndex")]
    public BooleanValue CacheIndex
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

    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
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

    [SchemaAttr(0, "offset")]
    public StringValue Offset
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "collapsedLevelsAreSubtotals")]
    public BooleanValue CollapsedLevelsAreSubtotals
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

    [SchemaAttr(0, "axis")]
    public EnumValue<PivotTableAxisValues> Axis
    {
      get
      {
        return (EnumValue<PivotTableAxisValues>) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fieldPosition")]
    public UInt32Value FieldPosition
    {
      get
      {
        return (UInt32Value) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    public PivotArea()
    {
    }

    public PivotArea(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotArea(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotArea(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "references" == name)
        return (OpenXmlElement) new PivotAreaReferences();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotArea.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotArea.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PivotAreaReferences PivotAreaReferences
    {
      get
      {
        return this.GetElement<PivotAreaReferences>(0);
      }
      set
      {
        this.SetElement<PivotAreaReferences>(0, value);
      }
    }

    public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(1);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "field" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<PivotAreaValues>();
      if ((int) namespaceId == 0 && "dataOnly" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "labelOnly" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "grandRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "grandCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "cacheIndex" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "outline" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "offset" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "collapsedLevelsAreSubtotals" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "axis" == name)
        return (OpenXmlSimpleType) new EnumValue<PivotTableAxisValues>();
      if ((int) namespaceId == 0 && "fieldPosition" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotArea>(deep);
    }
  }
}
