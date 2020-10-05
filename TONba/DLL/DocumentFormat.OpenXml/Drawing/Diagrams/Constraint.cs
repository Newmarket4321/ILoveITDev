// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.Constraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class Constraint : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[11]
    {
      "type",
      "for",
      "forName",
      "ptType",
      "refType",
      "refFor",
      "refForName",
      "refPtType",
      "op",
      "val",
      "fact"
    };
    private static byte[] attributeNamespaceIds = new byte[11];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 14
    };
    private const string tagName = "constr";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10707;

    public override string LocalName
    {
      get
      {
        return "constr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10707;
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
        return Constraint.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Constraint.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<ConstraintValues> Type
    {
      get
      {
        return (EnumValue<ConstraintValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "for")]
    public EnumValue<ConstraintRelationshipValues> For
    {
      get
      {
        return (EnumValue<ConstraintRelationshipValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "forName")]
    public StringValue ForName
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

    [SchemaAttr(0, "ptType")]
    public EnumValue<ElementValues> PointType
    {
      get
      {
        return (EnumValue<ElementValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refType")]
    public EnumValue<ConstraintValues> ReferenceType
    {
      get
      {
        return (EnumValue<ConstraintValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refFor")]
    public EnumValue<ConstraintRelationshipValues> ReferenceFor
    {
      get
      {
        return (EnumValue<ConstraintRelationshipValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "refForName")]
    public StringValue ReferenceForName
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

    [SchemaAttr(0, "refPtType")]
    public EnumValue<ElementValues> ReferencePointType
    {
      get
      {
        return (EnumValue<ElementValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "op")]
    public EnumValue<BoolOperatorValues> Operator
    {
      get
      {
        return (EnumValue<BoolOperatorValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
      get
      {
        return (DoubleValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fact")]
    public DoubleValue Fact
    {
      get
      {
        return (DoubleValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    public Constraint()
    {
    }

    public Constraint(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Constraint(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Constraint(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Constraint.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Constraint.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<ConstraintValues>();
      if ((int) namespaceId == 0 && "for" == name)
        return (OpenXmlSimpleType) new EnumValue<ConstraintRelationshipValues>();
      if ((int) namespaceId == 0 && "forName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "ptType" == name)
        return (OpenXmlSimpleType) new EnumValue<ElementValues>();
      if ((int) namespaceId == 0 && "refType" == name)
        return (OpenXmlSimpleType) new EnumValue<ConstraintValues>();
      if ((int) namespaceId == 0 && "refFor" == name)
        return (OpenXmlSimpleType) new EnumValue<ConstraintRelationshipValues>();
      if ((int) namespaceId == 0 && "refForName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "refPtType" == name)
        return (OpenXmlSimpleType) new EnumValue<ElementValues>();
      if ((int) namespaceId == 0 && "op" == name)
        return (OpenXmlSimpleType) new EnumValue<BoolOperatorValues>();
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "fact" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Constraint>(deep);
    }
  }
}
