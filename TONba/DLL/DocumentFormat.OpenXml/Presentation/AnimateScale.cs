// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.AnimateScale
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (ToPosition))]
  [ChildElementInfo(typeof (ByPosition))]
  [ChildElementInfo(typeof (FromPosition))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonBehavior))]
  public class AnimateScale : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "zoomContents",
      "bounceEnd"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 0,
      (byte) 49
    };
    private static readonly string[] eleTagNames = new string[4]
    {
      "cBhvr",
      "by",
      "from",
      "to"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "animScale";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12267;

    public override string LocalName
    {
      get
      {
        return "animScale";
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
        return 12267;
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
        return AnimateScale.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnimateScale.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "zoomContents")]
    public BooleanValue ZoomContents
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(49, "bounceEnd")]
    public Int32Value BounceEnd
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public AnimateScale()
    {
    }

    public AnimateScale(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AnimateScale(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AnimateScale(string outerXml)
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
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AnimateScale.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AnimateScale.eleNamespaceIds;
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "zoomContents" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if (49 == (int) namespaceId && "bounceEnd" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnimateScale>(deep);
    }
  }
}
