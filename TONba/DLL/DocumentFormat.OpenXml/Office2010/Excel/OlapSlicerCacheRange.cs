// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheRange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (OlapSlicerCacheItem), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class OlapSlicerCacheRange : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "startItem"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "range";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13065;

    public override string LocalName
    {
      get
      {
        return "range";
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
        return 13065;
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
        return OlapSlicerCacheRange.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OlapSlicerCacheRange.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "startItem")]
    public UInt32Value StartItem
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

    public OlapSlicerCacheRange()
    {
    }

    public OlapSlicerCacheRange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OlapSlicerCacheRange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OlapSlicerCacheRange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "i" == name)
        return (OpenXmlElement) new OlapSlicerCacheItem();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "startItem" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OlapSlicerCacheRange>(deep);
    }
  }
}
