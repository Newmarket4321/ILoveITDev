// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.SlicerCachePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class SlicerCachePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/slicerCache";
    internal const string ContentTypeConstant = "application/vnd.ms-excel.slicerCache+xml";
    internal const string TargetPathConstant = "slicerCaches";
    internal const string TargetNameConstant = "slicerCache";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SlicerCacheDefinition _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (SlicerCachePart._partConstraint == null)
        SlicerCachePart._partConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SlicerCachePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (SlicerCachePart._dataPartReferenceConstraint == null)
        SlicerCachePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SlicerCachePart._dataPartReferenceConstraint;
    }

    protected internal SlicerCachePart()
    {
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.microsoft.com/office/2007/relationships/slicerCache";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.ms-excel.slicerCache+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "slicerCaches";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "slicerCache";
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return version == FileFormatVersions.Office2010;
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
        this._rootEle = value as SlicerCacheDefinition;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.SlicerCacheDefinition;
      }
    }

    public SlicerCacheDefinition SlicerCacheDefinition
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<SlicerCacheDefinition>();
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
