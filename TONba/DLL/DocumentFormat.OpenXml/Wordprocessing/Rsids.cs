// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Rsids
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RsidRoot))]
  [ChildElementInfo(typeof (Rsid))]
  public class Rsids : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "rsidRoot",
      "rsid"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "rsids";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12185;

    public override string LocalName
    {
      get
      {
        return "rsids";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12185;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Rsids()
    {
    }

    public Rsids(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Rsids(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Rsids(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rsidRoot" == name)
        return (OpenXmlElement) new RsidRoot();
      if (23 == (int) namespaceId && "rsid" == name)
        return (OpenXmlElement) new Rsid();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Rsids.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Rsids.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RsidRoot RsidRoot
    {
      get
      {
        return this.GetElement<RsidRoot>(0);
      }
      set
      {
        this.SetElement<RsidRoot>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Rsids>(deep);
    }
  }
}
