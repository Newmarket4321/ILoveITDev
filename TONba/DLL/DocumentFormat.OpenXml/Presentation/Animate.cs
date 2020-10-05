// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Animate
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonBehavior))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TimeAnimateValueList))]
  public class Animate : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "by",
      "from",
      "to",
      "calcmode",
      "valueType",
      "bounceEnd"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 49
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "cBhvr",
      "tavLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "anim";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12262;

    public override string LocalName
    {
      get
      {
        return "anim";
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
        return 12262;
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
        return Animate.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Animate.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "by")]
    public StringValue By
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

    [SchemaAttr(0, "from")]
    public StringValue From
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

    [SchemaAttr(0, "to")]
    public StringValue To
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

    [SchemaAttr(0, "calcmode")]
    public EnumValue<AnimateBehaviorCalculateModeValues> CalculationMode
    {
      get
      {
        return (EnumValue<AnimateBehaviorCalculateModeValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "valueType")]
    public EnumValue<AnimateBehaviorValues> ValueType
    {
      get
      {
        return (EnumValue<AnimateBehaviorValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(49, "bounceEnd")]
    public Int32Value BounceEnd
    {
      get
      {
        return (Int32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public Animate()
    {
    }

    public Animate(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Animate(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Animate(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cBhvr" == name)
        return (OpenXmlElement) new CommonBehavior();
      if (24 == (int) namespaceId && "tavLst" == name)
        return (OpenXmlElement) new TimeAnimateValueList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Animate.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Animate.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonBehavior CommonBehavior
    {
      get
      {
        return this.GetElement<CommonBehavior>(0);
      }
      set
      {
        this.SetElement<CommonBehavior>(0, value);
      }
    }

    public TimeAnimateValueList TimeAnimateValueList
    {
      get
      {
        return this.GetElement<TimeAnimateValueList>(1);
      }
      set
      {
        this.SetElement<TimeAnimateValueList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "by" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "from" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "to" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "calcmode" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateBehaviorCalculateModeValues>();
      if ((int) namespaceId == 0 && "valueType" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateBehaviorValues>();
      if (49 == (int) namespaceId && "bounceEnd" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Animate>(deep);
    }
  }
}
