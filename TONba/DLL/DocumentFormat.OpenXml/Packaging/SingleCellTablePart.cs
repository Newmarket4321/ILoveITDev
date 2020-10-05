// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.SingleCellTablePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class SingleCellTablePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml";
    internal const string TargetPathConstant = "../tables";
    internal const string TargetNameConstant = "tableSingleCells";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SingleXmlCells _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (SingleCellTablePart._partConstraint == null)
        SingleCellTablePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SingleCellTablePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (SingleCellTablePart._dataPartReferenceConstraint == null)
        SingleCellTablePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SingleCellTablePart._dataPartReferenceConstraint;
    }

    protected internal SingleCellTablePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml";
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
        return "tableSingleCells";
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
        this._rootEle = value as SingleXmlCells;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.SingleXmlCells;
      }
    }

    public SingleXmlCells SingleXmlCells
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<SingleXmlCells>();
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
