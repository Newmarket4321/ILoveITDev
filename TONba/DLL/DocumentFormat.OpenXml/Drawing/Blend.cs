// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Blend
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EffectContainer))]
  public class Blend : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "blend"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "cont"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };
    private const string tagName = "blend";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10064;

    public override string LocalName
    {
      get
      {
        return "blend";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10064;
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
        return Blend.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Blend.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "blend")]
    public EnumValue<BlendModeValues> BlendMode
    {
      get
      {
        return (EnumValue<BlendModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public Blend()
    {
    }

    public Blend(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Blend(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Blend(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "cont" == name)
        return (OpenXmlElement) new EffectContainer();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Blend.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Blend.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public EffectContainer EffectContainer
    {
      get
      {
        return this.GetElement<EffectContainer>(0);
      }
      set
      {
        this.SetElement<EffectContainer>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "blend" == name)
        return (OpenXmlSimpleType) new EnumValue<BlendModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Blend>(deep);
    }
  }
}
