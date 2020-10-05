// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Subscript
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (SubscriptProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  [ChildElementInfo(typeof (SubArgument))]
  public class Subscript : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "sSubPr",
      "e",
      "sub"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 21,
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "sSub";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10924;

    public override string LocalName
    {
      get
      {
        return "sSub";
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
        return 10924;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Subscript()
    {
    }

    public Subscript(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Subscript(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Subscript(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "sSubPr" == name)
        return (OpenXmlElement) new SubscriptProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      if (21 == (int) namespaceId && "sub" == name)
        return (OpenXmlElement) new SubArgument();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Subscript.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Subscript.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SubscriptProperties SubscriptProperties
    {
      get
      {
        return this.GetElement<SubscriptProperties>(0);
      }
      set
      {
        this.SetElement<SubscriptProperties>(0, value);
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Subscript>(deep);
    }
  }
}
