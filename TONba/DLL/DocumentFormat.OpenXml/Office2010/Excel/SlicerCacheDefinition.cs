// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (SlicerCacheDefinitionExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SlicerCachePivotTables), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SlicerCacheData), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SlicerCacheDefinition : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "name",
      "sourceName"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "pivotTables",
      "data",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 53,
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "slicerCacheDefinition";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12994;

    public override string LocalName
    {
      get
      {
        return "slicerCacheDefinition";
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
        return 12994;
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
        return SlicerCacheDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlicerCacheDefinition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sourceName")]
    public StringValue SourceName
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal SlicerCacheDefinition(SlicerCachePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlicerCachePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlicerCachePart SlicerCachePart
    {
      get
      {
        return this.OpenXmlPart as SlicerCachePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public SlicerCacheDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlicerCacheDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlicerCacheDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public SlicerCacheDefinition()
    {
    }

    public void Save(SlicerCachePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "pivotTables" == name)
        return (OpenXmlElement) new SlicerCachePivotTables();
      if (53 == (int) namespaceId && "data" == name)
        return (OpenXmlElement) new SlicerCacheData();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new SlicerCacheDefinitionExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SlicerCacheDefinition.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SlicerCacheDefinition.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SlicerCachePivotTables SlicerCachePivotTables
    {
      get
      {
        return this.GetElement<SlicerCachePivotTables>(0);
      }
      set
      {
        this.SetElement<SlicerCachePivotTables>(0, value);
      }
    }

    public SlicerCacheData SlicerCacheData
    {
      get
      {
        return this.GetElement<SlicerCacheData>(1);
      }
      set
      {
        this.SetElement<SlicerCacheData>(1, value);
      }
    }

    public SlicerCacheDefinitionExtensionList SlicerCacheDefinitionExtensionList
    {
      get
      {
        return this.GetElement<SlicerCacheDefinitionExtensionList>(2);
      }
      set
      {
        this.SetElement<SlicerCacheDefinitionExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sourceName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerCacheDefinition>(deep);
    }
  }
}
