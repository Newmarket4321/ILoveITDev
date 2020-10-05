// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.Node
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [ChildElementInfo(typeof (Info))]
  [GeneratedCode("DomGen", "2.0")]
  public class Node : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "node-number",
      "confidence",
      "cost"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 0,
      (byte) 44,
      (byte) 44
    };
    private const string tagName = "node";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12755;

    public override string LocalName
    {
      get
      {
        return "node";
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
        return 12755;
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
        return Node.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Node.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "node-number")]
    public IntegerValue NodeNumber
    {
      get
      {
        return (IntegerValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
      get
      {
        return (DecimalValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
      get
      {
        return (DecimalValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public Node()
    {
    }

    public Node(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Node(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Node(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "info" == name)
        return (OpenXmlElement) new Info();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "node-number" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "confidence" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if (44 == (int) namespaceId && "cost" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Node>(deep);
    }
  }
}
