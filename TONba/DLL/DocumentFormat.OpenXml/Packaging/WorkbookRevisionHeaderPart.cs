// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WorkbookRevisionHeaderPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class WorkbookRevisionHeaderPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml";
    internal const string TargetPathConstant = "revisions";
    internal const string TargetNameConstant = "revisionHeaders";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Headers _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WorkbookRevisionHeaderPart._partConstraint == null)
        WorkbookRevisionHeaderPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog",
            new PartConstraintRule("WorkbookRevisionLogPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionLog+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) WorkbookRevisionHeaderPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WorkbookRevisionHeaderPart._dataPartReferenceConstraint == null)
        WorkbookRevisionHeaderPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WorkbookRevisionHeaderPart._dataPartReferenceConstraint;
    }

    protected internal WorkbookRevisionHeaderPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog":
          return (OpenXmlPart) new WorkbookRevisionLogPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "revisions";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "revisionHeaders";
      }
    }

    public IEnumerable<WorkbookRevisionLogPart> WorkbookRevisionLogParts
    {
      get
      {
        return this.GetPartsOfType<WorkbookRevisionLogPart>();
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
        this._rootEle = value as Headers;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Headers;
      }
    }

    public Headers Headers
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Headers>();
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
