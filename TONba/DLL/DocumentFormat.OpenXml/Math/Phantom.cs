// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Math.Phantom
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Math
{
  [ChildElementInfo(typeof (PhantomProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Base))]
  public class Phantom : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "phantPr",
      "e"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 21,
      (byte) 21
    };
    private const string tagName = "phant";
    private const byte tagNsId = 21;
    internal const int ElementTypeIdConst = 10921;

    public override string LocalName
    {
      get
      {
        return "phant";
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
        return 10921;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Phantom()
    {
    }

    public Phantom(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Phantom(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Phantom(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (21 == (int) namespaceId && "phantPr" == name)
        return (OpenXmlElement) new PhantomProperties();
      if (21 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new Base();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Phantom.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Phantom.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PhantomProperties PhantomProperties
    {
      get
      {
        return this.GetElement<PhantomProperties>(0);
      }
      set
      {
        this.SetElement<PhantomProperties>(0, value);
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Phantom>(deep);
    }
  }
}
