// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.SubSuperscript
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (SubSuperscriptProperties))]
  [ChildElementInfo(typeof (SubArgument))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  [ChildElementInfo(typeof (SuperArgument))]
  public class SubSuperscript : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "sSubSupPr",
      "e",
      "sub",
      "sup"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "sSubSup";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10925;

    public override string LocalName
    {
      get
      {
        return "sSubSup";
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
        return 10925;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SubSuperscript()
    {
    }

    public SubSuperscript(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SubSuperscript(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SubSuperscript(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "sSubSupPr" == name)
        return (OpenXmlElement) new SubSuperscriptProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      if (21 == (int) namespaceId && "sub" == name)
        return (OpenXmlElement) new SubArgument();
      if (21 == (int) namespaceId && "sup" == name)
        return (OpenXmlElement) new SuperArgument();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SubSuperscript.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SubSuperscript.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SubSuperscriptProperties SubSuperscriptProperties
    {
      get
      {
        return this.GetElement<SubSuperscriptProperties>(0);
      }
      set
      {
        this.SetElement<SubSuperscriptProperties>(0, value);
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

    public SubArgument SubArgument
    {
      get
      {
        return this.GetElement<SubArgument>(2);
      }
      set
      {
        this.SetElement<SubArgument>(2, value);
      }
    }

    public SuperArgument SuperArgument
    {
      get
      {
        return this.GetElement<SuperArgument>(3);
      }
      set
      {
        this.SetElement<SuperArgument>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SubSuperscript>(deep);
    }
  }
}
