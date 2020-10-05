// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TupleCache
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Entries))]
  [ChildElementInfo(typeof (ServerFormats))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Sets))]
  [ChildElementInfo(typeof (QueryCache))]
  public class TupleCache : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "entries",
      "sets",
      "queryCache",
      "serverFormats",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "tupleCache";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11452;

    public override string LocalName
    {
      get
      {
        return "tupleCache";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11452;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TupleCache()
    {
    }

    public TupleCache(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TupleCache(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TupleCache(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "entries" == name)
        return (OpenXmlElement) new Entries();
      if (22 == (int) namespaceId && "sets" == name)
        return (OpenXmlElement) new Sets();
      if (22 == (int) namespaceId && "queryCache" == name)
        return (OpenXmlElement) new QueryCache();
      if (22 == (int) namespaceId && "serverFormats" == name)
        return (OpenXmlElement) new ServerFormats();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TupleCache.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TupleCache.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Entries Entries
    {
      get
      {
        return this.GetElement<Entries>(0);
      }
      set
      {
        this.SetElement<Entries>(0, value);
      }
    }

    public Sets Sets
    {
      get
      {
        return this.GetElement<Sets>(1);
      }
      set
      {
        this.SetElement<Sets>(1, value);
      }
    }

    public QueryCache QueryCache
    {
      get
      {
        return this.GetElement<QueryCache>(2);
      }
      set
      {
        this.SetElement<QueryCache>(2, value);
      }
    }

    public ServerFormats ServerFormats
    {
      get
      {
        return this.GetElement<ServerFormats>(3);
      }
      set
      {
        this.SetElement<ServerFormats>(3, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TupleCache>(deep);
    }
  }
}
