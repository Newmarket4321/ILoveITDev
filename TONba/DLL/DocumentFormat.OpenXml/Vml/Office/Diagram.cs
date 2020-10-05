// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Diagram
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RelationTable))]
  public class Diagram : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[10]
    {
      "ext",
      "dgmstyle",
      "autoformat",
      "reverse",
      "autolayout",
      "dgmscalex",
      "dgmscaley",
      "dgmfontsize",
      "constrainbounds",
      "dgmbasetextscale"
    };
    private static byte[] attributeNamespaceIds = new byte[10]
    {
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "relationtable"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 27
    };
    private const string tagName = "diagram";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12474;

    public override string LocalName
    {
      get
      {
        return "diagram";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12474;
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
        return Diagram.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Diagram.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dgmstyle")]
    public IntegerValue Style
    {
      get
      {
        return (IntegerValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoformat")]
    public TrueFalseValue AutoFormat
    {
      get
      {
        return (TrueFalseValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "reverse")]
    public TrueFalseValue Reverse
    {
      get
      {
        return (TrueFalseValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autolayout")]
    public TrueFalseValue AutoLayout
    {
      get
      {
        return (TrueFalseValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dgmscalex")]
    public IntegerValue ScaleX
    {
      get
      {
        return (IntegerValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dgmscaley")]
    public IntegerValue ScaleY
    {
      get
      {
        return (IntegerValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dgmfontsize")]
    public IntegerValue FontSize
    {
      get
      {
        return (IntegerValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "constrainbounds")]
    public StringValue ConstrainBounds
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

    [SchemaAttr(0, "dgmbasetextscale")]
    public IntegerValue BaseTextScale
    {
      get
      {
        return (IntegerValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    public Diagram()
    {
    }

    public Diagram(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Diagram(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Diagram(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "relationtable" == name)
        return (OpenXmlElement) new RelationTable();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Diagram.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Diagram.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RelationTable RelationTable
    {
      get
      {
        return this.GetElement<RelationTable>(0);
      }
      set
      {
        this.SetElement<RelationTable>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      if ((int) namespaceId == 0 && "dgmstyle" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "autoformat" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "reverse" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "autolayout" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "dgmscalex" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "dgmscaley" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "dgmfontsize" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "constrainbounds" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "dgmbasetextscale" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Diagram>(deep);
    }
  }
}
