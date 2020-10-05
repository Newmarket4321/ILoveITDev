// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Nary
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (NaryProperties))]
  [ChildElementInfo(typeof (SuperArgument))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SubArgument))]
  [ChildElementInfo(typeof (Base))]
  public class Nary : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "naryPr",
      "sub",
      "sup",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "nary";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10920;

    public override string LocalName
    {
      get
      {
        return "nary";
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
        return 10920;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Nary()
    {
    }

    public Nary(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Nary(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Nary(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "naryPr" == name)
        return (OpenXmlElement) new NaryProperties();
      if (21 == (int) namespaceId && "sub" == name)
        return (OpenXmlElement) new SubArgument();
      if (21 == (int) namespaceId && "sup" == name)
        return (OpenXmlElement) new SuperArgument();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Nary.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Nary.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NaryProperties NaryProperties
    {
      get
      {
        return this.GetElement<NaryProperties>(0);
      }
      set
      {
        this.SetElement<NaryProperties>(0, value);
      }
    }

    public SubArgument SubArgument
    {
      get
      {
        return this.GetElement<SubArgument>(1);
      }
      set
      {
        this.SetElement<SubArgument>(1, value);
      }
    }

    public SuperArgument SuperArgument
    {
      get
      {
        return this.GetElement<SuperArgument>(2);
      }
      set
      {
        this.SetElement<SuperArgument>(2, value);
      }
    }

    public Base Base
    {
      get
      {
        return this.GetElement<Base>(3);
      }
      set
      {
        this.SetElement<Base>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Nary>(deep);
    }
  }
}
