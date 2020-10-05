// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.TableDefinitionPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class TableDefinitionPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml";
    internal const string TargetPathConstant = "../tables";
    internal const string TargetNameConstant = "table";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Table _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (TableDefinitionPart._partConstraint == null)
        TableDefinitionPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable",
            new PartConstraintRule("QueryTablePart", "application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) TableDefinitionPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (TableDefinitionPart._dataPartReferenceConstraint == null)
        TableDefinitionPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) TableDefinitionPart._dataPartReferenceConstraint;
    }

    protected internal TableDefinitionPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable":
          return (OpenXmlPart) new QueryTablePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "../tables";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "table";
      }
    }

    public IEnumerable<QueryTablePart> QueryTableParts
    {
      get
      {
        return this.GetPartsOfType<QueryTablePart>();
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
        this._rootEle = value as Table;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Table;
      }
    }

    public Table Table
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Table>();
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
