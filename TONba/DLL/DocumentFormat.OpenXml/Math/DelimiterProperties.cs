// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.DelimiterProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BeginChar))]
  [ChildElementInfo(typeof (SeparatorChar))]
  [ChildElementInfo(typeof (EndChar))]
  [ChildElementInfo(typeof (GrowOperators))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (ControlProperties))]
  public class DelimiterProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "begChr",
      "sepChr",
      "endChr",
      "grow",
      "shp",
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
    private const string tagName = "dPr";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10960;

    public override string LocalName
    {
      get
      {
        return "dPr";
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
        return 10960;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DelimiterProperties()
    {
    }

    public DelimiterProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DelimiterProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DelimiterProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "begChr" == name)
        return (OpenXmlElement) new BeginChar();
      if (21 == (int) namespaceId && "sepChr" == name)
        return (OpenXmlElement) new SeparatorChar();
      if (21 == (int) namespaceId && "endChr" == name)
        return (OpenXmlElement) new EndChar();
      if (21 == (int) namespaceId && "grow" == name)
        return (OpenXmlElement) new GrowOperators();
      if (21 == (int) namespaceId && "shp" == name)
        return (OpenXmlElement) new Shape();
      if (21 == (int) namespaceId && "ctrlPr" == name)
        return (OpenXmlElement) new ControlProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DelimiterProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DelimiterProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BeginChar BeginChar
    {
      get
      {
        return this.GetElement<BeginChar>(0);
      }
      set
      {
        this.SetElement<BeginChar>(0, value);
      }
    }

    public SeparatorChar SeparatorChar
    {
      get
      {
        return this.GetElement<SeparatorChar>(1);
      }
      set
      {
        this.SetElement<SeparatorChar>(1, value);
      }
    }

    public EndChar EndChar
    {
      get
      {
        return this.GetElement<EndChar>(2);
      }
      set
      {
        this.SetElement<EndChar>(2, value);
      }
    }

    public GrowOperators GrowOperators
    {
      get
      {
        return this.GetElement<GrowOperators>(3);
      }
      set
      {
        this.SetElement<GrowOperators>(3, value);
      }
    }

    public Shape Shape
    {
      get
      {
        return this.GetElement<Shape>(4);
      }
      set
      {
        this.SetElement<Shape>(4, value);
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
      return (OpenXmlElement) this.CloneImp<DelimiterProperties>(deep);
    }
  }
}
