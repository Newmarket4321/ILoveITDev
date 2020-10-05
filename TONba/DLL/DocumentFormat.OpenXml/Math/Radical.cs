// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Radical
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (RadicalProperties))]
  [ChildElementInfo(typeof (Degree))]
  [ChildElementInfo(typeof (Base))]
  [GeneratedCode("DomGen", "2.0")]
  public class Radical : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "radPr",
      "deg",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "rad";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10922;

    public override string LocalName
    {
      get
      {
        return "rad";
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
        return 10922;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Radical()
    {
    }

    public Radical(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Radical(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Radical(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "radPr" == name)
        return (OpenXmlElement) new RadicalProperties();
      if (21 == (int) namespaceId && "deg" == name)
        return (OpenXmlElement) new Degree();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Radical.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Radical.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RadicalProperties RadicalProperties
    {
      get
      {
        return this.GetElement<RadicalProperties>(0);
      }
      set
      {
        this.SetElement<RadicalProperties>(0, value);
      }
    }

    public Degree Degree
    {
      get
      {
        return this.GetElement<Degree>(1);
      }
      set
      {
        this.SetElement<Degree>(1, value);
      }
    }

    public Base Base
    {
      get
      {
        return this.GetElement<Base>(2);
      }
      set
      {
        this.SetElement<Base>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Radical>(deep);
    }
  }
}
