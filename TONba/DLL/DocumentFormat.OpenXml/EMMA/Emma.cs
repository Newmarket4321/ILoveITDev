// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.Emma
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [ChildElementInfo(typeof (Derivation))]
  [ChildElementInfo(typeof (EndPointInfo))]
  [ChildElementInfo(typeof (Info))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Grammar))]
  [ChildElementInfo(typeof (Model))]
  [ChildElementInfo(typeof (Interpretation))]
  [ChildElementInfo(typeof (OneOf))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (Sequence))]
  public class Emma : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "version"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "emma";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12757;

    public override string LocalName
    {
      get
      {
        return "emma";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 44;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12757;
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
        return Emma.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Emma.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "version")]
    public StringValue Version
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

    public Emma()
    {
    }

    public Emma(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Emma(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Emma(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "derivation" == name)
        return (OpenXmlElement) new Derivation();
      if (44 == (int) namespaceId && "grammar" == name)
        return (OpenXmlElement) new Grammar();
      if (44 == (int) namespaceId && "model" == name)
        return (OpenXmlElement) new Model();
      if (44 == (int) namespaceId && "endpoint-info" == name)
        return (OpenXmlElement) new EndPointInfo();
      if (44 == (int) namespaceId && "info" == name)
        return (OpenXmlElement) new Info();
      if (44 == (int) namespaceId && "interpretation" == name)
        return (OpenXmlElement) new Interpretation();
      if (44 == (int) namespaceId && "one-of" == name)
        return (OpenXmlElement) new OneOf();
      if (44 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new Group();
      if (44 == (int) namespaceId && "sequence" == name)
        return (OpenXmlElement) new Sequence();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "version" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Emma>(deep);
    }
  }
}
