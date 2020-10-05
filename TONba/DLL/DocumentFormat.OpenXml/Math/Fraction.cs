// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Fraction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (Numerator))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FractionProperties))]
  [ChildElementInfo(typeof (Denominator))]
  public class Fraction : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "fPr",
      "num",
      "den"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "f";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10914;

    public override string LocalName
    {
      get
      {
        return "f";
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
        return 10914;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Fraction()
    {
    }

    public Fraction(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Fraction(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Fraction(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "fPr" == name)
        return (OpenXmlElement) new FractionProperties();
      if (21 == (int) namespaceId && "num" == name)
        return (OpenXmlElement) new Numerator();
      if (21 == (int) namespaceId && "den" == name)
        return (OpenXmlElement) new Denominator();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Fraction.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Fraction.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FractionProperties FractionProperties
    {
      get
      {
        return this.GetElement<FractionProperties>(0);
      }
      set
      {
        this.SetElement<FractionProperties>(0, value);
      }
    }

    public Numerator Numerator
    {
      get
      {
        return this.GetElement<Numerator>(1);
      }
      set
      {
        this.SetElement<Numerator>(1, value);
      }
    }

    public Denominator Denominator
    {
      get
      {
        return this.GetElement<Denominator>(2);
      }
      set
      {
        this.SetElement<Denominator>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Fraction>(deep);
    }
  }
}
