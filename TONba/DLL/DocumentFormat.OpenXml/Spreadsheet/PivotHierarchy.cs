// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotHierarchy
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (MemberProperties))]
  [ChildElementInfo(typeof (Members))]
  [ChildElementInfo(typeof (PivotHierarchyExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotHierarchy : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[11]
    {
      "outline",
      "multipleItemSelectionAllowed",
      "subtotalTop",
      "showInFieldList",
      "dragToRow",
      "dragToCol",
      "dragToPage",
      "dragToData",
      "dragOff",
      "includeNewItemsInFilter",
      "caption"
    };
    private static byte[] attributeNamespaceIds = new byte[11];
    private static readonly string[] eleTagNames = new string[3]
    {
      "mps",
      "members",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "pivotHierarchy";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11177;

    public override string LocalName
    {
      get
      {
        return "pivotHierarchy";
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
        return 11177;
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
        return PivotHierarchy.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotHierarchy.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
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

    [SchemaAttr(0, "multipleItemSelectionAllowed")]
    public BooleanValue MultipleItemSelectionAllowed
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

    [SchemaAttr(0, "subtotalTop")]
    public BooleanValue SubtotalTop
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

    [SchemaAttr(0, "showInFieldList")]
    public BooleanValue ShowInFieldList
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

    [SchemaAttr(0, "dragToRow")]
    public BooleanValue DragToRow
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

    [SchemaAttr(0, "dragToCol")]
    public BooleanValue DragToColumn
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

    [SchemaAttr(0, "dragToPage")]
    public BooleanValue DragToPage
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

    [SchemaAttr(0, "dragToData")]
    public BooleanValue DragToData
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

    [SchemaAttr(0, "dragOff")]
    public BooleanValue DragOff
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

    [SchemaAttr(0, "includeNewItemsInFilter")]
    public BooleanValue IncludeNewItemsInFilter
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

    [SchemaAttr(0, "caption")]
    public StringValue Caption
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

    public PivotHierarchy()
    {
    }

    public PivotHierarchy(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotHierarchy(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotHierarchy(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "mps" == name)
        return (OpenXmlElement) new MemberProperties();
      if (22 == (int) namespaceId && "members" == name)
        return (OpenXmlElement) new Members();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PivotHierarchyExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotHierarchy.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotHierarchy.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MemberProperties MemberProperties
    {
      get
      {
        return this.GetElement<MemberProperties>(0);
      }
      set
      {
        this.SetElement<MemberProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "outline" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "multipleItemSelectionAllowed" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "subtotalTop" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showInFieldList" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToPage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragToData" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dragOff" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "includeNewItemsInFilter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "caption" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotHierarchy>(deep);
    }
  }
}
