// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.PivotChange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (PivotEditValue), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TupleItems), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class PivotChange : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "allocationMethod",
      "weightExpression"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "editValue",
      "tupleItems",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 53,
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "pivotChange";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13045;

    public override string LocalName
    {
      get
      {
        return "pivotChange";
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
        return 13045;
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
        return PivotChange.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotChange.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "allocationMethod")]
    public EnumValue<AllocationMethodValues> AllocationMethod
    {
      get
      {
        return (EnumValue<AllocationMethodValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "weightExpression")]
    public StringValue WeightExpression
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

    public PivotChange()
    {
    }

    public PivotChange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotChange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotChange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "editValue" == name)
        return (OpenXmlElement) new PivotEditValue();
      if (53 == (int) namespaceId && "tupleItems" == name)
        return (OpenXmlElement) new TupleItems();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotChange.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotChange.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PivotEditValue PivotEditValue
    {
      get
      {
        return this.GetElement<PivotEditValue>(0);
      }
      set
      {
        this.SetElement<PivotEditValue>(0, value);
      }
    }

    public TupleItems TupleItems
    {
      get
      {
        return this.GetElement<TupleItems>(1);
      }
      set
      {
        this.SetElement<TupleItems>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "allocationMethod" == name)
        return (OpenXmlSimpleType) new EnumValue<AllocationMethodValues>();
      if ((int) namespaceId == 0 && "weightExpression" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotChange>(deep);
    }
  }
}
