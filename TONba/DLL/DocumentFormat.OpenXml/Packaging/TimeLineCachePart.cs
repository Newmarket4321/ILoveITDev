// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.TimeLineCachePart
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
  public class TimeLineCachePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/timelineCache";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.timelineCache+xml";
    internal const string TargetPathConstant = "timelineCaches";
    internal const string TargetNameConstant = "timelineCache";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private TimelineCacheDefinition _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (TimeLineCachePart._partConstraint == null)
        TimeLineCachePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) TimeLineCachePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (TimeLineCachePart._dataPartReferenceConstraint == null)
        TimeLineCachePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) TimeLineCachePart._dataPartReferenceConstraint;
    }

    protected internal TimeLineCachePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2011/relationships/timelineCache";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.timelineCache+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "timelineCaches";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "timelineCache";
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
        this._rootEle = value as TimelineCacheDefinition;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.TimelineCacheDefinition;
      }
    }

    public TimelineCacheDefinition TimelineCacheDefinition
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<TimelineCacheDefinition>();
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
