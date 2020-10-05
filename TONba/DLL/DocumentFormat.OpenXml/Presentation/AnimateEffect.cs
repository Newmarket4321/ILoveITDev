// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.AnimateEffect
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommonBehavior))]
  [ChildElementInfo(typeof (Progress))]
  public class AnimateEffect : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "transition",
      "filter",
      "prLst"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[2]
    {
      "cBhvr",
      "progress"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "animEffect";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12264;

    public override string LocalName
    {
      get
      {
        return "animEffect";
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
        return 12264;
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
        return AnimateEffect.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AnimateEffect.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "transition")]
    public EnumValue<AnimateEffectTransitionValues> Transition
    {
      get
      {
        return (EnumValue<AnimateEffectTransitionValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filter")]
    public StringValue Filter
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

    [SchemaAttr(0, "prLst")]
    public StringValue PropertyList
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

    public AnimateEffect()
    {
    }

    public AnimateEffect(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AnimateEffect(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AnimateEffect(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cBhvr" == name)
        return (OpenXmlElement) new CommonBehavior();
      if (24 == (int) namespaceId && "progress" == name)
        return (OpenXmlElement) new Progress();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return AnimateEffect.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return AnimateEffect.eleNamespaceIds;
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

    public Progress Progress
    {
      get
      {
        return this.GetElement<Progress>(1);
      }
      set
      {
        this.SetElement<Progress>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "transition" == name)
        return (OpenXmlSimpleType) new EnumValue<AnimateEffectTransitionValues>();
      if ((int) namespaceId == 0 && "filter" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "prLst" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AnimateEffect>(deep);
    }
  }
}
