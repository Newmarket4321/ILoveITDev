// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.InternationalMacroSheetPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
  public class InternationalMacroSheetPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.intlmacrosheet+xml";
    internal const string TargetPathConstant = "macrosheets";
    internal const string TargetNameConstant = "intlsheet";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (InternationalMacroSheetPart._partConstraint == null)
        InternationalMacroSheetPart._partConstraint = new Dictionary<string, PartConstraintRule>()
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
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty",
            new PartConstraintRule("CustomPropertyPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
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
          }
        };
      return (IDictionary<string, PartConstraintRule>) InternationalMacroSheetPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (InternationalMacroSheetPart._dataPartReferenceConstraint == null)
        InternationalMacroSheetPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) InternationalMacroSheetPart._dataPartReferenceConstraint;
    }

    protected internal InternationalMacroSheetPart()
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
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty":
          return (OpenXmlPart) new CustomPropertyPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
          return (OpenXmlPart) new EmbeddedObjectPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
          return (OpenXmlPart) new EmbeddedPackagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
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

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.intlmacrosheet+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "macrosheets";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "intlsheet";
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

    public IEnumerable<CustomPropertyPart> CustomPropertyParts
    {
      get
      {
        return this.GetPartsOfType<CustomPropertyPart>();
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

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return true;
      }
    }
  }
}
