// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.PivotCacheIdVersion
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class PivotCacheIdVersion : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "cacheIdSupportedVersion",
      "cacheIdCreatedVersion"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "pivotCacheIdVersion";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13375;

    public override string LocalName
    {
      get
      {
        return "pivotCacheIdVersion";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13375;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return PivotCacheIdVersion.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotCacheIdVersion.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "cacheIdSupportedVersion")]
    public ByteValue CacheIdSupportedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cacheIdCreatedVersion")]
    public ByteValue CacheIdCreatedVersion
    {
      get
      {
        return (ByteValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "cacheIdSupportedVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "cacheIdCreatedVersion" == name)
        return (OpenXmlSimpleType) new ByteValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotCacheIdVersion>(deep);
    }
  }
}
