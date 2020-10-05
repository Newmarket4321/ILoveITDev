// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ChartPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class ChartPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
    internal const string TargetPathConstant = "charts";
    internal const string TargetNameConstant = "chart";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ChartSpace _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ChartPart._partConstraint == null)
        ChartPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes",
            new PartConstraintRule("ChartDrawingPart", "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
            new PartConstraintRule("EmbeddedPackagePart", (string) null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
            new PartConstraintRule("ImagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride",
            new PartConstraintRule("ThemeOverridePart", "application/vnd.openxmlformats-officedocument.themeOverride+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/chartStyle",
            new PartConstraintRule("ChartStylePart", "application/vnd.ms-office.chartstyle+xml", false, true, FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle",
            new PartConstraintRule("ChartColorStylePart", "application/vnd.ms-office.chartcolorstyle+xml", false, true, FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) ChartPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ChartPart._dataPartReferenceConstraint == null)
        ChartPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ChartPart._dataPartReferenceConstraint;
    }

    protected internal ChartPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes":
          return (OpenXmlPart) new ChartDrawingPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
          return (OpenXmlPart) new EmbeddedPackagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride":
          return (OpenXmlPart) new ThemeOverridePart();
        case "http://schemas.microsoft.com/office/2011/relationships/chartStyle":
          return (OpenXmlPart) new ChartStylePart();
        case "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle":
          return (OpenXmlPart) new ChartColorStylePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
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
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "charts";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "chart";
      }
    }

    public ChartDrawingPart ChartDrawingPart
    {
      get
      {
        return this.GetSubPartOfType<ChartDrawingPart>();
      }
    }

    public EmbeddedPackagePart EmbeddedPackagePart
    {
      get
      {
        return this.GetSubPartOfType<EmbeddedPackagePart>();
      }
    }

    public IEnumerable<ImagePart> ImageParts
    {
      get
      {
        return this.GetPartsOfType<ImagePart>();
      }
    }

    public ThemeOverridePart ThemeOverridePart
    {
      get
      {
        return this.GetSubPartOfType<ThemeOverridePart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public IEnumerable<ChartStylePart> ChartStyleParts
    {
      get
      {
        return this.GetPartsOfType<ChartStylePart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public IEnumerable<ChartColorStylePart> ChartColorStyleParts
    {
      get
      {
        return this.GetPartsOfType<ChartColorStylePart>();
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
        this._rootEle = value as ChartSpace;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.ChartSpace;
      }
    }

    public ChartSpace ChartSpace
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<ChartSpace>();
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
