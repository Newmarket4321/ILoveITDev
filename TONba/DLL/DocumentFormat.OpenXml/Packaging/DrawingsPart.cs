// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DrawingsPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DrawingsPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawing+xml";
    internal const string TargetPathConstant = "../drawings";
    internal const string TargetNameConstant = "drawing";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private WorksheetDrawing _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (DrawingsPart._partConstraint == null)
        DrawingsPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
            new PartConstraintRule("ChartPart", "application/vnd.openxmlformats-officedocument.drawingml.chart+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",
            new PartConstraintRule("DiagramColorsPart", "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",
            new PartConstraintRule("DiagramDataPart", "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing",
            new PartConstraintRule("DiagramPersistLayoutPart", "application/vnd.ms-office.drawingml.diagramDrawing+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",
            new PartConstraintRule("DiagramLayoutDefinitionPart", "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",
            new PartConstraintRule("DiagramStylePart", "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
            new PartConstraintRule("ImagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
            new PartConstraintRule("CustomXmlPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/webextension",
            new PartConstraintRule("WebExtensionPart", "application/vnd.ms-office.webextension+xml", false, true, FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) DrawingsPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (DrawingsPart._dataPartReferenceConstraint == null)
        DrawingsPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) DrawingsPart._dataPartReferenceConstraint;
    }

    protected internal DrawingsPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart":
          return (OpenXmlPart) new ChartPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors":
          return (OpenXmlPart) new DiagramColorsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData":
          return (OpenXmlPart) new DiagramDataPart();
        case "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing":
          return (OpenXmlPart) new DiagramPersistLayoutPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout":
          return (OpenXmlPart) new DiagramLayoutDefinitionPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle":
          return (OpenXmlPart) new DiagramStylePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml":
          return (OpenXmlPart) new CustomXmlPart();
        case "http://schemas.microsoft.com/office/2011/relationships/webextension":
          return (OpenXmlPart) new WebExtensionPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
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

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.drawing+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../drawings";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "drawing";
      }
    }

    public IEnumerable<ChartPart> ChartParts
    {
      get
      {
        return this.GetPartsOfType<ChartPart>();
      }
    }

    public IEnumerable<DiagramColorsPart> DiagramColorsParts
    {
      get
      {
        return this.GetPartsOfType<DiagramColorsPart>();
      }
    }

    public IEnumerable<DiagramDataPart> DiagramDataParts
    {
      get
      {
        return this.GetPartsOfType<DiagramDataPart>();
      }
    }

    public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
    {
      get
      {
        return this.GetPartsOfType<DiagramPersistLayoutPart>();
      }
    }

    public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
    {
      get
      {
        return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
      }
    }

    public IEnumerable<DiagramStylePart> DiagramStyleParts
    {
      get
      {
        return this.GetPartsOfType<DiagramStylePart>();
      }
    }

    public IEnumerable<ImagePart> ImageParts
    {
      get
      {
        return this.GetPartsOfType<ImagePart>();
      }
    }

    public IEnumerable<CustomXmlPart> CustomXmlParts
    {
      get
      {
        return this.GetPartsOfType<CustomXmlPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public IEnumerable<WebExtensionPart> WebExtensionParts
    {
      get
      {
        return this.GetPartsOfType<WebExtensionPart>();
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
        this._rootEle = value as WorksheetDrawing;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.WorksheetDrawing;
      }
    }

    public WorksheetDrawing WorksheetDrawing
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<WorksheetDrawing>();
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
