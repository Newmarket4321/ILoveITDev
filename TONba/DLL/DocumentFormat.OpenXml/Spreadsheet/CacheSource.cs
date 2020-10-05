// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CacheSource
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Consolidation))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CacheSourceExtensionList))]
  [ChildElementInfo(typeof (WorksheetSource))]
  public class CacheSource : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "type",
      "connectionId"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[3]
    {
      "worksheetSource",
      "consolidation",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "cacheSource";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11448;

    public override string LocalName
    {
      get
      {
        return "cacheSource";
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
        return 11448;
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
        return CacheSource.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CacheSource.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<SourceValues> Type
    {
      get
      {
        return (EnumValue<SourceValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "connectionId")]
    public UInt32Value ConnectionId
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public CacheSource()
    {
    }

    public CacheSource(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CacheSource(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CacheSource(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "worksheetSource" == name)
        return (OpenXmlElement) new WorksheetSource();
      if (22 == (int) namespaceId && "consolidation" == name)
        return (OpenXmlElement) new Consolidation();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new CacheSourceExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CacheSource.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CacheSource.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public WorksheetSource WorksheetSource
    {
      get
      {
        return this.GetElement<WorksheetSource>(0);
      }
      set
      {
        this.SetElement<WorksheetSource>(0, value);
      }
    }

    public Consolidation Consolidation
    {
      get
      {
        return this.GetElement<Consolidation>(1);
      }
      set
      {
        this.SetElement<Consolidation>(1, value);
      }
    }

    public CacheSourceExtensionList CacheSourceExtensionList
    {
      get
      {
        return this.GetElement<CacheSourceExtensionList>(2);
      }
      set
      {
        this.SetElement<CacheSourceExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<SourceValues>();
      if ((int) namespaceId == 0 && "connectionId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CacheSource>(deep);
    }
  }
}
