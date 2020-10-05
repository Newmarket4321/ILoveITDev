// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.Rule
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  public class Rule : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "type",
      "for",
      "forName",
      "ptType",
      "val",
      "fact",
      "max"
    };
    private static byte[] attributeNamespaceIds = new byte[7];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 14
    };
    private const string tagName = "rule";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10708;

    public override string LocalName
    {
      get
      {
        return "rule";
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
        return 10708;
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
        return Rule.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Rule.attributeNamespaceIds;
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

    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
      get
      {
        return (DoubleValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fact")]
    public DoubleValue Fact
    {
      get
      {
        return (DoubleValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "max")]
    public DoubleValue Max
    {
      get
      {
        return (DoubleValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    public Rule()
    {
    }

    public Rule(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Rule(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Rule(string outerXml)
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
        return Rule.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Rule.eleNamespaceIds;
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
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "fact" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "max" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Rule>(deep);
    }
  }
}
