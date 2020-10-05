// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (TabularSlicerCache), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OlapSlicerCache), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class SlicerCacheData : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "olap",
      "tabular"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "data";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13074;

    public override string LocalName
    {
      get
      {
        return "data";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13074;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SlicerCacheData()
    {
    }

    public SlicerCacheData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlicerCacheData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlicerCacheData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "olap" == name)
        return (OpenXmlElement) new OlapSlicerCache();
      if (53 == (int) namespaceId && "tabular" == name)
        return (OpenXmlElement) new TabularSlicerCache();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SlicerCacheData.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SlicerCacheData.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public OlapSlicerCache OlapSlicerCache
    {
      get
      {
        return this.GetElement<OlapSlicerCache>(0);
      }
      set
      {
        this.SetElement<OlapSlicerCache>(0, value);
      }
    }

    public TabularSlicerCache TabularSlicerCache
    {
      get
      {
        return this.GetElement<TabularSlicerCache>(1);
      }
      set
      {
        this.SetElement<TabularSlicerCache>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerCacheData>(deep);
    }
  }
}
