// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.LimitLower
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (Limit))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LimitLowerProperties))]
  [ChildElementInfo(typeof (Base))]
  public class LimitLower : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "limLowPr",
      "e",
      "lim"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "limLow";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10917;

    public override string LocalName
    {
      get
      {
        return "limLow";
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
        return 10917;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LimitLower()
    {
    }

    public LimitLower(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LimitLower(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LimitLower(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "limLowPr" == name)
        return (OpenXmlElement) new LimitLowerProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      if (21 == (int) namespaceId && "lim" == name)
        return (OpenXmlElement) new Limit();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LimitLower.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LimitLower.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LimitLowerProperties LimitLowerProperties
    {
      get
      {
        return this.GetElement<LimitLowerProperties>(0);
      }
      set
      {
        this.SetElement<LimitLowerProperties>(0, value);
      }
    }

    public Base Base
    {
      get
      {
        return this.GetElement<Base>(1);
      }
      set
      {
        this.SetElement<Base>(1, value);
      }
    }

    public Limit Limit
    {
      get
      {
        return this.GetElement<Limit>(2);
      }
      set
      {
        this.SetElement<Limit>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LimitLower>(deep);
    }
  }
}
