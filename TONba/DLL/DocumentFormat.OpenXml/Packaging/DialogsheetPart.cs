// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.DialogsheetPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class DialogsheetPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml";
    internal const string TargetPathConstant = "dialogsheets";
    internal const string TargetNameConstant = "sheet";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DialogSheet _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (DialogsheetPart._partConstraint == null)
        DialogsheetPart._partConstraint = new Dictionary<string, PartConstraintRule>()
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
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
            new PartConstraintRule("EmbeddedObjectPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) DialogsheetPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (DialogsheetPart._dataPartReferenceConstraint == null)
        DialogsheetPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) DialogsheetPart._dataPartReferenceConstraint;
    }

    protected internal DialogsheetPart()
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
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
          return (OpenXmlPart) new EmbeddedObjectPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
      EmbeddedObjectPart newPart = new EmbeddedObjectPart();
      this.InitPart<EmbeddedObjectPart>(newPart, contentType);
      return newPart;
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "dialogsheets";
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

    public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedObjectPart>();
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
        this._rootEle = value as DialogSheet;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.DialogSheet;
      }
    }

    public DialogSheet DialogSheet
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<DialogSheet>();
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
