// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.TimeLinePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class TimeLinePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/timeline";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.timeline+xml";
    internal const string TargetPathConstant = "../timelines";
    internal const string TargetNameConstant = "timeline";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Timelines _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (TimeLinePart._partConstraint == null)
        TimeLinePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) TimeLinePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (TimeLinePart._dataPartReferenceConstraint == null)
        TimeLinePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) TimeLinePart._dataPartReferenceConstraint;
    }

    protected internal TimeLinePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2011/relationships/timeline";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.timeline+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../timelines";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "timeline";
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return version == FileFormatVersions.Office2013;
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
        this._rootEle = value as Timelines;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Timelines;
      }
    }

    public Timelines Timelines
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Timelines>();
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
