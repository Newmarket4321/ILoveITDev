// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.PreSubSuper
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (SubArgument))]
  [ChildElementInfo(typeof (Base))]
  [ChildElementInfo(typeof (PreSubSuperProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SuperArgument))]
  public class PreSubSuper : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "sPrePr",
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
    private const string tagName = "sPre";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10923;

    public override string LocalName
    {
      get
      {
        return "sPre";
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
        return 10923;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PreSubSuper()
    {
    }

    public PreSubSuper(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PreSubSuper(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PreSubSuper(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "sPrePr" == name)
        return (OpenXmlElement) new PreSubSuperProperties();
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
        return PreSubSuper.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PreSubSuper.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PreSubSuperProperties PreSubSuperProperties
    {
      get
      {
        return this.GetElement<PreSubSuperProperties>(0);
      }
      set
      {
        this.SetElement<PreSubSuperProperties>(0, value);
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
      return (OpenXmlElement) this.CloneImp<PreSubSuper>(deep);
    }
  }
}
