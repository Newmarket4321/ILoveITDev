// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.WorksheetSortMap
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [ChildElementInfo(typeof (ColumnSortMap))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RowSortMap))]
  public class WorksheetSortMap : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "rowSortMap",
      "colSortMap"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 32,
      (byte) 32
    };
    private const string tagName = "worksheetSortMap";
    private const byte tagNsId = 32;
    internal const int ElementTypeIdConst = 12601;

    public override string LocalName
    {
      get
      {
        return "worksheetSortMap";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 32;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12601;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal WorksheetSortMap(WorksheetSortMapPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorksheetSortMapPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorksheetSortMapPart WorksheetSortMapPart
    {
      get
      {
        return this.OpenXmlPart as WorksheetSortMapPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public WorksheetSortMap(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WorksheetSortMap(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WorksheetSortMap(string outerXml)
      : base(outerXml)
    {
    }

    public WorksheetSortMap()
    {
    }

    public void Save(WorksheetSortMapPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (32 == (int) namespaceId && "rowSortMap" == name)
        return (OpenXmlElement) new RowSortMap();
      if (32 == (int) namespaceId && "colSortMap" == name)
        return (OpenXmlElement) new ColumnSortMap();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WorksheetSortMap.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WorksheetSortMap.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RowSortMap RowSortMap
    {
      get
      {
        return this.GetElement<RowSortMap>(0);
      }
      set
      {
        this.SetElement<RowSortMap>(0, value);
      }
    }

    public ColumnSortMap ColumnSortMap
    {
      get
      {
        return this.GetElement<ColumnSortMap>(1);
      }
      set
      {
        this.SetElement<ColumnSortMap>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WorksheetSortMap>(deep);
    }
  }
}
