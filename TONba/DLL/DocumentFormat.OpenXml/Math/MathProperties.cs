// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.MathProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (MathFont))]
  [ChildElementInfo(typeof (PostSpacing))]
  [ChildElementInfo(typeof (BreakBinary))]
  [ChildElementInfo(typeof (BreakBinarySubtraction))]
  [ChildElementInfo(typeof (SmallFraction))]
  [ChildElementInfo(typeof (DisplayDefaults))]
  [ChildElementInfo(typeof (LeftMargin))]
  [ChildElementInfo(typeof (RightMargin))]
  [ChildElementInfo(typeof (DefaultJustification))]
  [ChildElementInfo(typeof (PreSpacing))]
  [ChildElementInfo(typeof (IntegralLimitLocation))]
  [ChildElementInfo(typeof (InterSpacing))]
  [ChildElementInfo(typeof (IntraSpacing))]
  [ChildElementInfo(typeof (WrapIndent))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (WrapRight))]
  [ChildElementInfo(typeof (NaryLimitLocation))]
  public class MathProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      "mathFont",
      "brkBin",
      "brkBinSub",
      "smallFrac",
      "dispDef",
      "lMargin",
      "rMargin",
      "defJc",
      "preSp",
      "postSp",
      "interSp",
      "intraSp",
      "wrapIndent",
      "wrapRight",
      "intLim",
      "naryLim"
    };
    private static readonly byte[] eleNamespaceIds = new byte[16]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "mathPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10929;

    public override string LocalName
    {
      get
      {
        return "mathPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 21;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10929;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MathProperties()
    {
    }

    public MathProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MathProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MathProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "mathFont" == name)
        return (OpenXmlElement) new MathFont();
      if (21 == (int) namespaceId && "brkBin" == name)
        return (OpenXmlElement) new BreakBinary();
      if (21 == (int) namespaceId && "brkBinSub" == name)
        return (OpenXmlElement) new BreakBinarySubtraction();
      if (21 == (int) namespaceId && "smallFrac" == name)
        return (OpenXmlElement) new SmallFraction();
      if (21 == (int) namespaceId && "dispDef" == name)
        return (OpenXmlElement) new DisplayDefaults();
      if (21 == (int) namespaceId && "lMargin" == name)
        return (OpenXmlElement) new LeftMargin();
      if (21 == (int) namespaceId && "rMargin" == name)
        return (OpenXmlElement) new RightMargin();
      if (21 == (int) namespaceId && "defJc" == name)
        return (OpenXmlElement) new DefaultJustification();
      if (21 == (int) namespaceId && "preSp" == name)
        return (OpenXmlElement) new PreSpacing();
      if (21 == (int) namespaceId && "postSp" == name)
        return (OpenXmlElement) new PostSpacing();
      if (21 == (int) namespaceId && "interSp" == name)
        return (OpenXmlElement) new InterSpacing();
      if (21 == (int) namespaceId && "intraSp" == name)
        return (OpenXmlElement) new IntraSpacing();
      if (21 == (int) namespaceId && "wrapIndent" == name)
        return (OpenXmlElement) new WrapIndent();
      if (21 == (int) namespaceId && "wrapRight" == name)
        return (OpenXmlElement) new WrapRight();
      if (21 == (int) namespaceId && "intLim" == name)
        return (OpenXmlElement) new IntegralLimitLocation();
      if (21 == (int) namespaceId && "naryLim" == name)
        return (OpenXmlElement) new NaryLimitLocation();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MathProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MathProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MathFont MathFont
    {
      get
      {
        return this.GetElement<MathFont>(0);
      }
      set
      {
        this.SetElement<MathFont>(0, value);
      }
    }

    public BreakBinary BreakBinary
    {
      get
      {
        return this.GetElement<BreakBinary>(1);
      }
      set
      {
        this.SetElement<BreakBinary>(1, value);
      }
    }

    public BreakBinarySubtraction BreakBinarySubtraction
    {
      get
      {
        return this.GetElement<BreakBinarySubtraction>(2);
      }
      set
      {
        this.SetElement<BreakBinarySubtraction>(2, value);
      }
    }

    public SmallFraction SmallFraction
    {
      get
      {
        return this.GetElement<SmallFraction>(3);
      }
      set
      {
        this.SetElement<SmallFraction>(3, value);
      }
    }

    public DisplayDefaults DisplayDefaults
    {
      get
      {
        return this.GetElement<DisplayDefaults>(4);
      }
      set
      {
        this.SetElement<DisplayDefaults>(4, value);
      }
    }

    public LeftMargin LeftMargin
    {
      get
      {
        return this.GetElement<LeftMargin>(5);
      }
      set
      {
        this.SetElement<LeftMargin>(5, value);
      }
    }

    public RightMargin RightMargin
    {
      get
      {
        return this.GetElement<RightMargin>(6);
      }
      set
      {
        this.SetElement<RightMargin>(6, value);
      }
    }

    public DefaultJustification DefaultJustification
    {
      get
      {
        return this.GetElement<DefaultJustification>(7);
      }
      set
      {
        this.SetElement<DefaultJustification>(7, value);
      }
    }

    public PreSpacing PreSpacing
    {
      get
      {
        return this.GetElement<PreSpacing>(8);
      }
      set
      {
        this.SetElement<PreSpacing>(8, value);
      }
    }

    public PostSpacing PostSpacing
    {
      get
      {
        return this.GetElement<PostSpacing>(9);
      }
      set
      {
        this.SetElement<PostSpacing>(9, value);
      }
    }

    public InterSpacing InterSpacing
    {
      get
      {
        return this.GetElement<InterSpacing>(10);
      }
      set
      {
        this.SetElement<InterSpacing>(10, value);
      }
    }

    public IntraSpacing IntraSpacing
    {
      get
      {
        return this.GetElement<IntraSpacing>(11);
      }
      set
      {
        this.SetElement<IntraSpacing>(11, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MathProperties>(deep);
    }
  }
}
