// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WorkbookPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class WorkbookPart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    internal const string TargetPathConstant = "xl";
    internal const string TargetNameConstant = "workbook";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Workbook _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WorkbookPart._partConstraint == null)
        WorkbookPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
            new PartConstraintRule("CustomXmlPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain",
            new PartConstraintRule("CalculationChainPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata",
            new PartConstraintRule("CellMetadataPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections",
            new PartConstraintRule("ConnectionsPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.connections+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps",
            new PartConstraintRule("CustomXmlMappingsPart", "application/xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings",
            new PartConstraintRule("SharedStringTablePart", "application/vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders",
            new PartConstraintRule("WorkbookRevisionHeaderPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames",
            new PartConstraintRule("WorkbookUserDataPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.userNames+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
            new PartConstraintRule("WorkbookStylesPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
            new PartConstraintRule("ThemePart", "application/vnd.openxmlformats-officedocument.theme+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail",
            new PartConstraintRule("ThumbnailPart", (string) null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies",
            new PartConstraintRule("VolatileDependenciesPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.volatileDependencies+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet",
            new PartConstraintRule("ChartsheetPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet",
            new PartConstraintRule("DialogsheetPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink",
            new PartConstraintRule("ExternalWorkbookPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition",
            new PartConstraintRule("PivotTableCacheDefinitionPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
            new PartConstraintRule("WorksheetPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars",
            new PartConstraintRule("ExcelAttachedToolbarsPart", "application/vnd.ms-excel.attachedToolbars", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
            new PartConstraintRule("VbaProjectPart", "application/vnd.ms-office.vbaProject", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet",
            new PartConstraintRule("MacroSheetPart", "application/vnd.ms-excel.macrosheet+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet",
            new PartConstraintRule("InternationalMacroSheetPart", "application/vnd.ms-excel.intlmacrosheet+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/customDataProps",
            new PartConstraintRule("CustomDataPropertiesPart", "application/vnd.ms-excel.customDataProperties+xml", false, true, FileFormatVersions.Office2010)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/slicerCache",
            new PartConstraintRule("SlicerCachePart", "application/vnd.ms-excel.slicerCache+xml", false, true, FileFormatVersions.Office2010)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/timelineCache",
            new PartConstraintRule("TimeLineCachePart", "application/vnd.ms-excel.timelineCache+xml", false, true, FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) WorkbookPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WorkbookPart._dataPartReferenceConstraint == null)
        WorkbookPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WorkbookPart._dataPartReferenceConstraint;
    }

    protected internal WorkbookPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml":
          return (OpenXmlPart) new CustomXmlPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain":
          return (OpenXmlPart) new CalculationChainPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata":
          return (OpenXmlPart) new CellMetadataPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections":
          return (OpenXmlPart) new ConnectionsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps":
          return (OpenXmlPart) new CustomXmlMappingsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings":
          return (OpenXmlPart) new SharedStringTablePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders":
          return (OpenXmlPart) new WorkbookRevisionHeaderPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames":
          return (OpenXmlPart) new WorkbookUserDataPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles":
          return (OpenXmlPart) new WorkbookStylesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme":
          return (OpenXmlPart) new ThemePart();
        case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail":
          return (OpenXmlPart) new ThumbnailPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies":
          return (OpenXmlPart) new VolatileDependenciesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet":
          return (OpenXmlPart) new ChartsheetPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet":
          return (OpenXmlPart) new DialogsheetPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink":
          return (OpenXmlPart) new ExternalWorkbookPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition":
          return (OpenXmlPart) new PivotTableCacheDefinitionPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet":
          return (OpenXmlPart) new WorksheetPart();
        case "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars":
          return (OpenXmlPart) new ExcelAttachedToolbarsPart();
        case "http://schemas.microsoft.com/office/2006/relationships/vbaProject":
          return (OpenXmlPart) new VbaProjectPart();
        case "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet":
          return (OpenXmlPart) new MacroSheetPart();
        case "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet":
          return (OpenXmlPart) new InternationalMacroSheetPart();
        case "http://schemas.microsoft.com/office/2007/relationships/customDataProps":
          return (OpenXmlPart) new CustomDataPropertiesPart();
        case "http://schemas.microsoft.com/office/2007/relationships/slicerCache":
          return (OpenXmlPart) new SlicerCachePart();
        case "http://schemas.microsoft.com/office/2011/relationships/timelineCache":
          return (OpenXmlPart) new TimeLineCachePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
      CustomXmlPart newPart = new CustomXmlPart();
      this.InitPart<CustomXmlPart>(newPart, contentType);
      return newPart;
    }

    public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
      string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
      string targetExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddCustomXmlPart(contentType);
    }

    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
      CustomXmlPart newPart = new CustomXmlPart();
      this.InitPart<CustomXmlPart>(newPart, contentType, id);
      return newPart;
    }

    public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
      string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
      string targetExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddCustomXmlPart(contentType, id);
    }

    public ThumbnailPart AddThumbnailPart(string contentType)
    {
      ThumbnailPart newPart = new ThumbnailPart();
      this.InitPart<ThumbnailPart>(newPart, contentType);
      return newPart;
    }

    public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
    {
      string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
      string targetExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddThumbnailPart(contentType);
    }

    public ThumbnailPart AddThumbnailPart(string contentType, string id)
    {
      ThumbnailPart newPart = new ThumbnailPart();
      this.InitPart<ThumbnailPart>(newPart, contentType, id);
      return newPart;
    }

    public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType, string id)
    {
      string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
      string targetExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddThumbnailPart(contentType, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "xl";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "workbook";
      }
    }

    public IEnumerable<CustomXmlPart> CustomXmlParts
    {
      get
      {
        return this.GetPartsOfType<CustomXmlPart>();
      }
    }

    public CalculationChainPart CalculationChainPart
    {
      get
      {
        return this.GetSubPartOfType<CalculationChainPart>();
      }
    }

    public CellMetadataPart CellMetadataPart
    {
      get
      {
        return this.GetSubPartOfType<CellMetadataPart>();
      }
    }

    public ConnectionsPart ConnectionsPart
    {
      get
      {
        return this.GetSubPartOfType<ConnectionsPart>();
      }
    }

    public CustomXmlMappingsPart CustomXmlMappingsPart
    {
      get
      {
        return this.GetSubPartOfType<CustomXmlMappingsPart>();
      }
    }

    public SharedStringTablePart SharedStringTablePart
    {
      get
      {
        return this.GetSubPartOfType<SharedStringTablePart>();
      }
    }

    public WorkbookRevisionHeaderPart WorkbookRevisionHeaderPart
    {
      get
      {
        return this.GetSubPartOfType<WorkbookRevisionHeaderPart>();
      }
    }

    public WorkbookUserDataPart WorkbookUserDataPart
    {
      get
      {
        return this.GetSubPartOfType<WorkbookUserDataPart>();
      }
    }

    public WorkbookStylesPart WorkbookStylesPart
    {
      get
      {
        return this.GetSubPartOfType<WorkbookStylesPart>();
      }
    }

    public ThemePart ThemePart
    {
      get
      {
        return this.GetSubPartOfType<ThemePart>();
      }
    }

    public ThumbnailPart ThumbnailPart
    {
      get
      {
        return this.GetSubPartOfType<ThumbnailPart>();
      }
    }

    public VolatileDependenciesPart VolatileDependenciesPart
    {
      get
      {
        return this.GetSubPartOfType<VolatileDependenciesPart>();
      }
    }

    public IEnumerable<ChartsheetPart> ChartsheetParts
    {
      get
      {
        return this.GetPartsOfType<ChartsheetPart>();
      }
    }

    public IEnumerable<DialogsheetPart> DialogsheetParts
    {
      get
      {
        return this.GetPartsOfType<DialogsheetPart>();
      }
    }

    public IEnumerable<ExternalWorkbookPart> ExternalWorkbookParts
    {
      get
      {
        return this.GetPartsOfType<ExternalWorkbookPart>();
      }
    }

    public IEnumerable<PivotTableCacheDefinitionPart> PivotTableCacheDefinitionParts
    {
      get
      {
        return this.GetPartsOfType<PivotTableCacheDefinitionPart>();
      }
    }

    public IEnumerable<WorksheetPart> WorksheetParts
    {
      get
      {
        return this.GetPartsOfType<WorksheetPart>();
      }
    }

    public ExcelAttachedToolbarsPart ExcelAttachedToolbarsPart
    {
      get
      {
        return this.GetSubPartOfType<ExcelAttachedToolbarsPart>();
      }
    }

    public VbaProjectPart VbaProjectPart
    {
      get
      {
        return this.GetSubPartOfType<VbaProjectPart>();
      }
    }

    public IEnumerable<MacroSheetPart> MacroSheetParts
    {
      get
      {
        return this.GetPartsOfType<MacroSheetPart>();
      }
    }

    public IEnumerable<InternationalMacroSheetPart> InternationalMacroSheetParts
    {
      get
      {
        return this.GetPartsOfType<InternationalMacroSheetPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public IEnumerable<CustomDataPropertiesPart> CustomDataPropertiesParts
    {
      get
      {
        return this.GetPartsOfType<CustomDataPropertiesPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public IEnumerable<SlicerCachePart> SlicerCacheParts
    {
      get
      {
        return this.GetPartsOfType<SlicerCachePart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public IEnumerable<TimeLineCachePart> TimeLineCacheParts
    {
      get
      {
        return this.GetPartsOfType<TimeLineCachePart>();
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return false;
      }
    }

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as Workbook;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Workbook;
      }
    }

    public Workbook Workbook
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Workbook>();
        return this._rootEle;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }
  }
}
