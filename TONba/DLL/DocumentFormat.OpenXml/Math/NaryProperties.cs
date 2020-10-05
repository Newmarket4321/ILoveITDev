// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.NaryProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (HideSubArgument))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LimitLocation))]
  [ChildElementInfo(typeof (AccentChar))]
  [ChildElementInfo(typeof (GrowOperators))]
  [ChildElementInfo(typeof (HideSuperArgument))]
  [ChildElementInfo(typeof (ControlProperties))]
  public class NaryProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "chr",
      "limLoc",
      "grow",
      "subHide",
      "supHide",
      "ctrlPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "naryPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10992;

    public override string LocalName
    {
      get
      {
        return "naryPr";
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
        return 10992;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NaryProperties()
    {
    }

    public NaryProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NaryProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NaryProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "chr" == name)
        return (OpenXmlElement) new AccentChar();
      if (21 == (int) namespaceId && "limLoc" == name)
        return (OpenXmlElement) new LimitLocation();
      if (21 == (int) namespaceId && "grow" == name)
        return (OpenXmlElement) new GrowOperators();
      if (21 == (int) namespaceId && "subHide" == name)
        return (OpenXmlElement) new HideSubArgument();
      if (21 == (int) namespaceId && "supHide" == name)
        return (OpenXmlElement) new HideSuperArgument();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NaryProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NaryProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AccentChar AccentChar
    {
      get
      {
        return this.GetElement<AccentChar>(0);
      }
      set
      {
        this.SetElement<AccentChar>(0, value);
      }
    }

    public LimitLocation LimitLocation
    {
      get
      {
        return this.GetElement<LimitLocation>(1);
      }
      set
      {
        this.SetElement<LimitLocation>(1, value);
      }
    }

    public GrowOperators GrowOperators
    {
      get
      {
        return this.GetElement<GrowOperators>(2);
      }
      set
      {
        this.SetElement<GrowOperators>(2, value);
      }
    }

    public HideSubArgument HideSubArgument
    {
      get
      {
        return this.GetElement<HideSubArgument>(3);
      }
      set
      {
        this.SetElement<HideSubArgument>(3, value);
      }
    }

    public HideSuperArgument HideSuperArgument
    {
      get
      {
        return this.GetElement<HideSuperArgument>(4);
      }
      set
      {
        this.SetElement<HideSuperArgument>(4, value);
      }
    }

    public ControlProperties ControlProperties
    {
      get
      {
        return this.GetElement<ControlProperties>(5);
      }
      set
      {
        this.SetElement<ControlProperties>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NaryProperties>(deep);
    }
  }
}
