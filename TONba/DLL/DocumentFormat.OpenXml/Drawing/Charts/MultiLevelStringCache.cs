// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PointCount))]
  [ChildElementInfo(typeof (Level))]
  public class MultiLevelStringCache : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "ptCount",
      "lvl",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "multiLvlStrCache";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10576;

    public override string LocalName
    {
      get
      {
        return "multiLvlStrCache";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10576;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MultiLevelStringCache()
    {
    }

    public MultiLevelStringCache(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MultiLevelStringCache(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MultiLevelStringCache(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "ptCount" == name)
        return (OpenXmlElement) new PointCount();
      if (11 == (int) namespaceId && "lvl" == name)
        return (OpenXmlElement) new Level();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MultiLevelStringCache.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MultiLevelStringCache.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PointCount PointCount
    {
      get
      {
        return this.GetElement<PointCount>(0);
      }
      set
      {
        this.SetElement<PointCount>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MultiLevelStringCache>(deep);
    }
  }
}
