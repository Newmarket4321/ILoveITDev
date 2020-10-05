// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.MapInfo
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Map))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Schema))]
  public class MapInfo : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      nameof (SelectionNamespaces)
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "MapInfo";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11095;

    public override string LocalName
    {
      get
      {
        return nameof (MapInfo);
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
        return 11095;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return MapInfo.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MapInfo.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "SelectionNamespaces")]
    public StringValue SelectionNamespaces
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

    internal MapInfo(CustomXmlMappingsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomXmlMappingsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CustomXmlMappingsPart CustomXmlMappingsPart
    {
      get
      {
        return this.OpenXmlPart as CustomXmlMappingsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public MapInfo(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MapInfo(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MapInfo(string outerXml)
      : base(outerXml)
    {
    }

    public MapInfo()
    {
    }

    public void Save(CustomXmlMappingsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "Schema" == name)
        return (OpenXmlElement) new Schema();
      if (22 == (int) namespaceId && "Map" == name)
        return (OpenXmlElement) new Map();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "SelectionNamespaces" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MapInfo>(deep);
    }
  }
}
