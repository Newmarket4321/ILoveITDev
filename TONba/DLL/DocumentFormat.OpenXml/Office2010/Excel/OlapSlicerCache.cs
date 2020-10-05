// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCache
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (OlapSlicerCacheLevelsData), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (OlapSlicerCacheSelections), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class OlapSlicerCache : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "pivotCacheId"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[3]
    {
      "levels",
      "selections",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 53,
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "olap";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13060;

    public override string LocalName
    {
      get
      {
        return "olap";
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
        return 13060;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return OlapSlicerCache.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OlapSlicerCache.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public OlapSlicerCache()
    {
    }

    public OlapSlicerCache(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OlapSlicerCache(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OlapSlicerCache(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "levels" == name)
        return (OpenXmlElement) new OlapSlicerCacheLevelsData();
      if (53 == (int) namespaceId && "selections" == name)
        return (OpenXmlElement) new OlapSlicerCacheSelections();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OlapSlicerCache.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OlapSlicerCache.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OlapSlicerCacheLevelsData OlapSlicerCacheLevelsData
    {
      get
      {
        return this.GetElement<OlapSlicerCacheLevelsData>(0);
      }
      set
      {
        this.SetElement<OlapSlicerCacheLevelsData>(0, value);
      }
    }

    public OlapSlicerCacheSelections OlapSlicerCacheSelections
    {
      get
      {
        return this.GetElement<OlapSlicerCacheSelections>(1);
      }
      set
      {
        this.SetElement<OlapSlicerCacheSelections>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "pivotCacheId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OlapSlicerCache>(deep);
    }
  }
}
