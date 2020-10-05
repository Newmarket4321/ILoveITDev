// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.Rule
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [ChildElementInfo(typeof (Proxy))]
  [GeneratedCode("DomGen", "2.0")]
  public class Rule : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "id",
      "type",
      "how",
      "idref"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "r";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12492;

    public override string LocalName
    {
      get
      {
        return "r";
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
        return 12492;
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

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "type")]
    public EnumValue<RuleValues> Type
    {
      get
      {
        return (EnumValue<RuleValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "how")]
    public EnumValue<AlignmentValues> How
    {
      get
      {
        return (EnumValue<AlignmentValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "idref")]
    public StringValue ShapeReference
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
      if (27 == (int) namespaceId && "proxy" == name)
        return (OpenXmlElement) new Proxy();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<RuleValues>();
      if ((int) namespaceId == 0 && "how" == name)
        return (OpenXmlSimpleType) new EnumValue<AlignmentValues>();
      if ((int) namespaceId == 0 && "idref" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Rule>(deep);
    }
  }
}
