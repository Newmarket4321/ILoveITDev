// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.ChartDrawingPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class ChartDrawingPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml";
    internal const string TargetPathConstant = "../drawings";
    internal const string TargetNameConstant = "drawing";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private UserShapes _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (ChartDrawingPart._partConstraint == null)
        ChartDrawingPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
            new PartConstraintRule("ChartPart", "application/vnd.openxmlformats-officedocument.drawingml.chart+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
            new PartConstraintRule("ImagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) ChartDrawingPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (ChartDrawingPart._dataPartReferenceConstraint == null)
        ChartDrawingPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) ChartDrawingPart._dataPartReferenceConstraint;
    }

    protected internal ChartDrawingPart()
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
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
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

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml";
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

    public ChartPart ChartPart
    {
      get
      {
        return this.GetSubPartOfType<ChartPart>();
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

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as UserShapes;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.UserShapes;
      }
    }

    public UserShapes UserShapes
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<UserShapes>();
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
