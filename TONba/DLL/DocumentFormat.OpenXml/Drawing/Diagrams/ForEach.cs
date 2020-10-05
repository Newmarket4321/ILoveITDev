// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ForEach
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (Constraints))]
  [ChildElementInfo(typeof (Choose))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (PresentationOf))]
  [ChildElementInfo(typeof (Algorithm))]
  [ChildElementInfo(typeof (RuleList))]
  [ChildElementInfo(typeof (ForEach))]
  [ChildElementInfo(typeof (LayoutNode))]
  public class ForEach : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "name",
      "ref",
      "axis",
      "ptType",
      "hideLastTrans",
      "st",
      "cnt",
      "step"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private const string tagName = "forEach";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10718;

    public override string LocalName
    {
      get
      {
        return "forEach";
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
        return 10718;
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
        return ForEach.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ForEach.attributeNamespaceIds;
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

    [SchemaAttr(0, "ref")]
    public StringValue Reference
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

    [SchemaAttr(0, "axis")]
    public ListValue<EnumValue<AxisValues>> Axis
    {
      get
      {
        return (ListValue<EnumValue<AxisValues>>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ptType")]
    public ListValue<EnumValue<ElementValues>> PointType
    {
      get
      {
        return (ListValue<EnumValue<ElementValues>>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hideLastTrans")]
    public ListValue<BooleanValue> HideLastTrans
    {
      get
      {
        return (ListValue<BooleanValue>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "st")]
    public ListValue<Int32Value> Start
    {
      get
      {
        return (ListValue<Int32Value>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cnt")]
    public ListValue<UInt32Value> Count
    {
      get
      {
        return (ListValue<UInt32Value>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "step")]
    public ListValue<Int32Value> Step
    {
      get
      {
        return (ListValue<Int32Value>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    public ForEach()
    {
    }

    public ForEach(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ForEach(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ForEach(string outerXml)
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
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "axis" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<AxisValues>>();
      if ((int) namespaceId == 0 && "ptType" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<ElementValues>>();
      if ((int) namespaceId == 0 && "hideLastTrans" == name)
        return (OpenXmlSimpleType) new ListValue<BooleanValue>();
      if ((int) namespaceId == 0 && "st" == name)
        return (OpenXmlSimpleType) new ListValue<Int32Value>();
      if ((int) namespaceId == 0 && "cnt" == name)
        return (OpenXmlSimpleType) new ListValue<UInt32Value>();
      if ((int) namespaceId == 0 && "step" == name)
        return (OpenXmlSimpleType) new ListValue<Int32Value>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ForEach>(deep);
    }
  }
}
