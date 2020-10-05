// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class PivotTableCacheDefinitionPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml";
    internal const string TargetPathConstant = "../pivotCache";
    internal const string TargetNameConstant = "pivotCacheDefinition";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private PivotCacheDefinition _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (PivotTableCacheDefinitionPart._partConstraint == null)
        PivotTableCacheDefinitionPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords",
            new PartConstraintRule("PivotTableCacheRecordsPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) PivotTableCacheDefinitionPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (PivotTableCacheDefinitionPart._dataPartReferenceConstraint == null)
        PivotTableCacheDefinitionPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) PivotTableCacheDefinitionPart._dataPartReferenceConstraint;
    }

    protected internal PivotTableCacheDefinitionPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords":
          return (OpenXmlPart) new PivotTableCacheRecordsPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../pivotCache";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "pivotCacheDefinition";
      }
    }

    public PivotTableCacheRecordsPart PivotTableCacheRecordsPart
    {
      get
      {
        return this.GetSubPartOfType<PivotTableCacheRecordsPart>();
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
        this._rootEle = value as PivotCacheDefinition;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.PivotCacheDefinition;
      }
    }

    public PivotCacheDefinition PivotCacheDefinition
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<PivotCacheDefinition>();
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
