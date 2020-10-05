// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DropZoneFilter), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DropZoneCategories), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DropZoneData), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DropZoneSeries), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DropZonesVisible), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class PivotOptions : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "dropZoneFilter",
      "dropZoneCategories",
      "dropZoneData",
      "dropZoneSeries",
      "dropZonesVisible"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 46,
      (byte) 46,
      (byte) 46,
      (byte) 46,
      (byte) 46
    };
    private const string tagName = "pivotOptions";
    private const byte tagNsId = 46;
    internal const int ElementTypeIdConst = 12762;

    public override string LocalName
    {
      get
      {
        return "pivotOptions";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 46;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12762;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PivotOptions()
    {
    }

    public PivotOptions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotOptions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotOptions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (46 == (int) namespaceId && "dropZoneFilter" == name)
        return (OpenXmlElement) new DropZoneFilter();
      if (46 == (int) namespaceId && "dropZoneCategories" == name)
        return (OpenXmlElement) new DropZoneCategories();
      if (46 == (int) namespaceId && "dropZoneData" == name)
        return (OpenXmlElement) new DropZoneData();
      if (46 == (int) namespaceId && "dropZoneSeries" == name)
        return (OpenXmlElement) new DropZoneSeries();
      if (46 == (int) namespaceId && "dropZonesVisible" == name)
        return (OpenXmlElement) new DropZonesVisible();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PivotOptions.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PivotOptions.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DropZoneFilter DropZoneFilter
    {
      get
      {
        return this.GetElement<DropZoneFilter>(0);
      }
      set
      {
        this.SetElement<DropZoneFilter>(0, value);
      }
    }

    public DropZoneCategories DropZoneCategories
    {
      get
      {
        return this.GetElement<DropZoneCategories>(1);
      }
      set
      {
        this.SetElement<DropZoneCategories>(1, value);
      }
    }

    public DropZoneData DropZoneData
    {
      get
      {
        return this.GetElement<DropZoneData>(2);
      }
      set
      {
        this.SetElement<DropZoneData>(2, value);
      }
    }

    public DropZoneSeries DropZoneSeries
    {
      get
      {
        return this.GetElement<DropZoneSeries>(3);
      }
      set
      {
        this.SetElement<DropZoneSeries>(3, value);
      }
    }

    public DropZonesVisible DropZonesVisible
    {
      get
      {
        return this.GetElement<DropZonesVisible>(4);
      }
      set
      {
        this.SetElement<DropZonesVisible>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotOptions>(deep);
    }
  }
}
