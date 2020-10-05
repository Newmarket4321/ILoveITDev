// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CacheHierarchy
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FieldsUsage))]
  [ChildElementInfo(typeof (CacheHierarchyExtensionList))]
  [ChildElementInfo(typeof (GroupLevels))]
  public class CacheHierarchy : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[22]
    {
      "uniqueName",
      "caption",
      "measure",
      "set",
      "parentSet",
      "iconSet",
      "attribute",
      "time",
      "keyAttribute",
      "defaultMemberUniqueName",
      "allUniqueName",
      "allCaption",
      "dimensionUniqueName",
      "displayFolder",
      "measureGroup",
      "measures",
      "count",
      "oneField",
      "memberValueDatatype",
      "unbalanced",
      "unbalancedGroup",
      "hidden"
    };
    private static byte[] attributeNamespaceIds = new byte[22];
    private static readonly string[] eleTagNames = new string[3]
    {
      "fieldsUsage",
      "groupLevels",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "cacheHierarchy";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11185;

    public override string LocalName
    {
      get
      {
        return "cacheHierarchy";
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
        return 11185;
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
        return CacheHierarchy.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CacheHierarchy.attributeNamespaceIds;
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

    [SchemaAttr(0, "caption")]
    public StringValue Caption
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

    [SchemaAttr(0, "measure")]
    public BooleanValue Measure
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

    [SchemaAttr(0, "set")]
    public BooleanValue Set
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

    [SchemaAttr(0, "parentSet")]
    public UInt32Value ParentSet
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

    [SchemaAttr(0, "iconSet")]
    public Int32Value IconSet
    {
      get
      {
        return (Int32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "attribute")]
    public BooleanValue Attribute
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

    [SchemaAttr(0, "time")]
    public BooleanValue Time
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

    [SchemaAttr(0, "keyAttribute")]
    public BooleanValue KeyAttribute
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

    [SchemaAttr(0, "defaultMemberUniqueName")]
    public StringValue DefaultMemberUniqueName
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

    [SchemaAttr(0, "allUniqueName")]
    public StringValue AllUniqueName
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

    [SchemaAttr(0, "allCaption")]
    public StringValue AllCaption
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

    [SchemaAttr(0, "dimensionUniqueName")]
    public StringValue DimensionUniqueName
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

    [SchemaAttr(0, "displayFolder")]
    public StringValue DisplayFolder
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

    [SchemaAttr(0, "measureGroup")]
    public StringValue MeasureGroup
    {
      get
      {
        return (StringValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "measures")]
    public BooleanValue Measures
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

    [SchemaAttr(0, "count")]
    public UInt32Value Count
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

    [SchemaAttr(0, "oneField")]
    public BooleanValue OneField
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

    [SchemaAttr(0, "memberValueDatatype")]
    public UInt16Value MemberValueDatatype
    {
      get
      {
        return (UInt16Value) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "unbalanced")]
    public BooleanValue Unbalanced
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

    [SchemaAttr(0, "unbalancedGroup")]
    public BooleanValue UnbalancedGroup
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

    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
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

    public CacheHierarchy()
    {
    }

    public CacheHierarchy(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CacheHierarchy(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CacheHierarchy(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "fieldsUsage" == name)
        return (OpenXmlElement) new FieldsUsage();
      if (22 == (int) namespaceId && "groupLevels" == name)
        return (OpenXmlElement) new GroupLevels();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new CacheHierarchyExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CacheHierarchy.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CacheHierarchy.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FieldsUsage FieldsUsage
    {
      get
      {
        return this.GetElement<FieldsUsage>(0);
      }
      set
      {
        this.SetElement<FieldsUsage>(0, value);
      }
    }

    public GroupLevels GroupLevels
    {
      get
      {
        return this.GetElement<GroupLevels>(1);
      }
      set
      {
        this.SetElement<GroupLevels>(1, value);
      }
    }

    public CacheHierarchyExtensionList CacheHierarchyExtensionList
    {
      get
      {
        return this.GetElement<CacheHierarchyExtensionList>(2);
      }
      set
      {
        this.SetElement<CacheHierarchyExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "caption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "measure" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "set" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "parentSet" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "iconSet" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "attribute" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "time" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "keyAttribute" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "defaultMemberUniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "allUniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "allCaption" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "dimensionUniqueName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "displayFolder" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "measureGroup" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "measures" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "oneField" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "memberValueDatatype" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "unbalanced" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "unbalancedGroup" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CacheHierarchy>(deep);
    }
  }
}
