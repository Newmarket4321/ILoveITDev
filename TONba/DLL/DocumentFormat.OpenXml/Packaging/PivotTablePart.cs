// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PivotTablePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class PivotTablePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml";
    internal const string TargetPathConstant = "../pivotTables";
    internal const string TargetNameConstant = "pivotTable";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private PivotTableDefinition _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (PivotTablePart._partConstraint == null)
        PivotTablePart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition",
            new PartConstraintRule("PivotTableCacheDefinitionPart", "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml", true, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) PivotTablePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (PivotTablePart._dataPartReferenceConstraint == null)
        PivotTablePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) PivotTablePart._dataPartReferenceConstraint;
    }

    protected internal PivotTablePart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition":
          return (OpenXmlPart) new PivotTableCacheDefinitionPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../pivotTables";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "pivotTable";
      }
    }

    public PivotTableCacheDefinitionPart PivotTableCacheDefinitionPart
    {
      get
      {
        return this.GetSubPartOfType<PivotTableCacheDefinitionPart>();
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
        this._rootEle = value as PivotTableDefinition;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.PivotTableDefinition;
      }
    }

    public PivotTableDefinition PivotTableDefinition
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<PivotTableDefinition>();
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
