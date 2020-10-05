// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WorksheetPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class WorksheetPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml";
    internal const string TargetPathConstant = "worksheets";
    internal const string TargetNameConstant = "sheet";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Worksheet _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WorksheetPart._partConstraint == null)
        WorksheetPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
            new PartConstraintRule("SpreadsheetPrinterSettingsPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing",
            new PartConstraintRule("DrawingsPart", "application/vnd.openxmlformats-officedocument.drawing+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing",
            new PartConstraintRule("VmlDrawingPart", "application/vnd.openxmlformats-officedocument.vmlDrawing", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
            new PartConstraintRule("WorksheetCommentsPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable",
            new PartConstraintRule("PivotTablePart", "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells",
            new PartConstraintRule("SingleCellTablePart", "application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table",
            new PartConstraintRule("TableDefinitionPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
            new PartConstraintRule("EmbeddedControlPersistencePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp",
            new PartConstraintRule("ControlPropertiesPart", "application/vnd.ms-excel.controlproperties+xml", false, true, FileFormatVersions.Office2010)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
            new PartConstraintRule("EmbeddedObjectPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
            new PartConstraintRule("EmbeddedPackagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
            new PartConstraintRule("ImagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty",
            new PartConstraintRule("CustomPropertyPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/wsSortMap",
            new PartConstraintRule("WorksheetSortMapPart", "application/vnd.ms-excel.wsSortMap+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable",
            new PartConstraintRule("QueryTablePart", "application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary",
            new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/slicer",
            new PartConstraintRule("SlicersPart", "application/vnd.ms-excel.slicer+xml", false, true, FileFormatVersions.Office2010)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/timeline",
            new PartConstraintRule("TimeLinePart", "application/vnd.ms-excel.timeline+xml", false, true, FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) WorksheetPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WorksheetPart._dataPartReferenceConstraint == null)
        WorksheetPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WorksheetPart._dataPartReferenceConstraint;
    }

    protected internal WorksheetPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings":
          return (OpenXmlPart) new SpreadsheetPrinterSettingsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing":
          return (OpenXmlPart) new DrawingsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing":
          return (OpenXmlPart) new VmlDrawingPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments":
          return (OpenXmlPart) new WorksheetCommentsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable":
          return (OpenXmlPart) new PivotTablePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells":
          return (OpenXmlPart) new SingleCellTablePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table":
          return (OpenXmlPart) new TableDefinitionPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control":
          return (OpenXmlPart) new EmbeddedControlPersistencePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp":
          return (OpenXmlPart) new ControlPropertiesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
          return (OpenXmlPart) new EmbeddedObjectPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
          return (OpenXmlPart) new EmbeddedPackagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty":
          return (OpenXmlPart) new CustomPropertyPart();
        case "http://schemas.microsoft.com/office/2006/relationships/wsSortMap":
          return (OpenXmlPart) new WorksheetSortMapPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable":
          return (OpenXmlPart) new QueryTablePart();
        case "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary":
          return (OpenXmlPart) new EmbeddedControlPersistenceBinaryDataPart();
        case "http://schemas.microsoft.com/office/2007/relationships/slicer":
          return (OpenXmlPart) new SlicersPart();
        case "http://schemas.microsoft.com/office/2011/relationships/timeline":
          return (OpenXmlPart) new TimeLinePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
      EmbeddedControlPersistencePart newPart = new EmbeddedControlPersistencePart();
      this.InitPart<EmbeddedControlPersistencePart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
      string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistencePart(contentType);
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
      EmbeddedControlPersistencePart newPart = new EmbeddedControlPersistencePart();
      this.InitPart<EmbeddedControlPersistencePart>(newPart, contentType, id);
      return newPart;
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
      string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistencePart(contentType, id);
    }

    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
      EmbeddedObjectPart newPart = new EmbeddedObjectPart();
      this.InitPart<EmbeddedObjectPart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
      EmbeddedPackagePart newPart = new EmbeddedPackagePart();
      this.InitPart<EmbeddedPackagePart>(newPart, contentType);
      return newPart;
    }

    public ImagePart AddImagePart(string contentType)
    {
      ImagePart newPart = new ImagePart();
      this.InitPart<ImagePart>(newPart, contentType);
      return newPart;
    }

    public ImagePart AddImagePart(ImagePartType partType)
    {
      string contentType = ImagePartTypeInfo.GetContentType(partType);
      string targetExtension = ImagePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddImagePart(contentType);
    }

    public ImagePart AddImagePart(string contentType, string id)
    {
      ImagePart newPart = new ImagePart();
      this.InitPart<ImagePart>(newPart, contentType, id);
      return newPart;
    }

    public ImagePart AddImagePart(ImagePartType partType, string id)
    {
      string contentType = ImagePartTypeInfo.GetContentType(partType);
      string targetExtension = ImagePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddImagePart(contentType, id);
    }

    public CustomPropertyPart AddCustomPropertyPart(string contentType)
    {
      CustomPropertyPart newPart = new CustomPropertyPart();
      this.InitPart<CustomPropertyPart>(newPart, contentType);
      return newPart;
    }

    public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType)
    {
      string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
      string targetExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddCustomPropertyPart(contentType);
    }

    public CustomPropertyPart AddCustomPropertyPart(string contentType, string id)
    {
      CustomPropertyPart newPart = new CustomPropertyPart();
      this.InitPart<CustomPropertyPart>(newPart, contentType, id);
      return newPart;
    }

    public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType, string id)
    {
      string contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
      string targetExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddCustomPropertyPart(contentType, id);
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
      EmbeddedControlPersistenceBinaryDataPart newPart = new EmbeddedControlPersistenceBinaryDataPart();
      this.InitPart<EmbeddedControlPersistenceBinaryDataPart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
      string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
      EmbeddedControlPersistenceBinaryDataPart newPart = new EmbeddedControlPersistenceBinaryDataPart();
      this.InitPart<EmbeddedControlPersistenceBinaryDataPart>(newPart, contentType, id);
      return newPart;
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
      string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "worksheets";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "sheet";
      }
    }

    public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts
    {
      get
      {
        return this.GetPartsOfType<SpreadsheetPrinterSettingsPart>();
      }
    }

    public DrawingsPart DrawingsPart
    {
      get
      {
        return this.GetSubPartOfType<DrawingsPart>();
      }
    }

    public IEnumerable<VmlDrawingPart> VmlDrawingParts
    {
      get
      {
        return this.GetPartsOfType<VmlDrawingPart>();
      }
    }

    public WorksheetCommentsPart WorksheetCommentsPart
    {
      get
      {
        return this.GetSubPartOfType<WorksheetCommentsPart>();
      }
    }

    public IEnumerable<PivotTablePart> PivotTableParts
    {
      get
      {
        return this.GetPartsOfType<PivotTablePart>();
      }
    }

    public SingleCellTablePart SingleCellTablePart
    {
      get
      {
        return this.GetSubPartOfType<SingleCellTablePart>();
      }
    }

    public IEnumerable<TableDefinitionPart> TableDefinitionParts
    {
      get
      {
        return this.GetPartsOfType<TableDefinitionPart>();
      }
    }

    public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedControlPersistencePart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public IEnumerable<ControlPropertiesPart> ControlPropertiesParts
    {
      get
      {
        return this.GetPartsOfType<ControlPropertiesPart>();
      }
    }

    public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedObjectPart>();
      }
    }

    public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedPackagePart>();
      }
    }

    public IEnumerable<ImagePart> ImageParts
    {
      get
      {
        return this.GetPartsOfType<ImagePart>();
      }
    }

    public IEnumerable<CustomPropertyPart> CustomPropertyParts
    {
      get
      {
        return this.GetPartsOfType<CustomPropertyPart>();
      }
    }

    public WorksheetSortMapPart WorksheetSortMapPart
    {
      get
      {
        return this.GetSubPartOfType<WorksheetSortMapPart>();
      }
    }

    public IEnumerable<QueryTablePart> QueryTableParts
    {
      get
      {
        return this.GetPartsOfType<QueryTablePart>();
      }
    }

    public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public IEnumerable<SlicersPart> SlicersParts
    {
      get
      {
        return this.GetPartsOfType<SlicersPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public IEnumerable<TimeLinePart> TimeLineParts
    {
      get
      {
        return this.GetPartsOfType<TimeLinePart>();
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return true;
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
        this._rootEle = value as Worksheet;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Worksheet;
      }
    }

    public Worksheet Worksheet
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Worksheet>();
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
