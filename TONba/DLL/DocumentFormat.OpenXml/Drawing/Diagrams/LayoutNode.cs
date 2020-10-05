// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (VariableList))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Choose))]
  [ChildElementInfo(typeof (Algorithm))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (PresentationOf))]
  [ChildElementInfo(typeof (Constraints))]
  [ChildElementInfo(typeof (RuleList))]
  [ChildElementInfo(typeof (ForEach))]
  [ChildElementInfo(typeof (LayoutNode))]
  public class LayoutNode : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "name",
      "styleLbl",
      "chOrder",
      "moveWith"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "layoutNode";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10719;

    public override string LocalName
    {
      get
      {
        return "layoutNode";
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
        return 10719;
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
        return LayoutNode.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LayoutNode.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "styleLbl")]
    public StringValue StyleLabel
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

    [SchemaAttr(0, "chOrder")]
    public EnumValue<ChildOrderValues> ChildOrder
    {
      get
      {
        return (EnumValue<ChildOrderValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "moveWith")]
    public StringValue MoveWith
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

    public LayoutNode()
    {
    }

    public LayoutNode(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LayoutNode(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LayoutNode(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "alg" == name)
        return (OpenXmlElement) new Algorithm();
      if (14 == (int) namespaceId && "shape" == name)
        return (OpenXmlElement) new Shape();
      if (14 == (int) namespaceId && "presOf" == name)
        return (OpenXmlElement) new PresentationOf();
      if (14 == (int) namespaceId && "constrLst" == name)
        return (OpenXmlElement) new Constraints();
      if (14 == (int) namespaceId && "ruleLst" == name)
        return (OpenXmlElement) new RuleList();
      if (14 == (int) namespaceId && "varLst" == name)
        return (OpenXmlElement) new VariableList();
      if (14 == (int) namespaceId && "forEach" == name)
        return (OpenXmlElement) new ForEach();
      if (14 == (int) namespaceId && "layoutNode" == name)
        return (OpenXmlElement) new LayoutNode();
      if (14 == (int) namespaceId && "choose" == name)
        return (OpenXmlElement) new Choose();
      if (14 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "styleLbl" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "chOrder" == name)
        return (OpenXmlSimpleType) new EnumValue<ChildOrderValues>();
      if ((int) namespaceId == 0 && "moveWith" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LayoutNode>(deep);
    }
  }
}
