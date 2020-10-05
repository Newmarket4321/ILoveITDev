// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.PivotTableDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (ConditionalFormats), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotEdits), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotChanges), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class PivotTableDefinition : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[10]
    {
      "fillDownLabelsDefault",
      "visualTotalsForSets",
      "calculatedMembersInFilters",
      "altText",
      "altTextSummary",
      "enableEdit",
      "autoApply",
      "allocationMethod",
      "weightExpression",
      "hideValuesRow"
    };
    private static byte[] attributeNamespaceIds = new byte[10];
    private static readonly string[] eleTagNames = new string[3]
    {
      "pivotEdits",
      "pivotChanges",
      "conditionalFormats"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 53,
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "pivotTableDefinition";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12976;

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
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12976;
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

    [SchemaAttr(0, "fillDownLabelsDefault")]
    public BooleanValue FillDownLabelsDefault
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

    [SchemaAttr(0, "visualTotalsForSets")]
    public BooleanValue VisualTotalsForSets
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

    [SchemaAttr(0, "calculatedMembersInFilters")]
    public BooleanValue CalculatedMembersInFilters
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

    [SchemaAttr(0, "altText")]
    public StringValue AltText
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

    [SchemaAttr(0, "altTextSummary")]
    public StringValue AltTextSummary
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

    [SchemaAttr(0, "enableEdit")]
    public BooleanValue EnableEdit
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

    [SchemaAttr(0, "autoApply")]
    public BooleanValue AutoApply
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

    [SchemaAttr(0, "allocationMethod")]
    public EnumValue<AllocationMethodValues> AllocationMethod
    {
      get
      {
        return (EnumValue<AllocationMethodValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "weightExpression")]
    public StringValue WeightExpression
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

    [SchemaAttr(0, "hideValuesRow")]
    public BooleanValue HideValuesRow
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

    public PivotTableDefinition()
    {
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

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "pivotEdits" == name)
        return (OpenXmlElement) new PivotEdits();
      if (53 == (int) namespaceId && "pivotChanges" == name)
        return (OpenXmlElement) new PivotChanges();
      if (53 == (int) namespaceId && "conditionalFormats" == name)
        return (OpenXmlElement) new ConditionalFormats();
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

    public PivotEdits PivotEdits
    {
      get
      {
        return this.GetElement<PivotEdits>(0);
      }
      set
      {
        this.SetElement<PivotEdits>(0, value);
      }
    }

    public PivotChanges PivotChanges
    {
      get
      {
        return this.GetElement<PivotChanges>(1);
      }
      set
      {
        this.SetElement<PivotChanges>(1, value);
      }
    }

    public ConditionalFormats ConditionalFormats
    {
      get
      {
        return this.GetElement<ConditionalFormats>(2);
      }
      set
      {
        this.SetElement<ConditionalFormats>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "fillDownLabelsDefault" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "visualTotalsForSets" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "calculatedMembersInFilters" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "altText" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "altTextSummary" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "enableEdit" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoApply" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "allocationMethod" == name)
        return (OpenXmlSimpleType) new EnumValue<AllocationMethodValues>();
      if ((int) namespaceId == 0 && "weightExpression" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hideValuesRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotTableDefinition>(deep);
    }
  }
}
