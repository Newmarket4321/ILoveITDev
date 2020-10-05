// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.AnimateMotion
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonBehavior))]
  [ChildElementInfo(typeof (FromPosition))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ByPosition))]
  [ChildElementInfo(typeof (ToPosition))]
  [ChildElementInfo(typeof (RotationCenter))]
  public class AnimateMotion : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "origin",
      "path",
      "pathEditMode",
      "rAng",
      "ptsTypes",
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
    private static readonly string[] eleTagNames = new string[5]
    {
      "cBhvr",
      "by",
      "from",
      "to",
      "rCtr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "animMotion";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12265;

    public override string LocalName
    {
      get
      {
        return "animMotion";
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
        return 12265;
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
        return AnimateMotion.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnimateMotion.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "origin")]
    public EnumValue<AnimateMotionBehaviorOriginValues> Origin
    {
      get
      {
        return (EnumValue<AnimateMotionBehaviorOriginValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "path")]
    public StringValue Path
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

    [SchemaAttr(0, "pathEditMode")]
    public EnumValue<AnimateMotionPathEditModeValues> PathEditMode
    {
      get
      {
        return (EnumValue<AnimateMotionPathEditModeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rAng")]
    public Int32Value RelativeAngle
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ptsTypes")]
    public StringValue PointTypes
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

    public AnimateMotion()
    {
    }

    public AnimateMotion(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AnimateMotion(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AnimateMotion(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cBhvr" == name)
        return (OpenXmlElement) new CommonBehavior();
      if (24 == (int) namespaceId && "by" == name)
        return (OpenXmlElement) new ByPosition();
      if (24 == (int) namespaceId && "from" == name)
        return (OpenXmlElement) new FromPosition();
      if (24 == (int) namespaceId && "to" == name)
        return (OpenXmlElement) new ToPosition();
      if (24 == (int) namespaceId && "rCtr" == name)
        return (OpenXmlElement) new RotationCenter();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AnimateMotion.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AnimateMotion.eleNamespaceIds;
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

    public ByPosition ByPosition
    {
      get
      {
        return this.GetElement<ByPosition>(1);
      }
      set
      {
        this.SetElement<ByPosition>(1, value);
      }
    }

    public FromPosition FromPosition
    {
      get
      {
        return this.GetElement<FromPosition>(2);
      }
      set
      {
        this.SetElement<FromPosition>(2, value);
      }
    }

    public ToPosition ToPosition
    {
      get
      {
        return this.GetElement<ToPosition>(3);
      }
      set
      {
        this.SetElement<ToPosition>(3, value);
      }
    }

    public RotationCenter RotationCenter
    {
      get
      {
        return this.GetElement<RotationCenter>(4);
      }
      set
      {
        this.SetElement<RotationCenter>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "origin" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateMotionBehaviorOriginValues>();
      if ((int) namespaceId == 0 && "path" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "pathEditMode" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateMotionPathEditModeValues>();
      if ((int) namespaceId == 0 && "rAng" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "ptsTypes" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (49 == (int) namespaceId && "bounceEnd" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnimateMotion>(deep);
    }
  }
}
