// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.EffectList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Glow))]
  [ChildElementInfo(typeof (Blur))]
  [ChildElementInfo(typeof (FillOverlay))]
  [ChildElementInfo(typeof (InnerShadow))]
  [ChildElementInfo(typeof (OuterShadow))]
  [ChildElementInfo(typeof (PresetShadow))]
  [ChildElementInfo(typeof (Reflection))]
  [ChildElementInfo(typeof (SoftEdge))]
  [GeneratedCode("DomGen", "2.0")]
  public class EffectList : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "blur",
      "fillOverlay",
      "glow",
      "innerShdw",
      "outerShdw",
      "prstShdw",
      "reflection",
      "softEdge"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "effectLst";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10083;

    public override string LocalName
    {
      get
      {
        return "effectLst";
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
        return 10083;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public EffectList()
    {
    }

    public EffectList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EffectList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EffectList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "blur" == name)
        return (OpenXmlElement) new Blur();
      if (10 == (int) namespaceId && "fillOverlay" == name)
        return (OpenXmlElement) new FillOverlay();
      if (10 == (int) namespaceId && "glow" == name)
        return (OpenXmlElement) new Glow();
      if (10 == (int) namespaceId && "innerShdw" == name)
        return (OpenXmlElement) new InnerShadow();
      if (10 == (int) namespaceId && "outerShdw" == name)
        return (OpenXmlElement) new OuterShadow();
      if (10 == (int) namespaceId && "prstShdw" == name)
        return (OpenXmlElement) new PresetShadow();
      if (10 == (int) namespaceId && "reflection" == name)
        return (OpenXmlElement) new Reflection();
      if (10 == (int) namespaceId && "softEdge" == name)
        return (OpenXmlElement) new SoftEdge();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return EffectList.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return EffectList.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Blur Blur
    {
      get
      {
        return this.GetElement<Blur>(0);
      }
      set
      {
        this.SetElement<Blur>(0, value);
      }
    }

    public FillOverlay FillOverlay
    {
      get
      {
        return this.GetElement<FillOverlay>(1);
      }
      set
      {
        this.SetElement<FillOverlay>(1, value);
      }
    }

    public Glow Glow
    {
      get
      {
        return this.GetElement<Glow>(2);
      }
      set
      {
        this.SetElement<Glow>(2, value);
      }
    }

    public InnerShadow InnerShadow
    {
      get
      {
        return this.GetElement<InnerShadow>(3);
      }
      set
      {
        this.SetElement<InnerShadow>(3, value);
      }
    }

    public OuterShadow OuterShadow
    {
      get
      {
        return this.GetElement<OuterShadow>(4);
      }
      set
      {
        this.SetElement<OuterShadow>(4, value);
      }
    }

    public PresetShadow PresetShadow
    {
      get
      {
        return this.GetElement<PresetShadow>(5);
      }
      set
      {
        this.SetElement<PresetShadow>(5, value);
      }
    }

    public Reflection Reflection
    {
      get
      {
        return this.GetElement<Reflection>(6);
      }
      set
      {
        this.SetElement<Reflection>(6, value);
      }
    }

    public SoftEdge SoftEdge
    {
      get
      {
        return this.GetElement<SoftEdge>(7);
      }
      set
      {
        this.SetElement<SoftEdge>(7, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EffectList>(deep);
    }
  }
}
