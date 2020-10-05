// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class WorksheetSortMapPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/wsSortMap";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.wsSortMap+xml";
    internal const string TargetPathConstant = ".";
    internal const string TargetNameConstant = "wsSortMap";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private WorksheetSortMap _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (WorksheetSortMapPart._partConstraint == null)
        WorksheetSortMapPart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WorksheetSortMapPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (WorksheetSortMapPart._dataPartReferenceConstraint == null)
        WorksheetSortMapPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) WorksheetSortMapPart._dataPartReferenceConstraint;
    }

    protected internal WorksheetSortMapPart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2006/relationships/wsSortMap";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.wsSortMap+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return ".";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "wsSortMap";
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
        this._rootEle = value as WorksheetSortMap;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.WorksheetSortMap;
      }
    }

    public WorksheetSortMap WorksheetSortMap
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<WorksheetSortMap>();
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
