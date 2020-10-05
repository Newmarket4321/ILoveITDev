// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.FillOverlay
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (PatternFill))]
  [ChildElementInfo(typeof (GroupFill))]
  public class FillOverlay : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "blend"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[6]
    {
      "noFill",
      "solidFill",
      "gradFill",
      "blipFill",
      "pattFill",
      "grpFill"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "fillOverlay";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10070;

    public override string LocalName
    {
      get
      {
        return "fillOverlay";
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
        return 10070;
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
        return FillOverlay.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FillOverlay.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "blend")]
    public EnumValue<BlendModeValues> Blend
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

    public FillOverlay()
    {
    }

    public FillOverlay(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FillOverlay(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FillOverlay(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "grpFill" == name)
        return (OpenXmlElement) new GroupFill();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FillOverlay.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FillOverlay.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public NoFill NoFill
    {
      get
      {
        return this.GetElement<NoFill>(0);
      }
      set
      {
        this.SetElement<NoFill>(0, value);
      }
    }

    public SolidFill SolidFill
    {
      get
      {
        return this.GetElement<SolidFill>(1);
      }
      set
      {
        this.SetElement<SolidFill>(1, value);
      }
    }

    public GradientFill GradientFill
    {
      get
      {
        return this.GetElement<GradientFill>(2);
      }
      set
      {
        this.SetElement<GradientFill>(2, value);
      }
    }

    public BlipFill BlipFill
    {
      get
      {
        return this.GetElement<BlipFill>(3);
      }
      set
      {
        this.SetElement<BlipFill>(3, value);
      }
    }

    public PatternFill PatternFill
    {
      get
      {
        return this.GetElement<PatternFill>(4);
      }
      set
      {
        this.SetElement<PatternFill>(4, value);
      }
    }

    public GroupFill GroupFill
    {
      get
      {
        return this.GetElement<GroupFill>(5);
      }
      set
      {
        this.SetElement<GroupFill>(5, value);
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
      return (OpenXmlElement) this.CloneImp<FillOverlay>(deep);
    }
  }
}
