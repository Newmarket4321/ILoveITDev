// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommonBehavior
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonTimeNode))]
  [ChildElementInfo(typeof (TargetElement))]
  [ChildElementInfo(typeof (AttributeNameList))]
  public class CommonBehavior : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "additive",
      "accumulate",
      "xfrmType",
      "from",
      "to",
      "by",
      "rctx",
      "override"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private static readonly string[] eleTagNames = new string[3]
    {
      "cTn",
      "tgtEl",
      "attrNameLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cBhvr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12285;

    public override string LocalName
    {
      get
      {
        return "cBhvr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12285;
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
        return CommonBehavior.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CommonBehavior.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "additive")]
    public EnumValue<BehaviorAdditiveValues> Additive
    {
      get
      {
        return (EnumValue<BehaviorAdditiveValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "accumulate")]
    public EnumValue<BehaviorAccumulateValues> Accumulate
    {
      get
      {
        return (EnumValue<BehaviorAccumulateValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "xfrmType")]
    public EnumValue<BehaviorTransformValues> TransformType
    {
      get
      {
        return (EnumValue<BehaviorTransformValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "from")]
    public StringValue From
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

    [SchemaAttr(0, "to")]
    public StringValue To
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "by")]
    public StringValue By
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rctx")]
    public StringValue RuntimeContext
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

    [SchemaAttr(0, "override")]
    public EnumValue<BehaviorOverrideValues> Override
    {
      get
      {
        return (EnumValue<BehaviorOverrideValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    public CommonBehavior()
    {
    }

    public CommonBehavior(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommonBehavior(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommonBehavior(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cTn" == name)
        return (OpenXmlElement) new CommonTimeNode();
      if (24 == (int) namespaceId && "tgtEl" == name)
        return (OpenXmlElement) new TargetElement();
      if (24 == (int) namespaceId && "attrNameLst" == name)
        return (OpenXmlElement) new AttributeNameList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CommonBehavior.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CommonBehavior.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonTimeNode CommonTimeNode
    {
      get
      {
        return this.GetElement<CommonTimeNode>(0);
      }
      set
      {
        this.SetElement<CommonTimeNode>(0, value);
      }
    }

    public TargetElement TargetElement
    {
      get
      {
        return this.GetElement<TargetElement>(1);
      }
      set
      {
        this.SetElement<TargetElement>(1, value);
      }
    }

    public AttributeNameList AttributeNameList
    {
      get
      {
        return this.GetElement<AttributeNameList>(2);
      }
      set
      {
        this.SetElement<AttributeNameList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "additive" == name)
        return (OpenXmlSimpleType) new EnumValue<BehaviorAdditiveValues>();
      if ((int) namespaceId == 0 && "accumulate" == name)
        return (OpenXmlSimpleType) new EnumValue<BehaviorAccumulateValues>();
      if ((int) namespaceId == 0 && "xfrmType" == name)
        return (OpenXmlSimpleType) new EnumValue<BehaviorTransformValues>();
      if ((int) namespaceId == 0 && "from" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "to" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "by" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "rctx" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "override" == name)
        return (OpenXmlSimpleType) new EnumValue<BehaviorOverrideValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommonBehavior>(deep);
    }
  }
}
