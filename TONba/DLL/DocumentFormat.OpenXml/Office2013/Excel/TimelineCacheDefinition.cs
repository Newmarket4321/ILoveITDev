// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheDefinition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (TimelineState), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TimelineCachePivotTables), FileFormatVersions.Office2013)]
  public class TimelineCacheDefinition : OpenXmlPartRootElement
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
      "state",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 71,
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "timelineCacheDefinition";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13387;

    public override string LocalName
    {
      get
      {
        return "timelineCacheDefinition";
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
        return 13387;
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
        return TimelineCacheDefinition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TimelineCacheDefinition.attributeNamespaceIds;
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

    internal TimelineCacheDefinition(TimeLineCachePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(TimeLineCachePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public TimeLineCachePart TimeLineCachePart
    {
      get
      {
        return this.OpenXmlPart as TimeLineCachePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public TimelineCacheDefinition(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimelineCacheDefinition(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimelineCacheDefinition(string outerXml)
      : base(outerXml)
    {
    }

    public TimelineCacheDefinition()
    {
    }

    public void Save(TimeLineCachePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "pivotTables" == name)
        return (OpenXmlElement) new TimelineCachePivotTables();
      if (71 == (int) namespaceId && "state" == name)
        return (OpenXmlElement) new TimelineState();
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TimelineCacheDefinition.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TimelineCacheDefinition.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TimelineCachePivotTables TimelineCachePivotTables
    {
      get
      {
        return this.GetElement<TimelineCachePivotTables>(0);
      }
      set
      {
        this.SetElement<TimelineCachePivotTables>(0, value);
      }
    }

    public TimelineState TimelineState
    {
      get
      {
        return this.GetElement<TimelineState>(1);
      }
      set
      {
        this.SetElement<TimelineState>(1, value);
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
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sourceName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimelineCacheDefinition>(deep);
    }
  }
}
